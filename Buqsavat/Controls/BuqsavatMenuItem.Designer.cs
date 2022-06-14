namespace Buqsavat.Controls
{
    partial class BuqsavatMenuItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuqsavatMenuItem));
            this.menuItemImage = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSelectMenuItem = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemImage
            // 
            this.menuItemImage.Image = ((System.Drawing.Image)(resources.GetObject("menuItemImage.Image")));
            this.menuItemImage.Location = new System.Drawing.Point(-5, 113);
            this.menuItemImage.Name = "menuItemImage";
            this.menuItemImage.Size = new System.Drawing.Size(375, 261);
            this.menuItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuItemImage.TabIndex = 0;
            this.menuItemImage.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(0, 408);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(173, 89);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "0.00";
            // 
            // btnSelectMenuItem
            // 
            this.btnSelectMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelectMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelectMenuItem.Location = new System.Drawing.Point(0, 505);
            this.btnSelectMenuItem.Name = "btnSelectMenuItem";
            this.btnSelectMenuItem.Size = new System.Drawing.Size(375, 85);
            this.btnSelectMenuItem.TabIndex = 2;
            this.btnSelectMenuItem.Text = "Select";
            this.btnSelectMenuItem.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(1, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 62);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // BuqsavatMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSelectMenuItem);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.menuItemImage);
            this.Name = "BuqsavatMenuItem";
            this.Size = new System.Drawing.Size(373, 629);
            ((System.ComponentModel.ISupportInitialize)(this.menuItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox menuItemImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSelectMenuItem;
        private System.Windows.Forms.Label lblName;
    }
}
