
namespace Qualification
{
    partial class FormAccountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountant));
            this.dataGridViewStudentReportCard = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студент1курса1семестраDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.количествоотличноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествохорошоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоудовлетворительноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиезадолженностейDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.табельстудентовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet3 = new Qualification.QualificationDataSet3();
            this.табельстудентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet1 = new Qualification.QualificationDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGrants = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаакадемическойстипендииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Социальная_стипендия = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.суммадополнительнойстипендииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммавсехстипендийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стипендияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet5 = new Qualification.QualificationDataSet5();
            this.стипендияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet = new Qualification.QualificationDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateScholarship = new System.Windows.Forms.Button();
            this.sumScolarship = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.стипендияTableAdapter = new Qualification.QualificationDataSetTableAdapters.СтипендияTableAdapter();
            this.табель_студентовTableAdapter = new Qualification.QualificationDataSet1TableAdapters.Табель_студентовTableAdapter();
            this.табель_студентовTableAdapter1 = new Qualification.QualificationDataSet3TableAdapters.Табель_студентовTableAdapter();
            this.стипендияTableAdapter1 = new Qualification.QualificationDataSet5TableAdapters.СтипендияTableAdapter();
            this.calculateAndSaveButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReportCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельстудентовBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельстудентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudentReportCard
            // 
            this.dataGridViewStudentReportCard.AutoGenerateColumns = false;
            this.dataGridViewStudentReportCard.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewStudentReportCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentReportCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn1,
            this.студент1курса1семестраDataGridViewCheckBoxColumn,
            this.количествоотличноDataGridViewTextBoxColumn,
            this.количествохорошоDataGridViewTextBoxColumn,
            this.количествоудовлетворительноDataGridViewTextBoxColumn,
            this.наличиезадолженностейDataGridViewCheckBoxColumn});
            this.dataGridViewStudentReportCard.DataSource = this.табельстудентовBindingSource1;
            this.dataGridViewStudentReportCard.Location = new System.Drawing.Point(31, 113);
            this.dataGridViewStudentReportCard.Name = "dataGridViewStudentReportCard";
            this.dataGridViewStudentReportCard.RowHeadersWidth = 62;
            this.dataGridViewStudentReportCard.RowTemplate.Height = 28;
            this.dataGridViewStudentReportCard.Size = new System.Drawing.Size(964, 162);
            this.dataGridViewStudentReportCard.TabIndex = 0;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.Width = 150;
            // 
            // студент1курса1семестраDataGridViewCheckBoxColumn
            // 
            this.студент1курса1семестраDataGridViewCheckBoxColumn.DataPropertyName = "Студент_1курса_1семестра";
            this.студент1курса1семестраDataGridViewCheckBoxColumn.HeaderText = "Студент_1курса_1семестра";
            this.студент1курса1семестраDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.студент1курса1семестраDataGridViewCheckBoxColumn.Name = "студент1курса1семестраDataGridViewCheckBoxColumn";
            this.студент1курса1семестраDataGridViewCheckBoxColumn.Width = 150;
            // 
            // количествоотличноDataGridViewTextBoxColumn
            // 
            this.количествоотличноDataGridViewTextBoxColumn.DataPropertyName = "Количество_отлично";
            this.количествоотличноDataGridViewTextBoxColumn.HeaderText = "Количество_отлично";
            this.количествоотличноDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.количествоотличноDataGridViewTextBoxColumn.Name = "количествоотличноDataGridViewTextBoxColumn";
            this.количествоотличноDataGridViewTextBoxColumn.Width = 150;
            // 
            // количествохорошоDataGridViewTextBoxColumn
            // 
            this.количествохорошоDataGridViewTextBoxColumn.DataPropertyName = "Количество_хорошо";
            this.количествохорошоDataGridViewTextBoxColumn.HeaderText = "Количество_хорошо";
            this.количествохорошоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.количествохорошоDataGridViewTextBoxColumn.Name = "количествохорошоDataGridViewTextBoxColumn";
            this.количествохорошоDataGridViewTextBoxColumn.Width = 150;
            // 
            // количествоудовлетворительноDataGridViewTextBoxColumn
            // 
            this.количествоудовлетворительноDataGridViewTextBoxColumn.DataPropertyName = "Количество_удовлетворительно";
            this.количествоудовлетворительноDataGridViewTextBoxColumn.HeaderText = "Количество_удовлетворительно";
            this.количествоудовлетворительноDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.количествоудовлетворительноDataGridViewTextBoxColumn.Name = "количествоудовлетворительноDataGridViewTextBoxColumn";
            this.количествоудовлетворительноDataGridViewTextBoxColumn.Width = 150;
            // 
            // наличиезадолженностейDataGridViewCheckBoxColumn
            // 
            this.наличиезадолженностейDataGridViewCheckBoxColumn.DataPropertyName = "Наличие_задолженностей";
            this.наличиезадолженностейDataGridViewCheckBoxColumn.HeaderText = "Наличие_задолженностей";
            this.наличиезадолженностейDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.наличиезадолженностейDataGridViewCheckBoxColumn.Name = "наличиезадолженностейDataGridViewCheckBoxColumn";
            this.наличиезадолженностейDataGridViewCheckBoxColumn.Width = 150;
            // 
            // табельстудентовBindingSource1
            // 
            this.табельстудентовBindingSource1.DataMember = "Табель_студентов";
            this.табельстудентовBindingSource1.DataSource = this.qualificationDataSet3;
            // 
            // qualificationDataSet3
            // 
            this.qualificationDataSet3.DataSetName = "QualificationDataSet3";
            this.qualificationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // табельстудентовBindingSource
            // 
            this.табельстудентовBindingSource.DataMember = "Табель_студентов";
            this.табельстудентовBindingSource.DataSource = this.qualificationDataSet1;
            // 
            // qualificationDataSet1
            // 
            this.qualificationDataSet1.DataSetName = "QualificationDataSet1";
            this.qualificationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Табель студентов";
            // 
            // dataGridViewGrants
            // 
            this.dataGridViewGrants.AutoGenerateColumns = false;
            this.dataGridViewGrants.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewGrants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.суммаакадемическойстипендииDataGridViewTextBoxColumn,
            this.Социальная_стипендия,
            this.суммадополнительнойстипендииDataGridViewTextBoxColumn,
            this.суммавсехстипендийDataGridViewTextBoxColumn});
            this.dataGridViewGrants.DataSource = this.стипендияBindingSource1;
            this.dataGridViewGrants.Location = new System.Drawing.Point(31, 415);
            this.dataGridViewGrants.Name = "dataGridViewGrants";
            this.dataGridViewGrants.RowHeadersWidth = 62;
            this.dataGridViewGrants.RowTemplate.Height = 28;
            this.dataGridViewGrants.Size = new System.Drawing.Size(815, 130);
            this.dataGridViewGrants.TabIndex = 2;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 150;
            // 
            // суммаакадемическойстипендииDataGridViewTextBoxColumn
            // 
            this.суммаакадемическойстипендииDataGridViewTextBoxColumn.DataPropertyName = "Сумма_академической_стипендии";
            this.суммаакадемическойстипендииDataGridViewTextBoxColumn.HeaderText = "Сумма_академической_стипендии";
            this.суммаакадемическойстипендииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.суммаакадемическойстипендииDataGridViewTextBoxColumn.Name = "суммаакадемическойстипендииDataGridViewTextBoxColumn";
            this.суммаакадемическойстипендииDataGridViewTextBoxColumn.Width = 150;
            // 
            // Социальная_стипендия
            // 
            this.Социальная_стипендия.DataPropertyName = "Социальная_стипендия";
            this.Социальная_стипендия.HeaderText = "Социальная_стипендия";
            this.Социальная_стипендия.MinimumWidth = 8;
            this.Социальная_стипендия.Name = "Социальная_стипендия";
            this.Социальная_стипендия.Width = 150;
            // 
            // суммадополнительнойстипендииDataGridViewTextBoxColumn
            // 
            this.суммадополнительнойстипендииDataGridViewTextBoxColumn.DataPropertyName = "Сумма_дополнительной_стипендии";
            this.суммадополнительнойстипендииDataGridViewTextBoxColumn.HeaderText = "Сумма_дополнительной_стипендии";
            this.суммадополнительнойстипендииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.суммадополнительнойстипендииDataGridViewTextBoxColumn.Name = "суммадополнительнойстипендииDataGridViewTextBoxColumn";
            this.суммадополнительнойстипендииDataGridViewTextBoxColumn.Width = 150;
            // 
            // суммавсехстипендийDataGridViewTextBoxColumn
            // 
            this.суммавсехстипендийDataGridViewTextBoxColumn.DataPropertyName = "Сумма_всех_стипендий";
            this.суммавсехстипендийDataGridViewTextBoxColumn.HeaderText = "Сумма_всех_стипендий";
            this.суммавсехстипендийDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.суммавсехстипендийDataGridViewTextBoxColumn.Name = "суммавсехстипендийDataGridViewTextBoxColumn";
            this.суммавсехстипендийDataGridViewTextBoxColumn.Width = 150;
            // 
            // стипендияBindingSource1
            // 
            this.стипендияBindingSource1.DataMember = "Стипендия";
            this.стипендияBindingSource1.DataSource = this.qualificationDataSet5;
            // 
            // qualificationDataSet5
            // 
            this.qualificationDataSet5.DataSetName = "QualificationDataSet5";
            this.qualificationDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стипендияBindingSource
            // 
            this.стипендияBindingSource.DataMember = "Стипендия";
            this.стипендияBindingSource.DataSource = this.qualificationDataSet;
            // 
            // qualificationDataSet
            // 
            this.qualificationDataSet.DataSetName = "QualificationDataSet";
            this.qualificationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(25, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Журнал стипендии";
            // 
            // calculateScholarship
            // 
            this.calculateScholarship.BackColor = System.Drawing.Color.Honeydew;
            this.calculateScholarship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateScholarship.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateScholarship.Location = new System.Drawing.Point(387, 306);
            this.calculateScholarship.Name = "calculateScholarship";
            this.calculateScholarship.Size = new System.Drawing.Size(169, 85);
            this.calculateScholarship.TabIndex = 4;
            this.calculateScholarship.Text = "Высчитать академическую стипендию";
            this.calculateScholarship.UseVisualStyleBackColor = false;
            this.calculateScholarship.Click += new System.EventHandler(this.calculateScholarship_Click);
            // 
            // sumScolarship
            // 
            this.sumScolarship.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumScolarship.Location = new System.Drawing.Point(605, 362);
            this.sumScolarship.Name = "sumScolarship";
            this.sumScolarship.Size = new System.Drawing.Size(173, 33);
            this.sumScolarship.TabIndex = 5;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.стипендияBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1032, 38);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(55, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // стипендияTableAdapter
            // 
            this.стипендияTableAdapter.ClearBeforeFill = true;
            // 
            // табель_студентовTableAdapter
            // 
            this.табель_студентовTableAdapter.ClearBeforeFill = true;
            // 
            // табель_студентовTableAdapter1
            // 
            this.табель_студентовTableAdapter1.ClearBeforeFill = true;
            // 
            // стипендияTableAdapter1
            // 
            this.стипендияTableAdapter1.ClearBeforeFill = true;
            // 
            // calculateAndSaveButton
            // 
            this.calculateAndSaveButton.BackColor = System.Drawing.Color.Honeydew;
            this.calculateAndSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateAndSaveButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateAndSaveButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calculateAndSaveButton.Location = new System.Drawing.Point(826, 310);
            this.calculateAndSaveButton.Name = "calculateAndSaveButton";
            this.calculateAndSaveButton.Size = new System.Drawing.Size(169, 85);
            this.calculateAndSaveButton.TabIndex = 7;
            this.calculateAndSaveButton.Text = "Высчитать сумму всех стипендий";
            this.calculateAndSaveButton.UseVisualStyleBackColor = false;
            this.calculateAndSaveButton.Click += new System.EventHandler(this.calculateAndSaveButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Honeydew;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(877, 434);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 89);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FormAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1032, 577);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.calculateAndSaveButton);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.sumScolarship);
            this.Controls.Add(this.calculateScholarship);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewGrants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStudentReportCard);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormAccountant";
            this.Text = "Бухгалтер";
            this.Load += new System.EventHandler(this.FormAccountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReportCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельстудентовBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельстудентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стипендияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentReportCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGrants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateScholarship;
        private System.Windows.Forms.TextBox sumScolarship;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private QualificationDataSet qualificationDataSet;
        private System.Windows.Forms.BindingSource стипендияBindingSource;
        private QualificationDataSetTableAdapters.СтипендияTableAdapter стипендияTableAdapter;
        private QualificationDataSet1 qualificationDataSet1;
        private System.Windows.Forms.BindingSource табельстудентовBindingSource;
        private QualificationDataSet1TableAdapters.Табель_студентовTableAdapter табель_студентовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn студент1курса1семестраDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоотличноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествохорошоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоудовлетворительноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиезадолженностейDataGridViewCheckBoxColumn;
        private QualificationDataSet3 qualificationDataSet3;
        private System.Windows.Forms.BindingSource табельстудентовBindingSource1;
        private QualificationDataSet3TableAdapters.Табель_студентовTableAdapter табель_студентовTableAdapter1;
        private QualificationDataSet5 qualificationDataSet5;
        private System.Windows.Forms.BindingSource стипендияBindingSource1;
        private QualificationDataSet5TableAdapters.СтипендияTableAdapter стипендияTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаакадемическойстипендииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Социальная_стипендия;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммадополнительнойстипендииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммавсехстипендийDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button calculateAndSaveButton;
        private System.Windows.Forms.Button saveButton;
    }
}