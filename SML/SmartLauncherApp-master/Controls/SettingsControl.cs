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

namespace Artemis
{
    public partial class SettingsControl : UserControl
    {
        string sendData = "";
        bool portState = false;
        private void DrawPieChart(double value1, double v2, double v3)
        {
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.BackColor = Color.Transparent;
            string series = "seriesName";
            chart1.Series.Add(series);
            chart1.Series[series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[series].Points.AddXY("Available water volume", value1);
            chart1.Series[series].Points.AddXY("Amount of water needed to refill", v2);
            chart1.Series[series].Points.AddXY("Critical water level", v3);
        }
        string serialData;
        sbyte pozA, pozB, pozC, pozD, pozE, pozF, pozG, pozH, pozI, pozJ, pozK, pozL;
        string senzorTemp, senzorUmid, senzorPress;
        string AvailableWater, WaterOut, VolumeWaterLeft;
        double WaterOutD=20, AvailableWaterD=20, VolumeWaterLeftD=20;
        public SettingsControl()
        {
            InitializeComponent();
            timer1.Start();
            shadowLabel10.Visible = shadowLabel13.Visible = shadowLabel16.Visible = shadowLabel11.Visible = shadowLabel15.Visible = shadowLabel12.Visible = false;
            shadowLabel10.Enabled = shadowLabel13.Enabled = shadowLabel16.Enabled = shadowLabel11.Enabled = shadowLabel15.Enabled = shadowLabel12.Enabled = false;
            skeetButton1.Visible = skeetButton2.Visible = skeetButton3.Visible = false;
            skeetButton1.Enabled = skeetButton2.Enabled = skeetButton3.Enabled = false;
            textBox1.Visible = textBox2.Visible = textBox3.Visible = false;
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = false;
            skeetComboBox2.SelectedIndex = 1;
        }
        private void skeetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPortList.Text;
        }

        private void skeetToggle2_CheckedChanged(object sender)
        {
            if (butonDeschiderePort.Checked)
            {
                try
                {
                    serialPort1.PortName = comboBoxPortList.Text;
                    serialPort1.BaudRate = Convert.ToInt32(ComboBoxBaudRate.Text);
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        labelPortState.Text = "OPEN";
                        butonDeschiderePort.Checked = true;
                        serialPort1.Write("Z");
                        portState = true;
                    }
                }
                catch (Exception error)
                {
                    butonDeschiderePort.Checked = portState;
                    if (comboBoxPortList.Text != "" && ComboBoxBaudRate.Text == "")
                        MessageBox.Show("You must select the baudrate of the port before opening it !");
                    else if (comboBoxPortList.Text == "" && ComboBoxBaudRate.Text != "")
                        MessageBox.Show("You must select the port before opening it !");
                    else
                        MessageBox.Show("You must select a port and the baudrate of the port before opening it !");
                }
            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                        labelPortState.Text = "CLOSED";
                        butonDeschiderePort.Checked = false;
                        portState = false;
                    }
                }
                catch (Exception error)
                {
                   // MessageBox.Show(error.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("E");
                serialPort1.Close();
                Application.Exit();
            }
            else
                Application.Exit();
        }

        private void skeetComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 0 pentru cylinder si 1 pentru paralelipipedic
                if (skeetComboBox1.SelectedIndex == 0)
                {
                    skeetButton3.Visible = true;
                    skeetButton3.Enabled = true;
                    shadowLabel10.Visible = true; shadowLabel10.Enabled = true;  shadowLabel11.Enabled = true; shadowLabel11.Visible = true;
                    textBox2.Enabled = true; textBox2.Visible = true;

                    shadowLabel13.Visible = shadowLabel16.Visible = shadowLabel15.Visible = shadowLabel12.Visible = false;
                    shadowLabel13.Enabled = shadowLabel16.Enabled = shadowLabel11.Enabled = shadowLabel15.Enabled = shadowLabel12.Enabled = false;
                    skeetButton1.Visible = skeetButton2.Visible = false;
                    skeetButton1.Enabled = skeetButton2.Enabled = false;
                    textBox1.Visible = textBox3.Visible = false;
                    textBox1.Enabled = textBox3.Enabled = false;
                    serialPort1.Write("J");
                }
                else if (skeetComboBox1.SelectedIndex == 1)
                {
                    shadowLabel10.Visible = shadowLabel11.Visible = false;
                    shadowLabel10.Enabled = shadowLabel11.Enabled = false;
                    skeetButton3.Enabled = false; skeetButton3.Visible = false;
                    textBox2.Enabled = false; textBox2.Visible = false;

                    shadowLabel13.Visible = shadowLabel16.Visible = shadowLabel15.Visible = shadowLabel12.Visible = true;
                    shadowLabel13.Enabled = shadowLabel16.Enabled = shadowLabel11.Enabled = shadowLabel15.Enabled = shadowLabel12.Enabled = true;
                    skeetButton1.Visible = skeetButton2.Visible = true;
                    skeetButton1.Enabled = skeetButton2.Enabled = true;
                    textBox1.Visible = textBox3.Visible = true;
                    textBox1.Enabled = textBox3.Enabled = true;
                    serialPort1.Write("K");
                }
            }
        }
        private void skeetButton3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                sendData = "D" + textBox2.Text;
                serialPort1.Write(sendData);
            }
            else
                MessageBox.Show("Please open a port before updating the values !");
        }

        private void skeetButton1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                sendData = "L" + textBox1.Text;
                serialPort1.Write(sendData);
            }
            else
                MessageBox.Show("Please open a port before updating the values !");
        }

        private void skeetButton2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                sendData = "W" + textBox3.Text;
                serialPort1.Write(sendData);
            }
            else
                MessageBox.Show("Please open a port before updating the values !");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void skeetButton5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialData = "T" + textBox4.Text;
                serialPort1.Write(serialData);
            }
            else
                MessageBox.Show("Please open a port before updating the values !");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialData = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void skeetComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if (skeetComboBox2.SelectedIndex == 0)
                {
                    serialPort1.Write("C"); // AUTO
                }
                else if(skeetComboBox2.SelectedIndex == 1)
                {
                    serialPort1.Write("Z"); // MANUAL
                }

            }
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                pozA = Convert.ToSByte(serialData.IndexOf("a"));
                pozB = Convert.ToSByte(serialData.IndexOf("b"));
                pozC = Convert.ToSByte(serialData.IndexOf("c"));
                pozD = Convert.ToSByte(serialData.IndexOf("d"));
                pozE = Convert.ToSByte(serialData.IndexOf("e"));
                pozF = Convert.ToSByte(serialData.IndexOf("f"));
                pozG = Convert.ToSByte(serialData.IndexOf("g"));
                pozH = Convert.ToSByte(serialData.IndexOf("h"));
                pozI = Convert.ToSByte(serialData.IndexOf("i"));
                pozJ = Convert.ToSByte(serialData.IndexOf("j"));
                pozK = Convert.ToSByte(serialData.IndexOf("k"));
                pozL = Convert.ToSByte(serialData.IndexOf("l"));

                senzorTemp = serialData.Substring(0, pozA);
                senzorUmid = serialData.Substring(pozA + 1, (pozB - pozA) - 1);
                AvailableWater = serialData.Substring(pozC + 1, Math.Max(0, (pozD - pozC) - 1));
                WaterOut = serialData.Substring(pozD + 1, Math.Max(0, (pozE - pozD) - 1));
                VolumeWaterLeft = serialData.Substring(pozE + 1, Math.Max(0, (pozF - pozE) - 1));
                senzorPress = serialData.Substring(pozK+1, (pozL- pozK) - 1);

                AvailableWaterD = double.Parse(AvailableWater);
                WaterOutD = double.Parse(WaterOut);
                VolumeWaterLeftD = double.Parse(WaterOut);
                shadowLabel4.Text = senzorTemp;
                shadowLabel7.Text = senzorUmid;
                DrawPieChart(AvailableWaterD, WaterOutD, 3.00);
                shadowLabel22.Text = senzorPress;
            }
            catch(Exception error)
            {
                //MessageBox.Show(error.Message);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dataTime = DateTime.Now;
            label1.Text = dataTime.ToString();
        }

        private void comboBoxPortList_DropDown(object sender, EventArgs e)
        {
            string[] listaPort = SerialPort.GetPortNames();
            comboBoxPortList.Items.Clear();
            comboBoxPortList.Items.AddRange(listaPort);
        }
    }
}
