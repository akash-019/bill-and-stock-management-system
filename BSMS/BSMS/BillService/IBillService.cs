using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.BillService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBillService" in both code and config file together.
    [ServiceContract]
    public interface IBillService
    {
        [OperationContract]
        List<Billdata> selectBill();
        [OperationContract]
        List<Billdata> selectBillperBranch(int id);
        [OperationContract]
        Billdata getSingle(int i);
        [OperationContract]
        Bill addBill(Bill a);
        [OperationContract]
        Billdata updateBill(Bill a);
        [OperationContract]
        Bill deleteBill(int id);
    }
    [DataContract]
    public class Billdata
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Biller_ID { get; set; }
        [DataMember]
        public int Branch_ID { get; set; }
        [DataMember]
        public string Customer_Name { get; set; }
        [DataMember]
        public string Customer_Contact { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Payment_Mode { get; set; }
        [DataMember]
        public string Location { get; set; }

    }


}
