namespace Technical_school
{
    partial class edit_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_user));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.hide_pass = new System.Windows.Forms.PictureBox();
            this.show_pass = new System.Windows.Forms.PictureBox();
            this.date_label = new System.Windows.Forms.Label();
            this.undo_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.edit_pass2 = new System.Windows.Forms.TextBox();
            this.edit_pass1 = new System.Windows.Forms.TextBox();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.show_course_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.main_exit = new System.Windows.Forms.PictureBox();
            this.main_back = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_pass)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.faDatePicker1);
            this.panel1.Controls.Add(this.hide_pass);
            this.panel1.Controls.Add(this.show_pass);
            this.panel1.Controls.Add(this.date_label);
            this.panel1.Controls.Add(this.undo_btn);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.edit_pass2);
            this.panel1.Controls.Add(this.edit_pass1);
            this.panel1.Controls.Add(this.edit_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(408, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 293);
            this.panel1.TabIndex = 0;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(159, 118);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(215, 25);
            this.faDatePicker1.TabIndex = 13;
            // 
            // hide_pass
            // 
            this.hide_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_pass.BackgroundImage")));
            this.hide_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide_pass.Location = new System.Drawing.Point(16, 170);
            this.hide_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hide_pass.Name = "hide_pass";
            this.hide_pass.Size = new System.Drawing.Size(75, 34);
            this.hide_pass.TabIndex = 12;
            this.hide_pass.TabStop = false;
            this.hide_pass.Click += new System.EventHandler(this.hide_pass_Click);
            // 
            // show_pass
            // 
            this.show_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_pass.BackgroundImage")));
            this.show_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_pass.Location = new System.Drawing.Point(16, 170);
            this.show_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(75, 34);
            this.show_pass.TabIndex = 11;
            this.show_pass.TabStop = false;
            this.show_pass.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // date_label
            // 
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.date_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.date_label.Location = new System.Drawing.Point(236, 86);
            this.date_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(133, 28);
            this.date_label.TabIndex = 10;
            this.date_label.Text = "0000-00-00";
            // 
            // undo_btn
            // 
            this.undo_btn.BackColor = System.Drawing.Color.Cyan;
            this.undo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.undo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.undo_btn.Location = new System.Drawing.Point(107, 236);
            this.undo_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(125, 38);
            this.undo_btn.TabIndex = 9;
            this.undo_btn.Text = "مقادیر پیشفرض";
            this.undo_btn.UseVisualStyleBackColor = false;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.save_btn.Location = new System.Drawing.Point(240, 236);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(133, 38);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "ذخیره تغییرات";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // edit_pass2
            // 
            this.edit_pass2.Location = new System.Drawing.Point(99, 170);
            this.edit_pass2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit_pass2.Multiline = true;
            this.edit_pass2.Name = "edit_pass2";
            this.edit_pass2.PasswordChar = '*';
            this.edit_pass2.Size = new System.Drawing.Size(132, 24);
            this.edit_pass2.TabIndex = 6;
            // 
            // edit_pass1
            // 
            this.edit_pass1.Location = new System.Drawing.Point(240, 170);
            this.edit_pass1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit_pass1.Multiline = true;
            this.edit_pass1.Name = "edit_pass1";
            this.edit_pass1.PasswordChar = '*';
            this.edit_pass1.Size = new System.Drawing.Size(132, 24);
            this.edit_pass1.TabIndex = 5;
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(203, 21);
            this.edit_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit_name.Multiline = true;
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(165, 46);
            this.edit_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(381, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "رمز عبور جدید";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(381, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاریخ تولد";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(353, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.show_course_btn);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 353);
            this.panel2.TabIndex = 1;
            // 
            // show_course_btn
            // 
            this.show_course_btn.BackColor = System.Drawing.Color.Purple;
            this.show_course_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_course_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.show_course_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_course_btn.Location = new System.Drawing.Point(80, 310);
            this.show_course_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_course_btn.Name = "show_course_btn";
            this.show_course_btn.Size = new System.Drawing.Size(211, 39);
            this.show_course_btn.TabIndex = 1;
            this.show_course_btn.Text = "نمایش دوره های ثبت نام شده";
            this.show_course_btn.UseVisualStyleBackColor = false;
            this.show_course_btn.Click += new System.EventHandler(this.show_course_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(4, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(376, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(89, 507);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "بازگشت";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(20, 507);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "خروج";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // main_exit
            // 
            this.main_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_exit.BackgroundImage")));
            this.main_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_exit.Location = new System.Drawing.Point(20, 443);
            this.main_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_exit.Name = "main_exit";
            this.main_exit.Size = new System.Drawing.Size(61, 60);
            this.main_exit.TabIndex = 13;
            this.main_exit.TabStop = false;
            this.main_exit.Click += new System.EventHandler(this.main_exit_Click);
            // 
            // main_back
            // 
            this.main_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_back.BackgroundImage")));
            this.main_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_back.Location = new System.Drawing.Point(89, 443);
            this.main_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_back.Name = "main_back";
            this.main_back.Size = new System.Drawing.Size(76, 62);
            this.main_back.TabIndex = 12;
            this.main_back.TabStop = false;
            this.main_back.Click += new System.EventHandler(this.main_back_Click);
            // 
            // edit_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.main_exit);
            this.Controls.Add(this.main_back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "edit_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش اطلاعات";
            this.Load += new System.EventHandler(this.edit_user_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_pass)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox edit_pass2;
        private System.Windows.Forms.TextBox edit_pass1;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button show_course_btn;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.PictureBox show_pass;
        private System.Windows.Forms.PictureBox hide_pass;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox main_exit;
        private System.Windows.Forms.PictureBox main_back;
    }
}