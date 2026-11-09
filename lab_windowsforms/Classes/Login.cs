using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_windowsforms.Classes
{
    internal class Login
    {

        private int _id;
        private string _userLogin;
        private string _userPassowrd;
        private string _userProfile;

        public Login(int id, string userLogin, string userPassowrd, string userProfile)
        {

            this._id = id;
            this._userLogin = userLogin;
            this._userPassowrd = userPassowrd;
            this._userProfile = userProfile;
        } // Método construtor


        public bool autenticar(string username, string password)
        {
            return username == this._userLogin && password == this._userPassowrd;
           

        } // Autenticar



    }
}
