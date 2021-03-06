﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MosiacAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MosiacAPI.EFcode.Configurations
{ 
    public class InventoryConfig : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> entity)
        {
            entity.HasKey(p => p.StockTransactionID);
        }
    }
}
