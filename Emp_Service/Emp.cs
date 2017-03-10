namespace Emp_Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Emp")]
    public partial class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Emp_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Emp_Name { get; set; }

        public int DP_ID { get; set; }

        public virtual Department Department { get; set; }
    }
}
