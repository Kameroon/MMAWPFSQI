using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Repositories.Exceptions
{
    /// <summary>
    ///     Exception levée lors du chargement de données depuis le dépôt
    /// </summary>
    /// <seealso cref="RepositoryException" />
    [Serializable]
    public class LoadRepositoryException : RepositoryException
    {
        #region Fields

        private const string MESSAGE = "Impossible de charger l'entité [{0}].";

        #endregion

        #region Constructors

        public LoadRepositoryException(Type entityType) : base(string.Format(MESSAGE, entityType))
        {
        }

        public LoadRepositoryException(string message) : base(message)
        {
        }

        public LoadRepositoryException(Type entityType, Exception inner)
            : base(string.Format(MESSAGE, entityType), inner)
        {
        }

        public LoadRepositoryException(string message, Exception inner) : base(message, inner)
        {
        }

        protected LoadRepositoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion
    }
}