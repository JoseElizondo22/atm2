using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm2
{
    class Program
    {
        public static void Main()
        {
            string msg = BePrepared(44,44.0f,.66f,"sunny");
            Console.WriteLine(msg);

            msg = BePrepared(55, 66.2f, .22f, "windy");
            Console.WriteLine(msg);

            msg = BePrepared(66, 22.3f, .45f, "forecast");
            Console.WriteLine(msg);
        }
        static string BePrepared(int temp, float wind, float rain, string forecast)
        {
            string message = "what should i wear: ";
            if (temp < 32)
                message += "put on heavy coat\n";
            switch (forecast)
            {
                case "sunny":
                    message += "put on your sun glasses\n";

                    message += "put on sun screen\n";
                    break;
                case "windy":
                    message += "wear a coat\n";
                    break;

                case "snowy":
                    message += "wear your boots\n";
                    break;
            }
           
            if (temp > 30 && temp < 40)
            message += "wear your mittens:\n ";
          

            if (temp == 40)
            message += "Do you have a long sleeve shirt:\n ";
          

            if (temp > 70)
            message += "short sleeve shirt will be fine\n";
            
            if (temp > 110)
            message += "Move out of Texas\n";
            
            if (wind < 10.8)
            message += "nothing extra\n";

            if (wind > 10.8 && wind < 45.5)
            message +="Put on wind breaker\n";

            if (wind > 45.5 && wind < 75.2)
            message += "Stay in doors\n";

            if (wind > 75.2)
            message += "Get to the storm cellar\n";

            if (rain < .10)
            message += "dont worry about it\n";

            if (rain > .35)
            message += "take an umbrella\n";

            if (rain > .8)
            message += "stay home read a book\n";

            return message;

            }
        }
    }


