using Okta.Core;
using Okta.Core.Clients;
using Okta.Core.Models;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloOkta
{
    class Program
    {
        static void Main(string[] args)
        {
            var oktaClient = new OktaClient("00ty358R_ItCrIsZ7BxEA7dkPOJWtlc8Rt40A2JBBK", new Uri("https://piedmont.oktapreview.com"));
            var usersClient = oktaClient.GetUsersClient();

            try
            {
                int i = 1;
                foreach (User user in usersClient)
                {                    
                    Console.WriteLine("User found - " + i++);
                }
            }
            catch (OktaException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Write("Please enter to End");
                Console.Read();
            }
        }
    }
}
