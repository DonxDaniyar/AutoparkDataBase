namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.автобусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автопаркDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автопаркDataSet = new WindowsFormsApplication1.АвтопаркDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.автобусTableAdapter = new WindowsFormsApplication1.АвтопаркDataSetTableAdapters.АвтобусTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.автобусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркасыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жүргізушіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жүргізушініңТелефоныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жұмысРежиміDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гаражданШықанУақытыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гаражғаКелуУақытыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.механикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.күніDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автобусМәліметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автобус_мәліметTableAdapter = new WindowsFormsApplication1.АвтопаркDataSetTableAdapters.Автобус_мәліметTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автобусBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусМәліметBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файToolStripMenuItem,
            this.лToolStripMenuItem,
            this.окнаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файToolStripMenuItem
            // 
            this.файToolStripMenuItem.Name = "файToolStripMenuItem";
            this.файToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файToolStripMenuItem.Text = "Файл";
            this.файToolStripMenuItem.Click += new System.EventHandler(this.файToolStripMenuItem_Click);
            // 
            // лToolStripMenuItem
            // 
            this.лToolStripMenuItem.Name = "лToolStripMenuItem";
            this.лToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.лToolStripMenuItem.Text = "Правка";
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 49);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(815, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(417, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Водитель:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.автобусBindingSource, "Жүргізуші", true));
            this.comboBox2.DataSource = this.автобусBindingSource;
            this.comboBox2.DisplayMember = "Жүргізуші";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(525, 16);
            this.comboBox2.MaxDropDownItems = 20;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // автобусBindingSource
            // 
            this.автобусBindingSource.DataMember = "Автобус";
            this.автобусBindingSource.DataSource = this.автопаркDataSetBindingSource;
            // 
            // автопаркDataSetBindingSource
            // 
            this.автопаркDataSetBindingSource.DataSource = this.автопаркDataSet;
            this.автопаркDataSetBindingSource.Position = 0;
            // 
            // автопаркDataSet
            // 
            this.автопаркDataSet.DataSetName = "АвтопаркDataSet";
            this.автопаркDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.автобусBindingSource, "Автобус №", true));
            this.comboBox1.DataSource = this.автобусBindingSource;
            this.comboBox1.DisplayMember = "Автобус №";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер автобуса:";
            // 
            // автобусTableAdapter
            // 
            this.автобусTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 362);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.автобусDataGridViewTextBoxColumn,
            this.маркасыDataGridViewTextBoxColumn,
            this.жүргізушіDataGridViewTextBoxColumn,
            this.жүргізушініңТелефоныDataGridViewTextBoxColumn,
            this.жұмысРежиміDataGridViewTextBoxColumn,
            this.гаражданШықанУақытыDataGridViewTextBoxColumn,
            this.гаражғаКелуУақытыDataGridViewTextBoxColumn,
            this.механикDataGridViewTextBoxColumn,
            this.күніDataGridViewTextBoxColumn,
            this.шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn,
            this.келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автобусBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(987, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // автобусDataGridViewTextBoxColumn
            // 
            this.автобусDataGridViewTextBoxColumn.DataPropertyName = "Автобус №";
            this.автобусDataGridViewTextBoxColumn.HeaderText = "Автобус №";
            this.автобусDataGridViewTextBoxColumn.Name = "автобусDataGridViewTextBoxColumn";
            this.автобусDataGridViewTextBoxColumn.Width = 80;
            // 
            // маркасыDataGridViewTextBoxColumn
            // 
            this.маркасыDataGridViewTextBoxColumn.DataPropertyName = "Маркасы";
            this.маркасыDataGridViewTextBoxColumn.HeaderText = "Маркасы";
            this.маркасыDataGridViewTextBoxColumn.Name = "маркасыDataGridViewTextBoxColumn";
            this.маркасыDataGridViewTextBoxColumn.Width = 79;
            // 
            // жүргізушіDataGridViewTextBoxColumn
            // 
            this.жүргізушіDataGridViewTextBoxColumn.DataPropertyName = "Жүргізуші";
            this.жүргізушіDataGridViewTextBoxColumn.HeaderText = "Жүргізуші";
            this.жүргізушіDataGridViewTextBoxColumn.Name = "жүргізушіDataGridViewTextBoxColumn";
            this.жүргізушіDataGridViewTextBoxColumn.Width = 82;
            // 
            // жүргізушініңТелефоныDataGridViewTextBoxColumn
            // 
            this.жүргізушініңТелефоныDataGridViewTextBoxColumn.DataPropertyName = "Жүргізушінің телефоны";
            this.жүргізушініңТелефоныDataGridViewTextBoxColumn.HeaderText = "Жүргізушінің телефоны";
            this.жүргізушініңТелефоныDataGridViewTextBoxColumn.Name = "жүргізушініңТелефоныDataGridViewTextBoxColumn";
            this.жүргізушініңТелефоныDataGridViewTextBoxColumn.Width = 137;
            // 
            // жұмысРежиміDataGridViewTextBoxColumn
            // 
            this.жұмысРежиміDataGridViewTextBoxColumn.DataPropertyName = "Жұмыс режимі";
            this.жұмысРежиміDataGridViewTextBoxColumn.HeaderText = "Жұмыс режимі";
            this.жұмысРежиміDataGridViewTextBoxColumn.Name = "жұмысРежиміDataGridViewTextBoxColumn";
            // 
            // гаражданШықанУақытыDataGridViewTextBoxColumn
            // 
            this.гаражданШықанУақытыDataGridViewTextBoxColumn.DataPropertyName = "Гараждан шықан уақыты";
            this.гаражданШықанУақытыDataGridViewTextBoxColumn.HeaderText = "Гараждан шықан уақыты";
            this.гаражданШықанУақытыDataGridViewTextBoxColumn.Name = "гаражданШықанУақытыDataGridViewTextBoxColumn";
            this.гаражданШықанУақытыDataGridViewTextBoxColumn.Width = 112;
            // 
            // гаражғаКелуУақытыDataGridViewTextBoxColumn
            // 
            this.гаражғаКелуУақытыDataGridViewTextBoxColumn.DataPropertyName = "Гаражға келу уақыты";
            this.гаражғаКелуУақытыDataGridViewTextBoxColumn.HeaderText = "Гаражға келу уақыты";
            this.гаражғаКелуУақытыDataGridViewTextBoxColumn.Name = "гаражғаКелуУақытыDataGridViewTextBoxColumn";
            this.гаражғаКелуУақытыDataGridViewTextBoxColumn.Width = 96;
            // 
            // механикDataGridViewTextBoxColumn
            // 
            this.механикDataGridViewTextBoxColumn.DataPropertyName = "Механик";
            this.механикDataGridViewTextBoxColumn.HeaderText = "Механик";
            this.механикDataGridViewTextBoxColumn.Name = "механикDataGridViewTextBoxColumn";
            this.механикDataGridViewTextBoxColumn.Width = 76;
            // 
            // күніDataGridViewTextBoxColumn
            // 
            this.күніDataGridViewTextBoxColumn.DataPropertyName = "Күні";
            this.күніDataGridViewTextBoxColumn.HeaderText = "Күні";
            this.күніDataGridViewTextBoxColumn.Name = "күніDataGridViewTextBoxColumn";
            this.күніDataGridViewTextBoxColumn.Width = 52;
            // 
            // шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn
            // 
            this.шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn.DataPropertyName = "Шықандағы спидометрдің көрсетуі";
            this.шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn.HeaderText = "Шықандағы спидометрдің көрсетуі";
            this.шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn.Name = "шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn";
            this.шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn.Width = 152;
            // 
            // келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn
            // 
            this.келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn.DataPropertyName = "Келгендегі спидометрдің көрсетуі";
            this.келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn.HeaderText = "Келгендегі спидометрдің көрсетуі";
            this.келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn.Name = "келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn";
            this.келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn.Width = 148;
            // 
            // автобусМәліметBindingSource
            // 
            this.автобусМәліметBindingSource.DataMember = "Автобус мәлімет";
            this.автобусМәліметBindingSource.DataSource = this.автопаркDataSetBindingSource;
            // 
            // автобус_мәліметTableAdapter
            // 
            this.автобус_мәліметTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 209);
            this.panel3.TabIndex = 3;
            this.panel3.TabStop = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных автопарка";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автобусBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусМәліметBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource автопаркDataSetBindingSource;
        private АвтопаркDataSet автопаркDataSet;
        private System.Windows.Forms.BindingSource автобусBindingSource;
        private АвтопаркDataSetTableAdapters.АвтобусTableAdapter автобусTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource автобусМәліметBindingSource;
        private АвтопаркDataSetTableAdapters.Автобус_мәліметTableAdapter автобус_мәліметTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn автобусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркасыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жүргізушіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жүргізушініңТелефоныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жұмысРежиміDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гаражданШықанУақытыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гаражғаКелуУақытыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn механикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn күніDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шықандағыСпидометрдіңКөрсетуіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn келгендегіСпидометрдіңКөрсетуіDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
    }
}

