using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MosiacAPI.Services;
using MosiacAPI.Models;
using MosiacAPI.EFcode;
using MosiacAPI.DTO;

namespace MosiacAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private readonly PurchaseSQLDBContext _context;

        public PartController(PurchaseSQLDBContext context)
        {
            _context = context;

            if (_context.Part.Count() == 0)
            {
                // Create a new Part if collection is empty,
                // which means you can't delete all Parts.
                _context.Part.Add(new Models.Part { ItemDescription = "Part-1" });
                _context.SaveChanges();
            }
        }


        [HttpGet]
        [Route("api/part")]
        public ActionResult<List<PartDto>> GetAll()
        {
            PartService partService = new PartService(_context);
            return partService.AllParts();
            //return _context.Part.ToList();
        }

        [HttpGet("{id}", Name = "GetPart")]
        public ActionResult<PartDto> GetById(int id)
        {
            PartService partService = new PartService(_context);

            var item = partService.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Create(Part item)
        {
            _context.Part.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetPart", new { id = item.PartID }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, Part item)
        {
            var part = _context.Part.Find(id);
            if (part == null)
            {
                return NotFound();
            }

            part.Location = item.Location;
            part.ItemDescription = item.ItemDescription;

            _context.Part.Update(part);
            _context.SaveChanges();
            return NoContent();
        }
    }
}