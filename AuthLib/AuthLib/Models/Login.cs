// -----------------------------------------------------------------------
// Autor: João Marcelo
// E-mail: a23041@alunos.ipca.pt
// Versão: 1.0.0
// Data: ${DATE}
// Discipla: Programação Orientada Objetos
// Licença: MIT
// -----------------------------------------------------------------------

using System;

namespace AuthLib.Models
{
    /// <summary>
    /// Represents a login session with relevant session details.
    /// </summary>
    public class Login
    {
        #region Private
        private DateTime _loginTime;
        private DateTime? _logoutTime;
        private bool _isSuccessful; 
        private string _ipAddress;
        #endregion

        #region Public
        /// <summary>
        /// Gets the login time.
        /// </summary>
        public DateTime LoginTime => _loginTime;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Gets or sets the logout time.
        /// </summary>
        public DateTime? LogoutTime
        {
            get => _logoutTime;
            set => _logoutTime = value;
        }

        /// <summary>
        /// Gets the login status.
        /// </summary>
        public bool IsSuccessful => _isSuccessful;

        /// <summary>
        /// Gets the IP address of the login session.
        /// </summary>
        public string IpAddress => _ipAddress;

            /// <summary>
            /// Initializes a new instance of the Login class.
            /// </summary>
            /// <param name="loginTime">Time of login.</param>
            /// <param name="isSuccessful">Indicates if login was successful.</param>
            /// <param name="ipAddress">IP address of the user.</param>
            public Login(DateTime loginTime, bool isSuccessful, string ipAddress)
            {
                _loginTime = loginTime;
                _isSuccessful = isSuccessful;
                _ipAddress = ipAddress;
            }
            
            #endregion
        }
}