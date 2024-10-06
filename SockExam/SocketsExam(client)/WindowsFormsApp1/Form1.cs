using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int port = 13000;
        int loses = 0;
        int wins = 0;
        TcpClient client;
        NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", port);
                stream = client.GetStream();
                MessageBox.Show("Connected to server!");
            }
            catch (Exception ex)
            {
                vs.Text = $"Exception: {ex.Message}";
            }
        }

        private void RockBTN_Click(object sender, EventArgs e)
        {
            Your.BackgroundImage = RockBTN.BackgroundImage;
            SendMove(1);
        }

        private void PaperBTN_Click(object sender, EventArgs e)
        {
            Your.BackgroundImage = PaperBTN.BackgroundImage;
            SendMove(2);
        }

        private void ScissorsBTN_Click(object sender, EventArgs e)
        {
            Your.BackgroundImage = ScissorsBTN.BackgroundImage;
            SendMove(3);
        }

        private void SendMove(int move)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    vs.Text = "Not connected to the server.";
                    return;
                }

                byte[] data = BitConverter.GetBytes(move);
                stream.Write(data, 0, data.Length);

                byte[] buffer = new byte[4];
                stream.Read(buffer, 0, buffer.Length);
                int responseData = BitConverter.ToInt32(buffer, 0);

                if (responseData == 1 && move == 1 || responseData == 2 && move == 2 || responseData == 3 && move == 3)
                {
                    vs.Text = "==";
                }

                if (responseData == 1 && move == 3 || responseData == 3 && move == 2 || responseData == 2 && move == 1)
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

                if (responseData == 1 && move == 2 || responseData == 3 && move == 1 || responseData == 2 && move == 3)
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

                switch (responseData)
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
            catch (Exception ex)
            {
                vs.Text = $"Exception: {ex.Message}";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Close();
            client?.Close();
        }
    }
}