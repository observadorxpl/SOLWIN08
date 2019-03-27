using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace POO.Email
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> para = new List<string>();
            string[] words = txtDestinario.Text.Split(',');

            foreach (var word in words)
            {
                para.Add(word);
                Console.Write(word);
            }
            
            para.Add(txtDestinario.Text);

            List<string> adjunto= new List<string>();
            adjunto.Add(txtAdjuntar.Text);
            EnviarMensaje("1510188@utp.edu.pe", para, txtAsunto.Text, txtMensaje.Text,
                adjunto);
        }

        void EnviarMensaje(string de, List<String> para,
            string asunto, string Mensaje, List<string> adjunto)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("1510188@utp.edu.pe", "Jose Luis Cayo Acuña");
            foreach (string destinario in para)
            {
                mensaje.To.Add(destinario);
            }
            mensaje.Subject = asunto;
            mensaje.IsBodyHtml = false;
            mensaje.Body = Mensaje;
            foreach (String adj in adjunto)
            {
                if(System.IO.File.Exists(@adj))
                            mensaje.Attachments.Add(new Attachment(@adj));
            }
            
            SmtpClient servidor = new SmtpClient();
            servidor.Port = 587;
            servidor.Host = "smtp.live.com";
            NetworkCredential credenciales = new NetworkCredential();
            credenciales.UserName = "1510188@utp.edu.pe";
            credenciales.Password = "emoymelany";
            servidor.Credentials = credenciales;
            servidor.EnableSsl = true;

            servidor.Send(mensaje);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Elija el archivo a enviar";
            op.ShowDialog();
            if (op.FileName != "")
            {
                txtAdjuntar.Text = op.FileName;
            }

        }
    }
}
