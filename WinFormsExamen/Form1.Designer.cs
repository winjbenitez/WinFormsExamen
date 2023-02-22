namespace WinFormsExamen
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_R_altura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_R_base = new System.Windows.Forms.TextBox();
            this.btn_push_rectangulo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_T_altura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_T_base = new System.Windows.Forms.TextBox();
            this.btn_push_Triangulo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_P_altura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_P_base = new System.Windows.Forms.TextBox();
            this.btn_push_paralelogramo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_stack = new System.Windows.Forms.Label();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_R_altura);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_R_base);
            this.groupBox3.Controls.Add(this.btn_push_rectangulo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 265);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rectagulo";
            // 
            // txt_R_altura
            // 
            this.txt_R_altura.Location = new System.Drawing.Point(72, 95);
            this.txt_R_altura.Name = "txt_R_altura";
            this.txt_R_altura.Size = new System.Drawing.Size(125, 27);
            this.txt_R_altura.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Altura";
            // 
            // txt_R_base
            // 
            this.txt_R_base.Location = new System.Drawing.Point(72, 65);
            this.txt_R_base.Name = "txt_R_base";
            this.txt_R_base.Size = new System.Drawing.Size(125, 27);
            this.txt_R_base.TabIndex = 3;
            // 
            // btn_push_rectangulo
            // 
            this.btn_push_rectangulo.Location = new System.Drawing.Point(64, 128);
            this.btn_push_rectangulo.Name = "btn_push_rectangulo";
            this.btn_push_rectangulo.Size = new System.Drawing.Size(133, 36);
            this.btn_push_rectangulo.TabIndex = 2;
            this.btn_push_rectangulo.Text = "PUSH";
            this.btn_push_rectangulo.UseVisualStyleBackColor = true;
            this.btn_push_rectangulo.Click += new System.EventHandler(this.btn_push_rectangulo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Base";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_T_altura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_T_base);
            this.groupBox1.Controls.Add(this.btn_push_Triangulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(224, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 265);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangulo";
            // 
            // txt_T_altura
            // 
            this.txt_T_altura.Location = new System.Drawing.Point(72, 95);
            this.txt_T_altura.Name = "txt_T_altura";
            this.txt_T_altura.Size = new System.Drawing.Size(125, 27);
            this.txt_T_altura.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Altura";
            // 
            // txt_T_base
            // 
            this.txt_T_base.Location = new System.Drawing.Point(72, 65);
            this.txt_T_base.Name = "txt_T_base";
            this.txt_T_base.Size = new System.Drawing.Size(125, 27);
            this.txt_T_base.TabIndex = 3;
            // 
            // btn_push_Triangulo
            // 
            this.btn_push_Triangulo.Location = new System.Drawing.Point(64, 128);
            this.btn_push_Triangulo.Name = "btn_push_Triangulo";
            this.btn_push_Triangulo.Size = new System.Drawing.Size(133, 36);
            this.btn_push_Triangulo.TabIndex = 2;
            this.btn_push_Triangulo.Text = "PUSH";
            this.btn_push_Triangulo.UseVisualStyleBackColor = true;
            this.btn_push_Triangulo.Click += new System.EventHandler(this.btn_push_Triangulo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Base";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_P_altura);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_P_base);
            this.groupBox2.Controls.Add(this.btn_push_paralelogramo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(436, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 265);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paralelogramo";
            // 
            // txt_P_altura
            // 
            this.txt_P_altura.Location = new System.Drawing.Point(72, 95);
            this.txt_P_altura.Name = "txt_P_altura";
            this.txt_P_altura.Size = new System.Drawing.Size(125, 27);
            this.txt_P_altura.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Altura";
            // 
            // txt_P_base
            // 
            this.txt_P_base.Location = new System.Drawing.Point(72, 65);
            this.txt_P_base.Name = "txt_P_base";
            this.txt_P_base.Size = new System.Drawing.Size(125, 27);
            this.txt_P_base.TabIndex = 3;
            // 
            // btn_push_paralelogramo
            // 
            this.btn_push_paralelogramo.Location = new System.Drawing.Point(64, 128);
            this.btn_push_paralelogramo.Name = "btn_push_paralelogramo";
            this.btn_push_paralelogramo.Size = new System.Drawing.Size(133, 36);
            this.btn_push_paralelogramo.TabIndex = 2;
            this.btn_push_paralelogramo.Text = "PUSH";
            this.btn_push_paralelogramo.UseVisualStyleBackColor = true;
            this.btn_push_paralelogramo.Click += new System.EventHandler(this.btn_push_paralelogramo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Base";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_stack);
            this.groupBox5.Controls.Add(this.btn_Mostrar);
            this.groupBox5.Location = new System.Drawing.Point(705, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 268);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stack";
            // 
            // lbl_stack
            // 
            this.lbl_stack.AutoSize = true;
            this.lbl_stack.Location = new System.Drawing.Point(16, 67);
            this.lbl_stack.Name = "lbl_stack";
            this.lbl_stack.Size = new System.Drawing.Size(0, 20);
            this.lbl_stack.TabIndex = 1;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(14, 29);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(133, 29);
            this.btn_Mostrar.TabIndex = 0;
            this.btn_Mostrar.Text = "MOSTRAR PILA";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 399);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form Examen Josue Benitez";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_R_altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_R_base;
        private System.Windows.Forms.Button btn_push_rectangulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_T_altura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_T_base;
        private System.Windows.Forms.Button btn_push_Triangulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_P_altura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_P_base;
        private System.Windows.Forms.Button btn_push_paralelogramo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_stack;
        private System.Windows.Forms.Button btn_Mostrar;
    }
}
