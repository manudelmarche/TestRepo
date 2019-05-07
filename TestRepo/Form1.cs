//This is the worst craperie ever
//And this is another bullshit

using System;
using System.Windows.Forms;

namespace TestRepo
{
    public partial class Form1 : Form
    {
        private Car MyCar = new Car();
        Func<Car, string> formatCar;
        public Form1()
        {
            InitializeComponent();
            MyCar.Make = "Porsche";
            MyCar.Power = "377";
            formatCar = c => string.Format("my fantastic {0} has a whopping {1} horsepower", MyCar.Make, MyCar.Power);
            button1.Click += (s, e) =>
            {
                MessageBox.Show(MyCar.ToString(formatCar));
                ManuForm mForm = new ManuForm();
                mForm.ShowDialog();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a test for pull request with a conflict");
        }

        private void Nothing()
        {
            MessageBox.Show("ZIZIZ WAZIZIZ");
        }

        private void Bucht(Func<object> p)
        {
            MessageBox.Show(p.Invoke().ToString());
        }

        private string Test()
        {
            return "test";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bucterie de Scapin");
            FormPhil MyForm = new FormPhil();
            //test
            MyForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("vafanculo");
        //    //this.Bucht(() => this.Test());
        //}

    }


    public class Car
    {
        public string Make { get; set; }
        public string Power { get; set; }

        public override string ToString()
        {
            return string.Format("{0} has {1} horsepower", Make, Power);
        }

        public string ToString(Func<Car, string> format)
        {
            if (format != null)
                return format(this);
            return this.ToString();
        }

    }
}


/*
    logicalDatabaseElement.Value.CreateOnADLDS(() =>
    {
        // we add permissions to the ldb
        foreach (string permissionName in listOfPermissions)
        {
            Lazy<Cache.Permission> permissionElement = null;
            permissionElement = new Lazy<Cache.Permission>(() => { return new Cache.Permission(permissionName, permissionName, permissionName, logicalDatabaseElement.Value); });
            if (logicalDatabaseElement.Value.Permissions.TryAdd(permissionName, permissionElement))
            {
                try
                {
                    permissionElement.Value.CreateOnADLDS();
                }
                catch
                {
                    logicalDatabaseElement.Value.Permissions.TryRemove(permissionName, out permissionElement);
                    throw;
                }
            }
        }
    });
*/
