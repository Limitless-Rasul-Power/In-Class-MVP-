using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Models;

namespace WindowsFormsApp3.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> AddButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get; set; }

        public string ModelText { get { return ModelTxtBx.Text; } set { ModelTxtBx.Text = value; } }
        public List<Car> Cars { set { DataLstBx.DataSource = null; DataLstBx.DataSource = value; } }

        public string VendorText { get { return VendorTxtBx.Text; } set { VendorTxtBx.Text = value; } }
        public string ColorText { get { return ColorTxtBx.Text; } set { ColorTxtBx.Text = value; } }
        public string TransmissionText { get { return TransmissionTxtBx.Text; } set { TransmissionTxtBx.Text = value; } }
        public string YearText { get { return YearTxtBx.Text; } set { YearTxtBx.Text = value; } }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddButtonClicked.Invoke(sender, e);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadButtonClicked.Invoke(sender, e);

        }
    }
}
