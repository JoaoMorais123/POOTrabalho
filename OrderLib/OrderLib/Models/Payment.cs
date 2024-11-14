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
    /// Represents a payment made for an order.
    /// </summary>
    public class Payment : Entity
    {
        #region PRIVATE
        private DateTime _paymentDate;
        private Order _order;
        private decimal _amountDue;
        #endregion
        
        #region PUBLIC

        /// <summary>
        /// Gets the payment date.
        /// </summary>
        public DateTime PaymentDate => _paymentDate;

        /// <summary>
        /// Gets the associated order.
        /// </summary>
        public Order Order => _order;
        
        /// <summary>
        /// Gets the amount due for the payment.
        /// </summary>
        public decimal AmountDue => _amountDue;
        
        
        #endregion
        
        #region CONSTRUCTOR
        
        /// <summary>
        /// Initializes a new instance of the Payment class.
        /// </summary>
        /// <param name="id">The unique identifier for the payment.</param>
        /// <param name="order">The associated order for the payment.</param>
        /// <param name="amountDue">The amount due for the payment.</param>
        public Payment(int id, Order order, decimal amountDue)
            : base(id)
        {
            _paymentDate = DateTime.Now;
            _order = order;
            _amountDue = amountDue;
        }

        /// <summary>
        /// Processes the payment for the order.
        /// </summary>
        /// <returns>True if the payment was successfully processed; otherwise, false.</returns>
        public bool ProcessPayment()
        {
            return true;
        }
        
        #endregion
        
        #region METHODS
        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string DisplayInfo()
        {
            throw new NotImplementedException();
        }
        
        #endregion
    }

}