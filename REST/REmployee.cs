using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace REST
{
    [DataContract]
    public class REmployee
    {
        
            [DataMember(Name = "ID", Order = 0)]
            public int EMP_ID { set; get; }

            [DataMember(Name = "Name", Order = 1)]
            public int EMP_Name { set; get; }


            [DataMember(Name = "Dept_ID", Order = 2)]
            public int DP_ID { set; get; }

            [DataMember(Name = "Dept_Name", Order = 3)]
            public int DP_Name { set; get; }




        
    }
}
