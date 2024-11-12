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
            #region 註冊模組
            Console.WriteLine("歡迎使用者登入我們的GIT系統，請先輸入註冊訊息，以利後續登入做使用");
            while (true)
            {
                UserModel registerModel = new UserModel( Console.ReadLine(),  Console.ReadLine(),  Console.ReadLine(),  Console.ReadLine(), Console.ReadLine());
                RegisterService service = new RegisterService();
                bool isSuccess = service.Regist(registerModel);

                if (isSuccess)
                {
                    Console.WriteLine("註冊成功！");
                    break;
                }
                Console.WriteLine("註冊失敗！請重新註冊！");
            }
            #endregion

        }
    }
}
