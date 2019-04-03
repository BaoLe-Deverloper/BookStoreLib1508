namespace BookStory.Models.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        public int ID { get; set; }

        public int? BookID { get; set; }

        [StringLength(50)]
        public string OrderID { get; set; }

        public int? amount { get; set; }

        public virtual Book Book { get; set; }

        public virtual Order Order { get; set; }
    }
}
