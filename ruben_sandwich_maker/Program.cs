using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<string> repoUrls = new List<string>
        {
            "https://github.com/BenjaminRogersSeng/Rube-Phase-Java",        //Phase 1
            //"https://github.com/yourusername/VBProject",                  //Phase 2
            "https://github.com/BenjaminRogersSeng/Rube-Phase-Blackmail",   //Phase 3
        };

        string cloneDirectory = @"C:\RubeGoldbergProjects";

        foreach (var url in repoUrls)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo()
                    {
                        FileName = "git",
                        Arguments = "clone " + url,
                        WorkingDirectory = "C:/CODE/Common-Rube-Machine/",
                    }
                };
                process.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cloning {url}: {ex.Message}");
            }
        }    
    }
}
