﻿using GCBot.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GCBot.Data
{
    public class GcContext : DbContext
    {

        public GcContext() { }

        public virtual DbSet<NoteEntity> NoteEntities { get; set; }

    }
}
