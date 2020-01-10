using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public RootSettingsData root_settings;
    }
    class RootDB
    {
        public RootGroupData root_group;
    }
    class DirStructData
    {
        public RootDB root_db;
    }

    // core data handler
    class CoreDataHandler
    {

        public CoreDataHandler()
        {

        }
    }
}
