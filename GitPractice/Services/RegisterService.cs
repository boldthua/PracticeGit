using System;
using GitPractice.Models;

namespace GitPractice.Services
{
    public class RegisterService
    {
        public bool Regist(UserModel model)
        {
            if (model.Account.Equals("leo604leo604@gmail.com"))
            {
                Console.WriteLine("帳號已存在，請重新輸入帳號");
                return false;
            }

            return true;
        }

    }
}