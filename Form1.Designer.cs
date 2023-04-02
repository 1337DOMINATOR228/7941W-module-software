
namespace _79412W13._56MHz125KHz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LBStatus = new System.Windows.Forms.Label();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReconnectBtn = new System.Windows.Forms.Button();
            this.RescanBtn = new System.Windows.Forms.Button();
            this.CB_COMSelect = new System.Windows.Forms.ComboBox();
            this.CB_BaudSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Module = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TB_CardNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_GroupCode = new System.Windows.Forms.TextBox();
            this.TB_LastName = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Module.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.SendBtn);
            this.groupBox3.Controls.Add(this.TB_Output);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ReadBtn);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 266);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DataOpertion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Input";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 28);
            this.maskedTextBox1.Mask = "AA-AA-AA-AA-AA";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(149, 22);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(6, 56);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 10;
            this.SendBtn.Text = "Scan";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(6, 98);
            this.TB_Output.Multiline = true;
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.ReadOnly = true;
            this.TB_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Output.Size = new System.Drawing.Size(155, 134);
            this.TB_Output.TabIndex = 3;
            this.TB_Output.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output";
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(6, 237);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 9;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.LBStatus);
            this.groupBox2.Controls.Add(this.DisconnectBtn);
            this.groupBox2.Location = new System.Drawing.Point(201, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // LBStatus
            // 
            this.LBStatus.AutoSize = true;
            this.LBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBStatus.Location = new System.Drawing.Point(6, 18);
            this.LBStatus.Name = "LBStatus";
            this.LBStatus.Size = new System.Drawing.Size(56, 16);
            this.LBStatus.TabIndex = 7;
            this.LBStatus.Text = "Default";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(61, 68);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.DisconnectBtn.TabIndex = 10;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReconnectBtn);
            this.groupBox1.Controls.Add(this.RescanBtn);
            this.groupBox1.Controls.Add(this.CB_COMSelect);
            this.groupBox1.Controls.Add(this.CB_BaudSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(201, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Settings";
            // 
            // ReconnectBtn
            // 
            this.ReconnectBtn.Location = new System.Drawing.Point(13, 79);
            this.ReconnectBtn.Name = "ReconnectBtn";
            this.ReconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ReconnectBtn.TabIndex = 8;
            this.ReconnectBtn.Text = "Reconnect";
            this.ReconnectBtn.UseVisualStyleBackColor = true;
            this.ReconnectBtn.Click += new System.EventHandler(this.ReconnectBtn_Click);
            // 
            // RescanBtn
            // 
            this.RescanBtn.Location = new System.Drawing.Point(112, 79);
            this.RescanBtn.Name = "RescanBtn";
            this.RescanBtn.Size = new System.Drawing.Size(82, 23);
            this.RescanBtn.TabIndex = 7;
            this.RescanBtn.Text = "Rescan";
            this.RescanBtn.UseVisualStyleBackColor = true;
            this.RescanBtn.Click += new System.EventHandler(this.RescanBtn_Click);
            // 
            // CB_COMSelect
            // 
            this.CB_COMSelect.FormattingEnabled = true;
            this.CB_COMSelect.Location = new System.Drawing.Point(73, 21);
            this.CB_COMSelect.Name = "CB_COMSelect";
            this.CB_COMSelect.Size = new System.Drawing.Size(121, 21);
            this.CB_COMSelect.TabIndex = 0;
            this.CB_COMSelect.SelectedIndexChanged += new System.EventHandler(this.CB_COMSelect_SelectedIndexChanged);
            // 
            // CB_BaudSelect
            // 
            this.CB_BaudSelect.FormattingEnabled = true;
            this.CB_BaudSelect.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.CB_BaudSelect.Location = new System.Drawing.Point(73, 48);
            this.CB_BaudSelect.Name = "CB_BaudSelect";
            this.CB_BaudSelect.Size = new System.Drawing.Size(121, 21);
            this.CB_BaudSelect.TabIndex = 1;
            this.CB_BaudSelect.Text = "115200";
            this.CB_BaudSelect.SelectedIndexChanged += new System.EventHandler(this.CB_BaudSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud rate";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Module
            // 
            this.Module.Controls.Add(this.tabPage1);
            this.Module.Controls.Add(this.tabPage2);
            this.Module.Location = new System.Drawing.Point(0, -3);
            this.Module.Name = "Module";
            this.Module.SelectedIndex = 0;
            this.Module.Size = new System.Drawing.Size(427, 300);
            this.Module.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Module";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "GenKey";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.TB_CardNumber);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TB_GroupCode);
            this.tabPage2.Controls.Add(this.TB_LastName);
            this.tabPage2.Controls.Add(this.TB_Name);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataBase";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(4, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 20);
            this.button9.TabIndex = 15;
            this.button9.Text = "Enter to DB";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(189, 241);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Delete a member";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(11, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Use a card with number";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Generate and write a card";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(338, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(224, 217);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // TB_CardNumber
            // 
            this.TB_CardNumber.Location = new System.Drawing.Point(83, 120);
            this.TB_CardNumber.Name = "TB_CardNumber";
            this.TB_CardNumber.ReadOnly = true;
            this.TB_CardNumber.Size = new System.Drawing.Size(100, 22);
            this.TB_CardNumber.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Card Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Group Code";
            // 
            // TB_GroupCode
            // 
            this.TB_GroupCode.Location = new System.Drawing.Point(83, 92);
            this.TB_GroupCode.Name = "TB_GroupCode";
            this.TB_GroupCode.Size = new System.Drawing.Size(100, 22);
            this.TB_GroupCode.TabIndex = 6;
            // 
            // TB_LastName
            // 
            this.TB_LastName.Location = new System.Drawing.Point(83, 64);
            this.TB_LastName.Name = "TB_LastName";
            this.TB_LastName.Size = new System.Drawing.Size(100, 22);
            this.TB_LastName.TabIndex = 5;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(83, 36);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 22);
            this.TB_Name.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DataBase Controll panel";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(52, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Add a member";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 295);
            this.Controls.Add(this.Module);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "7941W Communicator";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Module.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LBStatus;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReconnectBtn;
        private System.Windows.Forms.Button RescanBtn;
        private System.Windows.Forms.ComboBox CB_COMSelect;
        private System.Windows.Forms.ComboBox CB_BaudSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Module;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TB_GroupCode;
        private System.Windows.Forms.TextBox TB_LastName;
        private System.Windows.Forms.TextBox TB_CardNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
    }
}

