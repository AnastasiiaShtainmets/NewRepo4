
namespace Qualification
{
    partial class FormStudent
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
            this.referenceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.табельстудентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet14 = new Qualification.QualificationDataSet14();
            this.табель_студентовTableAdapter = new Qualification.QualificationDataSet14TableAdapters.Табель_студентовTableAdapter();
            this.qualificationDataSet16 = new Qualification.QualificationDataSet16();
            this.стипендияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стипендияTableAdapter = new Qualification.QualificationDataSet16TableAdapters.СтипендияTableAdapter();
            this.qualificationDataSet17 = new Qualification.QualificationDataSet17();
            this.стипендияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.стипендияTableAdapter1 = new Qualification.QualificationDataSet17TableAdapters.СтипендияTableAdapter();
            this.стипендияBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet18 = new Qualification.QualificationDataSet18();
            this.стипендияTableAdapter2 = new Qualification.QualificationDataSet18TableAdapters.СтипендияTableAdapter();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.qualificationDataSet33 = new Qualification.QualificationDataSet33();
            this.стипендияBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.стипендияTableAdapter3 = new Qualification.QualificationDataSet33TableAdapters.СтипендияTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qualificationDataSet34 = new Qualification.QualificationDataSet34();
            this.стипендияBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.стипендияTableAdapter4 = new Qualification.QualificationDataSet34TableAdapters.СтипендияTableAdapter();
            this.starButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельстудентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceButton
            // 
            this.referenceButton.BackColor = System.Drawing.Color.Lavender;
            this.referenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.referenceButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.referenceButton.Location = new System.Drawing.Point(296, 331);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(142, 91);
            this.referenceButton.TabIndex = 0;
            this.referenceButton.Text = "Заказать справку ";
            this.referenceButton.UseVisualStyleBackColor = false;
            this.referenceButton.Click += new System.EventHandler(this.referenceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(201, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Успеваемость и стипендия";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(23, 93);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(726, 79);
            this.dataGridView3.TabIndex = 4;
            // 
            // табельстудентовBindingSource
            // 
            this.табельстудентовBindingSource.DataMember = "Табель_студентов";
            this.табельстудентовBindingSource.DataSource = this.qualificationDataSet14;
            // 
            // qualificationDataSet14
            // 
            this.qualificationDataSet14.DataSetName = "QualificationDataSet14";
            this.qualificationDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // табель_студентовTableAdapter
            // 
            this.табель_студентовTableAdapter.ClearBeforeFill = true;
            // 
            // qualificationDataSet16
            // 
            this.qualificationDataSet16.DataSetName = "QualificationDataSet16";
            this.qualificationDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стипендияBindingSource
            // 
            this.стипендияBindingSource.DataMember = "Стипендия";
            this.стипендияBindingSource.DataSource = this.qualificationDataSet16;
            // 
            // стипендияTableAdapter
            // 
            this.стипендияTableAdapter.ClearBeforeFill = true;
            // 
            // qualificationDataSet17
            // 
            this.qualificationDataSet17.DataSetName = "QualificationDataSet17";
            this.qualificationDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стипендияBindingSource1
            // 
            this.стипендияBindingSource1.DataMember = "Стипендия";
            this.стипендияBindingSource1.DataSource = this.qualificationDataSet17;
            // 
            // стипендияTableAdapter1
            // 
            this.стипендияTableAdapter1.ClearBeforeFill = true;
            // 
            // стипендияBindingSource2
            // 
            this.стипендияBindingSource2.DataMember = "Стипендия";
            this.стипендияBindingSource2.DataSource = this.qualificationDataSet18;
            // 
            // qualificationDataSet18
            // 
            this.qualificationDataSet18.DataSetName = "QualificationDataSet18";
            this.qualificationDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стипендияTableAdapter2
            // 
            this.стипендияTableAdapter2.ClearBeforeFill = true;
            // 
            // scheduleButton
            // 
            this.scheduleButton.BackColor = System.Drawing.Color.Lavender;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scheduleButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleButton.Location = new System.Drawing.Point(98, 331);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(142, 91);
            this.scheduleButton.TabIndex = 6;
            this.scheduleButton.Text = "Посмотреть расписание";
            this.scheduleButton.UseVisualStyleBackColor = false;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // qualificationDataSet33
            // 
            this.qualificationDataSet33.DataSetName = "QualificationDataSet33";
            this.qualificationDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стипендияBindingSource3
            // 
            this.стипендияBindingSource3.DataMember = "Стипендия";
            this.стипендияBindingSource3.DataSource = this.qualificationDataSet33;
            // 
            // стипендияTableAdapter3
            // 
            this.стипендияTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(726, 79);
            this.dataGridView1.TabIndex = 7;
            // 
            // qualificationDataSet34
            // 
            this.qualificationDataSet34.DataSetName = "QualificationDataSet34";
            this.qualificationDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стипендияBindingSource4
            // 
            this.стипендияBindingSource4.DataMember = "Стипендия";
            this.стипендияBindingSource4.DataSource = this.qualificationDataSet34;
            // 
            // стипендияTableAdapter4
            // 
            this.стипендияTableAdapter4.ClearBeforeFill = true;
            // 
            // starButton
            // 
            this.starButton.BackColor = System.Drawing.Color.Lavender;
            this.starButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.starButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.starButton.Location = new System.Drawing.Point(726, 423);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(38, 38);
            this.starButton.TabIndex = 8;
            this.starButton.Text = "*";
            this.starButton.UseVisualStyleBackColor = false;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(776, 473);
            this.Controls.Add(this.starButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.referenceButton);
            this.Name = "FormStudent";
            this.Text = "Личный кабинет студента";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельстудентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private QualificationDataSet14 qualificationDataSet14;
        private System.Windows.Forms.BindingSource табельстудентовBindingSource;
        private QualificationDataSet14TableAdapters.Табель_студентовTableAdapter табель_студентовTableAdapter;
        private QualificationDataSet16 qualificationDataSet16;
        private System.Windows.Forms.BindingSource стипендияBindingSource;
        private QualificationDataSet16TableAdapters.СтипендияTableAdapter стипендияTableAdapter;
        private QualificationDataSet17 qualificationDataSet17;
        private System.Windows.Forms.BindingSource стипендияBindingSource1;
        private QualificationDataSet17TableAdapters.СтипендияTableAdapter стипендияTableAdapter1;
        private QualificationDataSet18 qualificationDataSet18;
        private System.Windows.Forms.BindingSource стипендияBindingSource2;
        private QualificationDataSet18TableAdapters.СтипендияTableAdapter стипендияTableAdapter2;
        private System.Windows.Forms.Button scheduleButton;
        private QualificationDataSet33 qualificationDataSet33;
        private System.Windows.Forms.BindingSource стипендияBindingSource3;
        private QualificationDataSet33TableAdapters.СтипендияTableAdapter стипендияTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QualificationDataSet34 qualificationDataSet34;
        private System.Windows.Forms.BindingSource стипендияBindingSource4;
        private QualificationDataSet34TableAdapters.СтипендияTableAdapter стипендияTableAdapter4;
        private System.Windows.Forms.Button starButton;
    }
}