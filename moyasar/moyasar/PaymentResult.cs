using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moyasar
{
   public class PaymentResult
    {
       public string Id { get; set; }
       public string Status { get; set; }
       public double   Amount { get; set; }
       public double Fee { get; set; }
       public string Currency { get; set; }
       public double Refunded { get; set; }
       public string Refunded_at { get; set; }
       public string Description { get; set; }
       public string Invoice_Id { get; set; }
       public string IP { get; set; }
       public string Created_at { get; set; }
       public string Updated_at { get; set; }

    }
}
