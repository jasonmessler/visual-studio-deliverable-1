using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace regex1
{
    class Program
    {
        static void Main(string[] args)
        {

            string greeting = "Welcome! Please create a password. The password must contain: \n At least one lowercase letter \n At least one uppercase letter \n A minimum of 7 characters \n A maximum of 12 characters \n An exclamation point:!"; 
            string valid = "Password valid and accepted";
            string error = "Error";

            Console.WriteLine(greeting); //point 1
            string userInput = Console.ReadLine(); //point 2


            
            string regexPattern = @"^(?=.*[A-Z])(?=.*[a-z]).{7,12}(?=.*\!)";  // has point 3: ?=.*[A-Z] == at least 1 uppercase, point 4: ?=.*[a-z] == at least 1 lowercase, point 5: minchar 7 & point 6: maxchar 12 == .{7,12}, pont 7: \! == exclamation point
            var regex = new Regex(regexPattern);

            if (new Regex(regexPattern).IsMatch(userInput))
            {
                Console.WriteLine(valid); //point 8
                }
             else {
                Console.WriteLine(error); //point 9
            }

            Console.WriteLine("press enter to exit");
            Console.ReadLine();



            

             

        }
    }
}
