using System.Data;
using CPUFramework;
using System.Data.SqlClient;

namespace RecordKeeperBizObjects
{
    public static class DataService
    {
        //private static string connstring = "Server=tcp:srosenfeld.database.windows.net,1433;Initial Catalog=RecordKeeperDb;Persist Security Info=False;User ID=srosenfeldadmin;Password=CPU123!@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        //public static string SetConnectionString(string servername, string databasename, string username, string password)
        //{
        //    connstring = "Server=tcp:" + servername +
        //        ";Initial Catalog=" + databasename +
        //        ";Persist Security Info=False;User ID=" + username +
        //        ";Password=" + password + 
        //        ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        //    using (SqlConnection conn = new SqlConnection(connstring))
        //    {
        //        conn.Open();
        //    }
        //    return connstring;
        //}
        //internal static string ConnectionString
        //{
        //    get => connstring;
        //}
        public static DataTable GetUSGovRecordSummary()
        {
            string sql = "select Num = count(*), TableDesc = 'Parties' from Party union select Num = count(*), TableDesc = 'Presidents' from President union select Num = count(*), TableDesc = 'Executive Orders' from ExecutiveOrder";
            return SQLUtility.GetDataTable(DataUtility.ConnectionString, sql);
        }

        public static DataTable GetPartyList(bool IncludeBlank = false)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(DataUtility.ConnectionString, "PartyGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = IncludeBlank;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }

        public static DataTable GetPresidentList()
        {
            // return SQLUtility.GetDataTableFromSproc(connstring, "PresidentGet");
            SqlCommand cmd = SQLUtility.GetSqlCommand(DataUtility.ConnectionString, "presidentGet");
            cmd.Parameters["@All"].Value = 1;

            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }

        public static DataTable GetPresidentDetail(int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(DataUtility.ConnectionString, "presidentGet");
            cmd.Parameters["@PresidentId"].Value = id;
            cmd.Parameters["@All"].Value = 0;

            // get sql command for PresidentGet from sql utility 
            //set paramater of sqlCommand
            //pass the command back into Sql utility and get back a datatable
            return null;// SQLUtility.GetDataTable(cmd, connstring);
        }

        public static DataTable GetExecutiveOrdersForPresident(int presidentid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(DataUtility.ConnectionString, "ExecutiveOrderGet");
            cmd.Parameters["@PresidentId"].Value = presidentid;
            return null; //SQLUtility.GetDataTable(cmd, connstring);
        }
        public static DataTable GetPresidentWithRawSQL(int num)
        {
            DataTable dt = SQLUtility.GetDataTable(DataUtility.ConnectionString, "select * from president where num = 13");
            return dt;
        }
    }
}
