namespace AIS_lab1
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
            this.AcceptedEmps = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Fine = new System.Windows.Forms.Button();
            this.Premium = new System.Windows.Forms.Button();
            this.BadBonus = new System.Windows.Forms.TextBox();
            this.Bonus = new System.Windows.Forms.TextBox();
            this.AcceptedEmps2 = new System.Windows.Forms.ComboBox();
            this.AcceptedEmps1 = new System.Windows.Forms.ComboBox();
            this.EmpsForFire = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.Fire = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.EmpsForAccept = new System.Windows.Forms.ComboBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.ShowProjects = new System.Windows.Forms.Button();
            this.AllProjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcceptedEmps
            // 
            this.AcceptedEmps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AcceptedEmps.LabelWrap = false;
            this.AcceptedEmps.Location = new System.Drawing.Point(12, 29);
            this.AcceptedEmps.MultiSelect = false;
            this.AcceptedEmps.Name = "AcceptedEmps";
            this.AcceptedEmps.Size = new System.Drawing.Size(199, 207);
            this.AcceptedEmps.TabIndex = 0;
            this.AcceptedEmps.UseCompatibleStateImageBehavior = false;
            this.AcceptedEmps.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список числящихся сотрудников";
            // 
            // Fine
            // 
            this.Fine.Location = new System.Drawing.Point(503, 149);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(118, 23);
            this.Fine.TabIndex = 7;
            this.Fine.Text = "Оштрафовать";
            this.Fine.UseVisualStyleBackColor = true;
            this.Fine.Click += new System.EventHandler(this.Fine_Click);
            // 
            // Premium
            // 
            this.Premium.Location = new System.Drawing.Point(503, 117);
            this.Premium.Name = "Premium";
            this.Premium.Size = new System.Drawing.Size(118, 23);
            this.Premium.TabIndex = 9;
            this.Premium.Text = "Премировать";
            this.Premium.UseVisualStyleBackColor = true;
            this.Premium.Click += new System.EventHandler(this.Premium_Click);
            // 
            // BadBonus
            // 
            this.BadBonus.Location = new System.Drawing.Point(422, 149);
            this.BadBonus.Name = "BadBonus";
            this.BadBonus.Size = new System.Drawing.Size(75, 22);
            this.BadBonus.TabIndex = 11;
            // 
            // Bonus
            // 
            this.Bonus.Location = new System.Drawing.Point(422, 119);
            this.Bonus.Name = "Bonus";
            this.Bonus.Size = new System.Drawing.Size(75, 22);
            this.Bonus.TabIndex = 10;
            // 
            // AcceptedEmps2
            // 
            this.AcceptedEmps2.FormattingEnabled = true;
            this.AcceptedEmps2.Location = new System.Drawing.Point(220, 147);
            this.AcceptedEmps2.Name = "AcceptedEmps2";
            this.AcceptedEmps2.Size = new System.Drawing.Size(196, 24);
            this.AcceptedEmps2.TabIndex = 6;
            // 
            // AcceptedEmps1
            // 
            this.AcceptedEmps1.FormattingEnabled = true;
            this.AcceptedEmps1.Location = new System.Drawing.Point(220, 117);
            this.AcceptedEmps1.Name = "AcceptedEmps1";
            this.AcceptedEmps1.Size = new System.Drawing.Size(196, 24);
            this.AcceptedEmps1.TabIndex = 8;
            // 
            // EmpsForFire
            // 
            this.EmpsForFire.FormattingEnabled = true;
            this.EmpsForFire.Location = new System.Drawing.Point(220, 87);
            this.EmpsForFire.Name = "EmpsForFire";
            this.EmpsForFire.Size = new System.Drawing.Size(196, 24);
            this.EmpsForFire.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Средняя зп:";
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(311, 222);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(20, 17);
            this.Average.TabIndex = 13;
            this.Average.Text = "...";
            // 
            // Fire
            // 
            this.Fire.Location = new System.Drawing.Point(422, 87);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(89, 23);
            this.Fire.TabIndex = 2;
            this.Fire.Text = "Уволить";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(422, 57);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(89, 23);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "Принять";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Fill
            // 
            this.Fill.Location = new System.Drawing.Point(301, 29);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(210, 23);
            this.Fill.TabIndex = 15;
            this.Fill.Text = "Заполнить коллекцию";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // EmpsForAccept
            // 
            this.EmpsForAccept.FormattingEnabled = true;
            this.EmpsForAccept.Location = new System.Drawing.Point(220, 57);
            this.EmpsForAccept.Name = "EmpsForAccept";
            this.EmpsForAccept.Size = new System.Drawing.Size(196, 24);
            this.EmpsForAccept.TabIndex = 3;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(220, 29);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(75, 22);
            this.Count.TabIndex = 14;
            // 
            // ShowProjects
            // 
            this.ShowProjects.Location = new System.Drawing.Point(220, 177);
            this.ShowProjects.Name = "ShowProjects";
            this.ShowProjects.Size = new System.Drawing.Size(121, 23);
            this.ShowProjects.TabIndex = 16;
            this.ShowProjects.Text = "Проекты";
            this.ShowProjects.UseVisualStyleBackColor = true;
            this.ShowProjects.Click += new System.EventHandler(this.ShowProjects_Click);
            // 
            // AllProjects
            // 
            this.AllProjects.Location = new System.Drawing.Point(347, 177);
            this.AllProjects.Name = "AllProjects";
            this.AllProjects.Size = new System.Drawing.Size(121, 23);
            this.AllProjects.TabIndex = 17;
            this.AllProjects.Text = "Все проекты";
            this.AllProjects.UseVisualStyleBackColor = true;
            this.AllProjects.Click += new System.EventHandler(this.AllProjects_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 248);
            this.Controls.Add(this.AllProjects);
            this.Controls.Add(this.ShowProjects);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BadBonus);
            this.Controls.Add(this.Bonus);
            this.Controls.Add(this.Premium);
            this.Controls.Add(this.AcceptedEmps1);
            this.Controls.Add(this.Fine);
            this.Controls.Add(this.AcceptedEmps2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.EmpsForAccept);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.EmpsForFire);
            this.Controls.Add(this.AcceptedEmps);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AcceptedEmps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Fine;
        private System.Windows.Forms.Button Premium;
        private System.Windows.Forms.TextBox BadBonus;
        private System.Windows.Forms.TextBox Bonus;
        private System.Windows.Forms.ComboBox AcceptedEmps2;
        private System.Windows.Forms.ComboBox AcceptedEmps1;
        private System.Windows.Forms.ComboBox EmpsForFire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.ComboBox EmpsForAccept;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Button ShowProjects;
        private System.Windows.Forms.Button AllProjects;
    }
}

