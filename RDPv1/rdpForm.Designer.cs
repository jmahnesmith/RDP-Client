namespace RDPv1
{
    partial class rdpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rdpForm));
            this.rdp = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.psswordBox = new System.Windows.Forms.TextBox();
            this.connectbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.serverList = new System.Windows.Forms.TreeView();
            this.serverListButton = new System.Windows.Forms.CheckBox();
            this.serverNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addServerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.SuspendLayout();
            // 
            // rdp
            // 
            this.rdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(0, 0);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(1137, 420);
            this.rdp.TabIndex = 0;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameBox.Location = new System.Drawing.Point(284, 442);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(137, 20);
            this.usernameBox.TabIndex = 2;
            // 
            // psswordBox
            // 
            this.psswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.psswordBox.Location = new System.Drawing.Point(486, 441);
            this.psswordBox.Name = "psswordBox";
            this.psswordBox.PasswordChar = '*';
            this.psswordBox.Size = new System.Drawing.Size(158, 20);
            this.psswordBox.TabIndex = 3;
            // 
            // connectbtn
            // 
            this.connectbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectbtn.Location = new System.Drawing.Point(668, 440);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 4;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.disconnectbtn.Location = new System.Drawing.Point(759, 439);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(75, 23);
            this.disconnectbtn.TabIndex = 12;
            this.disconnectbtn.Text = "Disconnect";
            this.disconnectbtn.UseVisualStyleBackColor = true;
            this.disconnectbtn.Click += new System.EventHandler(this.disconnectbtn_Click);
            // 
            // serverList
            // 
            this.serverList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverList.Location = new System.Drawing.Point(961, 0);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(176, 420);
            this.serverList.TabIndex = 15;
            this.serverList.Visible = false;
            this.serverList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.serverList_NodeMouseDoubleClick);
            // 
            // serverListButton
            // 
            this.serverListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.serverListButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.serverListButton.AutoSize = true;
            this.serverListButton.Location = new System.Drawing.Point(995, 438);
            this.serverListButton.Name = "serverListButton";
            this.serverListButton.Size = new System.Drawing.Size(97, 23);
            this.serverListButton.TabIndex = 16;
            this.serverListButton.Text = "Show Server List";
            this.serverListButton.UseVisualStyleBackColor = true;
            this.serverListButton.CheckedChanged += new System.EventHandler(this.serverListButton_CheckedChanged);
            // 
            // serverNameBox
            // 
            this.serverNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.serverNameBox.Location = new System.Drawing.Point(83, 441);
            this.serverNameBox.Name = "serverNameBox";
            this.serverNameBox.Size = new System.Drawing.Size(129, 20);
            this.serverNameBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addServerButton
            // 
            this.addServerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addServerButton.Location = new System.Drawing.Point(874, 439);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(83, 23);
            this.addServerButton.TabIndex = 19;
            this.addServerButton.Text = "Add Server";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.addServerButton_Click);
            // 
            // rdpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1139, 479);
            this.Controls.Add(this.addServerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serverNameBox);
            this.Controls.Add(this.serverListButton);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.disconnectbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.psswordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.rdp);
            this.Name = "rdpForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting rdp;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox psswordBox;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.TreeView serverList;
        private System.Windows.Forms.CheckBox serverListButton;
        private System.Windows.Forms.TextBox serverNameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addServerButton;
    }
}

