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
    /// Represents a line item within an order.
    /// </summary>
    public class OrderLine
    {

        #region Private
        private Product _product;
        private int _quantity;
        private decimal _unitPrice;
        #endregion

        #region Public
        public int Quantity => _quantity;
        public decimal UnitPrice => _unitPrice;
        public double TotalWeight => _product.Weight * _quantity;
        public decimal TotalPrice => _unitPrice * _quantity;
        #endregion
        
        #region Constructor
        public OrderLine(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
            _unitPrice = product.UnitPrice;
        }
        #endregion
    }
}