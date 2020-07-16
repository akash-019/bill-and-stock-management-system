using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.BranchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BranchService" in both code and config file together.
    public class BranchService : IBranchService
    {
        BSMSEntities e = new BSMSEntities();


        public Branch addBranch(Branch a)
        {
            var data = e.Branches.Add(a);
            e.SaveChanges();
            return data;
        }

        public Branchdata deleteBranch(int id)
        {
            Branch a = e.Branches.Find(id);
            if (a != null)
            {
                e.Branches.Remove(a);
                e.SaveChanges();
                Branchdata d = new Branchdata();
                d.Id = a.Id;
                d.Br_Admin_ID = a.Br_Admin_ID;
                d.Location = a.Location;
                d.Br_Admin_Name = "";
                return d;
                
            }
            return null;

        }

        public Branchdata getSingle(int i)
        {
            Branch a = e.Branches.Find(i);
            if (a != null)
            {
                Branchdata d = new Branchdata();
                d.Id = a.Id;
                d.Br_Admin_ID = a.Br_Admin_ID;
                d.Location = a.Location;
                d.Br_Admin_Name = a.Branch_Admin.Name;
                return d;
            }
            return null;
        }

        public List<Branchdata> selectBranch()
        {
            var a = e.Branches.ToList();
            List<Branchdata> l = new List<Branchdata>();
          
            foreach (Branch i in a)
            {
                Branchdata d = new Branchdata();
                d.Id = i.Id;
                d.Br_Admin_ID = i.Br_Admin_ID;
                d.Location = i.Location;
                d.Br_Admin_Name = i.Branch_Admin.Name;
                l.Add(d);

            }
            return l;
        }

        public List<Branchdata> selectBranchperAdmin(int id)
        {
            var a = e.Branches.Where(m=>m.Br_Admin_ID==id).ToList();
            List<Branchdata> l = new List<Branchdata>();

            foreach (Branch i in a)
            {
                Branchdata d = new Branchdata();
                d.Id = i.Id;
                d.Br_Admin_ID = i.Br_Admin_ID;
                d.Location = i.Location;
                d.Br_Admin_Name = i.Branch_Admin.Name;
                l.Add(d);

            }
            return l;
        }

        public Branchdata updateBranch(Branch a)
        {
            Branch old = e.Branches.Where(
              x => x.Id == a.Id).SingleOrDefault();
            if (old != null)
            {
                e.Entry(old).CurrentValues.SetValues(a);
                e.SaveChanges();
                Branchdata d = new Branchdata();
                d.Id = a.Id;
                d.Br_Admin_ID = a.Br_Admin_ID;
                d.Location = a.Location;
                d.Br_Admin_Name = "";
                return d;
            }
            return null;
        }



    }
}
