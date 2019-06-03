namespace View1
{
    partial class FormAddEmployee
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
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.TextBoxPrize = new System.Windows.Forms.TextBox();
            this.TextBoxSalary = new System.Windows.Forms.TextBox();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.TextBoxFirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCancle = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.DisplayMember = "Status";
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Location = new System.Drawing.Point(113, 180);
            this.ComboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(203, 24);
            this.ComboBoxStatus.TabIndex = 27;
            this.ComboBoxStatus.ValueMember = "Status";
            // 
            // TextBoxPrize
            // 
            this.TextBoxPrize.Location = new System.Drawing.Point(113, 217);
            this.TextBoxPrize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPrize.Name = "TextBoxPrize";
            this.TextBoxPrize.Size = new System.Drawing.Size(203, 22);
            this.TextBoxPrize.TabIndex = 26;
            this.TextBoxPrize.TextChanged += new System.EventHandler(this.TextBoxPrize_TextChanged);
            // 
            // TextBoxSalary
            // 
            this.TextBoxSalary.Location = new System.Drawing.Point(113, 140);
            this.TextBoxSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSalary.Name = "TextBoxSalary";
            this.TextBoxSalary.Size = new System.Drawing.Size(203, 22);
            this.TextBoxSalary.TabIndex = 25;
            this.TextBoxSalary.TextChanged += new System.EventHandler(this.TextBoxSalary_TextChanged);
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.Location = new System.Drawing.Point(113, 97);
            this.TextBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(203, 22);
            this.TextBoxAge.TabIndex = 24;
            this.TextBoxAge.TextChanged += new System.EventHandler(this.TextBoxAge_TextChanged);
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(113, 57);
            this.TextBoxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(203, 22);
            this.TextBoxSurname.TabIndex = 23;
            // 
            // TextBoxFirstname
            // 
            this.TextBoxFirstname.Location = new System.Drawing.Point(113, 17);
            this.TextBoxFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxFirstname.Name = "TextBoxFirstname";
            this.TextBoxFirstname.Size = new System.Drawing.Size(203, 22);
            this.TextBoxFirstname.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Премия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Оклад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Возраст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Имя";
            // 
            // ButtonCancle
            // 
            this.ButtonCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancle.Location = new System.Drawing.Point(195, 274);
            this.ButtonCancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancle.Name = "ButtonCancle";
            this.ButtonCancle.Size = new System.Drawing.Size(93, 31);
            this.ButtonCancle.TabIndex = 15;
            this.ButtonCancle.Text = "Отмена";
            this.ButtonCancle.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAdd.Location = new System.Drawing.Point(45, 274);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(93, 31);
            this.ButtonAdd.TabIndex = 14;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 341);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.TextBoxPrize);
            this.Controls.Add(this.TextBoxSalary);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.TextBoxFirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCancle);
            this.Controls.Add(this.ButtonAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddEmployee";
            this.Text = "Добавление Сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button ButtonCancle;
        public System.Windows.Forms.Button ButtonAdd;
        public System.Windows.Forms.ComboBox ComboBoxStatus;
        public System.Windows.Forms.TextBox TextBoxPrize;
        public System.Windows.Forms.TextBox TextBoxSalary;
        public System.Windows.Forms.TextBox TextBoxAge;
        public System.Windows.Forms.TextBox TextBoxSurname;
        public System.Windows.Forms.TextBox TextBoxFirstname;
    }
}