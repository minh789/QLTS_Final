namespace MilkTea_TâyTây.EntityClass
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MilkTeaContextDB : DbContext
    {
        public MilkTeaContextDB()
            : base("name=MilkTeaContextDB")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<OrderCard> OrderCards { get; set; }
        public virtual DbSet<ToppingTable> ToppingTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .Property(e => e.BillId)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.BillDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.BillId)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.DrinkId)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.Ice)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.SUGAR)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .HasMany(e => e.ToppingTables)
                .WithMany(e => e.BillDetails)
                .Map(m => m.ToTable("BillDetailTopping").MapLeftKey("BillDetailId").MapRightKey("ToppingId"));

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Drinks)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drink>()
                .Property(e => e.DrinkId)
                .IsUnicode(false);

            modelBuilder.Entity<Drink>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Drink>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Drink)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drink>()
                .HasMany(e => e.Ingredients)
                .WithMany(e => e.Drinks)
                .Map(m => m.ToTable("Supplies").MapLeftKey("DrinkId").MapRightKey("IngredientID"));

            modelBuilder.Entity<Ingredient>()
                .Property(e => e.IngredientID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCard>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.OrderCard)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ToppingTable>()
                .Property(e => e.ToppingId)
                .IsUnicode(false);
        }
    }
}
