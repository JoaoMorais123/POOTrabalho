// -----------------------------------------------------------------------
// Autor: João Marcelo
// E-mail: a23041@alunos.ipca.pt
// Versão: 1.0.0
// Data: ${DATE}
// Discipla: Programação Orientada Objetos
// Licença: MIT
// -----------------------------------------------------------------------

using System;

namespace OrderLib.Models
{
    /// <summary>
    /// Base class representing a general entity with common properties.
    /// </summary>
    public abstract class Entity
    {
        #region Public
        public int ID { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public abstract string DisplayInfo();
        #endregion
        
        #region Protected
        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        protected Entity(int id)
        {
            ID = id;
            CreatedDate = DateTime.Now;
        }
        #endregion
    }
}