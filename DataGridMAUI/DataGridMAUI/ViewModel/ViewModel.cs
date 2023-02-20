using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMAUI
{
    public class ViewModel : INotifyPropertyChanged
    {
        OrderInfoRepository order;

        public ViewModel()
        {
            order = new OrderInfoRepository();
            SetRowstoGenerate(100);

        }

        #region ItemsSource

        private ObservableCollection<OrderInfo> ordersInfo;

        public ObservableCollection<OrderInfo> OrdersInfo
        {
            get
            {
                return ordersInfo;
            }
            set
            {
                this.ordersInfo = value;
                RaisePropertyChanged("OrdersInfo");
            }
        }

        #endregion

        #region ItemSource Generator

        public void SetRowstoGenerate(int count)
        {
            ordersInfo = order.GetOrderDetails(count);
        }

        //public void ShowTodaysAppointments(int count)
        //{
        //    ordersInfo.Clear();
        //    ordersInfo = order.GetOrderDetails(count);
        //}

        //public void ShowTomorrowsAppointments(int count)
        //{
        //    ordersInfo.Clear();
        //    ordersInfo = order.GetOrderDetails(count);
        //}

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
