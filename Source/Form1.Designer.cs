namespace Cockpit
{
    partial class Form1
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
            this.TxtConnection = new System.Windows.Forms.TextBox();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblConnection = new System.Windows.Forms.Label();
            this.BtConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtConnection
            // 
            this.TxtConnection.Location = new System.Drawing.Point(13, 13);
            this.TxtConnection.Name = "TxtConnection";
            this.TxtConnection.Size = new System.Drawing.Size(100, 20);
            this.TxtConnection.TabIndex = 0;
            // 
            // TxtInfo
            // 
            this.TxtInfo.Location = new System.Drawing.Point(13, 60);
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(259, 20);
            this.TxtInfo.TabIndex = 1;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(12, 44);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(25, 13);
            this.LblInfo.TabIndex = 2;
            this.LblInfo.Text = "Info";
            // 
            // LblConnection
            // 
            this.LblConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblConnection.Location = new System.Drawing.Point(119, 13);
            this.LblConnection.Name = "LblConnection";
            this.LblConnection.Size = new System.Drawing.Size(20, 20);
            this.LblConnection.TabIndex = 3;
            // 
            // BtConnect
            // 
            this.BtConnect.Location = new System.Drawing.Point(162, 12);
            this.BtConnect.Name = "BtConnect";
            this.BtConnect.Size = new System.Drawing.Size(96, 41);
            this.BtConnect.TabIndex = 4;
            this.BtConnect.Text = "Connect";
            this.BtConnect.UseVisualStyleBackColor = true;
            this.BtConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtConnect);
            this.Controls.Add(this.LblConnection);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.TxtConnection);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TxtConnection;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblConnection;
        private System.Windows.Forms.Button BtConnect;
    }
}

