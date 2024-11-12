using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitPractice.Models;
using GitPractice.Services;

namespace GitPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserModel registerModel = new UserModel( Console.ReadLine(),  Console.ReadLine(),  Console.ReadLine(),  Console.ReadLine(), Console.ReadLine());
            RegisterService service = new RegisterService();
            bool isSuccess = service.Regist(registerModel);

            if (isSuccess)
            {
                Console.WriteLine("註冊成功！");
            }
            else
            {
                Console.WriteLine("註冊失敗！");
            }
        }
    }
}
