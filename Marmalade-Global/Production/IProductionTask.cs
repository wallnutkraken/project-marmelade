using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global.Production
{
    interface IProductionTask
    {
        /// <summary>
        /// Duration of the task for completion. Minimum 15 minutes.
        /// </summary>
        TimeSpan Duration { get; set; }
        MachineType MachineTypeRequired { get; set; }
    }
}
