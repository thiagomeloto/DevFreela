using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string fullname, string email)
        {
            FullName = fullname;
            Email = email;
        }

        public string FullName { get; private set; }        
        public string Email { get; private set; }
    }
}
