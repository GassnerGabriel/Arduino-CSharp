using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        SerialPort usb = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            usb.PortName = "COM3";
            usb.BaudRate = 9600;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            usb.Open();
            if (usb.IsOpen)
                usb.Write(Convert.ToInt16(checkBox1.Checked).ToString());
            usb.Close();

            pictureBox1.BackColor = checkBox1.Checked ? Color.Red : SystemColors.Control;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
