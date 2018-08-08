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
    public partial class rdpForm : Form
    {
        
        public rdpForm()
        {
            InitializeComponent();
        }

        private void connectbtn_Click(object sender, EventArgs e) //Connects to RDP server
        {

            rdp.Server = serverNameBox.Text;
            rdp.UserName = usernameBox.Text;
            IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();
            secured.ClearTextPassword = psswordBox.Text;
            rdp.Connect();
        }

        private void Form1_Load(object sender, EventArgs e) //Server tree data
        {
            serverList.Nodes.Add("Knox County");

            serverList.Nodes[0].Nodes.Add("CC Domain Controller");
            serverList.Nodes[0].Nodes[0].Nodes.Add("192.168.254.5");

            serverList.Nodes[0].Nodes.Add("Probation Domain Controller");
            serverList.Nodes[0].Nodes[1].Nodes.Add("192.168.254.20");

            serverList.Nodes[0].Nodes.Add("Vines Computer");
            serverList.Nodes[0].Nodes[2].Nodes.Add("192.168.254.48");

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
            
        }

       

        private void serverListButton_CheckedChanged(object sender, EventArgs e) //Hides and unhides server list
        {
            
            if (serverListButton.Checked)
            {
                serverList.Visible = true;
            }
            else
            {
                serverList.Visible = false;

            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serverList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            serverNameBox.Text = serverList.SelectedNode.Text;
        }

        private void addServerButton_Click(object sender, EventArgs e)
        {
            Form AddServerForm = new Form();
            AddServerForm.Show();
            
        }

       

       
    }
}
