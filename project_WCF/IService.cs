using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace project_WCF
{
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        DataSet GetAll();

        [OperationContract]
        DataSet GetByID(int EMP_ID);


        [OperationContract]
        int Insert(int EMP_ID, string Name, int DP_ID);

        [OperationContract]
        int Update(int EMP_ID, string Name, int DP_ID);

        [OperationContract]
        int Delete(int EMP_ID);







    }
}
