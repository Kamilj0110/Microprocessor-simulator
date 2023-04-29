using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace oskZad5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
            
        }




        //////////////////////////////////////////////////////////
        ///                                                    ///
        ///     Inicjalizacja tablic i wartości początkowych   ///
        ///                                                    ///
        //////////////////////////////////////////////////////////
        private void init()
        {
            labelKrokProgramu = new System.Windows.Forms.Label[] { label1krokProgramu, label2krokProgramu, label3krokProgramu, label4krokProgramu, label5krokProgramu, label6krokProgramu, label7krokProgramu, label8krokProgramu, label9krokProgramu, label10krokProgramu, label11krokProgramu, label12krokProgramu, label13krokProgramu, label14krokProgramu, };
            labelWartoscRejestru = new System.Windows.Forms.Label[] { labelWartoscRejestruA, labelWartoscRejestruB, labelWartoscRejestruC, labelWartoscRejestruD, labelWartoscRejestruIN };

            checkboxyRejestruA = new System.Windows.Forms.CheckBox[] { rejestrAbit0, rejestrAbit1, rejestrAbit2, rejestrAbit3, rejestrAbit4, rejestrAbit5, rejestrAbit6, rejestrAbit7, rejestrAbit8, rejestrAbit9, rejestrAbit10, rejestrAbit11, rejestrAbit12, rejestrAbit13, rejestrAbit14, rejestrAbit15 };
            checkboxyRejestruB = new System.Windows.Forms.CheckBox[] { rejestrBbit0, rejestrBbit1, rejestrBbit2, rejestrBbit3, rejestrBbit4, rejestrBbit5, rejestrBbit6, rejestrBbit7, rejestrBbit8, rejestrBbit9, rejestrBbit10, rejestrBbit11, rejestrBbit12, rejestrBbit13, rejestrBbit14, rejestrBbit15 };
            checkboxyRejestruC = new System.Windows.Forms.CheckBox[] { rejestrCbit0, rejestrCbit1, rejestrCbit2, rejestrCbit3, rejestrCbit4, rejestrCbit5, rejestrCbit6, rejestrCbit7, rejestrCbit8, rejestrCbit9, rejestrCbit10, rejestrCbit11, rejestrCbit12, rejestrCbit13, rejestrCbit14, rejestrCbit15 };
            checkboxyRejestruD = new System.Windows.Forms.CheckBox[] { rejestrDbit0, rejestrDbit1, rejestrDbit2, rejestrDbit3, rejestrDbit4, rejestrDbit5, rejestrDbit6, rejestrDbit7, rejestrDbit8, rejestrDbit9, rejestrDbit10, rejestrDbit11, rejestrDbit12, rejestrDbit13, rejestrDbit14, rejestrDbit15 };
            checkboxyRejestruIN = new System.Windows.Forms.CheckBox[] { rejestrIbit0, rejestrIbit1, rejestrIbit2, rejestrIbit3, rejestrIbit4, rejestrIbit5, rejestrIbit6, rejestrIbit7, rejestrIbit8, rejestrIbit9, rejestrIbit10, rejestrIbit11, rejestrIbit12, rejestrIbit13, rejestrIbit14, rejestrIbit15 };

            tablicaRejestrow = new ushort[] { rejestrA, rejestrB, rejestrC, rejestrD, rejestrIN };

            for (int i = 0; i < 16; i++)
            {
                checkboxyRejestruA[i].Text = "0";
                checkboxyRejestruB[i].Text = "0";
                checkboxyRejestruC[i].Text = "0";
                checkboxyRejestruD[i].Text = "0";
                checkboxyRejestruIN[i].Text = "0";
            }

            label1krokProgramu.Text += st.PadLeft(118, ' ');
        }





        //////////////////////////////////////////////////////////
        ///                                                    ///
        ///     Ustawianie masek bitów i wartości wizualnych   ///
        ///                                                    ///
        //////////////////////////////////////////////////////////

        private ushort ustawMaskeBitu(ushort binary, System.Windows.Forms.CheckBox checkbox)
        {
            if (checkbox != null)
            {
                int bitNumber = Int32.Parse(checkbox.Name.Substring(11));
                ushort bitMask = (ushort)(1 << bitNumber);

                if (checkbox.Checked)
                {
                    checkbox.Text = "1";
                    binary |= bitMask;
                }
                else
                {
                    checkbox.Text = "0";
                    binary &= (ushort)~bitMask;
                } 
            }
            return binary;
        }


        private void ustawBitRejestru(System.Windows.Forms.CheckBox checkbox, int nrRejestru)
        {
            tablicaRejestrow[nrRejestru] = ustawMaskeBitu(tablicaRejestrow[nrRejestru], checkbox);
            labelWartoscRejestru[nrRejestru].Text = "Bin: " + Convert.ToString(tablicaRejestrow[nrRejestru], 2).PadLeft(16, '0') + "   Dec: " + ((int)tablicaRejestrow[nrRejestru]).ToString().PadLeft(5, '0') + "   Hex: " + tablicaRejestrow[nrRejestru].ToString("X").PadLeft(4, '0');
        }





        //////////////////////////////////////////////////////////////////
        ///                                                            ///
        ///    Obsługa zmiany bitów rejestrów po kliknięciu checkboxa  ///
        ///                                                            ///
        //////////////////////////////////////////////////////////////////
        private void rejestrA_CheckedChanged(object sender, EventArgs e)
        {
            ustawBitRejestru(sender as System.Windows.Forms.CheckBox, (int)nrRejestru.A);
        }

        private void rejestrB_CheckedChanged(object sender, EventArgs e)
        {
            ustawBitRejestru(sender as System.Windows.Forms.CheckBox, (int)nrRejestru.B);
        }

        private void rejestrC_CheckedChanged(object sender, EventArgs e)
        {
            ustawBitRejestru(sender as System.Windows.Forms.CheckBox, (int)nrRejestru.C);
        }

        private void rejestrD_CheckedChanged(object sender, EventArgs e)
        {
            ustawBitRejestru(sender as System.Windows.Forms.CheckBox, (int)nrRejestru.D);
        }

        private void rejestrIN_CheckedChanged(object sender, EventArgs e)
        {
            ustawBitRejestru(sender as System.Windows.Forms.CheckBox, (int)nrRejestru.IN);
        }






        //////////////////////////////////////////////////////////
        ///                                                    ///
        ///             Obsługa przycisków                     ///
        ///                                                    ///
        //////////////////////////////////////////////////////////

        private void buttonWykonajRozkaz_Click(object sender, EventArgs e)
        {
            string mnemotechnik = comboMnemotechnik.SelectedItem?.ToString();
            string rejestr1 = comboRejestr1.SelectedItem?.ToString();
            string rejestr2 = comboRejestr2.SelectedItem?.ToString();

            if (mnemotechnik != null && rejestr1 != null && rejestr2 != null)
            {
                listaRozkazow[0] = new rozkaz { Mnemotechnik = mnemotechnik, Rejestr1 = rejestr1, Rejestr2 = rejestr2 };
                wykonajRozkaz(0);
            }
            else
                MessageBox.Show("Nie wybrano wszystkich argumentów");
        }

        private void buttonDodajDoProgramu_Click(object sender, EventArgs e)
        {
            string mnemotechnik = comboMnemotechnik.SelectedItem?.ToString();
            string rejestr1 = comboRejestr1.SelectedItem?.ToString();
            string rejestr2 = comboRejestr2.SelectedItem?.ToString();

            if (mnemotechnik != null && rejestr1 != null && rejestr2 != null)
                dodajKrokProgramu(mnemotechnik, rejestr1, rejestr2);
            else
                MessageBox.Show("Nie wybrano wszystkich argumentów!");  
        }

        private void buttonWykonajProgram_Click(object sender, EventArgs e)
        {
            for (int i = 1; i<aktualnyKrok; i++) 
                wykonajRozkaz(i);

        }

        private void buttonWykonajKrok_Click(object sender, EventArgs e)
        {
           if (wykonywanyKrok<aktualnyKrok && wykonywanyKrok<=maxKrokow)
            {
                if (labelKrokProgramu[wykonywanyKrok - 1].Text.Contains(st))
                    labelKrokProgramu[wykonywanyKrok - 1].Text = labelKrokProgramu[wykonywanyKrok - 1].Text.Substring(0, labelKrokProgramu[wykonywanyKrok - 1].Text.Length - st.Length);

                if(labelKrokProgramu[wykonywanyKrok].Text.Length == 6 || labelKrokProgramu[wykonywanyKrok].Text.Length == 7)
                    labelKrokProgramu[wykonywanyKrok].Text += st.PadLeft(118, ' ');
                else
                    labelKrokProgramu[wykonywanyKrok].Text += st.PadLeft(100, ' ');

                wykonajRozkaz(wykonywanyKrok);
                wykonywanyKrok++;
            }
        }

        private void buttonZapiszProgram_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    for (int i = 1; i < aktualnyKrok; i++)
                        writer.WriteLine($"{listaRozkazow[i].Mnemotechnik},{listaRozkazow[i].Rejestr1},{listaRozkazow[i].Rejestr2}");
        }

        private void buttonWczytajProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < maxKrokow; i++)
                    labelKrokProgramu[i].Text = i + ".    ";

                aktualnyKrok = 1;
                rozkaz[] listaRozkazow = new rozkaz[maxKrokow+1];


                using (StreamReader reader = new StreamReader(dialog.FileName))
                {
                    string linia;
                    while ((linia = reader.ReadLine()) != null)
                    {
                        string[] pola = linia.Split(',');
                        dodajKrokProgramu(pola[0], pola[1], pola[2]);
                    }
                }
            }
        }




        //////////////////////////////////////////////////////////////////
        ///                                                            ///
        ///           Obsługa działań po kliknięciu przycisków         ///
        ///                                                            ///
        //////////////////////////////////////////////////////////////////

        private void dodajKrokProgramu(string mnemotechnik, string rejestr1, string rejestr2)
        {
            if (aktualnyKrok < maxKrokow + 1)
            {
                string kod = mnemotechnik + "   " + rejestr1 + ", " + rejestr2;
                
                labelKrokProgramu[aktualnyKrok - 1].Text = aktualnyKrok + ".    " + kod;
                if (!labelKrokProgramu[wykonywanyKrok - 1].Text.Contains(st) && aktualnyKrok!=1)
                    labelKrokProgramu[wykonywanyKrok-1].Text += st.PadLeft(100, ' ');

                if (aktualnyKrok == 1)
                    labelKrokProgramu[wykonywanyKrok - 1].Text += st.PadLeft(100, ' ');
                listaRozkazow[aktualnyKrok] = new rozkaz { Mnemotechnik = mnemotechnik, Rejestr1 = rejestr1, Rejestr2 = rejestr2 };
                aktualnyKrok++;
            }
            else
                MessageBox.Show("Przekroczono maksymalną ilość kroków programu!");
        }

        private void zmienStanCheckBoxa(int nazwaRejestru)
        {
            switch (nazwaRejestru)
            {
                case 0: for (int i = 0; i < 16; i++) checkboxyRejestruA[i].Checked = ((tablicaRejestrow[(int)nrRejestru.A] >> i) & 1) == 1; break;
                case 1: for (int i = 0; i < 16; i++) checkboxyRejestruB[i].Checked = ((tablicaRejestrow[(int)nrRejestru.B] >> i) & 1) == 1; break;
                case 2: for (int i = 0; i < 16; i++) checkboxyRejestruC[i].Checked = ((tablicaRejestrow[(int)nrRejestru.C] >> i) & 1) == 1; break;
                case 3: for (int i = 0; i < 16; i++) checkboxyRejestruD[i].Checked = ((tablicaRejestrow[(int)nrRejestru.D] >> i) & 1) == 1; break;
                default: break;
            }
        }

        private ushort zwrocRejestr2(int i)
        {
            switch (listaRozkazow[i].Rejestr2)
            {
                case "A": return tablicaRejestrow[(int)nrRejestru.A];
                case "B": return tablicaRejestrow[(int)nrRejestru.B];
                case "C": return tablicaRejestrow[(int)nrRejestru.C];
                case "D": return tablicaRejestrow[(int)nrRejestru.D];
                case "IN": return tablicaRejestrow[(int)nrRejestru.IN];
                default: return 0;
            }
        }

        private void ADDorSUB(int i, bool ADD, int nrRejestru)
        {
            if (ADD)
            {
                if (tablicaRejestrow[nrRejestru] + zwrocRejestr2(i) < 0b10000000000000000)
                {
                    tablicaRejestrow[nrRejestru] += zwrocRejestr2(i);
                    zmienStanCheckBoxa(nrRejestru);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Po wykonaniu tej operacji nastąpi przepełnienie rejestru " + (char)nrRejestru + 65 + ". Czy chcesz kontynuować?", "Uwaga", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        tablicaRejestrow[nrRejestru] += zwrocRejestr2(i);
                        zmienStanCheckBoxa(nrRejestru);
                    }
                    else
                        MessageBox.Show("Krok został pominięty.", "Informacja");
                }
            }

            else
            {
                if (tablicaRejestrow[nrRejestru] - zwrocRejestr2(i) > tablicaRejestrow[nrRejestru])
                {
                    tablicaRejestrow[nrRejestru] -= zwrocRejestr2(i);
                    zmienStanCheckBoxa(nrRejestru);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Po wykonaniu tej operacji nastąpi przepełnienie rejestru " + (char)nrRejestru + 65 + ". Czy chcesz kontynuować?", "Uwaga", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        tablicaRejestrow[nrRejestru] -= zwrocRejestr2(i);
                        zmienStanCheckBoxa(nrRejestru);
                    }
                    else
                        MessageBox.Show("Krok został pominięty.", "Informacja");
                }
            }
        }

        private void wykonajRozkaz(int i)
        {
            switch (listaRozkazow[i].Mnemotechnik)
            {
                case "MOV":
                    {
                        switch (listaRozkazow[i].Rejestr1)
                        {
                            case "A": tablicaRejestrow[(int)nrRejestru.A] = zwrocRejestr2(i); zmienStanCheckBoxa((int)nrRejestru.A); break;
                            case "B": tablicaRejestrow[(int)nrRejestru.B] = zwrocRejestr2(i); zmienStanCheckBoxa((int)nrRejestru.B); break;
                            case "C": tablicaRejestrow[(int)nrRejestru.C] = zwrocRejestr2(i); zmienStanCheckBoxa((int)nrRejestru.C); break;
                            case "D": tablicaRejestrow[(int)nrRejestru.D] = zwrocRejestr2(i); zmienStanCheckBoxa((int)nrRejestru.D); break;
                        }
                    }
                    break;


                case "ADD":
                    {
                        switch (listaRozkazow[i].Rejestr1)
                        {
                            case "A": ADDorSUB(i, true, (int)nrRejestru.A); break;
                            case "B": ADDorSUB(i, true, (int)nrRejestru.B); break;
                            case "C": ADDorSUB(i, true, (int)nrRejestru.C); break;
                            case "D": ADDorSUB(i, true, (int)nrRejestru.D); break;
                        }
                    }
                    break;


                case "SUB":
                    {
                        switch (listaRozkazow[i].Rejestr1)
                        {
                            case "A": ADDorSUB(i, false, (int)nrRejestru.A); break;
                            case "B": ADDorSUB(i, false, (int)nrRejestru.B); break;
                            case "C": ADDorSUB(i, false, (int)nrRejestru.C); break;
                            case "D": ADDorSUB(i, false, (int)nrRejestru.D); break;
                        }
                    }
                    break;
            }
        }
    }
}
