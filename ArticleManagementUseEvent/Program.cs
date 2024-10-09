namespace ArticleManagementUseEvent
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize the application configuration
            ApplicationConfiguration.Initialize();

            // Create the main form
            frmArticlesPublisher articlesPublisher = new frmArticlesPublisher();

            // Open the other forms on separate threads, to run them in parallel
            System.Threading.Thread form1Thread = new System.Threading.Thread(() => Application.Run(new frmSubscribers(1)));
            System.Threading.Thread form2Thread = new System.Threading.Thread(() => Application.Run(new frmSubscribers(2)));

            // Start the additional forms
            form1Thread.Start();
            form2Thread.Start();

            // Run the main form
            Application.Run(articlesPublisher);

        }
    }
}