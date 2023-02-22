using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission06.Models
{
    public class Category
    {
        /*Make the category class*/
        [Key]
        [Required]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
