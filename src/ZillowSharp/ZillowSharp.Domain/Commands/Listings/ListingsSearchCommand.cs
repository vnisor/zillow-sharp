using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZillowSharp.Domain.Entities;

namespace ZillowSharp.Domain.Commands.Listings
{
    public class ListingsSearchCommand : IZillowFindCommand<Listing>
    {

        private readonly IList<ListingSearchParameter> _parameters;

        /// <summary>
        /// Initializes a new instance of the ListingsSearchCommand class.
        /// </summary>
        public ListingsSearchCommand(IList<ListingSearchParameter> parameters)
        {
            _parameters = parameters;            
        }

        public Listing Execute(Services.IZillowService service)
        {
            var url = service.BuildUrl("listings.json?");

            //"projects/{0}/tickets/{1}"

            throw new NotImplementedException();
        }
    }
}
