using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMAUI
{
    public class OrderInfo : INotifyPropertyChanged
    {
        public OrderInfo()
        {

        }
        #region private variables

        private int orderId;
        private string customerId;
        private string customerquery;
        private string country;

        #endregion

        #region public properties
        public int OrderId
        {
            get
            {
                return orderId;
            }
            set
            {
                orderId = value;
                RaisePropertyChanged("OrderId");
            }
        }
        public string CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
                RaisePropertyChanged("CustomId");
            }
        }

        public string CustomerQuery
        {
            get
            {
                return customerquery;
            }
            set
            {
                customerquery = value;
                RaisePropertyChanged("CustomerQuery");
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                RaisePropertyChanged("Country");
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
        #endregion
    }
}
