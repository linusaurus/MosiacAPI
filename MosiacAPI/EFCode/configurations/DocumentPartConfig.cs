using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MosiacAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MosiacAPI.EFcode.Configurations
{
    public class DocumentPartConfig : IEntityTypeConfiguration<DocumentParts>
    {
        public  void  Configure( EntityTypeBuilder<DocumentParts> entity)
        {
            entity.HasKey(p => new { p.DocID, p.PartID });

            //---------------------------------------------
            // Relationships

           
        }
    }
}
