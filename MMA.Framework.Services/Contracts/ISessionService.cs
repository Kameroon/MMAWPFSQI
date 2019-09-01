using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Services.Contracts
{
    /// <summary>
    ///     Service de gestion de la session utilisateur.
    /// </summary>
    public interface ISessionService
    {
        ///// <summary>
        /////     Récupère l'utilisateur connecté en cours.
        ///// </summary>
        ///// <returns></returns>
        //ISqiUser GetCurrentUser();

        /// <summary>
        ///     Récupère le paramètre utilisateur à partir de sa clé.
        ///     <para>
        ///         Renvoie <c>null</c> si le paramètre n'existe pas.
        ///     </para>
        /// </summary>
        /// <param name="key">Clé du paramètre.</param>
        /// <returns></returns>
        string GetUserParameter(string key);
    }
}