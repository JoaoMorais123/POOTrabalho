// -----------------------------------------------------------------------
// Autor: João Marcelo
// E-mail: a23041@alunos.ipca.pt
// Versão: 1.0.0
// Data: ${DATE}
// Discipla: Programação Orientada Objetos
// Licença: MIT
// -----------------------------------------------------------------------

namespace OrderLib.Models
{
    /// <summary>
    /// Represents a car accessory with additional categorization.
    /// </summary>
    public class CarAccessory : Product
    {
        #region PRIVATE
        private string _accessoryCategory;
        #endregion
        
        #region PUBLIC
        /// <summary>
        /// Gets the accessory category.
        /// </summary>
        public string AccessoryCategory => _accessoryCategory;
        #endregion
        
        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the CarAccessory class with specified details.
        /// </summary>
        /// <param name="id">The unique identifier for the product.</param>
        /// <param name="name">The name of the accessory.</param>
        /// <param name="stockQuantity">The stock quantity available.</param>
        /// <param name="weight">The weight of the accessory.</param>
        /// <param name="unitPrice">The price per unit of the accessory.</param>
        /// <param name="accessoryCategory">The category of the accessory.</param>
        public CarAccessory(int id, string name, int stockQuantity, double weight, decimal unitPrice, string accessoryCategory)
            : base(id, name, stockQuantity, weight, unitPrice)
        {
            _accessoryCategory = accessoryCategory;
        }
        #endregion
    }
}