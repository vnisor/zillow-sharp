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

        /// <summary>
        /// Initializes a new instance of the ListingsSearchCommand class.
        /// </summary>
        public ListingsSearchCommand(IList<ListingSearchParameter> parameters)
        {
            
        }

        public Listing Execute(Services.IZillowService service)
        {
            throw new NotImplementedException();
        }
    }
}
