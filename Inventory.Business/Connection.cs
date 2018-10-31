using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Data;

namespace Inventory.Business
{
    internal class Connection
    {
        private static InventarioCittBDEntities1 _inventoryDataBase;

        public static InventarioCittBDEntities1 InventoryDataBase
        {

            get
            {
                if(_inventoryDataBase == null)
                {
                    _inventoryDataBase = new InventarioCittBDEntities1();
                }
                return _inventoryDataBase;
            }

            set { _inventoryDataBase = value; }
        }

    }
}
