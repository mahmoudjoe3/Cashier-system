using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacharSystem
{
    public partial class RegisterationForm : Form
    {
        int mov;
        int movX;
        int movY;

        public RegisterationForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            LoginForm login_form = new LoginForm();
            this.Hide();
            login_form.Show();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void ToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void name_MouseClick(object sender, MouseEventArgs e)
        {
            if (name.ForeColor != Color.White)
            {
                name.ForeColor = Color.White;
                name.Text = "";
            }
        }

        private void pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (pass.ForeColor != Color.White)
            {
                pass.ForeColor = Color.White;
                pass.Text = "";
            }
        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            if (email.ForeColor != Color.White)
            {
                email.ForeColor = Color.White;
                email.Text = "";
            }
        }

        private void re_pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (re_pass.ForeColor != Color.White)
            {
                re_pass.ForeColor = Color.White;
                re_pass.Text = "";
            }
        }

        private void pass_check_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_check.Checked)
            {
                pass.isPassword = false;
            }
            else
                pass.isPassword = true;
        }

        private void repass_check_CheckedChanged(object sender, EventArgs e)
        {
            if (repass_check.Checked)
                re_pass.isPassword = false;
            else
                re_pass.isPassword = true;
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            registeration_process();
        }
        private void registeration_process()
        {
        }

    }
}
