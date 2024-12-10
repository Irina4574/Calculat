using Calculator1.Presenters;

namespace Calculator1
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
            Form1 window = new Form1();

            Form1Presenter presenter = new Form1Presenter(window);

            Application.Run(window);


        }
    }
}