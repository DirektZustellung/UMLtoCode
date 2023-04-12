using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public struct Address
    {
        public string Street;
        public string City;
        public string State;
        public int Postal_Code;
        public string Country;

        public bool Validate() 
        {
            return true;
        }
    }
}
