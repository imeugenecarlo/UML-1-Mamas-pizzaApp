using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_Mamas_pizza
{
    public class Pizza
    {
        #region Instance field
        private string _name;
        private string _description;
        private double _price;
        #endregion

        #region Constructor
        public Pizza(string name, string description, double price)
        {
            _name = name;
            _description = description;
            _price = price;
        }
        #endregion

        #region Properties
        public double Price 
        {   get
                { return _price;}
        }

        public string Name 
        {   get 
                { return _name;}
        }

        public string Description 
        {   get 
                { return _description;}
        }
        #endregion

        #region PublicMethod
        public override string ToString()
        {
            return $"En Pizza {Name} indeholder:||{Description}||. Pris:{Price} kr.";
        }
        #endregion
    }
}