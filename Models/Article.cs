using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbProvAPI.Models
{
    public class Article
    {
        public long Id { get; set; }
        public long PageId { get; set; }
        public long Order { get; set; }
        public string Header { get; set; }
        public string Paragraph { get; set; }
        public DateTime TimeStamp { get; set; }        
        public bool Published { get; set; }

        //Style
        public string HeaderFont { get; set; }
        public string BgColor { get; set; }
        public string BorderColor { get; set; }
        public string BorderType { get; set; }
        //public byte[] ImgDataBack { get; set; }
        //public bool ImgBool { get; set; }
        public string ImgWidth { get; set; }
        public string LinkType { get; set; }
    }
}
