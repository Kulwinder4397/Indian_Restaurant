using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Indian_Restaurant.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public int Revenue { get; set; }

        public int Employees { get; set; }

        public int EstablishedYear { get; set; }
    }
}
