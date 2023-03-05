using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_Mamas_pizza
{
    public class Drink
    {
        #region Instance Fields
        private string _name;
        private string _description;
        private double _price;
        #endregion

        #region Constructor
        public Drink(string name, string description, double price)
        {
        _name = name;
        _description = description;
        _price = price;
        }
        #endregion

        #region Properties
        public string Name 
        {   get 
            { return _name; }
        }
        public string Description 
        {   get 
            { return _description;}
        }
        public double Price
        {   get
            { return _price; }
        }
        #endregion

        #region Public Methods
        public override string ToString()
        {
            return $"En Drink: {Name}, {Description}, {Price}kr.";
        }
        #endregion
    }
}
