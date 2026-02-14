namespace Calculadora2
{
    partial class calculadora
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
            txtResultado = new TextBox();
            btnUno = new Button();
            btnTres = new Button();
            btnDos = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnCuatro = new Button();
            btnOcho = new Button();
            btnNueve = new Button();
            btnSiete = new Button();
            btnCero = new Button();
            btnBorrarTodo = new Button();
            btnQuitar = new Button();
            btnBorrar = new Button();
            btnRaizCuadrada = new Button();
            btnCuadrado = new Button();
            btnSigno = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnSumar = new Button();
            btnRestar = new Button();
            btnResultado = new Button();
            btnPunto = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(1, 12);
            txtResultado.MaxLength = 20;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(369, 39);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUno.Location = new Point(15, 287);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(49, 45);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTres.Location = new Point(146, 287);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(49, 45);
            btnTres.TabIndex = 10;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDos.Location = new Point(82, 287);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(49, 45);
            btnDos.TabIndex = 11;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(82, 220);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(49, 45);
            btnCinco.TabIndex = 14;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(146, 220);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(49, 45);
            btnSeis.TabIndex = 13;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCuatro.Location = new Point(12, 220);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(49, 45);
            btnCuatro.TabIndex = 12;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOcho.Location = new Point(82, 150);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(49, 45);
            btnOcho.TabIndex = 17;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnNueve
            // 
            btnNueve.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNueve.Location = new Point(146, 150);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(49, 45);
            btnNueve.TabIndex = 16;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiete.Location = new Point(15, 150);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(49, 45);
            btnSiete.TabIndex = 15;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCero.Location = new Point(82, 350);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(45, 45);
            btnCero.TabIndex = 18;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrarTodo.Location = new Point(82, 88);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(49, 45);
            btnBorrarTodo.TabIndex = 21;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitar.Location = new Point(146, 88);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(49, 45);
            btnQuitar.TabIndex = 20;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(15, 88);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(49, 45);
            btnBorrar.TabIndex = 19;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaizCuadrada.Location = new Point(257, 88);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(49, 45);
            btnRaizCuadrada.TabIndex = 23;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += clickOperador;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCuadrado.Location = new Point(321, 88);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(49, 45);
            btnCuadrado.TabIndex = 22;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += clickOperador;
            // 
            // btnSigno
            // 
            btnSigno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSigno.Location = new Point(15, 350);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(58, 45);
            btnSigno.TabIndex = 25;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += btnSigno_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(257, 150);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(49, 45);
            btnDividir.TabIndex = 24;
            btnDividir.Tag = "/";
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(321, 150);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(49, 45);
            btnMultiplicar.TabIndex = 27;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(257, 220);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(49, 45);
            btnSumar.TabIndex = 26;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(312, 220);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(58, 45);
            btnRestar.TabIndex = 28;
            btnRestar.Tag = "-";
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(257, 287);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(121, 45);
            btnResultado.TabIndex = 29;
            btnResultado.Tag = "";
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(137, 350);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(58, 45);
            btnPunto.TabIndex = 30;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 430);
            Controls.Add(btnPunto);
            Controls.Add(btnResultado);
            Controls.Add(btnRestar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSumar);
            Controls.Add(btnSigno);
            Controls.Add(btnDividir);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnCuadrado);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrar);
            Controls.Add(btnCero);
            Controls.Add(btnOcho);
            Controls.Add(btnNueve);
            Controls.Add(btnSiete);
            Controls.Add(btnCinco);
            Controls.Add(btnSeis);
            Controls.Add(btnCuatro);
            Controls.Add(btnDos);
            Controls.Add(btnTres);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            Name = "calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnTres;
        private Button btnDos;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnCuatro;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnSiete;
        private Button btnCero;
        private Button btnBorrarTodo;
        private Button btnQuitar;
        private Button btnBorrar;
        private Button btnRaizCuadrada;
        private Button btnCuadrado;
        private Button btnSigno;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnResultado;
        private Button btnPunto;
    }
}
