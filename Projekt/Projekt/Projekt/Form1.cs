using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class oknoGlowne : Form
    {
        Baza baz;
        public oknoGlowne()
        {
            InitializeComponent();

        }


        private void oknoGlowne_Load(object sender, EventArgs e)
        {
            baz = new Baza("baza");
        }
   
 

        private void DodajButton_Click(object sender, EventArgs e)
        {
            PozPlan x = new PozPlan(textBox2.Text,
                                    monthCalendar1.SelectionRange.Start,
                                    (int)numericInterv.Value,
                                    !rzeczCheckBox.Checked,
                                    Convert.ToDouble(textBox1.Text),
                                    rzeczCheckBox.Checked,
                                    katTextBox.Text
                                    );
            if (rzeczCheckBox.Checked && monthCalendar1.SelectionRange.Start <= DateTime.Today)
            {
                baz.pozHistoria.Add(x);
                Console.WriteLine(baz.pozHistoria.Count);
            }
            else if (rzeczCheckBox.Checked)
                MessageBox.Show("Dla pozycji rzeczywistej data nie może być późniejsza niż dzisiaj");
            else baz.pozPlanowane.Add(x);
        }

       
    }



}
