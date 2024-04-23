using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTaskManagementApp.Components.Pages
{
    public class AuthenticateService : IAuthenticateService
    {
        public bool ValidateCredentials(string username, string password)
        {
            return username == "Student" && password == "OOP";
        }
    }
}
