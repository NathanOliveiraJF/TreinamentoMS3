using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    interface IConfiguration
    {
       string LogFilePath { get; set; }
       string DataBase { get; set; }
    }
}
