﻿namespace RecordKeeperWinForm
{
    partial class frmPresidentDetail
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
            this.lblParty = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateBorn = new System.Windows.Forms.Label();
            this.lblDateDied = new System.Windows.Forms.Label();
            this.lblTermStart = new System.Windows.Forms.Label();
            this.lblTermEnd = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDateBorn = new System.Windows.Forms.TextBox();
            this.txtDateDied = new System.Windows.Forms.TextBox();
            this.txtTermStart = new System.Windows.Forms.TextBox();
            this.txtTermEnd = new System.Windows.Forms.TextBox();
            this.lblExecutiveOrder = new System.Windows.Forms.Label();
            this.gExecutiveOrders = new System.Windows.Forms.DataGridView();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstParty = new System.Windows.Forms.ComboBox();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gExecutiveOrders)).BeginInit();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblParty, 0, 0);
            this.tblMain.Controls.Add(this.lblNum, 0, 1);
            this.tblMain.Controls.Add(this.lblFirstName, 0, 2);
            this.tblMain.Controls.Add(this.lblLastName, 0, 3);
            this.tblMain.Controls.Add(this.lblDateBorn, 0, 4);
            this.tblMain.Controls.Add(this.lblDateDied, 0, 5);
            this.tblMain.Controls.Add(this.lblTermStart, 0, 6);
            this.tblMain.Controls.Add(this.lblTermEnd, 0, 7);
            this.tblMain.Controls.Add(this.txtNumber, 1, 1);
            this.tblMain.Controls.Add(this.txtFirstName, 1, 2);
            this.tblMain.Controls.Add(this.txtLastName, 1, 3);
            this.tblMain.Controls.Add(this.txtDateBorn, 1, 4);
            this.tblMain.Controls.Add(this.txtDateDied, 1, 5);
            this.tblMain.Controls.Add(this.txtTermStart, 1, 6);
            this.tblMain.Controls.Add(this.txtTermEnd, 1, 7);
            this.tblMain.Controls.Add(this.lblExecutiveOrder, 2, 0);
            this.tblMain.Controls.Add(this.gExecutiveOrders, 2, 1);
            this.tblMain.Controls.Add(this.tblButtons, 2, 8);
            this.tblMain.Controls.Add(this.lstParty, 1, 0);
            this.tblMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 9;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(773, 610);
            this.tblMain.TabIndex = 0;
            // 
            // lblParty
            // 
            this.lblParty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblParty.AutoSize = true;
            this.lblParty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParty.Location = new System.Drawing.Point(3, 7);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(66, 32);
            this.lblParty.TabIndex = 0;
            this.lblParty.Text = "Party";
            // 
            // lblNum
            // 
            this.lblNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNum.Location = new System.Drawing.Point(3, 56);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(102, 32);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Number";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(3, 109);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(129, 32);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(3, 162);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(126, 32);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDateBorn
            // 
            this.lblDateBorn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateBorn.AutoSize = true;
            this.lblDateBorn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateBorn.Location = new System.Drawing.Point(3, 215);
            this.lblDateBorn.Name = "lblDateBorn";
            this.lblDateBorn.Size = new System.Drawing.Size(121, 32);
            this.lblDateBorn.TabIndex = 4;
            this.lblDateBorn.Text = "Date Born";
            // 
            // lblDateDied
            // 
            this.lblDateDied.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateDied.AutoSize = true;
            this.lblDateDied.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateDied.Location = new System.Drawing.Point(3, 268);
            this.lblDateDied.Name = "lblDateDied";
            this.lblDateDied.Size = new System.Drawing.Size(121, 32);
            this.lblDateDied.TabIndex = 5;
            this.lblDateDied.Text = "Date Died";
            // 
            // lblTermStart
            // 
            this.lblTermStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTermStart.AutoSize = true;
            this.lblTermStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTermStart.Location = new System.Drawing.Point(3, 321);
            this.lblTermStart.Name = "lblTermStart";
            this.lblTermStart.Size = new System.Drawing.Size(122, 32);
            this.lblTermStart.TabIndex = 6;
            this.lblTermStart.Text = "Term Start";
            // 
            // lblTermEnd
            // 
            this.lblTermEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTermEnd.AutoSize = true;
            this.lblTermEnd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTermEnd.Location = new System.Drawing.Point(3, 417);
            this.lblTermEnd.Name = "lblTermEnd";
            this.lblTermEnd.Size = new System.Drawing.Size(114, 32);
            this.lblTermEnd.TabIndex = 7;
            this.lblTermEnd.Text = "Term End";
            // 
            // txtNumber
            // 
            this.txtNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.Location = new System.Drawing.Point(141, 53);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(307, 39);
            this.txtNumber.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(141, 106);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(307, 39);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(141, 159);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(307, 39);
            this.txtLastName.TabIndex = 11;
            // 
            // txtDateBorn
            // 
            this.txtDateBorn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateBorn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateBorn.Location = new System.Drawing.Point(141, 212);
            this.txtDateBorn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDateBorn.Name = "txtDateBorn";
            this.txtDateBorn.Size = new System.Drawing.Size(307, 39);
            this.txtDateBorn.TabIndex = 12;
            // 
            // txtDateDied
            // 
            this.txtDateDied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDied.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateDied.Location = new System.Drawing.Point(141, 265);
            this.txtDateDied.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDateDied.Name = "txtDateDied";
            this.txtDateDied.Size = new System.Drawing.Size(307, 39);
            this.txtDateDied.TabIndex = 13;
            // 
            // txtTermStart
            // 
            this.txtTermStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTermStart.Location = new System.Drawing.Point(141, 318);
            this.txtTermStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtTermStart.Name = "txtTermStart";
            this.txtTermStart.Size = new System.Drawing.Size(307, 39);
            this.txtTermStart.TabIndex = 14;
            // 
            // txtTermEnd
            // 
            this.txtTermEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermEnd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTermEnd.Location = new System.Drawing.Point(141, 371);
            this.txtTermEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtTermEnd.Name = "txtTermEnd";
            this.txtTermEnd.Size = new System.Drawing.Size(307, 39);
            this.txtTermEnd.TabIndex = 15;
            // 
            // lblExecutiveOrder
            // 
            this.lblExecutiveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExecutiveOrder.AutoSize = true;
            this.lblExecutiveOrder.Location = new System.Drawing.Point(457, 7);
            this.lblExecutiveOrder.Name = "lblExecutiveOrder";
            this.lblExecutiveOrder.Size = new System.Drawing.Size(313, 32);
            this.lblExecutiveOrder.TabIndex = 16;
            this.lblExecutiveOrder.Text = "Executive Orders";
            this.lblExecutiveOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gExecutiveOrders
            // 
            this.gExecutiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gExecutiveOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gExecutiveOrders.Location = new System.Drawing.Point(457, 50);
            this.gExecutiveOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gExecutiveOrders.Name = "gExecutiveOrders";
            this.gExecutiveOrders.RowHeadersWidth = 51;
            this.tblMain.SetRowSpan(this.gExecutiveOrders, 7);
            this.gExecutiveOrders.RowTemplate.Height = 25;
            this.gExecutiveOrders.Size = new System.Drawing.Size(313, 449);
            this.gExecutiveOrders.TabIndex = 17;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButtons.AutoSize = true;
            this.tblButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblButtons.ColumnCount = 2;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Controls.Add(this.btnDelete, 1, 0);
            this.tblButtons.Controls.Add(this.btnSave, 0, 0);
            this.tblButtons.Location = new System.Drawing.Point(251, 506);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Size = new System.Drawing.Size(200, 48);
            this.tblButtons.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(103, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lstParty
            // 
            this.lstParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstParty.FormattingEnabled = true;
            this.lstParty.Location = new System.Drawing.Point(138, 3);
            this.lstParty.Name = "lstParty";
            this.lstParty.Size = new System.Drawing.Size(313, 40);
            this.lstParty.TabIndex = 19;
            // 
            // frmPresidentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 598);
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPresidentDetail";
            this.Text = "President Detail";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gExecutiveOrders)).EndInit();
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblParty;
        private Label lblNum;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDateBorn;
        private Label lblDateDied;
        private Label lblTermStart;
        private Label lblTermEnd;
        private TextBox txtNumber;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDateBorn;
        private TextBox txtDateDied;
        private TextBox txtTermStart;
        private TextBox txtTermEnd;
        private Label lblExecutiveOrder;
        private DataGridView gExecutiveOrders;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private ComboBox lstParty;
    }
}