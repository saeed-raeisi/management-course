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
    public partial class register : Form
    {

        school_Entities db = new school_Entities();
        public register()
        {
            InitializeComponent();
        }
        public static string GetPersianDate( DateTime date)
        {
            PersianCalendar jc = new PersianCalendar();
            return string.Format("{0:0000}/{1:00}/{2:00}", jc.GetYear(date), jc.GetMonth(date), jc.GetDayOfMonth(date));
        }
        private void register_Load(object sender, EventArgs e)
        {
            this.Size = new Size(641, 457);
            label6.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            main_back.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime(2014, 05, 21);
            d = dateTimePicker1.Value;
            string s =GetPersianDate(d); //1393/02/31
            DateTime p_d = DateTime.Parse(s);

            if (String.IsNullOrEmpty(user_txt.Text) || String.IsNullOrEmpty(pass_txt.Text)
                                                    || String.IsNullOrEmpty(comboBox1.Text))
            {
                System.Windows.Forms.MessageBox.Show("لطفا تمام مقادیر را صحیح وارد نمایید را وارد نمایید", "اخطار",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {

                string user_name = user_txt.Text.ToString();
                string personal_code = pass_txt.Text.ToString();
                string job = comboBox1.Text.ToString();

                intern_tbl intern = new intern_tbl();
                intern.intern_name = user_name;
                intern.intern_job = job;
                intern.intern_national_code = personal_code;
                intern.intern_birthday = p_d.Date;
                intern.intern_password = personal_code;


                db.intern_tbl.Add(intern);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception exception)
                {
                    System.Windows.Forms.MessageBox.Show("مشکلی در درج اطلاعات وجود دارد مقادیر را بازبینی کنید", "اخطار",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    throw;
                }
                

            }

        }

        private void main_back_Click(object sender, EventArgs e)
        {
            Form1 f= new Form1();
            this.Hide();
            f.ShowDialog();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
