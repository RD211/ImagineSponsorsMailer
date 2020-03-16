using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagineSponsors
{
    public partial class LoginForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public LoginForm()
        {
            InitializeComponent();
        }
        void saveAndEnter(String email,String pass)
        {
            File.WriteAllText("cred.txt", email + "*" + pass);
            this.Hide();
            MainForm frm = new MainForm(email, pass);
            if(frm.ShowDialog()!=DialogResult.Retry)
            {
                this.Close();
            }
            this.Show();
            
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                String savedCreds = File.ReadAllText("cred.txt");

                var splitCreds = savedCreds.Split('*');
                if (splitCreds.Length >= 2)
                    saveAndEnter(splitCreds[0], splitCreds[1]);
            }
            catch { }
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e) => this.Close();

        private void Btn_minimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void BunifuFlatButton1_Click(object sender, EventArgs e) => saveAndEnter(txt_email.Text, txt_pass.Text);
    }
}
