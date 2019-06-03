namespace View1
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.ButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.ButtonFakeDataEmployees = new System.Windows.Forms.ToolStripButton();
            this.ButtonChange = new System.Windows.Forms.ToolStripButton();
            this.DataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonInformation = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAdd,
            this.ButtonDelete,
            this.ButtonFakeDataEmployees,
            this.ButtonChange,
            this.ButtonInformation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(24, 24);
            this.ButtonAdd.Text = "toolStripButton1";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(24, 24);
            this.ButtonDelete.Text = "toolStripButton2";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonFakeDataEmployees
            // 
            this.ButtonFakeDataEmployees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonFakeDataEmployees.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFakeDataEmployees.Image")));
            this.ButtonFakeDataEmployees.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonFakeDataEmployees.Name = "ButtonFakeDataEmployees";
            this.ButtonFakeDataEmployees.Size = new System.Drawing.Size(162, 24);
            this.ButtonFakeDataEmployees.Text = "Заполнение таблицы";
            this.ButtonFakeDataEmployees.Click += new System.EventHandler(this.ButtonFakeDataEmployees_Click);
            // 
            // ButtonChange
            // 
            this.ButtonChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonChange.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChange.Image")));
            this.ButtonChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(176, 24);
            this.ButtonChange.Text = "Изменение сотрудника";
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // DataGridViewEmployee
            // 
            this.DataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.Surname,
            this.Age,
            this.Salary,
            this.Status,
            this.Prize});
            this.DataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewEmployee.Location = new System.Drawing.Point(0, 27);
            this.DataGridViewEmployee.Name = "DataGridViewEmployee";
            this.DataGridViewEmployee.RowTemplate.Height = 24;
            this.DataGridViewEmployee.Size = new System.Drawing.Size(800, 423);
            this.DataGridViewEmployee.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Firstname";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Оклад";
            this.Salary.Name = "Salary";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // Prize
            // 
            this.Prize.DataPropertyName = "Prize";
            this.Prize.HeaderText = "Премия";
            this.Prize.Name = "Prize";
            // 
            // ButtonInformation
            // 
            this.ButtonInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonInformation.Image = ((System.Drawing.Image)(resources.GetObject("ButtonInformation.Image")));
            this.ButtonInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonInformation.Name = "ButtonInformation";
            this.ButtonInformation.Size = new System.Drawing.Size(156, 24);
            this.ButtonInformation.Text = "Общая информация";
            this.ButtonInformation.Click += new System.EventHandler(this.ButtonInformation_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewEmployee);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEmployee";
            this.Text = "Сотрудники";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton ButtonDelete;
        public System.Windows.Forms.ToolStripButton ButtonFakeDataEmployees;
        public System.Windows.Forms.ToolStripButton ButtonAdd;
        public System.Windows.Forms.ToolStripButton ButtonChange;
        public System.Windows.Forms.DataGridView DataGridViewEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prize;
        public System.Windows.Forms.ToolStripButton ButtonInformation;
    }
}

