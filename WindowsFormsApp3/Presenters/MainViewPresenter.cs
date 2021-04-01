using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Data;
using WindowsFormsApp3.Models;
using WindowsFormsApp3.Views;

namespace WindowsFormsApp3.Presenters
{
    public class MainViewPresenter
    {
        private readonly CarContext _db;
        private readonly IMainView _view;

        public MainViewPresenter(IMainView view)
        {
            _view = view;


            _view.AddButtonClicked += ViewAddButtonClicked;
            _view.LoadButtonClicked += ViewLoadButtonClicked;

            _db = new CarContext();
        }

        private void ViewLoadButtonClicked(object sender, EventArgs e)
        {
            var list = _db.Cars.ToList();

            _view.Cars = list;

        }

        private void ViewAddButtonClicked(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Model = _view.ModelText,
                Vendor = _view.VendorText,
                Color = _view.ColorText,
                Transmission = _view.TransmissionText,
                Year = int.Parse(_view.YearText)
            };


            _db.Cars.Add(car);
            _db.SaveChanges();

        }

    }
}
