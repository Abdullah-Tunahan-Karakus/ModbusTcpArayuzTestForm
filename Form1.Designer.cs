namespace ModbusTcpArayüzTest1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnDisconnect = new Button();
            btnConnect = new Button();
            txtPort = new TextBox();
            txtIp = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            btnRead = new Button();
            txtReadQuantity = new TextBox();
            txtReadAddress = new TextBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            btnWriteSingle = new Button();
            txtWriteSingleValue = new TextBox();
            txtWriteSingleAddress = new TextBox();
            groupBox4 = new GroupBox();
            btnWriteMulti = new Button();
            txtWriteMultiValues = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtWriteMultiAddress = new TextBox();
            txtLog = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDisconnect);
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtIp);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bağlantı Ayarları";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 59);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Port:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "IP Address:";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(119, 111);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(6, 111);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(94, 51);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 1;
            txtPort.Text = "502";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(94, 22);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(100, 23);
            txtIp.TabIndex = 0;
            txtIp.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnRead);
            groupBox2.Controls.Add(txtReadQuantity);
            groupBox2.Controls.Add(txtReadAddress);
            groupBox2.Location = new Point(218, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veri Okuma Fnc03";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 59);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Kaç Adet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 30);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 4;
            label4.Text = "Başlangıç Adres:";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(59, 111);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtReadQuantity
            // 
            txtReadQuantity.Location = new Point(94, 51);
            txtReadQuantity.Name = "txtReadQuantity";
            txtReadQuantity.Size = new Size(100, 23);
            txtReadQuantity.TabIndex = 1;
            // 
            // txtReadAddress
            // 
            txtReadAddress.Location = new Point(94, 22);
            txtReadAddress.Name = "txtReadAddress";
            txtReadAddress.Size = new Size(100, 23);
            txtReadAddress.TabIndex = 0;
            txtReadAddress.Text = "40001";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnWriteSingle);
            groupBox3.Controls.Add(txtWriteSingleValue);
            groupBox3.Controls.Add(txtWriteSingleAddress);
            groupBox3.Location = new Point(424, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 140);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tekli Veri Yazma Fnc06";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 59);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 5;
            label5.Text = "Değer:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 30);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 4;
            label6.Text = "Adres:";
            // 
            // btnWriteSingle
            // 
            btnWriteSingle.Location = new Point(59, 111);
            btnWriteSingle.Name = "btnWriteSingle";
            btnWriteSingle.Size = new Size(75, 23);
            btnWriteSingle.TabIndex = 3;
            btnWriteSingle.Text = "SWrite";
            btnWriteSingle.UseVisualStyleBackColor = true;
            btnWriteSingle.Click += btnWriteSingle_Click;
            // 
            // txtWriteSingleValue
            // 
            txtWriteSingleValue.Location = new Point(94, 51);
            txtWriteSingleValue.Name = "txtWriteSingleValue";
            txtWriteSingleValue.Size = new Size(100, 23);
            txtWriteSingleValue.TabIndex = 1;
            // 
            // txtWriteSingleAddress
            // 
            txtWriteSingleAddress.Location = new Point(94, 22);
            txtWriteSingleAddress.Name = "txtWriteSingleAddress";
            txtWriteSingleAddress.Size = new Size(100, 23);
            txtWriteSingleAddress.TabIndex = 0;
            txtWriteSingleAddress.Text = "40001";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnWriteMulti);
            groupBox4.Controls.Add(txtWriteMultiValues);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtWriteMultiAddress);
            groupBox4.Location = new Point(630, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 140);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Çoklu Veri Yazma Fnc16";
            // 
            // btnWriteMulti
            // 
            btnWriteMulti.Location = new Point(60, 102);
            btnWriteMulti.Name = "btnWriteMulti";
            btnWriteMulti.Size = new Size(75, 23);
            btnWriteMulti.TabIndex = 8;
            btnWriteMulti.Text = "MWrite";
            btnWriteMulti.UseVisualStyleBackColor = true;
            btnWriteMulti.Click += btnWriteMulti_Click;
            // 
            // txtWriteMultiValues
            // 
            txtWriteMultiValues.Location = new Point(94, 56);
            txtWriteMultiValues.Name = "txtWriteMultiValues";
            txtWriteMultiValues.Size = new Size(100, 23);
            txtWriteMultiValues.TabIndex = 7;
            txtWriteMultiValues.Text = "10,20,30";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 30);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 6;
            label8.Text = "Başlangıç Adres:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 59);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 5;
            label7.Text = "Değerler:";
            // 
            // txtWriteMultiAddress
            // 
            txtWriteMultiAddress.Location = new Point(94, 22);
            txtWriteMultiAddress.Name = "txtWriteMultiAddress";
            txtWriteMultiAddress.Size = new Size(100, 23);
            txtWriteMultiAddress.TabIndex = 0;
            txtWriteMultiAddress.Text = "40001";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 158);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(818, 212);
            txtLog.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 374);
            Controls.Add(txtLog);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnDisconnect;
        private Button btnConnect;
        private TextBox txtPort;
        private TextBox txtIp;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Button btnRead;
        private TextBox txtReadQuantity;
        private TextBox txtReadAddress;
        private GroupBox groupBox3;
        private Label label5;
        private Label label6;
        private Button btnWriteSingle;
        private TextBox txtWriteSingleValue;
        private TextBox txtWriteSingleAddress;
        private GroupBox groupBox4;
        private Label label7;
        private Button button2;
        private TextBox textBox3;
        private TextBox txtWriteMultiAddress;
        private Label label8;
        private TextBox txtLog;
        private Button btnWriteMulti;
        private TextBox txtWriteMultiValues;
    }
}
