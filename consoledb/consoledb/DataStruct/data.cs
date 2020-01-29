using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using System.IO;

namespace consoledb.DataStruct
{
    // core data classes
    class RootSettingsData
    {
        public string email;
        public string username;
        public string password;

        public string firstName;
        public string lastName;
        public string middleName;
        public string address;
        public string gender;
        public string description;
        public int age;
    }
    class RootGroupData
    {
        public RootSettingsData root_settings = new RootSettingsData();
    }
    class RootDB
    {
        public RootGroupData root_group = new RootGroupData();
    }
    class DirStructData
    {
        public RootDB root_db = new RootDB();
        public DirStructData()
        {
            root_db.root_group.root_settings.email = "";
            root_db.root_group.root_settings.username = "";
            root_db.root_group.root_settings.password = "";
            root_db.root_group.root_settings.firstName = "";
            root_db.root_group.root_settings.middleName = "";
            root_db.root_group.root_settings.lastName = "";
            root_db.root_group.root_settings.address = "";
            root_db.root_group.root_settings.gender = "";
            root_db.root_group.root_settings.description = "";
            //root_db.root_group.root_settings.age = 0;
        }
    }

    class DataHandler
    {
        public static string GetDirStructJson(
            string email = "",
            string username = "",
            string password = "",
            string firstName = "",
            string middleName = "",
            string lastName = "",
            string address = "",
            string gender = "",
            int age = 0
        )
        {
            DirStructData dir = new DirStructData();
            dir.root_db.root_group.root_settings.email =      email;
            dir.root_db.root_group.root_settings.username =   username;
            dir.root_db.root_group.root_settings.password =   password;
            dir.root_db.root_group.root_settings.firstName =  firstName;
            dir.root_db.root_group.root_settings.middleName = middleName;
            dir.root_db.root_group.root_settings.lastName =   lastName;
            dir.root_db.root_group.root_settings.address =    address;
            dir.root_db.root_group.root_settings.gender =     gender;
            dir.root_db.root_group.root_settings.age =        age;

            return JsonConvert.SerializeObject(dir);
        }

        public static DirStructData GetDirObj(string dir)
        {
            DirStructData result = new DirStructData();
            return result;
        }
    }
}
