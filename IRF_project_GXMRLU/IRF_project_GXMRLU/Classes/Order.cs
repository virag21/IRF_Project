using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IRF_project_GXMRLU
{
   public class Order
    {
        public string Sender { get; set; }
        public string SenderPhone { get; set; }
        public string SenderEmail { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gift { get; set; }
        public int Quantity { get; set; }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

    }
}
