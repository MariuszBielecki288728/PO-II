using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
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
            baz = new Baza("baza", 0);

            refresh();
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
                refresh();
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
                refresh();
               }
                
            
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            if (!usunZHistCheckBox.Checked)
            {
                baz.pozPlanowane = baz.pozPlanowane.Where(p => p.nazwa != usunTextBox.Text).ToList();

                refresh();
            }
            else
            {
                baz.pozHistoria = baz.pozHistoria.Where(p => p.nazwa != usunTextBox.Text).ToList();
                refresh();
            }
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Plik dat|*.dat";
            openFileDialog1.Title = "Wczytaj plik budżetu";
            openFileDialog1.ShowDialog();
            Baza bazpom = baz;
            baz = WczytZapis.wczytaj(openFileDialog1.FileName);
            if (baz == null)
            {
                MessageBox.Show("Nie udało się wczytać pliku");
                baz = bazpom;
            }
            refresh();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik dat|*.dat";
            saveFileDialog.Title = "Zapisz plik budżetu";
            saveFileDialog.ShowDialog();
            WczytZapis.zapisz(baz, saveFileDialog.FileName);
        }

        private void odswiezBut_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
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

            saldoLab.Text = baz.budżet.ToString();


            najPozGrid.DataSource = baz.pozPlanowane.Select(n => new MyViewMode()
            { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderBy(b => b.Termin).ToList();

            histPozGrid.DataSource = baz.pozHistoria.Select(n => new MyViewMode()
            { Termin = n.termin, Nazwa = n.nazwa, Wartość = n.wysokość, Kategoria = n.kategoria }).ToList().OrderByDescending(b => b.Termin).ToList();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontakt.facebook();
        }

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontakt.mail();
        }

        private void stronaAutoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontakt.strona();
        }

        private void zmieńSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj nowe saldo",
                       "Zmień Saldo",
                       "0",
                       500,
                       300);
            try
            {
                baz.budżet = double.Parse(input); //TODO o tryować takie rzeczy
            }
            catch
            {
                MessageBox.Show("Nie udało się zmienić salda");
            }
            refresh();
        }
    }
    
 



}
