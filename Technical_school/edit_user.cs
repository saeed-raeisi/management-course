using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technical_school
{
    public partial class edit_user : Form
    {
        school_Entities db = new school_Entities();
        private string e_user = "";
        private string e_name = "";

        public edit_user()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void edit_user_Load(object sender, EventArgs e)
        {

            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            main_back.BackColor = System.Drawing.Color.Transparent;
            main_exit.BackColor = System.Drawing.Color.Transparent;

            hide_pass.Visible = false;
            show_pass.Visible = true;
            edit_name.Text= main.m_name.ToString();
            e_user = Form1.m_user;
            e_name = main.m_name.ToString();
            var result = from row in db.intern_tbl
                where row.intern_national_code == e_user
                select new
                {
                    row.intern_birthday,
                    row.intern_job,
                    row.intern_name,
                    row.intern_password
                };

            var list = result.ToList();

            date_label.Text =list.Single().intern_birthday.ToString();
            string d = register.GetPersianDate(list.Single().intern_birthday.Value);
            date_label.Text = d;
           // edit_name.Text = result.GetType().ToString()+ list.GetType().ToString();
            faDatePicker1.Text = d;

            Application.CurrentCulture = new CultureInfo("fa-IR");
            //date.Format = DateTimePickerFormat.Custom;
            //date.CustomFormat = Application.CurrentCulture.DateTimeFormat.ShortDatePattern;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            show_pass.Visible = false;
            hide_pass.Visible = true;
            edit_pass1.PasswordChar = '\0';
            edit_pass2.PasswordChar = '\0';

        }

        private void hide_pass_Click(object sender, EventArgs e)
        {
            show_pass.Visible = true;
            hide_pass.Visible = false;
            edit_pass1.PasswordChar = '*';
            edit_pass2.PasswordChar = '*';
        }

        private void main_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void main_back_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Hide();
            m.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Hide();
            m.ShowDialog();
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            var result = from row in db.intern_tbl
                where row.intern_national_code == e_user
                select new
                {
                    row.intern_birthday,
                    row.intern_job,
                    row.intern_name,
                    row.intern_password
                };

            var list = result.ToList();

            date_label.Text = list.Single().intern_birthday.ToString();
            string d = register.GetPersianDate(list.Single().intern_birthday.Value);
            date_label.Text = d;
            edit_name.Text = list.Single().intern_name.ToString();
            faDatePicker1.Text = d;
        }

        private void show_course_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;
            var result = (from row in db.register_tbl
                where row.intern_national_code == e_user
                select new
                {
                    row.course_tbl.course_name,
                    row.course_tbl.master_tbl.master_name,
                    row.course_tbl.course_level,
                    row.register_date
                    //row.intern_tbl.intern_birthday

                });

           // result.Single().register_date.Date;

            dataGridView1.DataSource = result.ToList();

            dataGridView1.Columns[2].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView1.Columns[0].HeaderText = "اسم دوره";
            dataGridView1.Columns[1].HeaderText = "نام استاد";
            dataGridView1.Columns[2].HeaderText = "سطح دوره";
            dataGridView1.Columns[3].HeaderText = "تاریخ ثبت نام";
            //main.set_grid_design(dataGridView1);
            main.set_valueTo_row(dataGridView1);
            dataGridView1.Update();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            intern_tbl it = db.intern_tbl.Where(it1 => it1.intern_national_code == e_user).Single();
            it.intern_name = edit_name.Text;
            DateTime d = DateTime.Parse(faDatePicker1.Text);
            it.intern_birthday =d ;

            if(edit_pass1.Text!=edit_pass2.Text)
            {
                System.Windows.Forms.MessageBox.Show("رمز عبور با تایید آن تطابق ندارد ! ", "اخطار",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                it.intern_password = edit_pass1.Text;
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("مشکلی در اعمال تغییرات وجود دارد", "اخطار",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }

        }
    }
}
