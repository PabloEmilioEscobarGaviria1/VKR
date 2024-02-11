using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKR;
using VKR.VKR;

namespace VKR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();

            if (!AuthClass.IsAuthenticated)
            {
                Application.Exit();
            }

            toolStripLabel1.Text = $"Добро пожаловать {AuthClass.auth_fio}! Ваш код {AuthClass.auth_id.ToString()}";

            switch (AuthClass.auth_role)
            {
                case 3:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    break;
                case 2:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    break;
                case 1:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Ваша роль в системе не определена. Приложение будет закрыто!");
                    Application.Exit();
                    break;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
