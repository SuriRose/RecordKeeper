using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecordKeeperBizObjects;
using CPUFramework;

namespace RecordKeeperWinForm
{
    public partial class frmMain : Form
    {
        int numtries = 0;
        public frmMain()
        {
            InitializeComponent();
            btnConnect.Click += BtnConnect_Click;
            gPresidentList.CellDoubleClick += GPresidentList_CellDoubleClick;
            btnNewPresident.Click += BtnNewPresident_Click;
            txtserver.Text = "srosenfeld.database.windows.net,1433";
            txtdatabase.Text = "RecordKeeperDb";
            txtusername.Text = "srosenfeldadmin";
            txtpassword.Text = "CPU123!@#";
        }

        private void BtnConnect_Click(object? sender, EventArgs e)
        {
            Connect();
        }
        private void Connect()
        {
            Cursor.Current = Cursors.WaitCursor;
            numtries++;
            if (numtries > 3)
            {
                MessageBox.Show("Wrong Username and password");
                Application.Exit();
            }
            try
            {
                DataUtility.SetConnectionString(txtserver.Text, txtdatabase.Text, txtusername.Text, txtpassword.Text);
                numtries = 0;
                BindForm();
            }
            catch (SqlException ex) when (ex.Message.StartsWith("login failed for user"))
            {
                numtries++;
                if (numtries < 3)
                {
                    MessageBox.Show("Invalid username or password.You have" + (3 - numtries).ToString() + "left to try");
                  
                }
                if (numtries < 3)
                {
                    MessageBox.Show("Bye");
                    Application.Exit();
                }
            }
            catch (SqlException ex)
            {
                //login failed for user
                //cannot open database
                MessageBox.Show("Unable to connect fix connection info and try again" + Environment.NewLine + ex.Message, "Recordkeeper");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void BindForm()
        {
            GRecordSummary.DataSource = DataService.GetUSGovRecordSummary();
            gPartyList.DataSource = DataService.GetPartyList();
            gPresidentList.DataSource = DataService.GetPresidentList();

            this.FormatGrid(GRecordSummary);
            this.FormatGrid(gPartyList, "PartyId");
            this.FormatGrid(gPresidentList, "PresidentId");
        }


        private void CreateNewPresident() {
            frmPresidentDetail f = new frmPresidentDetail();
            f.ShowForm(0);
        }
        private void FormatGrid(DataGridView gridobj, string PrimaryKeyFieldName = "")
        {
            gridobj.ReadOnly = true;
            gridobj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridobj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridobj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridobj.RowHeadersWidth = 25;
            gridobj.AllowUserToAddRows = false;
            if (PrimaryKeyFieldName != "")
            {
                gridobj.Columns[PrimaryKeyFieldName].Visible = false;
            }
        }
        private void GPresidentList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gPresidentList.Rows[e.RowIndex].Cells["PresidentId"].Value;
            frmPresidentDetail f = new frmPresidentDetail();
            f.ShowForm(id);
        }
        private void BtnNewPresident_Click(object? sender, EventArgs e)
        {
            CreateNewPresident();
        }
    }
}
