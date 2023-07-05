using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface IConnection<T>
    {
        public T ExtractUser(int id);
        public T ExtractUser(string email, string password);

        public void InsertUser(T entity);

        public bool ValidateCredentials(string email, string password);
    }
}
