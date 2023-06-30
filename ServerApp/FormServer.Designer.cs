namespace ServerApp
{
    partial class FormServer
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
            splitContainer1 = new SplitContainer();
            lisbClients = new ListBox();
            tlpClientInfo = new TableLayoutPanel();
            tbSaveFilePath = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbClientPort = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbClientIP = new TextBox();
            tbRequestFileName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tlpClientInfo.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 10);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lisbClients);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tlpClientInfo);
            splitContainer1.Size = new Size(612, 203);
            splitContainer1.SplitterDistance = 204;
            splitContainer1.TabIndex = 3;
            // 
            // lisbClients
            // 
            lisbClients.Dock = DockStyle.Fill;
            lisbClients.FormattingEnabled = true;
            lisbClients.ItemHeight = 15;
            lisbClients.Location = new Point(0, 0);
            lisbClients.Name = "lisbClients";
            lisbClients.Size = new Size(202, 201);
            lisbClients.TabIndex = 1;
            lisbClients.SelectedIndexChanged += lisbClients_SelectedIndexChanged;
            // 
            // tlpClientInfo
            // 
            tlpClientInfo.AutoSize = true;
            tlpClientInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpClientInfo.ColumnCount = 2;
            tlpClientInfo.ColumnStyles.Add(new ColumnStyle());
            tlpClientInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpClientInfo.Controls.Add(tbSaveFilePath, 1, 3);
            tlpClientInfo.Controls.Add(label4, 0, 3);
            tlpClientInfo.Controls.Add(label3, 0, 2);
            tlpClientInfo.Controls.Add(tbClientPort, 1, 1);
            tlpClientInfo.Controls.Add(label2, 0, 1);
            tlpClientInfo.Controls.Add(label1, 0, 0);
            tlpClientInfo.Controls.Add(tbClientIP, 1, 0);
            tlpClientInfo.Controls.Add(tbRequestFileName, 1, 2);
            tlpClientInfo.Dock = DockStyle.Fill;
            tlpClientInfo.Location = new Point(0, 0);
            tlpClientInfo.Name = "tlpClientInfo";
            tlpClientInfo.RowCount = 4;
            tlpClientInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpClientInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpClientInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpClientInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpClientInfo.Size = new Size(402, 201);
            tlpClientInfo.TabIndex = 4;
            // 
            // tbSaveFilePath
            // 
            tbSaveFilePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSaveFilePath.Location = new Point(122, 164);
            tbSaveFilePath.Name = "tbSaveFilePath";
            tbSaveFilePath.Size = new Size(277, 23);
            tbSaveFilePath.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(30, 168);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 5;
            label4.Text = "Process Result";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 117);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 4;
            label3.Text = "Request File Name";
            // 
            // tbClientPort
            // 
            tbClientPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbClientPort.Location = new Point(122, 63);
            tbClientPort.Name = "tbClientPort";
            tbClientPort.Size = new Size(277, 23);
            tbClientPort.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(51, 67);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Client Port";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(64, 17);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Client IP";
            // 
            // tbClientIP
            // 
            tbClientIP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbClientIP.Location = new Point(122, 13);
            tbClientIP.Name = "tbClientIP";
            tbClientIP.Size = new Size(277, 23);
            tbClientIP.TabIndex = 1;
            // 
            // tbRequestFileName
            // 
            tbRequestFileName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbRequestFileName.Location = new Point(122, 113);
            tbRequestFileName.Name = "tbRequestFileName";
            tbRequestFileName.Size = new Size(277, 23);
            tbRequestFileName.TabIndex = 5;
            // 
            // FormServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 223);
            Controls.Add(splitContainer1);
            Name = "FormServer";
            Padding = new Padding(10);
            Text = "Server App";
            FormClosed += FormServer_FormClosed;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tlpClientInfo.ResumeLayout(false);
            tlpClientInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox lisbClients;
        private TableLayoutPanel tlpClientInfo;
        private TextBox tbSaveFilePath;
        private Label label4;
        private Label label3;
        private TextBox tbClientPort;
        private Label label2;
        private Label label1;
        private TextBox tbClientIP;
        private TextBox tbRequestFileName;
    }
}