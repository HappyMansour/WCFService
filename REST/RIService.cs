using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace REST
{

    [ServiceContract]
    public interface RIService
    {
        // http://.........../Employees
        [WebGet(UriTemplate = "Employees")]
        [OperationContract]
        DataSet GetAll();

        // http://.........../Employee/1
        [WebGet(UriTemplate = "Employee/{EMP_ID}")]
        [OperationContract]
        DataSet GetByID(string EMP_ID);


        // POST http://.........../Employee
        [WebInvoke(Method = "POST", UriTemplate = "Employee")]
        [OperationContract]
        int Insert(string EMP_ID, string Name, string DP_ID);

        // PUT http://.........../Employee/1
        [WebInvoke(Method = "PUT", UriTemplate = "Employee/{EMP_ID}")]
        [OperationContract]
        int Update(string EMP_ID, string Name, string DP_ID);


        [WebInvoke(Method = "DELETE", UriTemplate = "Employee/{EMP_ID}")]
        [OperationContract]
        int Delete(string EMP_ID);







    }
}
