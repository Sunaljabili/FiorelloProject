using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class SayStart
    {
        public int Id { get; set; }
        
        public string ExpertImage { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string ExpertName { get; set; }
        [MaxLength(50)]
        public string ExpertPosition { get; set; }
    }
}
