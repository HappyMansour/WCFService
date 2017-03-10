using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Client
{
    public partial class Client : System.Web.UI.Page
    {
        EmpServiceRef.ServiceClient c=new EmpServiceRef.ServiceClient("BasicHttpBinding_IService");
        public static DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void View_btn_Click(object sender, EventArgs e)
        {
            ds = c.GetAll();
            ListBox1.DataSource = ds;
            ListBox1.DataBind();
            
        }

    }
}