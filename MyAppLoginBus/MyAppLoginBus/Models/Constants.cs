using System;
using System.Collections.Generic;
using System.Text;

namespace MyAppLoginBus.Models
{
    internal class Constants
    {
        public static string ConnectionString = "server=52.29.239.198;uid=sql7586795;port=3306;pwd=plArJjb22x;database=sql7586795";
        public static string InsertNewUser = "INSERT INTO USERS (USERNAME, PASS, EMAIL) VALUES (@USERNAME, @PASSWORD, @EMAIL);";
        public static string SelectALL = "SELECT * FROM USERS;";

    }
}
