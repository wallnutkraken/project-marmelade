using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Machine
    {
        private MachineType _Type;
        /// <summary>
        /// Gets the type of the machine as it was initialized.
        /// </summary>
        MachineType Type { get { return _Type; } }
        Machine(MachineType type)
        {
            _Type = type;
        }
    }
}
