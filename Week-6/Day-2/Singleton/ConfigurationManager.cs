using System;

namespace oopsDesignDemo.Singleton
{
    internal class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static readonly object lockObj = new object();
        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public string DatabaseConnectionString { get; set; }

        private ConfigurationManager()
        {
            ApplicationName = "Inventory System";
            Version = "1.0.0";
            DatabaseConnectionString = "Server=localhost;Database=InventoryDB;";
        }

        public static ConfigurationManager GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }
            }
            return instance;
        }
    }
}
