using System.Windows.Forms;


namespace TestForm
{
    public partial class Form1 : Form
    {



        public Form1()
        {

            //var e = new Entities();
            //var q=e.ADDRESS.ToList();
            //var b = q.First();
            //MessageBox.Show(b.ADDRESS_TABLE_NAME);

            InitializeComponent();
            //System.Data.Common.DbProviderFactories.GetFactoryClasses();
            LaborantRegitrationWpf.WpfShipmentCtl wpfReports = new LaborantRegitrationWpf.WpfShipmentCtl(null,null, null, null, null
                                                                                              );
            wpfReports.DEBUG = true;
            wpfReports.InitializeData();
            this.elementHost1.Child = wpfReports;
        }
    }
}
