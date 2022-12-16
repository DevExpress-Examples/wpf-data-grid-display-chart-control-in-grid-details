Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace WpfApplication19

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private employeesField As List(Of Employee)

        Private ReadOnly Property Employees As List(Of Employee)
            Get
                If employeesField Is Nothing Then PopulateEmployees()
                Return employeesField
            End Get
        End Property

        Private Sub PopulateEmployees()
            employeesField = New List(Of Employee)()
            employeesField.Add(New Employee("Bruce", "Cambell", "Sales Manager", "Education includes a BA in psychology from Colorado State University in 1970.  He also completed 'The Art of the Cold Call.'  Bruce is a member of Toastmasters International."))
            employeesField(0).Orders.Add(New Order("Supplier 1", Date.Now, "TV", 20))
            employeesField(0).Orders.Add(New Order("Supplier 2", Date.Now.AddDays(3), "Projector", 15))
            employeesField(0).Orders.Add(New Order("Supplier 3", Date.Now.AddDays(3), "HDMI Cable", 50))
            employeesField.Add(New Employee("Cindy", "Haneline", "Vice President of Sales", "Cindy received her BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  She is fluent in French and Italian and reads German.  She joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Cindy is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association."))
            employeesField(1).Orders.Add(New Order("Supplier 1", Date.Now.AddDays(1), "Blu-Ray Player", 10))
            employeesField(1).Orders.Add(New Order("Supplier 2", Date.Now.AddDays(1), "HDMI Cable", 10))
            employeesField(1).Orders.Add(New Order("Supplier 3", Date.Now.AddDays(1), "Projector", 10))
            employeesField(1).Orders.Add(New Order("Supplier 4", Date.Now.AddDays(1), "Amplifier", 10))
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.gridControl1.ItemsSource = Employees
            Me.gridControl2.ItemsSource = Employees
        End Sub

'#Region "#SetupDetails"
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim dataControlDetail As DataControlDetailDescriptor = New DataControlDetailDescriptor()
            dataControlDetail.DataControl = SetupDetailGrid()
            dataControlDetail.ItemsSourcePath = "Orders"
            dataControlDetail.ContentTemplate = CType(FindResource("ContentDetail"), DataTemplate)
            Dim contentDetail As ContentDetailDescriptor = New ContentDetailDescriptor()
            contentDetail.ContentTemplate = CType(FindResource("ContentDetail"), DataTemplate)
            contentDetail.HeaderContentTemplate = CType(FindResource("ContentDetail"), DataTemplate)
            contentDetail.HeaderContent = "ContentDetailDescriptor"
            Dim tabDetail As TabViewDetailDescriptor = New TabViewDetailDescriptor()
            tabDetail.DetailDescriptors.Add(contentDetail)
            tabDetail.DetailDescriptors.Add(dataControlDetail)
            Me.gridControl2.DetailDescriptor = tabDetail
        End Sub

'#End Region  ' #SetupDetails
'#Region "#SetupDetailGrid"
        Private Function SetupDetailGrid() As GridControl
            Dim detailGrid As GridControl = New GridControl()
            detailGrid.AutoGenerateColumns = AutoGenerateColumnsMode.AddNew
            detailGrid.View = New TableView()
            TryCast(detailGrid.View, TableView).DetailHeaderContent = "DataControlDetailDescriptor"
            TryCast(detailGrid.View, TableView).ShowGroupPanel = False
            TryCast(detailGrid.View, TableView).AutoWidth = True
            Return detailGrid
        End Function
'#End Region  ' #SetupDetailGrid
    End Class

    Public Class Employee

        Private firstNameField As String

        Private lastNameField As String

        Private titleField As String

        Private notesField As String

        Private ordersField As List(Of Order)

        Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal title As String, ByVal notes As String)
            firstNameField = firstName
            lastNameField = lastName
            titleField = title
            notesField = notes
            ordersField = New List(Of Order)()
        End Sub

        Public Sub New()
        End Sub

        Public Property FirstName As String
            Get
                Return firstNameField
            End Get

            Set(ByVal value As String)
                firstNameField = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return lastNameField
            End Get

            Set(ByVal value As String)
                lastNameField = value
            End Set
        End Property

        Public Property Title As String
            Get
                Return titleField
            End Get

            Set(ByVal value As String)
                titleField = value
            End Set
        End Property

        Public Property Notes As String
            Get
                Return notesField
            End Get

            Set(ByVal value As String)
                notesField = value
            End Set
        End Property

        Public ReadOnly Property Orders As List(Of Order)
            Get
                Return ordersField
            End Get
        End Property
    End Class

    Public Class Order

        Private supplierField As String

        Private dateField As Date

        Private productNameField As String

        Private quantityField As Integer

        Public Sub New(ByVal supplier As String, ByVal [date] As Date, ByVal productName As String, ByVal quantity As Integer)
            supplierField = supplier
            dateField = [date]
            productNameField = productName
            quantityField = quantity
        End Sub

        Public Property Supplier As String
            Get
                Return supplierField
            End Get

            Set(ByVal value As String)
                supplierField = value
            End Set
        End Property

        Public Property [Date] As Date
            Get
                Return dateField
            End Get

            Set(ByVal value As Date)
                dateField = value
            End Set
        End Property

        Public Property ProductName As String
            Get
                Return productNameField
            End Get

            Set(ByVal value As String)
                productNameField = value
            End Set
        End Property

        Public Property Quantity As Integer
            Get
                Return quantityField
            End Get

            Set(ByVal value As Integer)
                quantityField = value
            End Set
        End Property
    End Class
End Namespace
