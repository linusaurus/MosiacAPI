using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MosiacAPI.EFcode;
using Microsoft.EntityFrameworkCore;
using MosiacAPI.DTO;
using MosiacAPI.Models;

namespace MosiacAPI.Services
{
    public class PartService
    {
        private readonly MosiacAPI.EFcode.PurchaseSQLDBContext _context;

        public PartService(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public List<PartDto> AllParts()
        {


            IQueryable<PartDto> PartIQ = _context.Part.Select(p => new PartDto
            {
                PartID = p.PartID,
                Description = p.ItemDescription,
                PartNumber = p.ItemName,
                Location = p.Location,
                SKU = p.SKU  

            }) ;

            return   PartIQ.ToList();
         }

        public PartDto Find(int id)
        {


            IQueryable<PartDto> PartIQ = _context.Part.Where(d=> d.PartID==id).Select(p => new PartDto
            {
                PartID = p.PartID,
                Description = p.ItemDescription,
                PartNumber = p.ItemName,
                Cost = p.Cost,
                Location = p.Location,
                SKU = p.SKU,
                StockOnHand = _context.Inventory.Where(l => l.PartID == p.PartID).Sum(s => s.Qnty)
        });

            return PartIQ.FirstOrDefault();
        }

        public void UpdateStock(int id,decimal level)
        {


           

            
        }

        public void PushStock(int id, decimal amount)
        {





        }
    }
}
