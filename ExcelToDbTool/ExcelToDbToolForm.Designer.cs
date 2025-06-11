namespace ExcelToDbTool
{
    partial class ExcelToDbToolForm
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
            excelLabel = new Label();
            sheetLabel = new Label();
            outPathLabel = new Label();
            dataLabel = new Label();
            databaseLabel = new Label();
            uidLabel = new Label();
            pwdLabel = new Label();
            distanceLabel = new Label();
            excelControl = new TabControl();
            tabPage1 = new TabPage();
            commonTableCheckBox = new CheckBox();
            excelSelceButton = new Button();
            tabPage2 = new TabPage();
            inputLabel = new Label();
            inputBox = new TextBox();
            button1 = new Button();
            tabPage3 = new TabPage();
            deleteTableCheckBox = new CheckBox();
            button3 = new Button();
            outputPathLabel = new Label();
            tableNameBox = new TextBox();
            csvOutputPath = new TextBox();
            endFlagLabel = new Label();
            endTextBox = new TextBox();
            panel1 = new Panel();
            tableNamesLabel = new Label();
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
            excelTextBox.Location = new Point(134, 23);
            excelTextBox.Name = "excelTextBox";
            excelTextBox.Size = new Size(344, 23);
            excelTextBox.TabIndex = 2;
            // 
            // sheetTextBox
            // 
            sheetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sheetTextBox.Location = new Point(134, 78);
            sheetTextBox.Name = "sheetTextBox";
            sheetTextBox.Size = new Size(344, 23);
            sheetTextBox.TabIndex = 3;
            // 
            // outputPathTextBox
            // 
            outputPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputPathTextBox.Location = new Point(134, 133);
            outputPathTextBox.Name = "outputPathTextBox";
            outputPathTextBox.Size = new Size(344, 23);
            outputPathTextBox.TabIndex = 4;
            // 
            // dataSourceTextBox
            // 
            dataSourceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataSourceTextBox.Location = new Point(138, 10);
            dataSourceTextBox.Name = "dataSourceTextBox";
            dataSourceTextBox.Size = new Size(344, 23);
            dataSourceTextBox.TabIndex = 5;
            dataSourceTextBox.Text = "LocalHost\\MSSQLSERVER";
            // 
            // databaseTextBox
            // 
            databaseTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            databaseTextBox.Location = new Point(138, 65);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.Size = new Size(344, 23);
            databaseTextBox.TabIndex = 6;
            // 
            // uidTextBox
            // 
            uidTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uidTextBox.Location = new Point(138, 119);
            uidTextBox.Name = "uidTextBox";
            uidTextBox.Size = new Size(344, 23);
            uidTextBox.TabIndex = 7;
            uidTextBox.Text = "sa";
            // 
            // pwdTextBox
            // 
            pwdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pwdTextBox.Location = new Point(138, 173);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.Size = new Size(344, 23);
            pwdTextBox.TabIndex = 8;
            pwdTextBox.Text = "P@ssw0rd";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            distanceTextBox.Location = new Point(138, 228);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(344, 23);
            distanceTextBox.TabIndex = 9;
            distanceTextBox.Text = "3";
            // 
            // excelLabel
            // 
            excelLabel.Location = new Point(8, 24);
            excelLabel.Name = "excelLabel";
            excelLabel.Size = new Size(112, 21);
            excelLabel.TabIndex = 10;
            excelLabel.Text = "Excel";
            excelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sheetLabel
            // 
            sheetLabel.Location = new Point(8, 78);
            sheetLabel.Name = "sheetLabel";
            sheetLabel.Size = new Size(112, 21);
            sheetLabel.TabIndex = 11;
            sheetLabel.Text = "Sheet";
            sheetLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outPathLabel
            // 
            outPathLabel.Location = new Point(8, 133);
            outPathLabel.Name = "outPathLabel";
            outPathLabel.Size = new Size(112, 21);
            outPathLabel.TabIndex = 12;
            outPathLabel.Text = "OutPath";
            outPathLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataLabel
            // 
            dataLabel.Location = new Point(12, 10);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(76, 26);
            dataLabel.TabIndex = 13;
            dataLabel.Text = "Data Source";
            dataLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // databaseLabel
            // 
            databaseLabel.Location = new Point(12, 65);
            databaseLabel.Name = "databaseLabel";
            databaseLabel.Size = new Size(76, 26);
            databaseLabel.TabIndex = 14;
            databaseLabel.Text = "Database";
            databaseLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uidLabel
            // 
            uidLabel.Location = new Point(12, 119);
            uidLabel.Name = "uidLabel";
            uidLabel.Size = new Size(76, 26);
            uidLabel.TabIndex = 15;
            uidLabel.Text = "Uid";
            uidLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pwdLabel
            // 
            pwdLabel.Location = new Point(12, 173);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(76, 26);
            pwdLabel.TabIndex = 16;
            pwdLabel.Text = "Pwd";
            pwdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // distanceLabel
            // 
            distanceLabel.Location = new Point(12, 228);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(76, 26);
            distanceLabel.TabIndex = 17;
            distanceLabel.Text = "Distance";
            distanceLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            tabPage1.Controls.Add(excelTextBox);
            tabPage1.Controls.Add(commonTableCheckBox);
            tabPage1.Controls.Add(excelSelceButton);
            tabPage1.Controls.Add(excelLabel);
            tabPage1.Controls.Add(sheetLabel);
            tabPage1.Controls.Add(outPathLabel);
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
            // excelSelceButton
            // 
            excelSelceButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            excelSelceButton.Location = new Point(504, 23);
            excelSelceButton.Name = "excelSelceButton";
            excelSelceButton.Size = new Size(75, 23);
            excelSelceButton.TabIndex = 14;
            excelSelceButton.Text = "选择";
            excelSelceButton.UseVisualStyleBackColor = true;
            excelSelceButton.Click += excelSelceButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(inputLabel);
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
            // inputLabel
            // 
            inputLabel.Location = new Point(12, 61);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(76, 26);
            inputLabel.TabIndex = 19;
            inputLabel.Text = "Input";
            inputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            inputBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputBox.Location = new Point(134, 63);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(344, 23);
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
            tabPage3.Controls.Add(tableNamesLabel);
            tabPage3.Controls.Add(deleteTableCheckBox);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(outputPathLabel);
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
            deleteTableCheckBox.Location = new Point(494, 134);
            deleteTableCheckBox.Name = "deleteTableCheckBox";
            deleteTableCheckBox.Size = new Size(96, 21);
            deleteTableCheckBox.TabIndex = 16;
            deleteTableCheckBox.Text = "DeleteTable";
            deleteTableCheckBox.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(494, 201);
            button3.Name = "button3";
            button3.Size = new Size(96, 26);
            button3.TabIndex = 15;
            button3.Text = "Run";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // outputPathLabel
            // 
            outputPathLabel.Location = new Point(12, 12);
            outputPathLabel.Name = "outputPathLabel";
            outputPathLabel.Size = new Size(76, 26);
            outputPathLabel.TabIndex = 14;
            outputPathLabel.Text = "OutputPath";
            outputPathLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableNameBox
            // 
            tableNameBox.AcceptsReturn = true;
            tableNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableNameBox.Location = new Point(138, 63);
            tableNameBox.Multiline = true;
            tableNameBox.Name = "tableNameBox";
            tableNameBox.ScrollBars = ScrollBars.Vertical;
            tableNameBox.Size = new Size(340, 166);
            tableNameBox.TabIndex = 1;
            // 
            // csvOutputPath
            // 
            csvOutputPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            csvOutputPath.Location = new Point(138, 12);
            csvOutputPath.Name = "csvOutputPath";
            csvOutputPath.Size = new Size(340, 23);
            csvOutputPath.TabIndex = 0;
            // 
            // endFlagLabel
            // 
            endFlagLabel.Location = new Point(12, 284);
            endFlagLabel.Name = "endFlagLabel";
            endFlagLabel.Size = new Size(76, 26);
            endFlagLabel.TabIndex = 20;
            endFlagLabel.Text = "EndFlag";
            endFlagLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endTextBox
            // 
            endTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            endTextBox.Location = new Point(138, 284);
            endTextBox.Name = "endTextBox";
            endTextBox.Size = new Size(344, 23);
            endTextBox.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(endFlagLabel);
            panel1.Controls.Add(endTextBox);
            panel1.Controls.Add(excelControl);
            panel1.Controls.Add(distanceLabel);
            panel1.Controls.Add(dataLabel);
            panel1.Controls.Add(pwdLabel);
            panel1.Controls.Add(pwdTextBox);
            panel1.Controls.Add(distanceTextBox);
            panel1.Controls.Add(uidLabel);
            panel1.Controls.Add(uidTextBox);
            panel1.Controls.Add(databaseTextBox);
            panel1.Controls.Add(databaseLabel);
            panel1.Controls.Add(dataSourceTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 645);
            panel1.TabIndex = 21;
            // 
            // tableNamesLabel
            // 
            tableNamesLabel.Location = new Point(12, 133);
            tableNamesLabel.Name = "tableNamesLabel";
            tableNamesLabel.Size = new Size(85, 26);
            tableNamesLabel.TabIndex = 17;
            tableNamesLabel.Text = "tableNames";
            tableNamesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExcelToDbToolForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 645);
            Controls.Add(panel1);
            Name = "ExcelToDbToolForm";
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
        private Label excelLabel;
        private Label sheetLabel;
        private Label outPathLabel;
        private Label dataLabel;
        private Label databaseLabel;
        private Label uidLabel;
        private Label pwdLabel;
        private Label distanceLabel;
        private TabControl excelControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label inputLabel;
        private TextBox inputBox;
        private Button button1;
        private Label outputPathLabel;
        private TextBox tableNameBox;
        private TextBox csvOutputPath;
        private Button button3;
        private Label endFlagLabel;
        private TextBox endTextBox;
        private CheckBox commonTableCheckBox;
        private CheckBox deleteTableCheckBox;
        private Panel panel1;
        private Button excelSelceButton;
        private Label tableNamesLabel;
    }
}
