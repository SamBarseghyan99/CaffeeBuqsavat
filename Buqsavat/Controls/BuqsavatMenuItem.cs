using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buqsavat.Controls
{
    public partial class BuqsavatMenuItem : UserControl
    {
        #region Properties
        private decimal price;
        private string name;
        private Image image;

        public Image Image
        {
            get { return image; }
            set
            {
                image = value;
                this.menuItemImage.Image = image;
            }
        }

        public new string Name
        {
            get { return name; }
            set
            {
                name = value;
                this.lblName.Text = name;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                this.lblPrice.Text = price.ToString("$0.00");
            }
        }
        #endregion

        public BuqsavatMenuItem()
        {
            InitializeComponent();
        }


    }
}