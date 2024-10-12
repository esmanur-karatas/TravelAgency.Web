using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideSurname { get; set; }
        public string GuideDescription { get; set; }
        public string GuideDescription2 { get; set; }
        public string ImageUrl { get; set; }
        public Boolean Status { get; set; }
    }
}
