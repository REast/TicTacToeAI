using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell
{
   [Serializable]
   public class ConfigurationException : Exception
   {
      public ConfigurationException(string message) : base(message) { }

      public ConfigurationException() : base() { }

      public ConfigurationException(string message, Exception innerException) : base(message, innerException) { }

      protected ConfigurationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
   }
   
}
