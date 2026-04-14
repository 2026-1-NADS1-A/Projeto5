namespace Entrega_pi
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
            lblusuario = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnip = new Button();
            btnverificar = new Button();
            txtretorno = new TextBox();
            SuspendLayout();
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(12, 19);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(157, 17);
            lblusuario.TabIndex = 0;
            lblusuario.Text = "Digite seu ip da maquina:";
            lblusuario.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(537, 14);
            label1.Name = "label1";
            label1.Size = new Size(155, 17);
            label1.TabIndex = 2;
            label1.Text = "Como posso ver meu ip?";
            label1.Click += label1_Click_1;
            // 
            // btnip
            // 
            btnip.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnip.ImageAlign = ContentAlignment.TopCenter;
            btnip.Location = new Point(694, 10);
            btnip.Name = "btnip";
            btnip.Size = new Size(94, 25);
            btnip.TabIndex = 3;
            btnip.Text = "Clique aqui";
            btnip.UseVisualStyleBackColor = true;
            btnip.Click += btnip_Click;
            // 
            // btnverificar
            // 
            btnverificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnverificar.Location = new Point(288, 48);
            btnverificar.Name = "btnverificar";
            btnverificar.Size = new Size(75, 23);
            btnverificar.TabIndex = 4;
            btnverificar.Text = "Verificar";
            btnverificar.UseVisualStyleBackColor = true;
            btnverificar.Click += btnverificar_click;
            // 
            // txtretorno
            // 
            txtretorno.AccessibleRole = AccessibleRole.None;
            txtretorno.Location = new Point(173, 88);
            txtretorno.Multiline = true;
            txtretorno.Name = "txtretorno";
            txtretorno.ReadOnly = true;
            txtretorno.Size = new Size(313, 138);
            txtretorno.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(txtretorno);
            Controls.Add(btnverificar);
            Controls.Add(btnip);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblusuario);
            Name = "Form1";
            Text = "s";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusuario;
        private TextBox textBox1;
        private Label label1;
        private Button btnip;
        private Button btnverificar;
        private TextBox txtretorno;
    }
}
