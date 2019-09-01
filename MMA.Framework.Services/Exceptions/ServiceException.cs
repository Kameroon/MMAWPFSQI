using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Services.Exceptions
{
    [Serializable]
    public class ServiceException : Exception
    {
        #region Constructors

        public ServiceException(string message) : base(message)
        {
        }

        public ServiceException(string message, Exception inner) : base(message, inner)
        {
        }

        public ServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion
    }
}