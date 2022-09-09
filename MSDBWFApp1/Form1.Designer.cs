namespace MSDBWFApp1
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
            this.components = new System.ComponentModel.Container();
            this.labelState = new System.Windows.Forms.Label();
            this.diskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDiskDataSet = new MSDBWFApp1.DBDiskDataSet();
            this.diskTableAdapter = new MSDBWFApp1.DBDiskDataSetTableAdapters.DiskTableAdapter();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxNotes = new System.Windows.Forms.TextBox();
            this.cBoxPurpose = new System.Windows.Forms.ComboBox();
            this.tBoxTheme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpd = new System.Windows.Forms.Button();
            this.tBoxWhereRow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxUpdName = new System.Windows.Forms.TextBox();
            this.tBoxUpdTheme = new System.Windows.Forms.TextBox();
            this.tBoxUpdNotes = new System.Windows.Forms.TextBox();
            this.cBoxUpdPurpose = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cBoxPSearch = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.diskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDiskDataSet)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelState.Location = new System.Drawing.Point(12, 475);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(44, 16);
            this.labelState.TabIndex = 0;
            this.labelState.Text = "label1";
            // 
            // diskBindingSource
            // 
            this.diskBindingSource.DataMember = "Disk";
            this.diskBindingSource.DataSource = this.dBDiskDataSet;
            // 
            // dBDiskDataSet
            // 
            this.dBDiskDataSet.DataSetName = "DBDiskDataSet";
            this.dBDiskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diskTableAdapter
            // 
            this.diskTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(789, 446);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Групповое редактирование";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnSave, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(783, 440);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(777, 38);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(777, 390);
            this.dataGridView2.TabIndex = 24;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 446);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Одиночные действия";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(783, 440);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 333);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 104);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 78);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить элемент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBoxName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBoxNotes, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cBoxPurpose, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBoxTheme, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 72);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(192, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тематика";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(335, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Назначение";
            // 
            // tBoxName
            // 
            this.tBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxName.Location = new System.Drawing.Point(3, 43);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(146, 22);
            this.tBoxName.TabIndex = 3;
            this.tBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxNotes
            // 
            this.tBoxNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxNotes.Location = new System.Drawing.Point(459, 43);
            this.tBoxNotes.Name = "tBoxNotes";
            this.tBoxNotes.Size = new System.Drawing.Size(146, 22);
            this.tBoxNotes.TabIndex = 6;
            this.tBoxNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cBoxPurpose
            // 
            this.cBoxPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxPurpose.FormattingEnabled = true;
            this.cBoxPurpose.Items.AddRange(new object[] {
            "Аудио",
            "Видео",
            "Цифровой"});
            this.cBoxPurpose.Location = new System.Drawing.Point(307, 42);
            this.cBoxPurpose.Name = "cBoxPurpose";
            this.cBoxPurpose.Size = new System.Drawing.Size(146, 24);
            this.cBoxPurpose.TabIndex = 11;
            // 
            // tBoxTheme
            // 
            this.tBoxTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxTheme.Location = new System.Drawing.Point(155, 43);
            this.tBoxTheme.Name = "tBoxTheme";
            this.tBoxTheme.Size = new System.Drawing.Size(146, 22);
            this.tBoxTheme.TabIndex = 4;
            this.tBoxTheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(487, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Примечание";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(611, 3);
            this.btnAdd.Name = "btnAdd";
            this.tableLayoutPanel1.SetRowSpan(this.btnAdd, 2);
            this.btnAdd.Size = new System.Drawing.Size(149, 66);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(769, 78);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменить элемент";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.749076F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.45018F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.45018F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.45018F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.45018F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.45018F));
            this.tableLayoutPanel3.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpd, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.tBoxWhereRow, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tBoxUpdName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tBoxUpdTheme, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tBoxUpdNotes, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.cBoxUpdPurpose, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(763, 72);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(504, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Примечание";
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(622, 3);
            this.btnUpd.Name = "btnUpd";
            this.tableLayoutPanel3.SetRowSpan(this.btnUpd, 2);
            this.btnUpd.Size = new System.Drawing.Size(138, 66);
            this.btnUpd.TabIndex = 19;
            this.btnUpd.Text = "Изменить";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // tBoxWhereRow
            // 
            this.tBoxWhereRow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxWhereRow.Location = new System.Drawing.Point(3, 43);
            this.tBoxWhereRow.Name = "tBoxWhereRow";
            this.tBoxWhereRow.Size = new System.Drawing.Size(53, 22);
            this.tBoxWhereRow.TabIndex = 20;
            this.tBoxWhereRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Номер";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(233, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Тематика";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(92, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Название";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(364, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Назначение";
            // 
            // tBoxUpdName
            // 
            this.tBoxUpdName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxUpdName.Location = new System.Drawing.Point(62, 43);
            this.tBoxUpdName.Name = "tBoxUpdName";
            this.tBoxUpdName.Size = new System.Drawing.Size(134, 22);
            this.tBoxUpdName.TabIndex = 26;
            this.tBoxUpdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxUpdTheme
            // 
            this.tBoxUpdTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxUpdTheme.Location = new System.Drawing.Point(202, 43);
            this.tBoxUpdTheme.Name = "tBoxUpdTheme";
            this.tBoxUpdTheme.Size = new System.Drawing.Size(134, 22);
            this.tBoxUpdTheme.TabIndex = 27;
            this.tBoxUpdTheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxUpdNotes
            // 
            this.tBoxUpdNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxUpdNotes.Location = new System.Drawing.Point(482, 43);
            this.tBoxUpdNotes.Name = "tBoxUpdNotes";
            this.tBoxUpdNotes.Size = new System.Drawing.Size(134, 22);
            this.tBoxUpdNotes.TabIndex = 29;
            this.tBoxUpdNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cBoxUpdPurpose
            // 
            this.cBoxUpdPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxUpdPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUpdPurpose.FormattingEnabled = true;
            this.cBoxUpdPurpose.Items.AddRange(new object[] {
            "Аудио",
            "Видео",
            "Цифровой"});
            this.cBoxUpdPurpose.Location = new System.Drawing.Point(342, 43);
            this.cBoxUpdPurpose.Name = "cBoxUpdPurpose";
            this.cBoxUpdPurpose.Size = new System.Drawing.Size(134, 24);
            this.cBoxUpdPurpose.TabIndex = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 78);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnResetSearch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBoxSearch, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cBoxPSearch, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(763, 72);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(52, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Найти";
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetSearch.Location = new System.Drawing.Point(611, 3);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(149, 66);
            this.btnResetSearch.TabIndex = 16;
            this.btnResetSearch.Text = "Сбросить";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxSearch.Location = new System.Drawing.Point(307, 25);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(146, 22);
            this.tBoxSearch.TabIndex = 14;
            this.tBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(459, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 66);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cBoxPSearch
            // 
            this.cBoxPSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxPSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxPSearch.FormattingEnabled = true;
            this.cBoxPSearch.Items.AddRange(new object[] {
            "Назначение",
            "Тематика",
            "Название"});
            this.cBoxPSearch.Location = new System.Drawing.Point(155, 24);
            this.cBoxPSearch.Name = "cBoxPSearch";
            this.cBoxPSearch.Size = new System.Drawing.Size(146, 24);
            this.cBoxPSearch.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(777, 324);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(1, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(797, 472);
            this.tabControl2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.labelState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDiskDataSet)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelState;
        private DBDiskDataSet dBDiskDataSet;
        private System.Windows.Forms.BindingSource diskBindingSource;
        private DBDiskDataSetTableAdapters.DiskTableAdapter diskTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxNotes;
        private System.Windows.Forms.ComboBox cBoxPurpose;
        private System.Windows.Forms.TextBox tBoxTheme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.TextBox tBoxWhereRow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBoxUpdName;
        private System.Windows.Forms.TextBox tBoxUpdTheme;
        private System.Windows.Forms.TextBox tBoxUpdNotes;
        private System.Windows.Forms.ComboBox cBoxUpdPurpose;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cBoxPSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl2;
    }
}

