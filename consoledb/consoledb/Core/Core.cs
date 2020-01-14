using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using consoledb.Services;
using consoledb.DataStruct;

namespace consoledb.Core
{
    class CoreProccess
    {
        public CoreProccess()
        {
            string baseDir = FileHandler.GetBasePath();
            string dir = "/.consoledb";
            string fileDir = "/settings.json";

            //string fileContent = "test content";
            // create file test
            //FileHandler.CreateDir(baseDir + dir);
            //FileHandler.WriteFile(baseDir + dir + fileDir, fileContent);

            // delete file test
            //FileHandler.DeleteFile(baseDir + dir + fileDir);
            //FileHandler.DeleteDir(baseDir + dir);

            string jsonData = DataHandler.GetDirStructJson(
                email: "gilbert.cuerbo@gmail.com",
                username: "gilbertgit",
                password: "pass"
            );
            FileHandler.CreateDir(baseDir + dir);
            FileHandler.WriteFile(baseDir + dir + fileDir, jsonData);

            Console.WriteLine(jsonData);
            Console.ReadKey();
        }
    }
}
