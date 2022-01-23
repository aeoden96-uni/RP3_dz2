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
    public partial class vremenski_raspon : UserControl
    {
        public vremenski_raspon()
        {
            InitializeComponent();

            raspon = new Tuple<DateTime, DateTime>(datum1.vrijednost, datum2.vrijednost);


            datum1.promjena += UserControl_Datum1_ValueChanged;
            datum2.promjena += UserControl_Datum2_ValueChanged;

            //datum1.promjena += new EventHandler(UserControl_Datum1_ValueChanged);
            //datum2.promjena += new EventHandler(UserControl_Datum2_ValueChanged);


        }

        public Tuple<DateTime, DateTime> raspon
        {
            get { return _raspon; }
            set
            {
                _raspon = value;

                datum1.vrijednost = raspon.Item1;
                datum2.vrijednost = raspon.Item2;

            }
        }
        private Tuple<DateTime, DateTime> _raspon;


        public event EventHandler promjena;

        protected void UserControl_Datum1_ValueChanged(object sender, EventArgs e)
        {
            raspon = new Tuple<DateTime, DateTime>(datum1.vrijednost,raspon.Item2);

            if (promjena != null)
                promjena(sender, e);
        }

        protected void UserControl_Datum2_ValueChanged(object sender, EventArgs e)
        {

            raspon = new Tuple<DateTime, DateTime>(raspon.Item1,datum2.vrijednost);


            if (promjena != null)
                promjena(sender, e);
        }



        private void datum1_Load(object sender, EventArgs e)
        {

        }
    }
}
