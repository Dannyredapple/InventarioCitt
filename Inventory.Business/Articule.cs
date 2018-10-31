using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business
{
    public class Articule
    {
        #region Campos
        private int _id;
        private string _name;
        private int _stock;
        private string _description;

        #endregion

        #region Propiedades
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public locker Locker { get; set; }

        #endregion

        #region Constructor
        public Articule()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            Name = string.Empty;
            Stock = 0;
            Description = string.Empty;
            Locker = locker.Comida;
        }
        #endregion

        #region Metodos
        public bool Create()
        {
            try
            {
                Data.article art = new Data.article()
                {
                    NameArticle = Name,
                    Stock = Stock,
                    Locker = Locker.ToString(),
                    DescriptionArticle = Description
                };
                Connection.InventoryDataBase.article.Add(art);
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
                Data.article article = Connection.InventoryDataBase.article.First(a => a.ID == ID);
                Name = article.NameArticle;
                Stock = article.Stock;
                Locker = (locker)Enum.Parse(typeof(locker),article.Locker,true);
                Description = article.DescriptionArticle;
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

        public bool Delete ()
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
