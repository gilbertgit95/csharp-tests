using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoledb.Services;
using consoledb.DataStruct;

namespace consoledb
{
    // the core proccess handler
    class CoreHandler
    {

        public CoreHandler()
        {
            // check if the initial 
        }
    }

    // the Entry point class of the application
    class Program
    {
        static void Main(string[] args)
        {
            // FileHandler fHandler = new FileHandler();
            // Console.WriteLine("Base directory: " + fHandler.baseDir);

            // String baseDir = FileHandler.GetBasePath();
            // FileHandler.CreateDir(baseDir + "/gil-test");

            string baseDir = FileHandler.GetBasePath() + "/.consoledb";
            FileHandler.CreateDir(baseDir);

            baseDir += "/test.txt";
            FileHandler.WriteFile(baseDir, "gilbert-testing \n test");

            Console.WriteLine(FileHandler.ReadFileConcat(baseDir));

            Console.ReadKey();

            // json testing
            CoreDataHandler coreData = new CoreDataHandler();
            

            Console.ReadKey();
            // FileHandler.DeleteDir(baseDir + "/gil-test");
        }
    }
}
