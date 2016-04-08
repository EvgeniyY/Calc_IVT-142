namespace Calc_IVT142
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
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Squared = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Input1.Location = new System.Drawing.Point(12, 39);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(125, 20);
            this.Input1.TabIndex = 0;
            // 
            // Input2
            // 
            this.Input2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Input2.Location = new System.Drawing.Point(150, 39);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(125, 20);
            this.Input2.TabIndex = 1;
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Output.Location = new System.Drawing.Point(30, 196);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(220, 43);
            this.Output.TabIndex = 2;
            this.Output.Text = "=";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 86);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(60, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Action);
            // 
            // Substract
            // 
            this.Substract.Location = new System.Drawing.Point(78, 86);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(59, 23);
            this.Substract.TabIndex = 4;
            this.Substract.Text = "-";
            this.Substract.UseVisualStyleBackColor = true;
            this.Substract.Click += new System.EventHandler(this.Action);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(12, 128);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(59, 23);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Action);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(78, 128);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(59, 23);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Action);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(150, 86);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(59, 23);
            this.Sin.TabIndex = 7;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(150, 128);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(59, 23);
            this.Ln.TabIndex = 8;
            this.Ln.Text = "ln";
            this.Ln.UseVisualStyleBackColor = true;
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(216, 86);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(59, 23);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            // 
            // Squared
            // 
            this.Squared.Location = new System.Drawing.Point(216, 128);
            this.Squared.Name = "Squared";
            this.Squared.Size = new System.Drawing.Size(59, 23);
            this.Squared.TabIndex = 10;
            this.Squared.Text = "x^2";
            this.Squared.UseVisualStyleBackColor = true;
            this.Squared.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.Squared);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Squared;
    }
}

