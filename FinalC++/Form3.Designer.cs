namespace FinalC__
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.textarticulo = new System.Windows.Forms.TextBox();
            this.texcantidad = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelmensajes = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // textarticulo
            // 
            this.textarticulo.Location = new System.Drawing.Point(214, 88);
            this.textarticulo.Name = "textarticulo";
            this.textarticulo.Size = new System.Drawing.Size(100, 29);
            this.textarticulo.TabIndex = 3;
            // 
            // texcantidad
            // 
            this.texcantidad.Location = new System.Drawing.Point(214, 133);
            this.texcantidad.Name = "texcantidad";
            this.texcantidad.Size = new System.Drawing.Size(100, 29);
            this.texcantidad.TabIndex = 4;
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(214, 179);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(100, 29);
            this.textprecio.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelmensajes
            // 
            this.labelmensajes.ForeColor = System.Drawing.Color.Red;
            this.labelmensajes.Location = new System.Drawing.Point(127, 50);
            this.labelmensajes.Name = "labelmensajes";
            this.labelmensajes.Size = new System.Drawing.Size(64, 21);
            this.labelmensajes.TabIndex = 7;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(12, 290);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(30, 17);
            this.info.TabIndex = 8;
            this.info.Text = "info";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(696, 401);
            this.Controls.Add(this.info);
            this.Controls.Add(this.labelmensajes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.texcantidad);
            this.Controls.Add(this.textarticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Total de ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textarticulo;
        private System.Windows.Forms.TextBox texcantidad;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelmensajes;
        private System.Windows.Forms.Label info;
    }
}