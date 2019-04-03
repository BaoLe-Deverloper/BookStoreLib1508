namespace BookStory.Models.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbBookStore : DbContext
    {
        public DbBookStore()
            : base("name=DbBookStore")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookType> BookTypes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountPass)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountPostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountRoleKey)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.OrderUserID);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.Author)
                .HasForeignKey(e => e.BookAuthorID);

            modelBuilder.Entity<Book>()
                .Property(e => e.BookTypeKey)
                .IsUnicode(false);

            modelBuilder.Entity<BookType>()
                .Property(e => e.BookTypesKey)
                .IsUnicode(false);

            modelBuilder.Entity<BookType>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.BookType)
                .HasForeignKey(e => e.BookTypeKey);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderUserID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderState)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.Publisher)
                .HasForeignKey(e => e.BookPublisherID);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleKey)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Accounts)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.AccountRoleKey);
        }
    }
}
