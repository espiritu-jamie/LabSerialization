using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSerialization
{
    [Serializable]
    internal class Event
    {
        public int EventNumber
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }
    }
}
