namespace cacharSystem
{
    partial class RegisterationForm
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
            this.components = new System.ComponentModel.Container();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.back_home = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.repass_check = new System.Windows.Forms.CheckBox();
            this.pass_check = new System.Windows.Forms.CheckBox();
            this.re_pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.register_btn = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(44)))), ((int)(((byte)(123)))));
            this.ToolBar.Controls.Add(this.back_home);
            this.ToolBar.Controls.Add(this.minimize);
            this.ToolBar.Controls.Add(this.Exit);
            this.ToolBar.Controls.Add(this.label6);
            this.ToolBar.Controls.Add(this.label7);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(1000, 65);
            this.ToolBar.TabIndex = 7;
            this.ToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseDown);
            this.ToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseMove);
            this.ToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseUp);
            // 
            // back_home
            // 
            this.back_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_home.ForeColor = System.Drawing.Color.White;
            this.back_home.Location = new System.Drawing.Point(817, 12);
            this.back_home.Name = "back_home";
            this.back_home.Size = new System.Drawing.Size(104, 42);
            this.back_home.TabIndex = 13;
            this.back_home.Text = "Back to Login";
            this.back_home.UseVisualStyleBackColor = true;
            this.back_home.Click += new System.EventHandler(this.back_home_Click);
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(927, 19);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 28);
            this.minimize.TabIndex = 7;
            this.minimize.Text = "ـــــــــــــ";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(963, 19);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 28);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cashier System.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "M8 Companyْ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 2);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Register for Cashier System";
            // 
            // repass_check
            // 
            this.repass_check.AutoSize = true;
            this.repass_check.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repass_check.ForeColor = System.Drawing.Color.White;
            this.repass_check.Location = new System.Drawing.Point(888, 386);
            this.repass_check.Name = "repass_check";
            this.repass_check.Size = new System.Drawing.Size(57, 20);
            this.repass_check.TabIndex = 40;
            this.repass_check.Text = "Show";
            this.repass_check.UseVisualStyleBackColor = true;
            this.repass_check.CheckedChanged += new System.EventHandler(this.repass_check_CheckedChanged);
            // 
            // pass_check
            // 
            this.pass_check.AutoSize = true;
            this.pass_check.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_check.ForeColor = System.Drawing.Color.White;
            this.pass_check.Location = new System.Drawing.Point(888, 295);
            this.pass_check.Name = "pass_check";
            this.pass_check.Size = new System.Drawing.Size(57, 20);
            this.pass_check.TabIndex = 39;
            this.pass_check.Text = "Show";
            this.pass_check.UseVisualStyleBackColor = true;
            this.pass_check.CheckedChanged += new System.EventHandler(this.pass_check_CheckedChanged);
            // 
            // re_pass
            // 
            this.re_pass.BorderColorFocused = System.Drawing.Color.Silver;
            this.re_pass.BorderColorIdle = System.Drawing.Color.White;
            this.re_pass.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.re_pass.BorderThickness = 1;
            this.re_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.re_pass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.re_pass.ForeColor = System.Drawing.Color.Gray;
            this.re_pass.isPassword = true;
            this.re_pass.Location = new System.Drawing.Point(579, 374);
            this.re_pass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.re_pass.Name = "re_pass";
            this.re_pass.Size = new System.Drawing.Size(299, 45);
            this.re_pass.TabIndex = 38;
            this.re_pass.Text = "12345678...";
            this.re_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.re_pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.re_pass_MouseClick);
            // 
            // pass
            // 
            this.pass.BorderColorFocused = System.Drawing.Color.Silver;
            this.pass.BorderColorIdle = System.Drawing.Color.White;
            this.pass.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.pass.BorderThickness = 1;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.pass.ForeColor = System.Drawing.Color.Gray;
            this.pass.isPassword = true;
            this.pass.Location = new System.Drawing.Point(579, 282);
            this.pass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(299, 45);
            this.pass.TabIndex = 37;
            this.pass.Text = "12345678...";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_MouseClick);
            // 
            // email
            // 
            this.email.BorderColorFocused = System.Drawing.Color.Silver;
            this.email.BorderColorIdle = System.Drawing.Color.White;
            this.email.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.email.BorderThickness = 1;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.email.ForeColor = System.Drawing.Color.Gray;
            this.email.isPassword = false;
            this.email.Location = new System.Drawing.Point(77, 374);
            this.email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(299, 45);
            this.email.TabIndex = 36;
            this.email.Text = "Type your Email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.email_MouseClick);
            // 
            // name
            // 
            this.name.BorderColorFocused = System.Drawing.Color.Silver;
            this.name.BorderColorIdle = System.Drawing.Color.White;
            this.name.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.name.BorderThickness = 1;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.name.ForeColor = System.Drawing.Color.Gray;
            this.name.isPassword = false;
            this.name.Location = new System.Drawing.Point(77, 282);
            this.name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(299, 45);
            this.name.TabIndex = 35;
            this.name.Text = "Type your Full Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.name_MouseClick);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Black;
            this.register_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(737, 458);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(141, 50);
            this.register_btn.TabIndex = 34;
            this.register_btn.Text = "Register Now";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other..."});
            this.gender.Location = new System.Drawing.Point(78, 468);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(299, 29);
            this.gender.TabIndex = 33;
            this.gender.Text = "Select your Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(576, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Confirm Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(576, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(75, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(685, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "All fields are required";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "About You";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // RegisterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(44)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1000, 605);
            this.Controls.Add(this.repass_check);
            this.Controls.Add(this.pass_check);
            this.Controls.Add(this.re_pass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterationForm";
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox repass_check;
        private System.Windows.Forms.CheckBox pass_check;
        private Bunifu.Framework.UI.BunifuMetroTextbox re_pass;
        private Bunifu.Framework.UI.BunifuMetroTextbox pass;
        private Bunifu.Framework.UI.BunifuMetroTextbox email;
        private Bunifu.Framework.UI.BunifuMetroTextbox name;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_home;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}