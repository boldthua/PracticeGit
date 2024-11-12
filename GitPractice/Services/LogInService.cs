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
                return (true, "登入成功"); //若輸入帳號有在資料庫中，回傳true以及成功訊息
            }
            else if (model.Name == "" || model.Password == "") 
            {
                return (false, "輸入欄位不得為空白"); // 若輸入帳密中有空白，則回傳false及失敗訊息
            }
            return (false, "查無此帳號！");            
        }

        public void BugFix(UserModel model)
        {
            // 我修好啦！
        }
    }
}
