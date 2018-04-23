Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Editors.Settings
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.Windows.Threading
Imports DevExpress.Xpf.Ribbon

Namespace RibbonControl_Ex
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXRibbonWindow

		Public Sub New()
			InitializeComponent()

			vm = New ViewModel()
			vm.SliderValue = 30
		   ''' RibbonControl1.DataContext = vm;
			barManager.DataContext = vm
		End Sub

		Private vm As ViewModel


		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			vm.SliderValue = 70
		End Sub

	End Class

	Public Class ViewModel
		Inherits DependencyObject


		Public Property SliderValue() As Integer
			Get
				Return CInt(Fix(GetValue(SliderValueProperty)))
			End Get
			Set(ByVal value As Integer)
				SetValue(SliderValueProperty, value)
			End Set
		End Property

		' Using a DependencyProperty as the backing store for SliderValue.  This enables animation, styling, binding, etc...
		Public Shared ReadOnly SliderValueProperty As DependencyProperty = DependencyProperty.Register("SliderValue", GetType(Integer), GetType(ViewModel), New UIPropertyMetadata(50))


	End Class

	Public Class RecentItem
		Private privateNumber As Integer
		Public Property Number() As Integer
			Get
				Return privateNumber
			End Get
			Set(ByVal value As Integer)
				privateNumber = value
			End Set
		End Property
		Private privateFileName As String
		Public Property FileName() As String
			Get
				Return privateFileName
			End Get
			Set(ByVal value As String)
				privateFileName = value
			End Set
		End Property
	End Class

	Public Class ButtonWithImageContent
		Private privateImageSource As String
		Public Property ImageSource() As String
			Get
				Return privateImageSource
			End Get
			Set(ByVal value As String)
				privateImageSource = value
			End Set
		End Property
		Private privateContent As Object
		Public Property Content() As Object
			Get
				Return privateContent
			End Get
			Set(ByVal value As Object)
				privateContent = value
			End Set
		End Property
	End Class

	Public Class FontSizes
		Public ReadOnly Property Items() As Double()
			Get
				Return New Double() { 3.0, 4.0, 5.0, 6.0, 6.5, 7.0, 7.5, 8.0, 8.5, 9.0, 9.5, 10.0, 10.5, 11.0, 11.5, 12.0, 12.5, 13.0, 13.5, 14.0, 15.0, 16.0, 17.0, 18.0, 19.0, 20.0, 22.0, 24.0, 26.0, 28.0, 30.0, 32.0, 34.0, 36.0, 38.0, 40.0, 44.0, 48.0, 52.0, 56.0, 60.0, 64.0, 68.0, 72.0, 76.0, 80.0, 88.0, 96.0, 104.0, 112.0, 120.0, 128.0, 136.0, 144.0 }
			End Get
		End Property
	End Class

	Public Class DecimatedFontFamilies
		Inherits FontFamilies
		Private Const DecimationFactor As Integer = 5

		Public Overrides ReadOnly Property Items() As ObservableCollection(Of FontFamily)
			Get
				Dim res As New ObservableCollection(Of FontFamily)()
				For i As Integer = 0 To ItemsCore.Count - 1
					If i Mod DecimationFactor = 0 Then
						res.Add(ItemsCore(i))
					End If
				Next i
				Return res
			End Get
		End Property
	End Class

	Public Class FontFamilies
		Private Shared items_Renamed As ObservableCollection(Of FontFamily)
		Protected Shared ReadOnly Property ItemsCore() As ObservableCollection(Of FontFamily)
			Get
				If items_Renamed Is Nothing Then
					items_Renamed = New ObservableCollection(Of FontFamily)()
					For Each fam As FontFamily In Fonts.SystemFontFamilies
						If (Not IsValidFamily(fam)) Then
							Continue For
						End If
						items_Renamed.Add(fam)
					Next fam
				End If
				Return items_Renamed
			End Get
		End Property
		Public Shared Function IsValidFamily(ByVal fam As FontFamily) As Boolean
			For Each f As Typeface In fam.GetTypefaces()
				Dim g As GlyphTypeface = Nothing
				Try
					If f.TryGetGlyphTypeface(g) Then
						If g.Symbol Then
							Return False
						End If
					End If
				Catch e1 As Exception
					Return False
				End Try
			Next f
			Return True
		End Function
		Public Overridable ReadOnly Property Items() As ObservableCollection(Of FontFamily)
			Get
				Dim res As New ObservableCollection(Of FontFamily)()
				For Each fm As FontFamily In ItemsCore
					res.Add(fm)
				Next fm
				Return res
			End Get
		End Property
	End Class
End Namespace
