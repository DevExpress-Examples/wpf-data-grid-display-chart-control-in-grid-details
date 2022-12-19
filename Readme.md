<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128647499/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4042)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->

# WPF Data Grid - Display Chart Control in Grid Details

This example displays the memo field and the [Chart Control](https://docs.devexpress.com/WPF/117736/controls-and-libraries/charts-suite/chart-control) in grid details. The memo field displays data from the master row, and the chart is bound to detail data. The DataTemplate that contains these two controls is asigned to both [ContentDetailDescriptor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ContentDetailDescriptor) and [DataControlDetailDescriptor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlDetailDescriptor):

* The **ContentDetailDescriptor** tab displays the custom content only.
* The **DataControlDetailDescriptor** tab displays the custom content above the detail [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl).

![image](https://user-images.githubusercontent.com/65009440/208117852-56f53d2c-9539-4eb7-9632-e9926416efa7.png) 

## Files to Review

* [MainWindow.xaml](./CS/WpfApplication19/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication19/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication19/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication19/MainWindow.xaml.vb))

## Documentation

* [Tabbed View for Details](https://docs.devexpress.com/WPF/119853/controls-and-libraries/data-grid/master-detail/tabbed-view-for-details)
* [Custom Content in Details](https://docs.devexpress.com/WPF/119852/controls-and-libraries/data-grid/master-detail/custom-content-in-details)
* [Data Grid in Details](https://docs.devexpress.com/WPF/119851/controls-and-libraries/data-grid/master-detail/data-grid-in-details)
* [TabViewDetailDescriptor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TabViewDetailDescriptor)
* [ContentDetailDescriptor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ContentDetailDescriptor)
* [DataControlDetailDescriptor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlDetailDescriptor)

## More Examples

* [WPF Data Grid - Create Master-Detail Grid](https://github.com/DevExpress-Examples/wpf-data-grid-create-master-detail-grid)
* [WPF Data Grid - Create a Master-Detail Grid in Code](https://github.com/DevExpress-Examples/wpf-data-grid-create-master-detail-grid-in-code)
* [WPF Data Grid - Display Detail Content in Tabs](https://github.com/DevExpress-Examples/wpf-data-grid-display-detail-content-in-tabs)
* [WPF Data Grid - Expand and Collapse Master Rows](https://github.com/DevExpress-Examples/expanding-and-collapsing-master-rows-e4044)
* [WPF Data Grid - Specify Detail Buttons Visibility](https://github.com/DevExpress-Examples/detail-buttons-visibility-e4050)
* [WPF Data Grid - Select Details Based on the Data in the Master Row](https://github.com/DevExpress-Examples/how-to-use-different-details-depending-on-data-in-gridcontrols-master-row-t590724)
