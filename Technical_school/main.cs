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
    public partial class main : Form
    {
        Form1 f = new Form1();
        //Entities db = new Entities();
        school_Entities db = new school_Entities();
        private string m_user = "";
        public static string m_name = "";
        private int course_id = 0;
        private bool check = true;
        public main()
        {
            InitializeComponent();
           
        }

        public static string GetPersianDate(DateTime date)
        {
            PersianCalendar jc = new PersianCalendar();
            return string.Format("{0:0000}/{1:00}/{2:00}", jc.GetYear(date), jc.GetMonth(date), jc.GetDayOfMonth(date));
        }

        public static void set_grid_design(DataGridView d)
        {
            int columnCount = d.Columns.Count;

            //If we want the last column to fill the remaining space
            int lastColumnIndex = columnCount - 1;

            foreach (DataGridViewColumn column in d.Columns)
            {
                if (column.Index == columnCount - lastColumnIndex) //Last column will fill extra space
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else //Any other column will be sized based on the max content size
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            d.ScrollBars = ScrollBars.Both;
        }

        public static void set_valueTo_row(DataGridView d)
        {
            for (int i = 0; i < d.Rows.Count; i++)
            {
                d.Rows[i].HeaderCell.Value = Convert.ToString(i+1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            m_user = Form1.m_user;
            this.Size = new Size(720, 480);
            label3.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;

            var result = (from row in db.intern_tbl
                where row.intern_national_code == m_user
                select row.intern_name).ToList();

            var list = result.ToList();

            foreach (string intern in list)
            {
                m_name = intern;
            }

            main m=new main();
            m.Text = m_name;


        }


        private void main_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void main_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void cource_label_enter(object sender, EventArgs e)
        {
            label5.BackColor = System.Drawing.Color.Chartreuse;

        }

        private void course_label_leave(object sender, EventArgs e)
        {
            label5.BackColor = System.Drawing.Color.Transparent;
        }

        private void master_label_enter(object sender, EventArgs e)
        {
            label4.BackColor = System.Drawing.Color.Chartreuse;
        }

        private void master_label_leave(object sender, EventArgs e)
        {
            label4.BackColor = System.Drawing.Color.Transparent;
        }

        private void register_label_enter(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Chartreuse;
        }

        private void register_label_leave(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void show_course_Click(object sender, EventArgs e)
        {
            data_set.Visible = true;
            data_set.DataSource = null;
            var result = (from row in db.course_tbl  join  row2  in db.master_tbl on row.master_personal_code 
                    equals row2.personal_code
                          where row2.personal_code == row.master_personal_code
                select new
                {
                    row.course_name,
                    row.course_level,
                    row2.master_name
              
                });

          
            data_set.DataSource = result.ToList();

            data_set.Columns[0].HeaderText = "اسم دوره";
            data_set.Columns[1].HeaderText = "سطح دوره";
            data_set.Columns[2].HeaderText = "نام استاد";
            set_grid_design(data_set);
            set_valueTo_row(data_set);
            data_set.Update();
        }

        private void show_master_click(object sender, EventArgs e)
        {
            var result = (from row in db.master_tbl
                select new
                {
                    row.master_name,
                    row.master_skill
                });


            data_set.DataSource = result.ToList();

            data_set.Columns[0].HeaderText = "نام استاد";
            data_set.Columns[1].HeaderText = "مهارت استاد";
            set_grid_design(data_set);
            set_valueTo_row(data_set);
            data_set.Update();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //
            System.Windows.Forms.MessageBox.Show("برای ثبت نام ابتدا به قسمت نمایش دوره ها بروید و سپس روی نام دوره کلیک فرمایید", "توجه",
                System.Windows.Forms.MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void cell_cleck(object sender, DataGridViewCellEventArgs e)
        {
            data_set.Visible = false;
            user_label.Text = m_name;
            course_label.Text = data_set.SelectedCells[e.ColumnIndex].Value.ToString();
           //ourse_id = Convert.ToInt32(data_set.Rows[e.RowIndex]);
           course_id = Convert.ToInt32(data_set.CurrentCell.RowIndex)+1;
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            register_tbl register= new register_tbl();
            DateTime d= DateTime.Now;
            string p_d = GetPersianDate(d);
            register.register_date = DateTime.Parse(p_d).Date;
            register.intern_national_code = m_user;
            //gister.course_id =data_set.SelectedCells
            register.course_id = course_id;

            db.register_tbl.Add(register);

            try
            {
                db.SaveChanges();
                System.Windows.Forms.MessageBox.Show("با موفقیت ثبت نام شدید", "اعلان ثبت نام",
                System.Windows.Forms.MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                data_set.Visible = true;
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show("مشکلی در درج اطلاعات وجود دارد مقادیر را بازبینی کنید", "اخطار",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


            
        }

        private void edit_mouse_enter(object sender, EventArgs e)
        {
            label8.BackColor = System.Drawing.Color.Chartreuse;
        }

        private void edit_mouse_leave(object sender, EventArgs e)
        {
            label8.BackColor = System.Drawing.Color.Transparent;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            show_course_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox3_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            show_master_click(sender, e);
        }

        private void course_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            edit_user eu= new edit_user();
            this.Hide();
            eu.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            edit_user eu = new edit_user();
            this.Hide();
            eu.ShowDialog();
        }
    }
}
