using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteRegeditLimpaPasta
{
    public partial class Form1 : Form
    {
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LimpaPasta");

        public Form1()
        {        
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            

            lblcaminho.Text = key.GetValue("Caminho").ToString();
            int execO = Convert.ToInt32(key.GetValue("ExecOpen"));
            int execC = Convert.ToInt32(key.GetValue("ExecClose"));

            if (execO == 1)
            {
                lblExecOpen.Text = "Sim";
            }
            else {
                lblExecOpen.Text = "Não";
            }

            if (execC == 1)
            {
                lblExecClose.Text = "Sim";
            }
            else
            {
                lblExecClose.Text = "Não";
            }
        }

        private void btnDelReg_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LimpaPasta", true); //<--ganha privilegios
           reg.DeleteValue("ExecOpen");
           reg.DeleteValue("ExecClose");
        }
    }
}
