
namespace LogicaDifusa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbElemento = new System.Windows.Forms.ComboBox();
            this.spinnerElemento = new System.Windows.Forms.NumericUpDown();
            this.trackTamano = new System.Windows.Forms.TrackBar();
            this.pbArma = new System.Windows.Forms.PictureBox();
            this.pbElemento = new System.Windows.Forms.PictureBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconosArmas = new System.Windows.Forms.ImageList(this.components);
            this.iconosElementos = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spinnerEstado = new System.Windows.Forms.NumericUpDown();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPatron = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPapel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerElemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTamano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbElemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // cbElemento
            // 
            this.cbElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbElemento.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbElemento.FormattingEnabled = true;
            this.cbElemento.Items.AddRange(new object[] {
            "Agua",
            "Draco",
            "Fuego",
            "Hielo",
            "Rayo"});
            this.cbElemento.Location = new System.Drawing.Point(20, 60);
            this.cbElemento.Name = "cbElemento";
            this.cbElemento.Size = new System.Drawing.Size(175, 25);
            this.cbElemento.TabIndex = 0;
            // 
            // spinnerElemento
            // 
            this.spinnerElemento.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinnerElemento.Location = new System.Drawing.Point(225, 60);
            this.spinnerElemento.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinnerElemento.Name = "spinnerElemento";
            this.spinnerElemento.ReadOnly = true;
            this.spinnerElemento.Size = new System.Drawing.Size(175, 25);
            this.spinnerElemento.TabIndex = 5;
            // 
            // trackTamano
            // 
            this.trackTamano.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.trackTamano.LargeChange = 1;
            this.trackTamano.Location = new System.Drawing.Point(20, 398);
            this.trackTamano.Maximum = 4;
            this.trackTamano.Minimum = 1;
            this.trackTamano.Name = "trackTamano";
            this.trackTamano.Size = new System.Drawing.Size(380, 45);
            this.trackTamano.TabIndex = 6;
            this.trackTamano.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackTamano.Value = 1;
            // 
            // pbArma
            // 
            this.pbArma.BackColor = System.Drawing.Color.Transparent;
            this.pbArma.Image = ((System.Drawing.Image)(resources.GetObject("pbArma.Image")));
            this.pbArma.Location = new System.Drawing.Point(595, 60);
            this.pbArma.Name = "pbArma";
            this.pbArma.Size = new System.Drawing.Size(255, 255);
            this.pbArma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArma.TabIndex = 8;
            this.pbArma.TabStop = false;
            // 
            // pbElemento
            // 
            this.pbElemento.BackColor = System.Drawing.Color.Transparent;
            this.pbElemento.Image = ((System.Drawing.Image)(resources.GetObject("pbElemento.Image")));
            this.pbElemento.Location = new System.Drawing.Point(658, 390);
            this.pbElemento.Name = "pbElemento";
            this.pbElemento.Size = new System.Drawing.Size(130, 130);
            this.pbElemento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbElemento.TabIndex = 9;
            this.pbElemento.TabStop = false;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEvaluar.FlatAppearance.BorderSize = 0;
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluar.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluar.ForeColor = System.Drawing.Color.White;
            this.btnEvaluar.Location = new System.Drawing.Point(250, 500);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(150, 40);
            this.btnEvaluar.TabIndex = 10;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Arma recomendada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Elemento/Estado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconosArmas
            // 
            this.iconosArmas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconosArmas.ImageStream")));
            this.iconosArmas.TransparentColor = System.Drawing.Color.Transparent;
            this.iconosArmas.Images.SetKeyName(0, "arma_oculta.png");
            this.iconosArmas.Images.SetKeyName(1, "arco.png");
            this.iconosArmas.Images.SetKeyName(2, "ballesta_ligera.png");
            this.iconosArmas.Images.SetKeyName(3, "ballesta_pesada.png");
            this.iconosArmas.Images.SetKeyName(4, "cornamusa.png");
            this.iconosArmas.Images.SetKeyName(5, "espada_larga.png");
            this.iconosArmas.Images.SetKeyName(6, "espada_y_escudo.png");
            this.iconosArmas.Images.SetKeyName(7, "espadas_duales.png");
            this.iconosArmas.Images.SetKeyName(8, "glaive_de_insecto.png");
            this.iconosArmas.Images.SetKeyName(9, "gran_espada.png");
            this.iconosArmas.Images.SetKeyName(10, "hacha_cargada.png");
            this.iconosArmas.Images.SetKeyName(11, "hacha_espada.png");
            this.iconosArmas.Images.SetKeyName(12, "lanza_pistola.png");
            this.iconosArmas.Images.SetKeyName(13, "lanza_y_escudo.png");
            this.iconosArmas.Images.SetKeyName(14, "martillo.png");
            // 
            // iconosElementos
            // 
            this.iconosElementos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconosElementos.ImageStream")));
            this.iconosElementos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconosElementos.Images.SetKeyName(0, "arma_oculta.png");
            this.iconosElementos.Images.SetKeyName(1, "elemento_agua.png");
            this.iconosElementos.Images.SetKeyName(2, "elemento_draco.png");
            this.iconosElementos.Images.SetKeyName(3, "elemento_fuego.png");
            this.iconosElementos.Images.SetKeyName(4, "elemento_hielo.png");
            this.iconosElementos.Images.SetKeyName(5, "elemento_rayo.png");
            this.iconosElementos.Images.SetKeyName(6, "estado_nitro.png");
            this.iconosElementos.Images.SetKeyName(7, "estado_paralisis.png");
            this.iconosElementos.Images.SetKeyName(8, "estado_sueño.png");
            this.iconosElementos.Images.SetKeyName(9, "estado_veneno.png");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Elemento efectivo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nivel de efectividad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nivel de efectividad";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado efectivo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spinnerEstado
            // 
            this.spinnerEstado.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinnerEstado.Location = new System.Drawing.Point(225, 145);
            this.spinnerEstado.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinnerEstado.Name = "spinnerEstado";
            this.spinnerEstado.ReadOnly = true;
            this.spinnerEstado.Size = new System.Drawing.Size(175, 25);
            this.spinnerEstado.TabIndex = 16;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Nitro",
            "Paralisis",
            "Sueño",
            "Veneno"});
            this.cbEstado.Location = new System.Drawing.Point(20, 145);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(175, 25);
            this.cbEstado.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tipo de ataque";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Elemental",
            "Estado",
            "Fisico"});
            this.cbTipo.Location = new System.Drawing.Point(20, 230);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(175, 25);
            this.cbTipo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 30);
            this.label8.TabIndex = 22;
            this.label8.Text = "Patron de ataque";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPatron
            // 
            this.cbPatron.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatron.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPatron.FormattingEnabled = true;
            this.cbPatron.Items.AddRange(new object[] {
            "Cuerpo a cuerpo",
            "Distancia"});
            this.cbPatron.Location = new System.Drawing.Point(225, 230);
            this.cbPatron.Name = "cbPatron";
            this.cbPatron.Size = new System.Drawing.Size(175, 25);
            this.cbPatron.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tamaño del monstruo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(20, 500);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 30);
            this.label10.TabIndex = 25;
            this.label10.Text = "Pequeño";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(300, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 30);
            this.label11.TabIndex = 26;
            this.label11.Text = "Colosal";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 30);
            this.label12.TabIndex = 28;
            this.label12.Text = "Papeles especificos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPapel
            // 
            this.cbPapel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPapel.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPapel.FormattingEnabled = true;
            this.cbPapel.Items.AddRange(new object[] {
            "Ninguno",
            "Daño rapido",
            "Soporte",
            "Tanque"});
            this.cbPapel.Location = new System.Drawing.Point(19, 315);
            this.cbPapel.Name = "cbPapel";
            this.cbPapel.Size = new System.Drawing.Size(175, 25);
            this.cbPapel.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbPapel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPatron);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spinnerEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.pbElemento);
            this.Controls.Add(this.pbArma);
            this.Controls.Add(this.trackTamano);
            this.Controls.Add(this.spinnerElemento);
            this.Controls.Add(this.cbElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spinnerElemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTamano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbElemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbElemento;
        private System.Windows.Forms.NumericUpDown spinnerElemento;
        private System.Windows.Forms.TrackBar trackTamano;
        private System.Windows.Forms.PictureBox pbArma;
        private System.Windows.Forms.PictureBox pbElemento;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList iconosArmas;
        private System.Windows.Forms.ImageList iconosElementos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spinnerEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPatron;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPapel;
    }
}

