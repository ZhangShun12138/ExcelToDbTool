namespace ExcelToDbTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            excelTextBox = new TextBox();
            sheetTextBox = new TextBox();
            outputPathTextBox = new TextBox();
            dataSourceTextBox = new TextBox();
            databaseTextBox = new TextBox();
            uidTextBox = new TextBox();
            pwdTextBox = new TextBox();
            distanceTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            excelControl = new TabControl();
            tabPage1 = new TabPage();
            commonTableCheckBox = new CheckBox();
            tabPage2 = new TabPage();
            label9 = new Label();
            inputBox = new TextBox();
            button1 = new Button();
            tabPage3 = new TabPage();
            deleteTableCheckBox = new CheckBox();
            button3 = new Button();
            label10 = new Label();
            tableNameBox = new TextBox();
            csvOutputPath = new TextBox();
            label11 = new Label();
            endTextBox = new TextBox();
            panel1 = new Panel();
            excelControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(134, 195);
            button2.Name = "button2";
            button2.Size = new Size(273, 26);
            button2.TabIndex = 1;
            button2.Text = "Run";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // excelTextBox
            // 
            excelTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            excelTextBox.Location = new Point(134, 24);
            excelTextBox.Name = "excelTextBox";
            excelTextBox.Size = new Size(445, 23);
            excelTextBox.TabIndex = 2;
            // 
            // sheetTextBox
            // 
            sheetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sheetTextBox.Location = new Point(134, 78);
            sheetTextBox.Name = "sheetTextBox";
            sheetTextBox.Size = new Size(445, 23);
            sheetTextBox.TabIndex = 3;
            // 
            // outputPathTextBox
            // 
            outputPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputPathTextBox.Location = new Point(134, 133);
            outputPathTextBox.Name = "outputPathTextBox";
            outputPathTextBox.Size = new Size(445, 23);
            outputPathTextBox.TabIndex = 4;
            // 
            // dataSourceTextBox
            // 
            dataSourceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataSourceTextBox.Location = new Point(138, 10);
            dataSourceTextBox.Name = "dataSourceTextBox";
            dataSourceTextBox.Size = new Size(445, 23);
            dataSourceTextBox.TabIndex = 5;
            dataSourceTextBox.Text = "LocalHost\\MSSQLSERVER";
            // 
            // databaseTextBox
            // 
            databaseTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            databaseTextBox.Location = new Point(138, 65);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.Size = new Size(445, 23);
            databaseTextBox.TabIndex = 6;
            // 
            // uidTextBox
            // 
            uidTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uidTextBox.Location = new Point(138, 119);
            uidTextBox.Name = "uidTextBox";
            uidTextBox.Size = new Size(445, 23);
            uidTextBox.TabIndex = 7;
            uidTextBox.Text = "sa";
            // 
            // pwdTextBox
            // 
            pwdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pwdTextBox.Location = new Point(138, 173);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.Size = new Size(445, 23);
            pwdTextBox.TabIndex = 8;
            pwdTextBox.Text = "P@ssw0rd";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            distanceTextBox.Location = new Point(138, 228);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(445, 23);
            distanceTextBox.TabIndex = 9;
            distanceTextBox.Text = "3";
            // 
            // label1
            // 
            label1.Location = new Point(8, 24);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 10;
            label1.Text = "Excel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(8, 78);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 11;
            label2.Text = "Sheet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(8, 133);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 12;
            label3.Text = "OutPath";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(12, 10);
            label4.Name = "label4";
            label4.Size = new Size(76, 26);
            label4.TabIndex = 13;
            label4.Text = "Data Source";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(12, 65);
            label5.Name = "label5";
            label5.Size = new Size(76, 26);
            label5.TabIndex = 14;
            label5.Text = "Database";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(12, 119);
            label6.Name = "label6";
            label6.Size = new Size(76, 26);
            label6.TabIndex = 15;
            label6.Text = "Uid";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(12, 173);
            label7.Name = "label7";
            label7.Size = new Size(76, 26);
            label7.TabIndex = 16;
            label7.Text = "Pwd";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(12, 228);
            label8.Name = "label8";
            label8.Size = new Size(76, 26);
            label8.TabIndex = 17;
            label8.Text = "Distance";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // excelControl
            // 
            excelControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            excelControl.Controls.Add(tabPage1);
            excelControl.Controls.Add(tabPage2);
            excelControl.Controls.Add(tabPage3);
            excelControl.Location = new Point(0, 374);
            excelControl.Name = "excelControl";
            excelControl.SelectedIndex = 0;
            excelControl.Size = new Size(606, 271);
            excelControl.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(commonTableCheckBox);
            tabPage1.Controls.Add(excelTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(outputPathTextBox);
            tabPage1.Controls.Add(sheetTextBox);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(598, 241);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Excel";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // commonTableCheckBox
            // 
            commonTableCheckBox.AutoSize = true;
            commonTableCheckBox.Location = new Point(8, 195);
            commonTableCheckBox.Name = "commonTableCheckBox";
            commonTableCheckBox.Size = new Size(112, 21);
            commonTableCheckBox.TabIndex = 13;
            commonTableCheckBox.Text = "CommonTable";
            commonTableCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(inputBox);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(598, 241);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "File";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Location = new Point(12, 61);
            label9.Name = "label9";
            label9.Size = new Size(76, 26);
            label9.TabIndex = 19;
            label9.Text = "Input";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            inputBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputBox.Location = new Point(134, 61);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(445, 23);
            inputBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(187, 154);
            button1.Name = "button1";
            button1.Size = new Size(171, 26);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(deleteTableCheckBox);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(tableNameBox);
            tabPage3.Controls.Add(csvOutputPath);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(598, 241);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Read";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteTableCheckBox
            // 
            deleteTableCheckBox.AutoSize = true;
            deleteTableCheckBox.Location = new Point(14, 144);
            deleteTableCheckBox.Name = "deleteTableCheckBox";
            deleteTableCheckBox.Size = new Size(96, 21);
            deleteTableCheckBox.TabIndex = 16;
            deleteTableCheckBox.Text = "DeleteTable";
            deleteTableCheckBox.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 189);
            button3.Name = "button3";
            button3.Size = new Size(76, 26);
            button3.TabIndex = 15;
            button3.Text = "Run";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.Location = new Point(12, 12);
            label10.Name = "label10";
            label10.Size = new Size(76, 26);
            label10.TabIndex = 14;
            label10.Text = "OutputPath";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableNameBox
            // 
            tableNameBox.AcceptsReturn = true;
            tableNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableNameBox.Location = new Point(138, 61);
            tableNameBox.Multiline = true;
            tableNameBox.Name = "tableNameBox";
            tableNameBox.ScrollBars = ScrollBars.Vertical;
            tableNameBox.Size = new Size(445, 166);
            tableNameBox.TabIndex = 1;
            // 
            // csvOutputPath
            // 
            csvOutputPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            csvOutputPath.Location = new Point(138, 12);
            csvOutputPath.Name = "csvOutputPath";
            csvOutputPath.Size = new Size(445, 23);
            csvOutputPath.TabIndex = 0;
            // 
            // label11
            // 
            label11.Location = new Point(12, 284);
            label11.Name = "label11";
            label11.Size = new Size(76, 26);
            label11.TabIndex = 20;
            label11.Text = "EndFlag";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endTextBox
            // 
            endTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            endTextBox.Location = new Point(138, 284);
            endTextBox.Name = "endTextBox";
            endTextBox.Size = new Size(445, 23);
            endTextBox.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(endTextBox);
            panel1.Controls.Add(excelControl);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pwdTextBox);
            panel1.Controls.Add(distanceTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(uidTextBox);
            panel1.Controls.Add(databaseTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataSourceTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 645);
            panel1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 645);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            excelControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private TextBox excelTextBox;
        private TextBox sheetTextBox;
        private TextBox outputPathTextBox;
        private TextBox dataSourceTextBox;
        private TextBox databaseTextBox;
        private TextBox uidTextBox;
        private TextBox pwdTextBox;
        private TextBox distanceTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TabControl excelControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label9;
        private TextBox inputBox;
        private Button button1;
        private Label label10;
        private TextBox tableNameBox;
        private TextBox csvOutputPath;
        private Button button3;
        private Label label11;
        private TextBox endTextBox;
        private CheckBox commonTableCheckBox;
        private CheckBox deleteTableCheckBox;
        private Panel panel1;
    }
}
