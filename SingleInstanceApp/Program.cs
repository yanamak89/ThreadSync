class Program
{
    public static void Main(string[] args)
    {
        string mutexName = "Global\\MyUniqueSingleInstanceApp";

        using (Mutex mutex = new Mutex(false, mutexName, out bool isNewInstance))
        {
            if (!isNewInstance)
            {
                Console.WriteLine("Another instance of this application is already running. Existing...");
                return;
            }

            Console.WriteLine("Application is running. Press Enter to exit...");
            Console.ReadLine();
        }
    }
}