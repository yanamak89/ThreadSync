class Program
{
    // Створення Semaphore з максимальним доступом 2 потоки одночасно
    private static Semaphore semaphore = new Semaphore(2, 4);
    private static string logFilePath = "access.log";

    public static void Main(string[] args)
    {
        Console.WriteLine("Starting application...");

        // Очищення або створення нового файлу логу
        if (File.Exists(logFilePath))
        {
            File.Delete(logFilePath);
        }

        for (int i = 1; i <= 5; i++)
        {
            int thereadId = i;
            Thread thread = new Thread(() => AccessResource(thereadId));
            thread.Start();
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    static void AccessResource(int threadId)
    {
        Console.WriteLine($"Thread {threadId} is waiting for access...");
        semaphore.WaitOne();// Чекаємо доступу до ресурсу
        try
        {
            Console.WriteLine($"Thread {threadId} has gained access.");
            WriteLog($"Thread {threadId} accessed the resource at {DateTime.Now}");
                
            Thread.Sleep(2000);
        }
        finally 
        {
            Console.WriteLine($"Thread {threadId} is releasing access.");
            semaphore.Release();
        }
    }

    static void WriteLog(string message) 
    {
        lock (logFilePath) // Забезпечуємо впорядкованість запису
        { 
            using (StreamWriter writer = new StreamWriter(logFilePath, true)) 
            { 
                writer.WriteLine(message);
            }
        }
    }
}
