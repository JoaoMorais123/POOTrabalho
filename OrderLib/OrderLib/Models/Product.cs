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
    /// Represents a product with stock and pricing information.
    /// </summary>
    public class Product : Entity
    {
        
        #region PRIVATE
        private string _name;
        private int _stockQuantity;
        private double _weight;
        private decimal _unitPrice;
        #endregion

        #region PUBLIC
        public string Name => _name;
        public double Weight => _weight;
        public decimal UnitPrice => _unitPrice;
        
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="stockQuantity"></param>
        /// <param name="weight"></param>
        /// <param name="unitPrice"></param>
        public Product(int id, string name, int stockQuantity, double weight, decimal unitPrice)
            : base(id)
        {
            _name = name;
            _stockQuantity = stockQuantity;
            _weight = weight;
            _unitPrice = unitPrice;
        }
        
        #endregion
        
        
        #region METHODS
        /// <summary>
        /// Checks if the specified quantity is available in stock.
        /// </summary>
        /// <param name="quantity">Quantity to check.</param>
        /// <returns>True if the quantity is available; otherwise, false.</returns>
        public bool IsStockAvailable(int quantity) => _stockQuantity >= quantity;

        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string DisplayInfo()
        {
            throw new System.NotImplementedException();
        }
        
        #endregion
    }
    
}