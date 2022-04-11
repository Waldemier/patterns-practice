using Proxy.Implementations;
using System;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var authService = new AuthService();
            var settings = new ProtectedSettings(authService);
            Console.WriteLine(settings.GetConfig());
        }
    }
}
