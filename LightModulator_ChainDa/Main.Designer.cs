
namespace LightModulator_ChainDa
{
    partial class Main
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
            this.Btn_Open = new System.Windows.Forms.Button();
            this.GB_Type = new System.Windows.Forms.GroupBox();
            this.Btn_TypeB = new System.Windows.Forms.Button();
            this.Btn_TypeA = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.TB_Send = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_StopBits = new System.Windows.Forms.ComboBox();
            this.CB_Parity = new System.Windows.Forms.ComboBox();
            this.CB_BaudRate = new System.Windows.Forms.ComboBox();
            this.CB_DataBits = new System.Windows.Forms.ComboBox();
            this.CB_PortName = new System.Windows.Forms.ComboBox();
            this.Label_Connection = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_SelectCh0 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_SetCh3 = new System.Windows.Forms.Button();
            this.Btn_SetCh1 = new System.Windows.Forms.Button();
            this.Btn_SetCh2 = new System.Windows.Forms.Button();
            this.Btn_SetCh0 = new System.Windows.Forms.Button();
            this.NUD_SelectCh3 = new System.Windows.Forms.NumericUpDown();
            this.NUD_SelectCh1 = new System.Windows.Forms.NumericUpDown();
            this.NUD_SelectCh2 = new System.Windows.Forms.NumericUpDown();
            this.NUD_SelectCh0 = new System.Windows.Forms.NumericUpDown();
            this.CB_SelectCh3 = new System.Windows.Forms.ComboBox();
            this.CB_SelectCh1 = new System.Windows.Forms.ComboBox();
            this.CB_SelectCh2 = new System.Windows.Forms.ComboBox();
            this.TB_Received = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Type.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SelectCh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SelectCh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SelectCh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SelectCh0)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(101, 22);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(118, 40);
            this.Btn_Open.TabIndex = 0;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // GB_Type
            // 
            this.GB_Type.Controls.Add(this.Btn_TypeB);
            this.GB_Type.Controls.Add(this.Btn_TypeA);
            this.GB_Type.Location = new System.Drawing.Point(251, 12);
            this.GB_Type.Name = "GB_Type";
            this.GB_Type.Size = new System.Drawing.Size(231, 80);
            this.GB_Type.TabIndex = 1;
            this.GB_Type.TabStop = false;
            this.GB_Type.Text = "Type Select";
            // 
            // Btn_TypeB
            // 
            this.Btn_TypeB.Enabled = false;
            this.Btn_TypeB.Location = new System.Drawing.Point(116, 32);
            this.Btn_TypeB.Name = "Btn_TypeB";
            this.Btn_TypeB.Size = new System.Drawing.Size(100, 30);
            this.Btn_TypeB.TabIndex = 0;
            this.Btn_TypeB.Text = "Type B";
            this.Btn_TypeB.UseVisualStyleBackColor = true;
            // 
            // Btn_TypeA
            // 
            this.Btn_TypeA.Location = new System.Drawing.Point(10, 32);
            this.Btn_TypeA.Name = "Btn_TypeA";
            this.Btn_TypeA.Size = new System.Drawing.Size(100, 30);
            this.Btn_TypeA.TabIndex = 0;
            this.Btn_TypeA.Text = "Type A";
            this.Btn_TypeA.UseVisualStyleBackColor = true;
            this.Btn_TypeA.Click += new System.EventHandler(this.Btn_TypeA_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(101, 68);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(118, 40);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // TB_Send
            // 
            this.TB_Send.Location = new System.Drawing.Point(12, 305);
            this.TB_Send.Multiline = true;
            this.TB_Send.Name = "TB_Send";
            this.TB_Send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Send.Size = new System.Drawing.Size(233, 110);
            this.TB_Send.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CB_StopBits);
            this.groupBox2.Controls.Add(this.CB_Parity);
            this.groupBox2.Controls.Add(this.CB_BaudRate);
            this.groupBox2.Controls.Add(this.CB_DataBits);
            this.groupBox2.Controls.Add(this.CB_PortName);
            this.groupBox2.Controls.Add(this.Label_Connection);
            this.groupBox2.Controls.Add(this.Btn_Close);
            this.groupBox2.Controls.Add(this.Btn_Open);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 272);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stop Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial Port";
            // 
            // CB_StopBits
            // 
            this.CB_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_StopBits.FormattingEnabled = true;
            this.CB_StopBits.Location = new System.Drawing.Point(101, 239);
            this.CB_StopBits.Name = "CB_StopBits";
            this.CB_StopBits.Size = new System.Drawing.Size(118, 23);
            this.CB_StopBits.TabIndex = 2;
            // 
            // CB_Parity
            // 
            this.CB_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Parity.FormattingEnabled = true;
            this.CB_Parity.Location = new System.Drawing.Point(101, 210);
            this.CB_Parity.Name = "CB_Parity";
            this.CB_Parity.Size = new System.Drawing.Size(118, 23);
            this.CB_Parity.TabIndex = 2;
            // 
            // CB_BaudRate
            // 
            this.CB_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_BaudRate.FormattingEnabled = true;
            this.CB_BaudRate.Location = new System.Drawing.Point(101, 152);
            this.CB_BaudRate.Name = "CB_BaudRate";
            this.CB_BaudRate.Size = new System.Drawing.Size(118, 23);
            this.CB_BaudRate.TabIndex = 2;
            // 
            // CB_DataBits
            // 
            this.CB_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_DataBits.FormattingEnabled = true;
            this.CB_DataBits.Location = new System.Drawing.Point(101, 181);
            this.CB_DataBits.Name = "CB_DataBits";
            this.CB_DataBits.Size = new System.Drawing.Size(118, 23);
            this.CB_DataBits.TabIndex = 2;
            // 
            // CB_PortName
            // 
            this.CB_PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PortName.FormattingEnabled = true;
            this.CB_PortName.Location = new System.Drawing.Point(101, 123);
            this.CB_PortName.Name = "CB_PortName";
            this.CB_PortName.Size = new System.Drawing.Size(118, 23);
            this.CB_PortName.TabIndex = 2;
            // 
            // Label_Connection
            // 
            this.Label_Connection.AutoSize = true;
            this.Label_Connection.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Connection.Location = new System.Drawing.Point(6, 32);
            this.Label_Connection.Name = "Label_Connection";
            this.Label_Connection.Size = new System.Drawing.Size(89, 61);
            this.Label_Connection.TabIndex = 1;
            this.Label_Connection.Text = "⚫";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Send";
            // 
            // CB_SelectCh0
            // 
            this.CB_SelectCh0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SelectCh0.FormattingEnabled = true;
            this.CB_SelectCh0.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CB_SelectCh0.Location = new System.Drawing.Point(7, 37);
            this.CB_SelectCh0.Name = "CB_SelectCh0";
            this.CB_SelectCh0.Size = new System.Drawing.Size(44, 23);
            this.CB_SelectCh0.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_SetCh3);
            this.groupBox1.Controls.Add(this.Btn_SetCh1);
            this.groupBox1.Controls.Add(this.Btn_SetCh2);
            this.groupBox1.Controls.Add(this.Btn_SetCh0);
            this.groupBox1.Controls.Add(this.NUD_SelectCh3);
            this.groupBox1.Controls.Add(this.NUD_SelectCh1);
            this.groupBox1.Controls.Add(this.NUD_SelectCh2);
            this.groupBox1.Controls.Add(this.NUD_SelectCh0);
            this.groupBox1.Controls.Add(this.CB_SelectCh3);
            this.groupBox1.Controls.Add(this.CB_SelectCh1);
            this.groupBox1.Controls.Add(this.CB_SelectCh2);
            this.groupBox1.Controls.Add(this.CB_SelectCh0);
            this.groupBox1.Location = new System.Drawing.Point(251, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 186);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Box";
            // 
            // Btn_SetCh3
            // 
            this.Btn_SetCh3.Location = new System.Drawing.Point(161, 123);
            this.Btn_SetCh3.Name = "Btn_SetCh3";
            this.Btn_SetCh3.Size = new System.Drawing.Size(52, 23);
            this.Btn_SetCh3.TabIndex = 6;
            this.Btn_SetCh3.Text = "Set";
            this.Btn_SetCh3.UseVisualStyleBackColor = true;
            this.Btn_SetCh3.Click += new System.EventHandler(this.Btn_SetCh3_Click);
            // 
            // Btn_SetCh1
            // 
            this.Btn_SetCh1.Location = new System.Drawing.Point(161, 65);
            this.Btn_SetCh1.Name = "Btn_SetCh1";
            this.Btn_SetCh1.Size = new System.Drawing.Size(52, 23);
            this.Btn_SetCh1.TabIndex = 6;
            this.Btn_SetCh1.Text = "Set";
            this.Btn_SetCh1.UseVisualStyleBackColor = true;
            this.Btn_SetCh1.Click += new System.EventHandler(this.Btn_SetCh1_Click);
            // 
            // Btn_SetCh2
            // 
            this.Btn_SetCh2.Location = new System.Drawing.Point(161, 94);
            this.Btn_SetCh2.Name = "Btn_SetCh2";
            this.Btn_SetCh2.Size = new System.Drawing.Size(52, 23);
            this.Btn_SetCh2.TabIndex = 6;
            this.Btn_SetCh2.Text = "Set";
            this.Btn_SetCh2.UseVisualStyleBackColor = true;
            this.Btn_SetCh2.Click += new System.EventHandler(this.Btn_SetCh2_Click);
            // 
            // Btn_SetCh0
            // 
            this.Btn_SetCh0.Location = new System.Drawing.Point(161, 36);
            this.Btn_SetCh0.Name = "Btn_SetCh0";
            this.Btn_SetCh0.Size = new System.Drawing.Size(52, 23);
            this.Btn_SetCh0.TabIndex = 6;
            this.Btn_SetCh0.Text = "Set";
            this.Btn_SetCh0.UseVisualStyleBackColor = true;
            this.Btn_SetCh0.Click += new System.EventHandler(this.Btn_SetCh0_Click);
            // 
            // NUD_SelectCh3
            // 
            this.NUD_SelectCh3.Location = new System.Drawing.Point(64, 124);
            this.NUD_SelectCh3.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.NUD_SelectCh3.Name = "NUD_SelectCh3";
            this.NUD_SelectCh3.Size = new System.Drawing.Size(84, 23);
            this.NUD_SelectCh3.TabIndex = 5;
            this.NUD_SelectCh3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NUD_SelectCh1
            // 
            this.NUD_SelectCh1.Location = new System.Drawing.Point(64, 66);
            this.NUD_SelectCh1.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.NUD_SelectCh1.Name = "NUD_SelectCh1";
            this.NUD_SelectCh1.Size = new System.Drawing.Size(84, 23);
            this.NUD_SelectCh1.TabIndex = 5;
            this.NUD_SelectCh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NUD_SelectCh2
            // 
            this.NUD_SelectCh2.Location = new System.Drawing.Point(64, 95);
            this.NUD_SelectCh2.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.NUD_SelectCh2.Name = "NUD_SelectCh2";
            this.NUD_SelectCh2.Size = new System.Drawing.Size(84, 23);
            this.NUD_SelectCh2.TabIndex = 5;
            this.NUD_SelectCh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NUD_SelectCh0
            // 
            this.NUD_SelectCh0.Location = new System.Drawing.Point(64, 37);
            this.NUD_SelectCh0.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.NUD_SelectCh0.Name = "NUD_SelectCh0";
            this.NUD_SelectCh0.Size = new System.Drawing.Size(84, 23);
            this.NUD_SelectCh0.TabIndex = 5;
            this.NUD_SelectCh0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CB_SelectCh3
            // 
            this.CB_SelectCh3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SelectCh3.FormattingEnabled = true;
            this.CB_SelectCh3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CB_SelectCh3.Location = new System.Drawing.Point(7, 124);
            this.CB_SelectCh3.Name = "CB_SelectCh3";
            this.CB_SelectCh3.Size = new System.Drawing.Size(44, 23);
            this.CB_SelectCh3.TabIndex = 4;
            // 
            // CB_SelectCh1
            // 
            this.CB_SelectCh1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SelectCh1.FormattingEnabled = true;
            this.CB_SelectCh1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CB_SelectCh1.Location = new System.Drawing.Point(7, 66);
            this.CB_SelectCh1.Name = "CB_SelectCh1";
            this.CB_SelectCh1.Size = new System.Drawing.Size(44, 23);
            this.CB_SelectCh1.TabIndex = 4;
            // 
            // CB_SelectCh2
            // 
            this.CB_SelectCh2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_SelectCh2.FormattingEnabled = true;
            this.CB_SelectCh2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CB_SelectCh2.Location = new System.Drawing.Point(7, 95);
            this.CB_SelectCh2.Name = "CB_SelectCh2";
            this.CB_SelectCh2.Size = new System.Drawing.Size(44, 23);
            this.CB_SelectCh2.TabIndex = 4;
            // 
            // TB_Received
            // 
            this.TB_Received.Location = new System.Drawing.Point(251, 305);
            this.TB_Received.Multiline = true;
            this.TB_Received.Name = "TB_Received";
            this.TB_Received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Received.Size = new System.Drawing.Size(233, 110);
            this.TB_Received.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Received";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TB_Received);
            this.Controls.Add(this.TB_Send);
            this.Controls.Add(this.GB_Type);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Light Modulator for Chain Da (Power by MIRDC)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.GB_Type.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SelectCh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SelectCh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SelectCh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SelectCh0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.GroupBox GB_Type;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox TB_Send;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label_Connection;
        private System.Windows.Forms.ComboBox CB_Parity;
        private System.Windows.Forms.ComboBox CB_BaudRate;
        private System.Windows.Forms.ComboBox CB_DataBits;
        private System.Windows.Forms.ComboBox CB_PortName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_StopBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_TypeB;
        private System.Windows.Forms.Button Btn_TypeA;
        private System.Windows.Forms.ComboBox CB_SelectCh0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_SelectCh3;
        private System.Windows.Forms.ComboBox CB_SelectCh1;
        private System.Windows.Forms.ComboBox CB_SelectCh2;
        private System.Windows.Forms.Button Btn_SetCh3;
        private System.Windows.Forms.Button Btn_SetCh1;
        private System.Windows.Forms.Button Btn_SetCh2;
        private System.Windows.Forms.Button Btn_SetCh0;
        private System.Windows.Forms.NumericUpDown NUD_SelectCh3;
        private System.Windows.Forms.NumericUpDown NUD_SelectCh1;
        private System.Windows.Forms.NumericUpDown NUD_SelectCh2;
        private System.Windows.Forms.NumericUpDown NUD_SelectCh0;
        private System.Windows.Forms.TextBox TB_Received;
        private System.Windows.Forms.Label label1;
    }
}

