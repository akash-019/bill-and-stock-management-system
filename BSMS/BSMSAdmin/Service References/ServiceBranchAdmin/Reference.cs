﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BSMSAdmin.ServiceBranchAdmin {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Branch_Admin", Namespace="http://schemas.datacontract.org/2004/07/BSMS")]
    [System.SerializableAttribute()]
    public partial class Branch_Admin : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Branch[] BranchesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Branch[] Branches {
            get {
                return this.BranchesField;
            }
            set {
                if ((object.ReferenceEquals(this.BranchesField, value) != true)) {
                    this.BranchesField = value;
                    this.RaisePropertyChanged("Branches");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contact {
            get {
                return this.ContactField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactField, value) != true)) {
                    this.ContactField = value;
                    this.RaisePropertyChanged("Contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((this.DOBField.Equals(value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Branch", Namespace="http://schemas.datacontract.org/2004/07/BSMS")]
    [System.SerializableAttribute()]
    public partial class Branch : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Biller[] BillersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Bill[] BillsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Br_Admin_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Branch_Admin Branch_AdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] LocationField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Biller[] Billers {
            get {
                return this.BillersField;
            }
            set {
                if ((object.ReferenceEquals(this.BillersField, value) != true)) {
                    this.BillersField = value;
                    this.RaisePropertyChanged("Billers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Bill[] Bills {
            get {
                return this.BillsField;
            }
            set {
                if ((object.ReferenceEquals(this.BillsField, value) != true)) {
                    this.BillsField = value;
                    this.RaisePropertyChanged("Bills");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Br_Admin_ID {
            get {
                return this.Br_Admin_IDField;
            }
            set {
                if ((this.Br_Admin_IDField.Equals(value) != true)) {
                    this.Br_Admin_IDField = value;
                    this.RaisePropertyChanged("Br_Admin_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Branch_Admin Branch_Admin {
            get {
                return this.Branch_AdminField;
            }
            set {
                if ((object.ReferenceEquals(this.Branch_AdminField, value) != true)) {
                    this.Branch_AdminField = value;
                    this.RaisePropertyChanged("Branch_Admin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Biller", Namespace="http://schemas.datacontract.org/2004/07/BSMS")]
    [System.SerializableAttribute()]
    public partial class Biller : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Bill[] BillsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Branch BranchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Branch_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Bill[] Bills {
            get {
                return this.BillsField;
            }
            set {
                if ((object.ReferenceEquals(this.BillsField, value) != true)) {
                    this.BillsField = value;
                    this.RaisePropertyChanged("Bills");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Branch Branch {
            get {
                return this.BranchField;
            }
            set {
                if ((object.ReferenceEquals(this.BranchField, value) != true)) {
                    this.BranchField = value;
                    this.RaisePropertyChanged("Branch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Branch_ID {
            get {
                return this.Branch_IDField;
            }
            set {
                if ((this.Branch_IDField.Equals(value) != true)) {
                    this.Branch_IDField = value;
                    this.RaisePropertyChanged("Branch_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contact {
            get {
                return this.ContactField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactField, value) != true)) {
                    this.ContactField = value;
                    this.RaisePropertyChanged("Contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((this.DOBField.Equals(value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bill", Namespace="http://schemas.datacontract.org/2004/07/BSMS")]
    [System.SerializableAttribute()]
    public partial class Bill : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Biller BillerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Biller_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Branch BranchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Branch_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Customer_ContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Customer_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Payment_ModeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Sale[] SalesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Biller Biller {
            get {
                return this.BillerField;
            }
            set {
                if ((object.ReferenceEquals(this.BillerField, value) != true)) {
                    this.BillerField = value;
                    this.RaisePropertyChanged("Biller");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Biller_ID {
            get {
                return this.Biller_IDField;
            }
            set {
                if ((this.Biller_IDField.Equals(value) != true)) {
                    this.Biller_IDField = value;
                    this.RaisePropertyChanged("Biller_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Branch Branch {
            get {
                return this.BranchField;
            }
            set {
                if ((object.ReferenceEquals(this.BranchField, value) != true)) {
                    this.BranchField = value;
                    this.RaisePropertyChanged("Branch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Branch_ID {
            get {
                return this.Branch_IDField;
            }
            set {
                if ((this.Branch_IDField.Equals(value) != true)) {
                    this.Branch_IDField = value;
                    this.RaisePropertyChanged("Branch_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Customer_Contact {
            get {
                return this.Customer_ContactField;
            }
            set {
                if ((object.ReferenceEquals(this.Customer_ContactField, value) != true)) {
                    this.Customer_ContactField = value;
                    this.RaisePropertyChanged("Customer_Contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Customer_Name {
            get {
                return this.Customer_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Customer_NameField, value) != true)) {
                    this.Customer_NameField = value;
                    this.RaisePropertyChanged("Customer_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Payment_Mode {
            get {
                return this.Payment_ModeField;
            }
            set {
                if ((object.ReferenceEquals(this.Payment_ModeField, value) != true)) {
                    this.Payment_ModeField = value;
                    this.RaisePropertyChanged("Payment_Mode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Sale[] Sales {
            get {
                return this.SalesField;
            }
            set {
                if ((object.ReferenceEquals(this.SalesField, value) != true)) {
                    this.SalesField = value;
                    this.RaisePropertyChanged("Sales");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sale", Namespace="http://schemas.datacontract.org/2004/07/BSMS")]
    [System.SerializableAttribute()]
    public partial class Sale : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Bill BillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Bill_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Stock StockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Stock_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TotalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Bill Bill {
            get {
                return this.BillField;
            }
            set {
                if ((object.ReferenceEquals(this.BillField, value) != true)) {
                    this.BillField = value;
                    this.RaisePropertyChanged("Bill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Bill_ID {
            get {
                return this.Bill_IDField;
            }
            set {
                if ((this.Bill_IDField.Equals(value) != true)) {
                    this.Bill_IDField = value;
                    this.RaisePropertyChanged("Bill_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Stock Stock {
            get {
                return this.StockField;
            }
            set {
                if ((object.ReferenceEquals(this.StockField, value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock_ID {
            get {
                return this.Stock_IDField;
            }
            set {
                if ((this.Stock_IDField.Equals(value) != true)) {
                    this.Stock_IDField = value;
                    this.RaisePropertyChanged("Stock_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Stock", Namespace="http://schemas.datacontract.org/2004/07/BSMS")]
    [System.SerializableAttribute()]
    public partial class Stock : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DOMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuntityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BSMSAdmin.ServiceBranchAdmin.Sale[] SalesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DOM {
            get {
                return this.DOMField;
            }
            set {
                if ((this.DOMField.Equals(value) != true)) {
                    this.DOMField = value;
                    this.RaisePropertyChanged("DOM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quntity {
            get {
                return this.QuntityField;
            }
            set {
                if ((this.QuntityField.Equals(value) != true)) {
                    this.QuntityField = value;
                    this.RaisePropertyChanged("Quntity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BSMSAdmin.ServiceBranchAdmin.Sale[] Sales {
            get {
                return this.SalesField;
            }
            set {
                if ((object.ReferenceEquals(this.SalesField, value) != true)) {
                    this.SalesField = value;
                    this.RaisePropertyChanged("Sales");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBranchAdmin.IBranch_AdminService")]
    public interface IBranch_AdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/selectBranchAdmin", ReplyAction="http://tempuri.org/IBranch_AdminService/selectBranchAdminResponse")]
        BSMSAdmin.ServiceBranchAdmin.Branch_Admin[] selectBranchAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/selectBranchAdmin", ReplyAction="http://tempuri.org/IBranch_AdminService/selectBranchAdminResponse")]
        System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin[]> selectBranchAdminAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/getSingle", ReplyAction="http://tempuri.org/IBranch_AdminService/getSingleResponse")]
        BSMSAdmin.ServiceBranchAdmin.Branch_Admin getSingle(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/getSingle", ReplyAction="http://tempuri.org/IBranch_AdminService/getSingleResponse")]
        System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin> getSingleAsync(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/addBranchAdmin", ReplyAction="http://tempuri.org/IBranch_AdminService/addBranchAdminResponse")]
        BSMSAdmin.ServiceBranchAdmin.Branch_Admin addBranchAdmin(BSMSAdmin.ServiceBranchAdmin.Branch_Admin a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/addBranchAdmin", ReplyAction="http://tempuri.org/IBranch_AdminService/addBranchAdminResponse")]
        System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin> addBranchAdminAsync(BSMSAdmin.ServiceBranchAdmin.Branch_Admin a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/updateBranchAdmin", ReplyAction="http://tempuri.org/IBranch_AdminService/updateBranchAdminResponse")]
        BSMSAdmin.ServiceBranchAdmin.Branch_Admin updateBranchAdmin(BSMSAdmin.ServiceBranchAdmin.Branch_Admin a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/updateBranchAdmin", ReplyAction="http://tempuri.org/IBranch_AdminService/updateBranchAdminResponse")]
        System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin> updateBranchAdminAsync(BSMSAdmin.ServiceBranchAdmin.Branch_Admin a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/deleteBranchAdmin", ReplyAction="http://tempuri.org/IBranch_AdminService/deleteBranchAdminResponse")]
        BSMSAdmin.ServiceBranchAdmin.Branch_Admin deleteBranchAdmin(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBranch_AdminService/deleteBranchAdmin", ReplyAction="http://tempuri.org/IBranch_AdminService/deleteBranchAdminResponse")]
        System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin> deleteBranchAdminAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBranch_AdminServiceChannel : BSMSAdmin.ServiceBranchAdmin.IBranch_AdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Branch_AdminServiceClient : System.ServiceModel.ClientBase<BSMSAdmin.ServiceBranchAdmin.IBranch_AdminService>, BSMSAdmin.ServiceBranchAdmin.IBranch_AdminService {
        
        public Branch_AdminServiceClient() {
        }
        
        public Branch_AdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Branch_AdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Branch_AdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Branch_AdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BSMSAdmin.ServiceBranchAdmin.Branch_Admin[] selectBranchAdmin() {
            return base.Channel.selectBranchAdmin();
        }
        
        public System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin[]> selectBranchAdminAsync() {
            return base.Channel.selectBranchAdminAsync();
        }
        
        public BSMSAdmin.ServiceBranchAdmin.Branch_Admin getSingle(int i) {
            return base.Channel.getSingle(i);
        }
        
        public System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin> getSingleAsync(int i) {
            return base.Channel.getSingleAsync(i);
        }
        
        public BSMSAdmin.ServiceBranchAdmin.Branch_Admin addBranchAdmin(BSMSAdmin.ServiceBranchAdmin.Branch_Admin a) {
            return base.Channel.addBranchAdmin(a);
        }
        
        public System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin> addBranchAdminAsync(BSMSAdmin.ServiceBranchAdmin.Branch_Admin a) {
            return base.Channel.addBranchAdminAsync(a);
        }
        
        public BSMSAdmin.ServiceBranchAdmin.Branch_Admin updateBranchAdmin(BSMSAdmin.ServiceBranchAdmin.Branch_Admin a) {
            return base.Channel.updateBranchAdmin(a);
        }
        
        public System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin> updateBranchAdminAsync(BSMSAdmin.ServiceBranchAdmin.Branch_Admin a) {
            return base.Channel.updateBranchAdminAsync(a);
        }
        
        public BSMSAdmin.ServiceBranchAdmin.Branch_Admin deleteBranchAdmin(int id) {
            return base.Channel.deleteBranchAdmin(id);
        }
        
        public System.Threading.Tasks.Task<BSMSAdmin.ServiceBranchAdmin.Branch_Admin> deleteBranchAdminAsync(int id) {
            return base.Channel.deleteBranchAdminAsync(id);
        }
    }
}
