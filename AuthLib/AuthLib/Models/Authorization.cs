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
    public class Authorization
    {
        /// <summary>
        /// Specifies the authorization level for a person.
        /// </summary>
        public enum AuthorizationLevel
        {
            Admin,
            User
        }
    }
}