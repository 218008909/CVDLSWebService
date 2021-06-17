using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVDLS.Models
{
    public class Location
    {
        public string LocationID { get; set; }
        public bool Stationary { get; set; }
        public string Title { get; set; }
        public string Coordinates { get; set; }
        public DateTime DateRecorded { get; set; }
        public string TagsInLocation { get; set; }
    }
}
