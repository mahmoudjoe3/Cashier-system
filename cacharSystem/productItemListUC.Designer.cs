
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.order_edit = new Guna.UI2.WinForms.Guna2Button();
            this.order_delete = new Guna.UI2.WinForms.Guna2Button();
            this.item_Quantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.item_sellPrice.Location = new System.Drawing.Point(139, 64);
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
            this.item_factoryPrice.Location = new System.Drawing.Point(241, 64);
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
            this.label4.Location = new System.Drawing.Point(233, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Factory price";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // order_edit
            // 
            this.order_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.order_edit.BorderColor = System.Drawing.Color.Empty;
            this.order_edit.CheckedState.Parent = this.order_edit;
            this.order_edit.CustomImages.Parent = this.order_edit;
            this.order_edit.FillColor = System.Drawing.Color.Empty;
            this.order_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.order_edit.ForeColor = System.Drawing.Color.White;
            this.order_edit.HoverState.Parent = this.order_edit;
            this.order_edit.Image = ((System.Drawing.Image)(resources.GetObject("order_edit.Image")));
            this.order_edit.Location = new System.Drawing.Point(530, 44);
            this.order_edit.Name = "order_edit";
            this.order_edit.ShadowDecoration.Parent = this.order_edit;
            this.order_edit.Size = new System.Drawing.Size(39, 45);
            this.order_edit.TabIndex = 15;
            this.order_edit.Click += new System.EventHandler(this.order_edit_Click);
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
            this.order_delete.Location = new System.Drawing.Point(530, 0);
            this.order_delete.Name = "order_delete";
            this.order_delete.ShadowDecoration.Parent = this.order_delete;
            this.order_delete.Size = new System.Drawing.Size(40, 49);
            this.order_delete.TabIndex = 14;
            this.order_delete.Click += new System.EventHandler(this.order_delete_Click);
            // 
            // item_Quantity
            // 
            this.item_Quantity.AutoSize = true;
            this.item_Quantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.item_Quantity.Location = new System.Drawing.Point(371, 64);
            this.item_Quantity.Name = "item_Quantity";
            this.item_Quantity.Size = new System.Drawing.Size(16, 18);
            this.item_Quantity.TabIndex = 16;
            this.item_Quantity.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(356, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity";
            // 
            // UC_productItemList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.item_Quantity);
            this.Controls.Add(this.order_edit);
            this.Controls.Add(this.order_delete);
            this.Controls.Add(this.item_factoryPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.item_sellPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_title);
            this.Controls.Add(this.item_image);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_productItemList";
            this.Size = new System.Drawing.Size(569, 89);
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
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button order_edit;
        private Guna.UI2.WinForms.Guna2Button order_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label item_Quantity;
    }
}
