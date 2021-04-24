using Fiorello.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<FlowerCatg> FlowerCatgs { get; set; }
        public DbSet<FlowerExpert> FlowerExperts { get; set; }
        public DbSet<Valentine> Valentines { get; set; }
        public DbSet<SayStart> SayStarts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }
    }
}
