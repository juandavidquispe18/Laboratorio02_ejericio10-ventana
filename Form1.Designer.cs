namespace Laboratorio02_ejericio10_ventana
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
            button1 = new Button();
            txtBox01 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(157, 165);
            button1.Name = "button1";
            button1.Size = new Size(160, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular Importe Total";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBox01
            // 
            txtBox01.Location = new Point(278, 112);
            txtBox01.Name = "txtBox01";
            txtBox01.Size = new Size(109, 23);
            txtBox01.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 63);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 3;
            label2.Text = "DETERMINAR DESCUENTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 115);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese monto de consumo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 265);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtBox01);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtBox01;
        private Label label2;
        private Label label1;
    }
}