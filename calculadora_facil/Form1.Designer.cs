namespace calculadora_facil
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
            this.tBPantalla = new System.Windows.Forms.TextBox();
            this.btsigno = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btComa = new System.Windows.Forms.Button();
            this.btRaiz = new System.Windows.Forms.Button();
            this.btExponente = new System.Windows.Forms.Button();
            this.btFraccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBPantalla
            // 
            this.tBPantalla.Location = new System.Drawing.Point(25, 12);
            this.tBPantalla.Multiline = true;
            this.tBPantalla.Name = "tBPantalla";
            this.tBPantalla.Size = new System.Drawing.Size(204, 40);
            this.tBPantalla.TabIndex = 1;
            // 
            // btsigno
            // 
            this.btsigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btsigno.Location = new System.Drawing.Point(25, 320);
            this.btsigno.Name = "btsigno";
            this.btsigno.Size = new System.Drawing.Size(60, 40);
            this.btsigno.TabIndex = 2;
            this.btsigno.Text = "+/-";
            this.btsigno.UseVisualStyleBackColor = true;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(95, 320);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(60, 40);
            this.bt0.TabIndex = 3;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(249, 320);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(60, 40);
            this.btIgual.TabIndex = 5;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(25, 259);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(60, 40);
            this.bt1.TabIndex = 6;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(95, 259);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(60, 40);
            this.bt2.TabIndex = 7;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(169, 259);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(60, 40);
            this.bt3.TabIndex = 8;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btMas
            // 
            this.btMas.Location = new System.Drawing.Point(249, 259);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(60, 40);
            this.btMas.TabIndex = 9;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = true;
            this.btMas.Click += new System.EventHandler(this.btMas_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(25, 195);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(60, 40);
            this.bt4.TabIndex = 10;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(95, 195);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(60, 40);
            this.bt5.TabIndex = 11;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(169, 195);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(60, 40);
            this.bt6.TabIndex = 12;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // btMenos
            // 
            this.btMenos.Location = new System.Drawing.Point(249, 195);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(60, 40);
            this.btMenos.TabIndex = 13;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(25, 129);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(60, 40);
            this.bt7.TabIndex = 14;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(95, 129);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(60, 40);
            this.bt8.TabIndex = 15;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(169, 129);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(60, 40);
            this.bt9.TabIndex = 16;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(249, 129);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(60, 40);
            this.btMultiplicar.TabIndex = 17;
            this.btMultiplicar.Text = "x";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(249, 76);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(60, 40);
            this.btDividir.TabIndex = 18;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(239, 12);
            this.btBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(70, 40);
            this.btBorrar.TabIndex = 21;
            this.btBorrar.Text = "BORRAR";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btComa
            // 
            this.btComa.Location = new System.Drawing.Point(169, 320);
            this.btComa.Name = "btComa";
            this.btComa.Size = new System.Drawing.Size(60, 40);
            this.btComa.TabIndex = 22;
            this.btComa.Text = ",";
            this.btComa.UseVisualStyleBackColor = true;
            // 
            // btRaiz
            // 
            this.btRaiz.Location = new System.Drawing.Point(169, 76);
            this.btRaiz.Name = "btRaiz";
            this.btRaiz.Size = new System.Drawing.Size(60, 40);
            this.btRaiz.TabIndex = 23;
            this.btRaiz.Text = "√";
            this.btRaiz.UseVisualStyleBackColor = true;
            this.btRaiz.Click += new System.EventHandler(this.btRaiz_Click);
            // 
            // btExponente
            // 
            this.btExponente.Location = new System.Drawing.Point(95, 76);
            this.btExponente.Name = "btExponente";
            this.btExponente.Size = new System.Drawing.Size(60, 40);
            this.btExponente.TabIndex = 24;
            this.btExponente.Text = "^";
            this.btExponente.UseVisualStyleBackColor = true;
            this.btExponente.Click += new System.EventHandler(this.btExponente_Click);
            // 
            // btFraccion
            // 
            this.btFraccion.Location = new System.Drawing.Point(25, 76);
            this.btFraccion.Name = "btFraccion";
            this.btFraccion.Size = new System.Drawing.Size(60, 40);
            this.btFraccion.TabIndex = 25;
            this.btFraccion.Text = "1/x";
            this.btFraccion.UseVisualStyleBackColor = true;
            this.btFraccion.Click += new System.EventHandler(this.btFraccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 382);
            this.Controls.Add(this.btFraccion);
            this.Controls.Add(this.btExponente);
            this.Controls.Add(this.btRaiz);
            this.Controls.Add(this.btComa);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btMas);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btsigno);
            this.Controls.Add(this.tBPantalla);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBPantalla;
        private System.Windows.Forms.Button btsigno;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btComa;
        private System.Windows.Forms.Button btRaiz;
        private System.Windows.Forms.Button btExponente;
        private System.Windows.Forms.Button btFraccion;
    }
}

