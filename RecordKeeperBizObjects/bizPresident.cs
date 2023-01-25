using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;
using Dapper;
using System.ComponentModel.DataAnnotations;

namespace RecordKeeperBizObjects
{
    public class bizPresident : bizObject<bizPresident>
    {
        int partyIdval = 0;
        string lastnameval = "";
        string firstnameval = "";
        int numval;
        int termstartval;
        int termendval;
        DateTime datebornval;
        DateTime? datediedval;
        string codeval = "";

        public bizPresident()
        {
            this.DynamParamForUpdate.Output(this, x => x.Num);
            this.DynamParamForUpdate.Output(this, x => x.Code);
            //this.DynamParamForUpdate.Output(this, x => x.DateDied, size: 20);
        }
        public static List<bizPresident> Search(string criteria)
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("Search Criteria", criteria);
            return GetAllFromSproc("PresidentSearch", dp);
        }

        //new public void Load(int Id)
        //{
        //    //session 55
        //    //SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "PresidentGet");
        //    //cmd.Parameters["@PresidentId"].Value = Id;
        //    //DataTable dt = SQLUtility.GetDataTable(cmd);
        //    //DataTable dt = base.Load(Id);
        //    //if (dt.Rows.Count > 0)
        //    //{
        //    //    DataRow dr = dt.Rows[0];
        //    //    this.PartyId = (int)dr["PartyId"];
        //    //    this.LastName = dr["LastName"].ToString();
        //    //    this.FirstName = dr["FirstName"].ToString();
        //    //    this.Num = (int)dr["Num"];
        //    //    this.DateBorn = (DateTime)dr["DateBorn"];
        //    //    this.TermStart = (int)dr["TermStart"];

        //    //    if (dr["DateDied"] != DBNull.Value)
        //    //    {
        //    //        this.DateDied = (DateTime)dr["DateDied"];
        //    //    }
        //    using (SqlConnection conn = new SqlConnection(DataUtility.ConnectionString))
        //    {
        //        DynamicParameters dp = new DynamicParameters();
        //        dp.Add("PresidentId", Id);
        //        bizPresident prez = conn.QueryFirstOrDefault<bizPresident>("PresidentGet", dp, commandType: CommandType.StoredProcedure);
        //        //this.PrimaryKeyValue = prez.PrimaryKeyValue;
        //    }

        //}

        //new public void Delete()
        //{
        //    using (SqlConnection conn = new SqlConnection(DataService.ConnectionString))
        //    {
        //        DynamicParameters dp = new DynamicParameters();
        //        dp.Add( this.PrimaryKeyName, this.PrimaryKeyValue);
        //        conn.Execute(this.SprocName(SprocActionEnum.Delete), dp, commandType: CommandType.StoredProcedure);
        //    }
        //}

        public int PresidentId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }
        [Required]
        [Display(Name = "Party")]
        public int PartyId
        {
            get { return partyIdval; }
            set
            {
                partyIdval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Last Name")]
        public string LastName
        {
            get { return lastnameval; }
            set
            {
                lastnameval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "First Name")]
        public string FirstName
        {
            get { return firstnameval; }
            set
            {
                firstnameval = value;
                InvokePropertyChanged();
            }
        }
        public int Num
        {
            get { return numval; }
            set
            {
                numval = value;
                InvokePropertyChanged();
            }
        }
        public int TermStart
        {
            get { return termstartval; }
            set
            {
                termstartval = value;
                InvokePropertyChanged();
            }
        }
        public int TermEnd
        {
            get { return termendval; }
            set
            {
                termendval = value;
                InvokePropertyChanged();
            }
        }
        public DateTime DateBorn
        {
            get { return datebornval; }
            set
            {
                datebornval = value;
                InvokePropertyChanged();
            }
        }
        public DateTime? DateDied
        {
            get { return datediedval; }
            set
            {
                datediedval = value;
                InvokePropertyChanged();
            }
        }
        public string Code
        {
            get { return codeval; }
            set
            {
                codeval = value;
                InvokePropertyChanged();
            }
        }
        public string FullDescription() { return this.Num + " " + this.LastName + " " + this.FirstName; }

        protected DynamicParameters DynamParamForUpdate { get; } = new();
        public List<bizParty> PartyList()
        {
            return bizParty.GetAll();
        }

    }
}