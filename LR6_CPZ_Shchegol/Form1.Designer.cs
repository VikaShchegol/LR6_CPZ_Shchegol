namespace LR6_CPZ_Shchegol
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Змінна X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Змінна X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат розрахуну Y";
            // 
            // tbX1
            // 
            this.tbX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbX1.Location = new System.Drawing.Point(258, 39);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(115, 23);
            this.tbX1.TabIndex = 3;
            // 
            // tbX2
            // 
            this.tbX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbX2.Location = new System.Drawing.Point(258, 82);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(115, 23);
            this.tbX2.TabIndex = 4;
            // 
            // tbY
            // 
            this.tbY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbY.Location = new System.Drawing.Point(258, 130);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(115, 23);
            this.tbY.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Lavender;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCalculate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalculate.Location = new System.Drawing.Point(32, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 30);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Lavender;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnClear.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnClear.Location = new System.Drawing.Point(169, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(299, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(40, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Більше із значень";
            // 
            // tbMax
            // 
            this.tbMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbMax.Location = new System.Drawing.Point(258, 178);
            this.tbMax.Name = "tbMax";
            this.tbMax.ReadOnly = true;
            this.tbMax.Size = new System.Drawing.Size(115, 23);
            this.tbMax.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(423, 314);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMax;
    }
}

