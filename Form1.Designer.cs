
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.LBStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_BaudSelect = new System.Windows.Forms.ComboBox();
            this.CB_COMSelect = new System.Windows.Forms.ComboBox();
            this.RescanBtn = new System.Windows.Forms.Button();
            this.ReconnectBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Module.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 23);
            this.progressBar1.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
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
            // CB_COMSelect
            // 
            this.CB_COMSelect.FormattingEnabled = true;
            this.CB_COMSelect.Location = new System.Drawing.Point(73, 21);
            this.CB_COMSelect.Name = "CB_COMSelect";
            this.CB_COMSelect.Size = new System.Drawing.Size(121, 21);
            this.CB_COMSelect.TabIndex = 0;
            this.CB_COMSelect.SelectedIndexChanged += new System.EventHandler(this.CB_COMSelect_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output";
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 28);
            this.maskedTextBox1.Mask = "AA-AA-AA-AA-AA";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(149, 20);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Input";
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
            // Module
            // 
            this.Module.Controls.Add(this.tabPage1);
            this.Module.Location = new System.Drawing.Point(0, -3);
            this.Module.Name = "Module";
            this.Module.SelectedIndex = 0;
            this.Module.Size = new System.Drawing.Size(427, 300);
            this.Module.TabIndex = 17;
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
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Module.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReconnectBtn;
        private System.Windows.Forms.Button RescanBtn;
        private System.Windows.Forms.ComboBox CB_COMSelect;
        private System.Windows.Forms.ComboBox CB_BaudSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LBStatus;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.TabControl Module;
    }
}

