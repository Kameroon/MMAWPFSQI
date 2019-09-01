using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Services.Contracts
{
    public interface IProviderService
    {
        string GetConnectionString(string file);
    }
}
