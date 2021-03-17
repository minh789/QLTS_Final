namespace MilkTea_TâyTây.EntityClass
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ingredient")]
    public partial class Ingredient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient()
        {
            Drinks = new HashSet<Drink>();
        }

        [StringLength(10)]
        public string IngredientID { get; set; }

        [Required]
        [StringLength(100)]
        public string IngredientName { get; set; }

        public long IngredientPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime ProducedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpiryDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Drink> Drinks { get; set; }
    }
}
