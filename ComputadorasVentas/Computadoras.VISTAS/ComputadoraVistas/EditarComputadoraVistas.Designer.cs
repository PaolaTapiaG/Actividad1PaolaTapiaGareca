namespace Computadoras.VISTAS.ComputadoraVistas
{
    partial class EditarComputadoraVistas
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
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(231, 204);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(307, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(376, 328);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 29;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(164, 328);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 28;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(243, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 27);
            textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 204);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 24;
            label4.Text = "FECHA DE FABRICACION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 157);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 23;
            label3.Text = "PRECIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 115);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 22;
            label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 71);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 21;
            label1.Text = "NOMBRE";
            // 
            // EditarComputadoraVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditarComputadoraVistas";
            Text = "EditarComputadoraVistas";
            Load += EditarComputadoraVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}