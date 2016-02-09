using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class Machine
    {
        public MachineType Type { get; set; }
        public Machine(MachineType type)
        {
            Type = type;
        }
        public Machine() : this((MachineType)0)
        {
        }
    }
}
