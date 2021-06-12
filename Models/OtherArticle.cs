using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbProvAPI2.Models
{
    public class OtherArticle
    {
        public long Id { get; set; }
        public long PageId { get; set; }
        public string Link { get; set; }
        public string ImgLink { get; set; }
        public string Text { get; set; }
    }
}
