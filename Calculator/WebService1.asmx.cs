using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;



namespace Calculator
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        [WebMethod]
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        

        [WebMethod]
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        [WebMethod]
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }


    }
}
