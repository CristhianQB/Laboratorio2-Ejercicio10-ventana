namespace Laboratorio2_Ejercicio10_ventana
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
            label1 = new System.Windows.Forms.Label();
            txtb = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lbl6 = new System.Windows.Forms.Label();
            lbl7 = new System.Windows.Forms.Label();
            lbl8 = new System.Windows.Forms.Label();
            lbl9 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Consumo :";
            // 
            // txtb
            // 
            txtb.Location = new System.Drawing.Point(167, 47);
            txtb.Name = "txtb";
            txtb.Size = new System.Drawing.Size(170, 23);
            txtb.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(123, 117);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(147, 38);
            button1.TabIndex = 2;
            button1.Text = "Total";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(100, 204);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Descuento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(100, 261);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Sub total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(100, 315);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Impuesto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(100, 369);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 15);
            label5.TabIndex = 6;
            label5.Text = "Importe a pagar";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new System.Drawing.Point(232, 204);
            lbl6.Name = "lbl6";
            lbl6.Size = new System.Drawing.Size(13, 15);
            lbl6.TabIndex = 7;
            lbl6.Text = "0";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new System.Drawing.Point(232, 261);
            lbl7.Name = "lbl7";
            lbl7.Size = new System.Drawing.Size(13, 15);
            lbl7.TabIndex = 8;
            lbl7.Text = "0";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Location = new System.Drawing.Point(232, 315);
            lbl8.Name = "lbl8";
            lbl8.Size = new System.Drawing.Size(13, 15);
            lbl8.TabIndex = 9;
            lbl8.Text = "0";
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Location = new System.Drawing.Point(232, 369);
            lbl9.Name = "lbl9";
            lbl9.Size = new System.Drawing.Size(13, 15);
            lbl9.TabIndex = 10;
            lbl9.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(514, 450);
            Controls.Add(lbl9);
            Controls.Add(lbl8);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtb);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
    }
}
