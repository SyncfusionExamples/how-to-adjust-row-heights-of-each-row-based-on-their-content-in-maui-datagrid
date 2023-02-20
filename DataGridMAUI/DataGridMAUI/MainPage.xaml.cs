namespace DataGridMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        dataGrid.QueryRowHeight += DataGrid_QueryRowHeight;
	}

    private void DataGrid_QueryRowHeight(object sender, Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs e)
    {
        if (e.RowIndex > 0)
        {
            e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
            e.Handled= true;
        }
    }
}

