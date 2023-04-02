using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace _79412W13._56MHz125KHz
{
    public partial class Form1 : Form
    {
        byte[] bufWriteT5577 = { 0xAB, 0xBA, 0x00, 0x16, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };//Write T5577 key
        byte[] bufReadT5577 = { 0xAB, 0xBA, 0x00, 0x15, 0x00, 0x15, 0x00 };//Read T5577 data
        byte[] bufReadUID = { 0xAB, 0xBA, 0x00, 0x10, 0x00, 0x10, 0x00 };//Read UID

        private void FindPorts()
        {
            object[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
                CB_COMSelect.Items.Add(port);
        }

        public void RDM6300()
        {
            char[] buffer = new char[13];
            serialPort1.Read(buffer, 0, 13);
            for (int i = 1; i != 12; i++)
                TB_Output.Text += (buffer[i]);
            TB_Output.Text += Environment.NewLine;
        }


        //XOR check: result of other bytes check except protocol header (AB,BA)
        public byte XORCHeck(byte[] buffer)
        {
            int Sum = 0;
            byte request;
            for (int i = 2; i != buffer.Length - 1; i++)
            {
                Sum = Sum ^ buffer[i];
            }
            request = Convert.ToByte(Sum);
            return request;
        }

       
        // function clearout a message and returns a key

        public byte[] GetAKey(byte[] message)
        {
            if (message != null)
            {
                byte[] data = new byte[message[4]];
                for (int i = 0; i != message[4]; i++)
                {
                    data[i] = message[i + 5];
                }
                return data;
            }
            return null;
        }
        //function send a message to module return true if operation succesfull
        public bool TryToSend(byte[] buffer)
        {
            // check if port is ready for reading
            if (serialPort1.IsOpen)
            {
                try
                {
                    int[] data = new int[4];
                    buffer[buffer.Length - 1] = XORCHeck(buffer);
                    serialPort1.Write(buffer, 0, buffer.Length);
                   
                    System.Threading.Thread.Sleep(400);//Module need some sleep, or data will zero

                    if (serialPort1.BytesToRead != 1 && serialPort1.BytesToRead != 0)
                    {
                        for (int i = 0; i != 4; i++)
                        {
                            data[i] = serialPort1.ReadByte();
                        }

                        serialPort1.DiscardInBuffer();
                       
                        if (data[3].ToString("X") == "81") return true;
                        else
                            return false;
                        
                    }
                    else return false;
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Ошбика подключения! Время ожидания превышено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                // give error warning
                MessageBox.Show("Порт не открыт!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        //function sends message and returns message from the module
        private byte[] SendAndReadMessage(byte[] message)
        {
            // check if port is ready for reading
            if (serialPort1.IsOpen)
            {
                try
                {
                    message[message.Length - 1] = XORCHeck(message);
                    serialPort1.Write(message, 0, message.Length);

                    System.Threading.Thread.Sleep(100);//Module need some sleep, or data will zero
                    if (serialPort1.BytesToRead != 1 && serialPort1.BytesToRead != 0)
                    {
                        byte[] buffer = new byte[serialPort1.BytesToRead];

                        serialPort1.Read(buffer, 0, buffer.Length);
                        serialPort1.DiscardInBuffer();
                        return buffer;
                    }
                    else return null;
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Ошбика подключения! Время ожидания превышено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

            }
            else
                // give error warning
                MessageBox.Show("Порт не открыт!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private void Output(byte[] buffer)
        {
            TB_Output.Text += "Key: ";
            for (byte i = 0; i != buffer.Length; i++)
            {
                if (buffer[i] == 0) TB_Output.Text += "0";
                TB_Output.Text += buffer[i].ToString("X");
                TB_Output.Text += '-';
            }
            if (TB_Output.Text.Length != 0) TB_Output.Text = TB_Output.Text.Substring(0, TB_Output.Text.Length - 1);//Clear the last '-' symbol 
            TB_Output.Text += Environment.NewLine;
            TB_Output.Text += "--------------------------";
            TB_Output.Text += Environment.NewLine;
        }


        public Form1()
        {
            InitializeComponent();
            FindPorts();
        }

        private void CB_COMSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Output.Text = String.Empty;
            progressBar1.Value = 0;

            if (CB_BaudSelect.Text == String.Empty || CB_COMSelect.Text == String.Empty)
                LBStatus.Text = "Please Select Port Settings";
            else
            {
                try
                {
                    try
                    {
                        // make sure port isn't open	
                        if (!serialPort1.IsOpen)
                        {
                            serialPort1.PortName = CB_COMSelect.Text;

                            serialPort1.BaudRate = Int32.Parse(CB_BaudSelect.Text);

                            //open serial port 
                            serialPort1.Open();

                            progressBar1.Value = 100;
                            LBStatus.Text = "Connection is OK";
                            CB_COMSelect.Enabled = false;
                            ReconnectBtn.Enabled = false;
                        }
                        else
                            LBStatus.Text = "Port isn't openned";
                    }
                    catch (System.IO.IOException) { LBStatus.Text = "COM timeout error"; }
                }
                catch (UnauthorizedAccessException)
                {
                    LBStatus.Text = "UnauthorizedAccess";
                }

            }
        }

        private void CB_BaudSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Int32.Parse(CB_BaudSelect.Text);

        }

        //ReadButton
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            // check if port is ready for reading
            if (serialPort1.IsOpen)
            {

                try
                {
                    if (TryToSend(bufReadT5577)) Output(GetAKey(SendAndReadMessage(bufReadT5577)));
                    else
                     if (TryToSend(bufReadUID)) Output(GetAKey(SendAndReadMessage(bufReadUID)));
                    else LBStatus.Text = "Read Err";
                }
                catch (TimeoutException)
                {
                    LBStatus.Text = "Timeout Exception";
                }
                // Disable the init button
                // the asynchronous operation is done.
                CB_COMSelect.Enabled = false;

            }
            else
                // give error warning
                LBStatus.Text = "Port Not Opened";

        }

        //disconnection button
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {

            serialPort1.Close();
            progressBar1.Value = 0;
            CB_COMSelect.Enabled = true;
            LBStatus.Text = "Port has been disconnected";
            ReconnectBtn.Enabled = true;
        }

        private void RescanBtn_Click(object sender, EventArgs e)
        {
            CB_COMSelect.Items.Clear();
            FindPorts();
        }

        private void ReconnectBtn_Click(object sender, EventArgs e)
        {
            TB_Output.Text = String.Empty;
            progressBar1.Value = 0;

            if (CB_BaudSelect.Text == String.Empty || CB_COMSelect.Text == String.Empty)
                LBStatus.Text = "Please Select Port Settings";
            else
            {
                try
                {
                    try
                    {
                        // make sure port isn't open	
                        if (!serialPort1.IsOpen)
                        {
                            serialPort1.PortName = CB_COMSelect.Text;

                            serialPort1.BaudRate = Int32.Parse(CB_BaudSelect.Text);

                            //open serial port 
                            serialPort1.Open();
                            progressBar1.Value = 100;
                            LBStatus.Text = "Connection is OK";
                            CB_COMSelect.Enabled = false;
                            ReconnectBtn.Enabled = false;
                        }
                        else
                            LBStatus.Text = "Port isn't openned";
                    }

                    catch (System.IO.IOException) { LBStatus.Text = "COM timeout error"; }
                }
                catch (UnauthorizedAccessException)
                {
                    LBStatus.Text = "UnauthorizedAccess";
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    TB_Output.Invoke((MethodInvoker)delegate
                    {
                    });
                }
                catch (TimeoutException)
                {
                    LBStatus.Invoke((MethodInvoker)delegate
                    {
                        LBStatus.Text = "Timeout Exception";
                    });
                }

            }
            else
            {// give error warning
                LBStatus.Invoke((MethodInvoker)delegate
                {
                    LBStatus.Text = "Port Not Opened";
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_Output.Text = String.Empty;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                // this will read manually
                try
                {
                    if (TryToSend(bufReadT5577)) LBStatus.Text = "125KHz";
                    else
                    if (TryToSend(bufReadUID)) LBStatus.Text = "13.56MHz";
                    else LBStatus.Text = "Err";
                }
                catch (TimeoutException)
                {
                    LBStatus.Text = "Timeout Exception";
                }

            }
            else
                // give error warning
                LBStatus.Text = "Port Not Opened";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                byte[] message = bufWriteT5577;
                int[] DATA = new int[5];
                InputData = maskedTextBox1.Text.Split('-');//Clearing from trash
               
                try
                {
                    for (int g = 0; g < InputData.Length; g++)//HEX to INT
                        DATA[g] = Convert.ToInt32(InputData[g], 16);
                }
                catch (System.FormatException) 
                {
                    MessageBox.Show("This is not HEX!");
                    maskedTextBox1.Text = "";
                }

                key = DATA.Select(x => (byte)x).ToArray();//INT to Byte

                for (byte i = 0; i != key.Length; i++)
                    message[5 + i] = key[i];


                if (TryToSend(message) == true) MessageBox.Show("Opertaion Success!");
                else MessageBox.Show("Opertaion fail!");
                }
            else MessageBox.Show("Error in input!");
            }

            private void button3_Click(object sender, EventArgs e)
            {
                var rand = new Random();

                rand.NextBytes(key);

                maskedTextBox1.Text = BitConverter.ToString(key);
                maskedTextBox1.Text = maskedTextBox1.Text.Replace("-", "");
            }

            private void tabPage2_Click(object sender, EventArgs e)
            {
                AuthForm form = new AuthForm();
                form.Show();
            }


        //DATA BASE CODE PART 
        public bool AccessFlag = false;

        public string connect = "server=localhost;user=root;password=1337;database=vaulttechsecure;port=3306;charset=utf8;convert zero datetime=True";

        string SerialNumber;
        public byte[] key = new byte[5];
        string[] InputData = new string[5];
        void update()
        {
            try
            {
                MySqlConnection mycon = new MySqlConnection(connect);
                mycon.Open();
                string sql = "SELECT * FROM residents;";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, mycon);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TB_Name.Text != "" && TB_LastName.Text != "" && TB_GroupCode.Text != "" && SerialNumber != "")
            {
                try
                {
                    //string str = "server=localhost;user=root;password=1337;database=vaulttechsecure;port=3306";
                    MySqlConnection mycon = new MySqlConnection(connect);
                    mycon.Open();
                    string query = "INSERT INTO `residents`(`Name` , `Last Name` , `GroupCode` , `SerialNumber`) VALUES ('" + TB_Name.Text + "', '" + TB_LastName.Text + "', '" + Convert.ToInt32(TB_GroupCode.Text) + "', '" + SerialNumber + "');";
                    MySqlCommand command = new MySqlCommand(query, mycon);
                    command.ExecuteNonQuery();
                    mycon.Close();
                    update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TB_Name.Text = ""; TB_LastName.Text = ""; TB_GroupCode.Text = ""; TB_CardNumber.Text = ""; SerialNumber = "";
        }



        private void button6_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            rand.NextBytes(key);

            SerialNumber = BitConverter.ToString(key);
            TB_CardNumber.Text = SerialNumber;

            byte[] message = bufWriteT5577;
            for (byte i = 0; i != 5; i++)
            {
                message[5 + i] = key[i];
            }

            if (TryToSend(message) == true) MessageBox.Show("Card writing success!");
            else MessageBox.Show("Card writing fail!");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TryToSend(bufReadT5577) == true) MessageBox.Show("Card was found!");
            else MessageBox.Show("Card read fail!");

            SerialNumber = BitConverter.ToString(GetAKey(SendAndReadMessage(bufReadT5577)));
            TB_CardNumber.Text = SerialNumber;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            string idNumber = "";

            idNumber = Interaction.InputBox("Enter id number of member to delete", "Deleting a member", "");

            if (idNumber != "")
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connect))
                    {
                        var command = new MySqlCommand("SET FOREIGN_KEY_CHECKS=0; Delete from residents where idresidents = @idresidents; SET FOREIGN_KEY_CHECKS=1", connection);
                        command.Parameters.Add("@idresidents", MySqlDbType.Int32).Value = Convert.ToInt32(idNumber);
                        connection.Open();
                        command.ExecuteNonQuery();
                        update();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            else MessageBox.Show("Plsease enter an id to delete a member!");
        }

        private AuthForm _AuthForm;
        private void button9_Click(object sender, EventArgs e)
        {
            _AuthForm = new AuthForm();
            _AuthForm.AccessGranted += (o, args) =>
            {
                button4.Visible = !button4.Visible;
                button5.Visible = !button5.Visible;
                button8.Visible = !button8.Visible;
                dataGridView1.Visible = !dataGridView1.Visible;
                _AuthForm.Close();
                update();
            };
            _AuthForm.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
