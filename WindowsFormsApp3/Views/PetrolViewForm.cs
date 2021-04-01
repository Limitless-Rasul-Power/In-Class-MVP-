using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WindowsFormsApp3.Models;

namespace WindowsFormsApp3.Views
{
    public partial class PetrolViewForm : Form, IPetrolView
    {
        public EventHandler<EventArgs> LitrNumericUpDownValueChanged { get; set; }
        public EventHandler<EventArgs> PriceNumericUpDownValueChanged { get; set; }
        public EventHandler<EventArgs> PayButtonClicked { get; set; }
        public EventHandler<EventArgs> PetrolComboBoxSelectedIndexChanged { get; set; }
        public EventHandler<EventArgs> LitrRadioButtonCheckedChanged { get; set; }
        public EventHandler<EventArgs> PriceRadioButtonCheckedChanged { get; set; }
        public EventHandler<EventArgs> ShowAllPaymentButtonClicked { get; set; }
        public List<Petrol> Petrols { get; set; }
        public Guna2RadioButton LitrRadiButton { get; set; }
        public Guna2RadioButton PriceRadioButton { get; set; }
        public Guna2ComboBox PetrolComboBox { get; set; }
        public Guna2ComboBox PriceTextBox { get; set; }
        public Guna2NumericUpDown LitrNumericUpDown { get; set; }
        public Guna2NumericUpDown PriceNumericUpDown { get; set; }
        public Guna2HtmlLabel TotalPaymentLabel { get; set; }



        public PetrolViewForm()
        {
            InitializeComponent();
        }

        private void LitrRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (LitrRdBtn.Checked)
            {
                PriceNumPDwn.Enabled = false;
                PriceNumPDwn.Value = 0;
            }
        }

        private void LitrNumPDwn_ValueChanged(object sender, EventArgs e)
        {
            TotalPaymentLbl.Text = (LitrNumPDwn.Value * decimal.Parse(PriceTxtBx.Text)).ToString();
        }

        private void PriceNumPDwn_ValueChanged(object sender, EventArgs e)
        {
            TotalPaymentLbl.Text = (PriceNumPDwn.Value * decimal.Parse(PriceTxtBx.Text)).ToString();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {

        }

        private void PetrolCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PriceRdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowAllPaymentBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
