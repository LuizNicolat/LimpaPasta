using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace LimpaPasta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bool verifica = existechave();

            if (!Directory.Exists(@"C:\DeleteDefault"))
               {
                Directory.CreateDirectory(@"C:\DeleteDefault");
            }            

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LimpaPasta");

            if (key.GetValue("Caminho") != null && key.GetValue("Caminho") != " ")
            {
                lblSalvo.Text = key.GetValue("Caminho").ToString();
                txtCaminho.Text = key.GetValue("Caminho").ToString();
            }

            

            if (key.GetValue("Caminho") != null || key.GetValue("Caminho") != " ")
            {
                if (Convert.ToUInt32(key.GetValue("ExecOpen")) == 1)
                {
                    LimparPastaSelecionada();
                    if (Convert.ToUInt32(key.GetValue("ExecClose")) == 1)
                    {
                        lblSalvo.Text = key.GetValue("ExecClose").ToString();
                        Application.Exit();
                    }
                }
                else if (key.GetValue("Caminho") == null || key.GetValue("Caminho") == " ")
                {                    
                    lblSalvo.Text = "Caminho vazio";
                }
                
                chkExecOpen.Checked = true;
            }

            //if (verifica == true)
           // {
           //     lblSalvo.Text = "Existe";
            //}
           // else { lblSalvo.Text = "Não existe"; }
        }

        public bool criarchave(string caminho, int execOpen, int FechaExec) {

            RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\LimpaPasta");

            rk.SetValue("Caminho", caminho);
            rk.SetValue("ExecOpen", execOpen);
            rk.SetValue("ExecClose", FechaExec);

            //Registry.CurrentUser.SetValue(@"SOFTWARE\LimpaPasta\PegaAqui", caminho);

            return true;
        }

        public bool existechave() {
            RegistryKey rkSubKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LimpaPasta", false);
            if (rkSubKey == null)
            {
                return false;
            }
            else
            {
                return true;                
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdl = new FolderBrowserDialog();

            if (fdl.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = fdl.SelectedPath;
            }

            //string path = txtCaminho.Text;

            //criarchave(path);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string path = txtCaminho.Text;
            int execOpen = 0;
            int execClose = 0;

            if (chkExecOpen.Checked) { execOpen = 1; } else { execOpen = 0; };
            if (chkFecharLimpa.Checked) { execClose = 1; } else { execClose = 0; };

            criarchave(path, execOpen, execClose);

            //if (chkExecOpen.Checked) { lblSalvo.Text = "Marcado"; } else { lblSalvo.Text = "Desmarcado"; }
        }

        private void btnLIMPAR_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            LimparPastaSelecionada();
        }

        public void LimparPastaSelecionada() {

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LimpaPasta");

            string caminho = key.GetValue("Caminho").ToString();

            if (caminho == null || caminho == "")
            {
                caminho = @"C:\DeleteDefault";
            }

            DirectoryInfo di = new DirectoryInfo(caminho);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LimpaPasta");

            if (Convert.ToUInt32(key.GetValue("ExecClose")) == 1)
            {
                lblSalvo.Text = key.GetValue("ExecClose").ToString();
                Application.Exit();
            }
        }
    }
}
