using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbProvAPI.Models
{
    public class Document
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public byte[] DocData { get; set; }
        public string Title { get; set; }
    }
}
