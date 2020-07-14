namespace MPromotion
{
    partial class Main
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
            this.flMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.btnApplyPromo = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblItemsInCart = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.flMainPanel.SuspendLayout();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // flMainPanel
            // 
            this.flMainPanel.AutoSize = true;
            this.flMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flMainPanel.Controls.Add(this.pnlItems);
            this.flMainPanel.Controls.Add(this.pnlCheckout);
            this.flMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flMainPanel.Location = new System.Drawing.Point(-1, 49);
            this.flMainPanel.Name = "flMainPanel";
            this.flMainPanel.Size = new System.Drawing.Size(805, 421);
            this.flMainPanel.TabIndex = 0;
            // 
            // pnlItems
            // 
            this.pnlItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlItems.Controls.Add(this.btnAdd);
            this.pnlItems.Controls.Add(this.dgvProduct);
            this.pnlItems.Controls.Add(this.lblHeading);
            this.pnlItems.Location = new System.Drawing.Point(3, 3);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(799, 221);
            this.pnlItems.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(474, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(15, 31);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(393, 178);
            this.dgvProduct.TabIndex = 2;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(11, 4);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(103, 24);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Store Items";
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCheckout.Controls.Add(this.btnApplyPromo);
            this.pnlCheckout.Controls.Add(this.dgvCart);
            this.pnlCheckout.Controls.Add(this.lblCheckout);
            this.pnlCheckout.Location = new System.Drawing.Point(3, 230);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(796, 188);
            this.pnlCheckout.TabIndex = 1;
            this.pnlCheckout.Visible = false;
            // 
            // btnApplyPromo
            // 
            this.btnApplyPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPromo.Location = new System.Drawing.Point(474, 32);
            this.btnApplyPromo.Name = "btnApplyPromo";
            this.btnApplyPromo.Size = new System.Drawing.Size(130, 48);
            this.btnApplyPromo.TabIndex = 2;
            this.btnApplyPromo.Text = "Apply Promo";
            this.btnApplyPromo.UseVisualStyleBackColor = true;
            this.btnApplyPromo.Click += new System.EventHandler(this.btnApplyPromo_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(15, 32);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.Size = new System.Drawing.Size(406, 150);
            this.dgvCart.TabIndex = 1;
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(11, 4);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(94, 24);
            this.lblCheckout.TabIndex = 0;
            this.lblCheckout.Text = "CheckOut";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(353, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "M Store ";
            // 
            // lblItemsInCart
            // 
            this.lblItemsInCart.AutoSize = true;
            this.lblItemsInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsInCart.Location = new System.Drawing.Point(696, 14);
            this.lblItemsInCart.Name = "lblItemsInCart";
            this.lblItemsInCart.Size = new System.Drawing.Size(18, 20);
            this.lblItemsInCart.TabIndex = 2;
            this.lblItemsInCart.Text = "0";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(720, 13);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblItemsInCart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flMainPanel);
            this.Name = "Main";
            this.Text = "M Store ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.flMainPanel.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flMainPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Label lblItemsInCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnApplyPromo;
        private System.Windows.Forms.DataGridView dgvCart;
    }
}

