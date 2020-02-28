namespace сяп_сишарп_задание_2
{
    partial class frm_students
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
            this.mnS_main = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.следующийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предыдущийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьМагистромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьБакалавромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_faculty = new System.Windows.Forms.Label();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.txtB_firstname = new System.Windows.Forms.TextBox();
            this.txtB_lastname = new System.Windows.Forms.TextBox();
            this.txtB_faculty = new System.Windows.Forms.TextBox();
            this.cmbb_degree = new System.Windows.Forms.ComboBox();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.txtB_degree_info = new System.Windows.Forms.TextBox();
            this.lbl_degree_info = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtB_value = new System.Windows.Forms.TextBox();
            this.lbl_value = new System.Windows.Forms.Label();
            this.lbl_field = new System.Windows.Forms.Label();
            this.cmbb_field = new System.Windows.Forms.ComboBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.pnl_line = new System.Windows.Forms.Panel();
            this.mnS_main.SuspendLayout();
            this.pnl_info.SuspendLayout();
            this.pnl_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnS_main
            // 
            this.mnS_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnS_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.студентыToolStripMenuItem});
            this.mnS_main.Location = new System.Drawing.Point(0, 0);
            this.mnS_main.Name = "mnS_main";
            this.mnS_main.Size = new System.Drawing.Size(667, 28);
            this.mnS_main.TabIndex = 0;
            this.mnS_main.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.следующийToolStripMenuItem,
            this.предыдущийToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // следующийToolStripMenuItem
            // 
            this.следующийToolStripMenuItem.Name = "следующийToolStripMenuItem";
            this.следующийToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.следующийToolStripMenuItem.Text = "Следующий";
            this.следующийToolStripMenuItem.Click += new System.EventHandler(this.следующийToolStripMenuItem_Click);
            // 
            // предыдущийToolStripMenuItem
            // 
            this.предыдущийToolStripMenuItem.Name = "предыдущийToolStripMenuItem";
            this.предыдущийToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.предыдущийToolStripMenuItem.Text = "Предыдущий";
            this.предыдущийToolStripMenuItem.Click += new System.EventHandler(this.предыдущийToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.сделатьМагистромToolStripMenuItem,
            this.сделатьБакалавромToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сделатьМагистромToolStripMenuItem
            // 
            this.сделатьМагистромToolStripMenuItem.Name = "сделатьМагистромToolStripMenuItem";
            this.сделатьМагистромToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.сделатьМагистромToolStripMenuItem.Text = "Сделать магистром";
            this.сделатьМагистромToolStripMenuItem.Click += new System.EventHandler(this.сделатьМагистромToolStripMenuItem_Click);
            // 
            // сделатьБакалавромToolStripMenuItem
            // 
            this.сделатьБакалавромToolStripMenuItem.Name = "сделатьБакалавромToolStripMenuItem";
            this.сделатьБакалавромToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.сделатьБакалавромToolStripMenuItem.Text = "Сделать бакалавром";
            this.сделатьБакалавромToolStripMenuItem.Click += new System.EventHandler(this.сделатьБакалавромToolStripMenuItem_Click);
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(21, 4);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(35, 17);
            this.lbl_firstname.TabIndex = 1;
            this.lbl_firstname.Text = "Имя";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(21, 49);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(70, 17);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "Фамилия";
            // 
            // lbl_faculty
            // 
            this.lbl_faculty.AutoSize = true;
            this.lbl_faculty.Location = new System.Drawing.Point(21, 94);
            this.lbl_faculty.Name = "lbl_faculty";
            this.lbl_faculty.Size = new System.Drawing.Size(80, 17);
            this.lbl_faculty.TabIndex = 3;
            this.lbl_faculty.Text = "Факультет";
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Location = new System.Drawing.Point(21, 139);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(63, 17);
            this.lbl_degree.TabIndex = 4;
            this.lbl_degree.Text = "Степень";
            // 
            // txtB_firstname
            // 
            this.txtB_firstname.Location = new System.Drawing.Point(24, 24);
            this.txtB_firstname.Name = "txtB_firstname";
            this.txtB_firstname.Size = new System.Drawing.Size(241, 22);
            this.txtB_firstname.TabIndex = 5;
            this.txtB_firstname.TextChanged += new System.EventHandler(this.txtB_firstname_TextChanged);
            // 
            // txtB_lastname
            // 
            this.txtB_lastname.Location = new System.Drawing.Point(24, 69);
            this.txtB_lastname.Name = "txtB_lastname";
            this.txtB_lastname.Size = new System.Drawing.Size(241, 22);
            this.txtB_lastname.TabIndex = 6;
            this.txtB_lastname.TextChanged += new System.EventHandler(this.txtB_lastname_TextChanged);
            // 
            // txtB_faculty
            // 
            this.txtB_faculty.Location = new System.Drawing.Point(24, 114);
            this.txtB_faculty.Name = "txtB_faculty";
            this.txtB_faculty.Size = new System.Drawing.Size(241, 22);
            this.txtB_faculty.TabIndex = 7;
            this.txtB_faculty.TextChanged += new System.EventHandler(this.txtB_faculty_TextChanged);
            // 
            // cmbb_degree
            // 
            this.cmbb_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbb_degree.FormattingEnabled = true;
            this.cmbb_degree.Location = new System.Drawing.Point(24, 160);
            this.cmbb_degree.Name = "cmbb_degree";
            this.cmbb_degree.Size = new System.Drawing.Size(241, 24);
            this.cmbb_degree.TabIndex = 8;
            this.cmbb_degree.SelectedIndexChanged += new System.EventHandler(this.cmbb_degree_SelectedIndexChanged);
            // 
            // pnl_info
            // 
            this.pnl_info.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_info.Controls.Add(this.txtB_degree_info);
            this.pnl_info.Controls.Add(this.lbl_degree_info);
            this.pnl_info.Controls.Add(this.lbl_lastname);
            this.pnl_info.Controls.Add(this.btn_next);
            this.pnl_info.Controls.Add(this.cmbb_degree);
            this.pnl_info.Controls.Add(this.btn_prev);
            this.pnl_info.Controls.Add(this.lbl_firstname);
            this.pnl_info.Controls.Add(this.btn_ok);
            this.pnl_info.Controls.Add(this.txtB_faculty);
            this.pnl_info.Controls.Add(this.lbl_faculty);
            this.pnl_info.Controls.Add(this.txtB_lastname);
            this.pnl_info.Controls.Add(this.lbl_degree);
            this.pnl_info.Controls.Add(this.txtB_firstname);
            this.pnl_info.Location = new System.Drawing.Point(189, 50);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(288, 330);
            this.pnl_info.TabIndex = 9;
            // 
            // txtB_degree_info
            // 
            this.txtB_degree_info.Location = new System.Drawing.Point(24, 208);
            this.txtB_degree_info.Name = "txtB_degree_info";
            this.txtB_degree_info.Size = new System.Drawing.Size(241, 22);
            this.txtB_degree_info.TabIndex = 14;
            this.txtB_degree_info.TextChanged += new System.EventHandler(this.txtB_degree_info_TextChanged);
            // 
            // lbl_degree_info
            // 
            this.lbl_degree_info.AutoSize = true;
            this.lbl_degree_info.Location = new System.Drawing.Point(21, 187);
            this.lbl_degree_info.Name = "lbl_degree_info";
            this.lbl_degree_info.Size = new System.Drawing.Size(208, 17);
            this.lbl_degree_info.TabIndex = 13;
            this.lbl_degree_info.Text = "Данные о дипломе бакалавра";
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.Location = new System.Drawing.Point(162, 282);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(123, 40);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_prev.Location = new System.Drawing.Point(3, 282);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(123, 40);
            this.btn_prev.TabIndex = 11;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ok.Location = new System.Drawing.Point(162, 236);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(123, 40);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "Добавить";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pnl_search
            // 
            this.pnl_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_search.Controls.Add(this.btn_search);
            this.pnl_search.Controls.Add(this.txtB_value);
            this.pnl_search.Controls.Add(this.lbl_value);
            this.pnl_search.Controls.Add(this.lbl_field);
            this.pnl_search.Controls.Add(this.cmbb_field);
            this.pnl_search.Controls.Add(this.lbl_search);
            this.pnl_search.Location = new System.Drawing.Point(189, 398);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(288, 222);
            this.pnl_search.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search.Location = new System.Drawing.Point(83, 142);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 40);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txtB_value
            // 
            this.txtB_value.Location = new System.Drawing.Point(24, 114);
            this.txtB_value.Name = "txtB_value";
            this.txtB_value.Size = new System.Drawing.Size(241, 22);
            this.txtB_value.TabIndex = 4;
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(21, 94);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(73, 17);
            this.lbl_value.TabIndex = 3;
            this.lbl_value.Text = "Значение";
            // 
            // lbl_field
            // 
            this.lbl_field.AutoSize = true;
            this.lbl_field.Location = new System.Drawing.Point(21, 47);
            this.lbl_field.Name = "lbl_field";
            this.lbl_field.Size = new System.Drawing.Size(42, 17);
            this.lbl_field.TabIndex = 2;
            this.lbl_field.Text = "Поле";
            // 
            // cmbb_field
            // 
            this.cmbb_field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbb_field.FormattingEnabled = true;
            this.cmbb_field.Location = new System.Drawing.Point(24, 67);
            this.cmbb_field.Name = "cmbb_field";
            this.cmbb_field.Size = new System.Drawing.Size(241, 24);
            this.cmbb_field.TabIndex = 1;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(21, 17);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(48, 17);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "Поиск";
            // 
            // pnl_line
            // 
            this.pnl_line.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_line.Location = new System.Drawing.Point(192, 390);
            this.pnl_line.Name = "pnl_line";
            this.pnl_line.Size = new System.Drawing.Size(288, 2);
            this.pnl_line.TabIndex = 10;
            // 
            // frm_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 649);
            this.Controls.Add(this.pnl_line);
            this.Controls.Add(this.pnl_search);
            this.Controls.Add(this.pnl_info);
            this.Controls.Add(this.mnS_main);
            this.MainMenuStrip = this.mnS_main;
            this.Name = "frm_students";
            this.Text = "Студенты";
            this.mnS_main.ResumeLayout(false);
            this.mnS_main.PerformLayout();
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnS_main;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem следующийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предыдущийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьМагистромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьБакалавромToolStripMenuItem;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_faculty;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.TextBox txtB_firstname;
        private System.Windows.Forms.TextBox txtB_lastname;
        private System.Windows.Forms.TextBox txtB_faculty;
        private System.Windows.Forms.ComboBox cmbb_degree;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtB_value;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_field;
        private System.Windows.Forms.ComboBox cmbb_field;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Panel pnl_line;
        private System.Windows.Forms.TextBox txtB_degree_info;
        private System.Windows.Forms.Label lbl_degree_info;
    }
}

