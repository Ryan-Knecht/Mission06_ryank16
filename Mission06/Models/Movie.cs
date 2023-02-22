using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class Movie
    {
        //Create an autoincrementing key for the database
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        //The rest are not required fields
        public bool Edited { get; set; }

        public string LentTo { get; set; }

        //Create a range and verify the notes are within the range
        [Range(0,25,ErrorMessage ="Must be within 25 characters")]
        public string Notes { get; set; }



        //Build foreign key relation
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
