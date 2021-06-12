using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbProvAPI.Models
{
    public class Link
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public bool Video { get; set; }
        public string LinkString { get; set; }
    }
}
