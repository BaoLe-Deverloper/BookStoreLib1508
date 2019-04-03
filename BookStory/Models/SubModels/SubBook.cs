using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStory.Models.SubModels
{
    public class SubBook
    {

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

    }
}