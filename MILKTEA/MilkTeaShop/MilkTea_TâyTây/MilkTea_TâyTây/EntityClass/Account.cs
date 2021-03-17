namespace MilkTea_TâyTây.EntityClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(100)]
        public string PassWord { get; set; }

        [Required]
        [StringLength(100)]
        public string Position { get; set; }
    }
}
