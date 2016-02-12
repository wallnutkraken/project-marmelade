using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global.Machine
{
    interface IMachine
    {
        MachineType Type { get; set; }

        MachineSchedule MachineSchedule { get; set; }
        
        uint MachineId { get; set; }

        string Location { get; set; }
    }
}
