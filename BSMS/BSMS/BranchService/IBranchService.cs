using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.BranchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBranchService" in both code and config file together.
    [ServiceContract]
    public interface IBranchService
    {
        [OperationContract]
        List<Branchdata> selectBranch();
        [OperationContract]
        List<Branchdata> selectBranchperAdmin(int id);
        [OperationContract]
        Branchdata getSingle(int i);
        [OperationContract]
        Branch addBranch(Branch a);
        [OperationContract]
        Branchdata updateBranch(Branch a);
        [OperationContract]
        Branchdata deleteBranch(int id);
    }
    [DataContract]
    public class Branchdata
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Br_Admin_ID { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Br_Admin_Name { set; get; }
    }
}
