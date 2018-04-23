' Developer Express Code Central Example:
' How to bind a property inside the BarStaticItem.ContentTemplate to a ViewModel property
' 
' Assign the ViewModel instance to the RibbonControl.DataContext property. While
' binding a property in the BarStaticItem.ContentTemplate, use the RibbonControl
' name as the ElementName. The binding path should be the same as when you address
' the RibbonControl properties.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2567


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows

Namespace RibbonControl_Ex
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
	End Class
End Namespace
