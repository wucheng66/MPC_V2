
namespace PID参数整定软件
{
    partial class Mainfrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLbMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTd2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTi2 = new System.Windows.Forms.TextBox();
            this.txtKc2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMV2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSP2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPV2 = new System.Windows.Forms.TextBox();
            this.BtnAuto2 = new System.Windows.Forms.Button();
            this.Qvalue = new System.Windows.Forms.TextBox();
            this.Rvalue = new System.Windows.Forms.TextBox();
            this.Qlabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textTCup = new System.Windows.Forms.TextBox();
            this.textTCdown = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textNC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textNP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTd1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTi1 = new System.Windows.Forms.TextBox();
            this.txtKc1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMV1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSP1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPV1 = new System.Windows.Forms.TextBox();
            this.BtnAuto1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textLCup = new System.Windows.Forms.TextBox();
            this.textLCdown = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.hslRealTime1 = new HslControls.HslCurveHistory();
            this.hslRealTime2 = new HslControls.HslCurveHistory();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMBMV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBPV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.CMBServer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.Leftall = new System.Windows.Forms.Button();
            this.Leftone = new System.Windows.Forms.Button();
            this.Rightone = new System.Windows.Forms.Button();
            this.Rightall = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hslRealTime3 = new HslControls.HslCurveHistory();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1727, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1727, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLbMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1005);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1727, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLbMessage
            // 
            this.StatusLbMessage.Name = "StatusLbMessage";
            this.StatusLbMessage.Size = new System.Drawing.Size(167, 20);
            this.StatusLbMessage.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1727, 945);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1719, 912);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PID参数整定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.89359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.62074F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.48567F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 907F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 907F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 907F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 907F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1713, 906);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.02242F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.97758F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtTd2, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtTi2, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtKc2, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtMV2, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtSP2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPV2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnAuto2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.Qvalue, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.Rvalue, 1, 10);
            this.tableLayoutPanel4.Controls.Add(this.Qlabel, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 11);
            this.tableLayoutPanel4.Controls.Add(this.textTCup, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.textTCdown, 1, 12);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(275, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 14;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.9F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(261, 900);
            this.tableLayoutPanel4.TabIndex = 9;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 51);
            this.label10.TabIndex = 18;
            this.label10.Text = "微分时间（Td秒）";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTd2
            // 
            this.txtTd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTd2.Location = new System.Drawing.Point(172, 309);
            this.txtTd2.Name = "txtTd2";
            this.txtTd2.Size = new System.Drawing.Size(86, 29);
            this.txtTd2.TabIndex = 17;
            this.txtTd2.TextChanged += new System.EventHandler(this.txtTd2_TextChanged);
            this.txtTd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 51);
            this.label11.TabIndex = 16;
            this.label11.Text = "积分时间（Ti秒）";
            // 
            // txtTi2
            // 
            this.txtTi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTi2.Location = new System.Drawing.Point(172, 258);
            this.txtTi2.Name = "txtTi2";
            this.txtTi2.Size = new System.Drawing.Size(86, 29);
            this.txtTi2.TabIndex = 15;
            this.txtTi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtKc2
            // 
            this.txtKc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKc2.Location = new System.Drawing.Point(172, 207);
            this.txtKc2.Name = "txtKc2";
            this.txtKc2.Size = new System.Drawing.Size(86, 29);
            this.txtKc2.TabIndex = 14;
            this.txtKc2.TextChanged += new System.EventHandler(this.txtKc2_TextChanged);
            this.txtKc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 51);
            this.label12.TabIndex = 12;
            this.label12.Text = " 比例系数（Kc）";
            // 
            // txtMV2
            // 
            this.txtMV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMV2.Location = new System.Drawing.Point(172, 105);
            this.txtMV2.Name = "txtMV2";
            this.txtMV2.Size = new System.Drawing.Size(86, 29);
            this.txtMV2.TabIndex = 9;
            this.txtMV2.TextChanged += new System.EventHandler(this.txtMV2_TextChanged);
            this.txtMV2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 51);
            this.label13.TabIndex = 8;
            this.label13.Text = "操作值（MV）：";
            // 
            // txtSP2
            // 
            this.txtSP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSP2.Location = new System.Drawing.Point(172, 54);
            this.txtSP2.Name = "txtSP2";
            this.txtSP2.Size = new System.Drawing.Size(86, 29);
            this.txtSP2.TabIndex = 7;
            this.txtSP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 51);
            this.label14.TabIndex = 6;
            this.label14.Text = "设定值（SV）：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 51);
            this.label15.TabIndex = 1;
            this.label15.Text = "测量值（PV）：";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtPV2
            // 
            this.txtPV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPV2.Location = new System.Drawing.Point(172, 3);
            this.txtPV2.Name = "txtPV2";
            this.txtPV2.Size = new System.Drawing.Size(86, 29);
            this.txtPV2.TabIndex = 5;
            // 
            // BtnAuto2
            // 
            this.BtnAuto2.Location = new System.Drawing.Point(3, 156);
            this.BtnAuto2.Name = "BtnAuto2";
            this.BtnAuto2.Size = new System.Drawing.Size(97, 42);
            this.BtnAuto2.TabIndex = 10;
            this.BtnAuto2.Text = "手动";
            this.BtnAuto2.UseVisualStyleBackColor = true;
            this.BtnAuto2.Click += new System.EventHandler(this.BtnAuto2_Click);
            // 
            // Qvalue
            // 
            this.Qvalue.Enabled = false;
            this.Qvalue.Location = new System.Drawing.Point(172, 470);
            this.Qvalue.Margin = new System.Windows.Forms.Padding(3, 11, 3, 0);
            this.Qvalue.Name = "Qvalue";
            this.Qvalue.Size = new System.Drawing.Size(86, 29);
            this.Qvalue.TabIndex = 19;
            this.Qvalue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Qvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qvalue_KeyPress);
            // 
            // Rvalue
            // 
            this.Rvalue.Enabled = false;
            this.Rvalue.Location = new System.Drawing.Point(172, 521);
            this.Rvalue.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.Rvalue.Name = "Rvalue";
            this.Rvalue.Size = new System.Drawing.Size(86, 29);
            this.Rvalue.TabIndex = 20;
            this.Rvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rvalue_KeyPress);
            // 
            // Qlabel
            // 
            this.Qlabel.AutoSize = true;
            this.Qlabel.Location = new System.Drawing.Point(75, 476);
            this.Qlabel.Margin = new System.Windows.Forms.Padding(75, 17, 3, 13);
            this.Qlabel.Name = "Qlabel";
            this.Qlabel.Size = new System.Drawing.Size(19, 20);
            this.Qlabel.TabIndex = 21;
            this.Qlabel.Text = "Q";
            this.Qlabel.Click += new System.EventHandler(this.Qlabel_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(75, 527);
            this.label19.Margin = new System.Windows.Forms.Padding(75, 17, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 20);
            this.label19.TabIndex = 22;
            this.label19.Text = "R";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 578);
            this.label18.Margin = new System.Windows.Forms.Padding(40, 17, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "TC上下限";
            // 
            // textTCup
            // 
            this.textTCup.Location = new System.Drawing.Point(172, 572);
            this.textTCup.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.textTCup.Name = "textTCup";
            this.textTCup.Size = new System.Drawing.Size(86, 29);
            this.textTCup.TabIndex = 24;
            this.textTCup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTCup_KeyPress);
            // 
            // textTCdown
            // 
            this.textTCdown.Location = new System.Drawing.Point(172, 623);
            this.textTCdown.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.textTCdown.Name = "textTCdown";
            this.textTCdown.Size = new System.Drawing.Size(86, 29);
            this.textTCdown.TabIndex = 25;
            this.textTCdown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTCdown_KeyPress);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.99559F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.00441F));
            this.tableLayoutPanel5.Controls.Add(this.textNC, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.textNP, 1, 9);
            this.tableLayoutPanel5.Controls.Add(this.label16, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.txtTd1, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtTi1, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtKc1, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.txtMV1, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtSP1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtPV1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnAuto1, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.button1, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.button3, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.label20, 0, 11);
            this.tableLayoutPanel5.Controls.Add(this.textLCup, 1, 11);
            this.tableLayoutPanel5.Controls.Add(this.textLCdown, 1, 12);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 14;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.9F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(266, 900);
            this.tableLayoutPanel5.TabIndex = 7;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // textNC
            // 
            this.textNC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNC.Enabled = false;
            this.textNC.Location = new System.Drawing.Point(170, 521);
            this.textNC.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.textNC.Name = "textNC";
            this.textNC.Size = new System.Drawing.Size(93, 29);
            this.textNC.TabIndex = 24;
            this.textNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNC_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 527);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 17, 3, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 21);
            this.label17.TabIndex = 23;
            this.label17.Text = "控制区间Nc";
            // 
            // textNP
            // 
            this.textNP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNP.Enabled = false;
            this.textNP.Location = new System.Drawing.Point(170, 476);
            this.textNP.Margin = new System.Windows.Forms.Padding(3, 17, 3, 0);
            this.textNP.Name = "textNP";
            this.textNP.Size = new System.Drawing.Size(93, 29);
            this.textNP.TabIndex = 22;
            this.textNP.TextChanged += new System.EventHandler(this.textNP_TextChanged);
            this.textNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNP_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 476);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 17, 3, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 21);
            this.label16.TabIndex = 21;
            this.label16.Text = "预测区间Np";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 51);
            this.label9.TabIndex = 18;
            this.label9.Text = "微分时间（Td秒）";
            // 
            // txtTd1
            // 
            this.txtTd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTd1.Location = new System.Drawing.Point(170, 309);
            this.txtTd1.Name = "txtTd1";
            this.txtTd1.Size = new System.Drawing.Size(93, 29);
            this.txtTd1.TabIndex = 17;
            this.txtTd1.TextChanged += new System.EventHandler(this.txtTd1_TextChanged);
            this.txtTd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTd1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 51);
            this.label1.TabIndex = 16;
            this.label1.Text = "积分时间（Ti秒）";
            // 
            // txtTi1
            // 
            this.txtTi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTi1.Location = new System.Drawing.Point(170, 258);
            this.txtTi1.Name = "txtTi1";
            this.txtTi1.Size = new System.Drawing.Size(93, 29);
            this.txtTi1.TabIndex = 15;
            this.txtTi1.TextChanged += new System.EventHandler(this.txtTi1_TextChanged);
            this.txtTi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTi1_KeyPress);
            // 
            // txtKc1
            // 
            this.txtKc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKc1.Location = new System.Drawing.Point(170, 207);
            this.txtKc1.Name = "txtKc1";
            this.txtKc1.Size = new System.Drawing.Size(93, 29);
            this.txtKc1.TabIndex = 14;
            this.txtKc1.TextChanged += new System.EventHandler(this.txtKc1_TextChanged);
            this.txtKc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKc1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 51);
            this.label2.TabIndex = 12;
            this.label2.Text = " 比例系数（Kc）";
            // 
            // txtMV1
            // 
            this.txtMV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMV1.Location = new System.Drawing.Point(170, 105);
            this.txtMV1.Name = "txtMV1";
            this.txtMV1.Size = new System.Drawing.Size(93, 29);
            this.txtMV1.TabIndex = 9;
            this.txtMV1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMV1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 51);
            this.label8.TabIndex = 8;
            this.label8.Text = "操作值（MV）：";
            // 
            // txtSP1
            // 
            this.txtSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSP1.Location = new System.Drawing.Point(170, 54);
            this.txtSP1.Name = "txtSP1";
            this.txtSP1.Size = new System.Drawing.Size(93, 29);
            this.txtSP1.TabIndex = 7;
            this.txtSP1.TextChanged += new System.EventHandler(this.txtSP1_TextChanged);
            this.txtSP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSP1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 51);
            this.label7.TabIndex = 6;
            this.label7.Text = "设定值（SV）：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 51);
            this.label6.TabIndex = 1;
            this.label6.Text = "测量值（PV）：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPV1
            // 
            this.txtPV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPV1.Location = new System.Drawing.Point(170, 3);
            this.txtPV1.Name = "txtPV1";
            this.txtPV1.Size = new System.Drawing.Size(93, 29);
            this.txtPV1.TabIndex = 5;
            this.txtPV1.TextChanged += new System.EventHandler(this.txtPV1_TextChanged);
            // 
            // BtnAuto1
            // 
            this.BtnAuto1.Location = new System.Drawing.Point(3, 156);
            this.BtnAuto1.Name = "BtnAuto1";
            this.BtnAuto1.Size = new System.Drawing.Size(97, 42);
            this.BtnAuto1.TabIndex = 10;
            this.BtnAuto1.Text = "手动";
            this.BtnAuto1.UseVisualStyleBackColor = true;
            this.BtnAuto1.Click += new System.EventHandler(this.BtnAuto1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "自整定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(3, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 42);
            this.button3.TabIndex = 20;
            this.button3.Text = "MPC关闭";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 578);
            this.label20.Margin = new System.Windows.Forms.Padding(40, 17, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "LC上下限";
            // 
            // textLCup
            // 
            this.textLCup.Location = new System.Drawing.Point(170, 572);
            this.textLCup.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.textLCup.Name = "textLCup";
            this.textLCup.Size = new System.Drawing.Size(93, 29);
            this.textLCup.TabIndex = 26;
            this.textLCup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLCup_KeyPress);
            // 
            // textLCdown
            // 
            this.textLCdown.Location = new System.Drawing.Point(170, 623);
            this.textLCdown.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.textLCdown.Name = "textLCdown";
            this.textLCdown.Size = new System.Drawing.Size(93, 29);
            this.textLCdown.TabIndex = 27;
            this.textLCdown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLCdown_KeyPress);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.hslRealTime1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.hslRealTime2, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(542, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.86911F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.13089F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1168, 900);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // hslRealTime1
            // 
            this.hslRealTime1.BackColor = System.Drawing.Color.White;
            this.hslRealTime1.CoordinateColor = System.Drawing.Color.DimGray;
            this.hslRealTime1.CurveRanges = null;
            this.hslRealTime1.DashCoordinateColor = System.Drawing.Color.LightGray;
            this.hslRealTime1.Location = new System.Drawing.Point(3, 3);
            this.hslRealTime1.MarkTextColor = System.Drawing.Color.Yellow;
            this.hslRealTime1.Name = "hslRealTime1";
            this.hslRealTime1.ReferenceAxisLeft.Color = System.Drawing.Color.DimGray;
            this.hslRealTime1.ReferenceAxisLeft.Max = 200F;
            this.hslRealTime1.ReferenceAxisLeft.Unit = null;
            this.hslRealTime1.ReferenceAxisRight.Color = System.Drawing.Color.DimGray;
            this.hslRealTime1.ReferenceAxisRight.Unit = null;
            this.hslRealTime1.Size = new System.Drawing.Size(1162, 442);
            this.hslRealTime1.TabIndex = 12;
            this.hslRealTime1.Text = "hslCurveHistory1";
            this.hslRealTime1.Load += new System.EventHandler(this.hslRealTime1_Load_1);
            // 
            // hslRealTime2
            // 
            this.hslRealTime2.BackColor = System.Drawing.Color.White;
            this.hslRealTime2.CoordinateColor = System.Drawing.Color.DimGray;
            this.hslRealTime2.CurveRanges = null;
            this.hslRealTime2.DashCoordinateColor = System.Drawing.Color.LightGray;
            this.hslRealTime2.Location = new System.Drawing.Point(3, 451);
            this.hslRealTime2.MarkTextColor = System.Drawing.Color.Yellow;
            this.hslRealTime2.MoveLineColor = System.Drawing.Color.IndianRed;
            this.hslRealTime2.Name = "hslRealTime2";
            this.hslRealTime2.ReferenceAxisLeft.Color = System.Drawing.Color.DimGray;
            this.hslRealTime2.ReferenceAxisLeft.Max = 200F;
            this.hslRealTime2.ReferenceAxisLeft.Unit = null;
            this.hslRealTime2.ReferenceAxisRight.Color = System.Drawing.Color.DimGray;
            this.hslRealTime2.ReferenceAxisRight.Unit = null;
            this.hslRealTime2.Size = new System.Drawing.Size(1162, 446);
            this.hslRealTime2.TabIndex = 13;
            this.hslRealTime2.Text = "hslCurveHistory1";
            this.hslRealTime2.Load += new System.EventHandler(this.hslRealTime2_Load_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1719, 912);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "配置界面";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1713, 906);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.38095F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.61905F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1707, 447);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CMBMV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CMBPV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.CMBServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // CMBMV
            // 
            this.CMBMV.FormattingEnabled = true;
            this.CMBMV.Location = new System.Drawing.Point(125, 119);
            this.CMBMV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBMV.Name = "CMBMV";
            this.CMBMV.Size = new System.Drawing.Size(121, 27);
            this.CMBMV.TabIndex = 8;
            this.CMBMV.SelectedIndexChanged += new System.EventHandler(this.CMBMV_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "控制量（MV）：";
            // 
            // CMBPV
            // 
            this.CMBPV.FormattingEnabled = true;
            this.CMBPV.Location = new System.Drawing.Point(125, 70);
            this.CMBPV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBPV.Name = "CMBPV";
            this.CMBPV.Size = new System.Drawing.Size(121, 27);
            this.CMBPV.TabIndex = 6;
            this.CMBPV.SelectedIndexChanged += new System.EventHandler(this.CMBPV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "测量值（PV）：";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(262, 24);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(129, 35);
            this.BtnConnect.TabIndex = 4;
            this.BtnConnect.Text = "连接OPC";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // CMBServer
            // 
            this.CMBServer.FormattingEnabled = true;
            this.CMBServer.Location = new System.Drawing.Point(125, 29);
            this.CMBServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBServer.Name = "CMBServer";
            this.CMBServer.Size = new System.Drawing.Size(121, 27);
            this.CMBServer.TabIndex = 3;
            this.CMBServer.SelectedIndexChanged += new System.EventHandler(this.CMBServer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "OPC服务器名称：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "H1",
            "T1",
            "U1",
            "U2"});
            this.listBox1.Location = new System.Drawing.Point(3, 348);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(60, 80);
            this.listBox1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.Leftall);
            this.tabPage3.Controls.Add(this.Leftone);
            this.tabPage3.Controls.Add(this.Rightone);
            this.tabPage3.Controls.Add(this.Rightall);
            this.tabPage3.Controls.Add(this.listBox4);
            this.tabPage3.Controls.Add(this.listBox3);
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1719, 912);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "历史数据";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(546, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "确定";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Leftall
            // 
            this.Leftall.Location = new System.Drawing.Point(315, 204);
            this.Leftall.Name = "Leftall";
            this.Leftall.Size = new System.Drawing.Size(50, 35);
            this.Leftall.TabIndex = 6;
            this.Leftall.Text = "<<";
            this.Leftall.UseVisualStyleBackColor = true;
            // 
            // Leftone
            // 
            this.Leftone.Location = new System.Drawing.Point(315, 159);
            this.Leftone.Name = "Leftone";
            this.Leftone.Size = new System.Drawing.Size(50, 35);
            this.Leftone.TabIndex = 5;
            this.Leftone.Text = "<";
            this.Leftone.UseVisualStyleBackColor = true;
            this.Leftone.Click += new System.EventHandler(this.Leftone_Click);
            // 
            // Rightone
            // 
            this.Rightone.Location = new System.Drawing.Point(315, 73);
            this.Rightone.Name = "Rightone";
            this.Rightone.Size = new System.Drawing.Size(50, 35);
            this.Rightone.TabIndex = 4;
            this.Rightone.Text = ">";
            this.Rightone.UseVisualStyleBackColor = true;
            this.Rightone.Click += new System.EventHandler(this.Rightone_Click);
            // 
            // Rightall
            // 
            this.Rightall.Location = new System.Drawing.Point(315, 118);
            this.Rightall.Name = "Rightall";
            this.Rightall.Size = new System.Drawing.Size(50, 35);
            this.Rightall.TabIndex = 3;
            this.Rightall.Text = ">>";
            this.Rightall.UseVisualStyleBackColor = true;
            this.Rightall.Click += new System.EventHandler(this.Rightall_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 19;
            this.listBox4.Location = new System.Drawing.Point(398, 159);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 80);
            this.listBox4.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Location = new System.Drawing.Point(398, 73);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 80);
            this.listBox3.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Items.AddRange(new object[] {
            "H",
            "T",
            "U1",
            "U2"});
            this.listBox2.Location = new System.Drawing.Point(197, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(78, 175);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.hslRealTime3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1719, 912);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hslRealTime3
            // 
            this.hslRealTime3.BackColor = System.Drawing.Color.White;
            this.hslRealTime3.CoordinateColor = System.Drawing.Color.Black;
            this.hslRealTime3.CurveRanges = null;
            this.hslRealTime3.DashCoordinateColor = System.Drawing.Color.LightGray;
            this.hslRealTime3.Location = new System.Drawing.Point(223, 6);
            this.hslRealTime3.MarkTextColor = System.Drawing.Color.Yellow;
            this.hslRealTime3.Name = "hslRealTime3";
            this.hslRealTime3.ReferenceAxisLeft.Color = System.Drawing.Color.Black;
            this.hslRealTime3.ReferenceAxisLeft.Max = 200F;
            this.hslRealTime3.ReferenceAxisLeft.Min = 50F;
            this.hslRealTime3.ReferenceAxisLeft.Unit = null;
            this.hslRealTime3.ReferenceAxisRight.Max = 200F;
            this.hslRealTime3.ReferenceAxisRight.Min = 50F;
            this.hslRealTime3.ReferenceAxisRight.Unit = null;
            this.hslRealTime3.Size = new System.Drawing.Size(852, 478);
            this.hslRealTime3.TabIndex = 1;
            this.hslRealTime3.Text = "hslCurveHistory1";
            this.hslRealTime3.Load += new System.EventHandler(this.hslRealTime3_Load);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 1031);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainfrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CMBMV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBPV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ComboBox CMBServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel StatusLbMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtMV1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSP1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPV1;
        private System.Windows.Forms.Button BtnAuto1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTi1;
        private System.Windows.Forms.TextBox txtKc1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTd2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTi2;
        private System.Windows.Forms.TextBox txtKc2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMV2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSP2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPV2;
        private System.Windows.Forms.Button BtnAuto2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textNC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textNP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Qvalue;
        private System.Windows.Forms.TextBox Rvalue;
        private System.Windows.Forms.Label Qlabel;
        private System.Windows.Forms.Label label19;
        private HslControls.HslCurveHistory hslRealTime1;
        private HslControls.HslCurveHistory hslRealTime2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textTCup;
        private System.Windows.Forms.TextBox textTCdown;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textLCup;
        private System.Windows.Forms.TextBox textLCdown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Leftall;
        private System.Windows.Forms.Button Leftone;
        private System.Windows.Forms.Button Rightone;
        private System.Windows.Forms.Button Rightall;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private HslControls.HslCurveHistory hslRealTime3;
    }
}

