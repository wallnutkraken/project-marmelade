using Marmalade_Global.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Machine
    {
        /// <summary>
        /// Gets the type of the machine as it was initialized.
        /// </summary>
        public MachineType Type { get; set; }

        public uint MachineId { get; set; }

        public string Location { get; set; }
        public MachineSchedule MachineSchedule { get; set; } = new MachineSchedule();


        public Machine(MachineType type)
        {
            Type = type;
        }
        public Machine() : this((MachineType)0)
        {
        }
    }
}
