using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyVega.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MyVega.Controllers.Resources
{
    public partial class VehicleResource
    {
        public int Id { get; set; }
        public int ModelId { get; set; } //foreign key
        public bool IsRegistered { get; set; }

        public ContactResource Contact { get; set; }
        public ICollection<int> Features { get; set; } //ICollection<VehicleFeature> theloume mono to id opote int

        public VehicleResource()
        {
            Features = new Collection<int>();
        }

    }
}