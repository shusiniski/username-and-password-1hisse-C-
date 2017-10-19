using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var user01Obj = new Username("Admin", "123456", "p203");
        }
        class Username
        {
            private string username = "Admin";
            private string password = "123456";
            private string keyword;
            string nom;
            public Username(string _username, string _password, string _keyword)
            {
                Console.WriteLine("Istediyiniz Emrin Kodunu Daxil Edin");

                var nom = Console.ReadLine();

                if (nom == "1")
                {

                    Console.WriteLine("Admin Parolu Yazin");
                    string username = Console.ReadLine();
                    Console.WriteLine("Parolu Yazin");
                    string password = Console.ReadLine();

                    if (_username == username && _password == password)
                    {
                        Console.WriteLine("Daxil Oldunuz");
                    }
                    else
                    {
                        Console.WriteLine("Melumatlariniz Duzgun Deyil Bir de Yoxla");

                        Console.WriteLine("Admin Parolu Yazin");
                        string Username = Console.ReadLine();
                        Console.WriteLine("Parolu Yazin");
                        string Password = Console.ReadLine();

                        if (_username == username && _password == password)
                        {
                            Console.WriteLine("Daxil Oldunuz");
                        }
                    }
                }
            }
        }
    }
}
