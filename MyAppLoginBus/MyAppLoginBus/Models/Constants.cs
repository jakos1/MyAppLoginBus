using System;
using System.Collections.Generic;
using System.Text;

namespace MyAppLoginBus.Models
{
    internal class Constants
    {
        public static string ConnectionString = "server=52.29.239.198;uid=sql7588242;port=3306;pwd=A2W5nt7NDv;database=sql7588242";
        public static string InsertNewUser = "INSERT INTO USERS (USERNAME, PASS, EMAIL) VALUES (@USERNAME, @PASSWORD, @EMAIL);";
        public static string SelectALL = "SELECT * FROM USERS;";
    }
}
