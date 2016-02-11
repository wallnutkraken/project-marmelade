using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class MachineEntry 
    {
        private MachineType _Type;
        /// <summary>
        /// Gets the type of the machine as it was initialized.
        /// </summary>
        MachineType Type { get { return _Type; } }
        public MachineEntry(MachineType type)
        {
            _Type = type;
        }
        public MachineEntry() : this((MachineType)0)
        {
        }
    }
}
