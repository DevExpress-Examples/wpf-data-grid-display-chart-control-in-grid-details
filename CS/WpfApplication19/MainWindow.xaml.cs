using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;

namespace WpfApplication19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private List<Employee> employees;
        private List<Employee> Employees
        {
            get
            {
                if (employees == null)
                    PopulateEmployees();
                return employees;

            }
        }
        private void PopulateEmployees()
        {
            employees = new List<Employee>();
            employees.Add(new Employee("Bruce", "Cambell", "Sales Manager", "Education includes a BA in psychology from Colorado State University in 1970.  He also completed 'The Art of the Cold Call.'  Bruce is a member of Toastmasters International."));
            employees[0].Orders.Add(new Order("Supplier 1", DateTime.Now, "TV", 20));
            employees[0].Orders.Add(new Order("Supplier 2", DateTime.Now.AddDays(3), "Projector", 15));
            employees[0].Orders.Add(new Order("Supplier 3", DateTime.Now.AddDays(3), "HDMI Cable", 50));
            employees.Add(new Employee("Cindy", "Haneline", "Vice President of Sales", "Cindy received her BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  She is fluent in French and Italian and reads German.  She joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Cindy is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association."));
            employees[1].Orders.Add(new Order("Supplier 1", DateTime.Now.AddDays(1), "Blu-Ray Player", 10));
            employees[1].Orders.Add(new Order("Supplier 2", DateTime.Now.AddDays(1), "HDMI Cable", 10));
            employees[1].Orders.Add(new Order("Supplier 3", DateTime.Now.AddDays(1), "Projector", 10));
            employees[1].Orders.Add(new Order("Supplier 4", DateTime.Now.AddDays(1), "Amplifier", 10));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gridControl1.ItemsSource = Employees;
            gridControl2.ItemsSource = Employees;
        }

        #region #SetupDetails
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataControlDetailDescriptor dataControlDetail = new DataControlDetailDescriptor();
            dataControlDetail.DataControl = SetupDetailGrid();
            dataControlDetail.ItemsSourcePath = "Orders";
            dataControlDetail.ContentTemplate = (DataTemplate)this.FindResource("ContentDetail");

            ContentDetailDescriptor contentDetail = new ContentDetailDescriptor();
            contentDetail.ContentTemplate = (DataTemplate)this.FindResource("ContentDetail");
            contentDetail.HeaderContentTemplate = (DataTemplate)this.FindResource("ContentDetail");
            contentDetail.HeaderContent = "ContentDetailDescriptor";

            TabViewDetailDescriptor tabDetail = new TabViewDetailDescriptor();
            tabDetail.DetailDescriptors.Add(contentDetail);
            tabDetail.DetailDescriptors.Add(dataControlDetail);

            gridControl2.DetailDescriptor = tabDetail;
        }
        #endregion #SetupDetails
        
        #region #SetupDetailGrid
        private GridControl SetupDetailGrid()
        {
            GridControl detailGrid = new GridControl();
            detailGrid.AutoPopulateColumns = true;
            detailGrid.View = new TableView();
            (detailGrid.View as TableView).DetailHeaderContent = "DataControlDetailDescriptor";
            (detailGrid.View as TableView).ShowGroupPanel = false;
            (detailGrid.View as TableView).AutoWidth = true;
            return detailGrid;
        }
        #endregion #SetupDetailGrid
    }

    public class Employee
    {
        private string firstName;
        private string lastName;
        private string title;
        private string notes;
        private List<Order> orders;
        public Employee(string firstName, string lastName, string title, string notes)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
            this.notes = notes;
            this.orders = new List<Order>();
        }
        public Employee() { }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Notes { get { return notes; } set { notes = value; } }
        public List<Order> Orders { get { return orders; } }
    }

    public class Order
    {
        private string supplier;
        private DateTime date;
        private string productName;
        private int quantity;
        public Order(string supplier, DateTime date, string productName, int quantity)
        {
            this.supplier = supplier;
            this.date = date;
            this.productName = productName;
            this.quantity = quantity;
        }
        public string Supplier { get { return supplier; } set { supplier = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public string ProductName { get { return productName; } set { productName = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
    }

}
