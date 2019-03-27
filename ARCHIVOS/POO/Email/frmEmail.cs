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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            //Cargar Destinarios
            List<string> destinatarios = new List<string>();
            destinatarios.Add(txtPara.Text);
            //Cargar adjuntos
            List<string> adjuntos = new List<string>();
            if (txtAdjuntar.Text != "")
            {
                adjuntos.Add(txtAdjuntar.Text);
            }
            //Enviar correo
            try
            {
                EnviarMensaje(destinatarios, txtAsunto.Text, txtMensaje.Text,
                                         adjuntos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
            }
        }
        void EnviarMensaje(List<string> para, string asunto,
                                         string Mensaje, List<string> adjunto)
        {
            //Crear un mensaje 
            MailMessage mensaje = new MailMessage();
            //Definir el remitente
            mensaje.From = new MailAddress("tucorreoaoutlook", "TuNombre");
            //Definir los destinatarios
            foreach (string destinario in para)
            {
                mensaje.To.Add(destinario);
            }
            if (adjunto.Count > 0)
            {
                mensaje.Attachments.Add(new Attachment(adjunto[0]));
            }

            //Especificar el asunto
            mensaje.Subject = asunto;
            //Especificar el tipo de mensaje, "false" si es solo texto
            mensaje.IsBodyHtml = true;
            //Especificar el mensaje
            mensaje.Body = LeerHtml() ;
            //definir las propiedades del servidor de correos salientes
            SmtpClient servidor = new SmtpClient();
            servidor.Port = 587;
            servidor.Host = "smtp.live.com";
            //definir las credenciales para enviar el correo
            NetworkCredential credenciales = new NetworkCredential();
            credenciales.UserName = "tucorreooutlook";
            credenciales.Password = "tuclave";
            //pasar las credenciales
            servidor.Credentials = credenciales;
            servidor.EnableSsl = true; //esto es obligatorio para outlook
            //Enviar el correo
            servidor.Send(mensaje);
        }

        private void btnFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog cd = new OpenFileDialog();
            cd.ShowDialog();
            if (cd.FileName != "")
            {
                txtAdjuntar.Text = cd.FileName;
            }
        }
    
        string LeerHtml()
        {
            System.IO.StreamReader sr =
                          new System.IO.StreamReader("tabla.txt");
            return sr.ReadToEnd();
        }

    }
}




