using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.SalesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SalesService" in both code and config file together.
    public class SalesService : ISalesService
    {
        BSMSEntities e = new BSMSEntities();


        public List<SalesData> addSale(List<Sale> a)
        {
            List<SalesData> data = new List<SalesData>();
            foreach (Sale i in a)
            {
                var x = e.Sales.Add(i);
                var old=e.Stocks.Find(i.Stock_ID);
                var New = old;
                New.Available = New.Available - i.Quantity;
                e.Entry(old).CurrentValues.SetValues(New);
                e.SaveChanges();

                SalesData d = new SalesData();
                d.Id = x.Id;
                d.Stock_ID = x.Stock_ID;
                Stock s = e.Stocks.Find(d.Stock_ID);
                d.Name =s.Name;
                d.Bill_ID = x.Bill_ID;
                d.Quantity = x.Quantity;
                d.Total = x.Total;
                data.Add(d);

            }
            return data;
        }

        public Sale deleteSale(int id)
        {
            Sale a = e.Sales.Find(id);
            if (a != null)
            {
                e.Sales.Remove(a);
                e.SaveChanges();
                return a;
            }
            return null;
        }

        public List<SalesData> getSale(int i)
        {
            var a = e.Sales.Where(m=>m.Bill_ID==i);
            List<SalesData> l = new List<SalesData>();
            
            foreach (Sale x in a)
            {
                SalesData d = new SalesData();
                d.Id = x.Id;
                d.Stock_ID = x.Stock_ID;
                d.Name = x.Stock.Name;
                d.Bill_ID = x.Bill_ID;
                d.Quantity = x.Quantity;
                d.Total = x.Total;

                l.Add(d);

            }
            return l;
        }

   
       
      

        public List<SalesData> selectSale()
        {
            var a = e.Sales.ToList();
            List<SalesData> l = new List<SalesData>();
             foreach (Sale i in a)
            {
                SalesData d = new SalesData();

                d.Id = i.Id;
                d.Stock_ID = i.Stock_ID;
                d.Name = i.Stock.Name;
                d.Bill_ID = i.Bill_ID;
                d.Quantity = i.Quantity;
                d.Total = i.Total;

                l.Add(d);

            }
            return l;
        }

        public List<SalesData> selectSaleperBranch(int id)
        {
            var a = e.Sales.Where(m=>m.Bill.Branch_ID==id).ToList();
            List<SalesData> l = new List<SalesData>();
             foreach (Sale i in a)
            {
                SalesData d = new SalesData();

                d.Id = i.Id;
                d.Stock_ID = i.Stock_ID;
                d.Name = i.Stock.Name;
                d.Bill_ID = i.Bill_ID;
                d.Quantity = i.Quantity;
                d.Total = i.Total;

                l.Add(d);

            }
            return l;
        }

        public SalesData updateSale(Sale a)
        {
            Branch old = e.Branches.Where(
              x => x.Id == a.Id).SingleOrDefault();
            if (old != null)
            {
                e.Entry(old).CurrentValues.SetValues(a);
                e.SaveChanges();
                SalesData d = new SalesData();
                d.Id = a.Id;
                d.Stock_ID = a.Stock_ID;
                d.Bill_ID = a.Bill_ID;
                d.Name = a.Stock.Name;
                d.Quantity = a.Quantity;
                d.Total = a.Total;
            }
            return null;
        }


    }
}
