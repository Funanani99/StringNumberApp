namespace StringNumberApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblExchangeResult = new System.Windows.Forms.Label();
            this.lblNumberResult = new System.Windows.Forms.Label();
            this.lblFizzBuzzResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // lblExchangeResult
            // 
            this.lblExchangeResult.AutoSize = true;
            this.lblExchangeResult.BackColor = System.Drawing.Color.Gainsboro;
            this.lblExchangeResult.Location = new System.Drawing.Point(60, 320);
            this.lblExchangeResult.Name = "lblExchangeResult";
            this.lblExchangeResult.Size = new System.Drawing.Size(51, 20);
            this.lblExchangeResult.TabIndex = 4;
            this.lblExchangeResult.Text = "label1";
            // 
            // lblNumberResult
            // 
            this.lblNumberResult.AutoSize = true;
            this.lblNumberResult.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNumberResult.Location = new System.Drawing.Point(365, 334);
            this.lblNumberResult.Name = "lblNumberResult";
            this.lblNumberResult.Size = new System.Drawing.Size(51, 20);
            this.lblNumberResult.TabIndex = 5;
            this.lblNumberResult.Text = "label2";
            // 
            // lblFizzBuzzResult
            // 
            this.lblFizzBuzzResult.AutoSize = true;
            this.lblFizzBuzzResult.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFizzBuzzResult.Location = new System.Drawing.Point(645, 333);
            this.lblFizzBuzzResult.Name = "lblFizzBuzzResult";
            this.lblFizzBuzzResult.Size = new System.Drawing.Size(51, 20);
            this.lblFizzBuzzResult.TabIndex = 6;
            this.lblFizzBuzzResult.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFizzBuzzResult);
            this.Controls.Add(this.lblNumberResult);
            this.Controls.Add(this.lblExchangeResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "String Number App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblExchangeResult;
        private System.Windows.Forms.Label lblNumberResult;
        private System.Windows.Forms.Label lblFizzBuzzResult;
    }
}

