using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyVega.Controllers.Resources;
using MyVega.Models;
using MyVega.Persistence;

namespace MyVega.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        public static VegaDbContext _context;
        private readonly IMapper _mapper;

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            List<Make> makes = await _context.Makes.Include(m => m.Models).ToListAsync();   //vazoume models sti list makes (???)
            return _mapper.Map<List<Make>, List<MakeResource>>(makes);

        }
    }
}