using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class Form1 : Form
    {
        // Renomeando o botão para evitar ambiguidade
        private Button myButton;

        // Cria uma instância de PictureBox
        private PictureBox pictureBox;

        // Controle para o texto sobre a imagem
        private Label imageLabel;

        // Controle para o parágrafo abaixo da imagem
        private TextBox imageTextBox;

        public Form1()
        {
            InitializeComponent();
            InitializePictureBox(); // Inicializa o PictureBox
            InitializeControls();   // Inicializa os controles de texto
        }

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta o modo de exibição da imagem
            pictureBox.Width = 200; // Define a largura da imagem
            pictureBox.Height = 200; // Define a altura da imagem
            pictureBox.Location = new Point(50, 50); // Define a posição do PictureBox no formulário
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom; // Ancora o PictureBox em todos os lados
            this.Controls.Add(pictureBox); // Adiciona o PictureBox ao formulário
        }

        private void InitializeControls()
        {
            // Adiciona o controle de texto sobre a imagem
            imageLabel = new Label();
            imageLabel.Text = "A CACHORRA MAIS BONITA";
            imageLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            imageLabel.ForeColor = Color.White;
            imageLabel.BackColor = Color.FromArgb(192, 0, 0); // Cor de fundo RGB
            imageLabel.AutoSize = true;
            imageLabel.TextAlign = ContentAlignment.MiddleCenter;
            imageLabel.Visible = false; // Inicia invisível
            this.Controls.Add(imageLabel);

            // Adiciona o controle de texto abaixo da imagem
            imageTextBox = new TextBox();
            imageTextBox.Text = "Esta cachorra só dá trabalho";
            imageTextBox.Multiline = true;
            imageTextBox.ReadOnly = true;
            imageTextBox.ScrollBars = ScrollBars.Vertical;
            imageTextBox.BorderStyle = BorderStyle.None;
            imageTextBox.BackColor = Color.FromArgb(255, 255, 255); // Cor de fundo branca
            imageTextBox.Size = new Size(300, 100); // Tamanho do controle de texto
            imageTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom; // Ancora o controle de texto à esquerda, direita e inferior
            imageTextBox.Visible = false; // Inicia invisível
            this.Controls.Add(imageTextBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código a ser executado quando o formulário é carregado
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageUrl = "https://i.ibb.co/fGVDcN1/IMG-20220208-215455417.jpg";

            try
            {
                // Baixa a imagem da URL
                WebClient webClient = new WebClient();
                byte[] imageBytes = webClient.DownloadData(imageUrl);

                // Converte os bytes da imagem em um objeto Image
                Image image;
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    image = Image.FromStream(ms);
                }

                // Define a imagem no PictureBox
                pictureBox.Image = image;

                // Exibe os controles de texto sobre e abaixo da imagem
                imageLabel.Visible = true;
                imageTextBox.Visible = true;

                // Centraliza os controles de texto
                CenterControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }
        }

        // Método para centralizar os controles de texto
        private void CenterControls()
        {
            // Centraliza o controle de texto sobre a imagem
            imageLabel.Location = new Point((pictureBox.Width - imageLabel.Width) / 2 + pictureBox.Left,
                                             pictureBox.Top - 50);

            // Centraliza o controle de texto abaixo da imagem
            imageTextBox.Location = new Point((pictureBox.Width - imageTextBox.Width) / 2 + pictureBox.Left,
                                               pictureBox.Bottom + 20);
        }
    }
}
