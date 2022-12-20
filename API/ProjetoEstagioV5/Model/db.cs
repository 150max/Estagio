using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoEstagioV5.Model;
using System.Data;

namespace ProjetoEstagioV5.Model
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R7QRMCV;Initial Catalog=DW_NSA;Integrated Security=True");

        public string Product(Product emp)
        {
            string msg = string.Empty;
            try
            {
                SqlCommand com = new SqlCommand("GetMeasures2",con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name",emp.Name);
                com.Parameters.AddWithValue("@datetimestart",emp.Datetimestart);
                com.Parameters.AddWithValue("@datetimeend",emp.Datetimeend);
                com.Parameters.AddWithValue("@listzones",emp.Listzones);
                com.Parameters.AddWithValue("@listaps",emp.Listaps);
                com.Parameters.AddWithValue("@listdevices",emp.Listdevices);
                com.Parameters.AddWithValue("@listuserprops",emp.Listuserprops);
                com.Parameters.AddWithValue("8@topreg",emp.Topreg);
                var returnParameter = com.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                msg = "Success";
                var result = returnParameter.Value;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return msg;
        }

        //GET
        public DataSet ProductGet(Product emp,out string msg)
        {
            msg = string.Empty;
            DataSet ds = new DataSet();
            try
            {
                SqlCommand com = new SqlCommand("GetMeasures2", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", emp.Name);
                com.Parameters.AddWithValue("@datetimestart", emp.Datetimestart);
                com.Parameters.AddWithValue("@datetimeend", emp.Datetimeend);
                com.Parameters.AddWithValue("@listzones", emp.Listzones);
                com.Parameters.AddWithValue("@listaps", emp.Listaps);
                com.Parameters.AddWithValue("@listdevices", emp.Listdevices);
                com.Parameters.AddWithValue("@listuserprops", emp.Listuserprops);
                com.Parameters.AddWithValue("8@topreg", emp.Topreg);
                var returnParameter = com.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                msg = "SUCCESS";
                var result = returnParameter.Value;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            } 
            return ds;
        }
    }
}
