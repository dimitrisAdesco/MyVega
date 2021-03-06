using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyVega.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public Make Make { get; set; }
        public int MakeId { get; set; }   //refers to Make.Id
    }
}