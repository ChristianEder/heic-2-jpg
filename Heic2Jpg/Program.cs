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
            using (var progressBar = new ProgressBar(heics.Length, "Converting .heic files to .jpg"))
            {
                foreach (string heic in heics)
                {
                    using (var image = new MagickImage(heic))
                    {
                        image.Write(heic.Replace(Path.GetExtension(heic), ".jpg"));
                    }

                    try
                    {
                        File.Delete(heic);
                    }
                    catch
                    {
                    }

                    progressBar.Tick();
                }
            }
        }
    }
}
