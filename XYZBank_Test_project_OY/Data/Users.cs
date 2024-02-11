using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauce_demo.Data
{
    public class Users
    {
        public enum User
        {
            standard_user,
            locked_out_user,
            problem_user,
            performance_glitch_user,
            error_user,
            visual_user
        }

        public string _password = "secret_sauce";
        

        public string GetPassword()
        {
            return _password;
        }
    }
}
