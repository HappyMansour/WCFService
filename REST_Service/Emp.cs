namespace REST_Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Emp")]
    public partial class Emp
    {
        [Key]
        [DataMember(Name = "ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Emp_ID { get; set; }

        [DataMember(Name = "Name", Order = 1)]
        [Required]
        [StringLength(50)]
        public string Emp_Name { get; set; }

        [DataMember(Name = "Dept_ID", Order = 2)]
        public int DP_ID { get; set; }

        public virtual Department Department { get; set; }
    }
}
