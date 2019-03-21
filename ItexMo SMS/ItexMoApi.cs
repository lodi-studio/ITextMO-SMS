using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Twilio_SMS
{
    class ItexMoApi
    {

        public object SendMessage(string number, string message, string code = "TR-SHOEM409737_6LTPQ")
        { 
            object result = null;

            using (System.Net.WebClient client = new System.Net.WebClient()) 
            {
               NameValueCollection parameter = new NameValueCollection();
               string url = "https://www.itexmo.com/php_api/api.php";
               parameter.Add("1", number);
               parameter.Add("2", message);
               parameter.Add("3", code);

               dynamic rpb = client.UploadValues(url, "POST", parameter);

               result = (new System.Text.UTF8Encoding()).GetString(rpb);
            }

            return result;
        }

    }
}
