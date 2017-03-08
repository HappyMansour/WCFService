using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST
{
    class RService : RIService
    {
        SqlConnection con = new SqlConnection("Data Source =.\\MSSQL; Initial Catalog = WCFProject; Integrated Security = True");
        SqlCommand com;
        DataSet ds;
        SqlDataAdapter adapter;
        public DataSet GetAll()
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "select a.* from Emp a,Departments b where a.DP_ID=b.DP_ID";
            ds = new DataSet();
            adapter = new SqlDataAdapter(com);
            adapter.Fill(ds);
            return ds;
        }
        public DataSet GetByID(string EMP_ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "select a.*,b.DP_Name from Emp a,Departments b where a.DP_ID=b.DP_ID and a.EMP_ID=" +int.Parse(EMP_ID);
            ds = new DataSet();
            adapter = new SqlDataAdapter(com);
            adapter.Fill(ds);
            return ds;
        }
        public int Insert(string EMP_ID, string Name, string DP_ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Emp values (" +int.Parse(EMP_ID )+ ",'" + Name + "'," + int.Parse(DP_ID )+ ")";
            con.Open();
            int affected = com.ExecuteNonQuery();
            con.Close();
            return affected;

        }

        public int Update(string EMP_ID, string Name, string DP_ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "update Emp set EMP_Name='" + Name + "',DP_ID=" +int.Parse( DP_ID) + "where EMP_ID=" + int.Parse(EMP_ID);
            con.Open();
            int affected = com.ExecuteNonQuery();
            con.Close();
            return affected;

        }

        public int Delete(string EMP_ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from Emp where EMP_ID=" +int.Parse(EMP_ID);
            con.Open();
            int affected = com.ExecuteNonQuery();
            con.Close();
            return affected;

        }




    }

}
