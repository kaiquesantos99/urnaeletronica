using System.Media;
using System.Runtime.Versioning;
using UrnaEletronica.classes;


namespace UrnaEletronica


{


    public partial class Form1 : Form
    {
        List<Candidatos> listaCandidatos = new List<Candidatos>();
        SoundPlayer somUrna = new SoundPlayer(@"sons/somUrna.wav");



        System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            Candidatos c1 = new Candidatos()
            {
                Numero = 13,
                Candidato = "Lula",
                Partido = "PT",
                Foto = Properties.Resources.lula
            };
            Candidatos c2 = new Candidatos()
            {
                Numero = 22,
                Candidato = "Bolsonaro",
                Partido = "PL",
                Foto = Properties.Resources.bolsonaro
            };
            Candidatos c3 = new Candidatos()
            {
                Numero = 28,
                Candidato = "Marçal",
                Partido = "PRTB",
                Foto = Properties.Resources.marcal
            };
            Candidatos c4 = new Candidatos()
            {
                Numero = 0000,
                Candidato = "BRANCO",
                Partido = "BRANCO",
                Foto = null
            };


            listaCandidatos.Add(c1);
            listaCandidatos.Add(c2);
            listaCandidatos.Add(c3);
            listaCandidatos.Add(c4);
        }









        private void button1_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "1";
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "1";

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "2"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "2"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "3"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "3"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "4"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "4"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "5"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "5"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "6"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "6"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "7"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "7"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "8"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "8"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "9"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "9"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 1)
            {
                lblNum.Text = "0"; // Altera aqui
            }
            else if (lblNum2.Text.Length < 1)
            {
                lblNum2.Text = "0"; // Altera aqui

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);


                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        lblNome.Text = candidato.Candidato;
                        lblPartido.Text = candidato.Partido;
                        pbCandidato.Image = candidato.Foto;
                    }
                }

            }
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            if (lblNum2.Text.Length > 0)
            {
                lblNum2.Text = "";
                lblNome.Text = "";
                lblPartido.Text = "";
                pbCandidato.Image = null;
            }
            else if (lblNum.Text.Length > 0)
            {
                lblNum.Text = "";
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (lblNome.Text.Length > 0)
            {
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 5000;
                timer.Tick += Timer_Tick;
                timer.Start();

                tlpVotar.Visible = false;
                tlpFim.Visible = true;
                tlpFim.Dock = DockStyle.Fill;

                int candidatoNumber = int.Parse(lblNum.Text + lblNum2.Text);

                // Soma o voto no candidato
                foreach (Candidatos candidato in listaCandidatos)
                {
                    if (candidato.Numero == candidatoNumber)
                    {
                        candidato.QtdVotos++;
                    }
                }
                try
                {
                    somUrna.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao reproduzir: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Candidato não encontrado!");
            }

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblNum.Text = "";
            lblNum2.Text = "";
            lblNome.Text = "";
            lblPartido.Text = "";
            pbCandidato.Image = null;
            tlpVotar.Visible = true;
            tlpFim.Visible = false;
            timer.Stop();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Apuracao(listaCandidatos).Show();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();

            tlpVotar.Visible = false;
            tlpFim.Visible = true;
            tlpFim.Dock = DockStyle.Fill;

            // Soma o voto no candidato
            listaCandidatos[3].QtdVotos++;
            try
            {
                somUrna.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao reproduzir: " + ex);
            }
        }
    }
}
