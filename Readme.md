<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication19/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication19/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication19/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication19/MainWindow.xaml.vb))
<!-- default file list end -->
# Displaying chart control in grid details


<p>This example demonstrates how to display a memo field and a chart within grid details.  While the memo field displays data from the master record, the chart control is bound to the detail data table. </p><p>Grid Controls in this sample use a TabViewDetailDescriptor with both ContentDetailDescriptor and DataControlDescriptor showing the same custom content. This is done by assigning the same template to the detail descriptors' ContentTemplate properties. Note that when using a DataControlDetailDescriptor, the template is displayed above the detail grid.</p><p>Two grid control are included in this sample to demonstrate how to setup custom details both via XAML or code.</p>

<br/>


