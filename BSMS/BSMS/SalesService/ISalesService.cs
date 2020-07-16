using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.SalesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISalesService" in both code and config file together.
    [ServiceContract]
    public interface ISalesService
    {
        [OperationContract]
        List<SalesData> selectSale();
        [OperationContract]
        List<SalesData> selectSaleperBranch(int id);
        [OperationContract]
        List<SalesData> getSale(int i);
        [OperationContract]
        List<SalesData> addSale(List<Sale> a);
        [OperationContract]
        SalesData updateSale(Sale a);
        [OperationContract]
        Sale deleteSale(int id);
    }
    [DataContract]
    public class SalesData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Stock_ID { get; set; }
        [DataMember]
        public int Bill_ID { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public Nullable<int> Total { get; set; }
    }

}
