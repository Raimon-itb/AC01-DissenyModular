
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        const string IniciCalculador = "===Calculator of Parking Ticket===";
        const string MsgInici = "First you put the hours you want to calculate (if its less than 1 hour put 0) and then the minuts!";
        const string MsgHours = "How many hours did you stay: ";
        const string MsgMinuts = "How many minuts did you stay: ";
        const string MsgResult = "The price for {0}:{1} hours is {2}€!";
        const string MsgFormatError = "Format error. Hours and minuts have to be integer numbers";

        int hours = 0;
        int minuts = 0;
        float totalTime = 0;
        float finalPrice = 0;
        bool format = false;

        Console.WriteLine(IniciCalculador);
        Console.WriteLine("");
        Console.WriteLine(MsgInici);
        Console.WriteLine("");
        while (!format)
        {
            try
            {
                Console.WriteLine(MsgHours);
                hours = Int32.Parse(Console.ReadLine());
                Console.WriteLine(MsgMinuts);
                minuts = Int32.Parse(Console.ReadLine());
                Console.Clear();

                totalTime = hours + (minuts / 60f);
                totalTime = (float)Math.Round(totalTime, 2);

                finalPrice = CalculadoraParking(totalTime);
                finalPrice = (float)Math.Round(finalPrice, 2);

                Console.WriteLine(MsgResult, hours, minuts, finalPrice);


            }
            catch (FormatException)
            {
                Console.WriteLine(MsgFormatError);
                Console.WriteLine("");
            }
        }
        
    }
    public static float CalculadoraParking(float hour)
    {
        if (hour <= 1)
        {
            return 3.50f;
        }
        else if (hour >= 2 && hour <= 5)
        {
            return 2.00f * hour;
        }
        else
        {
            return 1.50f * hour;
        }
        
    }
}
