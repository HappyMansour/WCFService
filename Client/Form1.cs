﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Client
{
    public partial class Form1 : Form
    {
        Client_Emp_Service.ServiceClient c = new Client_Emp_Service.ServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void View_Click(object sender, EventArgs e)
        {

        }
    }
}
