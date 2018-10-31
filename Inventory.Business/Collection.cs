using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Data;

namespace Inventory.Business
{
    public class Collection
    {
        public List<Leader> GetLeaders()
        {
            List<Leader> output = new List<Leader>();
            foreach(Data.leader lead in Connection.InventoryDataBase.leader)
            {
                output.Add(new Leader()
                {
                    Rut = lead.Rut,
                    Dv = lead.Dv,
                    Name = lead.NameLeader,
                    WorkingDay = lead.WorkingDay == "Diurno" ? workingDay.Diurno : workingDay.Vespertino,
                    Carrera = lead.career,
                    Job = (job)Enum.Parse(typeof(job),lead.job)
                });
            }
            return output;
        }

        public List<Articule> GetArticules()
        {
            List<Articule> output = new List<Articule>();
            foreach(Data.article art in Connection.InventoryDataBase.article)
            {
                var ar = art;
                output.Add(new Articule()
                {
                    ID = art.ID,
                    Name = art.NameArticle,
                    Stock = art.Stock,
                    Locker = (locker)Enum.Parse(typeof(locker),art.Locker, true),
                    Description = art.DescriptionArticle
                });
            }
            return output;
        }
    }
}
