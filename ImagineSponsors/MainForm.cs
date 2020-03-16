using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagineSponsors
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        String email, password;
        SponsorEmail emailToSend = new SponsorEmail();
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(String email,String password)
        {
            this.email = email;
            this.password = password;
            InitializeComponent();

        }

        private void Btn_exit_Click(object sender, EventArgs e)=> this.Close();

        private void Btn_minimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void Label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            loadMailOut();
            var jsonString = JsonConvert.SerializeObject(emailToSend);
            File.WriteAllText("mail\\"+ emailToSend.subject + DateTime.Now.ToLongTimeString().Replace(':', ' ') + ".mail", jsonString);
            MessageBox.Show("Mail saved!");
            getMailsLists();

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                foreach(var v in dialog.FileNames)
                {
                    list_attachements.Items.Add(v.Split('\\').Last());
                    emailToSend.attachments.Add(v);
                }
            }
        }
        private void clearEmails() => list_emails.Clear();
        private void concatenateEmails()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                concatenateEmails(dialog.FileName);
            }
        }
        private void concatenateEmails(String file) => File.ReadAllLines(file).ToList().ForEach((s) => list_emails.Items.Add(s));

        private void Btn_clear_Click(object sender, EventArgs e) => clearEmails();

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e) => concatenateEmails();

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            clearEmails();
            concatenateEmails();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            List<String> stringsMail = new List<string>();
            for(int i = 0;i<list_emails.Items.Count;i++)
            {
                stringsMail.Add(list_emails.Items[i].Text);
            }
            File.WriteAllLines("mail lists\\" + DateTime.Now.ToLongTimeString().Replace(':',' ')+".list",stringsMail);
            MessageBox.Show("Saved list!");
            getMailsLists();

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            File.Delete("cred.txt");
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void Cbox_emailList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearEmails();
            concatenateEmails(cbox_emailList.Items[cbox_emailList.SelectedIndex].ToString());
        }
        void getMailsLists()
        {
            Directory.GetFiles("mail\\").ToList().ForEach((s) => {
                if (s.EndsWith(".mail"))
                {
                    cbox_mail.Items.Add(s);
                }
            });
            Directory.GetFiles("mail lists\\").ToList().ForEach((s) => {
                if (s.EndsWith(".list"))
                {
                    cbox_emailList.Items.Add(s);
                }
            });
        }
        void loadMailIn()
        {
            list_attachements.Items.Clear();
            txt_body.Text = emailToSend.body;
            txt_title.Text = emailToSend.subject;
            emailToSend.attachments.ForEach((s) =>list_attachements.Items.Add(s));
        }
        void loadMailOut()
        {
            emailToSend.subject = txt_title.Text;
            emailToSend.body = txt_body.Text;
            var copier = emailToSend.attachments.ToArray();
            emailToSend.moveFiles(copier.ToList());
        }
        private void Cbox_mail_SelectedIndexChanged(object sender, EventArgs e)
        {
            emailToSend = JsonConvert.DeserializeObject<SponsorEmail>(File.ReadAllText(cbox_mail.Items[cbox_mail.SelectedIndex].ToString()));
            loadMailIn();
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            msg.Subject = emailToSend.subject;
            msg.Body = emailToSend.body;
            emailToSend.attachments.ForEach((s) => msg.Attachments.Add(new Attachment(s)));
            MailAddress adr = new MailAddress(email);
            msg.From = adr;
            List<String> emailsOfSpons = new List<string>();
            for(int i = 0;i<list_emails.Items.Count;i++)
            {
                msg.Bcc.Add(list_emails.Items[i].Text);
            }
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Timeout = 2313123;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(email, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.Send(msg);
            MessageBox.Show("Mail Sent!");
            emailToSend.attachments.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            emailToSend = new SponsorEmail();
            lbl_emailLogged.Text = "Logged in as : " + email;
            getMailsLists();
        }
    }
}
