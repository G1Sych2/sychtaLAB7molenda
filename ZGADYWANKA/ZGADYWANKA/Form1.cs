using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZGADYWANKA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int WygLiczba;

        private bool zapauzowana = false;

        private int czas;

        private int LicznikRuchow;

        List<Proba> Proby = new List<Proba>();

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            /// resetuje ustawienia gry do początku
            WygLiczba = 0;
            zapauzowana = false;
            czas = 0;
            LicznikRuchow = 0;
            buttonCheck.Enabled = false;
            StopButton.Enabled = false;
            textBoxfrom.Text = " ";
            textBoxTo.Text = " ";
            textBoxNumber.Text = "Wpisz liczbę";
            labelZaMaloZaDuzo.Visible = false;
            labelTime.Visible = false;
            labelMoves.Visible = false;
            labelNumber.Visible = false;
            TimeLabel.Text = "Czas Gry:";
            timerGameTime.Stop();
            StartInfoLabel.Text = "Podaj zakres i wciśnij Wylosuj!";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            /// pauzuje timer i blokuje spradzenie liczby, gdy jest on zatrzymany
            if(!zapauzowana)
            {
                timerGameTime.Stop();
                StopButton.Text = "Wznów!";
                GenButton.Enabled = false;
                zapauzowana = true;
                buttonCheck.Enabled = false;
            }
            /// wznawia timer i odblokowuje sprawdzenie liczby
            else
            {
                timerGameTime.Start();
                StopButton.Text = "Pauza";
                GenButton.Enabled = true;
                zapauzowana = false;
                buttonCheck.Enabled = true;
            }
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            int od = 0;
            int Do = 0;
            /// sprawdza czy zakres jest uzupełniony prawidłowo
            if (string.IsNullOrWhiteSpace(textBoxfrom.Text))
            {
                StartInfoLabel.Text = "Podaj Liczbę od!";
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTo.Text))
            {
                StartInfoLabel.Text = "Podaj Liczbę do!";
                return;
            }


            od = Convert.ToInt32(textBoxfrom.Text);
            Do = Convert.ToInt32(textBoxTo.Text);

            Random generator = new Random();
            try
            {
                int WylosowanaLiczba = generator.Next(od, Do); /// generuje liczbę
                WygLiczba = WylosowanaLiczba;
            }
            catch (Exception exc)
            {
                StartInfoLabel.Text = "Pierwsza liczba musi być większa od drugiej";
            }


            timerGameTime.Start();  /// odpala timer
            czas = 0;
            StartInfoLabel.Text = "Liczba wylosowana. Odgadnij ją!";
            StopButton.Enabled = true;
            buttonCheck.Enabled = true;
            labelZaMaloZaDuzo.Visible = false;
            labelTime.Visible = false;
            labelMoves.Visible = false;
            labelNumber.Visible = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            /// sprawdza czy została wpisana liczba
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text))
            {
                labelZaMaloZaDuzo.Text = "Podaj Liczbę!";
                labelZaMaloZaDuzo.ForeColor = Color.Black;
                labelZaMaloZaDuzo.Visible = true;
                return;
            }
            int proba = 0;

            try
            {
                proba = Convert.ToInt32(textBoxNumber.Text);
            }
            catch(Exception napis)
            {
                labelZaMaloZaDuzo.Text = "Podaj Liczbę!";
                labelZaMaloZaDuzo.ForeColor = Color.Black;
                labelZaMaloZaDuzo.Visible = true;
            }

            if (proba>WygLiczba)
            {
                /// dodaje probe do listy
                Proba probaOb = new Proba();
                probaOb.SekundaGry = czas;
                probaOb.WygenerowanaLiczba = Convert.ToString(WygLiczba);
                probaOb.WprowadzonaLiczba = textBoxNumber.Text;
                Proby.Add(probaOb);
                ///komunikat
                LicznikRuchow++;
                labelZaMaloZaDuzo.Text = "Za Dużo!";
                labelZaMaloZaDuzo.ForeColor = Color.Red;
                labelZaMaloZaDuzo.Visible = true;
                return;
            }
            else if(proba<WygLiczba)
            {
                /// dodaje probe do listy
                Proba probaOb = new Proba();
                probaOb.SekundaGry = czas;
                probaOb.WygenerowanaLiczba = Convert.ToString(WygLiczba);
                probaOb.WprowadzonaLiczba = textBoxNumber.Text;
                Proby.Add(probaOb);
                /// komunikat
                LicznikRuchow++;
                labelZaMaloZaDuzo.Text = "Za Mało!";
                labelZaMaloZaDuzo.ForeColor = Color.Red;
                labelZaMaloZaDuzo.Visible = true;
                return;
            }
            else if(proba==WygLiczba)
            {
                /// dodaje probe do listy
                Proba probaOb = new Proba();
                probaOb.SekundaGry = czas;
                probaOb.WygenerowanaLiczba = Convert.ToString(WygLiczba);
                probaOb.WprowadzonaLiczba = textBoxNumber.Text;
                Proby.Add(probaOb);
                /// komunikat
                LicznikRuchow++;
                labelZaMaloZaDuzo.Text = "Zgadłeś!";
                labelZaMaloZaDuzo.ForeColor = Color.Green;
                labelZaMaloZaDuzo.Visible = true;
                /// zatrzymuje grę i pokazuje wyniki
                timerGameTime.Stop();
                labelTime.Text = "Całkowity czas gry: " + czas;
                labelMoves.Text = "Liczba ruchów: " + LicznikRuchow;
                labelNumber.Text = "Wylosowana liczba: " + WygLiczba;
                labelTime.Visible = true;
                labelMoves.Visible = true;
                labelNumber.Visible = true;
                buttonCheck.Enabled = false;
                StopButton.Enabled = false;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
        }

        /// odświeża pole po kliknięciu
        private void textBoxNumber_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = " ";
        }

        /// odliczanie
        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            czas++;
            TimeLabel.Text = "Czas gry: "+ Convert.ToString(czas);
        }


        /// Handlery blokujące wprowadzanie liter zamiast liczb
        private void textBoxfrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonStory_Click(object sender, EventArgs e)
        {
            FormStatystyki Stat = new FormStatystyki();
            /// utworzyć nową formę od Formtatystyki a następnie przejść na using danej form i dodać elementy, a następnie show this fom Kappa

                ListView listView1 = new ListView();
                listView1.Bounds = new Rectangle(new Point(12, 12), new Size(255, 215));
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.Scrollable = true;
                listView1.Columns.Add("Wyg. Liczba", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Wprow. Liczba", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Sek. Gry", -2, HorizontalAlignment.Left);

                ///dodanie itemów
                foreach(Proba proba in Proby)
                {
                ListViewItem newItem = new ListViewItem(proba.WygenerowanaLiczba);
                newItem.SubItems.Add(proba.WprowadzonaLiczba);
                newItem.SubItems.Add(Convert.ToString(proba.SekundaGry));
                listView1.Items.Add(newItem);
                }

                Stat.Controls.Add(listView1);

                Stat.Show();
        }
    }
}
