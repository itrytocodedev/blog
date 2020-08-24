using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itrytocode.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int CreatedBy { get; set; }
        public int IsActive { get; set; }
    }
}
