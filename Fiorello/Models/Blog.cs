using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string SubTitle { get; set; }
        public string CardImage { get; set; }
        [MaxLength(50)]
        public string CardTitle { get; set; }
        [MaxLength(150)]
        public string CardBody { get; set; }
        public DateTime Date { get; set; }
    }
}
