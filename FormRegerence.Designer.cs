
namespace Qualification
{
    partial class FormRegerence
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
            this.qualificationDataSet19 = new Qualification.QualificationDataSet19();
            this.справкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справкиTableAdapter = new Qualification.QualificationDataSet19TableAdapters.СправкиTableAdapter();
            this.certOfStudyButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.certOfScholarshipButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.untilDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qualificationDataSet19
            // 
            this.qualificationDataSet19.DataSetName = "QualificationDataSet19";
            this.qualificationDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справкиBindingSource
            // 
            this.справкиBindingSource.DataMember = "Справки";
            this.справкиBindingSource.DataSource = this.qualificationDataSet19;
            // 
            // справкиTableAdapter
            // 
            this.справкиTableAdapter.ClearBeforeFill = true;
            // 
            // certOfStudyButton
            // 
            this.certOfStudyButton.BackColor = System.Drawing.Color.Lavender;
            this.certOfStudyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.certOfStudyButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.certOfStudyButton.Location = new System.Drawing.Point(22, 100);
            this.certOfStudyButton.Name = "certOfStudyButton";
            this.certOfStudyButton.Size = new System.Drawing.Size(164, 81);
            this.certOfStudyButton.TabIndex = 0;
            this.certOfStudyButton.Text = "Справка об обучении";
            this.certOfStudyButton.UseVisualStyleBackColor = false;
            this.certOfStudyButton.Click += new System.EventHandler(this.certOfStudyButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTextBox.Location = new System.Drawing.Point(412, 191);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(79, 33);
            this.quantityTextBox.TabIndex = 1;
           
            // 
            // certOfScholarshipButton
            // 
            this.certOfScholarshipButton.BackColor = System.Drawing.Color.Lavender;
            this.certOfScholarshipButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.certOfScholarshipButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.certOfScholarshipButton.Location = new System.Drawing.Point(22, 225);
            this.certOfScholarshipButton.Name = "certOfScholarshipButton";
            this.certOfScholarshipButton.Size = new System.Drawing.Size(164, 80);
            this.certOfScholarshipButton.TabIndex = 2;
            this.certOfScholarshipButton.Text = "Справка о стипендии";
            this.certOfScholarshipButton.UseVisualStyleBackColor = false;
            this.certOfScholarshipButton.Click += new System.EventHandler(this.certOfScholarshipButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(240, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Период:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(368, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(121, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "от";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Lavender;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(545, 25);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 45);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(16, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Заказ справок";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(166, 359);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(181, 26);
            this.fromDateTimePicker.TabIndex = 13;
            // 
            // untilDateTimePicker
            // 
            this.untilDateTimePicker.Location = new System.Drawing.Point(422, 359);
            this.untilDateTimePicker.Name = "untilDateTimePicker";
            this.untilDateTimePicker.Size = new System.Drawing.Size(181, 26);
            this.untilDateTimePicker.TabIndex = 14;
            // 
            // FormRegerence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(682, 412);
            this.Controls.Add(this.untilDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.certOfScholarshipButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.certOfStudyButton);
            this.Name = "FormRegerence";
            this.Text = "Личный кабинет студента";
            
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QualificationDataSet19 qualificationDataSet19;
        private System.Windows.Forms.BindingSource справкиBindingSource;
        private QualificationDataSet19TableAdapters.СправкиTableAdapter справкиTableAdapter;
        private System.Windows.Forms.Button certOfStudyButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button certOfScholarshipButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker untilDateTimePicker;
    }
}