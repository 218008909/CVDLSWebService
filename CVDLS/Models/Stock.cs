using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CVDLS.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        public string Batch { get; set; }
        public string VaccineType { get; set; }
        [DataType(DataType.Date)] public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public string TagID { get; set; }
        public string Condition { get; set; }
        public string Destination { get; set; }
    }
}
