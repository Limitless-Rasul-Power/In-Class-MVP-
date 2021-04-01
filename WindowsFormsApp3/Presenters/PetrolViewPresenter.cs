using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Models;
using WindowsFormsApp3.Views;

namespace WindowsFormsApp3.Data
{
    public class PetrolViewPresenter
    {
        private readonly PetrolContext _petrolContext;
        private readonly IPetrolView _petrolView;

        public PetrolViewPresenter(IPetrolView view)
        {
            _petrolView = view;

            

        }


        private void ViewLitrNumericUpDownValueChanged(object sender, EventArgs e)
        {
            _petrolView.TotalPaymentLabel.Text = (decimal.Parse(_petrolView.PriceTextBox.Text) * _petrolView.LitrNumericUpDown.Value).ToString();
        }

        private void ViewPriceNumericUpDownValueChanged(object sender, EventArgs e)
        {
            _petrolView.TotalPaymentLabel.Text = (decimal.Parse(_petrolView.PriceTextBox.Text) * _petrolView.PriceNumericUpDown.Value).ToString();
        }

        private void ViewPayButtonClicked(object sender, EventArgs e)
        {
            Petrol petrol = new Petrol
            {
                Name = _petrolView.PetrolComboBox.SelectedItem as string,
                Price = decimal.Parse(_petrolView.PriceTextBox.Text)
            };


            _petrolContext.PetrolPayments.Add(new PetrolStation { Petrol = petrol, AllPrice = decimal.Parse(_petrolView.TotalPaymentLabel.Text) });
            _petrolContext.SaveChanges();

        }

        private void ViewPetrolComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _petrolView.PriceTextBox.Text = _petrolView.Petrols.Find(p => p.Name == _petrolView.PetrolComboBox.SelectedItem as string).Price.ToString();
        }

    }
}
