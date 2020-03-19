# How to bind a property inside the BarStaticItem.ContentTemplate to a ViewModel property

This example demonstrates how to bind controls within a [BarStaticItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarStaticItem)'s ContentTemplate to a property in a ViewModel. 

BarStaticItem's [Content](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarItem.Content) and [ContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarItem.ContentTemplate) properties work similarly to the Content and ContentTemplate properties of the standard ContentControl. To specify the DataContext object for controls within **BarStaticItem.ContentTemplate**, set the **BarStaticItem.Content** property. 

<br/>

*Files to look at*:

* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml)
* [ViewModel.cs](./CS/DXSample/ViewModel.cs)
