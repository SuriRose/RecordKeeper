using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using CPUFramework;
using RecordKeeperBizObjects;
using System.Data;
using NUnit.Framework;
using System.Data.SqlClient;

namespace RecordKeeperTest
{
    internal class DapperTest
    {
        int totalprez = 0;
        string connstring = "";
        int maxpreznum = 0;
        int maxprezid = 0;
        int prezwithexecorederid = 0;
        int maxpartyid = 0;

        [SetUp]
        public void Setup()
        {
            connstring = DataUtility.SetConnectionString("srosenfeld.database.windows.net,1433", "RecordKeeperDb", "srosenfeldadmin", "CPU123!@#");
            DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*)from president");
            totalprez = (int)dt.Rows[0]["total"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.presidentId, p.Num from president p order by p.num desc");
            maxpreznum = (int)dt.Rows[0]["Num"];
            maxprezid = (int)dt.Rows[0]["PresidentId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.presidentId, p.Num from president p join ExecutiveOrder e on e.presidentId = p.presidentId order by p.num desc");
            prezwithexecorederid = (int)dt.Rows[0]["PresidentId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 * from party p order by partyId desc");
            maxpartyid = (int)dt.Rows[0]["partyId"];

            //? bizPresident.SetConnectionString();
        }
        private bizPresident LoadPrez(int Id)
        {
            bizPresident prez = bizPresident.Get(Id);

            return prez;
        }

        //load list
        private List<bizPresident> LoadListPrez()
        {
            return bizPresident.GetAll();
        }
        //insert new
        private bizPresident InsertNewPrez()
        {
            bizPresident prez = new bizPresident();
            prez.PartyId = maxpartyid;
            prez.FirstName = "Yonason";
            prez.LastName = "Adams";
            prez.DateBorn = System.DateTime.Now.AddMonths(-450);
            prez.DateDied = System.DateTime.Now.AddMonths(24);
            prez.TermStart = System.DateTime.Now.Year;
            //dynamic params initialized w/ prez 

            prez.Save();
            return prez;
        }

        //update
        private void ChangePrezNum()
        {
            bizPresident prez = this.LoadPrez(maxprezid);
            prez.Num += 1;
            prez.Save();
        }
        //update
        private void SwapPrezFirstName(bizPresident prez)
        {
            string lastname = prez.LastName;
            string firstname = prez.FirstName;
            prez.LastName = firstname;
            prez.FirstName = lastname;
            prez.Save();
        }
        //delete
        private int DeletePrez(int Id = 0)
        {
            bizPresident p;
            if (Id == 0)
            {
                p = this.InsertNewPrez();
            }
            else
            {
                p = this.LoadPrez(Id);
            }
            Id = p.PresidentId;
            p.Delete();
            return Id;
        }

        //delete that fails
        [Test]
        public void TestLoadPrezList()
        {
            List<bizPresident> lst = this.LoadListPrez();
            TestContext.WriteLine("num of prez " + lst.Count);
            Assert.IsTrue(lst.Count == totalprez);
        }
        [Test]
        public void TestLoadPrez()
        {
            bizPresident p = this.LoadPrez(maxprezid);
            TestContext.WriteLine(p.FullDescription());
            Assert.IsTrue(p.Num == maxpreznum);
        }
        [Test]
        public void TestLoadPrezByNum()
        {
            bizPresident p = bizPresident.Get("Num", maxpreznum);
            TestContext.WriteLine(p.FullDescription());
            Assert.IsTrue(p.PresidentId == maxprezid);
        }
        [Test]
        public void TestInsertNewPrez()
        {
            bizPresident p = this.InsertNewPrez();
            TestContext.WriteLine("Expected presidentId = " + (maxprezid) + " Value = " + p.PresidentId);
            TestContext.WriteLine("Expected Num = " + (maxpreznum + 1) + " Value = " + p.Num);
            TestContext.WriteLine("Expected Code not blank. Code = " + p.Code);
            Assert.IsTrue(p.Num == maxpreznum + 1 && p.PresidentId > maxprezid && string.IsNullOrEmpty(p.Code) == false);
        }
        [Test]
        public void TestUpdatePrez()
        {
            bizPresident prez = this.LoadPrez(maxprezid);
            string lastname = prez.LastName;
            string firstname = prez.FirstName;
            this.SwapPrezFirstName(prez);
            prez = this.LoadPrez(maxprezid);
            TestContext.WriteLine("Original " + firstname + " " + lastname + " Current " + prez.FirstName + " " + prez.LastName);
            Assert.IsTrue(prez.LastName == firstname && prez.FirstName == lastname);
        }
        [Test]
        public void TestDeleteNewPrez()
            {
        //    int id = this.DeletePrez();
        //    bizPresident p = this.LoadPrez(id);
        //    Assert.IsTrue(p == null);
            int id = this.DeletePrez();
            bizPresident p = this.LoadPrez(id);
            Assert.IsTrue(p.PresidentId == 0);
        }
        [Test]
        public void TestDeletePrezWithExecOrder()
        {
            CPUException? ex = Assert.Throws<CPUException>(() => this.DeletePrez(prezwithexecorederid));
            TestContext.WriteLine(ex?.FriendlyMessage);
        }
        [Test]
        public void TestChangePrezNum()
        {
            CPUException? ex = Assert.Throws<CPUException>(() => this.ChangePrezNum());
            TestContext.WriteLine(ex?.Message);
        }
        [Test]
        public void TestSearchprez()
        {
            List<bizPresident> lst = bizPresident.Search("bush");
            TestContext.WriteLine("list count = " + lst.Count.ToString());
            Assert.IsTrue(lst.Count == 2);
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Dapper;
//using CPUFramework;
//using RecordKeeperBizObjects;
//using System.Data;
//using NUnit.Framework;
//using System.Data.SqlClient;

//namespace RecordKeeperTest
//{
//    internal class DapperTest
//    {
//        int totalprez = 0;
//        int maxpreznum = 0;
//        int maxprezid = 0;
//        int maxpartyid = 0;
//        int prezwithexecorderid = 0;
//        string connstring = "";

//        [SetUp]
//        public void Setup()
//        {
//            check what this reallly should be
//            connstring = DataUtility.SetConnectionString("srosenfeld.database.windows.net,1433", "RecordKeeperDb", "srosenfeldadmin", "CPU123!@#");
//            DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*) from president");
//            totalprez = (int)dt.Rows[0]["total"];

//            connstring = DataUtility.SetConnectionString("srosenfeld.database.windows.net,1433", "RecordKeeperDb", "srosenfeldadmin", "CPU123!@#");
//            DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*)from president");
//            totalprez = (int)dt.Rows[0]["total"];

//            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.Num, p.PresidentId from president p order by p.Num desc, p.PresidentId desc");
//            maxpreznum = (int)dt.Rows[0]["Num"];
//            maxprezid = (int)dt.Rows[0]["PresidentId"];

//            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.PresidentId, p.Num from president p join ExecutiveOrder e on e.PresidentId = p.PresidentId order by p.Num desc");
//            prezwithexecorderid = (int)dt.Rows[0]["PresidentId"];

//            dt = SQLUtility.GetDataTable(connstring, "select top 1 * from party order by partyId desc");
//            maxpartyid = (int)dt.Rows[0]["PartyId"];


//        }

//        private SqlConnection GetConnection()
//        {
//            return new SqlConnection(DataUtility.ConnectionString);
//        }

//        CRUD

//        load by primary key
//        private bizPresident LoadPrez(int Id)
//        {
//            using (SqlConnection conn = GetConnection())
//            {
//                DynamicParameters dp = new DynamicParameters();
//                dp.Add("PresidentId", Id);
//                bizPresident prez = conn.QueryFirstOrDefault<bizPresident>("PresidentGet", dp, commandType: CommandType.StoredProcedure);
//                return prez;
//            }
//            bizPresident prez = bizPresident.Get(Id);

//            return prez;
//        }
//        load list
//        private List<bizPresident> LoadListPrez()
//        {
//            return bizPresident.GetAll();
//        }

//        insert new
//        private bizPresident InsertNewPrez()
//        {
//            bizPresident prez = new bizPresident();//new bizPresident();
//            prez.PartyId = maxpartyid;
//            prez.FirstName = "Yonason";
//            prez.LastName = "Adams";
//            prez.DateBorn = DateTime.Now.AddMonths(-450);
//            prez.DateDied = DateTime.Now.AddMonths(24);
//            prez.TermStart = DateTime.Now.Year;

//            DynamicParameters dp = new DynamicParameters(prez);

//            dp.Output<bizPresident>(prez, x => x.PresidentId);
//            dp.Output<bizPresident>(prez, x => x.Num);

//            using (SqlConnection conn = GetConnection())
//            {
//                conn.Execute("PresidentUpdate", dp, commandType: CommandType.StoredProcedure);
//            }
//            dynamic params initialized with prez
//            conn.Execute

//            return prez;
//        }
//        delete

//        private int DeletePrez(int Id = 0)
//        {
//            bizPresident p;

//            if (Id == 0)
//            {
//                p = this.InsertNewPrez();
//            }
//            else
//            {
//                p = this.LoadPrez(Id);
//            }

//            Id = p.PresidentId;

//            p.Delete();

//            return Id;
//        }

//        update
//        private void SwapPrezFirstName(bizPresident prez)
//        {
//            string lastname = prez.LastName;
//            string firstname = prez.FirstName;
//            prez.LastName = firstname;
//            prez.FirstName = lastname;

//            prez.Save();
//        }
//        private void ChangePrezNum()
//        {
//            bizPresident prez = this.LoadPrez(maxprezid);
//            prez.Num = prez.Num + 1;

//            DynamicParameters dp = new DynamicParameters(prez);
//            dp.Add("Message", "", direction: ParameterDirection.InputOutput);
//            dp.Add("return_value", "", direction: ParameterDirection.ReturnValue);

//            using (SqlConnection conn = GetConnection())
//            {
//                conn.Execute("PresidentUpdate", dp, commandType: CommandType.StoredProcedure);
//            }

//            int ret = dp.Get<int>("return_value");
//            string msg = dp.Get<string>("Message");

//            if (ret == 1)
//            {
//                throw new CPUException(msg);
//            }
//        }

//        delete that fails

//        update that fails on validation

//        tests
//        [Test]
//        public void TestLoadPrezList()
//        {
//            List<bizPresident> lst = this.LoadListPrez();
//            TestContext.WriteLine("Num of prez " + lst.Count);
//            Assert.IsTrue(lst.Count == totalprez);
//        }

//        [Test]
//        public void TestLoadPrezByNum()
//        {
//            bizPresident p = bizPresident.Get("Num", maxpreznum);
//            TestContext.WriteLine(p.FullDescription());
//            Assert.IsTrue(p.PresidentId == maxprezid);
//        }


//        [Test]
//        public void TestLoadPrez()
//        {
//            bizPresident p = this.LoadPrez(maxprezid);
//            TestContext.WriteLine(p.FullDescription());
//            Assert.IsTrue(p.Num == maxpreznum);
//        }

//        [Test]
//        public void TestInsertNewPrez()
//        {
//            bizPresident p = this.InsertNewPrez();
//            TestContext.WriteLine("Expected PresidentId > " + (maxprezid) + " Value = " + p.PresidentId);
//            TestContext.WriteLine("Expected Num = " + (maxpreznum + 1) + " Value = " + p.Num);
//            TestContext.WriteLine("Expected Code not blank. Code = " + p.Code);
//            Assert.IsTrue(p.Num == maxpreznum + 1 && p.PresidentId > maxprezid && string.IsNullOrEmpty(p.Code) == false);
//        }

//        [Test]
//        public void TestUpdatePrez()
//        {
//            bizPresident prez = this.LoadPrez(maxprezid);
//            string lastname = prez.LastName;
//            string firstname = prez.FirstName;
//            this.SwapPrezFirstName(prez);
//            prez = this.LoadPrez(maxprezid);
//            TestContext.WriteLine("Original " + firstname + " Current " + lastname + " " + prez.FirstName + " " + prez.LastName);
//            Assert.IsTrue(prez.LastName == firstname && prez.FirstName == lastname);
//        }

//        [Test]
//        public void TestDeleteNewPrez()
//        {
//            int id = this.DeletePrez();
//            bizPresident p = this.LoadPrez(id);
//            Assert.IsTrue(p.PresidentId == 0);
//        }

//        [Test]
//        public void TestDeletePrezWithExecOrder()
//        {
//            CPUException? ex = Assert.Throws<CPUException>(() => this.DeletePrez(prezwithexecorderid));
//            TestContext.WriteLine(ex?.FriendlyMessage);
//        }

//        [Test]
//        public void TestChangePrezNum()
//        {
//            CPUException? ex = Assert.Throws<CPUException>(() => this.ChangePrezNum());
//            TestContext.WriteLine(ex?.Message);
//        }
//        test for load by prim...
//        [Test]
//        public void TestSearchPrez()
//        {
//            List<bizPresident> lst = bizPresident.Search("bush");
//            TestContext.WriteLine("List Count = " + lst.Count.ToString());
//            Assert.IsTrue(lst.Count == 2);
//        }
//    }
//}