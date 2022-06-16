using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buqsavat
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            this.caffeeTable1.TableCommandExecuted += CaffeeTable_TableCommandExecuted;
            this.caffeeTable2.TableCommandExecuted += CaffeeTable_TableCommandExecuted;
            this.caffeeTable3.TableCommandExecuted += CaffeeTable_TableCommandExecuted;
            this.caffeeTable4.TableCommandExecuted += CaffeeTable_TableCommandExecuted;

        }
        private void CaffeeTable_TableCommandExecuted(int tableNumber, TableCommand command)
        {
            MessageBox.Show($"Table {tableNumber} has executed command {command}");
        }

        private void caffeeTable1_Load(object sender, EventArgs e)
        {

        }
    }
}
