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
Imports DevExpress.Xpf.Grid

Namespace WpfApplication19
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
'INSTANT VB NOTE: The field employees was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private employees_Conflict As List(Of Employee)
		Private ReadOnly Property Employees() As List(Of Employee)
			Get
				If employees_Conflict Is Nothing Then
					PopulateEmployees()
				End If
				Return employees_Conflict

			End Get
		End Property
		Private Sub PopulateEmployees()
			employees_Conflict = New List(Of Employee)()
			employees_Conflict.Add(New Employee("Bruce", "Cambell", "Sales Manager", "Education includes a BA in psychology from Colorado State University in 1970.  He also completed 'The Art of the Cold Call.'  Bruce is a member of Toastmasters International."))
			employees_Conflict(0).Orders.Add(New Order("Supplier 1", DateTime.Now, "TV", 20))
			employees_Conflict(0).Orders.Add(New Order("Supplier 2", DateTime.Now.AddDays(3), "Projector", 15))
			employees_Conflict(0).Orders.Add(New Order("Supplier 3", DateTime.Now.AddDays(3), "HDMI Cable", 50))
			employees_Conflict.Add(New Employee("Cindy", "Haneline", "Vice President of Sales", "Cindy received her BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  She is fluent in French and Italian and reads German.  She joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Cindy is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association."))
			employees_Conflict(1).Orders.Add(New Order("Supplier 1", DateTime.Now.AddDays(1), "Blu-Ray Player", 10))
			employees_Conflict(1).Orders.Add(New Order("Supplier 2", DateTime.Now.AddDays(1), "HDMI Cable", 10))
			employees_Conflict(1).Orders.Add(New Order("Supplier 3", DateTime.Now.AddDays(1), "Projector", 10))
			employees_Conflict(1).Orders.Add(New Order("Supplier 4", DateTime.Now.AddDays(1), "Amplifier", 10))
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			gridControl1.ItemsSource = Employees
			gridControl2.ItemsSource = Employees
		End Sub

		#Region "#SetupDetails"
		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dataControlDetail As New DataControlDetailDescriptor()
			dataControlDetail.DataControl = SetupDetailGrid()
			dataControlDetail.ItemsSourcePath = "Orders"
			dataControlDetail.ContentTemplate = DirectCast(Me.FindResource("ContentDetail"), DataTemplate)

			Dim contentDetail As New ContentDetailDescriptor()
			contentDetail.ContentTemplate = DirectCast(Me.FindResource("ContentDetail"), DataTemplate)
			contentDetail.HeaderContentTemplate = DirectCast(Me.FindResource("ContentDetail"), DataTemplate)
			contentDetail.HeaderContent = "ContentDetailDescriptor"

			Dim tabDetail As New TabViewDetailDescriptor()
			tabDetail.DetailDescriptors.Add(contentDetail)
			tabDetail.DetailDescriptors.Add(dataControlDetail)

			gridControl2.DetailDescriptor = tabDetail
		End Sub
		#End Region ' #SetupDetails

		#Region "#SetupDetailGrid"
		Private Function SetupDetailGrid() As GridControl
			Dim detailGrid As New GridControl()
			detailGrid.AutoGenerateColumns = AutoGenerateColumnsMode.AddNew
			detailGrid.View = New TableView()
			TryCast(detailGrid.View, TableView).DetailHeaderContent = "DataControlDetailDescriptor"
			TryCast(detailGrid.View, TableView).ShowGroupPanel = False
			TryCast(detailGrid.View, TableView).AutoWidth = True
			Return detailGrid
		End Function
		#End Region ' #SetupDetailGrid
	End Class

	Public Class Employee
'INSTANT VB NOTE: The field firstName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private firstName_Conflict As String
'INSTANT VB NOTE: The field lastName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private lastName_Conflict As String
'INSTANT VB NOTE: The field title was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private title_Conflict As String
'INSTANT VB NOTE: The field notes was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private notes_Conflict As String
'INSTANT VB NOTE: The field orders was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private orders_Conflict As List(Of Order)
		Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal title As String, ByVal notes As String)
			Me.firstName_Conflict = firstName
			Me.lastName_Conflict = lastName
			Me.title_Conflict = title
			Me.notes_Conflict = notes
			Me.orders_Conflict = New List(Of Order)()
		End Sub
		Public Sub New()
		End Sub
		Public Property FirstName() As String
			Get
				Return firstName_Conflict
			End Get
			Set(ByVal value As String)
				firstName_Conflict = value
			End Set
		End Property
		Public Property LastName() As String
			Get
				Return lastName_Conflict
			End Get
			Set(ByVal value As String)
				lastName_Conflict = value
			End Set
		End Property
		Public Property Title() As String
			Get
				Return title_Conflict
			End Get
			Set(ByVal value As String)
				title_Conflict = value
			End Set
		End Property
		Public Property Notes() As String
			Get
				Return notes_Conflict
			End Get
			Set(ByVal value As String)
				notes_Conflict = value
			End Set
		End Property
		Public ReadOnly Property Orders() As List(Of Order)
			Get
				Return orders_Conflict
			End Get
		End Property
	End Class

	Public Class Order
'INSTANT VB NOTE: The field supplier was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private supplier_Conflict As String
'INSTANT VB NOTE: The field date was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private date_Conflict As DateTime
'INSTANT VB NOTE: The field productName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private productName_Conflict As String
'INSTANT VB NOTE: The field quantity was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private quantity_Conflict As Integer
		Public Sub New(ByVal supplier As String, ByVal [date] As DateTime, ByVal productName As String, ByVal quantity As Integer)
			Me.supplier_Conflict = supplier
			Me.date_Conflict = [date]
			Me.productName_Conflict = productName
			Me.quantity_Conflict = quantity
		End Sub
		Public Property Supplier() As String
			Get
				Return supplier_Conflict
			End Get
			Set(ByVal value As String)
				supplier_Conflict = value
			End Set
		End Property
		Public Property [Date]() As DateTime
			Get
				Return date_Conflict
			End Get
			Set(ByVal value As DateTime)
				date_Conflict = value
			End Set
		End Property
		Public Property ProductName() As String
			Get
				Return productName_Conflict
			End Get
			Set(ByVal value As String)
				productName_Conflict = value
			End Set
		End Property
		Public Property Quantity() As Integer
			Get
				Return quantity_Conflict
			End Get
			Set(ByVal value As Integer)
				quantity_Conflict = value
			End Set
		End Property
	End Class

End Namespace
