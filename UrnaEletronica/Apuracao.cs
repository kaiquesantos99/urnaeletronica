using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEletronica.classes;

namespace UrnaEletronica
{
    public partial class Apuracao : Form
    {
        public Apuracao(List<Candidatos> c)
        {
            InitializeComponent();
            dgvApuracao.DataSource = c;
            dgvApuracao.Columns["Foto"].Visible = false;
        }

        private void Apuracao_Load(object sender, EventArgs e)
        {

        }
    }
}
