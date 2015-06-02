using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TryToChat
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;


        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string name)
        {
            InitializeComponent();
            this.Text = name;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создание сокета, задание всяких типов и тд
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Заполнение по умолчанию поля с ip (по дефолту там свой локальный ip), а если сетки нет, то localhost
            ipLabel.Text = getIP();

        }

        private String getIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            //Биндим сокет
            epLocal = new IPEndPoint(IPAddress.Parse(getIP()), Convert.ToInt32(localPortTextField.Text));
            socket.Bind(epLocal);
            //Подключаемся к удаленному IP
            epRemote = new IPEndPoint(IPAddress.Parse(ipTextField.Text), Convert.ToInt32(remPortTextField.Text));
            socket.Connect(epRemote);
            //Слушаем порт
            buffer = new byte[1500];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

        }

        private void messageCallBack(IAsyncResult result)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])result.AsyncState;

                //Конвертируем в байты в строку
                String receivedMessage = Encoding.UTF8.GetString(receivedData);
                

                //Выводим сообщение в textArea
                textArea.Items.Add("Гость: " + receivedMessage);

                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //Преобразуем строку в byte[]
            byte[] sendingMessage = new byte[1500];
            sendingMessage = Encoding.UTF8.GetBytes(messageField.Text);

            //Отправляем сообщение
            socket.Send(sendingMessage);

            //Добавляем его в textArea
            textArea.Items.Add("Я: " + messageField.Text);
            messageField.Text = "";
        }
    }
}
