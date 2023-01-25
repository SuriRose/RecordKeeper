using NUnit.Framework;
using RecordKeeperBizObjects;
using System.Data;
using CPUFramework;
using Dapper;
using System.Data.SqlClient;

namespace RecordKeeperTest
{
    public class Tests
    {
        int totalprez = 0;
        string connstring = "";
        int maxpreznum = 0;
        int maxprezid = 0;
        int prezwithexecorederid = 0;

        [SetUp]
        public void Setup()
        {
            connstring = DataUtility.SetConnectionString("srosenfeld.database.windows.net,1433", "RecordKeeperDb", "srosenfeldadmin", "CPU123!@#");
            DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*)from president");
            totalprez = (int)dt.Rows[0]["total"];

            //code below without datatable and only dt??
            DataTable dt2 = SQLUtility.GetDataTable(connstring, "select top 1 p.presidentId, p.Num from president p ");
            maxpreznum = (int)dt2.Rows[0]["Num"];
            maxprezid = (int)dt2.Rows[0]["PresidentId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.presidentId, p.Num from president p join ExecutiveOrder e on e.presidentid = p.presidentId order by p.num desc");
            prezwithexecorederid = (int)dt.Rows[0]["PresidentId"];
        }
        //[Test]
        //public void TestPresidentList()
        //{
        //    DataTable dt = DataService.GetPresidentList();
        //    TestContext.WriteLine("Num Presidents " + dt.Rows.Count.ToString());
        //    Assert.IsTrue(dt.Rows.Count == totalprez);
        //}
        ////[Test]
        ////public void TestPartyList()
        ////{
        ////    DataTable dt = DataService.GetPartyList();
        ////    TestContext.WriteLine("Num parties " + dt.Rows.Count.ToString());
        ////    Assert.IsTrue(dt.Rows.Count == 7);
        ////}
        ////[Test]
        ////public void TestUSGovSummary()
        ////{
        ////    DataTable dt = DataService.GetUSGovRecordSummary();
        ////    TestContext.WriteLine("Num records for summary" + dt.Rows.Count.ToString());
        ////    Assert.IsTrue(dt.Rows.Count == 3);
        ////}
        ////[Test]

        //public void TestLoadPresident()
        //{
        //    bizPresident prez = bizPresident.Get(maxprezid);
        //    TestContext.WriteLine("Prez FullDescription = " + prez.FullDescription());
        //    Assert.IsTrue(prez.Num == maxpreznum);
        //}
        //[Test]
        //public void TestNewPresident()
        //{
        //    bizPresident prez = new bizPresident();
        //    prez.FirstName = "Yonason";
        //    prez.LastName = "Adams";
        //    prez.DateBorn = System.DateTime.Now.AddMonths(-450);
        //    prez.DateDied = System.DateTime.Now.AddMonths(24);
        //    prez.TermStart = System.DateTime.Now.Year;
        //    prez.Save();
        //    TestContext.WriteLine("New President num = " + prez.Num.ToString() + ".Should be " + (maxpreznum + 1));
        //    Assert.IsTrue(prez.Num == maxpreznum + 1);
        //}
        //[Test]
        //public void TestChangePresNum()
        //{
        //    bizPresident prez = bizPresident.Get(maxprezid);
        //    //prez.Load(maxprezid);
        //    prez.Num = prez.Num + 1;
        //    Assert.Throws<CPUException>(() => prez.Save(), "You cannot change a president's number");

        //    TestContext.WriteLine(prez.FullDescription());
        //}
        //[Test]
        //public void TestDeletePresidentWithExecutiveOrder()
        //{
        //    bizPresident prez = bizPresident.Get(prezwithexecorederid);
        //    //prez.Get(prezwithexecorederid);
        //    prez.Delete();
        //    Assert.Throws<CPUException>(() => prez.Delete());
        //}
        //[Test]
        //public void TestLoadPresidentDapper()
        //{
        //    using (SqlConnection conn = new SqlConnection(connstring))
        //    {
        //        bizPresident prez = conn.QueryFirstOrDefault<bizPresident>("select top 1 * from president");
        //        TestContext.WriteLine(prez.FullDescription());
        //    }
        //}
    }
}