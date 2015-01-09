using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Mvc4DDD.MVC.EndUserApp.Helpers
{
    public static class ConnectionStringHelper
    {
        /// <summary>
        /// As the database is inside another project and doesn't have a full path, it was necessary 
        /// create this helper to find the database.
        /// </summary>
        /// <returns></returns>
        public static String GetConnectionString()
        {
            String path = "\"" + Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.FullName +
                          "\\Mvc4DDD.Administration\\App_Data\\Mvc4DDD.mdf\"";

            //String path = "\"C:\\Users\\Guto\\Documents\\Visual Studio 2013\\Projects\\Mvc4DDD\\Mvc4DDD.Administration\\App_Data\\Mvc4DDD.mdf\"";
            return String.Format("Data Source=(LocalDb)\\v11.0;AttachDbFilename={0};Initial Catalog=Mvc4DDD;Integrated Security=True", path);
        }
    }
}