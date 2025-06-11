using OfficeOpenXml;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace ExcelToDbTool
{
    public partial class ExcelToDbToolForm : Form
    {
        List<string> tableNames = [];

        public ExcelToDbToolForm()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            tableNames = ReadFileWithEncoding(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config", "tablenames"), Encoding.UTF8);

            string filePath = excelTextBox.Text;
            string sheetName = sheetTextBox.Text;
            string outPath = outputPathTextBox.Text;
            if (string.IsNullOrEmpty(outPath))
            {
                outPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp");
            }

            if (Directory.Exists(outPath))
            {
                Directory.Delete(outPath, true);
            }

            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp"));

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];

                // string cellValue = worksheet.Cells[1, 1].Text;
                // Console.WriteLine("Cell A1 value: " + cellValue);

                List<string> sqls = [];
                for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                {
                    string textB = worksheet.Cells[row, 2].Text;

                    // 检索结束
                    if (worksheet.Cells[row, 1].Text == endTextBox.Text)
                    {
                        break;
                    }
                    if (!tableNames.Contains(textB))
                    {
                        continue;
                    }
                    List<string> strings = new();
                    int rowOfValue = row + int.Parse(distanceTextBox.Text);
                    for (int i = 0; !string.IsNullOrEmpty(worksheet.Cells[rowOfValue + i, 2].Text); i++)
                    {
                        string value = string.Empty;
                        for (int col = 2; !string.IsNullOrEmpty(worksheet.Cells[rowOfValue + i - 1, col].Text) && col <= worksheet.Dimension.End.Column; col++)
                        {
                            string temp = worksheet.Cells[rowOfValue + i, col].Text;
                            if (temp == "NULL")
                            {
                                temp = string.Empty;
                            }
                            if (temp == "True" || temp == "TRUE" || temp == "true")
                            {
                                temp = "1";
                            }
                            if (temp == "False" || temp == "FALSE" || temp == "false")
                            {
                                temp = "0";
                            }
                            if (col == 2)
                            {
                                value += $"{temp}";
                            }
                            else
                            {
                                value += $",{temp}";
                            }
                        }
                        strings.Add(value);
                    }

                    var writeReturnValue = WriteFileWithEncoding(strings, @$"{outPath}\{textB}.csv", Encoding.GetEncoding("shift_jis"));
                    if (writeReturnValue is not null)
                    {
                        MessageBox.Show(writeReturnValue);
                        return;
                    }

                    sqls.Add(@$"BULK INSERT {textB} FROM '{outPath}\{textB}.csv' WITH (FIELDTERMINATOR = ',', ROWTERMINATOR = '0x0D0A', CODEPAGE = '932');");
                }

                string connectionString = $"Data Source={dataSourceTextBox.Text};Database={databaseTextBox.Text};TrustServerCertificate=true;uid={uidTextBox.Text}; pwd={pwdTextBox.Text}; MultipleActiveResultSets=true;Encrypt=False;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            foreach (string sql in sqls)
                            {
                                using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                                {
                                    command.ExecuteNonQuery();
                                    Console.WriteLine($"Executed: {sql}");
                                }
                            }

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                        connection.Close();
                        return;
                    }
                }

                MessageBox.Show("The execution was successful.");
            }

            if (this.commonTableCheckBox.Checked)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 指定要搜索的目录路径
                string directoryPath = inputBox.Text;

                // 使用 Directory.GetFiles 方法获取所有 .csv 文件
                string[] csvFiles = Directory.GetFiles(directoryPath, "*.csv", SearchOption.AllDirectories);

                List<string> sqls = [];
                foreach (string file in csvFiles)
                {
                    string tableName = Path.GetFileNameWithoutExtension(file);
                    sqls.Add(@$"BULK INSERT {tableName} FROM '{file}' WITH (FIELDTERMINATOR = ',', ROWTERMINATOR = '0x0D0A', CODEPAGE = '932');");
                    Console.WriteLine(file);
                }

                string connectionString = $"Data Source={dataSourceTextBox.Text};Database={databaseTextBox.Text};TrustServerCertificate=true;uid={uidTextBox.Text}; pwd={pwdTextBox.Text}; MultipleActiveResultSets=true;Encrypt=False;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        foreach (string sql in sqls)
                        {
                            using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                            {
                                command.ExecuteNonQuery();
                                Console.WriteLine($"Executed: {sql}");
                            }
                        }

                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("The execution was successful.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string outputPath = csvOutputPath.Text;
                if (string.IsNullOrEmpty(outputPath))
                {
                    outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output");
                }

                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                string[] tableNames = tableNameBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                // 定义 bcp 命令的参数
                string bcpCommand = "bcp";

                foreach (string tableName in tableNames)
                {
                    // 构建 bcp 命令行参数
                    string arguments = @$"{databaseTextBox.Text}.dbo.{tableName} out {outputPath}\{tableName}.csv -c -t, -S {dataSourceTextBox.Text} -U {uidTextBox.Text} -P {pwdTextBox.Text} -C 932";

                    // 创建 ProcessStartInfo 对象
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = bcpCommand,
                        Arguments = arguments,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    // 创建 Process 对象并启动
                    using (Process process = new Process { StartInfo = startInfo })
                    {
                        process.Start();

                        // 读取标准输出和错误输出
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        // 等待进程完成
                        process.WaitForExit();

                        // 输出结果
                        // Console.WriteLine("Output:");
                        // Console.WriteLine(output);
                        // Console.WriteLine("Error:");
                        // Console.WriteLine(error);

                        if (process.ExitCode != 0)
                        {
                            MessageBox.Show(output);
                            return;
                        }
                    }
                }

                if (this.deleteTableCheckBox.Checked)
                {
                    string sql = $@"
                        DECLARE @TableName NVARCHAR(MAX);
                        DECLARE @ResetSQL NVARCHAR(MAX);
                        
                        -- 禁用外键检查
                        EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';
                        
                        -- 获取所有表名
                        DECLARE table_cursor CURSOR FOR
                        SELECT name
                        FROM sys.tables;
                        
                        OPEN table_cursor;
                        
                        FETCH NEXT FROM table_cursor INTO @TableName;
                        
                        WHILE @@FETCH_STATUS = 0
                        BEGIN
                            -- 生成重置自增字段ID的SQL语句
                            SET @ResetSQL = 'DBCC CHECKIDENT (' + QUOTENAME(@TableName) + ', RESEED, 0)';
                            EXEC sp_executesql @ResetSQL;
                        
                            -- 删除表中的数据
                            SET @ResetSQL = 'DELETE FROM ' + QUOTENAME(@TableName);
                            EXEC sp_executesql @ResetSQL;
                        
                            FETCH NEXT FROM table_cursor INTO @TableName;
                        END;
                        
                        CLOSE table_cursor;
                        DEALLOCATE table_cursor;
                        
                        -- 启用外键检查
                        EXEC sp_MSforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL';
                        ";

                    string connectionString = $"Data Source={dataSourceTextBox.Text};Database={databaseTextBox.Text};TrustServerCertificate=true;uid={uidTextBox.Text}; pwd={pwdTextBox.Text}; MultipleActiveResultSets=true;Encrypt=False;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                            {
                                command.ExecuteNonQuery();
                                Console.WriteLine($"Executed: {sql}");
                            }
                            transaction.Commit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("The execution was successful.");
        }
        private void excelSelceButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 设置文件过滤：Excel文件
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "选择Excel文件";
                openFileDialog.Multiselect = false; // 单文件选择

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    excelTextBox.Text = filePath;
                }
            }
        }

        public static List<string> ReadFileWithEncoding(string filePath, Encoding encoding)
        {
            List<string> lines = new List<string>();

            // 使用指定的编码读取文件
            using (StreamReader reader = new StreamReader(filePath, encoding))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        static string? WriteFileWithEncoding(List<string> lines, string filePath, Encoding encoding)
        {
            try
            {
                string directory = Path.GetDirectoryName(filePath)!;
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (StreamWriter writer = new StreamWriter(filePath, false, encoding))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;
        }

        static bool IsDateTimeOffsetFormat(string input)
        {
            // 正则表达式，匹配格式为 "2021-11-17 00:00:00.0000000 +09:00" 的字符串
            string pattern = @"^\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}\.\d{7} [+\-]\d{2}:\d{2}$";
            return Regex.IsMatch(input, pattern);
        }

        static bool IsAllDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            return Regex.IsMatch(input, @"^\d+$");
        }
    }
}
