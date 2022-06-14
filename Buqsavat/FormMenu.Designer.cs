namespace Buqsavat
{
    partial class FormMenu
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
            this.flpMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flpMenuItems
            // 
            this.flpMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenuItems.Location = new System.Drawing.Point(0, 0);
            this.flpMenuItems.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.flpMenuItems.Name = "flpMenuItems";
            this.flpMenuItems.Size = new System.Drawing.Size(870, 590);
            this.flpMenuItems.TabIndex = 0;
            this.flpMenuItems.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMenuItems_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 122);
            this.panel1.TabIndex = 1;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpMenuItems);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMenuItems;
        private System.Windows.Forms.Panel panel1;
    }
}