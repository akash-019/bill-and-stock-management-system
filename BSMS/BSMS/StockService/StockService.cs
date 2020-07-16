using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.StockService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StockService" in both code and config file together.
    public class StockService : IStockService
    {
        BSMSEntities e = new BSMSEntities();


        public Stock addStock(Stock a)
        {
            var data = e.Stocks.Add(a);
            e.SaveChanges();
            return data;
        }


        public StockData deleteStock(int id)
        {
            Stock a = e.Stocks.Find(id);
            if (a != null)
            {
                e.Stocks.Remove(a);
                e.SaveChanges();
                StockData d = new StockData();
                d.Id = a.Id;
                d.Name = a.Name;
                d.Quantity = a.Quantity;
                d.Price = a.Price;
                d.DOM = a.DOM;
                d.Available = a.Available;
                d.Branch_Id = a.Branch_Id;
                d.Branch_Location = "";
                return d;
            }
            return null;
        }

        public StockData getSingle(int i)
        {
            Stock a = e.Stocks.Find(i);
            if (a != null)
            {
                StockData d = new StockData();
                d.Id = a.Id;
                d.Name = a.Name;
                d.Quantity = a.Quantity;
                d.Price = a.Price;
                d.DOM = a.DOM;
                d.Available = a.Available;
                d.Branch_Id = a.Branch_Id;
                d.Branch_Location = a.Branch.Location;
                return d;
            }
            return null;
        }



        public List<StockData> selectStock()
        {
            var a = e.Stocks.ToList();
            List<StockData> l = new List<StockData>();
           
            foreach (Stock i in a)
            {
                StockData d = new StockData();
                d.Id = i.Id;
                d.Name = i.Name;
                d.Quantity = i.Quantity;
                d.Price = i.Price;
                d.DOM = i.DOM;
                d.Available = i.Available;
                d.Branch_Id = i.Branch_Id;
                d.Branch_Location = i.Branch.Location;
                l.Add(d);

            }
            return l;

        }

        public List<StockData> selectStockperBranch(int id)
        {
            var a = e.Stocks.Where(m=>m.Branch_Id==id).ToList();
            List<StockData> l = new List<StockData>();

            foreach (Stock i in a)
            {
                StockData d = new StockData();
                d.Id = i.Id;
                d.Name = i.Name;
                d.Quantity = i.Quantity;
                d.Price = i.Price;
                d.DOM = i.DOM;
                d.Available = i.Available;
                d.Branch_Id = i.Branch_Id;
                d.Branch_Location = i.Branch.Location;
                l.Add(d);

            }
            return l;
        }

        public StockData updateStock(Stock a)
        {
            Stock old = e.Stocks.Where(
              x => x.Id == a.Id).SingleOrDefault();
            if (old != null)
            {
                e.Entry(old).CurrentValues.SetValues(a);
                e.SaveChanges();
                StockData d = new StockData();
                d.Id = a.Id;
                d.Name = a.Name;
                d.Quantity = a.Quantity;
                d.Price = a.Price;
                d.DOM = a.DOM;
                d.Available = a.Available;
                d.Branch_Id = a.Branch_Id;
                d.Branch_Location = "";
                return d;
            }
            return null;
        }
    }
}
