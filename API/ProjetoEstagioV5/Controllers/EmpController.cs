using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using ProjetoEstagioV5.Model;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoEstagioV5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        db dbop = new db();
        string msg = string.Empty;

        // GET: api/<EmpController>
        [HttpGet]
        /*public List<Product> Get(Int64 Datetimestart, Int64 Datetimeend, string Listzones, string Listaps, string Listdevices, string Listuserprops, int Topreg)
        {
            Product emp = new Product();
            emp.Name = "UniqueVisits";
            emp.Datetimestart = Datetimestart;
            emp.Datetimeend = Datetimeend;
            emp.Listzones = Listzones;
            emp.Listaps = Listaps;
            emp.Listdevices = Listdevices;
            emp.Listuserprops = Listuserprops;
            emp.Topreg = Topreg;
            DataSet ds = dbop.ProductGet(emp, out msg);
            List<Product> list = new List<Product>();
            var result = new List<Product>();
            foreach(DataRow dr in  ds.Tables[0].Rows)
            {

                list.Add(new Product
                {
                    Datetimestart = Convert.ToInt64(dr["Datetimestart"]),
                    Datetimeend = Convert.ToInt64(dr["Datetimeend"]),
                    Listzones = dr["Listzones"].ToString(),
                    Listaps = dr["Listaps"].ToString(),
                    Listdevices = dr["Listdevices"].ToString(),
                    Listuserprops = dr["Listuserprops"].ToString(),
                    Topreg = Convert.ToInt32(dr["Topreg"]),
                });
            }
            return list;

        }
    */
        //string StartDate, string EndDate, int? StudentId = null, int? DeptId = null, int? CollegeId = null, int? SectionId = null
        public string getStudentDetails(string Name,Int64? Datetimestart, Int64? Datetimeend, string Listzones, string Listaps, string Listdevices, string Listuserprops, int? Topreg)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "Data Source=DESKTOP-R7QRMCV;Initial Catalog=DW_NSA;Integrated Security=True;TrustServerCertificate=true";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GetMeasures2";
            sqlCmd.Connection = myConnection;
            sqlCmd.Parameters.AddWithValue("@Name", Name);
            sqlCmd.Parameters.AddWithValue("@datetimestart", Datetimestart);
            sqlCmd.Parameters.AddWithValue("@datetimeend", Datetimeend );
            sqlCmd.Parameters.AddWithValue("@listzones", Listzones);
            sqlCmd.Parameters.AddWithValue("@listaps", Listaps);
            sqlCmd.Parameters.AddWithValue("@listdevices", Listdevices);
            sqlCmd.Parameters.AddWithValue("@listuserprops", Listuserprops);
            sqlCmd.Parameters.AddWithValue("@topreg", Topreg);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            string jsonString = string.Empty;
            myConnection.Open();
            sda.Fill(ds);
            myConnection.Close();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                jsonString = JsonConvert.SerializeObject(ds.Tables[0]);

            }
            return jsonString;
        }

        // GET api/<EmpController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmpController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
