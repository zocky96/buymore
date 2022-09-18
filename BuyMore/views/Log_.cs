using BuyMore.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyMore
{
    public partial class Log_ : Form
    {
        public Log_()
        {
            InitializeComponent();
            LogC.showLog(logTable);
        }

        private void Log__Load(object sender, EventArgs e)
        {

        }
    }
}
