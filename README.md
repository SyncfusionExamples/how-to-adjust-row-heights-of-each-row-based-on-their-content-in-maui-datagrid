# How to adjust RowHeights of each row based on their content in MAUI DataGrid
In.NET [MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) (SfDataGrid) allows you to customize the [RowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeight) of grid rows using the [QueryRowHeight ](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryRowHeight) event. You can auto fit a row based on its content by using the [GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__) method.

>Note :
>`Handled` property of the [QueryRowHeightEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html) must be set to true in the `QueryRowHeight` event for the height changes to take effect.
## XAML

```XAML
<syncfusion:SfDataGrid x:Name="dataGrid"
                    ItemsSource="{Binding OrdersInfo}"
                AutoGenerateColumnsMode="None">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderId" HeaderText="Order ID" />
        <syncfusion:DataGridTextColumn MappingName="CustomerId"  HeaderText="Customer ID"/>
        <syncfusion:DataGridTemplateColumn MappingName="CustomerQuery" HeaderText="Customer Query">
            <syncfusion:DataGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <Label Text="{Binding CustomerQuery}"/>
                </DataTemplate>
            </syncfusion:DataGridTemplateColumn.CellTemplate>
        </syncfusion:DataGridTemplateColumn>
        <syncfusion:DataGridTextColumn MappingName="Country" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
```
## C#
```C#
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
```
>Note: To skip the header row the condition (e.RowIndex > 0) is added.



![How to adjust row height based on content](RowHeightBasedonContent.png)
## Conclusion
I hope you enjoyed learning about how to adjust row heights of each row based on their content in MAUI DataGrid (SfDataGrid).

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to know about its other groundbreaking feature representations. You can also explore our .NET MAUI DataGrid Documentation to understand how to present and manipulate data.
For current customers, you can check out our .NET MAUI components from the [License and Downloads](https://www.syncfusion.com/account/downloads) page. If you are new to Syncfusion, you can try our 30-day free trial to check out our .NET MAUI DataGrid and other .NET MAUI components.
If you have any queries or require clarifications, please let us know in comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/account/login?ReturnUrl=%2Faccount%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dc54e52f3eb3cde0c3f20474f1bc179ed%26redirect_uri%3Dhttps%253A%252F%252Fsupport.syncfusion.com%252Fagent%252Flogincallback%26response_type%3Dcode%26scope%3Dopenid%2520profile%2520agent.api%2520integration.api%2520offline_access%2520kb.api%26state%3D8db41f98953a4d9ba40407b150ad4cf2%26code_challenge%3DvwHoT64z2h21eP_A9g7JWtr3vp3iPrvSjfh5hN5C7IE%26code_challenge_method%3DS256%26response_mode%3Dquery) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid). We are always happy to assist you!