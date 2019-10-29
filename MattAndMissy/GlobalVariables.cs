using System;

namespace MattAndMissy
{
    public static class GlobalVariables
    {
        public static string DatabaseConnectionString = Environment.GetEnvironmentVariable("DatabaseConnectionString");
    }
}
