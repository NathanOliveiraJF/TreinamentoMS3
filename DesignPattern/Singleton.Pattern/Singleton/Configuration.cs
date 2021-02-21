using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Configuration : IConfiguration
    {
        private Configuration()
        {
        }

        public static IConfiguration Instancia 
        {
            get 
            {
                if (instancia == null)
                    instancia = new Configuration();

                return instancia;
            }
        }

        public  string LogFilePath { get; set; }
        public  string DataBase { get; set; }

        private static Configuration instancia = null;
    }
}
