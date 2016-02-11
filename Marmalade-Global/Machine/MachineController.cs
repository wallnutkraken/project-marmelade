using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global.Machine
{
    static class MachineController
    {
        /// <summary>
        /// Creates a machine from parameters and adds it to the database.
        /// </summary>
        /// <returns>Bool reporting whether the operation was successful or not</returns>
        public static bool AddMachine(MachineType type, string location)
        {
            bool? result = null;
            MachineEntry entry = new MachineEntry(type);
            entry.Location = location;
            try
            {
                Database.AddMachine(entry);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return (bool)result;
        }
    }
}
