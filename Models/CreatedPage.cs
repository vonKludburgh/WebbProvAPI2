using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbProvAPI.Models
{
    public class CreatedPage
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool Header { get; set; }
        public bool Right { get; set; }
        public bool Footer { get; set; }
        public long Order { get; set; }
        public DateTime TimeStamp { get; set; }
        public string FooterString { get; set; }

        //Style Main
        public string FontMain { get; set; }
        public string BgColor { get; set; }
        public string BorderColor { get; set; }
        public string BorderType { get; set; }
        //public byte[] ImgData { get; set; }
        //public bool ImgBool { get; set; }

        ////Style Header
        public string FontHeader { get; set; }
        public string ColorHeader { get; set; }
        public string BorderColorHeader { get; set; }
        public string BorderTypeHeader { get; set; }
        //public byte[] ImgDataHeader { get; set; }
        //public bool ImgBoolHeader { get; set; }

        ////Style Left
        public string FontLeftbar { get; set; }
        public string ColorLeftbar { get; set; }
        public string BorderColorLeftbar { get; set; }
        public string BorderTypeLeftbar { get; set; }
        //public byte[] ImgDataLeftbar { get; set; }
        //public bool ImgBoolLeftbar { get; set; }

        ////Style Right
        public string ColorRightbar { get; set; }
        public string BorderColorRightbar { get; set; }
        public string BorderTypeRightbar { get; set; }
        //public byte[] ImgDataRightbar { get; set; }
        //public bool ImgBoolRightbar { get; set; }

        ////Style Footer
        public string FontFooter { get; set; }
        public string ColorFooter { get; set; }
        public string BorderColorFooter { get; set; }
        public string BorderTypeFooter { get; set; }

        public long Count { get; set; }
    }
}
