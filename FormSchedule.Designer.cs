
namespace Qualification
{
    partial class FormSchedule
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.средаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet22 = new Qualification.QualificationDataSet22();
            this.четвергBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet23 = new Qualification.QualificationDataSet23();
            this.пятницаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet24 = new Qualification.QualificationDataSet24();
            this.понедельникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet20 = new Qualification.QualificationDataSet20();
            this.вторникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet21 = new Qualification.QualificationDataSet21();
            this.понедельникTableAdapter = new Qualification.QualificationDataSet20TableAdapters.ПонедельникTableAdapter();
            this.вторникTableAdapter = new Qualification.QualificationDataSet21TableAdapters.ВторникTableAdapter();
            this.средаTableAdapter = new Qualification.QualificationDataSet22TableAdapters.СредаTableAdapter();
            this.четвергTableAdapter = new Qualification.QualificationDataSet23TableAdapters.ЧетвергTableAdapter();
            this.пятницаTableAdapter = new Qualification.QualificationDataSet24TableAdapters.ПятницаTableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.средаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.четвергBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пятницаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.понедельникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вторникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 30);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(33, 163);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 107);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Понедельник";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-64, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(665, 98);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вторник";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-65, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(665, 106);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(600, 72);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Среда";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-63, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(663, 109);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(600, 72);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Четверг";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(-65, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(665, 98);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(600, 72);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Пятница";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(-65, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.RowTemplate.Height = 28;
            this.dataGridView5.Size = new System.Drawing.Size(665, 98);
            this.dataGridView5.TabIndex = 0;
            // 
            // средаBindingSource
            // 
            this.средаBindingSource.DataMember = "Среда";
            this.средаBindingSource.DataSource = this.qualificationDataSet22;
            // 
            // qualificationDataSet22
            // 
            this.qualificationDataSet22.DataSetName = "QualificationDataSet22";
            this.qualificationDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // четвергBindingSource
            // 
            this.четвергBindingSource.DataMember = "Четверг";
            this.четвергBindingSource.DataSource = this.qualificationDataSet23;
            // 
            // qualificationDataSet23
            // 
            this.qualificationDataSet23.DataSetName = "QualificationDataSet23";
            this.qualificationDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пятницаBindingSource
            // 
            this.пятницаBindingSource.DataMember = "Пятница";
            this.пятницаBindingSource.DataSource = this.qualificationDataSet24;
            // 
            // qualificationDataSet24
            // 
            this.qualificationDataSet24.DataSetName = "QualificationDataSet24";
            this.qualificationDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // понедельникBindingSource
            // 
            this.понедельникBindingSource.DataMember = "Понедельник";
            this.понедельникBindingSource.DataSource = this.qualificationDataSet20;
            // 
            // qualificationDataSet20
            // 
            this.qualificationDataSet20.DataSetName = "QualificationDataSet20";
            this.qualificationDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вторникBindingSource
            // 
            this.вторникBindingSource.DataMember = "Вторник";
            this.вторникBindingSource.DataSource = this.qualificationDataSet21;
            // 
            // qualificationDataSet21
            // 
            this.qualificationDataSet21.DataSetName = "QualificationDataSet21";
            this.qualificationDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // понедельникTableAdapter
            // 
            this.понедельникTableAdapter.ClearBeforeFill = true;
            // 
            // вторникTableAdapter
            // 
            this.вторникTableAdapter.ClearBeforeFill = true;
            // 
            // средаTableAdapter
            // 
            this.средаTableAdapter.ClearBeforeFill = true;
            // 
            // четвергTableAdapter
            // 
            this.четвергTableAdapter.ClearBeforeFill = true;
            // 
            // пятницаTableAdapter
            // 
            this.пятницаTableAdapter.ClearBeforeFill = true;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Lavender;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(552, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 43);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Расписание";
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormSchedule";
            this.Text = "Личный кабинет студента";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.средаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.четвергBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пятницаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.понедельникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вторникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private QualificationDataSet20 qualificationDataSet20;
        private System.Windows.Forms.BindingSource понедельникBindingSource;
        private QualificationDataSet20TableAdapters.ПонедельникTableAdapter понедельникTableAdapter;
        private QualificationDataSet21 qualificationDataSet21;
        private System.Windows.Forms.BindingSource вторникBindingSource;
        private QualificationDataSet21TableAdapters.ВторникTableAdapter вторникTableAdapter;
        private QualificationDataSet22 qualificationDataSet22;
        private System.Windows.Forms.BindingSource средаBindingSource;
        private QualificationDataSet22TableAdapters.СредаTableAdapter средаTableAdapter;
        private QualificationDataSet23 qualificationDataSet23;
        private System.Windows.Forms.BindingSource четвергBindingSource;
        private QualificationDataSet23TableAdapters.ЧетвергTableAdapter четвергTableAdapter;
        private QualificationDataSet24 qualificationDataSet24;
        private System.Windows.Forms.BindingSource пятницаBindingSource;
        private QualificationDataSet24TableAdapters.ПятницаTableAdapter пятницаTableAdapter;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
    }
}