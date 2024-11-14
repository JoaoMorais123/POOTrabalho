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
    /// <summary>
    /// Service for handling authentication and authorization.
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        #region IAuthenticationService Members
        /// <summary>
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Person Login(string email, string password)
        {
            throw new System.NotImplementedException();
        }
        
        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Logout()
        {
            throw new System.NotImplementedException();
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Person Register(string email, string name, string password)
        {
            throw new System.NotImplementedException();
        }
        
        #endregion
    }
}