using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;
using AxMSTSCLib;

namespace RDPv1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {

            rdp.Server = comboBox1.SelectedItem.ToString(); 
            rdp.UserName = usernameBox.Text;
            IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();
            secured.ClearTextPassword = psswordBox.Text;
            rdp.Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        

        private void disconnectbtn_Click(object sender, EventArgs e) //Disconnects RDP connection
        {
            if (rdp.Connected.ToString() == "1")
            {
                rdp.Disconnect();
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();
        }

       

    }
}
