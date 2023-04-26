namespace WF
{
    partial class Calc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputY = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(13, 13);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(100, 20);
            this.inputX.TabIndex = 0;
            this.inputX.Text = "x";
            // 
            // inputY
            // 
            this.inputY.Location = new System.Drawing.Point(13, 40);
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(100, 20);
            this.inputY.TabIndex = 1;
            this.inputY.Text = "y";
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(13, 67);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(20, 23);
            this.addition.TabIndex = 2;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(39, 67);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(20, 23);
            this.substraction.TabIndex = 3;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(65, 67);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(20, 23);
            this.multiplication.TabIndex = 4;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(93, 67);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(20, 23);
            this.divide.TabIndex = 5;
            this.divide.Text = ":";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 103);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.inputY);
            this.Controls.Add(this.inputX);
            this.Name = "Calc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputY;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button divide;
    }
}

