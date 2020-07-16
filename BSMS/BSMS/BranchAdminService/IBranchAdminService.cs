using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.BranchAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBranchAdminService" in both code and config file together.
    [ServiceContract]
    public interface IBranchAdminService
    {
        [OperationContract]
        List<BranchAdminData> selectBranchAdmin();
        [OperationContract]
        BranchAdminData getSingle(int i);
        [OperationContract]
        Branch_Admin addBranchAdmin(Branch_Admin a);
        [OperationContract]
        BranchAdminData updateBranchAdmin(Branch_Admin a);
        [OperationContract]
        BranchAdminData deleteBranchAdmin(int id);
    }
    [DataContract]
    public class BranchAdminData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Contact { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }

    }
}
