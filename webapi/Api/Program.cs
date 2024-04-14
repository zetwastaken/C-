public class APITest
{
    public HttpClient client; public async Task GetData()
    {
        client = new HttpClient();
        string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
        string response = await client.GetStringAsync(call);
        Console.WriteLine(response);
    }
}

namespace Api
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            APITest t = new APITest();
            t.GetData().Wait();
        }
    }
}
