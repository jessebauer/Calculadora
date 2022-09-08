namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnEleva = new System.Windows.Forms.Button();
            this.btnDivUm = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btncSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnInverteSinal = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.txtTelaTemporaria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Enabled = false;
            this.txtVisor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVisor.Location = new System.Drawing.Point(12, 12);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(318, 99);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(93, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.DimGray;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRaiz.Location = new System.Drawing.Point(174, 208);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(75, 73);
            this.btnRaiz.TabIndex = 7;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            // 
            // btnEleva
            // 
            this.btnEleva.BackColor = System.Drawing.Color.DimGray;
            this.btnEleva.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEleva.Location = new System.Drawing.Point(93, 208);
            this.btnEleva.Name = "btnEleva";
            this.btnEleva.Size = new System.Drawing.Size(75, 73);
            this.btnEleva.TabIndex = 6;
            this.btnEleva.Text = "x²";
            this.btnEleva.UseVisualStyleBackColor = false;
            this.btnEleva.Click += new System.EventHandler(this.btnEleva_Click);
            // 
            // btnDivUm
            // 
            this.btnDivUm.BackColor = System.Drawing.Color.DimGray;
            this.btnDivUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivUm.Location = new System.Drawing.Point(12, 208);
            this.btnDivUm.Name = "btnDivUm";
            this.btnDivUm.Size = new System.Drawing.Size(75, 73);
            this.btnDivUm.TabIndex = 5;
            this.btnDivUm.Text = "1/x";
            this.btnDivUm.UseVisualStyleBackColor = false;
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.BackColor = System.Drawing.Color.DimGray;
            this.btnMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplica.Location = new System.Drawing.Point(255, 287);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(75, 73);
            this.btnMultiplica.TabIndex = 12;
            this.btnMultiplica.Text = "×";
            this.btnMultiplica.UseVisualStyleBackColor = false;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.Color.DimGray;
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNove.Location = new System.Drawing.Point(174, 287);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(75, 73);
            this.btnNove.TabIndex = 11;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.Color.DimGray;
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOito.Location = new System.Drawing.Point(93, 287);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(75, 73);
            this.btnOito.TabIndex = 10;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.Color.DimGray;
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSete.Location = new System.Drawing.Point(12, 287);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(75, 73);
            this.btnSete.TabIndex = 9;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.BackColor = System.Drawing.Color.DimGray;
            this.btnSubtrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtrai.Location = new System.Drawing.Point(255, 366);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(75, 73);
            this.btnSubtrai.TabIndex = 16;
            this.btnSubtrai.Text = "-";
            this.btnSubtrai.UseVisualStyleBackColor = false;
            this.btnSubtrai.Click += new System.EventHandler(this.btnSubtrai_Click);
            // 
            // btncSeis
            // 
            this.btncSeis.BackColor = System.Drawing.Color.DimGray;
            this.btncSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncSeis.Location = new System.Drawing.Point(174, 366);
            this.btncSeis.Name = "btncSeis";
            this.btncSeis.Size = new System.Drawing.Size(75, 73);
            this.btncSeis.TabIndex = 15;
            this.btncSeis.Text = "6";
            this.btncSeis.UseVisualStyleBackColor = false;
            this.btncSeis.Click += new System.EventHandler(this.btncSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.DimGray;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCinco.Location = new System.Drawing.Point(93, 366);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 73);
            this.btnCinco.TabIndex = 14;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.Color.DimGray;
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuatro.Location = new System.Drawing.Point(12, 366);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(75, 73);
            this.btnQuatro.TabIndex = 13;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.DimGray;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.Location = new System.Drawing.Point(255, 445);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 73);
            this.btnSoma.TabIndex = 20;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.DimGray;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTres.Location = new System.Drawing.Point(174, 445);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 73);
            this.btnTres.TabIndex = 19;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.Color.DimGray;
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDois.Location = new System.Drawing.Point(93, 445);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(75, 73);
            this.btnDois.TabIndex = 18;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.Color.DimGray;
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUm.Location = new System.Drawing.Point(12, 445);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(75, 73);
            this.btnUm.TabIndex = 17;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(174, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 73);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.DimGray;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVirgula.Location = new System.Drawing.Point(173, 524);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(75, 73);
            this.btnVirgula.TabIndex = 24;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.DimGray;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(92, 524);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 73);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnInverteSinal
            // 
            this.btnInverteSinal.BackColor = System.Drawing.Color.DimGray;
            this.btnInverteSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInverteSinal.Location = new System.Drawing.Point(11, 524);
            this.btnInverteSinal.Name = "btnInverteSinal";
            this.btnInverteSinal.Size = new System.Drawing.Size(75, 73);
            this.btnInverteSinal.TabIndex = 22;
            this.btnInverteSinal.Text = "+/-";
            this.btnInverteSinal.UseVisualStyleBackColor = false;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Location = new System.Drawing.Point(255, 524);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 73);
            this.btnIgual.TabIndex = 25;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.DimGray;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(255, 208);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 73);
            this.btnDivide.TabIndex = 26;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpa.Location = new System.Drawing.Point(255, 129);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Padding = new System.Windows.Forms.Padding(1000);
            this.btnLimpa.Size = new System.Drawing.Size(75, 73);
            this.btnLimpa.TabIndex = 27;
            this.btnLimpa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // txtTelaTemporaria
            // 
            this.txtTelaTemporaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelaTemporaria.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelaTemporaria.Location = new System.Drawing.Point(186, 77);
            this.txtTelaTemporaria.Name = "txtTelaTemporaria";
            this.txtTelaTemporaria.Size = new System.Drawing.Size(144, 27);
            this.txtTelaTemporaria.TabIndex = 28;
            this.txtTelaTemporaria.TextChanged += new System.EventHandler(this.txtResultadoTemporario_TextChanged);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(342, 615);
            this.Controls.Add(this.txtTelaTemporaria);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnInverteSinal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.btncSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnEleva);
            this.Controls.Add(this.btnDivUm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVisor);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtVisor;
        private Button button1;
        private Button button2;
        private Button btnRaiz;
        private Button btnEleva;
        private Button btnDivUm;
        private Button btnMultiplica;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnSubtrai;
        private Button btncSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnSoma;
        private Button btnTres;
        private Button btnDois;
        private Button btnUm;
        private Button btnLimpar;
        private Button btnVirgula;
        private Button btnZero;
        private Button btnInverteSinal;
        private Button btnIgual;
        private Button btnDivide;
        private Button btnLimpa;
        private TextBox txtTelaTemporaria;
    }
}