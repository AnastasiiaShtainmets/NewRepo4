
namespace Qualification
{
    partial class FormSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretary));
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet25 = new Qualification.QualificationDataSet25();
            this.студентыTableAdapter = new Qualification.QualificationDataSet25TableAdapters.СтудентыTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
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
            this.справкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet26 = new Qualification.QualificationDataSet26();
            this.label2 = new System.Windows.Forms.Label();
            this.справкиTableAdapter = new Qualification.QualificationDataSet26TableAdapters.СправкиTableAdapter();
            this.scheduleSecretaryButton = new System.Windows.Forms.Button();
            this.performanceButton = new System.Windows.Forms.Button();
            this.qualificationDataSet35 = new Qualification.QualificationDataSet35();
            this.справкиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.справкиTableAdapter1 = new Qualification.QualificationDataSet35TableAdapters.СправкиTableAdapter();
            this.справкиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet36 = new Qualification.QualificationDataSet36();
            this.справкиTableAdapter2 = new Qualification.QualificationDataSet36TableAdapters.СправкиTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.студентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet37 = new Qualification.QualificationDataSet37();
            this.студентыTableAdapter1 = new Qualification.QualificationDataSet37TableAdapters.СтудентыTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.passwordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номерсправкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.справкаобобученииDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.справкаостипендииDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.справкаостипендииотDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.справкаостипендиидоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idстудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.справкиBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationDataSet48 = new Qualification.QualificationDataSet48();
            this.справкиTableAdapter3 = new Qualification.QualificationDataSet48TableAdapters.СправкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet48)).BeginInit();
            this.SuspendLayout();
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.qualificationDataSet25;
            // 
            // qualificationDataSet25
            // 
            this.qualificationDataSet25.DataSetName = "QualificationDataSet25";
            this.qualificationDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Студенты";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.студентыBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1141, 38);
            this.bindingNavigator1.TabIndex = 2;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
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
            // справкиBindingSource
            // 
            this.справкиBindingSource.DataMember = "Справки";
            this.справкиBindingSource.DataSource = this.qualificationDataSet26;
            // 
            // qualificationDataSet26
            // 
            this.qualificationDataSet26.DataSetName = "QualificationDataSet26";
            this.qualificationDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Справки";
            // 
            // справкиTableAdapter
            // 
            this.справкиTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleSecretaryButton
            // 
            this.scheduleSecretaryButton.BackColor = System.Drawing.Color.Moccasin;
            this.scheduleSecretaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scheduleSecretaryButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleSecretaryButton.Location = new System.Drawing.Point(816, 422);
            this.scheduleSecretaryButton.Name = "scheduleSecretaryButton";
            this.scheduleSecretaryButton.Size = new System.Drawing.Size(142, 62);
            this.scheduleSecretaryButton.TabIndex = 7;
            this.scheduleSecretaryButton.Text = "Расписание";
            this.scheduleSecretaryButton.UseVisualStyleBackColor = false;
            this.scheduleSecretaryButton.Click += new System.EventHandler(this.scheduleSecretaryButton_Click);
            // 
            // performanceButton
            // 
            this.performanceButton.BackColor = System.Drawing.Color.Moccasin;
            this.performanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.performanceButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performanceButton.Location = new System.Drawing.Point(987, 422);
            this.performanceButton.Name = "performanceButton";
            this.performanceButton.Size = new System.Drawing.Size(142, 62);
            this.performanceButton.TabIndex = 8;
            this.performanceButton.Text = "Табель студентов";
            this.performanceButton.UseVisualStyleBackColor = false;
            this.performanceButton.Click += new System.EventHandler(this.performanceButton_Click);
            // 
            // qualificationDataSet35
            // 
            this.qualificationDataSet35.DataSetName = "QualificationDataSet35";
            this.qualificationDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справкиBindingSource1
            // 
            this.справкиBindingSource1.DataMember = "Справки";
            this.справкиBindingSource1.DataSource = this.qualificationDataSet35;
            // 
            // справкиTableAdapter1
            // 
            this.справкиTableAdapter1.ClearBeforeFill = true;
            // 
            // справкиBindingSource2
            // 
            this.справкиBindingSource2.DataMember = "Справки";
            this.справкиBindingSource2.DataSource = this.qualificationDataSet36;
            // 
            // qualificationDataSet36
            // 
            this.qualificationDataSet36.DataSetName = "QualificationDataSet36";
            this.qualificationDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справкиTableAdapter2
            // 
            this.справкиTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(988, 130);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // студентыBindingSource1
            // 
            this.студентыBindingSource1.DataMember = "Студенты";
            this.студентыBindingSource1.DataSource = this.qualificationDataSet37;
            // 
            // qualificationDataSet37
            // 
            this.qualificationDataSet37.DataSetName = "QualificationDataSet37";
            this.qualificationDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыTableAdapter1
            // 
            this.студентыTableAdapter1.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Moccasin;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(1011, 278);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 98);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // passwordButton
            // 
            this.passwordButton.BackColor = System.Drawing.Color.Moccasin;
            this.passwordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passwordButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordButton.Location = new System.Drawing.Point(13, 437);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(195, 47);
            this.passwordButton.TabIndex = 12;
            this.passwordButton.Text = "Сгенерировать пароль";
            this.passwordButton.UseVisualStyleBackColor = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(247, 463);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(168, 30);
            this.passwordTextBox.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерсправкиDataGridViewTextBoxColumn,
            this.справкаобобученииDataGridViewCheckBoxColumn,
            this.справкаостипендииDataGridViewCheckBoxColumn,
            this.справкаостипендииотDataGridViewTextBoxColumn,
            this.справкаостипендиидоDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.idстудентаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.справкиBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(13, 95);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1116, 130);
            this.dataGridView2.TabIndex = 14;
            // 
            // номерсправкиDataGridViewTextBoxColumn
            // 
            this.номерсправкиDataGridViewTextBoxColumn.DataPropertyName = "Номер_справки";
            this.номерсправкиDataGridViewTextBoxColumn.HeaderText = "Номер_справки";
            this.номерсправкиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерсправкиDataGridViewTextBoxColumn.Name = "номерсправкиDataGridViewTextBoxColumn";
            // 
            // справкаобобученииDataGridViewCheckBoxColumn
            // 
            this.справкаобобученииDataGridViewCheckBoxColumn.DataPropertyName = "Справка_об_обучении";
            this.справкаобобученииDataGridViewCheckBoxColumn.HeaderText = "Справка_об_обучении";
            this.справкаобобученииDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.справкаобобученииDataGridViewCheckBoxColumn.Name = "справкаобобученииDataGridViewCheckBoxColumn";
            // 
            // справкаостипендииDataGridViewCheckBoxColumn
            // 
            this.справкаостипендииDataGridViewCheckBoxColumn.DataPropertyName = "Справка_о_стипендии";
            this.справкаостипендииDataGridViewCheckBoxColumn.HeaderText = "Справка_о_стипендии";
            this.справкаостипендииDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.справкаостипендииDataGridViewCheckBoxColumn.Name = "справкаостипендииDataGridViewCheckBoxColumn";
            // 
            // справкаостипендииотDataGridViewTextBoxColumn
            // 
            this.справкаостипендииотDataGridViewTextBoxColumn.DataPropertyName = "Справка_о_стипендии_от";
            this.справкаостипендииотDataGridViewTextBoxColumn.HeaderText = "Справка_о_стипендии_от";
            this.справкаостипендииотDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.справкаостипендииотDataGridViewTextBoxColumn.Name = "справкаостипендииотDataGridViewTextBoxColumn";
            // 
            // справкаостипендиидоDataGridViewTextBoxColumn
            // 
            this.справкаостипендиидоDataGridViewTextBoxColumn.DataPropertyName = "Справка_о_стипендии_до";
            this.справкаостипендиидоDataGridViewTextBoxColumn.HeaderText = "Справка_о_стипендии_до";
            this.справкаостипендиидоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.справкаостипендиидоDataGridViewTextBoxColumn.Name = "справкаостипендиидоDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // idстудентаDataGridViewTextBoxColumn
            // 
            this.idстудентаDataGridViewTextBoxColumn.DataPropertyName = "id_студента";
            this.idстудентаDataGridViewTextBoxColumn.HeaderText = "id_студента";
            this.idстудентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idстудентаDataGridViewTextBoxColumn.Name = "idстудентаDataGridViewTextBoxColumn";
            // 
            // справкиBindingSource3
            // 
            this.справкиBindingSource3.DataMember = "Справки";
            this.справкиBindingSource3.DataSource = this.qualificationDataSet48;
            // 
            // qualificationDataSet48
            // 
            this.qualificationDataSet48.DataSetName = "QualificationDataSet48";
            this.qualificationDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справкиTableAdapter3
            // 
            this.справкиTableAdapter3.ClearBeforeFill = true;
            // 
            // FormSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1141, 528);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.performanceButton);
            this.Controls.Add(this.scheduleSecretaryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormSecretary";
            this.Text = "Секретарь";
            this.Load += new System.EventHandler(this.FormSecretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справкиBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationDataSet48)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QualificationDataSet25 qualificationDataSet25;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private QualificationDataSet25TableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label2;
        private QualificationDataSet26 qualificationDataSet26;
        private System.Windows.Forms.BindingSource справкиBindingSource;
        private QualificationDataSet26TableAdapters.СправкиTableAdapter справкиTableAdapter;
        private System.Windows.Forms.Button scheduleSecretaryButton;
        private System.Windows.Forms.Button performanceButton;
        private QualificationDataSet35 qualificationDataSet35;
        private System.Windows.Forms.BindingSource справкиBindingSource1;
        private QualificationDataSet35TableAdapters.СправкиTableAdapter справкиTableAdapter1;
        private QualificationDataSet36 qualificationDataSet36;
        private System.Windows.Forms.BindingSource справкиBindingSource2;
        private QualificationDataSet36TableAdapters.СправкиTableAdapter справкиTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QualificationDataSet37 qualificationDataSet37;
        private System.Windows.Forms.BindingSource студентыBindingSource1;
        private QualificationDataSet37TableAdapters.СтудентыTableAdapter студентыTableAdapter1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private QualificationDataSet48 qualificationDataSet48;
        private System.Windows.Forms.BindingSource справкиBindingSource3;
        private QualificationDataSet48TableAdapters.СправкиTableAdapter справкиTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерсправкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn справкаобобученииDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn справкаостипендииDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn справкаостипендииотDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn справкаостипендиидоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idстудентаDataGridViewTextBoxColumn;
    }
}