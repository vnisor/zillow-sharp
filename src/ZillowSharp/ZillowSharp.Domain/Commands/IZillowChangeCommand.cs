using System;
using System.Collections.Generic;
using System.Linq;
using ZillowSharp.Domain.Services;

namespace ZillowSharp.Domain.Commands
{
    public interface IZillowChangeCommand
    {
        /// <summary>
        /// Executes the command using the provided Zillow service.
        /// </summary>
        /// <param name="service"></param>
        void Execute(IZillowService service);
    }
}
