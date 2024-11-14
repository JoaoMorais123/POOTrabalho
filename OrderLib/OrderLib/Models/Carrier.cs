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
    /// Represents a shipping carrier with shipping cost calculation.
    /// </summary>
    public class Carrier
    {

        #region Private
        private string _name;
        private decimal _shippingCostPerKg;
        private int _deliveryTimeInDays;
        #endregion
        
        #region Public
        public string Name => _name;
        public decimal ShippingCostPerKg => _shippingCostPerKg;
        public int EstimatedDeliveryTime => _deliveryTimeInDays;
        #endregion
        
        #region Constructor
        public Carrier(string name, decimal shippingCostPerKg, int deliveryTimeInDays)
        {
            _name = name;
            _shippingCostPerKg = shippingCostPerKg;
            _deliveryTimeInDays = deliveryTimeInDays;
        }
        #endregion
        
        #region Public methods
        /// <summary>
        /// Calculates the total shipping cost based on weight.
        /// </summary>
        /// <param name="totalWeight">Total weight of the order.</param>
        /// <returns>Total shipping cost.</returns>
        public decimal CalculateShippingCost(double totalWeight) => (decimal)totalWeight * _shippingCostPerKg;

        /// <summary>
        /// Validates if the carrier can deliver within the expected timeframe.
        /// </summary>
        /// <param name="expectedDays">Expected delivery days.</param>
        /// <returns>True if the carrier can deliver within the expected timeframe; otherwise, false.</returns>
        public bool ValidateDeliveryTime(int expectedDays) => _deliveryTimeInDays <= expectedDays;
        #endregion
    }
}