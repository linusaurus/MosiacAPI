using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MosiacAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace MosiacAPI.DTO
{
    public class PartDto
    {
        public int PartID { get; set; }
        public string Description { get; set; }
      
        public string PartNumber { get; set; }
        public string Location { get; set; }
        public string SKU { get; set; }
    }
}
