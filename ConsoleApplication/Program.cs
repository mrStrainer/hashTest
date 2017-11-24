using System;

namespace ConsoleApplication
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("User:");
            var user = Console.ReadLine();
            
            Console.WriteLine("Pass:");
            var pass = Console.ReadLine();
            
            var hashedPass = SecurePasswordHasher.SecurePasswordHasher.Hash(pass);
            var isEqual = SecurePasswordHasher.SecurePasswordHasher.Verify(pass, hashedPass);
            
            Console.WriteLine($"User: { user }\n Pass: { pass }");
            Console.WriteLine($"Hashed pass: { hashedPass } \n Verification: { isEqual }");

            Console.ReadLine();
        }
    }
}