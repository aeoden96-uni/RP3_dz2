using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca02
{
    public partial class datum : UserControl
    {

        public DateTime vrijednost
        {
            get { return _vrijednost; }
            set
            {
                _vrijednost = value;

                pocetak_1.Value = _vrijednost.Day;
                pocetak_2.Value = _vrijednost.Month;
                pocetak_3.Value = _vrijednost.Year;

            }
        }
        private DateTime _vrijednost;

        public event EventHandler promjena;

        

        public datum()
        {
            InitializeComponent();

            vrijednost = DateTime.Today;

            pocetak_1.Value = vrijednost.Day;
            pocetak_2.Value = vrijednost.Month;
            pocetak_3.Value = vrijednost.Year;


            pocetak_1.ValueChanged += pocetak_1_ValueChanged;
            pocetak_2.ValueChanged += pocetak_2_ValueChanged;
            pocetak_3.ValueChanged += pocetak_3_ValueChanged;
        }

        private void pocetak_1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                vrijednost = new DateTime(vrijednost.Year, vrijednost.Month, (int)pocetak_1.Value);
            }
            catch (ArgumentOutOfRangeException)
            {

                if (pocetak_1.Value <= 0)
                    pocetak_1.Value = 1;
                else
                    pocetak_1.Value--;
            }
            

            if (promjena != null)
                promjena(sender, e);
        }
        private void pocetak_2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                vrijednost = new DateTime(vrijednost.Year, (int)pocetak_2.Value, vrijednost.Day);
            }
            catch (ArgumentOutOfRangeException)
            {

                if (pocetak_2.Value <= 0)
                    pocetak_2.Value = 1;
                else
                    pocetak_2.Value--;
            }


            if (promjena != null)
                promjena(sender, e);
        }


        private void pocetak_3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                vrijednost = new DateTime((int)pocetak_3.Value, vrijednost.Month, vrijednost.Day);
            }
            catch (ArgumentOutOfRangeException)
            {
                if (pocetak_3.Value <= 0)
                    pocetak_3.Value = 1;
                else
                    pocetak_3.Value --;
            }


            if (promjena != null)
                promjena(sender, e);
        }


    }
}
