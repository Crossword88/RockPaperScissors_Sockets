using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketsExam
{
    public partial class ServerForm : Form
    {
        TcpListener server = null;
        TcpClient client = null;
        NetworkStream stream = null;
        int port = 13000;
        IPAddress localAddr;
        int data;
        int loses = 0;
        int wins = 0;

        public ServerForm()
        {
            InitializeComponent();

            localAddr = IPAddress.Parse("127.0.0.1");
            server = new TcpListener(localAddr, port);
            server.Start();
            AcceptClient();
        }

        private async void AcceptClient()
        {
            client = await server.AcceptTcpClientAsync();
            MessageBox.Show("Connected!");
            stream = client.GetStream();
        }

        private void GetMove(int move)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, buffer.Length);
            data = BitConverter.ToInt32(buffer, 0);

            if (data == 1 && move == 1 || data == 2 && move == 2 || data == 3 && move == 3)
            {
                vs.Text = "==";
            }

            if (data == 1 && move == 3 || data == 3 && move == 2 || data == 2 && move == 1)
            {
                vs.Text = "<<<";
                loses++;
                Loses.Text = loses.ToString();

                if (loses == 5)
                {
                    MessageBox.Show("You lose(");
                    wins = 0;
                    loses = 0;
                    Wins.Text = "0";
                    Loses.Text = "0";
                }
            }

            if (data == 1 && move == 2 || data == 3 && move == 1 || data == 2 && move == 3)
            {
                vs.Text = ">>>";
                wins++;
                Wins.Text = wins.ToString();

                if (wins == 5)
                {
                    MessageBox.Show("YOU WON! Congrats!");
                    wins = 0;
                    loses = 0;
                    Wins.Text = "0";
                    Loses.Text = "0";
                }
            }

            switch (data)
            {
                case 1:
                    Enemy.BackgroundImage = RockBTN.BackgroundImage;
                    break;
                case 2:
                    Enemy.BackgroundImage = PaperBTN.BackgroundImage;
                    break;
                case 3:
                    Enemy.BackgroundImage = ScissorsBTN.BackgroundImage;
                    break;
                default:
                    break;
            }

            // Разблокировка кнопок для следующего раунда
            RockBTN.Enabled = true;
            PaperBTN.Enabled = true;
            ScissorsBTN.Enabled = true;
        }

        private void SendMove(int move)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    vs.Text = "Not connected to the client.";
                    return;
                }

                byte[] responseBytes = BitConverter.GetBytes(move);
                stream.Write(responseBytes, 0, 4);
                GetMove(move);
            }
            catch (Exception ex)
            {
                vs.Text = $"Exception: {ex.Message}";
            }
        }

        private void RockBTN_Click(object sender, EventArgs e)
        {
            Your.BackgroundImage = RockBTN.BackgroundImage;
            RockBTN.Enabled = false;
            PaperBTN.Enabled = false;
            ScissorsBTN.Enabled = false;
            SendMove(1);
        }

        private void PaperBTN_Click(object sender, EventArgs e)
        {
            Your.BackgroundImage = PaperBTN.BackgroundImage;
            RockBTN.Enabled = false;
            PaperBTN.Enabled = false;
            ScissorsBTN.Enabled = false;
            SendMove(2);
        }

        private void ScissorsBTN_Click(object sender, EventArgs e)
        {
            Your.BackgroundImage = ScissorsBTN.BackgroundImage;
            RockBTN.Enabled = false;
            PaperBTN.Enabled = false;
            ScissorsBTN.Enabled = false;
            SendMove(3);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Close();
            client?.Close();
            server?.Stop();
        }
    }
}