using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlPoolTable1_OnTableFinish(object sender, ctrlPoolTable.TableEventArgs e)
        {
            MessageBox.Show($"Time Has been Finished For Player : {e.PlayerName}\nOn Table Name: {e.TableTitle} \nTime : {e.TableTime}\nFees = {e.Fees}$");
        }
    }
}
