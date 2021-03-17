namespace MilkTea_TâyTây.EntityClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToppingTable")]
    public partial class ToppingTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ToppingTable()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        [Key]
        [StringLength(10)]
        public string ToppingId { get; set; }

        [Required]
        [StringLength(50)]
        public string ToppingName { get; set; }

        public int ToppingPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
