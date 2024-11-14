// -----------------------------------------------------------------------
// Autor: João Marcelo
// E-mail: a23041@alunos.ipca.pt
// Versão: 1.0.0
// Data: ${DATE}
// Discipla: Programação Orientada Objetos
// Licença: MIT
// -----------------------------------------------------------------------

namespace AuthLib.Models
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Person Login(string email, string password);
        bool Logout();
        Person Register(string email, string name, string password);
    }
}