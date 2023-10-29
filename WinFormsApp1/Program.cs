namespace WinFormsApp1
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
<<<<<<< HEAD
            Application.Run(new Snakes());
=======
            Application.Run(new Form1());
>>>>>>> 83cacf4f895b7177023aeb680f5297020f207d3d
        }
    }
}