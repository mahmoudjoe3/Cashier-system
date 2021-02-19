
namespace cacharSystem
{
    partial class cartItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cartItem));
            this.cartItemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.order_delete = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cartItemName
            // 
            this.cartItemName.AutoSize = true;
            this.cartItemName.Dock = System.Windows.Forms.DockStyle.Left;
            this.cartItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartItemName.Location = new System.Drawing.Point(0, 0);
            this.cartItemName.Name = "cartItemName";
            this.cartItemName.Size = new System.Drawing.Size(100, 25);
            this.cartItemName.TabIndex = 0;
            this.cartItemName.Text = "CocaCola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(147, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "5 EGP";
            // 
            // order_delete
            // 
            this.order_delete.BackColor = System.Drawing.Color.Red;
            this.order_delete.BorderColor = System.Drawing.Color.Empty;
            this.order_delete.CheckedState.Parent = this.order_delete;
            this.order_delete.CustomImages.Parent = this.order_delete;
            this.order_delete.FillColor = System.Drawing.Color.Empty;
            this.order_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.order_delete.ForeColor = System.Drawing.Color.White;
            this.order_delete.HoverState.Parent = this.order_delete;
            this.order_delete.Image = ((System.Drawing.Image)(resources.GetObject("order_delete.Image")));
            this.order_delete.Location = new System.Drawing.Point(222, -10);
            this.order_delete.Name = "order_delete";
            this.order_delete.ShadowDecoration.Parent = this.order_delete;
            this.order_delete.Size = new System.Drawing.Size(40, 49);
            this.order_delete.TabIndex = 15;
            this.order_delete.Click += new System.EventHandler(this.order_delete_Click);
            // 
            // cartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.order_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartItemName);
            this.Name = "cartItem";
            this.Size = new System.Drawing.Size(262, 28);
            this.Load += new System.EventHandler(this.cartItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cartItemName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button order_delete;
    }
}
