namespace MilkTea_TâyTây.EntityClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Drink")]
    public partial class Drink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drink()
        {
            BillDetails = new HashSet<BillDetail>();
            Ingredients = new HashSet<Ingredient>();
        }

        [StringLength(10)]
        public string DrinkId { get; set; }

        [Required]
        [StringLength(10)]
        public string CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string DrinkName { get; set; }

        public int Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
