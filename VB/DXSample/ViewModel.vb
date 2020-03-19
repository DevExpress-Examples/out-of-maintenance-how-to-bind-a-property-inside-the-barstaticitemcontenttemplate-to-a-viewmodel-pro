Imports System
Imports System.Windows.Threading
Imports DevExpress.Mvvm

Namespace DXSample
	Public Class ViewModel
		Inherits ViewModelBase

		Private Timer As DispatcherTimer
		Public Property CurrentValue() As DateTime
			Get
				Return GetValue(Of DateTime)()
			End Get
			Set(ByVal value As DateTime)
				SetValue(value)
			End Set
		End Property
		Public Property Content() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
		Public Sub New()
			Content = "Hello, World!"
			Timer = New DispatcherTimer() With {.Interval = TimeSpan.FromSeconds(1)}
			AddHandler Timer.Tick, AddressOf Timer_Tick
			Timer.Start()
		End Sub
		Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			CurrentValue = DateTime.Now
		End Sub
		Protected Overrides Sub Finalize()
			Timer.Stop()
			RemoveHandler Timer.Tick, AddressOf Timer_Tick
			Timer = Nothing
		End Sub
	End Class
End Namespace
