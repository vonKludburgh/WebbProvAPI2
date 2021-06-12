using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbProvAPI.Models;
using WebbProvAPI2.Models;

namespace WebbProvAPI2.Data
{
    public class WebbProvAPI2Context : DbContext
    {
        public WebbProvAPI2Context (DbContextOptions<WebbProvAPI2Context> options)
            : base(options)
        {
        }

        public DbSet<WebbProvAPI.Models.Article> Articles { get; set; }

        public DbSet<WebbProvAPI.Models.CreatedPage> CreatedPages { get; set; }

        public DbSet<WebbProvAPI.Models.Document> Documents { get; set; }

        public DbSet<WebbProvAPI.Models.Image> Images { get; set; }

        public DbSet<WebbProvAPI.Models.Link> Links { get; set; }

        public DbSet<WebbProvAPI2.Models.OtherArticle> OtherArticles { get; set; }
    }
}
