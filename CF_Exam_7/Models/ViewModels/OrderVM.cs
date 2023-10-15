using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CF_Exam_7.Models.ViewModels
{
    public class OrderVM
    {
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }

        public int Quantity { get; set; }

        public decimal Rate { get; set; }

        public string OrderNo { get; set; }

        public DateTime OrderDate { get; set; }

        public string Description { get; set; }

        public string AddressProofImage { get; set; }

        public Nullable<bool> Terms { get; set; }
    }
}