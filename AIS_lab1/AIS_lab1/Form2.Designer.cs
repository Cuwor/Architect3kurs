namespace AIS_lab1
{
    partial class Form2
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
            this.ProjectOfEmp = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.Label();
            this.AddProjForEmp = new System.Windows.Forms.Button();
            this.DelProjForEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectOfEmp
            // 
            this.ProjectOfEmp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProjectOfEmp.LabelWrap = false;
            this.ProjectOfEmp.Location = new System.Drawing.Point(12, 34);
            this.ProjectOfEmp.MultiSelect = false;
            this.ProjectOfEmp.Name = "ProjectOfEmp";
            this.ProjectOfEmp.Size = new System.Drawing.Size(199, 207);
            this.ProjectOfEmp.TabIndex = 1;
            this.ProjectOfEmp.UseCompatibleStateImageBehavior = false;
            this.ProjectOfEmp.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Проекты сотрудника:";
            // 
            // EmpName
            // 
            this.EmpName.AutoSize = true;
            this.EmpName.Location = new System.Drawing.Point(165, 9);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(20, 17);
            this.EmpName.TabIndex = 7;
            this.EmpName.Text = "...";
            // 
            // AddProjForEmp
            // 
            this.AddProjForEmp.Location = new System.Drawing.Point(217, 34);
            this.AddProjForEmp.Name = "AddProjForEmp";
            this.AddProjForEmp.Size = new System.Drawing.Size(89, 23);
            this.AddProjForEmp.TabIndex = 8;
            this.AddProjForEmp.Text = "Добавить";
            this.AddProjForEmp.UseVisualStyleBackColor = true;
            this.AddProjForEmp.Click += new System.EventHandler(this.AddProjForEmp_Click);
            // 
            // DelProjForEmp
            // 
            this.DelProjForEmp.Location = new System.Drawing.Point(217, 63);
            this.DelProjForEmp.Name = "DelProjForEmp";
            this.DelProjForEmp.Size = new System.Drawing.Size(89, 23);
            this.DelProjForEmp.TabIndex = 9;
            this.DelProjForEmp.Text = "Убрать";
            this.DelProjForEmp.UseVisualStyleBackColor = true;
            this.DelProjForEmp.Click += new System.EventHandler(this.DelProjForEmp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 254);
            this.Controls.Add(this.DelProjForEmp);
            this.Controls.Add(this.AddProjForEmp);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectOfEmp);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProjectOfEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmpName;
        private System.Windows.Forms.Button AddProjForEmp;
        private System.Windows.Forms.Button DelProjForEmp;
    }
}