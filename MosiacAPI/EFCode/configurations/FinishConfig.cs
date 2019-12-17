using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MosiacAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MosiacAPI.EFcode.Configurations
{
    public class FinishConfig : IEntityTypeConfiguration<Finish>
    {
        public void Configure(EntityTypeBuilder<Finish> entity)
        {
            entity.HasKey(p => p.FinishID);
        }
    }
}