using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Repositories.Helpers
{
    public static class RepositoryHelper
    {
        #region Fields

        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties

        //private static IApplicationModelFactory ApplicationModelFactory { get; } =
        //    InstanceLocator.Current.GetInstance<IApplicationModelFactory>();

        //private static IMetaModelFactory MetaModelFactory { get; } =
        //    InstanceLocator.Current.GetInstance<IMetaModelFactory>();

        #endregion

        #region Methods

        //public static IEnvironmentStatus GetEnvironmentStatusFromDto(
        //    IList<IEnvironmentStatus> cachedEnvironmentStatuses,
        //    EnvironmentStatus dto)
        //{
        //    if (dto == null)
        //    {
        //        return null;
        //    }

        //    var environmentStatus = cachedEnvironmentStatuses.SingleOrDefault(u => u.Id == dto.Id);

        //    if (environmentStatus != null)
        //    {
        //        _logger.Trace($"DTO: L'environement [#{environmentStatus.Id}] récupéré en cache.");

        //        return environmentStatus;
        //    }

        //    environmentStatus = ApplicationModelFactory.CreateEnvironmentStatus(
        //        dto.Id,
        //        dto.Label
        //    );

        //    cachedEnvironmentStatuses.Add(environmentStatus);
        //    _logger.Trace($"DTO : Le status [#{environmentStatus.Id}] créé.");
        //    _logger.Trace($"DTO : {cachedEnvironmentStatuses.Count} status d'environement en cache.");

        //    return environmentStatus;
        //}

        //public static ISqiModule GetModuleFromDto(SqiModule dto)
        //{
        //    var module = MetaModelFactory.CreateModule(dto.Id, dto.Label);

        //    return module;
        //}

        //public static ISqiUser GetSqiUserFromDto(IList<ISqiUser> cachedUsers, SqiUser dto, bool areParametersLoaded)
        //{
        //    if (dto == null)
        //    {
        //        return null;
        //    }

        //    var sqiUser = cachedUsers.SingleOrDefault(u => u.Id == dto.Id);

        //    if (sqiUser != null)
        //    {
        //        _logger.Trace($"DTO: Utilisateur [#{sqiUser.Id}] récupéré en cache.");

        //        return sqiUser;
        //    }

        //    sqiUser = MetaModelFactory.CreateSqiUser(dto.Id, dto.Person.LastName, dto.Person.FirstName,
        //        dto.Person.Email, dto.Login,
        //        dto.Password, dto.WindowsAccount);
        //    cachedUsers.Add(sqiUser);
        //    _logger.Trace($"DTO : Utilisateur [#{sqiUser.Id}] créé.");
        //    _logger.Trace($"DTO : {cachedUsers.Count} utilisateurs en cache.");

        //    if (areParametersLoaded)
        //    {
        //        sqiUser.Parameters = dto.Parameters.Select(GetUserParameterFromDto).ToList();
        //    }

        //    return sqiUser;
        //}

        //public static IUserParameter GetUserParameterFromDto(UserParameter dto)
        //{
        //    var parameter = MetaModelFactory.CreateUserParameter(dto.Id, dto.Key, dto.Value);
        //    parameter.Module = GetModuleFromDto(dto.Module);

        //    return parameter;
        //}

        #endregion
    }
}