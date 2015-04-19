using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Course
{
    class LoadSave
    {
        private static readonly string ConnectionString = @ConfigurationManager.ConnectionStrings["Course.Properties.Settings.CoursesConnectionString"].ToString();
    }
}
