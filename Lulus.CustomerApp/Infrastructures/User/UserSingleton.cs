using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.CustomerApp.Infrastructures.User
{
    public sealed class UserSingleton
    {
        static volatile UserSingleton Instance;
        static string Token { get; set; } = "";
        private UserSingleton() { }
        public static void Init(string token)
        {
            Token = token;
        }
        public static UserSingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new UserSingleton();
            }
            return Instance;
        }
        public string GetToken() => Token;
    }
}
