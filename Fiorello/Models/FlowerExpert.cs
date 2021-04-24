using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class FlowerExpert
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string SubTitle { get; set; }
        public string ExpertImage { get; set; }
        public string ExpertName { get; set; }
        public string ExpertPosition { get; set; }
    }
}
