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
        }
    }

    class DataHandler
    {
        public static string GetDirStructJson(string email, string username, string password)
        {
            DirStructData dir = new DirStructData();
            dir.root_db.root_group.root_settings.email = email != null? email: "";
            dir.root_db.root_group.root_settings.username = username != null ? username : "";
            dir.root_db.root_group.root_settings.password = password != null ? password : "";

            return JsonConvert.SerializeObject(dir);
        }

        public static DirStructData GetDirObj(string dir)
        {
            DirStructData result = new DirStructData();
            return result;
        }
    }
}
