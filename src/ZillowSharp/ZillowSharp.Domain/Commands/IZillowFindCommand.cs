using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZillowSharp.Domain.Services;

namespace ZillowSharp.Domain.Commands
{
    public interface IZillowFindCommand<T>
    {
        /// <summary>
        /// Executes the command using the provided Zillow Service.
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        T Execute(IZillowService service);
    }
}
