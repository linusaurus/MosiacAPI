using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MosiacAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MosiacAPI.EFcode.Configurations
{
    public class UnitOfPurchaseConfig : IEntityTypeConfiguration<UnitOfPurchase>
    {
        public void Configure(EntityTypeBuilder<UnitOfPurchase> entity)
        {
            entity.HasKey(p => p.UoPID);
        }
    }
}

