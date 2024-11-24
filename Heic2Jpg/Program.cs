using System.IO;
using System.Linq;
using ImageMagick;
using ShellProgressBar;

namespace Heic2Jpg
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = args.Any() ? args.Single() : Directory.GetCurrentDirectory();
            var heics = Directory.GetFiles(path, "*.heic", SearchOption.AllDirectories);
            if(!heics.Any())
            {
                System.Console.WriteLine("No .heic files found in folder " + path);    
            }
            System.Console.WriteLine("Found " + heics.Count() + " .heics");
            
            //using (var progressBar = new ProgressBar(heics.Length, "Converting .heic files to .jpg"))
            {
                foreach (string heic in heics)
                {
                    System.Console.WriteLine("Trying to convert " + heic);
                    try
                    {
                        using (var image = new MagickImage(heic))
                        {
                            image.Write(heic.Replace(Path.GetExtension(heic), ".jpg"));
                        }    
                    }
                    catch(System.Exception e)
                    {
                        System.Console.WriteLine("Could not convert " + heic + ":" + e.ToString());
                        continue;
                    }

                    try
                    {
                        File.Delete(heic);
                    }
                    catch
                    {
                        System.Console.WriteLine("Could not delete " + heic);
                    }

                    //progressBar.Tick();
                }
            }

            System.Console.WriteLine("Converted .heics");
        }
    }
}
