using MyNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var client = new Client(httpClient);
            var utenti = client.UtentiAllAsync().Result;
            label1.Text = utenti.FirstOrDefault().CognomeNome;
        }
    }
}
