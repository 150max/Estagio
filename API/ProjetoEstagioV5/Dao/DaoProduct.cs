/*using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using ProjetoEstagioV5.Model;
using System.Collections.Generic;

namespace ProjetoEstagioV5.Dao
{
    public class DaoProduct
    {
        string conexao = "Data Source=DESKTOP-R7QRMCV;Initial Catalog=DW_NSA;Integrated Security=True";

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();   

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand  cmd = new SqlCommand("[dbo].[GetMeasures2]", conn))
                {
                    string msg = string.Empty;
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var product = new Product();
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@datetimestart", product.Datetimestart);
                        cmd.Parameters.AddWithValue("@datetimeend", product.Datetimeend);
                        cmd.Parameters.AddWithValue("@listzones", product.Listzones);
                        cmd.Parameters.AddWithValue("@listaps", product.Listaps);
                        cmd.Parameters.AddWithValue("@listdevices", product.Listdevices);
                        cmd.Parameters.AddWithValue("@listuserprops", product.Listuserprops);
                        cmd.Parameters.AddWithValue("@topreg", product.Topreg);
                        products.Add(product);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        msg = "Success";
                    }

                    catch(Exception ex)
                    {
                        msg = ex.Message;
                    }
                    finally
                    {
                        if (conn.State==ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }

            }

            return products;
        }

    }
    
}
*/