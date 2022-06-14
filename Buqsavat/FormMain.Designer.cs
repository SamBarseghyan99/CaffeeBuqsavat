namespace Buqsavat
{
    partial class FormMain
    {
        private Controls.CaffeeTable caffeeTable1;
        private Controls.CaffeeTable caffeeTable2;
        private Controls.CaffeeTable caffeeTable3;
        private Controls.CaffeeTable caffeeTable4;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.caffeeTable1 = new Buqsavat.Controls.CaffeeTable();
            this.caffeeTable2 = new Buqsavat.Controls.CaffeeTable();
            this.caffeeTable3 = new Buqsavat.Controls.CaffeeTable();
            this.caffeeTable4 = new Buqsavat.Controls.CaffeeTable();
            this.SuspendLayout();
            // 
            // caffeeTable1
            // 
            this.caffeeTable1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caffeeTable1.Location = new System.Drawing.Point(19, 27);
            this.caffeeTable1.Margin = new System.Windows.Forms.Padding(0);
            this.caffeeTable1.Name = "caffeeTable1";
            this.caffeeTable1.Size = new System.Drawing.Size(330, 286);
            this.caffeeTable1.TabIndex = 0;
            this.caffeeTable1.TableNumber = 1;
            this.caffeeTable1.Load += new System.EventHandler(this.caffeeTable1_Load);
            // 
            // caffeeTable2
            // 
            this.caffeeTable2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caffeeTable2.Location = new System.Drawing.Point(376, 27);
            this.caffeeTable2.Margin = new System.Windows.Forms.Padding(0);
            this.caffeeTable2.Name = "caffeeTable2";
            this.caffeeTable2.Size = new System.Drawing.Size(330, 286);
            this.caffeeTable2.TabIndex = 0;
            this.caffeeTable2.TableNumber = 2;
            // 
            // caffeeTable3
            // 
            this.caffeeTable3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caffeeTable3.Location = new System.Drawing.Point(19, 338);
            this.caffeeTable3.Margin = new System.Windows.Forms.Padding(0);
            this.caffeeTable3.Name = "caffeeTable3";
            this.caffeeTable3.Size = new System.Drawing.Size(330, 286);
            this.caffeeTable3.TabIndex = 0;
            this.caffeeTable3.TableNumber = 3;
            // 
            // caffeeTable4
            // 
            this.caffeeTable4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caffeeTable4.Location = new System.Drawing.Point(376, 338);
            this.caffeeTable4.Margin = new System.Windows.Forms.Padding(0);
            this.caffeeTable4.Name = "caffeeTable4";
            this.caffeeTable4.Size = new System.Drawing.Size(330, 286);
            this.caffeeTable4.TabIndex = 0;
            this.caffeeTable4.TableNumber = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 647);
            this.Controls.Add(this.caffeeTable4);
            this.Controls.Add(this.caffeeTable3);
            this.Controls.Add(this.caffeeTable2);
            this.Controls.Add(this.caffeeTable1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormMain";
            this.Text = "Form Buqsavat";
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}
