namespace WindowsFormsApp1
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
            this.emplLB = new System.Windows.Forms.ListBox();
            this.AgeLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emplLB
            // 
            this.emplLB.FormattingEnabled = true;
            this.emplLB.Location = new System.Drawing.Point(12, 12);
            this.emplLB.Name = "emplLB";
            this.emplLB.Size = new System.Drawing.Size(232, 420);
            this.emplLB.TabIndex = 1;
            // 
            // AgeLB
            // 
            this.AgeLB.FormattingEnabled = true;
            this.AgeLB.Location = new System.Drawing.Point(284, 15);
            this.AgeLB.Name = "AgeLB";
            this.AgeLB.Size = new System.Drawing.Size(232, 420);
            this.AgeLB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Средний доход";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(610, 15);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(0, 13);
            this.labelSalary.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeLB);
            this.Controls.Add(this.emplLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox emplLB;
        private System.Windows.Forms.ListBox AgeLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSalary;
    }
}

