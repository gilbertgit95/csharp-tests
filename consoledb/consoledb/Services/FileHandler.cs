using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace consoledb.Services
{
    // the file handler class
    class FileHandler
    {
        public string baseDir;

        public FileHandler()
        {
            baseDir = GetBasePath();
        }

        public static string GetBasePath()
        {
            return Directory.GetCurrentDirectory();
        }

        public static void CreateDir(string dir)
        {
            Directory.CreateDirectory(dir);
        }

        public static void DeleteDir(string path)
        {
            Directory.Delete(path, true);
        }

        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public static void WriteFile(string path, string content)
        {
            StreamWriter str = new StreamWriter(path);

            str.WriteLine(content);
            str.Flush();
            str.Close();
        }


        public static List<string> ReadFileByLine(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> content = new List<string> { };

            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = reader.ReadLine();

            while (str != null)
            {
                content.Add(str);
                str = reader.ReadLine();
            }

            return content;
        }

        public static string ReadFileConcat(string path)
        {
            List<string> content = ReadFileByLine(path);
            return String.Join("", content);
        }


        public static bool IsPathExisted(string path)
        {
            return File.Exists(path);
        }

    }

}
