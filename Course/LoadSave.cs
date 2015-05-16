using System.Configuration;

namespace Course
{
    class LoadSave
    {
        private static readonly string ConnectionString = @ConfigurationManager.ConnectionStrings["Course.Properties.Settings.CoursesConnectionString"].ToString();
    }
}
