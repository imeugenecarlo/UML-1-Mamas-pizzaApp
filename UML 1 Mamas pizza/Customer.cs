using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1_Mamas_pizza
{
    public class Customer
    {
        #region Instance Fields
        private string _name;
        private string _address;
        private string _mail;
        private int _cellphone;
        #endregion

        #region Constructor
        public Customer(string name, string address, string mail, int cellphone)
        {
            _name = name;
          _address = address;
           _mail = mail;
           _cellphone = cellphone;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }   
        }

        public string Address
        { 
            get { return _address; } 
        }

        public string Mail
        { 
            get { return _mail; }
        }
        public int Cellphone
        { 
            get { return _cellphone; }
        }
        #endregion

        #region Public Methods
        public override string ToString()
        { 
        return $"Kunden: {Name}, {Address}, {Mail}, tlf: {Cellphone}.";
        }
        #endregion
    }
}
