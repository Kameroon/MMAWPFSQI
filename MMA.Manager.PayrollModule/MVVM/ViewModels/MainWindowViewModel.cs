using MMA.Framework.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Manager.PayrollModule.MVVM.ViewModels
{
    public class MainWindowViewModel : IDisposable
    {
        private IEnvoieFichePaieService _envoieFichePaieService;

        public MainWindowViewModel(IEnvoieFichePaieService envoieFichePaieService)
        {
            _envoieFichePaieService = envoieFichePaieService;

            string file = @"C:\Users\aidip\OneDrive\Bureau\TestAfersys.xlsx";
            
            //_envoieFichePaieService.GetDataTableFromExcelFile(file);
        }
        
        #region -- Dispose methode --
        bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                }
            }
            //dispose unmanaged resources
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            //bgWorkerExport.Dispose();
            NLog.LogManager.Shutdown();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
