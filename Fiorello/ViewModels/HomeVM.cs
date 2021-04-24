using Fiorello.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }

        public SliderContent SliderContents { get; set; }
        public IEnumerable<FlowerCatg> FlowerCatgs { get; set; }
        public IEnumerable<FlowerExpert> FlowerExperts { get; set; }
        public FlowerExpert FlowerExpert { get; set; }
        public IEnumerable<Valentine> Valentines { get; set; }
        public Valentine Valentine { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
        public IEnumerable<SayStart> SayStarts { get; set; }
        public IEnumerable<Instagram> Instagrams { get; set; }


    }
}
