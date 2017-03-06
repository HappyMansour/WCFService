using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ServiceModel;




namespace project_WCF
{
    
    class Service:IService
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
            ds= new DataSet();
            adapter= new SqlDataAdapter(com);
            adapter.Fill(ds);
            return ds;
        }
        public DataSet GetByID(int EMP_ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "select a.*,b.DP_Name from Emp a,Departments b where a.DP_ID=b.DP_ID and a.EMP_ID=" + EMP_ID;
            ds = new DataSet();
            adapter = new SqlDataAdapter(com);
            adapter.Fill(ds);
            return ds;
        }
        public int Insert(int EMP_ID,string Name,int DP_ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Emp values (" + EMP_ID+",'"+ Name+"',"+ DP_ID +")";
            con.Open();
            int affected = com.ExecuteNonQuery();
            con.Close();
            return affected;
            
        }

        public int Update(int EMP_ID, string Name, int DP_ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "update Emp set EMP_Name='"+ Name+"',DP_ID="+ DP_ID+ "where EMP_ID="+ EMP_ID;
            con.Open();
            int affected = com.ExecuteNonQuery();
            con.Close();
            return affected;

        }

        public int Delete(int EMP_ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from Emp where EMP_ID=" + EMP_ID;
            con.Open();
            int affected = com.ExecuteNonQuery();
            con.Close();
            return affected;

        }




    }
}
