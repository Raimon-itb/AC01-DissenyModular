
public class Program
{
    public static void Main()
    {
        const string MsgInputNumber = "What number you want to validate: ";
        const string MsgResult = "Range [{0},{1}], number {2} ----> {3}";
        const string MsgFormatError = "The input number is not the correct format. Only integer numbers allowed.";

        const int Maxim = 50;
        const int Minim = 10;

        int number = 0;
        bool validated = false;
        

        Console.WriteLine(MsgInputNumber);
        try 
        {
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(number);
            validated = Validar(number, Minim, Maxim);

            Console.Write(MsgResult, Minim, Maxim, number, validated);
        } 
        catch (FormatException)
        {
            Console.WriteLine(MsgFormatError,number);
        }
        

    }
    public static bool Validar(int num, int min, int max)
    {

        if (num < max && num > min)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
