using System.Reflection.Emit;

namespace oskZad5
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        ushort rejestrA =  0b0000000000000000;
        ushort rejestrB =  0b0000000000000000;
        ushort rejestrC =  0b0000000000000000;
        ushort rejestrD =  0b0000000000000000;
        ushort rejestrIN = 0b0000000000000000;

        int aktualnyKrok = 1;
        int wykonywanyKrok = 1;

        const int maxKrokow = 14;

        string st = "<===";

        System.Windows.Forms.CheckBox[] checkboxyRejestruA = new System.Windows.Forms.CheckBox[16];
        System.Windows.Forms.CheckBox[] checkboxyRejestruB = new System.Windows.Forms.CheckBox[16];
        System.Windows.Forms.CheckBox[] checkboxyRejestruC = new System.Windows.Forms.CheckBox[16];
        System.Windows.Forms.CheckBox[] checkboxyRejestruD = new System.Windows.Forms.CheckBox[16];
        System.Windows.Forms.CheckBox[] checkboxyRejestruIN = new System.Windows.Forms.CheckBox[16];

        System.Windows.Forms.Label[] labelKrokProgramu = new System.Windows.Forms.Label[15];
        System.Windows.Forms.Label[] labelWartoscRejestru = new System.Windows.Forms.Label[15];

        enum nrRejestru
        {
            A,B,C,D,IN
        }

        ushort[] tablicaRejestrow = new ushort[4];

        public struct rozkaz
        {
            public string Mnemotechnik;
            public string Rejestr1;
            public string Rejestr2;
        }


        rozkaz[] listaRozkazow = new rozkaz[maxKrokow+1];



        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.rejestrAbit15 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit14 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit13 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit12 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit11 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit10 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit9 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit8 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit7 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit6 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit5 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit4 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit3 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit2 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit1 = new System.Windows.Forms.CheckBox();
            this.rejestrAbit0 = new System.Windows.Forms.CheckBox();
            this.labelRejestrA = new System.Windows.Forms.Label();
            this.labelAH = new System.Windows.Forms.Label();
            this.labelRejestrAbit15 = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelRejestrAbit0 = new System.Windows.Forms.Label();
            this.labelRejestrBbit0 = new System.Windows.Forms.Label();
            this.labelBL = new System.Windows.Forms.Label();
            this.labelRejestrBbit15 = new System.Windows.Forms.Label();
            this.labelBH = new System.Windows.Forms.Label();
            this.labelRejestrB = new System.Windows.Forms.Label();
            this.rejestrBbit1 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit2 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit3 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit4 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit5 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit6 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit7 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit8 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit9 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit10 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit11 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit12 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit13 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit14 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit15 = new System.Windows.Forms.CheckBox();
            this.rejestrBbit0 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit0 = new System.Windows.Forms.CheckBox();
            this.labelRejestrDbit0 = new System.Windows.Forms.Label();
            this.labelDL = new System.Windows.Forms.Label();
            this.labelRejestrDbit15 = new System.Windows.Forms.Label();
            this.labelDH = new System.Windows.Forms.Label();
            this.labelRejestrD = new System.Windows.Forms.Label();
            this.rejestrDbit1 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit2 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit3 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit4 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit5 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit6 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit7 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit8 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit9 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit10 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit11 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit12 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit13 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit14 = new System.Windows.Forms.CheckBox();
            this.rejestrDbit15 = new System.Windows.Forms.CheckBox();
            this.labelRejestrCbit0 = new System.Windows.Forms.Label();
            this.labelCL = new System.Windows.Forms.Label();
            this.labelRejestrCbit15 = new System.Windows.Forms.Label();
            this.labelCH = new System.Windows.Forms.Label();
            this.labelRejestrC = new System.Windows.Forms.Label();
            this.rejestrCbit0 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit1 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit2 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit3 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit4 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit5 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit6 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit7 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit8 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit9 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit10 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit11 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit12 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit13 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit14 = new System.Windows.Forms.CheckBox();
            this.rejestrCbit15 = new System.Windows.Forms.CheckBox();
            this.ramkaRejestrA = new System.Windows.Forms.Label();
            this.ramkaRejestrC = new System.Windows.Forms.Label();
            this.ramkaRejestrB = new System.Windows.Forms.Label();
            this.ramkaRejestrD = new System.Windows.Forms.Label();
            this.napisRejestry = new System.Windows.Forms.Label();
            this.napisKod = new System.Windows.Forms.Label();
            this.comboRejestr1 = new System.Windows.Forms.ComboBox();
            this.napisStrzalka = new System.Windows.Forms.Label();
            this.comboRejestr2 = new System.Windows.Forms.ComboBox();
            this.comboMnemotechnik = new System.Windows.Forms.ComboBox();
            this.napisAdresowanie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelINL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelINH = new System.Windows.Forms.Label();
            this.labelRejestrIN = new System.Windows.Forms.Label();
            this.rejestrIbit0 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit1 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit2 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit3 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit4 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit5 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit6 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit7 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit8 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit9 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit10 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit11 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit12 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit13 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit14 = new System.Windows.Forms.CheckBox();
            this.rejestrIbit15 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelWartoscRejestruIN = new System.Windows.Forms.Label();
            this.labelWartoscRejestruB = new System.Windows.Forms.Label();
            this.labelWartoscRejestruD = new System.Windows.Forms.Label();
            this.labelWartoscRejestruC = new System.Windows.Forms.Label();
            this.labelWartoscRejestruA = new System.Windows.Forms.Label();
            this.napisProgram = new System.Windows.Forms.Label();
            this.label1krokProgramu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2krokProgramu = new System.Windows.Forms.Label();
            this.label3krokProgramu = new System.Windows.Forms.Label();
            this.label4krokProgramu = new System.Windows.Forms.Label();
            this.label5krokProgramu = new System.Windows.Forms.Label();
            this.label6krokProgramu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDodajDoProgramu = new System.Windows.Forms.Button();
            this.buttonWykonajRozkaz = new System.Windows.Forms.Button();
            this.buttonZapiszProgram = new System.Windows.Forms.Button();
            this.buttonWczytajProgram = new System.Windows.Forms.Button();
            this.buttonWykonajKrok = new System.Windows.Forms.Button();
            this.buttonWykonajProgram = new System.Windows.Forms.Button();
            this.label7krokProgramu = new System.Windows.Forms.Label();
            this.label8krokProgramu = new System.Windows.Forms.Label();
            this.label9krokProgramu = new System.Windows.Forms.Label();
            this.label10krokProgramu = new System.Windows.Forms.Label();
            this.label11krokProgramu = new System.Windows.Forms.Label();
            this.label12krokProgramu = new System.Windows.Forms.Label();
            this.label13krokProgramu = new System.Windows.Forms.Label();
            this.label14krokProgramu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rejestrAbit15
            // 
            this.rejestrAbit15.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit15.AutoSize = true;
            this.rejestrAbit15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit15.Location = new System.Drawing.Point(132, 126);
            this.rejestrAbit15.Name = "rejestrAbit15";
            this.rejestrAbit15.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit15.TabIndex = 0;
            this.rejestrAbit15.UseVisualStyleBackColor = true;
            this.rejestrAbit15.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit14
            // 
            this.rejestrAbit14.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit14.AutoSize = true;
            this.rejestrAbit14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit14.Location = new System.Drawing.Point(153, 126);
            this.rejestrAbit14.Name = "rejestrAbit14";
            this.rejestrAbit14.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit14.TabIndex = 1;
            this.rejestrAbit14.UseVisualStyleBackColor = true;
            this.rejestrAbit14.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit13
            // 
            this.rejestrAbit13.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit13.AutoSize = true;
            this.rejestrAbit13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit13.Location = new System.Drawing.Point(174, 126);
            this.rejestrAbit13.Name = "rejestrAbit13";
            this.rejestrAbit13.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit13.TabIndex = 2;
            this.rejestrAbit13.UseVisualStyleBackColor = true;
            this.rejestrAbit13.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit12
            // 
            this.rejestrAbit12.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit12.AutoSize = true;
            this.rejestrAbit12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit12.Location = new System.Drawing.Point(195, 126);
            this.rejestrAbit12.Name = "rejestrAbit12";
            this.rejestrAbit12.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit12.TabIndex = 3;
            this.rejestrAbit12.UseVisualStyleBackColor = true;
            this.rejestrAbit12.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit11
            // 
            this.rejestrAbit11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit11.AutoSize = true;
            this.rejestrAbit11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit11.Location = new System.Drawing.Point(216, 126);
            this.rejestrAbit11.Name = "rejestrAbit11";
            this.rejestrAbit11.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit11.TabIndex = 4;
            this.rejestrAbit11.UseVisualStyleBackColor = true;
            this.rejestrAbit11.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit10
            // 
            this.rejestrAbit10.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit10.AutoSize = true;
            this.rejestrAbit10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit10.Location = new System.Drawing.Point(237, 126);
            this.rejestrAbit10.Name = "rejestrAbit10";
            this.rejestrAbit10.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit10.TabIndex = 5;
            this.rejestrAbit10.UseVisualStyleBackColor = true;
            this.rejestrAbit10.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit9
            // 
            this.rejestrAbit9.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit9.AutoSize = true;
            this.rejestrAbit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit9.Location = new System.Drawing.Point(258, 126);
            this.rejestrAbit9.Name = "rejestrAbit9";
            this.rejestrAbit9.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit9.TabIndex = 6;
            this.rejestrAbit9.UseVisualStyleBackColor = true;
            this.rejestrAbit9.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit8
            // 
            this.rejestrAbit8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit8.AutoSize = true;
            this.rejestrAbit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit8.Location = new System.Drawing.Point(279, 126);
            this.rejestrAbit8.Name = "rejestrAbit8";
            this.rejestrAbit8.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit8.TabIndex = 7;
            this.rejestrAbit8.UseVisualStyleBackColor = true;
            this.rejestrAbit8.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit7
            // 
            this.rejestrAbit7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit7.AutoSize = true;
            this.rejestrAbit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit7.Location = new System.Drawing.Point(319, 126);
            this.rejestrAbit7.Name = "rejestrAbit7";
            this.rejestrAbit7.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit7.TabIndex = 8;
            this.rejestrAbit7.UseVisualStyleBackColor = true;
            this.rejestrAbit7.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit6
            // 
            this.rejestrAbit6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit6.AutoSize = true;
            this.rejestrAbit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit6.Location = new System.Drawing.Point(340, 126);
            this.rejestrAbit6.Name = "rejestrAbit6";
            this.rejestrAbit6.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit6.TabIndex = 9;
            this.rejestrAbit6.UseVisualStyleBackColor = true;
            this.rejestrAbit6.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit5
            // 
            this.rejestrAbit5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit5.AutoSize = true;
            this.rejestrAbit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit5.Location = new System.Drawing.Point(361, 126);
            this.rejestrAbit5.Name = "rejestrAbit5";
            this.rejestrAbit5.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit5.TabIndex = 10;
            this.rejestrAbit5.UseVisualStyleBackColor = true;
            this.rejestrAbit5.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit4
            // 
            this.rejestrAbit4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit4.AutoSize = true;
            this.rejestrAbit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit4.Location = new System.Drawing.Point(382, 126);
            this.rejestrAbit4.Name = "rejestrAbit4";
            this.rejestrAbit4.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit4.TabIndex = 11;
            this.rejestrAbit4.UseVisualStyleBackColor = true;
            this.rejestrAbit4.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit3
            // 
            this.rejestrAbit3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit3.AutoSize = true;
            this.rejestrAbit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit3.Location = new System.Drawing.Point(403, 126);
            this.rejestrAbit3.Name = "rejestrAbit3";
            this.rejestrAbit3.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit3.TabIndex = 12;
            this.rejestrAbit3.UseVisualStyleBackColor = true;
            this.rejestrAbit3.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit2
            // 
            this.rejestrAbit2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit2.AutoSize = true;
            this.rejestrAbit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit2.Location = new System.Drawing.Point(424, 126);
            this.rejestrAbit2.Name = "rejestrAbit2";
            this.rejestrAbit2.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit2.TabIndex = 13;
            this.rejestrAbit2.UseVisualStyleBackColor = true;
            this.rejestrAbit2.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit1
            // 
            this.rejestrAbit1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit1.AutoSize = true;
            this.rejestrAbit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit1.Location = new System.Drawing.Point(445, 126);
            this.rejestrAbit1.Name = "rejestrAbit1";
            this.rejestrAbit1.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit1.TabIndex = 14;
            this.rejestrAbit1.UseVisualStyleBackColor = true;
            this.rejestrAbit1.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // rejestrAbit0
            // 
            this.rejestrAbit0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrAbit0.AutoSize = true;
            this.rejestrAbit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrAbit0.Location = new System.Drawing.Point(466, 126);
            this.rejestrAbit0.Name = "rejestrAbit0";
            this.rejestrAbit0.Size = new System.Drawing.Size(6, 6);
            this.rejestrAbit0.TabIndex = 15;
            this.rejestrAbit0.UseVisualStyleBackColor = true;
            this.rejestrAbit0.CheckedChanged += new System.EventHandler(this.rejestrA_CheckedChanged);
            // 
            // labelRejestrA
            // 
            this.labelRejestrA.AutoSize = true;
            this.labelRejestrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestrA.Location = new System.Drawing.Point(40, 126);
            this.labelRejestrA.Name = "labelRejestrA";
            this.labelRejestrA.Size = new System.Drawing.Size(71, 16);
            this.labelRejestrA.TabIndex = 16;
            this.labelRejestrA.Text = "Rejestr A";
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Location = new System.Drawing.Point(202, 97);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(22, 13);
            this.labelAH.TabIndex = 17;
            this.labelAH.Text = "AH";
            // 
            // labelRejestrAbit15
            // 
            this.labelRejestrAbit15.AutoSize = true;
            this.labelRejestrAbit15.Location = new System.Drawing.Point(129, 154);
            this.labelRejestrAbit15.Name = "labelRejestrAbit15";
            this.labelRejestrAbit15.Size = new System.Drawing.Size(33, 13);
            this.labelRejestrAbit15.TabIndex = 18;
            this.labelRejestrAbit15.Text = "15-bit";
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Location = new System.Drawing.Point(389, 97);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(20, 13);
            this.labelAL.TabIndex = 19;
            this.labelAL.Text = "AL";
            // 
            // labelRejestrAbit0
            // 
            this.labelRejestrAbit0.AutoSize = true;
            this.labelRejestrAbit0.Location = new System.Drawing.Point(454, 154);
            this.labelRejestrAbit0.Name = "labelRejestrAbit0";
            this.labelRejestrAbit0.Size = new System.Drawing.Size(27, 13);
            this.labelRejestrAbit0.TabIndex = 20;
            this.labelRejestrAbit0.Text = "0-bit";
            // 
            // labelRejestrBbit0
            // 
            this.labelRejestrBbit0.AutoSize = true;
            this.labelRejestrBbit0.Location = new System.Drawing.Point(454, 296);
            this.labelRejestrBbit0.Name = "labelRejestrBbit0";
            this.labelRejestrBbit0.Size = new System.Drawing.Size(27, 13);
            this.labelRejestrBbit0.TabIndex = 41;
            this.labelRejestrBbit0.Text = "0-bit";
            // 
            // labelBL
            // 
            this.labelBL.AutoSize = true;
            this.labelBL.Location = new System.Drawing.Point(389, 239);
            this.labelBL.Name = "labelBL";
            this.labelBL.Size = new System.Drawing.Size(20, 13);
            this.labelBL.TabIndex = 40;
            this.labelBL.Text = "BL";
            // 
            // labelRejestrBbit15
            // 
            this.labelRejestrBbit15.AutoSize = true;
            this.labelRejestrBbit15.Location = new System.Drawing.Point(129, 296);
            this.labelRejestrBbit15.Name = "labelRejestrBbit15";
            this.labelRejestrBbit15.Size = new System.Drawing.Size(33, 13);
            this.labelRejestrBbit15.TabIndex = 39;
            this.labelRejestrBbit15.Text = "15-bit";
            // 
            // labelBH
            // 
            this.labelBH.AutoSize = true;
            this.labelBH.Location = new System.Drawing.Point(202, 239);
            this.labelBH.Name = "labelBH";
            this.labelBH.Size = new System.Drawing.Size(22, 13);
            this.labelBH.TabIndex = 38;
            this.labelBH.Text = "BH";
            // 
            // labelRejestrB
            // 
            this.labelRejestrB.AutoSize = true;
            this.labelRejestrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestrB.Location = new System.Drawing.Point(40, 268);
            this.labelRejestrB.Name = "labelRejestrB";
            this.labelRejestrB.Size = new System.Drawing.Size(71, 16);
            this.labelRejestrB.TabIndex = 37;
            this.labelRejestrB.Text = "Rejestr B";
            // 
            // rejestrBbit1
            // 
            this.rejestrBbit1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit1.AutoSize = true;
            this.rejestrBbit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit1.Location = new System.Drawing.Point(445, 268);
            this.rejestrBbit1.Name = "rejestrBbit1";
            this.rejestrBbit1.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit1.TabIndex = 35;
            this.rejestrBbit1.UseVisualStyleBackColor = true;
            this.rejestrBbit1.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit2
            // 
            this.rejestrBbit2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit2.AutoSize = true;
            this.rejestrBbit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit2.Location = new System.Drawing.Point(424, 268);
            this.rejestrBbit2.Name = "rejestrBbit2";
            this.rejestrBbit2.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit2.TabIndex = 34;
            this.rejestrBbit2.UseVisualStyleBackColor = true;
            this.rejestrBbit2.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit3
            // 
            this.rejestrBbit3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit3.AutoSize = true;
            this.rejestrBbit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit3.Location = new System.Drawing.Point(403, 268);
            this.rejestrBbit3.Name = "rejestrBbit3";
            this.rejestrBbit3.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit3.TabIndex = 33;
            this.rejestrBbit3.UseVisualStyleBackColor = true;
            this.rejestrBbit3.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit4
            // 
            this.rejestrBbit4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit4.AutoSize = true;
            this.rejestrBbit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit4.Location = new System.Drawing.Point(382, 268);
            this.rejestrBbit4.Name = "rejestrBbit4";
            this.rejestrBbit4.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit4.TabIndex = 32;
            this.rejestrBbit4.UseVisualStyleBackColor = true;
            this.rejestrBbit4.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit5
            // 
            this.rejestrBbit5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit5.AutoSize = true;
            this.rejestrBbit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit5.Location = new System.Drawing.Point(361, 268);
            this.rejestrBbit5.Name = "rejestrBbit5";
            this.rejestrBbit5.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit5.TabIndex = 31;
            this.rejestrBbit5.UseVisualStyleBackColor = true;
            this.rejestrBbit5.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit6
            // 
            this.rejestrBbit6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit6.AutoSize = true;
            this.rejestrBbit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit6.Location = new System.Drawing.Point(340, 268);
            this.rejestrBbit6.Name = "rejestrBbit6";
            this.rejestrBbit6.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit6.TabIndex = 30;
            this.rejestrBbit6.UseVisualStyleBackColor = true;
            this.rejestrBbit6.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit7
            // 
            this.rejestrBbit7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit7.AutoSize = true;
            this.rejestrBbit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit7.Location = new System.Drawing.Point(319, 268);
            this.rejestrBbit7.Name = "rejestrBbit7";
            this.rejestrBbit7.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit7.TabIndex = 29;
            this.rejestrBbit7.UseVisualStyleBackColor = true;
            this.rejestrBbit7.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit8
            // 
            this.rejestrBbit8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit8.AutoSize = true;
            this.rejestrBbit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit8.Location = new System.Drawing.Point(279, 268);
            this.rejestrBbit8.Name = "rejestrBbit8";
            this.rejestrBbit8.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit8.TabIndex = 28;
            this.rejestrBbit8.UseVisualStyleBackColor = true;
            this.rejestrBbit8.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit9
            // 
            this.rejestrBbit9.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit9.AutoSize = true;
            this.rejestrBbit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit9.Location = new System.Drawing.Point(258, 268);
            this.rejestrBbit9.Name = "rejestrBbit9";
            this.rejestrBbit9.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit9.TabIndex = 27;
            this.rejestrBbit9.UseVisualStyleBackColor = true;
            this.rejestrBbit9.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit10
            // 
            this.rejestrBbit10.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit10.AutoSize = true;
            this.rejestrBbit10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit10.Location = new System.Drawing.Point(237, 268);
            this.rejestrBbit10.Name = "rejestrBbit10";
            this.rejestrBbit10.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit10.TabIndex = 26;
            this.rejestrBbit10.UseVisualStyleBackColor = true;
            this.rejestrBbit10.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit11
            // 
            this.rejestrBbit11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit11.AutoSize = true;
            this.rejestrBbit11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit11.Location = new System.Drawing.Point(216, 268);
            this.rejestrBbit11.Name = "rejestrBbit11";
            this.rejestrBbit11.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit11.TabIndex = 25;
            this.rejestrBbit11.UseVisualStyleBackColor = true;
            this.rejestrBbit11.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit12
            // 
            this.rejestrBbit12.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit12.AutoSize = true;
            this.rejestrBbit12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit12.Location = new System.Drawing.Point(195, 268);
            this.rejestrBbit12.Name = "rejestrBbit12";
            this.rejestrBbit12.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit12.TabIndex = 24;
            this.rejestrBbit12.UseVisualStyleBackColor = true;
            this.rejestrBbit12.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit13
            // 
            this.rejestrBbit13.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit13.AutoSize = true;
            this.rejestrBbit13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit13.Location = new System.Drawing.Point(174, 268);
            this.rejestrBbit13.Name = "rejestrBbit13";
            this.rejestrBbit13.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit13.TabIndex = 23;
            this.rejestrBbit13.UseVisualStyleBackColor = true;
            this.rejestrBbit13.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit14
            // 
            this.rejestrBbit14.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit14.AutoSize = true;
            this.rejestrBbit14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit14.Location = new System.Drawing.Point(153, 268);
            this.rejestrBbit14.Name = "rejestrBbit14";
            this.rejestrBbit14.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit14.TabIndex = 22;
            this.rejestrBbit14.UseVisualStyleBackColor = true;
            this.rejestrBbit14.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit15
            // 
            this.rejestrBbit15.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit15.AutoSize = true;
            this.rejestrBbit15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit15.Location = new System.Drawing.Point(132, 268);
            this.rejestrBbit15.Name = "rejestrBbit15";
            this.rejestrBbit15.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit15.TabIndex = 21;
            this.rejestrBbit15.UseVisualStyleBackColor = true;
            this.rejestrBbit15.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrBbit0
            // 
            this.rejestrBbit0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrBbit0.AutoSize = true;
            this.rejestrBbit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrBbit0.Location = new System.Drawing.Point(466, 268);
            this.rejestrBbit0.Name = "rejestrBbit0";
            this.rejestrBbit0.Size = new System.Drawing.Size(6, 6);
            this.rejestrBbit0.TabIndex = 42;
            this.rejestrBbit0.UseVisualStyleBackColor = true;
            this.rejestrBbit0.CheckedChanged += new System.EventHandler(this.rejestrB_CheckedChanged);
            // 
            // rejestrDbit0
            // 
            this.rejestrDbit0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit0.AutoSize = true;
            this.rejestrDbit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit0.Location = new System.Drawing.Point(992, 268);
            this.rejestrDbit0.Name = "rejestrDbit0";
            this.rejestrDbit0.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit0.TabIndex = 84;
            this.rejestrDbit0.UseVisualStyleBackColor = true;
            this.rejestrDbit0.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // labelRejestrDbit0
            // 
            this.labelRejestrDbit0.AutoSize = true;
            this.labelRejestrDbit0.Location = new System.Drawing.Point(980, 296);
            this.labelRejestrDbit0.Name = "labelRejestrDbit0";
            this.labelRejestrDbit0.Size = new System.Drawing.Size(27, 13);
            this.labelRejestrDbit0.TabIndex = 83;
            this.labelRejestrDbit0.Text = "0-bit";
            // 
            // labelDL
            // 
            this.labelDL.AutoSize = true;
            this.labelDL.Location = new System.Drawing.Point(915, 239);
            this.labelDL.Name = "labelDL";
            this.labelDL.Size = new System.Drawing.Size(21, 13);
            this.labelDL.TabIndex = 82;
            this.labelDL.Text = "DL";
            // 
            // labelRejestrDbit15
            // 
            this.labelRejestrDbit15.AutoSize = true;
            this.labelRejestrDbit15.Location = new System.Drawing.Point(655, 296);
            this.labelRejestrDbit15.Name = "labelRejestrDbit15";
            this.labelRejestrDbit15.Size = new System.Drawing.Size(33, 13);
            this.labelRejestrDbit15.TabIndex = 81;
            this.labelRejestrDbit15.Text = "15-bit";
            // 
            // labelDH
            // 
            this.labelDH.AutoSize = true;
            this.labelDH.Location = new System.Drawing.Point(728, 239);
            this.labelDH.Name = "labelDH";
            this.labelDH.Size = new System.Drawing.Size(23, 13);
            this.labelDH.TabIndex = 80;
            this.labelDH.Text = "DH";
            // 
            // labelRejestrD
            // 
            this.labelRejestrD.AutoSize = true;
            this.labelRejestrD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestrD.Location = new System.Drawing.Point(566, 268);
            this.labelRejestrD.Name = "labelRejestrD";
            this.labelRejestrD.Size = new System.Drawing.Size(72, 16);
            this.labelRejestrD.TabIndex = 79;
            this.labelRejestrD.Text = "Rejestr D";
            // 
            // rejestrDbit1
            // 
            this.rejestrDbit1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit1.AutoSize = true;
            this.rejestrDbit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit1.Location = new System.Drawing.Point(971, 268);
            this.rejestrDbit1.Name = "rejestrDbit1";
            this.rejestrDbit1.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit1.TabIndex = 78;
            this.rejestrDbit1.UseVisualStyleBackColor = true;
            this.rejestrDbit1.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit2
            // 
            this.rejestrDbit2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit2.AutoSize = true;
            this.rejestrDbit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit2.Location = new System.Drawing.Point(950, 268);
            this.rejestrDbit2.Name = "rejestrDbit2";
            this.rejestrDbit2.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit2.TabIndex = 77;
            this.rejestrDbit2.UseVisualStyleBackColor = true;
            this.rejestrDbit2.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit3
            // 
            this.rejestrDbit3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit3.AutoSize = true;
            this.rejestrDbit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit3.Location = new System.Drawing.Point(929, 268);
            this.rejestrDbit3.Name = "rejestrDbit3";
            this.rejestrDbit3.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit3.TabIndex = 76;
            this.rejestrDbit3.UseVisualStyleBackColor = true;
            this.rejestrDbit3.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit4
            // 
            this.rejestrDbit4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit4.AutoSize = true;
            this.rejestrDbit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit4.Location = new System.Drawing.Point(908, 268);
            this.rejestrDbit4.Name = "rejestrDbit4";
            this.rejestrDbit4.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit4.TabIndex = 75;
            this.rejestrDbit4.UseVisualStyleBackColor = true;
            this.rejestrDbit4.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit5
            // 
            this.rejestrDbit5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit5.AutoSize = true;
            this.rejestrDbit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit5.Location = new System.Drawing.Point(887, 268);
            this.rejestrDbit5.Name = "rejestrDbit5";
            this.rejestrDbit5.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit5.TabIndex = 74;
            this.rejestrDbit5.UseVisualStyleBackColor = true;
            this.rejestrDbit5.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit6
            // 
            this.rejestrDbit6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit6.AutoSize = true;
            this.rejestrDbit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit6.Location = new System.Drawing.Point(866, 268);
            this.rejestrDbit6.Name = "rejestrDbit6";
            this.rejestrDbit6.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit6.TabIndex = 73;
            this.rejestrDbit6.UseVisualStyleBackColor = true;
            this.rejestrDbit6.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit7
            // 
            this.rejestrDbit7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit7.AutoSize = true;
            this.rejestrDbit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit7.Location = new System.Drawing.Point(845, 268);
            this.rejestrDbit7.Name = "rejestrDbit7";
            this.rejestrDbit7.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit7.TabIndex = 72;
            this.rejestrDbit7.UseVisualStyleBackColor = true;
            this.rejestrDbit7.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit8
            // 
            this.rejestrDbit8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit8.AutoSize = true;
            this.rejestrDbit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit8.Location = new System.Drawing.Point(805, 268);
            this.rejestrDbit8.Name = "rejestrDbit8";
            this.rejestrDbit8.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit8.TabIndex = 71;
            this.rejestrDbit8.UseVisualStyleBackColor = true;
            this.rejestrDbit8.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit9
            // 
            this.rejestrDbit9.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit9.AutoSize = true;
            this.rejestrDbit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit9.Location = new System.Drawing.Point(784, 268);
            this.rejestrDbit9.Name = "rejestrDbit9";
            this.rejestrDbit9.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit9.TabIndex = 70;
            this.rejestrDbit9.UseVisualStyleBackColor = true;
            this.rejestrDbit9.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit10
            // 
            this.rejestrDbit10.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit10.AutoSize = true;
            this.rejestrDbit10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit10.Location = new System.Drawing.Point(763, 268);
            this.rejestrDbit10.Name = "rejestrDbit10";
            this.rejestrDbit10.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit10.TabIndex = 69;
            this.rejestrDbit10.UseVisualStyleBackColor = true;
            this.rejestrDbit10.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit11
            // 
            this.rejestrDbit11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit11.AutoSize = true;
            this.rejestrDbit11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit11.Location = new System.Drawing.Point(742, 268);
            this.rejestrDbit11.Name = "rejestrDbit11";
            this.rejestrDbit11.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit11.TabIndex = 68;
            this.rejestrDbit11.UseVisualStyleBackColor = true;
            this.rejestrDbit11.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit12
            // 
            this.rejestrDbit12.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit12.AutoSize = true;
            this.rejestrDbit12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit12.Location = new System.Drawing.Point(721, 268);
            this.rejestrDbit12.Name = "rejestrDbit12";
            this.rejestrDbit12.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit12.TabIndex = 67;
            this.rejestrDbit12.UseVisualStyleBackColor = true;
            this.rejestrDbit12.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit13
            // 
            this.rejestrDbit13.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit13.AutoSize = true;
            this.rejestrDbit13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit13.Location = new System.Drawing.Point(700, 268);
            this.rejestrDbit13.Name = "rejestrDbit13";
            this.rejestrDbit13.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit13.TabIndex = 66;
            this.rejestrDbit13.UseVisualStyleBackColor = true;
            this.rejestrDbit13.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit14
            // 
            this.rejestrDbit14.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit14.AutoSize = true;
            this.rejestrDbit14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit14.Location = new System.Drawing.Point(679, 268);
            this.rejestrDbit14.Name = "rejestrDbit14";
            this.rejestrDbit14.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit14.TabIndex = 65;
            this.rejestrDbit14.UseVisualStyleBackColor = true;
            this.rejestrDbit14.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // rejestrDbit15
            // 
            this.rejestrDbit15.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrDbit15.AutoSize = true;
            this.rejestrDbit15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrDbit15.Location = new System.Drawing.Point(658, 268);
            this.rejestrDbit15.Name = "rejestrDbit15";
            this.rejestrDbit15.Size = new System.Drawing.Size(6, 6);
            this.rejestrDbit15.TabIndex = 64;
            this.rejestrDbit15.UseVisualStyleBackColor = true;
            this.rejestrDbit15.CheckedChanged += new System.EventHandler(this.rejestrD_CheckedChanged);
            // 
            // labelRejestrCbit0
            // 
            this.labelRejestrCbit0.AutoSize = true;
            this.labelRejestrCbit0.Location = new System.Drawing.Point(980, 154);
            this.labelRejestrCbit0.Name = "labelRejestrCbit0";
            this.labelRejestrCbit0.Size = new System.Drawing.Size(27, 13);
            this.labelRejestrCbit0.TabIndex = 63;
            this.labelRejestrCbit0.Text = "0-bit";
            // 
            // labelCL
            // 
            this.labelCL.AutoSize = true;
            this.labelCL.Location = new System.Drawing.Point(915, 97);
            this.labelCL.Name = "labelCL";
            this.labelCL.Size = new System.Drawing.Size(20, 13);
            this.labelCL.TabIndex = 62;
            this.labelCL.Text = "CL";
            // 
            // labelRejestrCbit15
            // 
            this.labelRejestrCbit15.AutoSize = true;
            this.labelRejestrCbit15.Location = new System.Drawing.Point(655, 154);
            this.labelRejestrCbit15.Name = "labelRejestrCbit15";
            this.labelRejestrCbit15.Size = new System.Drawing.Size(33, 13);
            this.labelRejestrCbit15.TabIndex = 61;
            this.labelRejestrCbit15.Text = "15-bit";
            // 
            // labelCH
            // 
            this.labelCH.AutoSize = true;
            this.labelCH.Location = new System.Drawing.Point(728, 97);
            this.labelCH.Name = "labelCH";
            this.labelCH.Size = new System.Drawing.Size(22, 13);
            this.labelCH.TabIndex = 60;
            this.labelCH.Text = "CH";
            // 
            // labelRejestrC
            // 
            this.labelRejestrC.AutoSize = true;
            this.labelRejestrC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestrC.Location = new System.Drawing.Point(566, 126);
            this.labelRejestrC.Name = "labelRejestrC";
            this.labelRejestrC.Size = new System.Drawing.Size(71, 16);
            this.labelRejestrC.TabIndex = 59;
            this.labelRejestrC.Text = "Rejestr C";
            // 
            // rejestrCbit0
            // 
            this.rejestrCbit0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit0.AutoSize = true;
            this.rejestrCbit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit0.Location = new System.Drawing.Point(992, 126);
            this.rejestrCbit0.Name = "rejestrCbit0";
            this.rejestrCbit0.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit0.TabIndex = 58;
            this.rejestrCbit0.UseVisualStyleBackColor = true;
            this.rejestrCbit0.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit1
            // 
            this.rejestrCbit1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit1.AutoSize = true;
            this.rejestrCbit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit1.Location = new System.Drawing.Point(971, 126);
            this.rejestrCbit1.Name = "rejestrCbit1";
            this.rejestrCbit1.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit1.TabIndex = 57;
            this.rejestrCbit1.UseVisualStyleBackColor = true;
            this.rejestrCbit1.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit2
            // 
            this.rejestrCbit2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit2.AutoSize = true;
            this.rejestrCbit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit2.Location = new System.Drawing.Point(950, 126);
            this.rejestrCbit2.Name = "rejestrCbit2";
            this.rejestrCbit2.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit2.TabIndex = 56;
            this.rejestrCbit2.UseVisualStyleBackColor = true;
            this.rejestrCbit2.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit3
            // 
            this.rejestrCbit3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit3.AutoSize = true;
            this.rejestrCbit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit3.Location = new System.Drawing.Point(929, 126);
            this.rejestrCbit3.Name = "rejestrCbit3";
            this.rejestrCbit3.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit3.TabIndex = 55;
            this.rejestrCbit3.UseVisualStyleBackColor = true;
            this.rejestrCbit3.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit4
            // 
            this.rejestrCbit4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit4.AutoSize = true;
            this.rejestrCbit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit4.Location = new System.Drawing.Point(908, 126);
            this.rejestrCbit4.Name = "rejestrCbit4";
            this.rejestrCbit4.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit4.TabIndex = 54;
            this.rejestrCbit4.UseVisualStyleBackColor = true;
            this.rejestrCbit4.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit5
            // 
            this.rejestrCbit5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit5.AutoSize = true;
            this.rejestrCbit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit5.Location = new System.Drawing.Point(887, 126);
            this.rejestrCbit5.Name = "rejestrCbit5";
            this.rejestrCbit5.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit5.TabIndex = 53;
            this.rejestrCbit5.UseVisualStyleBackColor = true;
            this.rejestrCbit5.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit6
            // 
            this.rejestrCbit6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit6.AutoSize = true;
            this.rejestrCbit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit6.Location = new System.Drawing.Point(866, 126);
            this.rejestrCbit6.Name = "rejestrCbit6";
            this.rejestrCbit6.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit6.TabIndex = 52;
            this.rejestrCbit6.UseVisualStyleBackColor = true;
            this.rejestrCbit6.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit7
            // 
            this.rejestrCbit7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit7.AutoSize = true;
            this.rejestrCbit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit7.Location = new System.Drawing.Point(845, 126);
            this.rejestrCbit7.Name = "rejestrCbit7";
            this.rejestrCbit7.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit7.TabIndex = 51;
            this.rejestrCbit7.UseVisualStyleBackColor = true;
            this.rejestrCbit7.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit8
            // 
            this.rejestrCbit8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit8.AutoSize = true;
            this.rejestrCbit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit8.Location = new System.Drawing.Point(805, 126);
            this.rejestrCbit8.Name = "rejestrCbit8";
            this.rejestrCbit8.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit8.TabIndex = 50;
            this.rejestrCbit8.UseVisualStyleBackColor = true;
            this.rejestrCbit8.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit9
            // 
            this.rejestrCbit9.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit9.AutoSize = true;
            this.rejestrCbit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit9.Location = new System.Drawing.Point(784, 126);
            this.rejestrCbit9.Name = "rejestrCbit9";
            this.rejestrCbit9.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit9.TabIndex = 49;
            this.rejestrCbit9.UseVisualStyleBackColor = true;
            this.rejestrCbit9.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit10
            // 
            this.rejestrCbit10.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit10.AutoSize = true;
            this.rejestrCbit10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit10.Location = new System.Drawing.Point(763, 126);
            this.rejestrCbit10.Name = "rejestrCbit10";
            this.rejestrCbit10.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit10.TabIndex = 48;
            this.rejestrCbit10.UseVisualStyleBackColor = true;
            this.rejestrCbit10.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit11
            // 
            this.rejestrCbit11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit11.AutoSize = true;
            this.rejestrCbit11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit11.Location = new System.Drawing.Point(742, 126);
            this.rejestrCbit11.Name = "rejestrCbit11";
            this.rejestrCbit11.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit11.TabIndex = 47;
            this.rejestrCbit11.UseVisualStyleBackColor = true;
            this.rejestrCbit11.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit12
            // 
            this.rejestrCbit12.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit12.AutoSize = true;
            this.rejestrCbit12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit12.Location = new System.Drawing.Point(721, 126);
            this.rejestrCbit12.Name = "rejestrCbit12";
            this.rejestrCbit12.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit12.TabIndex = 46;
            this.rejestrCbit12.UseVisualStyleBackColor = true;
            this.rejestrCbit12.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit13
            // 
            this.rejestrCbit13.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit13.AutoSize = true;
            this.rejestrCbit13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit13.Location = new System.Drawing.Point(700, 126);
            this.rejestrCbit13.Name = "rejestrCbit13";
            this.rejestrCbit13.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit13.TabIndex = 45;
            this.rejestrCbit13.UseVisualStyleBackColor = true;
            this.rejestrCbit13.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit14
            // 
            this.rejestrCbit14.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit14.AutoSize = true;
            this.rejestrCbit14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit14.Location = new System.Drawing.Point(679, 126);
            this.rejestrCbit14.Name = "rejestrCbit14";
            this.rejestrCbit14.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit14.TabIndex = 44;
            this.rejestrCbit14.UseVisualStyleBackColor = true;
            this.rejestrCbit14.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // rejestrCbit15
            // 
            this.rejestrCbit15.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrCbit15.AutoSize = true;
            this.rejestrCbit15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrCbit15.Location = new System.Drawing.Point(658, 126);
            this.rejestrCbit15.Name = "rejestrCbit15";
            this.rejestrCbit15.Size = new System.Drawing.Size(6, 6);
            this.rejestrCbit15.TabIndex = 43;
            this.rejestrCbit15.UseVisualStyleBackColor = true;
            this.rejestrCbit15.CheckedChanged += new System.EventHandler(this.rejestrC_CheckedChanged);
            // 
            // ramkaRejestrA
            // 
            this.ramkaRejestrA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramkaRejestrA.Location = new System.Drawing.Point(31, 76);
            this.ramkaRejestrA.Name = "ramkaRejestrA";
            this.ramkaRejestrA.Size = new System.Drawing.Size(493, 126);
            this.ramkaRejestrA.TabIndex = 90;
            // 
            // ramkaRejestrC
            // 
            this.ramkaRejestrC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramkaRejestrC.Location = new System.Drawing.Point(551, 76);
            this.ramkaRejestrC.Name = "ramkaRejestrC";
            this.ramkaRejestrC.Size = new System.Drawing.Size(493, 126);
            this.ramkaRejestrC.TabIndex = 91;
            // 
            // ramkaRejestrB
            // 
            this.ramkaRejestrB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramkaRejestrB.Location = new System.Drawing.Point(31, 227);
            this.ramkaRejestrB.Name = "ramkaRejestrB";
            this.ramkaRejestrB.Size = new System.Drawing.Size(493, 126);
            this.ramkaRejestrB.TabIndex = 92;
            // 
            // ramkaRejestrD
            // 
            this.ramkaRejestrD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramkaRejestrD.Location = new System.Drawing.Point(551, 227);
            this.ramkaRejestrD.Name = "ramkaRejestrD";
            this.ramkaRejestrD.Size = new System.Drawing.Size(493, 126);
            this.ramkaRejestrD.TabIndex = 93;
            // 
            // napisRejestry
            // 
            this.napisRejestry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.napisRejestry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napisRejestry.Location = new System.Drawing.Point(31, 19);
            this.napisRejestry.Name = "napisRejestry";
            this.napisRejestry.Size = new System.Drawing.Size(1013, 47);
            this.napisRejestry.TabIndex = 94;
            this.napisRejestry.Text = "Rejestry";
            this.napisRejestry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // napisKod
            // 
            this.napisKod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.napisKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napisKod.Location = new System.Drawing.Point(551, 419);
            this.napisKod.Name = "napisKod";
            this.napisKod.Size = new System.Drawing.Size(493, 46);
            this.napisKod.TabIndex = 95;
            this.napisKod.Text = "Kod";
            this.napisKod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboRejestr1
            // 
            this.comboRejestr1.FormattingEnabled = true;
            this.comboRejestr1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboRejestr1.Location = new System.Drawing.Point(797, 488);
            this.comboRejestr1.Name = "comboRejestr1";
            this.comboRejestr1.Size = new System.Drawing.Size(48, 21);
            this.comboRejestr1.TabIndex = 96;
            // 
            // napisStrzalka
            // 
            this.napisStrzalka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napisStrzalka.Location = new System.Drawing.Point(851, 488);
            this.napisStrzalka.Name = "napisStrzalka";
            this.napisStrzalka.Size = new System.Drawing.Size(35, 25);
            this.napisStrzalka.TabIndex = 97;
            this.napisStrzalka.Text = "=>";
            // 
            // comboRejestr2
            // 
            this.comboRejestr2.FormattingEnabled = true;
            this.comboRejestr2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "IN"});
            this.comboRejestr2.Location = new System.Drawing.Point(881, 488);
            this.comboRejestr2.Name = "comboRejestr2";
            this.comboRejestr2.Size = new System.Drawing.Size(48, 21);
            this.comboRejestr2.TabIndex = 98;
            // 
            // comboMnemotechnik
            // 
            this.comboMnemotechnik.FormattingEnabled = true;
            this.comboMnemotechnik.Items.AddRange(new object[] {
            "MOV",
            "ADD",
            "SUB"});
            this.comboMnemotechnik.Location = new System.Drawing.Point(673, 488);
            this.comboMnemotechnik.Name = "comboMnemotechnik";
            this.comboMnemotechnik.Size = new System.Drawing.Size(88, 21);
            this.comboMnemotechnik.TabIndex = 99;
            // 
            // napisAdresowanie
            // 
            this.napisAdresowanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.napisAdresowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napisAdresowanie.Location = new System.Drawing.Point(31, 419);
            this.napisAdresowanie.Name = "napisAdresowanie";
            this.napisAdresowanie.Size = new System.Drawing.Size(493, 46);
            this.napisAdresowanie.TabIndex = 100;
            this.napisAdresowanie.Text = "Adresowanie Natychmiastowe";
            this.napisAdresowanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "0-bit";
            // 
            // labelINL
            // 
            this.labelINL.AutoSize = true;
            this.labelINL.Location = new System.Drawing.Point(389, 496);
            this.labelINL.Name = "labelINL";
            this.labelINL.Size = new System.Drawing.Size(21, 13);
            this.labelINL.TabIndex = 120;
            this.labelINL.Text = "inL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 119;
            this.label4.Text = "15-bit";
            // 
            // labelINH
            // 
            this.labelINH.AutoSize = true;
            this.labelINH.Location = new System.Drawing.Point(202, 496);
            this.labelINH.Name = "labelINH";
            this.labelINH.Size = new System.Drawing.Size(23, 13);
            this.labelINH.TabIndex = 118;
            this.labelINH.Text = "inH";
            // 
            // labelRejestrIN
            // 
            this.labelRejestrIN.AutoSize = true;
            this.labelRejestrIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestrIN.Location = new System.Drawing.Point(40, 525);
            this.labelRejestrIN.Name = "labelRejestrIN";
            this.labelRejestrIN.Size = new System.Drawing.Size(71, 15);
            this.labelRejestrIN.TabIndex = 117;
            this.labelRejestrIN.Text = "Rejestr IN";
            // 
            // rejestrIbit0
            // 
            this.rejestrIbit0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit0.AutoSize = true;
            this.rejestrIbit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit0.Location = new System.Drawing.Point(466, 525);
            this.rejestrIbit0.Name = "rejestrIbit0";
            this.rejestrIbit0.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit0.TabIndex = 116;
            this.rejestrIbit0.UseVisualStyleBackColor = true;
            this.rejestrIbit0.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit1
            // 
            this.rejestrIbit1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit1.AutoSize = true;
            this.rejestrIbit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit1.Location = new System.Drawing.Point(445, 525);
            this.rejestrIbit1.Name = "rejestrIbit1";
            this.rejestrIbit1.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit1.TabIndex = 115;
            this.rejestrIbit1.UseVisualStyleBackColor = true;
            this.rejestrIbit1.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit2
            // 
            this.rejestrIbit2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit2.AutoSize = true;
            this.rejestrIbit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit2.Location = new System.Drawing.Point(424, 525);
            this.rejestrIbit2.Name = "rejestrIbit2";
            this.rejestrIbit2.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit2.TabIndex = 114;
            this.rejestrIbit2.UseVisualStyleBackColor = true;
            this.rejestrIbit2.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit3
            // 
            this.rejestrIbit3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit3.AutoSize = true;
            this.rejestrIbit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit3.Location = new System.Drawing.Point(403, 525);
            this.rejestrIbit3.Name = "rejestrIbit3";
            this.rejestrIbit3.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit3.TabIndex = 113;
            this.rejestrIbit3.UseVisualStyleBackColor = true;
            this.rejestrIbit3.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit4
            // 
            this.rejestrIbit4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit4.AutoSize = true;
            this.rejestrIbit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit4.Location = new System.Drawing.Point(382, 525);
            this.rejestrIbit4.Name = "rejestrIbit4";
            this.rejestrIbit4.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit4.TabIndex = 112;
            this.rejestrIbit4.UseVisualStyleBackColor = true;
            this.rejestrIbit4.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit5
            // 
            this.rejestrIbit5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit5.AutoSize = true;
            this.rejestrIbit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit5.Location = new System.Drawing.Point(361, 525);
            this.rejestrIbit5.Name = "rejestrIbit5";
            this.rejestrIbit5.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit5.TabIndex = 111;
            this.rejestrIbit5.UseVisualStyleBackColor = true;
            this.rejestrIbit5.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit6
            // 
            this.rejestrIbit6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit6.AutoSize = true;
            this.rejestrIbit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit6.Location = new System.Drawing.Point(340, 525);
            this.rejestrIbit6.Name = "rejestrIbit6";
            this.rejestrIbit6.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit6.TabIndex = 110;
            this.rejestrIbit6.UseVisualStyleBackColor = true;
            this.rejestrIbit6.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit7
            // 
            this.rejestrIbit7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit7.AutoSize = true;
            this.rejestrIbit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit7.Location = new System.Drawing.Point(319, 525);
            this.rejestrIbit7.Name = "rejestrIbit7";
            this.rejestrIbit7.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit7.TabIndex = 109;
            this.rejestrIbit7.UseVisualStyleBackColor = true;
            this.rejestrIbit7.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit8
            // 
            this.rejestrIbit8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit8.AutoSize = true;
            this.rejestrIbit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit8.Location = new System.Drawing.Point(279, 525);
            this.rejestrIbit8.Name = "rejestrIbit8";
            this.rejestrIbit8.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit8.TabIndex = 108;
            this.rejestrIbit8.UseVisualStyleBackColor = true;
            this.rejestrIbit8.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit9
            // 
            this.rejestrIbit9.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit9.AutoSize = true;
            this.rejestrIbit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit9.Location = new System.Drawing.Point(258, 525);
            this.rejestrIbit9.Name = "rejestrIbit9";
            this.rejestrIbit9.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit9.TabIndex = 107;
            this.rejestrIbit9.UseVisualStyleBackColor = true;
            this.rejestrIbit9.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit10
            // 
            this.rejestrIbit10.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit10.AutoSize = true;
            this.rejestrIbit10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit10.Location = new System.Drawing.Point(237, 525);
            this.rejestrIbit10.Name = "rejestrIbit10";
            this.rejestrIbit10.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit10.TabIndex = 106;
            this.rejestrIbit10.UseVisualStyleBackColor = true;
            this.rejestrIbit10.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit11
            // 
            this.rejestrIbit11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit11.AutoSize = true;
            this.rejestrIbit11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit11.Location = new System.Drawing.Point(216, 525);
            this.rejestrIbit11.Name = "rejestrIbit11";
            this.rejestrIbit11.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit11.TabIndex = 105;
            this.rejestrIbit11.UseVisualStyleBackColor = true;
            this.rejestrIbit11.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit12
            // 
            this.rejestrIbit12.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit12.AutoSize = true;
            this.rejestrIbit12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit12.Location = new System.Drawing.Point(195, 525);
            this.rejestrIbit12.Name = "rejestrIbit12";
            this.rejestrIbit12.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit12.TabIndex = 104;
            this.rejestrIbit12.UseVisualStyleBackColor = true;
            this.rejestrIbit12.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit13
            // 
            this.rejestrIbit13.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit13.AutoSize = true;
            this.rejestrIbit13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit13.Location = new System.Drawing.Point(174, 525);
            this.rejestrIbit13.Name = "rejestrIbit13";
            this.rejestrIbit13.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit13.TabIndex = 103;
            this.rejestrIbit13.UseVisualStyleBackColor = true;
            this.rejestrIbit13.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit14
            // 
            this.rejestrIbit14.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit14.AutoSize = true;
            this.rejestrIbit14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit14.Location = new System.Drawing.Point(153, 525);
            this.rejestrIbit14.Name = "rejestrIbit14";
            this.rejestrIbit14.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit14.TabIndex = 102;
            this.rejestrIbit14.UseVisualStyleBackColor = true;
            this.rejestrIbit14.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // rejestrIbit15
            // 
            this.rejestrIbit15.Appearance = System.Windows.Forms.Appearance.Button;
            this.rejestrIbit15.AutoSize = true;
            this.rejestrIbit15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rejestrIbit15.Location = new System.Drawing.Point(132, 525);
            this.rejestrIbit15.Name = "rejestrIbit15";
            this.rejestrIbit15.Size = new System.Drawing.Size(6, 6);
            this.rejestrIbit15.TabIndex = 101;
            this.rejestrIbit15.UseVisualStyleBackColor = true;
            this.rejestrIbit15.CheckedChanged += new System.EventHandler(this.rejestrIN_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(31, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(493, 126);
            this.label7.TabIndex = 123;
            // 
            // labelWartoscRejestruIN
            // 
            this.labelWartoscRejestruIN.AutoSize = true;
            this.labelWartoscRejestruIN.Location = new System.Drawing.Point(180, 571);
            this.labelWartoscRejestruIN.Name = "labelWartoscRejestruIN";
            this.labelWartoscRejestruIN.Size = new System.Drawing.Size(250, 13);
            this.labelWartoscRejestruIN.TabIndex = 122;
            this.labelWartoscRejestruIN.Text = "Bin: 0000000000000000   Dec: 00000   Hex: 0000 ";
            // 
            // labelWartoscRejestruB
            // 
            this.labelWartoscRejestruB.AutoSize = true;
            this.labelWartoscRejestruB.Location = new System.Drawing.Point(180, 319);
            this.labelWartoscRejestruB.Name = "labelWartoscRejestruB";
            this.labelWartoscRejestruB.Size = new System.Drawing.Size(250, 13);
            this.labelWartoscRejestruB.TabIndex = 87;
            this.labelWartoscRejestruB.Text = "Bin: 0000000000000000   Dec: 00000   Hex: 0000 ";
            // 
            // labelWartoscRejestruD
            // 
            this.labelWartoscRejestruD.AutoSize = true;
            this.labelWartoscRejestruD.Location = new System.Drawing.Point(706, 319);
            this.labelWartoscRejestruD.Name = "labelWartoscRejestruD";
            this.labelWartoscRejestruD.Size = new System.Drawing.Size(250, 13);
            this.labelWartoscRejestruD.TabIndex = 88;
            this.labelWartoscRejestruD.Text = "Bin: 0000000000000000   Dec: 00000   Hex: 0000 ";
            // 
            // labelWartoscRejestruC
            // 
            this.labelWartoscRejestruC.AutoSize = true;
            this.labelWartoscRejestruC.Location = new System.Drawing.Point(706, 172);
            this.labelWartoscRejestruC.Name = "labelWartoscRejestruC";
            this.labelWartoscRejestruC.Size = new System.Drawing.Size(250, 13);
            this.labelWartoscRejestruC.TabIndex = 86;
            this.labelWartoscRejestruC.Text = "Bin: 0000000000000000   Dec: 00000   Hex: 0000 ";
            // 
            // labelWartoscRejestruA
            // 
            this.labelWartoscRejestruA.AutoSize = true;
            this.labelWartoscRejestruA.Location = new System.Drawing.Point(180, 172);
            this.labelWartoscRejestruA.Name = "labelWartoscRejestruA";
            this.labelWartoscRejestruA.Size = new System.Drawing.Size(250, 13);
            this.labelWartoscRejestruA.TabIndex = 85;
            this.labelWartoscRejestruA.Text = "Bin: 0000000000000000   Dec: 00000   Hex: 0000 ";
            // 
            // napisProgram
            // 
            this.napisProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.napisProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napisProgram.Location = new System.Drawing.Point(1125, 19);
            this.napisProgram.Name = "napisProgram";
            this.napisProgram.Size = new System.Drawing.Size(436, 47);
            this.napisProgram.TabIndex = 124;
            this.napisProgram.Text = "Program";
            this.napisProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1krokProgramu
            // 
            this.label1krokProgramu.AutoSize = true;
            this.label1krokProgramu.Location = new System.Drawing.Point(1146, 97);
            this.label1krokProgramu.Name = "label1krokProgramu";
            this.label1krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label1krokProgramu.TabIndex = 125;
            this.label1krokProgramu.Text = "1.    ";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(1125, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 525);
            this.label3.TabIndex = 126;
            // 
            // label2krokProgramu
            // 
            this.label2krokProgramu.AutoSize = true;
            this.label2krokProgramu.Location = new System.Drawing.Point(1146, 119);
            this.label2krokProgramu.Name = "label2krokProgramu";
            this.label2krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label2krokProgramu.TabIndex = 127;
            this.label2krokProgramu.Text = "2.    ";
            // 
            // label3krokProgramu
            // 
            this.label3krokProgramu.AutoSize = true;
            this.label3krokProgramu.Location = new System.Drawing.Point(1146, 141);
            this.label3krokProgramu.Name = "label3krokProgramu";
            this.label3krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label3krokProgramu.TabIndex = 128;
            this.label3krokProgramu.Text = "3.    ";
            // 
            // label4krokProgramu
            // 
            this.label4krokProgramu.AutoSize = true;
            this.label4krokProgramu.Location = new System.Drawing.Point(1146, 163);
            this.label4krokProgramu.Name = "label4krokProgramu";
            this.label4krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label4krokProgramu.TabIndex = 129;
            this.label4krokProgramu.Text = "4.    ";
            // 
            // label5krokProgramu
            // 
            this.label5krokProgramu.AutoSize = true;
            this.label5krokProgramu.Location = new System.Drawing.Point(1146, 185);
            this.label5krokProgramu.Name = "label5krokProgramu";
            this.label5krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label5krokProgramu.TabIndex = 130;
            this.label5krokProgramu.Text = "5.    ";
            // 
            // label6krokProgramu
            // 
            this.label6krokProgramu.AutoSize = true;
            this.label6krokProgramu.Location = new System.Drawing.Point(1146, 207);
            this.label6krokProgramu.Name = "label6krokProgramu";
            this.label6krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label6krokProgramu.TabIndex = 131;
            this.label6krokProgramu.Text = "6.    ";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(551, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 126);
            this.label1.TabIndex = 132;
            // 
            // buttonDodajDoProgramu
            // 
            this.buttonDodajDoProgramu.Location = new System.Drawing.Point(841, 543);
            this.buttonDodajDoProgramu.Name = "buttonDodajDoProgramu";
            this.buttonDodajDoProgramu.Size = new System.Drawing.Size(157, 41);
            this.buttonDodajDoProgramu.TabIndex = 134;
            this.buttonDodajDoProgramu.Text = "Dodaj do programu";
            this.buttonDodajDoProgramu.UseVisualStyleBackColor = true;
            this.buttonDodajDoProgramu.Click += new System.EventHandler(this.buttonDodajDoProgramu_Click);
            // 
            // buttonWykonajRozkaz
            // 
            this.buttonWykonajRozkaz.Location = new System.Drawing.Point(604, 543);
            this.buttonWykonajRozkaz.Name = "buttonWykonajRozkaz";
            this.buttonWykonajRozkaz.Size = new System.Drawing.Size(157, 41);
            this.buttonWykonajRozkaz.TabIndex = 133;
            this.buttonWykonajRozkaz.Text = "Wykonaj Rozkaz";
            this.buttonWykonajRozkaz.UseVisualStyleBackColor = true;
            this.buttonWykonajRozkaz.Click += new System.EventHandler(this.buttonWykonajRozkaz_Click);
            // 
            // buttonZapiszProgram
            // 
            this.buttonZapiszProgram.Location = new System.Drawing.Point(1149, 522);
            this.buttonZapiszProgram.Name = "buttonZapiszProgram";
            this.buttonZapiszProgram.Size = new System.Drawing.Size(182, 62);
            this.buttonZapiszProgram.TabIndex = 135;
            this.buttonZapiszProgram.Text = "Zapisz Program";
            this.buttonZapiszProgram.UseVisualStyleBackColor = true;
            this.buttonZapiszProgram.Click += new System.EventHandler(this.buttonZapiszProgram_Click);
            // 
            // buttonWczytajProgram
            // 
            this.buttonWczytajProgram.Location = new System.Drawing.Point(1355, 522);
            this.buttonWczytajProgram.Name = "buttonWczytajProgram";
            this.buttonWczytajProgram.Size = new System.Drawing.Size(182, 62);
            this.buttonWczytajProgram.TabIndex = 136;
            this.buttonWczytajProgram.Text = "Wczytaj Program";
            this.buttonWczytajProgram.UseVisualStyleBackColor = true;
            this.buttonWczytajProgram.Click += new System.EventHandler(this.buttonWczytajProgram_Click);
            // 
            // buttonWykonajKrok
            // 
            this.buttonWykonajKrok.Location = new System.Drawing.Point(1149, 447);
            this.buttonWykonajKrok.Name = "buttonWykonajKrok";
            this.buttonWykonajKrok.Size = new System.Drawing.Size(182, 62);
            this.buttonWykonajKrok.TabIndex = 137;
            this.buttonWykonajKrok.Text = "Wykonaj Krok";
            this.buttonWykonajKrok.UseVisualStyleBackColor = true;
            this.buttonWykonajKrok.Click += new System.EventHandler(this.buttonWykonajKrok_Click);
            // 
            // buttonWykonajProgram
            // 
            this.buttonWykonajProgram.Location = new System.Drawing.Point(1355, 447);
            this.buttonWykonajProgram.Name = "buttonWykonajProgram";
            this.buttonWykonajProgram.Size = new System.Drawing.Size(182, 62);
            this.buttonWykonajProgram.TabIndex = 138;
            this.buttonWykonajProgram.Text = "Wykonaj Program";
            this.buttonWykonajProgram.UseVisualStyleBackColor = true;
            this.buttonWykonajProgram.Click += new System.EventHandler(this.buttonWykonajProgram_Click);
            // 
            // label7krokProgramu
            // 
            this.label7krokProgramu.AutoSize = true;
            this.label7krokProgramu.Location = new System.Drawing.Point(1146, 227);
            this.label7krokProgramu.Name = "label7krokProgramu";
            this.label7krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label7krokProgramu.TabIndex = 139;
            this.label7krokProgramu.Text = "7.    ";
            // 
            // label8krokProgramu
            // 
            this.label8krokProgramu.AutoSize = true;
            this.label8krokProgramu.Location = new System.Drawing.Point(1146, 249);
            this.label8krokProgramu.Name = "label8krokProgramu";
            this.label8krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label8krokProgramu.TabIndex = 140;
            this.label8krokProgramu.Text = "8.    ";
            // 
            // label9krokProgramu
            // 
            this.label9krokProgramu.AutoSize = true;
            this.label9krokProgramu.Location = new System.Drawing.Point(1146, 271);
            this.label9krokProgramu.Name = "label9krokProgramu";
            this.label9krokProgramu.Size = new System.Drawing.Size(28, 13);
            this.label9krokProgramu.TabIndex = 141;
            this.label9krokProgramu.Text = "9.    ";
            // 
            // label10krokProgramu
            // 
            this.label10krokProgramu.AutoSize = true;
            this.label10krokProgramu.Location = new System.Drawing.Point(1146, 296);
            this.label10krokProgramu.Name = "label10krokProgramu";
            this.label10krokProgramu.Size = new System.Drawing.Size(34, 13);
            this.label10krokProgramu.TabIndex = 142;
            this.label10krokProgramu.Text = "10.    ";
            // 
            // label11krokProgramu
            // 
            this.label11krokProgramu.AutoSize = true;
            this.label11krokProgramu.Location = new System.Drawing.Point(1146, 319);
            this.label11krokProgramu.Name = "label11krokProgramu";
            this.label11krokProgramu.Size = new System.Drawing.Size(34, 13);
            this.label11krokProgramu.TabIndex = 143;
            this.label11krokProgramu.Text = "11.    ";
            // 
            // label12krokProgramu
            // 
            this.label12krokProgramu.AutoSize = true;
            this.label12krokProgramu.Location = new System.Drawing.Point(1146, 340);
            this.label12krokProgramu.Name = "label12krokProgramu";
            this.label12krokProgramu.Size = new System.Drawing.Size(34, 13);
            this.label12krokProgramu.TabIndex = 144;
            this.label12krokProgramu.Text = "12.    ";
            // 
            // label13krokProgramu
            // 
            this.label13krokProgramu.AutoSize = true;
            this.label13krokProgramu.Location = new System.Drawing.Point(1146, 364);
            this.label13krokProgramu.Name = "label13krokProgramu";
            this.label13krokProgramu.Size = new System.Drawing.Size(34, 13);
            this.label13krokProgramu.TabIndex = 145;
            this.label13krokProgramu.Text = "13.    ";
            // 
            // label14krokProgramu
            // 
            this.label14krokProgramu.AutoSize = true;
            this.label14krokProgramu.Location = new System.Drawing.Point(1146, 388);
            this.label14krokProgramu.Name = "label14krokProgramu";
            this.label14krokProgramu.Size = new System.Drawing.Size(34, 13);
            this.label14krokProgramu.TabIndex = 146;
            this.label14krokProgramu.Text = "14.    ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 630);
            this.Controls.Add(this.label14krokProgramu);
            this.Controls.Add(this.label13krokProgramu);
            this.Controls.Add(this.label12krokProgramu);
            this.Controls.Add(this.label11krokProgramu);
            this.Controls.Add(this.label10krokProgramu);
            this.Controls.Add(this.label9krokProgramu);
            this.Controls.Add(this.label8krokProgramu);
            this.Controls.Add(this.label7krokProgramu);
            this.Controls.Add(this.buttonWykonajProgram);
            this.Controls.Add(this.buttonWykonajKrok);
            this.Controls.Add(this.buttonWczytajProgram);
            this.Controls.Add(this.buttonZapiszProgram);
            this.Controls.Add(this.buttonDodajDoProgramu);
            this.Controls.Add(this.buttonWykonajRozkaz);
            this.Controls.Add(this.label6krokProgramu);
            this.Controls.Add(this.label5krokProgramu);
            this.Controls.Add(this.label4krokProgramu);
            this.Controls.Add(this.label3krokProgramu);
            this.Controls.Add(this.label2krokProgramu);
            this.Controls.Add(this.label1krokProgramu);
            this.Controls.Add(this.napisProgram);
            this.Controls.Add(this.labelWartoscRejestruIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelINL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelINH);
            this.Controls.Add(this.labelRejestrIN);
            this.Controls.Add(this.rejestrIbit0);
            this.Controls.Add(this.rejestrIbit1);
            this.Controls.Add(this.rejestrIbit2);
            this.Controls.Add(this.rejestrIbit3);
            this.Controls.Add(this.rejestrIbit4);
            this.Controls.Add(this.rejestrIbit5);
            this.Controls.Add(this.rejestrIbit6);
            this.Controls.Add(this.rejestrIbit7);
            this.Controls.Add(this.rejestrIbit8);
            this.Controls.Add(this.rejestrIbit9);
            this.Controls.Add(this.rejestrIbit10);
            this.Controls.Add(this.rejestrIbit11);
            this.Controls.Add(this.rejestrIbit12);
            this.Controls.Add(this.rejestrIbit13);
            this.Controls.Add(this.rejestrIbit14);
            this.Controls.Add(this.rejestrIbit15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.napisAdresowanie);
            this.Controls.Add(this.comboMnemotechnik);
            this.Controls.Add(this.comboRejestr2);
            this.Controls.Add(this.napisStrzalka);
            this.Controls.Add(this.comboRejestr1);
            this.Controls.Add(this.napisKod);
            this.Controls.Add(this.napisRejestry);
            this.Controls.Add(this.labelWartoscRejestruD);
            this.Controls.Add(this.labelWartoscRejestruB);
            this.Controls.Add(this.labelWartoscRejestruC);
            this.Controls.Add(this.labelWartoscRejestruA);
            this.Controls.Add(this.rejestrDbit0);
            this.Controls.Add(this.labelRejestrDbit0);
            this.Controls.Add(this.labelDL);
            this.Controls.Add(this.labelRejestrDbit15);
            this.Controls.Add(this.labelDH);
            this.Controls.Add(this.labelRejestrD);
            this.Controls.Add(this.rejestrDbit1);
            this.Controls.Add(this.rejestrDbit2);
            this.Controls.Add(this.rejestrDbit3);
            this.Controls.Add(this.rejestrDbit4);
            this.Controls.Add(this.rejestrDbit5);
            this.Controls.Add(this.rejestrDbit6);
            this.Controls.Add(this.rejestrDbit7);
            this.Controls.Add(this.rejestrDbit8);
            this.Controls.Add(this.rejestrDbit9);
            this.Controls.Add(this.rejestrDbit10);
            this.Controls.Add(this.rejestrDbit11);
            this.Controls.Add(this.rejestrDbit12);
            this.Controls.Add(this.rejestrDbit13);
            this.Controls.Add(this.rejestrDbit14);
            this.Controls.Add(this.rejestrDbit15);
            this.Controls.Add(this.labelRejestrCbit0);
            this.Controls.Add(this.labelCL);
            this.Controls.Add(this.labelRejestrCbit15);
            this.Controls.Add(this.labelCH);
            this.Controls.Add(this.labelRejestrC);
            this.Controls.Add(this.rejestrCbit0);
            this.Controls.Add(this.rejestrCbit1);
            this.Controls.Add(this.rejestrCbit2);
            this.Controls.Add(this.rejestrCbit3);
            this.Controls.Add(this.rejestrCbit4);
            this.Controls.Add(this.rejestrCbit5);
            this.Controls.Add(this.rejestrCbit6);
            this.Controls.Add(this.rejestrCbit7);
            this.Controls.Add(this.rejestrCbit8);
            this.Controls.Add(this.rejestrCbit9);
            this.Controls.Add(this.rejestrCbit10);
            this.Controls.Add(this.rejestrCbit11);
            this.Controls.Add(this.rejestrCbit12);
            this.Controls.Add(this.rejestrCbit13);
            this.Controls.Add(this.rejestrCbit14);
            this.Controls.Add(this.rejestrCbit15);
            this.Controls.Add(this.rejestrBbit0);
            this.Controls.Add(this.labelRejestrBbit0);
            this.Controls.Add(this.labelBL);
            this.Controls.Add(this.labelRejestrBbit15);
            this.Controls.Add(this.labelBH);
            this.Controls.Add(this.labelRejestrB);
            this.Controls.Add(this.rejestrBbit1);
            this.Controls.Add(this.rejestrBbit2);
            this.Controls.Add(this.rejestrBbit3);
            this.Controls.Add(this.rejestrBbit4);
            this.Controls.Add(this.rejestrBbit5);
            this.Controls.Add(this.rejestrBbit6);
            this.Controls.Add(this.rejestrBbit7);
            this.Controls.Add(this.rejestrBbit8);
            this.Controls.Add(this.rejestrBbit9);
            this.Controls.Add(this.rejestrBbit10);
            this.Controls.Add(this.rejestrBbit11);
            this.Controls.Add(this.rejestrBbit12);
            this.Controls.Add(this.rejestrBbit13);
            this.Controls.Add(this.rejestrBbit14);
            this.Controls.Add(this.rejestrBbit15);
            this.Controls.Add(this.labelRejestrAbit0);
            this.Controls.Add(this.labelAL);
            this.Controls.Add(this.labelRejestrAbit15);
            this.Controls.Add(this.labelAH);
            this.Controls.Add(this.labelRejestrA);
            this.Controls.Add(this.rejestrAbit0);
            this.Controls.Add(this.rejestrAbit1);
            this.Controls.Add(this.rejestrAbit2);
            this.Controls.Add(this.rejestrAbit3);
            this.Controls.Add(this.rejestrAbit4);
            this.Controls.Add(this.rejestrAbit5);
            this.Controls.Add(this.rejestrAbit6);
            this.Controls.Add(this.rejestrAbit7);
            this.Controls.Add(this.rejestrAbit8);
            this.Controls.Add(this.rejestrAbit9);
            this.Controls.Add(this.rejestrAbit10);
            this.Controls.Add(this.rejestrAbit11);
            this.Controls.Add(this.rejestrAbit12);
            this.Controls.Add(this.rejestrAbit13);
            this.Controls.Add(this.rejestrAbit14);
            this.Controls.Add(this.rejestrAbit15);
            this.Controls.Add(this.ramkaRejestrA);
            this.Controls.Add(this.ramkaRejestrC);
            this.Controls.Add(this.ramkaRejestrB);
            this.Controls.Add(this.ramkaRejestrD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox rejestrAbit15;
        private System.Windows.Forms.CheckBox rejestrAbit14;
        private System.Windows.Forms.CheckBox rejestrAbit13;
        private System.Windows.Forms.CheckBox rejestrAbit12;
        private System.Windows.Forms.CheckBox rejestrAbit11;
        private System.Windows.Forms.CheckBox rejestrAbit10;
        private System.Windows.Forms.CheckBox rejestrAbit9;
        private System.Windows.Forms.CheckBox rejestrAbit8;
        private System.Windows.Forms.CheckBox rejestrAbit7;
        private System.Windows.Forms.CheckBox rejestrAbit6;
        private System.Windows.Forms.CheckBox rejestrAbit5;
        private System.Windows.Forms.CheckBox rejestrAbit4;
        private System.Windows.Forms.CheckBox rejestrAbit3;
        private System.Windows.Forms.CheckBox rejestrAbit2;
        private System.Windows.Forms.CheckBox rejestrAbit1;
        private System.Windows.Forms.CheckBox rejestrAbit0;
        private System.Windows.Forms.Label labelRejestrA;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.Label labelRejestrAbit15;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelRejestrAbit0;
        private System.Windows.Forms.Label labelRejestrBbit0;
        private System.Windows.Forms.Label labelBL;
        private System.Windows.Forms.Label labelRejestrBbit15;
        private System.Windows.Forms.Label labelBH;
        private System.Windows.Forms.Label labelRejestrB;
        private System.Windows.Forms.CheckBox rejestrBbit1;
        private System.Windows.Forms.CheckBox rejestrBbit2;
        private System.Windows.Forms.CheckBox rejestrBbit3;
        private System.Windows.Forms.CheckBox rejestrBbit4;
        private System.Windows.Forms.CheckBox rejestrBbit5;
        private System.Windows.Forms.CheckBox rejestrBbit6;
        private System.Windows.Forms.CheckBox rejestrBbit7;
        private System.Windows.Forms.CheckBox rejestrBbit8;
        private System.Windows.Forms.CheckBox rejestrBbit9;
        private System.Windows.Forms.CheckBox rejestrBbit10;
        private System.Windows.Forms.CheckBox rejestrBbit11;
        private System.Windows.Forms.CheckBox rejestrBbit12;
        private System.Windows.Forms.CheckBox rejestrBbit13;
        private System.Windows.Forms.CheckBox rejestrBbit14;
        private System.Windows.Forms.CheckBox rejestrBbit15;
        private System.Windows.Forms.CheckBox rejestrBbit0;
        private System.Windows.Forms.CheckBox rejestrDbit0;
        private System.Windows.Forms.Label labelRejestrDbit0;
        private System.Windows.Forms.Label labelDL;
        private System.Windows.Forms.Label labelRejestrDbit15;
        private System.Windows.Forms.Label labelDH;
        private System.Windows.Forms.Label labelRejestrD;
        private System.Windows.Forms.CheckBox rejestrDbit1;
        private System.Windows.Forms.CheckBox rejestrDbit2;
        private System.Windows.Forms.CheckBox rejestrDbit3;
        private System.Windows.Forms.CheckBox rejestrDbit4;
        private System.Windows.Forms.CheckBox rejestrDbit5;
        private System.Windows.Forms.CheckBox rejestrDbit6;
        private System.Windows.Forms.CheckBox rejestrDbit7;
        private System.Windows.Forms.CheckBox rejestrDbit8;
        private System.Windows.Forms.CheckBox rejestrDbit9;
        private System.Windows.Forms.CheckBox rejestrDbit10;
        private System.Windows.Forms.CheckBox rejestrDbit11;
        private System.Windows.Forms.CheckBox rejestrDbit12;
        private System.Windows.Forms.CheckBox rejestrDbit13;
        private System.Windows.Forms.CheckBox rejestrDbit14;
        private System.Windows.Forms.CheckBox rejestrDbit15;
        private System.Windows.Forms.Label labelRejestrCbit0;
        private System.Windows.Forms.Label labelCL;
        private System.Windows.Forms.Label labelRejestrCbit15;
        private System.Windows.Forms.Label labelCH;
        private System.Windows.Forms.Label labelRejestrC;
        private System.Windows.Forms.CheckBox rejestrCbit0;
        private System.Windows.Forms.CheckBox rejestrCbit1;
        private System.Windows.Forms.CheckBox rejestrCbit2;
        private System.Windows.Forms.CheckBox rejestrCbit3;
        private System.Windows.Forms.CheckBox rejestrCbit4;
        private System.Windows.Forms.CheckBox rejestrCbit5;
        private System.Windows.Forms.CheckBox rejestrCbit6;
        private System.Windows.Forms.CheckBox rejestrCbit7;
        private System.Windows.Forms.CheckBox rejestrCbit8;
        private System.Windows.Forms.CheckBox rejestrCbit9;
        private System.Windows.Forms.CheckBox rejestrCbit10;
        private System.Windows.Forms.CheckBox rejestrCbit11;
        private System.Windows.Forms.CheckBox rejestrCbit12;
        private System.Windows.Forms.CheckBox rejestrCbit13;
        private System.Windows.Forms.CheckBox rejestrCbit14;
        private System.Windows.Forms.CheckBox rejestrCbit15;
        private System.Windows.Forms.Label ramkaRejestrA;
        private System.Windows.Forms.Label ramkaRejestrC;
        private System.Windows.Forms.Label ramkaRejestrB;
        private System.Windows.Forms.Label ramkaRejestrD;
        private System.Windows.Forms.Label napisRejestry;
        private System.Windows.Forms.Label napisKod;
        private System.Windows.Forms.ComboBox comboRejestr1;
        private System.Windows.Forms.Label napisStrzalka;
        private System.Windows.Forms.ComboBox comboRejestr2;
        private System.Windows.Forms.ComboBox comboMnemotechnik;
        private System.Windows.Forms.Label napisAdresowanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelINL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelINH;
        private System.Windows.Forms.Label labelRejestrIN;
        private System.Windows.Forms.CheckBox rejestrIbit0;
        private System.Windows.Forms.CheckBox rejestrIbit1;
        private System.Windows.Forms.CheckBox rejestrIbit2;
        private System.Windows.Forms.CheckBox rejestrIbit3;
        private System.Windows.Forms.CheckBox rejestrIbit4;
        private System.Windows.Forms.CheckBox rejestrIbit5;
        private System.Windows.Forms.CheckBox rejestrIbit6;
        private System.Windows.Forms.CheckBox rejestrIbit7;
        private System.Windows.Forms.CheckBox rejestrIbit8;
        private System.Windows.Forms.CheckBox rejestrIbit9;
        private System.Windows.Forms.CheckBox rejestrIbit10;
        private System.Windows.Forms.CheckBox rejestrIbit11;
        private System.Windows.Forms.CheckBox rejestrIbit12;
        private System.Windows.Forms.CheckBox rejestrIbit13;
        private System.Windows.Forms.CheckBox rejestrIbit14;
        private System.Windows.Forms.CheckBox rejestrIbit15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWartoscRejestruIN;
        private System.Windows.Forms.Label labelWartoscRejestruB;
        private System.Windows.Forms.Label labelWartoscRejestruD;
        private System.Windows.Forms.Label labelWartoscRejestruC;
        private System.Windows.Forms.Label labelWartoscRejestruA;
        private System.Windows.Forms.Label napisProgram;
        private System.Windows.Forms.Label label1krokProgramu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2krokProgramu;
        private System.Windows.Forms.Label label3krokProgramu;
        private System.Windows.Forms.Label label4krokProgramu;
        private System.Windows.Forms.Label label5krokProgramu;
        private System.Windows.Forms.Label label6krokProgramu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodajDoProgramu;
        private System.Windows.Forms.Button buttonWykonajRozkaz;
        private System.Windows.Forms.Button buttonZapiszProgram;
        private System.Windows.Forms.Button buttonWczytajProgram;
        private System.Windows.Forms.Button buttonWykonajKrok;
        private System.Windows.Forms.Button buttonWykonajProgram;
        private System.Windows.Forms.Label label7krokProgramu;
        private System.Windows.Forms.Label label8krokProgramu;
        private System.Windows.Forms.Label label9krokProgramu;
        private System.Windows.Forms.Label label10krokProgramu;
        private System.Windows.Forms.Label label11krokProgramu;
        private System.Windows.Forms.Label label12krokProgramu;
        private System.Windows.Forms.Label label13krokProgramu;
        private System.Windows.Forms.Label label14krokProgramu;
    }
}

