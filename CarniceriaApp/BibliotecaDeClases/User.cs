using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Representa la base para la construccion de varios tipos de usuarios
    /// </summary>
    public abstract class User
    {
        public string Name { get; }
        public string Mail { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Se encarga de inicializar los atributos: nombre, mail y contraseña
        /// </summary>
        /// <param name="name">Recibe el nombre del usuario</param>
        /// <param name="mail">Recibe el mail del usuario</param>
        /// <param name="password">Recibe la contraseña del usuario</param>
        protected User(string name, string mail, string password)
        {
            this.Name = name;
            this.Mail = mail;
            this.Password = password;
        }

        public virtual string ShowInfo()
        {
            string info = $"Nombre: {this.Name}\n" +
                          $"Email: {this.Mail}\n";
            return info;
        }
    }
}
