<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655456/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2567)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to bind a property inside the BarStaticItem.ContentTemplate to a ViewModel property

This example demonstrates how to bind controls within a [BarStaticItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarStaticItem)'s ContentTemplate to a property in a ViewModel. 

BarStaticItem's [Content](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarItem.Content) and [ContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarItem.ContentTemplate) properties work similarly to the Content and ContentTemplate properties of the standard ContentControl. To specify the DataContext object for controls within **BarStaticItem.ContentTemplate**, set the **BarStaticItem.Content** property. 

<br/>

*Files to look at*:

* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml)
* [ViewModel.cs](./CS/DXSample/ViewModel.cs)
