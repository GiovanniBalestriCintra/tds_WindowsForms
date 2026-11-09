using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_windowsforms.Classes
{
    public class Login
    {

        private int _id;
        private string _nome;
        private string _userLogin;
        private string _userPassowrd;
        private string _userProfile;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string UserLogin { get => _userLogin; set => _userLogin = value; }
        public string UserPassowrd { get => _userPassowrd; set => _userPassowrd = value; }
        public string UserProfile { get => _userProfile; set => _userProfile = value; }


        public Login(int id, string nome, string userLogin, string userPassowrd, string userProfile)
        {

            this._id = id;
            this._nome = nome;
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
