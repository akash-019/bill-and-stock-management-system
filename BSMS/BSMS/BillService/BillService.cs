using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.BillService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BillService" in both code and config file together.
    public class BillService : IBillService
    {
        BSMSEntities e = new BSMSEntities();


        public Bill addBill(Bill a)
        {
            var data = e.Bills.Add(a);
            e.SaveChanges();
            return data;
        }

        public Bill deleteBill(int id)
        {
            Bill a = e.Bills.Find(id);
            if (a != null)
            {
                e.Bills.Remove(a);
                e.SaveChanges();
                return a;
            }
            return null;
        }

        public Billdata getSingle(int i)
        {
            Bill a = e.Bills.Find(i);
            if (a != null)
            {
                Billdata d = new Billdata();
                d.Id = a.Id;
                d.Biller_ID = a.Biller_ID;
                d.Branch_ID = a.Branch_ID;
                d.Customer_Name = a.Customer_Name;
                d.Customer_Contact = a.Customer_Contact;
                d.Amount = a.Amount;
                d.Date = a.Date;
                d.Payment_Mode = a.Payment_Mode;
                d.Location = a.Branch.Location;
                return d;
            }
            return null;
        }

        public List<Billdata> selectBill()
        {
            var a = e.Bills.ToList();
            List<Billdata> l = new List<Billdata>();
        
            foreach (Bill i in a)
            {
                Billdata d = new Billdata();
                d.Id = i.Id;
                d.Biller_ID = i.Biller_ID;
                d.Branch_ID = i.Branch_ID;
                d.Customer_Name = i.Customer_Name;
                d.Customer_Contact = i.Customer_Contact;
                d.Amount = i.Amount;
                d.Date = i.Date;
                d.Payment_Mode = i.Payment_Mode;
                d.Location = i.Branch.Location;

                l.Add(d);

            }
            return l;
        }

        public List<Billdata> selectBillperBranch(int id)
        {
            var lpb = e.Bills.Where(m => m.Branch_ID == id).ToList();
            List<Billdata> l = new List<Billdata>();

            foreach (Bill i in lpb)
            {
                Billdata d = new Billdata();
                d.Id = i.Id;
                d.Biller_ID = i.Biller_ID;
                d.Branch_ID = i.Branch_ID;
                d.Customer_Name = i.Customer_Name;
                d.Customer_Contact = i.Customer_Contact;
                d.Amount = i.Amount;
                d.Date = i.Date;
                d.Payment_Mode = i.Payment_Mode;
                d.Location = i.Branch.Location;

                l.Add(d);

            }
            return l;
        }

        public Bill updateBill(Admin a)
        {
            throw new NotImplementedException();
        }

        public Billdata updateBill(Bill a)
        {
            Bill old = e.Bills.Where(
              x => x.Id == a.Id).SingleOrDefault();
            if (old != null)
            {
                e.Entry(old).CurrentValues.SetValues(a);
                e.SaveChanges();
                Billdata d = new Billdata();
                d.Id = a.Id;
                d.Biller_ID = a.Biller_ID;
                d.Branch_ID = a.Branch_ID;
                d.Customer_Name = a.Customer_Name;
                d.Customer_Contact = a.Customer_Contact;
                d.Amount = a.Amount;
                d.Date = a.Date;
                d.Payment_Mode = a.Payment_Mode;
                d.Location = a.Branch.Location;
                return d;

            }
            return null;
        }
    }
}
