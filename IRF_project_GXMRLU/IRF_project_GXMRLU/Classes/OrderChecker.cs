using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IRF_project_GXMRLU
{
    public class OrderChecker
    {
        public OrderChecker()
        {

        }
        public Order Register(string sender, string senderphone, string senderemail, string name, string address, string gift, int quantity)
        {
            if (!ValidateEmail(senderemail))
                throw new ValidationException(
                    "A megadott e-mail cím nem megfelelő!");
            if (!ValidatePhone(senderphone))
                throw new ValidationException(
                    "A megadottt telefonszám nem megfelelő!\n" +
                    "A következő formátumok elfogadhatóak: 06301061811 vagy +36706227672");

            var order = new Order()
            {
                Sender = sender,
                SenderEmail = senderemail,
                SenderPhone = senderphone,
                Name = name,
                Address = address,
                Gift = gift,
                Quantity = quantity
            };

            return order;

        }
        public bool ValidateEmail(string senderemail)
        {
            return Regex.IsMatch(
                senderemail,
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public bool ValidatePhone(string senderphone)
        {
            return Regex.IsMatch(
               senderphone,
               @"^(\+36|06)([2-9]{1}0|1)([0-9]{7})");
        }
    }
}
