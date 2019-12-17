using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MosiacAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MosiacAPI.EFcode.Configurations
{
    public class PartTypeConfig : IEntityTypeConfiguration<PartType>
    {
        public void Configure(EntityTypeBuilder<PartType> entity)
        {
            entity.HasKey(p => p.PartTypeID);
        }
    }
}