using System.Timers;
using Timer = System.Timers.Timer;

class Program
{
    static List<string> SuspiciousIps = new List<string>();
    static HashSet<string> BlockedIps = new HashSet<string>();
    static Timer monitoringTimer;

    public static void Main(string[] args)
    {
        Console.WriteLine("Starting aitomated event monitoring...");

        AddSuspiciousEvent("192.168.1.1");
        AddSuspiciousEvent("192.168.1.2");

        monitoringTimer = new Timer(5000);
        monitoringTimer.Elapsed += MonitorEvents;
        monitoringTimer.AutoReset = true;
        monitoringTimer.Start();
        AddSuspiciousEvent("192.168.1.3");
        AddSuspiciousEvent("192.168.1.4");

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
    static void AddSuspiciousEvent(string ipAddress)
    {
        Console.WriteLine($"Detected suspicious activity from IP: {ipAddress}");
        SuspiciousIps.Add(ipAddress);
    }
    static void MonitorEvents(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine("Monitoring suspicious events...");
        foreach (var ip in SuspiciousIps.ToList())
        {
            if (!BlockedIps.Contains(ip))
            {
                BlockIp(ip);
                SuspiciousIps.Remove(ip);
            }
        }
        
    }
    static void BlockIp(string ipAddress)
    {
        Console.WriteLine($"Blocking IP: {ipAddress}");
        BlockedIps.Add(ipAddress);

    }
}