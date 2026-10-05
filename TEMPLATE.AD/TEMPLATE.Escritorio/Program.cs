// Projecto (windows form app)
// Referencia Domain

// Al editar Lista, recordar editar tambien Lista.Designer.cs
// para agregar un form simplemente add form


namespace TEMPLATE.Escritorio
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
            Application.Run(new Lista());
        }
    }
}