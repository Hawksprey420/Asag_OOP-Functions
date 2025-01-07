namespace Asag_OOP_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Intro intro = new Intro();
                intro.Intro_Main();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LeapYear leapYear = new LeapYear();
                        LeapYear.LeapYear_Main();
                        break;

                    case 2:
                        Heron heronsFormula = new Heron();
                        Heron.Heron_Main();
                        break;

                    case 3:
                        Console.WriteLine("Are you sure? Y or N?");
                        string confirm = Console.ReadLine();
                        if (confirm == "Y" || confirm == "y")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            continue;
                        }
                        continue; 
                }
            }
        }
    }
}