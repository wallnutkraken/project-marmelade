using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class MachineEntry 
    {
        /// <summary>
        /// Gets the type of the machine as it was initialized.
        /// </summary>
        MachineType Type { get { return _Type; } }
        public MachineType Type { get; set; }

        public MachineSchedule MachineSchedule { get; set; }


        public Machine(MachineType type)
        {
            Type = type;
        }
        public MachineEntry() : this((MachineType)0)
        {
        }
    }
}
