using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business
{
    public class Request
    {
        public string Name { get; set; }
        public int Cant { get; set; }
        public string Email { get; set; }
        public Articule articule { get; set; }
        public Leader leader { get; set; }

        public Request()
        {
            Init();
        }

        private void Init()
        {
            Name = string.Empty;
            Cant = 0;
            Email = string.Empty;
            articule = new Articule();
            leader = new Leader();
        }

        public bool Create()
        {
            try
            {
                Data.request request = new Data.request()
                {
                    NameRequest = Name,
                    
                };

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
