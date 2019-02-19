using System;

namespace URLEncoder
{
    class CreateAndTestURL{
        public void CreateURL()
        {
            Console.WriteLine("This program will construct a URL for you!");

            Console.WriteLine("Enter your project name:");
            string projectName = Console.ReadLine();

            Console.WriteLine("Enter your activity name:");
            string activityName = Console.ReadLine();

            TestURL(projectName, activityName);

            Console.WriteLine("Your URL is:");
            Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectName.Replace(" ", "%20"), activityName.Replace(" ", "%20"));
        } 

        public void TestURL(string pName, string aName){
            /*
            if(pName.Contains(" ")){
                Console.WriteLine("Project Name contains a space");
                pName.Replace(" ", "%20");
            }
            if (aName.Contains(" "))
            {
                Console.WriteLine("Activity Name contains a space");
                aName.Replace(" ", "%20");
            }
            */
        }
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
