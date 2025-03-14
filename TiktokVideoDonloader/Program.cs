namespace TiktokVideoDonloader
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static frmHome HOME_FORM; 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            HOME_FORM = new frmHome();
            Application.Run(HOME_FORM);
        }
    }
}