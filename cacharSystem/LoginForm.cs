using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacharSystem
{
    public partial class LoginForm : Form
    {

        int mov;
        int movX;
        int movY;

        public LoginForm()
        {
            Thread thread = new Thread(new ThreadStart(formRun));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread.Abort();
        }

        private void formRun()
        {
            Application.Run(new Form_Splash());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            if (email.ForeColor != Color.White)
            {
                email.Text = "";
                email.ForeColor = Color.White;
            }
        }

        

        private void pass_check_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_check.Checked)
                pass.isPassword = false;
            else
                pass.isPassword = true;
        }

        private void pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (pass.ForeColor != Color.White)
            {
                pass.Text = "";
                pass.ForeColor = Color.White;
            }
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            RegisterationForm form = new RegisterationForm();
            this.Hide();
            form.Show();
            login_process();
        }

        private void login_process()
        {
            //write the login process here
        }

    }
}
