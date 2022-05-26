using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyService
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://CalculateWebService.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public double TotalPrice(double price, double weight, double dds)
        {
            double totalPrice;
            double ddsPrice;
            double weightTax = 0;
            if (weight >= 0.50 && weight <= 1.00) 
            {
               weightTax = 4.99;
            }
            else 
            if(weight>=1.01 && weight <=2.00)
            {
                weightTax = 5.77;
            }
            else
            {
                weightTax = 6.50;
            }
            ddsPrice = (price * (dds / 100));
            totalPrice = ddsPrice + price + weightTax;
            return totalPrice;
           
        }
    }
}
