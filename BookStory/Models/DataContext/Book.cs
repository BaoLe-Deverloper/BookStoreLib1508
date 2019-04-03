namespace BookStory.Models.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int BookID { get; set; }

        [StringLength(300)]
        public string BookName { get; set; }

        [StringLength(300)]
        public string BookTitle { get; set; }

        public double? BookPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BookDatePost { get; set; }

        public int? BookQuantity { get; set; }

        public int? BookAuthorID { get; set; }

        public int? BookPublisherID { get; set; }

        [StringLength(50)]
        public string BookTypeKey { get; set; }

        public virtual Author Author { get; set; }

        public virtual BookType BookType { get; set; }

        public virtual Publisher Publisher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
