using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technical_school
{
    public partial class Form1 : Form
    {
        //Entities db = new Entities();
        school_Entities db=new school_Entities();
        public static string m_user = "";
        private string m_name;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // custom Design
            this.Size = new Size(641, 457);
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            checkBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user_txt.Text) || String.IsNullOrEmpty(pass_txt.Text))
            {
                System.Windows.Forms.MessageBox.Show("لطفا نام کاربری و رمز عبور را وارد نمایید", "اخطار",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            else if(!checkBox1.Checked)
            {
               
                //var result = db.course_tbl.ToList();
                string user = user_txt.Text;
                string pass = pass_txt.Text;
                m_user = user;
                
                var result = db.intern_tbl
                    .Where(s => s.intern_national_code.Equals(user) && s.intern_password.Equals(pass));

                if (result.Any())
                    {
                    var result_name = (from row in db.intern_tbl
                                  where row.intern_national_code == m_user
                                  select row.intern_name).ToList();

                    var list = result_name.ToList();

                    foreach (string intern in list)
                    {
                        m_name = intern;
                    }

                    System.Windows.Forms.MessageBox.Show(" سلام " + m_name + "", "خوش آمدید",
                      System.Windows.Forms.MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    this.Hide();
                        main show_main = new main();
                        show_main.ShowDialog();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("لطفا نام کاربری و رمز عبور صحبح را وارد نمایید", "اخطار",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    
            }
            else if(checkBox1.Checked)
            {
                string user = user_txt.Text;
                string pass = pass_txt.Text;
                m_user = user;
                var result = db.master_tbl
                    .Where(s => s.personal_code.Equals(user) && s.master_password.Equals(pass_txt.Text));
                if (result.Any())
                {
                    this.Hide();
                    main show_main = new main();
                    show_main.ShowDialog();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("لطفا نام کاربری و رمز عبور صحبح را وارد نمایید", "اخطار",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
           // this.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            register r=new register();
            r.Show();
        }
    }
}
