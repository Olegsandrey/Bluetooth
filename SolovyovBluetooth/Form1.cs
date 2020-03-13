using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.ComponentModel;
using System.Data;
using System.Drawing;\
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolovyovBluetooth

{
    public partial class Form1 : Form
    {
        List<BluetoothDeviceInfo> DevList = new List<BluetoothDeviceInfo>();
        public delegate void UpdateDiscoverBox(List<BluetoothDeviceInfo> d);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
