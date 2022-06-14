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
    public partial class CaffeeTable : UserControl
    {
        public event TableCommandEventHandler TableCommandExecuted;

        private int tableNumber;
        public int TableNumber
        {
            get { return tableNumber; }
            set
            {
                tableNumber = value;
                this.label1.Text = tableNumber.ToString();
            }
        }

        public CaffeeTable()
        {
            InitializeComponent();
        }

        private void btnTableCommand_Click(object sender, EventArgs e)
        {
            TableCommand command = TableCommand.Reserve;

            Button button = sender as Button;

            if (button == btnNewOrder)
            {
                command = TableCommand.Order;
                var formMenu = new  FormMenu();
                formMenu.ShowDialog();
            }
            if (button == btnReserveTable)
                command = TableCommand.Reserve;
            if (button == btnBill)
                command = TableCommand.Bill;

            if (TableCommandExecuted != null)
                TableCommandExecuted(tableNumber, command);
        }
    }
}
