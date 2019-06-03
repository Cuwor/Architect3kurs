namespace AIS_lab1
{
    partial class Form3
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
            this.ListOfProj = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmpImProj = new System.Windows.Forms.Button();
            this.DelEmp = new System.Windows.Forms.Button();
            this.ListOfEmps = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProj = new System.Windows.Forms.Button();
            this.DelProj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListOfProj
            // 
            this.ListOfProj.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListOfProj.LabelWrap = false;
            this.ListOfProj.Location = new System.Drawing.Point(12, 36);
            this.ListOfProj.MultiSelect = false;
            this.ListOfProj.Name = "ListOfProj";
            this.ListOfProj.Size = new System.Drawing.Size(199, 207);
            this.ListOfProj.TabIndex = 2;
            this.ListOfProj.UseCompatibleStateImageBehavior = false;
            this.ListOfProj.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Проекты";
            // 
            // AddEmpImProj
            // 
            this.AddEmpImProj.Location = new System.Drawing.Point(422, 36);
            this.AddEmpImProj.Name = "AddEmpImProj";
            this.AddEmpImProj.Size = new System.Drawing.Size(189, 23);
            this.AddEmpImProj.TabIndex = 9;
            this.AddEmpImProj.Text = "Добавить сотрудника";
            this.AddEmpImProj.UseVisualStyleBackColor = true;
            this.AddEmpImProj.Click += new System.EventHandler(this.AddEmpImProj_Click);
            // 
            // DelEmp
            // 
            this.DelEmp.Location = new System.Drawing.Point(422, 65);
            this.DelEmp.Name = "DelEmp";
            this.DelEmp.Size = new System.Drawing.Size(189, 23);
            this.DelEmp.TabIndex = 11;
            this.DelEmp.Text = "Снять с проекта";
            this.DelEmp.UseVisualStyleBackColor = true;
            this.DelEmp.Click += new System.EventHandler(this.DelEmp_Click);
            // 
            // ListOfEmps
            // 
            this.ListOfEmps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListOfEmps.LabelWrap = false;
            this.ListOfEmps.Location = new System.Drawing.Point(217, 36);
            this.ListOfEmps.MultiSelect = false;
            this.ListOfEmps.Name = "ListOfEmps";
            this.ListOfEmps.Size = new System.Drawing.Size(199, 207);
            this.ListOfEmps.TabIndex = 12;
            this.ListOfEmps.UseCompatibleStateImageBehavior = false;
            this.ListOfEmps.View = System.Windows.Forms.View.Tile;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ответственные";
            // 
            // AddProj
            // 
            this.AddProj.Location = new System.Drawing.Point(422, 191);
            this.AddProj.Name = "AddProj";
            this.AddProj.Size = new System.Drawing.Size(189, 23);
            this.AddProj.TabIndex = 14;
            this.AddProj.Text = "Добавить проект";
            this.AddProj.UseVisualStyleBackColor = true;
            this.AddProj.Click += new System.EventHandler(this.AddProj_Click);
            // 
            // DelProj
            // 
            this.DelProj.Location = new System.Drawing.Point(422, 220);
            this.DelProj.Name = "DelProj";
            this.DelProj.Size = new System.Drawing.Size(189, 23);
            this.DelProj.TabIndex = 15;
            this.DelProj.Text = "Удалить проект";
            this.DelProj.UseVisualStyleBackColor = true;
            this.DelProj.Click += new System.EventHandler(this.DelProj_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 255);
            this.Controls.Add(this.DelProj);
            this.Controls.Add(this.AddProj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListOfEmps);
            this.Controls.Add(this.DelEmp);
            this.Controls.Add(this.AddEmpImProj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOfProj);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListOfProj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEmpImProj;
        private System.Windows.Forms.Button DelEmp;
        private System.Windows.Forms.ListView ListOfEmps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProj;
        private System.Windows.Forms.Button DelProj;
    }
}