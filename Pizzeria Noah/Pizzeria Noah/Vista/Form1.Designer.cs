namespace Pizzeria_Noah.Vista
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSimulats = new System.Windows.Forms.TextBox();
            this.buttonInici = new System.Windows.Forms.Button();
            this.buttonComanda = new System.Windows.Forms.Button();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHoraInici = new System.Windows.Forms.Label();
            this.labelTempsReal = new System.Windows.Forms.Label();
            this.labelTempsSimulat = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1s real = N simulats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N:";
            // 
            // textBoxSimulats
            // 
            this.textBoxSimulats.Location = new System.Drawing.Point(35, 41);
            this.textBoxSimulats.Name = "textBoxSimulats";
            this.textBoxSimulats.Size = new System.Drawing.Size(100, 20);
            this.textBoxSimulats.TabIndex = 2;
            // 
            // buttonInici
            // 
            this.buttonInici.Location = new System.Drawing.Point(141, 39);
            this.buttonInici.Name = "buttonInici";
            this.buttonInici.Size = new System.Drawing.Size(75, 23);
            this.buttonInici.TabIndex = 3;
            this.buttonInici.Text = "Inici";
            this.buttonInici.UseVisualStyleBackColor = true;
            // 
            // buttonComanda
            // 
            this.buttonComanda.Location = new System.Drawing.Point(141, 87);
            this.buttonComanda.Name = "buttonComanda";
            this.buttonComanda.Size = new System.Drawing.Size(75, 23);
            this.buttonComanda.TabIndex = 6;
            this.buttonComanda.Text = "Comanda";
            this.buttonComanda.UseVisualStyleBackColor = true;
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Location = new System.Drawing.Point(35, 89);
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(100, 20);
            this.textBoxIngredients.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingredients:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temps simulat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Temps real:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora inici:";
            // 
            // labelHoraInici
            // 
            this.labelHoraInici.AutoSize = true;
            this.labelHoraInici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraInici.Location = new System.Drawing.Point(294, 44);
            this.labelHoraInici.Name = "labelHoraInici";
            this.labelHoraInici.Size = new System.Drawing.Size(98, 25);
            this.labelHoraInici.TabIndex = 12;
            this.labelHoraInici.Text = "00:00:00";
            // 
            // labelTempsReal
            // 
            this.labelTempsReal.AutoSize = true;
            this.labelTempsReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsReal.Location = new System.Drawing.Point(469, 44);
            this.labelTempsReal.Name = "labelTempsReal";
            this.labelTempsReal.Size = new System.Drawing.Size(98, 25);
            this.labelTempsReal.TabIndex = 11;
            this.labelTempsReal.Text = "00:00:00";
            // 
            // labelTempsSimulat
            // 
            this.labelTempsSimulat.AutoSize = true;
            this.labelTempsSimulat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsSimulat.Location = new System.Drawing.Point(640, 44);
            this.labelTempsSimulat.Name = "labelTempsSimulat";
            this.labelTempsSimulat.Size = new System.Drawing.Size(98, 25);
            this.labelTempsSimulat.TabIndex = 10;
            this.labelTempsSimulat.Text = "00:00:00";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 136);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(773, 302);
            this.dataGridView.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelHoraInici);
            this.Controls.Add(this.labelTempsReal);
            this.Controls.Add(this.labelTempsSimulat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonComanda);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonInici);
            this.Controls.Add(this.textBoxSimulats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxSimulats;
        public System.Windows.Forms.Button buttonInici;
        public System.Windows.Forms.Button buttonComanda;
        public System.Windows.Forms.TextBox textBoxIngredients;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label labelHoraInici;
        public System.Windows.Forms.Label labelTempsReal;
        public System.Windows.Forms.Label labelTempsSimulat;
        public System.Windows.Forms.DataGridView dataGridView;
    }
}

