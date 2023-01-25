namespace RecordKeeperWinForm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.GRecordSummary = new System.Windows.Forms.DataGridView();
            this.gPartyList = new System.Windows.Forms.DataGridView();
            this.gPresidentList = new System.Windows.Forms.DataGridView();
            this.tblConnection = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNewPresident = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRecordSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPartyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPresidentList)).BeginInit();
            this.tblConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.GRecordSummary, 0, 0);
            this.tblMain.Controls.Add(this.gPartyList, 1, 0);
            this.tblMain.Controls.Add(this.gPresidentList, 0, 2);
            this.tblMain.Controls.Add(this.tblConnection, 0, 1);
            this.tblMain.Controls.Add(this.btnNewPresident, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.Size = new System.Drawing.Size(1049, 720);
            this.tblMain.TabIndex = 0;
            // 
            // GRecordSummary
            // 
            this.GRecordSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRecordSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRecordSummary.Location = new System.Drawing.Point(3, 4);
            this.GRecordSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GRecordSummary.Name = "GRecordSummary";
            this.GRecordSummary.RowHeadersWidth = 51;
            this.GRecordSummary.RowTemplate.Height = 25;
            this.GRecordSummary.Size = new System.Drawing.Size(518, 319);
            this.GRecordSummary.TabIndex = 0;
            // 
            // gPartyList
            // 
            this.gPartyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPartyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPartyList.Location = new System.Drawing.Point(527, 4);
            this.gPartyList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gPartyList.Name = "gPartyList";
            this.gPartyList.RowHeadersWidth = 51;
            this.gPartyList.RowTemplate.Height = 25;
            this.gPartyList.Size = new System.Drawing.Size(519, 319);
            this.gPartyList.TabIndex = 1;
            // 
            // gPresidentList
            // 
            this.gPresidentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPresidentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPresidentList.Location = new System.Drawing.Point(3, 396);
            this.gPresidentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gPresidentList.Name = "gPresidentList";
            this.gPresidentList.RowHeadersWidth = 51;
            this.gPresidentList.RowTemplate.Height = 25;
            this.gPresidentList.Size = new System.Drawing.Size(518, 320);
            this.gPresidentList.TabIndex = 2;
            // 
            // tblConnection
            // 
            this.tblConnection.ColumnCount = 5;
            this.tblMain.SetColumnSpan(this.tblConnection, 2);
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.Controls.Add(this.label1, 0, 0);
            this.tblConnection.Controls.Add(this.label2, 1, 0);
            this.tblConnection.Controls.Add(this.label3, 2, 0);
            this.tblConnection.Controls.Add(this.label4, 3, 0);
            this.tblConnection.Controls.Add(this.label5, 4, 0);
            this.tblConnection.Controls.Add(this.txtserver, 0, 1);
            this.tblConnection.Controls.Add(this.txtdatabase, 1, 1);
            this.tblConnection.Controls.Add(this.txtusername, 2, 1);
            this.tblConnection.Controls.Add(this.txtpassword, 3, 1);
            this.tblConnection.Controls.Add(this.btnConnect, 4, 1);
            this.tblConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConnection.Location = new System.Drawing.Point(3, 330);
            this.tblConnection.Name = "tblConnection";
            this.tblConnection.RowCount = 2;
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblConnection.Size = new System.Drawing.Size(1043, 59);
            this.tblConnection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(835, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // txtserver
            // 
            this.txtserver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtserver.Location = new System.Drawing.Point(3, 32);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(202, 27);
            this.txtserver.TabIndex = 7;
            // 
            // txtdatabase
            // 
            this.txtdatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdatabase.Location = new System.Drawing.Point(211, 32);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(202, 27);
            this.txtdatabase.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtusername.Location = new System.Drawing.Point(419, 32);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(202, 27);
            this.txtusername.TabIndex = 9;
            // 
            // txtpassword
            // 
            this.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpassword.Location = new System.Drawing.Point(627, 32);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(202, 27);
            this.txtpassword.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(835, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 24);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnNewPresident
            // 
            this.btnNewPresident.Location = new System.Drawing.Point(527, 395);
            this.btnNewPresident.Name = "btnNewPresident";
            this.btnNewPresident.Size = new System.Drawing.Size(174, 29);
            this.btnNewPresident.TabIndex = 4;
            this.btnNewPresident.Text = "New President";
            this.btnNewPresident.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 720);
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRecordSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPartyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPresidentList)).EndInit();
            this.tblConnection.ResumeLayout(false);
            this.tblConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView GRecordSummary;
        private DataGridView gPartyList;
        private DataGridView gPresidentList;
        private TableLayoutPanel tblConnection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtserver;
        private TextBox txtdatabase;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnConnect;
        private Button btnNewPresident;
    }
}