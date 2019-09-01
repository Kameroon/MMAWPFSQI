using MMA.Framework.Repositories.Exceptions;
using MMA.Framework.Services.Contracts;
using MMA.Framework.Services.Exceptions;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Services.Core
{
    public class SessionService : ISessionService
    {
        #region Fields

        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public string GetUserParameter(string key)
        {
            return null;
            //throw new NotImplementedException();
        }

        #endregion

        #region Properties

        //private IApplicationRepository AppplicationRepository { get; } =
        //    InstanceLocator.Current.GetInstance<IApplicationRepository>();

        //private ISqiUser CurrentUser { get; set; }

        #endregion

        #region Methods

        //public ISqiUser GetCurrentUser()
        //{
        //    if (CurrentUser == null)
        //    {
        //        LoadCurrentUser();
        //    }

        //    return CurrentUser;
        //}

        //public string GetUserParameter(string key)
        //{
        //    var currentUser = GetCurrentUser();
        //    var parameter = currentUser.Parameters.SingleOrDefault(p => p.Key.Equals(key));

        //    if (parameter == null)
        //    {
        //        _logger.Debug($"Paramètre [{key}] introuvable pour l'utilisateur [#{currentUser.Id}].");

        //        return null;
        //    }

        //    _logger.Debug($"Paramètre [{key}] de l'utilisateur [#{currentUser.Id}] : [{parameter.Value}].");

        //    return parameter.Value;
        //}

        //private void LoadCurrentUser()
        //{
        //    var id = 2;

        //    try
        //    {
        //        CurrentUser = AppplicationRepository.GetUser(id);
        //    }
        //    catch (LoadRepositoryException exception)
        //    {
        //        _logger.Error(exception);

        //        throw new ServiceException($"Impossible de récupérer l'utilisateur en cours [#{id}]", exception);
        //    }
        //}

        #endregion
    }
}