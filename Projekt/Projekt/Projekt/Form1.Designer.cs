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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.najPozLab = new System.Windows.Forms.Label();
            this.histOpVIew = new System.Windows.Forms.ListView();
            this.histOpLab = new System.Windows.Forms.Label();
            this.bilPlanBox = new System.Windows.Forms.GroupBox();
            this.bilRzeczBox = new System.Windows.Forms.GroupBox();
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
            this.bazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.nowyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "pasekStatusu";
            // 
            // najPozLab
            // 
            this.najPozLab.AutoSize = true;
            this.najPozLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.najPozLab.Location = new System.Drawing.Point(14, 237);
            this.najPozLab.Name = "najPozLab";
            this.najPozLab.Size = new System.Drawing.Size(111, 15);
            this.najPozLab.TabIndex = 5;
            this.najPozLab.Text = "Najbliższe pozycje:";
            // 
            // histOpVIew
            // 
            this.histOpVIew.Location = new System.Drawing.Point(517, 25);
            this.histOpVIew.Name = "histOpVIew";
            this.histOpVIew.Size = new System.Drawing.Size(315, 415);
            this.histOpVIew.TabIndex = 6;
            this.histOpVIew.UseCompatibleStateImageBehavior = false;
            this.histOpVIew.View = System.Windows.Forms.View.List;
            // 
            // histOpLab
            // 
            this.histOpLab.AutoSize = true;
            this.histOpLab.Location = new System.Drawing.Point(514, 9);
            this.histOpLab.Name = "histOpLab";
            this.histOpLab.Size = new System.Drawing.Size(85, 13);
            this.histOpLab.TabIndex = 7;
            this.histOpLab.Text = "Historia operacji:";
            // 
            // bilPlanBox
            // 
            this.bilPlanBox.Location = new System.Drawing.Point(17, 447);
            this.bilPlanBox.Name = "bilPlanBox";
            this.bilPlanBox.Size = new System.Drawing.Size(377, 74);
            this.bilPlanBox.TabIndex = 10;
            this.bilPlanBox.TabStop = false;
            this.bilPlanBox.Text = "Bilans Planowany";
            // 
            // bilRzeczBox
            // 
            this.bilRzeczBox.Location = new System.Drawing.Point(447, 447);
            this.bilRzeczBox.Name = "bilRzeczBox";
            this.bilRzeczBox.Size = new System.Drawing.Size(385, 73);
            this.bilRzeczBox.TabIndex = 11;
            this.bilRzeczBox.TabStop = false;
            this.bilRzeczBox.Text = "Bilans rzeczywisty";
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
            this.nowyBox.Location = new System.Drawing.Point(17, 12);
            this.nowyBox.Name = "nowyBox";
            this.nowyBox.Size = new System.Drawing.Size(488, 198);
            this.nowyBox.TabIndex = 12;
            this.nowyBox.TabStop = false;
            this.nowyBox.Text = "Nowa pozycja";
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(6, 169);
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
            this.monthCalendar1.Location = new System.Drawing.Point(208, 25);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // bazaBindingSource
            // 
            this.bazaBindingSource.DataSource = typeof(Projekt.Baza);
            // 
            // bazaBindingSource1
            // 
            this.bazaBindingSource1.DataSource = typeof(Projekt.Baza);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(17, 265);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(488, 175);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(849, 555);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nowyBox);
            this.Controls.Add(this.bilRzeczBox);
            this.Controls.Add(this.bilPlanBox);
            this.Controls.Add(this.histOpLab);
            this.Controls.Add(this.histOpVIew);
            this.Controls.Add(this.najPozLab);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "oknoGlowne";
            this.Text = "Planowanie Budżetu";
            this.Load += new System.EventHandler(this.oknoGlowne_Load);
            this.nowyBox.ResumeLayout(false);
            this.nowyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label najPozLab;
        private System.Windows.Forms.ListView histOpVIew;
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
        private System.Windows.Forms.BindingSource bazaBindingSource;
        private System.Windows.Forms.BindingSource bazaBindingSource1;
        private System.Windows.Forms.ListView listView1;
    }
}

