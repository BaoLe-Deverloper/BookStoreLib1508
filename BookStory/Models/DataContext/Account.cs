namespace BookStory.Models.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Orders = new HashSet<Order>();
        }

        [StringLength(50)]
        public string AccountID { get; set; }

        [Required]
        [StringLength(200)]
        public string AccountName { get; set; }

        [StringLength(100)]
        public string AccountEmail { get; set; }

        [StringLength(300)]
        public string AccountPass { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AccountDateCreate { get; set; }

        [StringLength(400)]
        public string AccountAddress { get; set; }

        [StringLength(20)]
        public string AccountPhoneNumber { get; set; }

        [StringLength(10)]
        public string AccountPostalCode { get; set; }

        [StringLength(10)]
        public string AccountRoleKey { get; set; }

        public bool? AccountVerified { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AccountBirthday { get; set; }

        public bool? AccountGender { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
