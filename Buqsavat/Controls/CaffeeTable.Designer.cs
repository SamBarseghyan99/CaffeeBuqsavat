namespace Buqsavat.Controls
{
    partial class CaffeeTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReserveTable = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 568);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 318);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // btnReserveTable
            // 
            this.btnReserveTable.Location = new System.Drawing.Point(439, 42);
            this.btnReserveTable.Name = "btnReserveTable";
            this.btnReserveTable.Size = new System.Drawing.Size(214, 58);
            this.btnReserveTable.TabIndex = 1;
            this.btnReserveTable.Text = "Reserve Table";
            this.btnReserveTable.UseVisualStyleBackColor = true;
            this.btnReserveTable.Click += new System.EventHandler(this.btnTableCommand_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(439, 132);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(214, 58);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnTableCommand_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewOrder.ForeColor = System.Drawing.Color.IndianRed;
            this.btnNewOrder.Location = new System.Drawing.Point(439, 223);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(214, 58);
            this.btnNewOrder.TabIndex = 1;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnTableCommand_Click);
            // 
            // CaffeeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnReserveTable);
            this.Controls.Add(this.panel1);
            this.Name = "CaffeeTable";
            this.Size = new System.Drawing.Size(678, 568);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReserveTable;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnNewOrder;
    }
}
