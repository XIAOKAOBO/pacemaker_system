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

namespace Pacemaker
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        private DateTime datetime;
        private string in_data;
        private int anInteger;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Stop-Button
            try
            {
                myport.Close();
                progressBar1.Value = 0;
            } 
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            // connect button 
            myport = new SerialPort();
            myport.PortName = port_name_tb.Text;
            myport.BaudRate = 9600;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myport_DataReceived;
            try
            {
                myport.Open();
                progressBar1.Value =100;
                data_tb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed");
            }
        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
               if(myport.IsOpen)
                in_data = myport.ReadLine();
            }
            catch (Exception ex)
            {
                this.Invoke(new EventHandler(display_data_event));
            }
            this.Invoke(new EventHandler(display_data_event));

        }

        private void display_data_event(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            data_tb.AppendText(time+"\n\t"+in_data+"\n");
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pathfile = @"C:\Users\cobbs\Desktop\";
                string filename = "egram data.txt";
                System.IO.File.WriteAllText(pathfile + filename, data_tb.Text);
                MessageBox.Show(" Data has been saved to" + pathfile, "Save File");
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message, "Error");
            }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void transmit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (myport.IsOpen)
                {
                    anInteger = Convert.ToInt32(send_txtbox.Text);
                    anInteger = int.Parse(send_txtbox.Text);
                    byte[] b = BitConverter.GetBytes(anInteger);
                    myport.Write(b, 0, 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
