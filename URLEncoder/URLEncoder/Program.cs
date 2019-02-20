using System;

namespace URLEncoder
{
    class CreateAndTestURL
    {
        public void CreateURL()
        {
            Console.WriteLine("This program will construct a URL for you!");

            string projectName = "";
            string activityName = "";

            string selectCase = "y";
            while (selectCase == "y")
            {
                switch (selectCase)
            {

                case "y":
                    int acceptableInput = 69;
                while (acceptableInput != 0)
                {
                    Console.WriteLine("Enter your project name:");
                    projectName = Console.ReadLine();
                    acceptableInput = RestrictedInput(projectName);

                }

                acceptableInput = 69;
                while (acceptableInput != 0)
                {
                    Console.WriteLine("Enter your activity name:");
                    activityName = Console.ReadLine();
                    acceptableInput = RestrictedInput(activityName);
                }

                Console.WriteLine("Successful input! Creating your URL...");
                TestURL(projectName, activityName);
                       break;

                default:
                    Console.WriteLine("ALERT! Something went wrong! Try again.");
                break;
            }

                Console.WriteLine("Would you like to create another URL?");
                Console.WriteLine("Enter y for yes or any key to exit:");
                selectCase = Console.ReadLine();

                if (selectCase == "y") { selectCase = "y"; } 
                else { Console.WriteLine("All done. Have a nice day!"); }
            }

            //Console.WriteLine("Your Un-Edited URL is:");
            //Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectName, activityName);
        }

        public int RestrictedInput(string Input)
        {
            if (Input == "")
            {
                Console.WriteLine("Input cannot be blank, please enter new input.");
                return 1;
            }
            else if (Input == "%00")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%01")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%02")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%03")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%04")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%05")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%06")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%07")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%08")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%09")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%10")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%11")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%12")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%13")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%14")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%15")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%16")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%17")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%18")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%19")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%1A")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%1B")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%1C")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%1D")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%1E")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%1F")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%0A")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%0B")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%0C")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%0D")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%0E")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else if (Input == "%0F")
            {
                Console.WriteLine("ALERT! Input invalid. Cannot use control characters!");
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void TestURL(string URLname, string URLactivity)
        {
            string URL = URLname + URLactivity;
            string URL1 = URLname;
            string URL2 = URLactivity;

            if (URL.Contains("%"))
            {
                Console.WriteLine("URL contains %");
                URL1 = URL1.Replace("%", "%25");
                URL2 = URL2.Replace("%", "%25");
            }

            if (URL.Contains(";"))
            {
                Console.WriteLine("URL contains ;");
                URL1 = URL1.Replace(";", "%3B");
                URL2 = URL2.Replace(";", "%3B");
            }

            if (URL.Contains("/"))
            {
                Console.WriteLine("URL contains /");
                URL1 = URL1.Replace("/", "%2F");
                URL2 = URL2.Replace("/", "%2F");
            }

            if (URL.Contains("?"))
            {
                Console.WriteLine("URL contains ?");
                URL1 = URL1.Replace("?", "%3F");
                URL2 = URL2.Replace("?", "%3F");
            }

            if (URL.Contains(":"))
            {
                Console.WriteLine("URL contains :");
                URL1 = URL1.Replace(":", "%3A");
                URL2 = URL2.Replace(":", "%3A");
            }

            if (URL.Contains("@"))
            {
                Console.WriteLine("URL contains @");
                URL1 = URL1.Replace("@", "%40");
                URL2 = URL2.Replace("@", "%40");
            }

            if (URL.Contains("&"))
            {
                Console.WriteLine("URL contains &");
                URL1 = URL1.Replace("&", "%26");
                URL2 = URL2.Replace("&", "%26");
            }

            if (URL.Contains("="))
            {
                Console.WriteLine("URL contains =");
                URL1 = URL1.Replace("=", "%3D");
                URL2 = URL2.Replace("=", "%3D");
            }

            if (URL.Contains("+"))
            {
                Console.WriteLine("URL contains +");
                URL1 = URL1.Replace("+", "%2B");
                URL2 = URL2.Replace("+", "%2B");
            }

            if (URL.Contains("$"))
            {
                Console.WriteLine("URL contains $");
                URL1 = URL1.Replace("$", "%24");
                URL2 = URL2.Replace("$", "%24");
            }

            if (URL.Contains(","))
            {
                Console.WriteLine("URL contains ,");
                URL1 = URL1.Replace(",", "%2C");
                URL2 = URL2.Replace(",", "%2C");
            }

            if (URL.Contains("<"))
            {
                Console.WriteLine("URL contains <");
                URL1 = URL1.Replace("<", "%3C");
                URL2 = URL2.Replace("<", "%3C");
            }

            if (URL.Contains(">"))
            {
                Console.WriteLine("URL contains >");
                URL1 = URL1.Replace(">", "%3E");
                URL2 = URL2.Replace(">", "%3E");
            }

            if (URL.Contains("#"))
            {
                Console.WriteLine("URL contains #");
                URL1 = URL1.Replace("#", "%23");
                URL2 = URL2.Replace("#", "%23");
            }

            if (URL.Contains("\""))
            {
                Console.WriteLine("URL contains \"");
                URL1 = URL1.Replace("\"", "%22");
                URL2 = URL2.Replace("\"", "%22");
            }

            if (URL.Contains(" "))
            {
                Console.WriteLine("URL contains [space]");
                URL1 = URL1.Replace(" ", "%20");
                URL2 = URL2.Replace(" ", "%20");
            }

            if (URL.Contains("{"))
            {
                Console.WriteLine("URL contains {");
                URL1 = URL1.Replace("{", "%7B");
                URL2 = URL2.Replace("{", "%7B");
            }

            if (URL.Contains("}"))
            {
                Console.WriteLine("URL contains }");
                URL1 = URL1.Replace("}", "%7D");
                URL2 = URL2.Replace("}", "%7D");
            }

            if (URL.Contains("|"))
            {
                Console.WriteLine("URL contains |");
                URL1 = URL1.Replace("|", "%7C");
                URL2 = URL2.Replace("|", "%7C");
            }

            if (URL.Contains("\\"))
            {
                Console.WriteLine("URL contains \\");
                URL1 = URL1.Replace("\\", "%5C");
                URL2 = URL2.Replace("\\", "%5C");
            }

            if (URL.Contains("^"))
            {
                Console.WriteLine("URL contains ^");
                URL1 = URL1.Replace("^", "%5E");
                URL2 = URL2.Replace("^", "%5E");
            }

            if (URL.Contains("["))
            {
                Console.WriteLine("URL contains [");
                URL1 = URL1.Replace("[", "%5B");
                URL2 = URL2.Replace("[", "%5B");
            }

            if (URL.Contains("]"))
            {
                Console.WriteLine("URL contains ]");
                URL1 = URL1.Replace("]", "%5D");
                URL2 = URL2.Replace("]", "%5D");
            }

            if (URL.Contains("`"))
            {
                Console.WriteLine("URL contains `");
                URL1 = URL1.Replace("`", "%60");
                URL2 = URL2.Replace("`", "%60");
            }

            Console.WriteLine("Your URL is:");
            Console.WriteLine("https://companyserver.com/content/" + URL1 + "/files/" + URL2 + "/" + URL2 + "Report.pdf");

        }



        class MainClass
        {
            public static void Main(string[] args)
            {
                var URL1 = new CreateAndTestURL();
                URL1.CreateURL();

            }
        }

    }
}
