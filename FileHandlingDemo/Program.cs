using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileHandlingDemo
{
    public class Sample
    {
        public Sample()
        {
            Console.WriteLine("sample class constructor");
        }
        public void Display()
        {
            Console.WriteLine("display method");
        }
        //~Sample() { Console.WriteLine("sample class destructor"); }

        internal class Program
        {
            static void Main(string[] args)
            {
                Sample sample = new Sample();
                sample.Display();
                sample = null;
                GC.Collect();
                Console.WriteLine(GC.GetTotalMemory(false));
                GC.Collect();
                Console.WriteLine(GC.MaxGeneration);
            }
        }
    }
}


//            FileInfo file = new FileInfo("C:/Users/ushasrik/Documents/Example.txt");
//            if (!file.Exists)
//            {
//                file.Create().Close();
//            }
//            Console.WriteLine(file.FullName);
//            //file.CopyTo("C:/Users/ushasri/Documents/sample.txt", true);
//            //file.MoveTo("C:/Users/anvithr/Videos/sample_renamed.txt");

//            //file.MoveTo("C:/Users/anvithr/Videos");
//            string sourcedir = @"C:/Users/ushasrik/Documents/Portfolio";
//            string targetdir = @"C:/Users/ushasrik/Documents/Portfolio/sampleDestination";
//            DirectoryInfo sdi = new DirectoryInfo(sourcedir);
//            DirectoryInfo tdi = new DirectoryInfo(targetdir);
//            if (!tdi.Exists)
//            {
//                tdi.Create();
//            }
//            foreach (FileInfo fi in sdi.GetFiles())
//            {
//                fi.CopyTo(Path.Combine(tdi.ToString(), fi.Name), true);
//                Console.WriteLine(@"Copying {0}\{1}", tdi.FullName, fi.Name);
//            }
//            foreach (DirectoryInfo sourceSubDir in sdi.GetDirectories())
//            {
//                DirectoryInfo targetSubDir = tdi.CreateSubdirectory(sourceSubDir.Name);
//                foreach (FileInfo fi in sourceSubDir.GetFiles())
//                {
//                    fi.CopyTo(Path.Combine(targetSubDir.ToString(), fi.Name), true);
//                    Console.WriteLine(@"Copying {0}\{1}", targetSubDir.FullName, fi.Name);
//                }

//            }

//            Console.ReadLine();
//        }
//    }
//}



        //string filePath = "C:/Users/ushasrik/Documents/Example.txt";
        ////Writing to a file
        //using (StreamWriter writer = new StreamWriter(filePath))
        //{
        //    Console.WriteLine("Hello world!!");
        //    Console.WriteLine("This is a sample text");
        //}
        ////Reading to a file
        //using (StreamReader reader = new StreamReader(filePath))
        //{
        //    string content = reader.ReadToEnd();
        //    Console.WriteLine("File content:");
        //    Console.WriteLine(content);
        //}

        ////Appending to a file
        //using (StreamWriter writer = new StreamWriter(filePath))
        //{
        //    writer.WriteLine("Appending a new line to the file");
        //}
        ////Reading the updated file
        //using (StreamReader reader = new StreamReader(filePath))
        //{
        //    string content = reader.ReadToEnd();
        //    Console.WriteLine("Updated File Content:");
        //    Console.WriteLine(content);
        //}
        //    StreamReader reader = null;
        //    try
        //    {
        //        reader = new StreamReader(filePath);
        //        string content = reader.ReadToEnd();
        //        Console.WriteLine(content);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //        {
        //            reader.Close();
        //        }
        //    }

        //    Console.ReadLine();
        //}
    
