
namespace cacharSystem
{
    partial class UC_productItemList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_productItemList));
            this.item_image = new System.Windows.Forms.PictureBox();
            this.item_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.item_sellPrice = new System.Windows.Forms.Label();
            this.item_factoryPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.item_increase = new Guna.UI2.WinForms.Guna2Button();
            this.item_decrease = new Guna.UI2.WinForms.Guna2Button();
            this.item_quantity = new System.Windows.Forms.Label();
            this.item_delete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.item_image)).BeginInit();
            this.SuspendLayout();
            // 
            // item_image
            // 
            this.item_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.item_image.Image = ((System.Drawing.Image)(resources.GetObject("item_image.Image")));
            this.item_image.Location = new System.Drawing.Point(0, 0);
            this.item_image.Name = "item_image";
            this.item_image.Size = new System.Drawing.Size(123, 89);
            this.item_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.item_image.TabIndex = 0;
            this.item_image.TabStop = false;
            // 
            // item_title
            // 
            this.item_title.AutoSize = true;
            this.item_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_title.ForeColor = System.Drawing.Color.White;
            this.item_title.Location = new System.Drawing.Point(134, 13);
            this.item_title.Name = "item_title";
            this.item_title.Size = new System.Drawing.Size(127, 23);
            this.item_title.TabIndex = 1;
            this.item_title.Text = "product title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sell price";
            // 
            // item_sellPrice
            // 
            this.item_sellPrice.AutoSize = true;
            this.item_sellPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_sellPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.item_sellPrice.Location = new System.Drawing.Point(246, 44);
            this.item_sellPrice.Name = "item_sellPrice";
            this.item_sellPrice.Size = new System.Drawing.Size(57, 18);
            this.item_sellPrice.TabIndex = 3;
            this.item_sellPrice.Text = "50 EGP";
            // 
            // item_factoryPrice
            // 
            this.item_factoryPrice.AutoSize = true;
            this.item_factoryPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_factoryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.item_factoryPrice.Location = new System.Drawing.Point(246, 64);
            this.item_factoryPrice.Name = "item_factoryPrice";
            this.item_factoryPrice.Size = new System.Drawing.Size(57, 18);
            this.item_factoryPrice.TabIndex = 5;
            this.item_factoryPrice.Text = "45 EGP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(134, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Factory price";
            // 
            // item_increase
            // 
            this.item_increase.BackColor = System.Drawing.Color.Transparent;
            this.item_increase.BorderRadius = 9;
            this.item_increase.CheckedState.Parent = this.item_increase;
            this.item_increase.CustomImages.Parent = this.item_increase;
            this.item_increase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_increase.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.item_increase.ForeColor = System.Drawing.Color.Black;
            this.item_increase.HoverState.Parent = this.item_increase;
            this.item_increase.Image = ((System.Drawing.Image)(resources.GetObject("item_increase.Image")));
            this.item_increase.Location = new System.Drawing.Point(319, 31);
            this.item_increase.Name = "item_increase";
            this.item_increase.ShadowDecoration.Parent = this.item_increase;
            this.item_increase.Size = new System.Drawing.Size(27, 27);
            this.item_increase.TabIndex = 6;
            this.item_increase.Click += new System.EventHandler(this.item_increase_Click);
            // 
            // item_decrease
            // 
            this.item_decrease.BackColor = System.Drawing.Color.Transparent;
            this.item_decrease.BorderRadius = 9;
            this.item_decrease.CheckedState.Parent = this.item_decrease;
            this.item_decrease.CustomImages.Parent = this.item_decrease;
            this.item_decrease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_decrease.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.item_decrease.ForeColor = System.Drawing.Color.Black;
            this.item_decrease.HoverState.Parent = this.item_decrease;
            this.item_decrease.Image = ((System.Drawing.Image)(resources.GetObject("item_decrease.Image")));
            this.item_decrease.Location = new System.Drawing.Point(376, 31);
            this.item_decrease.Name = "item_decrease";
            this.item_decrease.ShadowDecoration.Parent = this.item_decrease;
            this.item_decrease.Size = new System.Drawing.Size(27, 27);
            this.item_decrease.TabIndex = 7;
            this.item_decrease.Click += new System.EventHandler(this.item_decrease_Click);
            // 
            // item_quantity
            // 
            this.item_quantity.AutoSize = true;
            this.item_quantity.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.item_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.item_quantity.Location = new System.Drawing.Point(349, 31);
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(24, 26);
            this.item_quantity.TabIndex = 8;
            this.item_quantity.Text = "4";
            // 
            // item_delete
            // 
            this.item_delete.BackColor = System.Drawing.Color.Transparent;
            this.item_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_delete.BorderRadius = 8;
            this.item_delete.CheckedState.Parent = this.item_delete;
            this.item_delete.CustomImages.Parent = this.item_delete;
            this.item_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.item_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.item_delete.HoverState.Parent = this.item_delete;
            this.item_delete.Location = new System.Drawing.Point(417, 29);
            this.item_delete.Name = "item_delete";
            this.item_delete.ShadowDecoration.Parent = this.item_delete;
            this.item_delete.Size = new System.Drawing.Size(131, 33);
            this.item_delete.TabIndex = 9;
            this.item_delete.Text = "Delete";
            this.item_delete.Click += new System.EventHandler(this.item_delete_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_productItemList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.item_delete);
            this.Controls.Add(this.item_quantity);
            this.Controls.Add(this.item_decrease);
            this.Controls.Add(this.item_increase);
            this.Controls.Add(this.item_factoryPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.item_sellPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_title);
            this.Controls.Add(this.item_image);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_productItemList";
            this.Size = new System.Drawing.Size(566, 89);
            this.Load += new System.EventHandler(this.UC_productItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox item_image;
        private System.Windows.Forms.Label item_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label item_sellPrice;
        private System.Windows.Forms.Label item_factoryPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button item_increase;
        private Guna.UI2.WinForms.Guna2Button item_decrease;
        private System.Windows.Forms.Label item_quantity;
        private Guna.UI2.WinForms.Guna2Button item_delete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
