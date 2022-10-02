
namespace L9_DBDLL_29187
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
            this.lbl_texto1 = new System.Windows.Forms.Label();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.lbl_numero1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_texto1
            // 
            this.lbl_texto1.AutoSize = true;
            this.lbl_texto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto1.Location = new System.Drawing.Point(82, 55);
            this.lbl_texto1.Name = "lbl_texto1";
            this.lbl_texto1.Size = new System.Drawing.Size(272, 33);
            this.lbl_texto1.TabIndex = 0;
            this.lbl_texto1.Text = "PRUEBA DE SUMA";
            // 
            // btn_sumar
            // 
            this.btn_sumar.Location = new System.Drawing.Point(394, 167);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(121, 49);
            this.btn_sumar.TabIndex = 1;
            this.btn_sumar.Text = "SUMAR";
            this.btn_sumar.UseVisualStyleBackColor = true;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click);
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(178, 153);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(166, 20);
            this.txt_numero1.TabIndex = 2;
            this.txt_numero1.TextChanged += new System.EventHandler(this.txt_numero1_TextChanged);
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(178, 223);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(166, 20);
            this.txt_numero2.TabIndex = 3;
            this.txt_numero2.TextChanged += new System.EventHandler(this.txt_numero2_TextChanged);
            // 
            // lbl_numero1
            // 
            this.lbl_numero1.AutoSize = true;
            this.lbl_numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero1.Location = new System.Drawing.Point(97, 125);
            this.lbl_numero1.Name = "lbl_numero1";
            this.lbl_numero1.Size = new System.Drawing.Size(167, 25);
            this.lbl_numero1.TabIndex = 4;
            this.lbl_numero1.Text = "Primer Número: ";
            this.lbl_numero1.Click += new System.EventHandler(this.lbl_numero1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Segundo Número: ";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(297, 318);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 39);
            this.lbl_resultado.TabIndex = 6;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(537, 167);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(115, 49);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_numero1);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.btn_sumar);
            this.Controls.Add(this.lbl_texto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_texto1;
        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.Label lbl_numero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_limpiar;
    }
}

