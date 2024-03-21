using System.Threading.Tasks;
using Task1;
using Task2;
using Task3;
using Task4;
using Task5;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select the task number(1-5): ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Task1.Program.Main_Task1();
                    break;

                case 2:
                    Task2.Program.Main_Task2();
                    break;

                case 3:
                    Task3.Program.Main_Task3();
                    break;

                case 4:
                    Task4.Program.Main_Task4();
                    break;

                case 5:
                    Task5.Program.Main_Task5();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}