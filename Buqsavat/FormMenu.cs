using Buqsavat.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buqsavat
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            this.Load += FormMenu_Load;
        }

        private void FormMenu_Load(object? sender, EventArgs e)
        {
            List<BuqsavatMenuItem> menuItems = new List<BuqsavatMenuItem>();

            menuItems.Add(new BuqsavatMenuItem() { Name = "Coffee", Price = 10 });
            menuItems.Add(new BuqsavatMenuItem() { Name = "Tea", Price = 5 });
            menuItems.Add(new BuqsavatMenuItem() { Name = "Coffee with milk", Price = 8 });
            menuItems.Add(new BuqsavatMenuItem() { Name = "Tea with milk", Price = 100 });
            menuItems.Add(new BuqsavatMenuItem() { Name = "Coffee with sugar", Price = 5 });
            menuItems.Add(new BuqsavatMenuItem()
            {
                Name = "Tea with sugar",
                Price = 9,
                Image = Image.FromFile(@"C:\Users\DELL\source\repos\Buqsavat\Buqsavat\Images\Toast.jpg")
            });

            this.flpMenuItems.Controls.AddRange(menuItems.ToArray());
        }

        private void flpMenuItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}