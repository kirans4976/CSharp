using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"E:\Temp\Demos\FileSystem";

            /*
             * .getDirectories(rootPath) returns  a string[] of dirs(filepath of foldernames only)
             * if folder contains subfolders and to include that we must specify * search pattern, searchoption parameters
              this is danger when ur looking into c drive as it contains lots of file, u can avoid this by using additional params
             * 
             * 
             

            */
            //string[] dirs = Directory.GetDirectories(rootPath,"*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}


            /*
                *search pattern & top directories will get only file but not under subfolder
                *to get all files including subfolder, AllDirectories pram must specify
               
             */
            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            //*.xslx means only xslx files
            //*folder*.*  means filename conists of folder


            //foreach (string file in files)
            //{
            //    //Console.WriteLine(file); // returns all filenames along with filepath
            //    //Console.WriteLine(Path.GetFileName(file));// returns only filename
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));// not fileName included only directory
            //                         Path.GetFullPath
            //    var info = new FileInfo(file); //info object will consists open,lastread/access

            //    Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");// getting file info
            
            //}

            //string newPath = @"E:\Temp\Demos\FileSystem\SubFolderC\SubSubFolderD";
            //Directory.CreateDirectory(newPath); // this is enough & not chech directory exists
            //bool directoryExists = Directory.Exists(newPath);

            //if (directoryExists)
            //{
            //    Console.WriteLine("The directory exists");
            //}
            //else
            //{
            //    Console.WriteLine("The directory does not exist");
            //    Directory.CreateDirectory(newPath);
            //}

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"E:\Temp\Demos\FileSystem\SubFolderA\";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationFolder}{ Path.GetFileName(file) }", true); // overrite true
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{ i }.txt", false); //1.txt
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}{ Path.GetFileName(file) }"); // cut & paste
            //}

            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //Console.WriteLine(Path.GetDirectoryName(file));
                //var info = new FileInfo(file);

                //Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");
            }

            Console.ReadLine();

            // generall can be used in file logs(lg files within log folder)
        }
    }
}
