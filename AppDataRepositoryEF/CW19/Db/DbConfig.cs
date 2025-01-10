using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepositoryEF.CW19.Db
{
    public static class DbConfig
    {
        public static string ConnectionString { get; set; }
        static DbConfig()
        {
            //DESKTOP-1MKPIBC
            //DESKTOP-G8DPHTL
            ConnectionString = @"Server=DESKTOP-1MKPIBC;Database=CW19;Integrated Security=True;TrustServerCertificate=True;";
        }
    }
}
