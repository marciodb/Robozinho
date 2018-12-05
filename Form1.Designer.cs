namespace OrientacaoObjeto
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bFeliz = new System.Windows.Forms.Button();
            this.bTriste = new System.Windows.Forms.Button();
            this.bDesconfiado = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "O";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "(____)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bFeliz
            // 
            this.bFeliz.Location = new System.Drawing.Point(10, 230);
            this.bFeliz.Name = "bFeliz";
            this.bFeliz.Size = new System.Drawing.Size(75, 23);
            this.bFeliz.TabIndex = 3;
            this.bFeliz.Text = "Feliz";
            this.bFeliz.UseVisualStyleBackColor = true;
            this.bFeliz.Click += new System.EventHandler(this.bFeliz_Click);
            // 
            // bTriste
            // 
            this.bTriste.Location = new System.Drawing.Point(109, 231);
            this.bTriste.Name = "bTriste";
            this.bTriste.Size = new System.Drawing.Size(75, 23);
            this.bTriste.TabIndex = 4;
            this.bTriste.Text = "Dormindo";
            this.bTriste.UseVisualStyleBackColor = true;
            this.bTriste.Click += new System.EventHandler(this.bTriste_Click);
            // 
            // bDesconfiado
            // 
            this.bDesconfiado.Location = new System.Drawing.Point(203, 231);
            this.bDesconfiado.Name = "bDesconfiado";
            this.bDesconfiado.Size = new System.Drawing.Size(75, 23);
            this.bDesconfiado.TabIndex = 5;
            this.bDesconfiado.Text = "Desconfiado";
            this.bDesconfiado.UseVisualStyleBackColor = true;
            this.bDesconfiado.Click += new System.EventHandler(this.bDesconfiado_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(118, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 23);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.bDesconfiado);
            this.Controls.Add(this.bTriste);
            this.Controls.Add(this.bFeliz);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bFeliz;
        private System.Windows.Forms.Button bTriste;
        private System.Windows.Forms.Button bDesconfiado;
        private System.Windows.Forms.Button button7;
    }
}

