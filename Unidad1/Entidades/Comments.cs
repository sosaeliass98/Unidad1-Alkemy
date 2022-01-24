using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.Entidades
{
    internal class Comments
    {
        [Key]
        public int CommentId { get; set; }
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
        public User? User { get; set; }
    }
}
