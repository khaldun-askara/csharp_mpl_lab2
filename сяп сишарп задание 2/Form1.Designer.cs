﻿namespace сяп_сишарп_задание_2
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.lbl_search = new System.Windows.Forms.Label();
            this.cmbb_field = new System.Windows.Forms.ComboBox();
            this.lbl_field = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.txtB_value = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.mnS_main.Size = new System.Drawing.Size(667, 30);
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.следующийToolStripMenuItem,
            this.предыдущийToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // следующийToolStripMenuItem
            // 
            this.следующийToolStripMenuItem.Name = "следующийToolStripMenuItem";
            this.следующийToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.следующийToolStripMenuItem.Text = "Следующий";
            // 
            // предыдущийToolStripMenuItem
            // 
            this.предыдущийToolStripMenuItem.Name = "предыдущийToolStripMenuItem";
            this.предыдущийToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.предыдущийToolStripMenuItem.Text = "Предыдущий";
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
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // сделатьМагистромToolStripMenuItem
            // 
            this.сделатьМагистромToolStripMenuItem.Name = "сделатьМагистромToolStripMenuItem";
            this.сделатьМагистромToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.сделатьМагистромToolStripMenuItem.Text = "Сделать магистром";
            // 
            // сделатьБакалавромToolStripMenuItem
            // 
            this.сделатьБакалавромToolStripMenuItem.Name = "сделатьБакалавромToolStripMenuItem";
            this.сделатьБакалавромToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.сделатьБакалавромToolStripMenuItem.Text = "Сделать бакалавром";
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
            // 
            // txtB_lastname
            // 
            this.txtB_lastname.Location = new System.Drawing.Point(24, 69);
            this.txtB_lastname.Name = "txtB_lastname";
            this.txtB_lastname.Size = new System.Drawing.Size(241, 22);
            this.txtB_lastname.TabIndex = 6;
            // 
            // txtB_faculty
            // 
            this.txtB_faculty.Location = new System.Drawing.Point(24, 114);
            this.txtB_faculty.Name = "txtB_faculty";
            this.txtB_faculty.Size = new System.Drawing.Size(241, 22);
            this.txtB_faculty.TabIndex = 7;
            // 
            // cmbb_degree
            // 
            this.cmbb_degree.FormattingEnabled = true;
            this.cmbb_degree.Location = new System.Drawing.Point(24, 160);
            this.cmbb_degree.Name = "cmbb_degree";
            this.cmbb_degree.Size = new System.Drawing.Size(241, 24);
            this.cmbb_degree.TabIndex = 8;
            // 
            // pnl_info
            // 
            this.pnl_info.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.pnl_info.Size = new System.Drawing.Size(288, 295);
            this.pnl_info.TabIndex = 9;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ok.Location = new System.Drawing.Point(162, 190);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(123, 40);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "Добавить";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_prev.Location = new System.Drawing.Point(3, 236);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(123, 40);
            this.btn_prev.TabIndex = 11;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.Location = new System.Drawing.Point(162, 236);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(123, 40);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // pnl_search
            // 
            this.pnl_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_search.Controls.Add(this.button1);
            this.pnl_search.Controls.Add(this.txtB_value);
            this.pnl_search.Controls.Add(this.lbl_value);
            this.pnl_search.Controls.Add(this.lbl_field);
            this.pnl_search.Controls.Add(this.cmbb_field);
            this.pnl_search.Controls.Add(this.lbl_search);
            this.pnl_search.Location = new System.Drawing.Point(189, 359);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(288, 222);
            this.pnl_search.TabIndex = 9;
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
            // cmbb_field
            // 
            this.cmbb_field.FormattingEnabled = true;
            this.cmbb_field.Location = new System.Drawing.Point(24, 67);
            this.cmbb_field.Name = "cmbb_field";
            this.cmbb_field.Size = new System.Drawing.Size(241, 24);
            this.cmbb_field.TabIndex = 1;
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
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(21, 94);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(73, 17);
            this.lbl_value.TabIndex = 3;
            this.lbl_value.Text = "Значение";
            // 
            // txtB_value
            // 
            this.txtB_value.Location = new System.Drawing.Point(24, 114);
            this.txtB_value.Name = "txtB_value";
            this.txtB_value.Size = new System.Drawing.Size(241, 22);
            this.txtB_value.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(83, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnl_line
            // 
            this.pnl_line.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_line.Location = new System.Drawing.Point(189, 351);
            this.pnl_line.Name = "pnl_line";
            this.pnl_line.Size = new System.Drawing.Size(288, 2);
            this.pnl_line.TabIndex = 10;
            // 
            // frm_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 632);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtB_value;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_field;
        private System.Windows.Forms.ComboBox cmbb_field;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Panel pnl_line;
    }
}

