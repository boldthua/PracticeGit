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
        public bool LogIn(UserModel model) 
        {
            if (model.Equals(model))
            {
                return true;
            }
            return false;            
        }
    }
}
