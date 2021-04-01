using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Models;
using Guna.UI2.WinForms;

namespace WindowsFormsApp3.Views
{
    public interface IPetrolView
    {
        EventHandler<EventArgs> LitrNumericUpDownValueChanged { get; set; }
        EventHandler<EventArgs> PriceNumericUpDownValueChanged { get; set; }
        EventHandler<EventArgs> PayButtonClicked { get; set; }
        EventHandler<EventArgs> PetrolComboBoxSelectedIndexChanged { get; set; }
        EventHandler<EventArgs> LitrRadioButtonCheckedChanged { get; set; }
        EventHandler<EventArgs> PriceRadioButtonCheckedChanged { get; set; }
        EventHandler<EventArgs> ShowAllPaymentButtonClicked { get; set; }        
        List<Petrol> Petrols { get; set; }
        Guna2RadioButton LitrRadiButton { get; set; }
        Guna2RadioButton PriceRadioButton { get; set; }
        Guna2ComboBox PetrolComboBox { get; set; }
        Guna2ComboBox PriceTextBox { get; set; }
        Guna2NumericUpDown LitrNumericUpDown { get; set; }
        Guna2NumericUpDown PriceNumericUpDown { get; set; }
        Guna2HtmlLabel TotalPaymentLabel { get; set; }
    }
}
