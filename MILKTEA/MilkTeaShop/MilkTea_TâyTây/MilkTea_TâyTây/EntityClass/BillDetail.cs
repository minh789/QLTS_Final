namespace MilkTea_TâyTây.EntityClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillDetail")]
    public partial class BillDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillDetail()
        {
            ToppingTables = new HashSet<ToppingTable>();
        }

        [StringLength(20)]
        public string BillDetailId { get; set; }

        [Required]
        [StringLength(20)]
        public string BillId { get; set; }

        [Required]
        [StringLength(10)]
        public string DrinkId { get; set; }

        public int Number { get; set; }

        [Required]
        [StringLength(10)]
        public string Size { get; set; }

        [Required]
        [StringLength(10)]
        public string Ice { get; set; }

        [Required]
        [StringLength(10)]
        public string SUGAR { get; set; }

        public int BillDetailPrice { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Drink Drink { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToppingTable> ToppingTables { get; set; }
    }
}
