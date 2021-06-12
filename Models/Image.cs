using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbProvAPI.Models
{
    public class Image
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public byte[] ImageData { get; set; }
        public string Title { get; set; }
        public long PageId { get; set; }
        public string Location { get; set; }
    }
}

