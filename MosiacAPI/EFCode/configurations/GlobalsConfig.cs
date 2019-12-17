﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MosiacAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MosiacAPI.EFcode.Configurations
{
    public class GlobalsConfig : IEntityTypeConfiguration<Globals>
    {
        public void Configure(EntityTypeBuilder<Globals> entity)
        {
            entity.HasKey(p => p.GiD);
        }
    }
}