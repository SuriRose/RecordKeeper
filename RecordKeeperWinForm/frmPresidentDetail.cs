using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;
using RecordKeeperBizObjects;
namespace RecordKeeperWinForm
{
    public partial class frmPresidentDetail : Form
    {
        bizPresident prezobj = new bizPresident();
        public frmPresidentDetail()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            //bizPresident.SetConnectionString();
        }

        public void ShowForm(int id)
        {
            prezobj = bizPresident.Get(id);
            //prezobj = new bizPresident();    
            lstParty.DataSource = DataService.GetPartyList(true);
            lstParty.ValueMember = "PartyId";
            lstParty.DisplayMember = "Party";
            lstParty.DataBindings.Add("SelectedValue", prezobj, "PartyId");

            txtNumber.DataBindings.Add("Text", prezobj, "Num");
            txtFirstName.DataBindings.Add("Text", prezobj, "FirstName");
            txtLastName.DataBindings.Add("Text", prezobj, "LastName");
            txtDateBorn.DataBindings.Add("Text", prezobj, "DateBorn");
            txtDateDied.DataBindings.Add("Text", prezobj, "DateDied");
            txtTermEnd.DataBindings.Add("Text", prezobj, "Termend");
            txtTermStart.DataBindings.Add("Text", prezobj, "TermStart");  
            gExecutiveOrders.DataSource = DataService.GetExecutiveOrdersForPresident(id);

                this.StartPosition = FormStartPosition.CenterScreen;
                this.Show();
        }
        private void Delete()
        {
            try
            {
                prezobj.Delete();
                this.Close();
            }
            catch (CPUException ex) { MessageBox.Show(ex.FriendlyMessage, this.Text, MessageBoxButtons.OK); }
        }
        private void Save()
        {
            try
            {
                prezobj.Save();
            }
            catch (CPUException ex) { MessageBox.Show(ex.FriendlyMessage, this.Text, MessageBoxButtons.OK); }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}