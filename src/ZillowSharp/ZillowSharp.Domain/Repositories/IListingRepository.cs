using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZillowSharp.Domain.Entities;

namespace ZillowSharp.Domain.Repositories
{
    public interface IListingRepository
    {
        IList<Listing> FindAll(int page, int limit);
    }
}
