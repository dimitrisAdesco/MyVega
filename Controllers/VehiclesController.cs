using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyVega.Controllers.Resources;
using MyVega.Models;
using MyVega.Persistence;

namespace MyVega.Controllers
{
    [Route("api/vehicles")]
    public class VehiclesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly VegaDbContext _context;
        public VehiclesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        
        [HttpPost]
        public IActionResult CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = _mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            return Ok(vehicle);

        }
    }
}