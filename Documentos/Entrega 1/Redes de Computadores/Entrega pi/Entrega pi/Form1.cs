using System.Net;
using System.Net.Sockets;

namespace Entrega_pi
{
    public partial class Form1 : Form
    {
        int tentativa, invalido, valido;
        public Form1()
        {
            InitializeComponent();
            tentativa = 0;
            invalido = 0;  
            valido = 0;
            txtretorno.Text = "Número de tentativas: " + tentativa + ".\r\nNúmero de autorizados: " + valido + ".\r\nNúmero de Bloqueados: " + invalido + ".";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu ip é: " + ObterIpLocal());
        }
        private string ObterIpLocal()
        {
            string nomeMaquina = Dns.GetHostName();
            IPHostEntry host = Dns.GetHostEntry(nomeMaquina);

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "IP não encontrado";

        }
        private void label1_Click_1(object sender, EventArgs e) 
        { 
        
        }
        private void btnverificar_click(object sender, EventArgs e) 
        {
            String ipdig = textBox1.Text;
            String ipmaq = ObterIpLocal();

            if (ipdig.CompareTo(ipmaq) == 0) 
            {
                tentativa  = tentativa + 1;
                valido = valido + 1;
                MessageBox.Show("Autorizado.");
                txtretorno.Text = "Número de tentativas: " + tentativa + ".\r\nNúmero de autorizados: " + valido + ".\r\nNúmero de Bloqueados: " + invalido + ".";

            }
            else 
            {
                tentativa = tentativa + 1;
                invalido = invalido + 1;
                MessageBox.Show("Bloqueado.");
                txtretorno.Text = "Número de tentativas: " + tentativa + ".\r\nNúmero de autorizados: " + valido + ".\r\nNúmero de Bloqueados: " + invalido + ".";
            }

        }
    }
}
    