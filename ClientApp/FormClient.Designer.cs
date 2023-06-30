namespace ClientApp
{
    partial class FormClient
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
            if(disposing && (components != null)) {
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
            btnDownload = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbDownloadResult = new TextBox();
            tbSaveFilePath = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbServerPort = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbServerIP = new TextBox();
            tbRequestFileName = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDownload.Location = new Point(3, 160);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(113, 23);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tbDownloadResult, 1, 4);
            tableLayoutPanel1.Controls.Add(tbSaveFilePath, 1, 3);
            tableLayoutPanel1.Controls.Add(btnDownload, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(tbServerPort, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbServerIP, 1, 0);
            tableLayoutPanel1.Controls.Add(tbRequestFileName, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(364, 191);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbDownloadResult
            // 
            tbDownloadResult.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbDownloadResult.Location = new Point(122, 160);
            tbDownloadResult.Name = "tbDownloadResult";
            tbDownloadResult.Size = new Size(239, 23);
            tbDownloadResult.TabIndex = 7;
            // 
            // tbSaveFilePath
            // 
            tbSaveFilePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSaveFilePath.Location = new Point(122, 121);
            tbSaveFilePath.Name = "tbSaveFilePath";
            tbSaveFilePath.Size = new Size(239, 23);
            tbSaveFilePath.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(32, 125);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 5;
            label4.Text = "Save File Path";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 87);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 4;
            label3.Text = "Request File Name";
            // 
            // tbServerPort
            // 
            tbServerPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbServerPort.Location = new Point(122, 45);
            tbServerPort.Name = "tbServerPort";
            tbServerPort.Size = new Size(239, 23);
            tbServerPort.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(48, 49);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Server Port";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(61, 11);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Server IP";
            // 
            // tbServerIP
            // 
            tbServerIP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbServerIP.Location = new Point(122, 7);
            tbServerIP.Name = "tbServerIP";
            tbServerIP.Size = new Size(239, 23);
            tbServerIP.TabIndex = 1;
            // 
            // tbRequestFileName
            // 
            tbRequestFileName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbRequestFileName.Location = new Point(122, 83);
            tbRequestFileName.Name = "tbRequestFileName";
            tbRequestFileName.Size = new Size(239, 23);
            tbRequestFileName.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(400, 250);
            Name = "FormMain";
            Padding = new Padding(10);
            Text = "Client App";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownload;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbSaveFilePath;
        private Label label4;
        private Label label3;
        private TextBox tbServerPort;
        private Label label2;
        private Label label1;
        private TextBox tbServerIP;
        private TextBox tbRequestFileName;
        private TextBox tbDownloadResult;
    }
}