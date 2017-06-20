using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    
    public partial class oknoGlowne : Form
    {
        Baza baz;
        bool pomCzyPl;
        double wys;
        public oknoGlowne()
        {
            InitializeComponent();

        }


        private void oknoGlowne_Load(object sender, EventArgs e)
        {
            baz = new Baza("baza", 1000);

            saldoLab.Text = baz.budżet.ToString();

            najPozGrid.DataSource = baz.pozPlanowane.Select(n => new
            MyViewMode() { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderBy(b => b.Termin).ToList();

            histPozGrid.DataSource = baz.pozHistoria.Select(n => new MyViewMode()
            { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderByDescending(b => b.Termin).ToList();

            double xx = Liczymy.bilansPlanowany(baz);
            double yy = Liczymy.bilansRzeczywisty(baz);

            bilPlanLab.Text = xx.ToString();
            bilRzeczLab.Text = yy.ToString();
            if (xx <= 0)
            {
                bilPlanLab.ForeColor = Color.Red;
            }
            if (yy <= 0)
            {
                bilRzeczLab.ForeColor = Color.Red;
            }
        }
   
 

        private void DodajButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                pomCzyPl=false;
                wys = 0;
            }
            else
            {
                pomCzyPl = Convert.ToDouble(textBox1.Text) < 0;
                wys = Convert.ToDouble(textBox1.Text);

            }
                

            PozPlan x = new PozPlan(textBox2.Text,
                                    monthCalendar1.SelectionRange.Start,
                                    (int)numericInterv.Value,
                                    pomCzyPl,
                                    wys,
                                    rzeczCheckBox.Checked,
                                    katTextBox.Text
                                    );


            if (rzeczCheckBox.Checked && monthCalendar1.SelectionRange.Start <= DateTime.Today)
            {
                



                foreach (PozPlan p in baz.pozPlanowane)
                {
                  
                    if (p.nazwa == textBox2.Text)
                    {
                        
                        x = p;
                    }
                   
                }

                

                baz.addPozRzecz(x);

                saldoLab.Text = baz.budżet.ToString();


                najPozGrid.DataSource = baz.pozPlanowane.Select(n => new MyViewMode()
                { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderBy(b => b.Termin).ToList();

                histPozGrid.DataSource = baz.pozHistoria.Select(n => new MyViewMode()
                { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderByDescending(b=>b.Termin).ToList();
            }
            else if (rzeczCheckBox.Checked)
                MessageBox.Show("Dla pozycji rzeczywistej data nie może być późniejsza niż dzisiaj");
            else if (monthCalendar1.SelectionRange.Start < DateTime.Today)
                MessageBox.Show("Dla pozycji planowanej data nie może być wcześniejsza niż dzisiaj");
            else
            {
                if (baz.pozPlanowane.Where(u => u.nazwa == textBox2.Text).ToList().Any())
                {
                    MessageBox.Show("Istnieje już pozycja o tej nazwie");
                    return;
                }
                baz.addPozPlan(x);
               
                najPozGrid.DataSource = baz.pozPlanowane.Select(n => new MyViewMode()
                { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderBy(b => b.Termin).ToList();
            }
                
            
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            if (!usunZHistCheckBox.Checked)
            {
                baz.pozPlanowane = baz.pozPlanowane.Where(p => p.nazwa != usunTextBox.Text).ToList();

                najPozGrid.DataSource = baz.pozPlanowane.Select(n => new MyViewMode()
                { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderBy(b => b.Termin).ToList();
            }
            else
            {
                baz.pozHistoria = baz.pozHistoria.Where(p => p.nazwa != usunTextBox.Text).ToList();
                histPozGrid.DataSource = baz.pozHistoria.Select(n => new MyViewMode()
                { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderByDescending(b => b.Termin).ToList();
            }
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Plik dat|*.dat";
            openFileDialog.Title = "Wczytaj plik budżetu";
            openFileDialog.ShowDialog();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik dat|*.dat";
            saveFileDialog.Title = "Zapisz plik budżetu";
            saveFileDialog.ShowDialog();
        }

        private void odswiezBut_Click(object sender, EventArgs e)
        {
            double xx = Liczymy.bilansPlanowany(baz);
            double yy = Liczymy.bilansRzeczywisty(baz);

            bilPlanLab.Text = xx.ToString();
            bilRzeczLab.Text = yy.ToString();
            if (xx <= 0)
            {
                bilPlanLab.ForeColor = Color.Red;
            }
            if (yy <= 0)
            {
                bilRzeczLab.ForeColor = Color.Red;
            }
        }
    }
    class MyViewMode
    {
        public DateTime Termin { get; set; }
        public string Nazwa { get; set; }
        public double Wartość { get; set; }
        public string Kategoria { get; set; }
    }
 



}
