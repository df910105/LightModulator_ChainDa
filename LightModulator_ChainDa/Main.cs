using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightModulator_ChainDa
{
    public partial class Main : Form
    {
        private readonly SerialPort sp = new();

        public Main()
        {
            InitializeComponent(); 
            Init();
            sp.DataReceived += Sp_DataReceived;
            CheckSerialStatus();
        }

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                var sp = sender as SerialPort;
                var msg = sp.ReadLine();
                TB_Received.AppendText(msg + "\n");
                Console.WriteLine($"Lighter Msg:{msg}");
            }
            catch
            {

            }
        }

        private void Init()
        {
            int[] baudrate = { 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000 };
            int[] databits = { 5, 6, 7, 8 };
            CB_PortName.DataSource = SerialPort.GetPortNames();
            CB_BaudRate.DataSource = baudrate;
            CB_DataBits.DataSource = databits;
            CB_Parity.DataSource = typeof(Parity).GetEnumValues();
            CB_StopBits.DataSource = typeof(StopBits).GetEnumValues();
            CB_SelectCh0.SelectedIndex = 0;
            CB_SelectCh1.SelectedIndex = 1;
            CB_SelectCh2.SelectedIndex = 2;
            CB_SelectCh3.SelectedIndex = 3;
        }

        private void CheckSerialStatus()
        {
            var open = sp.IsOpen;
            Label_Connection.ForeColor = open ? Color.LimeGreen : Color.Red;
            GB_Type.Enabled = !open;
            Btn_Open.Enabled = !open;
            Btn_Close.Enabled = open;
            CB_PortName.SelectedItem = sp.PortName;
            CB_BaudRate.SelectedItem = sp.BaudRate;
            CB_DataBits.SelectedItem = sp.DataBits;
            CB_Parity.SelectedItem = sp.Parity;
            CB_StopBits.SelectedItem = sp.StopBits;
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = CB_PortName.SelectedItem.ToString();
                sp.BaudRate = (int)CB_BaudRate.SelectedItem;
                sp.DataBits = (int)CB_DataBits.SelectedItem;
                sp.Parity = (Parity)CB_Parity.SelectedItem;
                sp.StopBits = (StopBits)CB_StopBits.SelectedItem;
                sp.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CheckSerialStatus();
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            sp.Close();
            CheckSerialStatus();
        }

        private void Btn_TypeA_Click(object sender, EventArgs e)
        {
            sp.BaudRate = 115200;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            CheckSerialStatus();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
        }

        public void ChangeLight(byte ch, int value)
        {
            if (sp.IsOpen)
            {
                try
                {
                    byte high = (byte)(value / 256 * 16);
                    byte low = (byte)(value % 256);
                    byte[] cmd = { 0x89, 0x55, 0xAA, 0x23, ch, high, low, 0x00 };
                    cmd = CheckSum(cmd);
                    TB_Send.AppendText(BitConverter.ToString(cmd) + "\r\n");
                    sp.Write(cmd, 0, cmd.Length);
                }
                catch
                {

                }
            }
        }

        private static byte[] CheckSum(byte[] data)
        {
            long longSum = data.Sum(x => (long)x);
            byte sum = unchecked((byte)longSum);
            return data.Append(sum).ToArray();
        }

        private void Btn_SetCh0_Click(object sender, EventArgs e)
        {
            ChangeLight((byte)CB_SelectCh0.SelectedIndex, (int)NUD_SelectCh0.Value);
        }

        private void Btn_SetCh1_Click(object sender, EventArgs e)
        {
            ChangeLight((byte)CB_SelectCh1.SelectedIndex, (int)NUD_SelectCh1.Value);
        }

        private void Btn_SetCh2_Click(object sender, EventArgs e)
        {
            ChangeLight((byte)CB_SelectCh2.SelectedIndex, (int)NUD_SelectCh2.Value);
        }

        private void Btn_SetCh3_Click(object sender, EventArgs e)
        {
            ChangeLight((byte)CB_SelectCh3.SelectedIndex, (int)NUD_SelectCh3.Value);
        }
    }
}
