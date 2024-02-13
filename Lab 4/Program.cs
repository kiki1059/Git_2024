using System.Text;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidEmployeeId("E12345")== true);
            Console.WriteLine(IsValidEmployeeId("E123") == false);
            Console.WriteLine(IsValidEmployeeId("P12345") == false);
            Console.WriteLine(IsValidEmployeeId("") == false);

            Console.WriteLine(IsValidHoursWorked(20) == true);

            Console.WriteLine(IsValidPayRate(5) == true);

        }

        static bool IsValidEmployeeId(string input)
        {
         if (input.Length  != 6) 
            {
                return false;
            }

         if (input[0] != 'E')
            {
                return false;
            }

            return true;
            
        }

        static bool IsValidHoursWorked(double hours)
        {
            if (hours > 10 && hours < 50)
                {
                    return true;
                }

                return false;
        }

        static bool IsValidPayRate(double PayRate)
        {
            if (PayRate !> 10 && PayRate !< 65)
            {
                return true;
            }

            return false;
        }



    }
}
