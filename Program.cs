using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        const string MenuPrint = "===DEGREE CONVERSOR===";
        const string Option1 = "1.Convert Celssius to Fahrenheit";
        const string Option2 = "2.Convert Fahrenheit to Celssius";
        const string Option3 = "3. Convert Celssius to Kelvin";
        const string Exit = "0. Exit";
        const string MsgExit = "Exiting Conversor...";
        const string MsgInputDegree = "What tempeture want to get: ";
        const string MsgOption = "What conversion you want to do(Options 1-3): ";
        const string MsgResult = "Youre temperature is {0}º";
        const string MsgFormatError = "The input degree is not the correct format. Only decimals allowed.";
        const string MsgOptionError = "The input option is not a correct option. Options 0 - 3.";
        const int MaxTries = 3;

        float temperature = 0;
        float degree = 0;
        int option = 0;
        int tries = 0;



        do
        {

            try
            {
                Console.WriteLine(MsgInputDegree);
                temperature = float.Parse(Console.ReadLine());

                Console.WriteLine(MenuPrint);
                Console.WriteLine("");
                Console.WriteLine(Option1);
                Console.WriteLine(Option2);
                Console.WriteLine(Option3);
                Console.WriteLine(Exit);
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine(MsgOption);
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        degree = ConversioFareheid(temperature);
                        degree = (float)Math.Round(degree, 2);
                        Console.WriteLine(MsgResult, degree);
                        break;
                    case 2:
                        degree = ConversioCelssius(temperature);
                        degree = (float)Math.Round(degree, 2);
                        Console.WriteLine(MsgResult, degree);
                        break;
                    case 3:
                        degree = ConversioKelvin(temperature);
                        degree = (float)Math.Round(degree, 2);
                        Console.WriteLine(MsgResult, degree);
                        break;
                    case 0:
                        Console.WriteLine(MsgExit);
                        return;
                    default:
                        Console.WriteLine(MsgOptionError);
                        tries++;
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
            catch (FormatException)
            {
                Console.WriteLine(MsgFormatError);

                tries++;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (tries < MaxTries);




    }
    public static float ConversioCelssius(float degree)
    {
        return (degree - 32) * 5 / 9;

    }
    public static float ConversioFareheid(float degree)
    {
        return degree * 9 / 5 + 32;

    }
    public static float ConversioKelvin(float degree)
    {
        return degree + 273.15f;

    }
}
