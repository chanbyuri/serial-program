using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using System.Windows.Threading;

namespace SerialProgram
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialPort serialPort = new SerialPort();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Com_Refresh(sender, e);
            int[] baudrate = { 9600, 19200, 38400, 57600, 115200 };
            foreach(int br in baudrate)
                comboBoxBaudrate.Items.Add(br);

            int[] databits = { 7, 8, 9 };
            foreach (int db in databits)
                comboBoxDatabits.Items.Add(db);

            foreach (StopBits sb in Enum.GetValues(typeof(StopBits)))
                comboBoxStopbits.Items.Add(sb);

            foreach (Parity p in Enum.GetValues(typeof(Parity)))
                comboBoxParity.Items.Add(p);

            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //int buffLen = serialPort.ReadBufferSize; 
            //byte[] buffer = new byte[buffLen];
            string recvStr = serialPort.ReadExisting();

            //int res = serialPort.Read(buffer, 0, buffer.Length);
            //recvData = recvSerial.Read()
            //char[] recvByte = new char[buffer.Length * 2];
            byte[] recvByte = new byte[recvStr.Length * 2];

            for (int i = 0; i < recvStr.Length; i++)
            {
                int upperBit = (recvStr[i] >> 4) & 0x0F;
                int lowerBit = recvStr[i] & 0x0F;

                recvByte[i * 2] = (byte)(upperBit > 9 ? upperBit - 10 +'A' : upperBit + '0');
                recvByte[i * 2 + 1] = (byte)(lowerBit > 9 ? lowerBit - 10 + 'A' : lowerBit + '0');
            }
            string recvByteToString = Encoding.Default.GetString(recvByte);
            //string buffString = Encoding.Default.GetString(buffer);

            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                richTextBox_hex.AppendText("recv : " + recvByteToString + Environment.NewLine);
                //richTextBox_ascii.AppendText("recv : " + buffString);
                richTextBox_ascii.AppendText("recv : " + recvStr + Environment.NewLine);
            }));

        }

        private void Com_Refresh(object sender, RoutedEventArgs e)
        {
            comboBoxCom.Items.Clear();
            foreach (string name in SerialPort.GetPortNames())
                comboBoxCom.Items.Add(name);
        }

        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {
            Com_Refresh(sender, e);
        }

        private void buttonConnect_Click(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                MessageBox.Show("이미 열려있는 포트입니다.");
                return;
            }
            serialPort.PortName = (string)comboBoxCom.SelectedItem;
            serialPort.BaudRate = (int)comboBoxBaudrate.SelectedItem;
            serialPort.DataBits = (int)comboBoxDatabits.SelectedItem;
            serialPort.StopBits = (StopBits)comboBoxStopbits.SelectedItem;
            serialPort.Parity = (Parity)comboBoxParity.SelectedItem;
            //serialPort = new SerialPort(pn,br,pr,db,sb);

            serialPort.Open();

            if(serialPort.IsOpen)
            {
                MessageBox.Show("연결되었습니다.");

                button_hex1.IsEnabled = true;
                button_hex2.IsEnabled = true;
                button_hex3.IsEnabled = true;

                button_ascii1.IsEnabled = true;
                button_ascii2.IsEnabled = true;
                button_ascii3.IsEnabled = true;
            }
            else MessageBox.Show("연결 실패.");
        }
        
        private void hex_send(TextBox textBox)
        {
            string newText = textBox.Text;
            int textLen = newText.Length;
            byte[] tranByte = new byte[textLen/2];

            if(textLen % 2 == 1)
            {
                MessageBox.Show("홀수 개의 숫자를 입력했습니다.");
                return;
            }

            for(int i = 0;i < textLen; i++)
            {
                char eachCh = newText[i];
                if (!(eachCh >= '0' && eachCh <= 'F'))
                {
                    MessageBox.Show("0 ~ F 이외의 문자가 있습니다.");
                    return;
                }

                if(i % 2 == 0)
                {
                    tranByte[i / 2] |= (byte)((eachCh & 0x0F) << 4);
                }
                else
                {
                    tranByte[i / 2] |= (byte)((eachCh & 0x0F));
                }
            }

            serialPort.Write(tranByte, 0, tranByte.Length);
            richTextBox_hex.AppendText("hex : " + newText);

            string tranText = Encoding.Default.GetString(tranByte);

            richTextBox_ascii.AppendText("hex : " + tranText);

            richTextBox_ascii.AppendText(Environment.NewLine);
            richTextBox_hex.AppendText(Environment.NewLine);
        }
        private void ascii_send(TextBox textBox)
        {
            string newText = textBox.Text;
            int textLen = newText.Length;
            byte[] hexByte = new byte[textLen * 2];

            serialPort.Write(newText);
            richTextBox_ascii.AppendText("ascii : " + newText);

            for (int i = 0; i < textLen; i++)
            {
                int upperBit = (newText[i] >> 4) & 0x0F;
                int lowerBit = newText[i] & 0x0F;

                hexByte[i * 2] = (byte)(upperBit > 9 ? upperBit - 10 + 'A' : upperBit + '0');
                hexByte[i * 2 + 1] = (byte)(lowerBit > 9 ? lowerBit - 10 + 'A' : lowerBit + '0');
            }
            string result = Encoding.Default.GetString(hexByte);
            richTextBox_hex.AppendText("ascii : " + result);

            richTextBox_ascii.AppendText(Environment.NewLine);
            richTextBox_hex.AppendText(Environment.NewLine);
        }
        private void button_hex1_Click(object sender, RoutedEventArgs e)
        {
            if(serialPort.IsOpen)   hex_send(textBox_hex1);
            else
            {
                MessageBox.Show("포트 닫힘.");
            }
        }

        private void button_hex2_Click(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                hex_send(textBox_hex2);
                textBox_hex2.Clear();
            }
            else
            {
                MessageBox.Show("포트 닫힘.");
            }
        }

        private void button_hex3_Click(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                hex_send(textBox_hex3);
                textBox_hex3.Clear();
            }
            else
            {
                MessageBox.Show("포트 닫힘.");
            }
        }

        private void button_ascii1_Click(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen) ascii_send(textBox_ascii1);
            else
            {
                MessageBox.Show("포트 닫힘.");
            }
        }

        private void button_ascii2_Click(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                ascii_send(textBox_ascii2);
                textBox_ascii2.Clear();
            }
            else
            {
                MessageBox.Show("포트 닫힘.");
            }
        }

        private void button_ascii3_Click(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                ascii_send(textBox_ascii2);
                textBox_ascii2.Clear();
            }
            else
            {
                MessageBox.Show("포트 닫힘.");
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void textBox_hex1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) button_hex1_Click(sender,e);
        }

        private void textBox_hex2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) button_hex2_Click(sender, e);
        }

        private void textBox_hex3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) button_hex3_Click(sender, e);
        }

        private void textBox_ascii1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) button_ascii1_Click(sender, e);
        }

        private void textBox_ascii2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) button_ascii2_Click(sender, e);
        }

        private void textBox_ascii3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) button_ascii3_Click(sender, e);
        }

        private void button_hexClear_Click(object sender, RoutedEventArgs e)
        {
            richTextBox_hex.Document.Blocks.Clear();
        }

        private void button_asciiClear_Click(object sender, RoutedEventArgs e)
        {
            richTextBox_ascii.Document.Blocks.Clear();
        }
    }
}
