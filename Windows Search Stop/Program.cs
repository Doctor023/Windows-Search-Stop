using System.Diagnostics;

namespace Windows_Search_Stop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "net stop \"Windows seach\"";

        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        processStartInfo.FileName = "powershell.exe"; 
        processStartInfo.Arguments = $"-Command {command}"; 
        processStartInfo.RedirectStandardOutput = true;
        processStartInfo.UseShellExecute = false;
        processStartInfo.CreateNoWindow = true;

        // Запускаем процесс
        Process process = new Process();
        process.StartInfo = processStartInfo;
        process.Start();

        string output = process.StandardOutput.ReadToEnd();

        Console.WriteLine(output);

        process.WaitForExit();
        }
    }
}