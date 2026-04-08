# How to achieve consistent border rendering in .NET MAUI DataGrid SfDataGrid?
This Sample demonstrates how to achieve consistent grid line (border) rendering specifically on Android when working with the Syncfusion [.NET Maui DataGrid](https://help.syncfusion.com/maui/datagrid/overview)(SfDataGrid).

On Android devices, grid line thickness may appear thinner or inconsistent due to the device’s screen density. This behavior is platform-specific and does not affect other MAUI platforms. The workaround shown below adjusts the grid line thickness at runtime to ensure proper visual appearance on Android.

## Xaml
```
 <ContentPage.BindingContext>
     <local:OrderInfoRepository />
 </ContentPage.BindingContext>

 <ContentPage.Content>
     <syncfusion:SfDataGrid x:Name="dataGrid" 
                            ColumnWidthMode="Auto"
                            GridLinesVisibility="Both" 
                            HeaderGridLinesVisibility="Both"
                            AutoGenerateColumnsMode="None"
                            ItemsSource="{Binding OrderInfoCollection}">
         <syncfusion:SfDataGrid.Columns>
             <syncfusion:DataGridNumericColumn MappingName="OrderID" 
                                               HeaderText="Order ID" 
                                               Format="#"/>
             <syncfusion:DataGridTextColumn MappingName="CustomerID" 
                                            HeaderText="Customer ID" />
             <syncfusion:DataGridTextColumn  MappingName="ShipCountry" 
                                             HeaderText="Ship Country"/>
         </syncfusion:SfDataGrid.Columns>
     </syncfusion:SfDataGrid>
 </ContentPage.Content>

```
## Xaml.cs
```
     public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
#if ANDROID
            dataGrid.DefaultStyle.GridLineStrokeThickness *= (float)DeviceDisplay.MainDisplayInfo.Density;
            dataGrid.DefaultStyle.HeaderGridLineStrokeThickness *= (float)DeviceDisplay.MainDisplayInfo.Density;
#endif
        }
    }

```
### ScreenShot
<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjYyNzA3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9._XtO1LBwh_YBin9dAhtdsJhl-PoavxyOANHpuhNLcac" width=404/>

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-achieve-consistent-border-rendering-in-.NET-MAUI-DataGrid-SfDataGrid)

 Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

### Conclusion
I hope you enjoyed learning about How to bind a dynamic data object in SfDataGrid.

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums),[Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
