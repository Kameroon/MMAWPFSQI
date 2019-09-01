using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Services.Contracts
{
    public interface IEnvoieFichePaieService
    {
        DataTable GetDataTableFromExcelFile(string file);
    }
}
