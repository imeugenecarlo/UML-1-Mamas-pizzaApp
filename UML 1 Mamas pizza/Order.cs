using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_Mamas_pizza
{
    public class Order
    {
        #region InstanceFields
        private Pizza _pizza;
        private Drink _drink;
        private Customer _customer;
        #endregion

        #region Constructor
        public Order(Pizza pizza, Drink drink, Customer customer)
        {
            _pizza = pizza;
            _customer = customer;
            _drink = drink;
        }
        #endregion

        #region Function
        public double CalculatéTotalPrice
        {
            get
            {
                double totalPrice =
                    _pizza.Price + _drink.Price;

                double shippingPrice = 40;
                double taxPrice = 1.25;
                return totalPrice * taxPrice + shippingPrice;
            }
        }
        #endregion

        #region Properties
        public Pizza Pizzaorder

        {
            get { return _pizza; }
        }

        public Customer Customerorder 
        { get 
            { return _customer; } 
        }

        public Drink Drinkorder
        {
            get { return _drink; }
        }
        #endregion

        #region Public Methods
        public override string ToString()
        {

            return $"En Ordre: {Pizzaorder} :{Drinkorder} :{Customerorder}";

        }
        #endregion
    }
}
