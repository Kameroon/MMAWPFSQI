using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Services.Contracts
{
    /// <summary>
    ///     Service de gestion des caches.
    /// </summary>
    public interface ICacheService
    {
        /// <summary>
        ///     Ajoute les données en cache.
        /// </summary>
        /// <typeparam name="T">Type de donnée.</typeparam>
        /// <param name="items">Liste des données.</param>
        void AddCache<T>(IEnumerable<T> items = null)
            where T : class;

        /// <summary>
        ///     Supprime le cache.
        /// </summary>
        /// <typeparam name="T">Type de données.</typeparam>
        void DeleteCache<T>()
            where T : class;

        /// <summary>
        ///     Vide le cache.
        /// </summary>
        /// <typeparam name="T">Type de données.</typeparam>
        void FlushCache<T>()
            where T : class;

        /// <summary>
        ///     Récupère les données en cache.
        ///     <para>
        ///         Renvoie <c>null</c> si le cache n'existe pas.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type de données.</typeparam>
        /// <returns></returns>
        IEnumerable<T> GetCache<T>()
            where T : class;

        ///// <summary>
        /////     Récupère une entité en cache par son identifiant.
        /////     <para>
        /////         Renvoie <c>null</c> si le cache ou l'entité n'existe pas.
        /////     </para>
        ///// </summary>
        ///// <typeparam name="TEntity">Type de l'entité.</typeparam>
        ///// <param name="id">Identifiant de l'entité.</param>
        ///// <returns></returns>
        //TEntity GetEntity<TEntity>(int id)
        //    where TEntity : class, IEntity;
    }
}