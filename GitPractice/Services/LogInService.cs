using GitPractice.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractice.Services
{
    internal class LogInService
    {
        public (bool, string) LogIn(UserModel model) 
        {
            if (model.Equals(model))
            {
                return (true, "登入成功");
            }
            else if (model.Name == "" || model.Password == "") 
            {
                return (false, "輸入欄位不得為空白");
            }
            return (false, "查無此帳號！");            
        }
    }
}
