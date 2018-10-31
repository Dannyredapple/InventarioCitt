using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business
{
    public class Leader
    {
        public int Rut { get; set; }
        public string Dv { get; set; }
        public string Name { get; set; }
        public workingDay WorkingDay { get; set; }
        public string Carrera { get; set; }
        public job Job { get; set; }

        public Leader()
        {
            Init();
        }

        private void Init()
        {
            Rut = 0;
            Dv = string.Empty;
            Name = string.Empty;
            WorkingDay = workingDay.Diurno;
            Carrera = string.Empty;
            Job = job.Capitan;
        }

        #region Metodos
        public bool Create()
        {
            try
            {
                Data.leader leader = new Data.leader()
                {
                    Rut = Rut,
                    Dv = Dv,
                    NameLeader = Name,
                    WorkingDay = WorkingDay.ToString(),
                    job = Job.ToString(),
                    career = Carrera
                };
                Connection.InventoryDataBase.leader.Add(leader);
                Connection.InventoryDataBase.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Data.leader leader = Connection.InventoryDataBase.leader.First(l => l.Rut == Rut);
                Name = leader.NameLeader;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Data.article article = Connection.InventoryDataBase.article.First(a => a.ID == ID);
                article.NameArticle = Name;
                article.Locker = Locker.ToString();
                article.Stock = Stock;
                article.DescriptionArticle = Description;
                Connection.InventoryDataBase.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Data.article article = Connection.InventoryDataBase.article.First(a => a.ID == ID);
                Connection.InventoryDataBase.article.Remove(article);
                Connection.InventoryDataBase.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
