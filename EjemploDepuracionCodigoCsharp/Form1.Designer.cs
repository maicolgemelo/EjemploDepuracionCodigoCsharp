namespace EjemploDepuracionCodigoCsharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lvNumeros = new System.Windows.Forms.ListView();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.lbvalores = new System.Windows.Forms.ListBox();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consecutivo con uso del ciclo mientras ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(266, 118);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 31);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // lvNumeros
            // 
            this.lvNumeros.Location = new System.Drawing.Point(588, 118);
            this.lvNumeros.Name = "lvNumeros";
            this.lvNumeros.Size = new System.Drawing.Size(90, 320);
            this.lvNumeros.TabIndex = 3;
            this.lvNumeros.UseCompatibleStateImageBehavior = false;
            // 
            // btnRellenar
            // 
            this.btnRellenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRellenar.Location = new System.Drawing.Point(405, 118);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(123, 42);
            this.btnRellenar.TabIndex = 4;
            this.btnRellenar.Text = "Rellenar";
            this.btnRellenar.UseVisualStyleBackColor = true;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // lbvalores
            // 
            this.lbvalores.FormattingEnabled = true;
            this.lbvalores.Location = new System.Drawing.Point(704, 118);
            this.lbvalores.Name = "lbvalores";
            this.lbvalores.Size = new System.Drawing.Size(92, 316);
            this.lbvalores.TabIndex = 5;
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFibonacci.Location = new System.Drawing.Point(405, 206);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(123, 46);
            this.btnFibonacci.TabIndex = 6;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.lbvalores);
            this.Controls.Add(this.btnRellenar);
            this.Controls.Add(this.lvNumeros);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListView lvNumeros;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.ListBox lbvalores;
        private System.Windows.Forms.Button btnFibonacci;
    }
}

