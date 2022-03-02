namespace Arbeidskrav1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelConnect1 = new System.Windows.Forms.Label();
            this.buttonDisconnect1 = new System.Windows.Forms.Button();
            this.buttonSend1 = new System.Windows.Forms.Button();
            this.comboBoxBitRate1 = new System.Windows.Forms.ComboBox();
            this.buttonConnect1 = new System.Windows.Forms.Button();
            this.comboBoxCOM1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSend1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLog1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonUpdate2 = new System.Windows.Forms.Button();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.buttonEdit1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelName1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelConnected2 = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonSendArd1 = new System.Windows.Forms.Button();
            this.buttonRetrieveArd1 = new System.Windows.Forms.Button();
            this.buttonRetrieveParameter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxalarmH = new System.Windows.Forms.TextBox();
            this.textBoxalarmL = new System.Windows.Forms.TextBox();
            this.textBoxurv = new System.Windows.Forms.TextBox();
            this.textBoxlrv = new System.Windows.Forms.TextBox();
            this.buttonSaveParameter = new System.Windows.Forms.Button();
            this.buttonViewFile1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRawOrSca = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelConnected3 = new System.Windows.Forms.Label();
            this.chartLight1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUpdate1 = new System.Windows.Forms.Button();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.buttonClearChart1 = new System.Windows.Forms.Button();
            this.radioButtonScaled1 = new System.Windows.Forms.RadioButton();
            this.textBoxLog2 = new System.Windows.Forms.TextBox();
            this.radioButtonRaw1 = new System.Windows.Forms.RadioButton();
            this.buttonManuelRead1 = new System.Windows.Forms.Button();
            this.buttonAutoRead1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerChart1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerCon = new System.Windows.Forms.Timer(this.components);
            this.comboBoxHz1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLight1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 494);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelConnect1);
            this.panel4.Controls.Add(this.buttonDisconnect1);
            this.panel4.Controls.Add(this.buttonSend1);
            this.panel4.Controls.Add(this.comboBoxBitRate1);
            this.panel4.Controls.Add(this.buttonConnect1);
            this.panel4.Controls.Add(this.comboBoxCOM1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBoxSend1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 418);
            this.panel4.TabIndex = 13;
            // 
            // labelConnect1
            // 
            this.labelConnect1.AutoSize = true;
            this.labelConnect1.Location = new System.Drawing.Point(0, 0);
            this.labelConnect1.Name = "labelConnect1";
            this.labelConnect1.Size = new System.Drawing.Size(73, 13);
            this.labelConnect1.TabIndex = 12;
            this.labelConnect1.Text = "Disconnected";
            // 
            // buttonDisconnect1
            // 
            this.buttonDisconnect1.Location = new System.Drawing.Point(91, 147);
            this.buttonDisconnect1.Name = "buttonDisconnect1";
            this.buttonDisconnect1.Size = new System.Drawing.Size(95, 23);
            this.buttonDisconnect1.TabIndex = 6;
            this.buttonDisconnect1.Text = "Disconnect";
            this.buttonDisconnect1.UseVisualStyleBackColor = true;
            this.buttonDisconnect1.Click += new System.EventHandler(this.buttonDisconnect1_Click);
            // 
            // buttonSend1
            // 
            this.buttonSend1.Location = new System.Drawing.Point(229, 118);
            this.buttonSend1.Name = "buttonSend1";
            this.buttonSend1.Size = new System.Drawing.Size(95, 23);
            this.buttonSend1.TabIndex = 11;
            this.buttonSend1.Tag = "";
            this.buttonSend1.Text = "Send";
            this.buttonSend1.UseVisualStyleBackColor = true;
            this.buttonSend1.Click += new System.EventHandler(this.buttonSend1_Click);
            // 
            // comboBoxBitRate1
            // 
            this.comboBoxBitRate1.FormattingEnabled = true;
            this.comboBoxBitRate1.Location = new System.Drawing.Point(91, 42);
            this.comboBoxBitRate1.Name = "comboBoxBitRate1";
            this.comboBoxBitRate1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBitRate1.TabIndex = 0;
            // 
            // buttonConnect1
            // 
            this.buttonConnect1.Location = new System.Drawing.Point(91, 118);
            this.buttonConnect1.Name = "buttonConnect1";
            this.buttonConnect1.Size = new System.Drawing.Size(95, 23);
            this.buttonConnect1.TabIndex = 7;
            this.buttonConnect1.Text = "Connect";
            this.buttonConnect1.UseVisualStyleBackColor = true;
            this.buttonConnect1.Click += new System.EventHandler(this.buttonConnect1_Click);
            // 
            // comboBoxCOM1
            // 
            this.comboBoxCOM1.FormattingEnabled = true;
            this.comboBoxCOM1.Location = new System.Drawing.Point(91, 69);
            this.comboBoxCOM1.Name = "comboBoxCOM1";
            this.comboBoxCOM1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOM1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bit Rate";
            // 
            // textBoxSend1
            // 
            this.textBoxSend1.Location = new System.Drawing.Point(229, 72);
            this.textBoxSend1.Name = "textBoxSend1";
            this.textBoxSend1.Size = new System.Drawing.Size(121, 20);
            this.textBoxSend1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxLog1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(504, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 462);
            this.panel3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log";
            // 
            // textBoxLog1
            // 
            this.textBoxLog1.Location = new System.Drawing.Point(21, 42);
            this.textBoxLog1.Multiline = true;
            this.textBoxLog1.Name = "textBoxLog1";
            this.textBoxLog1.ReadOnly = true;
            this.textBoxLog1.Size = new System.Drawing.Size(352, 339);
            this.textBoxLog1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonUpdate2);
            this.tabPage2.Controls.Add(this.buttonDelete1);
            this.tabPage2.Controls.Add(this.buttonEdit1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.labelName1);
            this.tabPage2.Controls.Add(this.textBoxName);
            this.tabPage2.Controls.Add(this.labelConnected2);
            this.tabPage2.Controls.Add(this.buttonSaveFile);
            this.tabPage2.Controls.Add(this.buttonSendArd1);
            this.tabPage2.Controls.Add(this.buttonRetrieveArd1);
            this.tabPage2.Controls.Add(this.buttonRetrieveParameter);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxalarmH);
            this.tabPage2.Controls.Add(this.textBoxalarmL);
            this.tabPage2.Controls.Add(this.textBoxurv);
            this.tabPage2.Controls.Add(this.textBoxlrv);
            this.tabPage2.Controls.Add(this.buttonSaveParameter);
            this.tabPage2.Controls.Add(this.buttonViewFile1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration change";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate2
            // 
            this.buttonUpdate2.Location = new System.Drawing.Point(492, 416);
            this.buttonUpdate2.Name = "buttonUpdate2";
            this.buttonUpdate2.Size = new System.Drawing.Size(104, 39);
            this.buttonUpdate2.TabIndex = 29;
            this.buttonUpdate2.Text = "Update";
            this.buttonUpdate2.UseVisualStyleBackColor = true;
            this.buttonUpdate2.Click += new System.EventHandler(this.buttonUpdate2_Click);
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Location = new System.Drawing.Point(602, 416);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(104, 39);
            this.buttonDelete1.TabIndex = 28;
            this.buttonDelete1.Text = "Delete row";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(712, 416);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(104, 39);
            this.buttonEdit1.TabIndex = 26;
            this.buttonEdit1.Text = "Edit row";
            this.buttonEdit1.UseVisualStyleBackColor = true;
            this.buttonEdit1.Click += new System.EventHandler(this.buttonEdit1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 404);
            this.dataGridView1.TabIndex = 23;
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(53, 29);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(26, 13);
            this.labelName1.TabIndex = 21;
            this.labelName1.Text = "Tag";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // labelConnected2
            // 
            this.labelConnected2.AutoSize = true;
            this.labelConnected2.Location = new System.Drawing.Point(3, 3);
            this.labelConnected2.Name = "labelConnected2";
            this.labelConnected2.Size = new System.Drawing.Size(73, 13);
            this.labelConnected2.TabIndex = 17;
            this.labelConnected2.Text = "Disconnected";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(58, 367);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(101, 23);
            this.buttonSaveFile.TabIndex = 14;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonSendArd1
            // 
            this.buttonSendArd1.Location = new System.Drawing.Point(58, 188);
            this.buttonSendArd1.Name = "buttonSendArd1";
            this.buttonSendArd1.Size = new System.Drawing.Size(170, 23);
            this.buttonSendArd1.TabIndex = 13;
            this.buttonSendArd1.Text = "Save to Arduino";
            this.buttonSendArd1.UseVisualStyleBackColor = true;
            this.buttonSendArd1.Click += new System.EventHandler(this.buttonSendArd1_Click);
            // 
            // buttonRetrieveArd1
            // 
            this.buttonRetrieveArd1.Location = new System.Drawing.Point(58, 217);
            this.buttonRetrieveArd1.Name = "buttonRetrieveArd1";
            this.buttonRetrieveArd1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRetrieveArd1.Size = new System.Drawing.Size(170, 23);
            this.buttonRetrieveArd1.TabIndex = 12;
            this.buttonRetrieveArd1.Text = "Retrieve from arduino";
            this.buttonRetrieveArd1.UseVisualStyleBackColor = true;
            this.buttonRetrieveArd1.Click += new System.EventHandler(this.buttonRetrieveArd1_Click);
            // 
            // buttonRetrieveParameter
            // 
            this.buttonRetrieveParameter.Location = new System.Drawing.Point(58, 246);
            this.buttonRetrieveParameter.Name = "buttonRetrieveParameter";
            this.buttonRetrieveParameter.Size = new System.Drawing.Size(170, 23);
            this.buttonRetrieveParameter.TabIndex = 11;
            this.buttonRetrieveParameter.Text = "Retrieve from database";
            this.buttonRetrieveParameter.UseVisualStyleBackColor = true;
            this.buttonRetrieveParameter.Click += new System.EventHandler(this.buttonRetrieveParameter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "alarmH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "alarmL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "urv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "lrv";
            // 
            // textBoxalarmH
            // 
            this.textBoxalarmH.Location = new System.Drawing.Point(128, 133);
            this.textBoxalarmH.Name = "textBoxalarmH";
            this.textBoxalarmH.Size = new System.Drawing.Size(100, 20);
            this.textBoxalarmH.TabIndex = 5;
            // 
            // textBoxalarmL
            // 
            this.textBoxalarmL.Location = new System.Drawing.Point(128, 107);
            this.textBoxalarmL.Name = "textBoxalarmL";
            this.textBoxalarmL.Size = new System.Drawing.Size(100, 20);
            this.textBoxalarmL.TabIndex = 4;
            // 
            // textBoxurv
            // 
            this.textBoxurv.Location = new System.Drawing.Point(128, 81);
            this.textBoxurv.Name = "textBoxurv";
            this.textBoxurv.Size = new System.Drawing.Size(100, 20);
            this.textBoxurv.TabIndex = 3;
            // 
            // textBoxlrv
            // 
            this.textBoxlrv.Location = new System.Drawing.Point(128, 55);
            this.textBoxlrv.Name = "textBoxlrv";
            this.textBoxlrv.Size = new System.Drawing.Size(100, 20);
            this.textBoxlrv.TabIndex = 2;
            // 
            // buttonSaveParameter
            // 
            this.buttonSaveParameter.Location = new System.Drawing.Point(382, 416);
            this.buttonSaveParameter.Name = "buttonSaveParameter";
            this.buttonSaveParameter.Size = new System.Drawing.Size(104, 39);
            this.buttonSaveParameter.TabIndex = 1;
            this.buttonSaveParameter.Text = "Add row";
            this.buttonSaveParameter.UseVisualStyleBackColor = true;
            this.buttonSaveParameter.Click += new System.EventHandler(this.buttonSaveParameter_Click);
            // 
            // buttonViewFile1
            // 
            this.buttonViewFile1.Location = new System.Drawing.Point(58, 396);
            this.buttonViewFile1.Name = "buttonViewFile1";
            this.buttonViewFile1.Size = new System.Drawing.Size(101, 23);
            this.buttonViewFile1.TabIndex = 0;
            this.buttonViewFile1.Text = "View File";
            this.buttonViewFile1.UseVisualStyleBackColor = true;
            this.buttonViewFile1.Click += new System.EventHandler(this.buttonViewFile1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(914, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Monitor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRawOrSca);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.labelConnected3);
            this.panel1.Controls.Add(this.chartLight1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 462);
            this.panel1.TabIndex = 4;
            // 
            // labelRawOrSca
            // 
            this.labelRawOrSca.AutoSize = true;
            this.labelRawOrSca.Location = new System.Drawing.Point(0, 17);
            this.labelRawOrSca.Name = "labelRawOrSca";
            this.labelRawOrSca.Size = new System.Drawing.Size(30, 13);
            this.labelRawOrSca.TabIndex = 1;
            this.labelRawOrSca.Text = "Light";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 444);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(765, 18);
            this.panel5.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seconds";
            // 
            // labelConnected3
            // 
            this.labelConnected3.AutoSize = true;
            this.labelConnected3.Location = new System.Drawing.Point(0, 0);
            this.labelConnected3.Name = "labelConnected3";
            this.labelConnected3.Size = new System.Drawing.Size(73, 13);
            this.labelConnected3.TabIndex = 4;
            this.labelConnected3.Text = "Disconnected";
            // 
            // chartLight1
            // 
            chartArea3.Name = "ChartArea1";
            this.chartLight1.ChartAreas.Add(chartArea3);
            this.chartLight1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartLight1.Legends.Add(legend3);
            this.chartLight1.Location = new System.Drawing.Point(0, 0);
            this.chartLight1.Name = "chartLight1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "LightChart";
            series3.XValueMember = "5";
            this.chartLight1.Series.Add(series3);
            this.chartLight1.Size = new System.Drawing.Size(765, 462);
            this.chartLight1.TabIndex = 0;
            this.chartLight1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBoxHz1);
            this.panel2.Controls.Add(this.buttonUpdate1);
            this.panel2.Controls.Add(this.labelStatus1);
            this.panel2.Controls.Add(this.Status);
            this.panel2.Controls.Add(this.buttonClearChart1);
            this.panel2.Controls.Add(this.radioButtonScaled1);
            this.panel2.Controls.Add(this.textBoxLog2);
            this.panel2.Controls.Add(this.radioButtonRaw1);
            this.panel2.Controls.Add(this.buttonManuelRead1);
            this.panel2.Controls.Add(this.buttonAutoRead1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(768, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 462);
            this.panel2.TabIndex = 5;
            // 
            // buttonUpdate1
            // 
            this.buttonUpdate1.Location = new System.Drawing.Point(31, 403);
            this.buttonUpdate1.Name = "buttonUpdate1";
            this.buttonUpdate1.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate1.TabIndex = 9;
            this.buttonUpdate1.Text = "Update status";
            this.buttonUpdate1.UseVisualStyleBackColor = true;
            this.buttonUpdate1.Click += new System.EventHandler(this.buttonUpdateStatus1_Click);
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Location = new System.Drawing.Point(69, 387);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(14, 13);
            this.labelStatus1.TabIndex = 8;
            this.labelStatus1.Tag = "";
            this.labelStatus1.Text = "S";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(32, 387);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(40, 13);
            this.Status.TabIndex = 7;
            this.Status.Tag = "";
            this.Status.Text = "Status:";
            // 
            // buttonClearChart1
            // 
            this.buttonClearChart1.Location = new System.Drawing.Point(31, 349);
            this.buttonClearChart1.Name = "buttonClearChart1";
            this.buttonClearChart1.Size = new System.Drawing.Size(75, 23);
            this.buttonClearChart1.TabIndex = 6;
            this.buttonClearChart1.Text = "Clear chart";
            this.buttonClearChart1.UseVisualStyleBackColor = true;
            this.buttonClearChart1.Click += new System.EventHandler(this.buttonClearChart1_Click);
            // 
            // radioButtonScaled1
            // 
            this.radioButtonScaled1.AutoSize = true;
            this.radioButtonScaled1.Location = new System.Drawing.Point(49, 269);
            this.radioButtonScaled1.Name = "radioButtonScaled1";
            this.radioButtonScaled1.Size = new System.Drawing.Size(85, 17);
            this.radioButtonScaled1.TabIndex = 5;
            this.radioButtonScaled1.TabStop = true;
            this.radioButtonScaled1.Text = "Read scaled";
            this.radioButtonScaled1.UseVisualStyleBackColor = true;
            this.radioButtonScaled1.CheckedChanged += new System.EventHandler(this.radioButtonScaled1_CheckedChanged);
            // 
            // textBoxLog2
            // 
            this.textBoxLog2.Location = new System.Drawing.Point(11, 14);
            this.textBoxLog2.Multiline = true;
            this.textBoxLog2.Name = "textBoxLog2";
            this.textBoxLog2.ReadOnly = true;
            this.textBoxLog2.Size = new System.Drawing.Size(109, 193);
            this.textBoxLog2.TabIndex = 1;
            // 
            // radioButtonRaw1
            // 
            this.radioButtonRaw1.AutoSize = true;
            this.radioButtonRaw1.Location = new System.Drawing.Point(48, 246);
            this.radioButtonRaw1.Name = "radioButtonRaw1";
            this.radioButtonRaw1.Size = new System.Drawing.Size(71, 17);
            this.radioButtonRaw1.TabIndex = 4;
            this.radioButtonRaw1.TabStop = true;
            this.radioButtonRaw1.Text = "Read raw";
            this.radioButtonRaw1.UseVisualStyleBackColor = true;
            this.radioButtonRaw1.CheckedChanged += new System.EventHandler(this.radioButtonRaw1_CheckedChanged);
            // 
            // buttonManuelRead1
            // 
            this.buttonManuelRead1.Location = new System.Drawing.Point(31, 320);
            this.buttonManuelRead1.Name = "buttonManuelRead1";
            this.buttonManuelRead1.Size = new System.Drawing.Size(75, 23);
            this.buttonManuelRead1.TabIndex = 2;
            this.buttonManuelRead1.Text = "Manuel read";
            this.buttonManuelRead1.UseVisualStyleBackColor = true;
            this.buttonManuelRead1.Click += new System.EventHandler(this.buttonManuelRead1_Click);
            // 
            // buttonAutoRead1
            // 
            this.buttonAutoRead1.Location = new System.Drawing.Point(31, 291);
            this.buttonAutoRead1.Name = "buttonAutoRead1";
            this.buttonAutoRead1.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoRead1.TabIndex = 3;
            this.buttonAutoRead1.Text = "Auto read";
            this.buttonAutoRead1.UseVisualStyleBackColor = true;
            this.buttonAutoRead1.Click += new System.EventHandler(this.buttonAutoRead1_Click);
            // 
            // timerChart1
            // 
            this.timerChart1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "conf.ssc";
            this.openFileDialog1.Filter = "ssc Files|*.ssc";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "ssc Files|*.ssc";
            // 
            // timerCon
            // 
            this.timerCon.Tick += new System.EventHandler(this.timerCon_Tick);
            // 
            // comboBoxHz1
            // 
            this.comboBoxHz1.FormattingEnabled = true;
            this.comboBoxHz1.Location = new System.Drawing.Point(52, 222);
            this.comboBoxHz1.Name = "comboBoxHz1";
            this.comboBoxHz1.Size = new System.Drawing.Size(60, 21);
            this.comboBoxHz1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 11;
            this.label8.Tag = "";
            this.label8.Text = "Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 494);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLight1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonConnect1;
        private System.Windows.Forms.Button buttonDisconnect1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCOM1;
        private System.Windows.Forms.ComboBox comboBoxBitRate1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonSend1;
        private System.Windows.Forms.TextBox textBoxSend1;
        private System.Windows.Forms.Button buttonSaveParameter;
        private System.Windows.Forms.Button buttonViewFile1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxLog2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLight1;
        private System.Windows.Forms.TextBox textBoxalarmH;
        private System.Windows.Forms.TextBox textBoxalarmL;
        private System.Windows.Forms.TextBox textBoxurv;
        private System.Windows.Forms.TextBox textBoxlrv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAutoRead1;
        private System.Windows.Forms.Button buttonManuelRead1;
        private System.Windows.Forms.Button buttonRetrieveParameter;
        private System.Windows.Forms.Timer timerChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxLog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonSendArd1;
        private System.Windows.Forms.Button buttonRetrieveArd1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelConnect1;
        private System.Windows.Forms.Label labelConnected2;
        private System.Windows.Forms.Label labelConnected3;
        private System.Windows.Forms.RadioButton radioButtonScaled1;
        private System.Windows.Forms.RadioButton radioButtonRaw1;
        private System.Windows.Forms.Button buttonClearChart1;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelRawOrSca;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerCon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button buttonEdit1;
        private System.Windows.Forms.Label labelStatus1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button buttonUpdate1;
        private System.Windows.Forms.Button buttonUpdate2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxHz1;
    }
}

