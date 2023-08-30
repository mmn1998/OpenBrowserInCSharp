using System.Diagnostics;

public class Program
{

public static void Main(string[] args)
    {
        Process.Start(new ProcessStartInfo("https://www.google.com/") { UseShellExecute = true });
    }
}
