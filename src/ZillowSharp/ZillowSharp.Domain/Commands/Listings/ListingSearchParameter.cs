using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZillowSharp.Domain.Commands.Listings
{
    public class ListingSearchParameter
    {
        /// <summary>
        /// Initializes a new instance of the ListingSearchParameter class.
        /// </summary>
        public ListingSearchParameter(string fieldName, string value)
        {
            _fieldName = fieldName;
            _value = value;
        }

        private readonly string _fieldName;
        private readonly string _value;

        public string FieldName
        {
            get
            {
                return _fieldName;
            }
        }
        public string Value
        {
            get
            {
                return _value;
            }
        }
    }
}
