using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.Entidades
{
    internal class Posts
    {
        [Key]
        public int PostId { get; set; }
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? Content { get; set; }
        public User? User { get; set; }

    }
}
