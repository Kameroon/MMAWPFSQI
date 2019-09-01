using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Repositories.Exceptions
{
    /// <summary>
    ///     Exception levée depuis le dépôt
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class RepositoryException : Exception
    {
        #region Fields

        private const string MESSAGE = "Erreur liée à la manipulation des données.";

        #endregion

        #region Constructors

        public RepositoryException() : base(MESSAGE)
        {
        }

        public RepositoryException(string message) : base(message)
        {
        }

        public RepositoryException(Exception inner) : base(MESSAGE, inner)
        {
        }

        public RepositoryException(string message, Exception inner) : base(message, inner)
        {
        }

        protected RepositoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion
    }
}