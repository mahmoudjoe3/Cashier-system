﻿
namespace cacharSystem
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.codeTXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.userRadio = new System.Windows.Forms.RadioButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(124, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // codeTXT
            // 
            this.codeTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTXT.DefaultText = "";
            this.codeTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codeTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codeTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeTXT.DisabledState.Parent = this.codeTXT;
            this.codeTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeTXT.FocusedState.Parent = this.codeTXT;
            this.codeTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeTXT.HoverState.Parent = this.codeTXT;
            this.codeTXT.Location = new System.Drawing.Point(57, 195);
            this.codeTXT.Name = "codeTXT";
            this.codeTXT.PasswordChar = '\0';
            this.codeTXT.PlaceholderText = "";
            this.codeTXT.SelectedText = "";
            this.codeTXT.ShadowDecoration.Parent = this.codeTXT;
            this.codeTXT.Size = new System.Drawing.Size(233, 36);
            this.codeTXT.TabIndex = 2;
            this.codeTXT.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(54, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Your Code Please";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(173, 277);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(117, 36);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "LogIn";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadio.ForeColor = System.Drawing.SystemColors.Control;
            this.adminRadio.Location = new System.Drawing.Point(67, 237);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(75, 22);
            this.adminRadio.TabIndex = 5;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "Admin";
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // userRadio
            // 
            this.userRadio.AutoSize = true;
            this.userRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRadio.ForeColor = System.Drawing.SystemColors.Control;
            this.userRadio.Location = new System.Drawing.Point(148, 237);
            this.userRadio.Name = "userRadio";
            this.userRadio.Size = new System.Drawing.Size(87, 22);
            this.userRadio.TabIndex = 6;
            this.userRadio.TabStop = true;
            this.userRadio.Text = "Cashier";
            this.userRadio.UseVisualStyleBackColor = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 6;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Silver;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(311, -3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(36, 32);
            this.guna2Button2.TabIndex = 30;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(44)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(345, 400);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.userRadio);
            this.Controls.Add(this.adminRadio);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTXT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox codeTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton userRadio;
        private System.Windows.Forms.RadioButton adminRadio;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}