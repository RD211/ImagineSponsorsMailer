using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ImagineSponsors
{
    public class SponsorEmail
    {
        public String subject, body;
        public List<String> attachments = new List<String>();
        public void moveFiles(List<String> attach)
        {
            attachments.Clear();
            attach.ForEach((s)=>{
                File.Copy(s,"mail\\"+ s.Split('\\').Last());
                attachments.Add("mail\\" + s.Split('\\').Last());
            });

        }
    }
}
