namespace Projekt
{
    partial class oknoGlowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.najPozLab = new System.Windows.Forms.Label();
            this.histOpLab = new System.Windows.Forms.Label();
            this.bilPlanBox = new System.Windows.Forms.GroupBox();
            this.bilPlanLab = new System.Windows.Forms.Label();
            this.bilRzeczBox = new System.Windows.Forms.GroupBox();
            this.bilRzeczLab = new System.Windows.Forms.Label();
            this.nowyBox = new System.Windows.Forms.GroupBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nazwLab = new System.Windows.Forms.Label();
            this.rzeczCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wartLab = new System.Windows.Forms.Label();
            this.katTextBox = new System.Windows.Forms.TextBox();
            this.katLab = new System.Windows.Forms.Label();
            this.intervMscLab = new System.Windows.Forms.Label();
            this.intervLab = new System.Windows.Forms.Label();
            this.numericInterv = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.najPozGrid = new System.Windows.Forms.DataGridView();
            this.histPozGrid = new System.Windows.Forms.DataGridView();
            this.usunButton = new System.Windows.Forms.Button();
            this.usunZHistCheckBox = new System.Windows.Forms.CheckBox();
            this.usunGroupBox = new System.Windows.Forms.GroupBox();
            this.nazwaLab = new System.Windows.Forms.Label();
            this.usunTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stronaAutoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saldoGroupBox = new System.Windows.Forms.GroupBox();
            this.saldoLab = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.odswiezBut = new System.Windows.Forms.Button();
            this.nowyBudżetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilPlanBox.SuspendLayout();
            this.bilRzeczBox.SuspendLayout();
            this.nowyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.najPozGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histPozGrid)).BeginInit();
            this.usunGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.saldoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1062, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "pasekStatusu";
            // 
            // najPozLab
            // 
            this.najPozLab.AutoSize = true;
            this.najPozLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.najPozLab.Location = new System.Drawing.Point(9, 253);
            this.najPozLab.Name = "najPozLab";
            this.najPozLab.Size = new System.Drawing.Size(111, 15);
            this.najPozLab.TabIndex = 5;
            this.najPozLab.Text = "Najbliższe pozycje:";
            // 
            // histOpLab
            // 
            this.histOpLab.AutoSize = true;
            this.histOpLab.Location = new System.Drawing.Point(616, 25);
            this.histOpLab.Name = "histOpLab";
            this.histOpLab.Size = new System.Drawing.Size(85, 13);
            this.histOpLab.TabIndex = 7;
            this.histOpLab.Text = "Historia operacji:";
            // 
            // bilPlanBox
            // 
            this.bilPlanBox.Controls.Add(this.bilPlanLab);
            this.bilPlanBox.Location = new System.Drawing.Point(12, 463);
            this.bilPlanBox.Name = "bilPlanBox";
            this.bilPlanBox.Size = new System.Drawing.Size(363, 74);
            this.bilPlanBox.TabIndex = 10;
            this.bilPlanBox.TabStop = false;
            this.bilPlanBox.Text = "Bilans Planowany";
            // 
            // bilPlanLab
            // 
            this.bilPlanLab.AutoSize = true;
            this.bilPlanLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bilPlanLab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bilPlanLab.Location = new System.Drawing.Point(6, 28);
            this.bilPlanLab.Name = "bilPlanLab";
            this.bilPlanLab.Size = new System.Drawing.Size(79, 29);
            this.bilPlanLab.TabIndex = 0;
            this.bilPlanLab.Text = "label1";
            // 
            // bilRzeczBox
            // 
            this.bilRzeczBox.Controls.Add(this.bilRzeczLab);
            this.bilRzeczBox.Location = new System.Drawing.Point(451, 463);
            this.bilRzeczBox.Name = "bilRzeczBox";
            this.bilRzeczBox.Size = new System.Drawing.Size(376, 73);
            this.bilRzeczBox.TabIndex = 11;
            this.bilRzeczBox.TabStop = false;
            this.bilRzeczBox.Text = "Bilans rzeczywisty";
            // 
            // bilRzeczLab
            // 
            this.bilRzeczLab.AutoSize = true;
            this.bilRzeczLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bilRzeczLab.Location = new System.Drawing.Point(6, 28);
            this.bilRzeczLab.Name = "bilRzeczLab";
            this.bilRzeczLab.Size = new System.Drawing.Size(79, 29);
            this.bilRzeczLab.TabIndex = 1;
            this.bilRzeczLab.Text = "label1";
            // 
            // nowyBox
            // 
            this.nowyBox.Controls.Add(this.DodajButton);
            this.nowyBox.Controls.Add(this.textBox2);
            this.nowyBox.Controls.Add(this.nazwLab);
            this.nowyBox.Controls.Add(this.rzeczCheckBox);
            this.nowyBox.Controls.Add(this.textBox1);
            this.nowyBox.Controls.Add(this.wartLab);
            this.nowyBox.Controls.Add(this.katTextBox);
            this.nowyBox.Controls.Add(this.katLab);
            this.nowyBox.Controls.Add(this.intervMscLab);
            this.nowyBox.Controls.Add(this.intervLab);
            this.nowyBox.Controls.Add(this.numericInterv);
            this.nowyBox.Controls.Add(this.monthCalendar1);
            this.nowyBox.Location = new System.Drawing.Point(12, 28);
            this.nowyBox.Name = "nowyBox";
            this.nowyBox.Size = new System.Drawing.Size(598, 197);
            this.nowyBox.TabIndex = 12;
            this.nowyBox.TabStop = false;
            this.nowyBox.Text = "Nowa pozycja";
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(13, 163);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(75, 23);
            this.DodajButton.TabIndex = 13;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // nazwLab
            // 
            this.nazwLab.AutoSize = true;
            this.nazwLab.Location = new System.Drawing.Point(52, 78);
            this.nazwLab.Name = "nazwLab";
            this.nazwLab.Size = new System.Drawing.Size(40, 13);
            this.nazwLab.TabIndex = 11;
            this.nazwLab.Text = "Nazwa";
            // 
            // rzeczCheckBox
            // 
            this.rzeczCheckBox.AutoSize = true;
            this.rzeczCheckBox.Location = new System.Drawing.Point(98, 26);
            this.rzeczCheckBox.Name = "rzeczCheckBox";
            this.rzeczCheckBox.Size = new System.Drawing.Size(85, 17);
            this.rzeczCheckBox.TabIndex = 10;
            this.rzeczCheckBox.Text = "Rzeczywista";
            this.rzeczCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // wartLab
            // 
            this.wartLab.AutoSize = true;
            this.wartLab.Location = new System.Drawing.Point(10, 131);
            this.wartLab.Name = "wartLab";
            this.wartLab.Size = new System.Drawing.Size(82, 13);
            this.wartLab.TabIndex = 8;
            this.wartLab.Text = "Wartość pozycji";
            // 
            // katTextBox
            // 
            this.katTextBox.Location = new System.Drawing.Point(98, 101);
            this.katTextBox.Name = "katTextBox";
            this.katTextBox.Size = new System.Drawing.Size(100, 20);
            this.katTextBox.TabIndex = 7;
            // 
            // katLab
            // 
            this.katLab.AutoSize = true;
            this.katLab.Location = new System.Drawing.Point(40, 104);
            this.katLab.Name = "katLab";
            this.katLab.Size = new System.Drawing.Size(52, 13);
            this.katLab.TabIndex = 6;
            this.katLab.Text = "Kategoria";
            // 
            // intervMscLab
            // 
            this.intervMscLab.AutoSize = true;
            this.intervMscLab.Location = new System.Drawing.Point(151, 51);
            this.intervMscLab.Name = "intervMscLab";
            this.intervMscLab.Size = new System.Drawing.Size(47, 13);
            this.intervMscLab.TabIndex = 5;
            this.intervMscLab.Text = "miesięcy";
            // 
            // intervLab
            // 
            this.intervLab.AutoSize = true;
            this.intervLab.Location = new System.Drawing.Point(33, 51);
            this.intervLab.Name = "intervLab";
            this.intervLab.Size = new System.Drawing.Size(59, 13);
            this.intervLab.TabIndex = 4;
            this.intervLab.Text = "powtórz co";
            // 
            // numericInterv
            // 
            this.numericInterv.Location = new System.Drawing.Point(98, 49);
            this.numericInterv.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericInterv.Name = "numericInterv";
            this.numericInterv.Size = new System.Drawing.Size(39, 20);
            this.numericInterv.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(317, 24);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // najPozGrid
            // 
            this.najPozGrid.AllowUserToAddRows = false;
            this.najPozGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.najPozGrid.Location = new System.Drawing.Point(15, 278);
            this.najPozGrid.Name = "najPozGrid";
            this.najPozGrid.ReadOnly = true;
            this.najPozGrid.Size = new System.Drawing.Size(430, 177);
            this.najPozGrid.TabIndex = 13;
            // 
            // histPozGrid
            // 
            this.histPozGrid.AllowUserToAddRows = false;
            this.histPozGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.histPozGrid.Location = new System.Drawing.Point(619, 41);
            this.histPozGrid.Name = "histPozGrid";
            this.histPozGrid.ReadOnly = true;
            this.histPozGrid.Size = new System.Drawing.Size(430, 414);
            this.histPozGrid.TabIndex = 14;
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(6, 62);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(75, 23);
            this.usunButton.TabIndex = 14;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // usunZHistCheckBox
            // 
            this.usunZHistCheckBox.AutoSize = true;
            this.usunZHistCheckBox.Location = new System.Drawing.Point(93, 66);
            this.usunZHistCheckBox.Name = "usunZHistCheckBox";
            this.usunZHistCheckBox.Size = new System.Drawing.Size(63, 17);
            this.usunZHistCheckBox.TabIndex = 15;
            this.usunZHistCheckBox.Text = "z historii";
            this.usunZHistCheckBox.UseVisualStyleBackColor = true;
            // 
            // usunGroupBox
            // 
            this.usunGroupBox.Controls.Add(this.nazwaLab);
            this.usunGroupBox.Controls.Add(this.usunTextBox);
            this.usunGroupBox.Controls.Add(this.usunZHistCheckBox);
            this.usunGroupBox.Controls.Add(this.usunButton);
            this.usunGroupBox.Location = new System.Drawing.Point(451, 278);
            this.usunGroupBox.Name = "usunGroupBox";
            this.usunGroupBox.Size = new System.Drawing.Size(162, 91);
            this.usunGroupBox.TabIndex = 14;
            this.usunGroupBox.TabStop = false;
            this.usunGroupBox.Text = "Usuwanie";
            // 
            // nazwaLab
            // 
            this.nazwaLab.AutoSize = true;
            this.nazwaLab.Location = new System.Drawing.Point(10, 22);
            this.nazwaLab.Name = "nazwaLab";
            this.nazwaLab.Size = new System.Drawing.Size(40, 13);
            this.nazwaLab.TabIndex = 17;
            this.nazwaLab.Text = "Nazwa";
            // 
            // usunTextBox
            // 
            this.usunTextBox.Location = new System.Drawing.Point(56, 19);
            this.usunTextBox.Name = "usunTextBox";
            this.usunTextBox.Size = new System.Drawing.Size(100, 20);
            this.usunTextBox.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.kontaktToolStripMenuItem,
            this.zmieńSaldoToolStripMenuItem,
            this.nowyBudżetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookToolStripMenuItem,
            this.mailToolStripMenuItem,
            this.stronaAutoraToolStripMenuItem});
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kontaktToolStripMenuItem.Text = "Kontakt";
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.mailToolStripMenuItem.Text = "Mail";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // stronaAutoraToolStripMenuItem
            // 
            this.stronaAutoraToolStripMenuItem.Name = "stronaAutoraToolStripMenuItem";
            this.stronaAutoraToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.stronaAutoraToolStripMenuItem.Text = "Strona autora";
            this.stronaAutoraToolStripMenuItem.Click += new System.EventHandler(this.stronaAutoraToolStripMenuItem_Click);
            // 
            // zmieńSaldoToolStripMenuItem
            // 
            this.zmieńSaldoToolStripMenuItem.Name = "zmieńSaldoToolStripMenuItem";
            this.zmieńSaldoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.zmieńSaldoToolStripMenuItem.Text = "Zmień saldo";
            this.zmieńSaldoToolStripMenuItem.Click += new System.EventHandler(this.zmieńSaldoToolStripMenuItem_Click);
            // 
            // saldoGroupBox
            // 
            this.saldoGroupBox.Controls.Add(this.saldoLab);
            this.saldoGroupBox.Location = new System.Drawing.Point(452, 369);
            this.saldoGroupBox.Name = "saldoGroupBox";
            this.saldoGroupBox.Size = new System.Drawing.Size(160, 85);
            this.saldoGroupBox.TabIndex = 16;
            this.saldoGroupBox.TabStop = false;
            this.saldoGroupBox.Text = "Saldo";
            // 
            // saldoLab
            // 
            this.saldoLab.AutoSize = true;
            this.saldoLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saldoLab.Location = new System.Drawing.Point(6, 30);
            this.saldoLab.Name = "saldoLab";
            this.saldoLab.Size = new System.Drawing.Size(79, 29);
            this.saldoLab.TabIndex = 0;
            this.saldoLab.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // odswiezBut
            // 
            this.odswiezBut.Location = new System.Drawing.Point(381, 463);
            this.odswiezBut.Name = "odswiezBut";
            this.odswiezBut.Size = new System.Drawing.Size(64, 22);
            this.odswiezBut.TabIndex = 17;
            this.odswiezBut.Text = "Odśwież";
            this.odswiezBut.UseVisualStyleBackColor = true;
            this.odswiezBut.Click += new System.EventHandler(this.odswiezBut_Click);
            // 
            // nowyBudżetToolStripMenuItem
            // 
            this.nowyBudżetToolStripMenuItem.Name = "nowyBudżetToolStripMenuItem";
            this.nowyBudżetToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.nowyBudżetToolStripMenuItem.Text = "Nowy budżet";
            this.nowyBudżetToolStripMenuItem.Click += new System.EventHandler(this.nowyBudżetToolStripMenuItem_Click);
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1062, 569);
            this.Controls.Add(this.odswiezBut);
            this.Controls.Add(this.saldoGroupBox);
            this.Controls.Add(this.usunGroupBox);
            this.Controls.Add(this.histPozGrid);
            this.Controls.Add(this.najPozGrid);
            this.Controls.Add(this.nowyBox);
            this.Controls.Add(this.bilRzeczBox);
            this.Controls.Add(this.bilPlanBox);
            this.Controls.Add(this.histOpLab);
            this.Controls.Add(this.najPozLab);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "oknoGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planowanie Budżetu";
            this.Load += new System.EventHandler(this.oknoGlowne_Load);
            this.bilPlanBox.ResumeLayout(false);
            this.bilPlanBox.PerformLayout();
            this.bilRzeczBox.ResumeLayout(false);
            this.bilRzeczBox.PerformLayout();
            this.nowyBox.ResumeLayout(false);
            this.nowyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.najPozGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histPozGrid)).EndInit();
            this.usunGroupBox.ResumeLayout(false);
            this.usunGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.saldoGroupBox.ResumeLayout(false);
            this.saldoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label najPozLab;
        private System.Windows.Forms.Label histOpLab;
        private System.Windows.Forms.GroupBox bilPlanBox;
        private System.Windows.Forms.GroupBox bilRzeczBox;
        private System.Windows.Forms.GroupBox nowyBox;
        private System.Windows.Forms.Label intervMscLab;
        private System.Windows.Forms.Label intervLab;
        private System.Windows.Forms.NumericUpDown numericInterv;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox katTextBox;
        private System.Windows.Forms.Label katLab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label wartLab;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nazwLab;
        private System.Windows.Forms.CheckBox rzeczCheckBox;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.DataGridView najPozGrid;
        private System.Windows.Forms.DataGridView histPozGrid;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.GroupBox usunGroupBox;
        private System.Windows.Forms.CheckBox usunZHistCheckBox;
        private System.Windows.Forms.Label nazwaLab;
        private System.Windows.Forms.TextBox usunTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox saldoGroupBox;
        private System.Windows.Forms.Label saldoLab;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label bilPlanLab;
        private System.Windows.Forms.Label bilRzeczLab;
        private System.Windows.Forms.Button odswiezBut;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stronaAutoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyBudżetToolStripMenuItem;
    }
}

