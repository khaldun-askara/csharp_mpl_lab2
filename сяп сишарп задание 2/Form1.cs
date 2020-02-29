using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace сяп_сишарп_задание_2
{
    public partial class frm_students : Form
    {
        private string current_file_name;
        private Students current_list_of_student;

        private BySomething current_filter = new BySomething(a=>true);

        public void SearchOff()
        {
            current_filter = new BySomething(a=>true);
            cmbb_field.SelectedItem = null;
            txtB_value.Text = "";
        }
        public void BlockInfo()
        {
            txtB_firstname.Text = txtB_lastname.Text = txtB_faculty.Text = "";
            cmbb_degree.SelectedItem = null;
            txtB_degree_info.Visible = lbl_degree_info.Visible = btn_ok.Visible = false;
            txtB_firstname.Enabled = txtB_lastname.Enabled = txtB_faculty.Enabled = cmbb_degree.Enabled = false;
            
        }
        public void EnableTxtB()
        {
            txtB_firstname.Enabled = txtB_lastname.Enabled = txtB_faculty.Enabled = cmbb_degree.Enabled = true;
        }
        public void Editing()
        {
            сохранитьToolStripMenuItem.Enabled = следующийToolStripMenuItem.Enabled = предыдущийToolStripMenuItem.Enabled
                = редактироватьToolStripMenuItem.Enabled = удалитьToolStripMenuItem.Enabled = добавитьToolStripMenuItem.Enabled
                = сделатьБакалавромToolStripMenuItem.Enabled = сделатьМагистромToolStripMenuItem.Enabled = false;
            btn_next.Enabled = btn_prev.Enabled = false;
        }
        public frm_students()
        {
            InitializeComponent();
            BlockInfo();
            btn_next.Enabled = btn_prev.Enabled = btn_search.Enabled = btn_reset.Enabled = false;
            cmbb_degree.Items.Add("Бакалавр");
            cmbb_degree.Items.Add("Магистр");
            cmbb_field.Items.Add("Имя");
            cmbb_field.Items.Add("Фамилия");
            cmbb_field.Items.Add("Факультет");
            Editing();
            txtB_value.Enabled = cmbb_field.Enabled = false;
        }

        private void ShowCurrStudent()
        {
            if (!current_list_of_student.Curr_student.HasValue)
            {
                BlockInfo();
                Editing();
                if (txtB_value.Text == "" || txtB_value.Text == null)
                    txtB_value.Enabled = cmbb_field.Enabled = false;
                return;
            }
            Student curr_student = current_list_of_student.All_students[current_list_of_student.Curr_student.Value];
            txtB_firstname.Text = curr_student.first_name;
            txtB_lastname.Text = curr_student.last_name;
            txtB_faculty.Text = curr_student.faculty;
            if (curr_student.GetType() == typeof(Master))
            {
                cmbb_degree.SelectedItem = cmbb_degree.Items[1];
                Master temp = (Master)curr_student;
                txtB_degree_info.Text = temp.degree_info;
            }
            if (curr_student.GetType() == typeof(Bachelor))
                cmbb_degree.SelectedItem = cmbb_degree.Items[0];

            сохранитьToolStripMenuItem.Enabled = следующийToolStripMenuItem.Enabled = предыдущийToolStripMenuItem.Enabled
                = редактироватьToolStripMenuItem.Enabled = удалитьToolStripMenuItem.Enabled = добавитьToolStripMenuItem.Enabled = true;

            if ((string)cmbb_degree.SelectedItem == "Магистр")
                сделатьБакалавромToolStripMenuItem.Enabled = true;
            if ((string)cmbb_degree.SelectedItem == "Бакалавр")
                сделатьМагистромToolStripMenuItem.Enabled = true;

            btn_next.Enabled = btn_prev.Enabled = true;
            if (current_list_of_student.Curr_student == current_list_of_student.Search_first)
                btn_prev.Enabled = false;
            if (current_list_of_student.Curr_student == current_list_of_student.Search_last)
                btn_next.Enabled = false;
            следующийToolStripMenuItem.Enabled = btn_next.Enabled;
            предыдущийToolStripMenuItem.Enabled = btn_prev.Enabled;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            current_file_name = dlg.FileName;
            EnableTxtB();
            List<Student> temp_list = new List<Student>();

            var xs = new XmlSerializer(typeof(List<Student>));
            using (var fs = new FileStream(current_file_name, FileMode.Open))
            {
                try
                {
                    temp_list = (List<Student>)xs.Deserialize(fs);
                }
                catch(Exception eee)
                {
                    MessageBox.Show("Беды с файлом. " + eee.Message);
                    return;
                }
            }

            current_list_of_student = new Students(temp_list);
            SearchOff();
            current_list_of_student.Searching(current_filter);
            ShowCurrStudent();

            txtB_value.Enabled = cmbb_field.Enabled = true;
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            добавитьToolStripMenuItem_Click(sender, e);
            if (current_list_of_student == null)
                current_list_of_student = new Students();
            else current_list_of_student.Clean();
            Editing();
            EnableTxtB();
            SearchOff();
        }

        private void cmbb_degree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmbb_degree.SelectedItem == "Магистр")
                lbl_degree_info.Visible = txtB_degree_info.Visible = true;
            else
            {
                lbl_degree_info.Visible = txtB_degree_info.Visible = false;
                txtB_degree_info.Text = "";
            }
            data_intered();
        }
        private void search_data_intered()
        {
            btn_search.Enabled = btn_reset.Enabled = cmbb_field.SelectedItem != null && txtB_value.Text != "" && txtB_value.Text != null;
        }
        private void data_intered()
        {
            if (txtB_firstname.Text != "" && txtB_firstname.Text != null
                && txtB_lastname.Text != "" && txtB_lastname.Text != null
                && txtB_faculty.Text != "" && txtB_faculty.Text != null
                && cmbb_degree.SelectedItem != null)
                if ((string)cmbb_degree.SelectedItem == "Магистр" && txtB_degree_info.Text != ""
                    && txtB_degree_info.Text != null || (string)cmbb_degree.SelectedItem != "Магистр")
                {
                    btn_ok.Enabled = true;
                    return;
                }
            btn_ok.Enabled = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (btn_ok.Text == "Ок")
                try
                {
                    current_list_of_student.All_students[current_list_of_student.Curr_student.Value].ChangeInfo(txtB_firstname.Text, txtB_lastname.Text,
                          txtB_faculty.Text);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

            try
            {
                if (btn_ok.Text == "Ок")
                {
                    if ((string)cmbb_degree.SelectedItem == "Магистр")
                    {
                        Master temp = (Master)current_list_of_student.All_students[current_list_of_student.Curr_student.Value];
                        temp.ChangeInfo(txtB_firstname.Text, txtB_lastname.Text,
                            txtB_faculty.Text, txtB_degree_info.Text);
                    }
                    else current_list_of_student.All_students[current_list_of_student.Curr_student.Value].ChangeInfo(txtB_firstname.Text, txtB_lastname.Text,
                            txtB_faculty.Text);
                    btn_ok.Visible = false;
                    ShowCurrStudent();
                    return;
                }
                if ((string)cmbb_degree.SelectedItem == "Магистр")
                    current_list_of_student.AddStudent(txtB_firstname.Text,
                        txtB_lastname.Text, txtB_faculty.Text, txtB_degree_info.Text);
                else current_list_of_student.AddStudent(txtB_firstname.Text,
                        txtB_lastname.Text, txtB_faculty.Text);
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
                return;
            }
            btn_ok.Visible = false;
            current_list_of_student.Searching(current_filter);

            ShowCurrStudent();
            txtB_value.Enabled = cmbb_field.Enabled = true;
        }

        private void txtB_firstname_TextChanged(object sender, EventArgs e)
        {
            data_intered();
        }

        private void txtB_lastname_TextChanged(object sender, EventArgs e)
        {
            data_intered();
        }

        private void txtB_faculty_TextChanged(object sender, EventArgs e)
        {
            data_intered();
        }

        private void txtB_degree_info_TextChanged(object sender, EventArgs e)
        {
            data_intered();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB_firstname.Text = txtB_lastname.Text = txtB_faculty.Text = "";
            cmbb_degree.SelectedItem = null;
            txtB_firstname.Enabled = txtB_lastname.Enabled = txtB_faculty.Enabled = cmbb_degree.Enabled = true;
            btn_ok.Text = "Добавить";
            btn_ok.Visible = true;
            btn_ok.Enabled = false;
            Editing();
            EnableTxtB();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current_list_of_student.DeleteCurrStudent();
            //Editing();
            current_list_of_student.Searching(current_filter);
            ShowCurrStudent();
            добавитьToolStripMenuItem.Enabled = true;
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editing();
            btn_ok.Visible = true;
            btn_ok.Enabled = false;
            btn_ok.Text = "Ок";
            data_intered();
            EnableTxtB();
        }

        private void сделатьМагистромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student curr_student = current_list_of_student.All_students[current_list_of_student.Curr_student.Value];
            Editing();
            Master temp = new Master(curr_student.first_name, curr_student.last_name, curr_student.faculty, "");
            current_list_of_student.DeleteCurrStudent();
            current_list_of_student.AddStudent(temp);
            cmbb_degree.SelectedItem = cmbb_degree.Items[1];
            ShowCurrStudent();
            редактироватьToolStripMenuItem_Click(sender, e);
        }

        private void сделатьБакалавромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student curr_student = current_list_of_student.All_students[current_list_of_student.Curr_student.Value];
            Editing();
            Bachelor temp = new Bachelor(curr_student.first_name, curr_student.last_name, curr_student.faculty);
            current_list_of_student.DeleteCurrStudent();
            current_list_of_student.AddStudent(temp);
            cmbb_degree.SelectedItem = cmbb_degree.Items[0];
            ShowCurrStudent();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            current_list_of_student.Prev(current_filter);
            ShowCurrStudent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            current_list_of_student.Next(current_filter);
            ShowCurrStudent();
        }

        private void следующийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_next_Click(sender, e);
        }

        private void предыдущийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_prev_Click(sender, e);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "XML файлы(*.xml)|*.xml";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            current_file_name = dlg.FileName;

            var xs = new XmlSerializer(typeof(List<Student>));
            using (var fs = new FileStream(current_file_name, FileMode.Create))
            {
                try
                {
                    xs.Serialize(fs, current_list_of_student.All_students);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
            }
        }

        private void cmbb_field_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_data_intered();
        }

        private void txtB_value_TextChanged(object sender, EventArgs e)
        {
            search_data_intered();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try { NameConversion.FirstCapitalOthersNot(txtB_value.Text); }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
            switch (cmbb_field.SelectedIndex)
            {
                case 0: current_filter = new BySomething(a => a.first_name == NameConversion.FirstCapitalOthersNot(txtB_value.Text)); break;
                case 1: current_filter = new BySomething(a => a.last_name == NameConversion.FirstCapitalOthersNot(txtB_value.Text)); break;
                case 2: current_filter = new BySomething(a => a.faculty == NameConversion.FirstCapitalOthersNot(txtB_value.Text)); break;
            }
            current_list_of_student.Searching(current_filter);
            ShowCurrStudent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            SearchOff();
            current_list_of_student.Searching(current_filter);
            current_list_of_student.Curr_student = 0;
            ShowCurrStudent();
        }
    }
}
