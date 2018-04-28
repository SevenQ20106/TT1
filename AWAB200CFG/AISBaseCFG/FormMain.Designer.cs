namespace AISBaseCFG
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.串口配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网口连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslConnMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslConnStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_DataMonitor = new System.Windows.Forms.Button();
            this.btn_SetCMD = new System.Windows.Forms.Button();
            this.btn_QueryCMD = new System.Windows.Forms.Button();
            this.TabControlALL = new System.Windows.Forms.TabControl();
            this.tPGeneral = new System.Windows.Forms.TabPage();
            this.groupBox_PosSr = new System.Windows.Forms.GroupBox();
            this.radioButton_Ex_In = new System.Windows.Forms.RadioButton();
            this.radioButton_Ex_Sur = new System.Windows.Forms.RadioButton();
            this.radioButton_In_Ex = new System.Windows.Forms.RadioButton();
            this.radioButton_In_Sur = new System.Windows.Forms.RadioButton();
            this.radioButton_Ex = new System.Windows.Forms.RadioButton();
            this.radioButton_In = new System.Windows.Forms.RadioButton();
            this.radioButton_Sur = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ckb_TxB_Powerlevel = new System.Windows.Forms.CheckBox();
            this.ckb_TxA_Powerlevel = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ckb_TxB_Enable = new System.Windows.Forms.CheckBox();
            this.ckb_TxA_Enable = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TxB = new System.Windows.Forms.TextBox();
            this.txt_RxB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TxA = new System.Windows.Forms.TextBox();
            this.txt_RxA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckb_RATDMA = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ADSInterval = new System.Windows.Forms.TextBox();
            this.txt_MMSI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RepeatIndicator = new System.Windows.Forms.TextBox();
            this.txt_BaseNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MsgRetires = new System.Windows.Forms.TextBox();
            this.txt_TalkerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbt_MTP_B = new System.Windows.Forms.RadioButton();
            this.rbt_MTP_A = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxSN = new System.Windows.Forms.ComboBox();
            this.cbxEW = new System.Windows.Forms.ComboBox();
            this.txtLatFen2 = new System.Windows.Forms.TextBox();
            this.txtLatFen1 = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLatDu = new System.Windows.Forms.TextBox();
            this.txtLongFen2 = new System.Windows.Forms.TextBox();
            this.txtLongFen1 = new System.Windows.Forms.TextBox();
            this.txtLongDu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.ckbPosAccuary = new System.Windows.Forms.CheckBox();
            this.tPNet = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.gpNet0 = new System.Windows.Forms.GroupBox();
            this.txtWired_MAC = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.txtWired_Gateway = new AISBaseCFG.IPAddressTextBox();
            this.txtWired_SubNetMask = new AISBaseCFG.IPAddressTextBox();
            this.txtWired_IP = new AISBaseCFG.IPAddressTextBox();
            this.label187 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLocalCFGPort = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.txtLocalDataPort = new System.Windows.Forms.TextBox();
            this.label124 = new System.Windows.Forms.Label();
            this.gpWIFI = new System.Windows.Forms.GroupBox();
            this.label121 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.txtLocalPort_3 = new System.Windows.Forms.TextBox();
            this.txtLocalPort_2 = new System.Windows.Forms.TextBox();
            this.txtLocalPort_1 = new System.Windows.Forms.TextBox();
            this.txtLocalPort_0 = new System.Windows.Forms.TextBox();
            this.txtAddr_IP_3 = new AISBaseCFG.IPAddressTextBox();
            this.txtAddr_IP_2 = new AISBaseCFG.IPAddressTextBox();
            this.txtAddr_IP_1 = new AISBaseCFG.IPAddressTextBox();
            this.txtDesPort_3 = new System.Windows.Forms.TextBox();
            this.label125 = new System.Windows.Forms.Label();
            this.txtDesPort_2 = new System.Windows.Forms.TextBox();
            this.label126 = new System.Windows.Forms.Label();
            this.txtDesPort_1 = new System.Windows.Forms.TextBox();
            this.label127 = new System.Windows.Forms.Label();
            this.txtDesPort_0 = new System.Windows.Forms.TextBox();
            this.label122 = new System.Windows.Forms.Label();
            this.txtAddr_IP_0 = new AISBaseCFG.IPAddressTextBox();
            this.tPTimeSlot = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtChBSlotCounts17 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtChASlotCounts17 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtChBSlotInterval17 = new System.Windows.Forms.ComboBox();
            this.txtChASlotInterval17 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtChBStartSlot17 = new System.Windows.Forms.TextBox();
            this.txtChBStartTime17 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.txtChAStartSlot17 = new System.Windows.Forms.TextBox();
            this.txtChAStartTime17 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtChASlotInterval20 = new System.Windows.Forms.ComboBox();
            this.txtChBSlotInterval20 = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtChBStartSlot20 = new System.Windows.Forms.TextBox();
            this.txtChBStartTime20 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtChAStartSlot20 = new System.Windows.Forms.TextBox();
            this.txtChAStartTime20 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtChASlotInterval23 = new System.Windows.Forms.ComboBox();
            this.txtChBSlotInterval23 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtChBStartSlot23 = new System.Windows.Forms.TextBox();
            this.txtChBStartTime23 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtChAStartSlot23 = new System.Windows.Forms.TextBox();
            this.txtChAStartTime23 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtChASlotInterval22 = new System.Windows.Forms.ComboBox();
            this.txtChBSlotInterval22 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtChBStartSlot22 = new System.Windows.Forms.TextBox();
            this.txtChBStartTime22 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtChAStartSlot22 = new System.Windows.Forms.TextBox();
            this.txtChAStartTime22 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtChBSlotInterval4 = new System.Windows.Forms.ComboBox();
            this.txtChASlotInterval4 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtChBStartSlot4 = new System.Windows.Forms.TextBox();
            this.txtChBStartTime4 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtChAStartSlot4 = new System.Windows.Forms.TextBox();
            this.txtChAStartTime4 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tPDLM = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.cbx_Incerment_ChB4 = new System.Windows.Forms.ComboBox();
            this.txt_TimeOut_ChB4 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.cbx_Owner_ChB4 = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.txt_SlotCounts_ChB4 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.txt_StartSlot_ChB4 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.cbx_Incerment_ChB3 = new System.Windows.Forms.ComboBox();
            this.txt_TimeOut_ChB3 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.cbx_Owner_ChB3 = new System.Windows.Forms.ComboBox();
            this.label77 = new System.Windows.Forms.Label();
            this.txt_SlotCounts_ChB3 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.txt_StartSlot_ChB3 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.cbx_Incerment_ChB2 = new System.Windows.Forms.ComboBox();
            this.txt_TimeOut_ChB2 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.cbx_Owner_ChB2 = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.txt_SlotCounts_ChB2 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.txt_StartSlot_ChB2 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.cbx_Incerment_ChB1 = new System.Windows.Forms.ComboBox();
            this.txt_TimeOut_ChB1 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.cbx_Owner_ChB1 = new System.Windows.Forms.ComboBox();
            this.label87 = new System.Windows.Forms.Label();
            this.txt_SlotCounts_ChB1 = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.txt_StartSlot_ChB1 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.cbxDLMIndex = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cbx_Incerment_ChA4 = new System.Windows.Forms.ComboBox();
            this.txt_TimeOut_ChA4 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.cbx_Owner_ChA4 = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.txt_SlotCounts_ChA4 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.txt_StartSlot_ChA4 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.cbx_Incerment_ChA3 = new System.Windows.Forms.ComboBox();
            this.txt_TimeOut_ChA3 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.cbx_Owner_ChA3 = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.txt_SlotCounts_ChA3 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.txt_StartSlot_ChA3 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.cbx_Incerment_ChA2 = new System.Windows.Forms.ComboBox();
            this.txt_TimeOut_ChA2 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.cbx_Owner_ChA2 = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.txt_SlotCounts_ChA2 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.txt_StartSlot_ChA2 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.cbx_Incerment_ChA1 = new System.Windows.Forms.ComboBox();
            this.txt_TimeOut_ChA1 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.cbx_Owner_ChA1 = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txt_SlotCounts_ChA1 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.txt_StartSlot_ChA1 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.tPGroupAssignment = new System.Windows.Forms.TabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.ckb_SNR = new System.Windows.Forms.CheckBox();
            this.ckb_TimeOfMsgArrival = new System.Windows.Forms.CheckBox();
            this.ckb_FisrtSlotNumForFirstRecvMsg = new System.Windows.Forms.CheckBox();
            this.ckb_SingalStrength = new System.Windows.Forms.CheckBox();
            this.ckb_VSI4VDO = new System.Windows.Forms.CheckBox();
            this.ckb_VSI4VDM = new System.Windows.Forms.CheckBox();
            this.cbx_SPO_Channel = new System.Windows.Forms.ComboBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.ckb_RecvSingalStrength = new System.Windows.Forms.CheckBox();
            this.ckb_AverageNoiseLevel = new System.Windows.Forms.CheckBox();
            this.ckb_ForecastCHLoad = new System.Windows.Forms.CheckBox();
            this.ckb_NumOfBadCRC = new System.Windows.Forms.CheckBox();
            this.ckb_PreFrameCHLoad = new System.Windows.Forms.CheckBox();
            this.ckb_ProFSRSens = new System.Windows.Forms.CheckBox();
            this.tPVtoN = new System.Windows.Forms.TabPage();
            this.btn_AtoN_1 = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.pAtoN = new System.Windows.Forms.Panel();
            this.label132 = new System.Windows.Forms.Label();
            this.txt_ATN_StartSlotChA = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.txtSizeD = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.txtSizeC = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.txtSizeB = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.txtSizeA = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckb_ATN_NS = new System.Windows.Forms.ComboBox();
            this.ckb_ATN_EW = new System.Windows.Forms.ComboBox();
            this.txt_ATN_LatSecond = new System.Windows.Forms.TextBox();
            this.txt_ATN_LatFen = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.txt_ATN_LatDu = new System.Windows.Forms.TextBox();
            this.txt_ATN_LongSeconds = new System.Windows.Forms.TextBox();
            this.label109 = new System.Windows.Forms.Label();
            this.txt_ATN_LongFen = new System.Windows.Forms.TextBox();
            this.txt_ATN_LongDu = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.ckb_ATN_SingedMode = new System.Windows.Forms.CheckBox();
            this.ckb_ATN_RAIM_Flag = new System.Windows.Forms.CheckBox();
            this.ckb_ATN_OffPos = new System.Windows.Forms.CheckBox();
            this.ckb_ATN_PosAccuray = new System.Windows.Forms.CheckBox();
            this.ckb_AtoN_VirtualATN = new System.Windows.Forms.CheckBox();
            this.txt_ATN_UpdateTime = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.txt_AtoN_TimeStamp = new System.Windows.Forms.TextBox();
            this.txt_AtoN_SendIntervalChA = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.cbx_AtoN_PosDeviceType = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.txt_AtoN_Name = new System.Windows.Forms.TextBox();
            this.cbxAtoNType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_AtoN_MMSI = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.ckb_AtoN_Enable = new System.Windows.Forms.CheckBox();
            this.btn_AtoN_32 = new System.Windows.Forms.Button();
            this.btn_AtoN_31 = new System.Windows.Forms.Button();
            this.btn_AtoN_30 = new System.Windows.Forms.Button();
            this.btn_AtoN_29 = new System.Windows.Forms.Button();
            this.btn_AtoN_28 = new System.Windows.Forms.Button();
            this.btn_AtoN_27 = new System.Windows.Forms.Button();
            this.btn_AtoN_26 = new System.Windows.Forms.Button();
            this.btn_AtoN_25 = new System.Windows.Forms.Button();
            this.btn_AtoN_24 = new System.Windows.Forms.Button();
            this.btn_AtoN_23 = new System.Windows.Forms.Button();
            this.btn_AtoN_22 = new System.Windows.Forms.Button();
            this.btn_AtoN_21 = new System.Windows.Forms.Button();
            this.btn_AtoN_20 = new System.Windows.Forms.Button();
            this.btn_AtoN_19 = new System.Windows.Forms.Button();
            this.btn_AtoN_18 = new System.Windows.Forms.Button();
            this.btn_AtoN_17 = new System.Windows.Forms.Button();
            this.btn_AtoN_16 = new System.Windows.Forms.Button();
            this.btn_AtoN_15 = new System.Windows.Forms.Button();
            this.btn_AtoN_14 = new System.Windows.Forms.Button();
            this.btn_AtoN_13 = new System.Windows.Forms.Button();
            this.btn_AtoN_12 = new System.Windows.Forms.Button();
            this.btn_AtoN_11 = new System.Windows.Forms.Button();
            this.btn_AtoN_10 = new System.Windows.Forms.Button();
            this.btn_AtoN_9 = new System.Windows.Forms.Button();
            this.btn_AtoN_8 = new System.Windows.Forms.Button();
            this.btn_AtoN_7 = new System.Windows.Forms.Button();
            this.btn_AtoN_6 = new System.Windows.Forms.Button();
            this.btn_AtoN_5 = new System.Windows.Forms.Button();
            this.btn_AtoN_4 = new System.Windows.Forms.Button();
            this.btn_AtoN_3 = new System.Windows.Forms.Button();
            this.btn_AtoN_2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabControlALL.SuspendLayout();
            this.tPGeneral.SuspendLayout();
            this.groupBox_PosSr.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tPNet.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gpNet0.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpWIFI.SuspendLayout();
            this.tPTimeSlot.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tPDLM.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tPGroupAssignment.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tPVtoN.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.pAtoN.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox18.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接方式ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 连接方式ToolStripMenuItem
            // 
            this.连接方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口配置ToolStripMenuItem,
            this.网口连接ToolStripMenuItem});
            this.连接方式ToolStripMenuItem.Name = "连接方式ToolStripMenuItem";
            this.连接方式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.连接方式ToolStripMenuItem.Text = "连接方式";
            // 
            // 串口配置ToolStripMenuItem
            // 
            this.串口配置ToolStripMenuItem.Name = "串口配置ToolStripMenuItem";
            this.串口配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.串口配置ToolStripMenuItem.Text = "串口连接";
            this.串口配置ToolStripMenuItem.Click += new System.EventHandler(this.串口配置ToolStripMenuItem_Click);
            // 
            // 网口连接ToolStripMenuItem
            // 
            this.网口连接ToolStripMenuItem.Name = "网口连接ToolStripMenuItem";
            this.网口连接ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.网口连接ToolStripMenuItem.Text = "网口连接";
            this.网口连接ToolStripMenuItem.Click += new System.EventHandler(this.网口连接ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslConnMode,
            this.tsslConnStatus,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "工作模式：";
            // 
            // tsslConnMode
            // 
            this.tsslConnMode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsslConnMode.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslConnMode.Name = "tsslConnMode";
            this.tsslConnMode.Size = new System.Drawing.Size(4, 17);
            // 
            // tsslConnStatus
            // 
            this.tsslConnStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsslConnStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslConnStatus.Name = "tsslConnStatus";
            this.tsslConnStatus.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(713, 17);
            this.toolStripStatusLabel4.Spring = true;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 17);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_DataMonitor);
            this.tabPage1.Controls.Add(this.btn_SetCMD);
            this.tabPage1.Controls.Add(this.btn_QueryCMD);
            this.tabPage1.Controls.Add(this.TabControlALL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_DataMonitor
            // 
            this.btn_DataMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DataMonitor.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DataMonitor.Location = new System.Drawing.Point(674, 62);
            this.btn_DataMonitor.Name = "btn_DataMonitor";
            this.btn_DataMonitor.Size = new System.Drawing.Size(109, 37);
            this.btn_DataMonitor.TabIndex = 3;
            this.btn_DataMonitor.Text = "数据监视";
            this.btn_DataMonitor.UseVisualStyleBackColor = true;
            this.btn_DataMonitor.Click += new System.EventHandler(this.btn_DataMonitor_Click);
            // 
            // btn_SetCMD
            // 
            this.btn_SetCMD.Enabled = false;
            this.btn_SetCMD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SetCMD.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetCMD.Location = new System.Drawing.Point(674, 197);
            this.btn_SetCMD.Name = "btn_SetCMD";
            this.btn_SetCMD.Size = new System.Drawing.Size(109, 37);
            this.btn_SetCMD.TabIndex = 2;
            this.btn_SetCMD.Text = "设置参数";
            this.btn_SetCMD.UseVisualStyleBackColor = true;
            this.btn_SetCMD.Click += new System.EventHandler(this.btn_SetCMD_Click);
            // 
            // btn_QueryCMD
            // 
            this.btn_QueryCMD.Enabled = false;
            this.btn_QueryCMD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QueryCMD.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_QueryCMD.Location = new System.Drawing.Point(674, 130);
            this.btn_QueryCMD.Name = "btn_QueryCMD";
            this.btn_QueryCMD.Size = new System.Drawing.Size(109, 36);
            this.btn_QueryCMD.TabIndex = 1;
            this.btn_QueryCMD.Text = "查询参数";
            this.btn_QueryCMD.UseVisualStyleBackColor = true;
            this.btn_QueryCMD.Click += new System.EventHandler(this.btn_QueryCMD_Click);
            // 
            // TabControlALL
            // 
            this.TabControlALL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlALL.Controls.Add(this.tPGeneral);
            this.TabControlALL.Controls.Add(this.tPNet);
            this.TabControlALL.Controls.Add(this.tPTimeSlot);
            this.TabControlALL.Controls.Add(this.tPDLM);
            this.TabControlALL.Controls.Add(this.tPGroupAssignment);
            this.TabControlALL.Controls.Add(this.tPVtoN);
            this.TabControlALL.Location = new System.Drawing.Point(2, 3);
            this.TabControlALL.Multiline = true;
            this.TabControlALL.Name = "TabControlALL";
            this.TabControlALL.Padding = new System.Drawing.Point(20, 5);
            this.TabControlALL.SelectedIndex = 0;
            this.TabControlALL.Size = new System.Drawing.Size(661, 481);
            this.TabControlALL.TabIndex = 0;
            // 
            // tPGeneral
            // 
            this.tPGeneral.Controls.Add(this.groupBox_PosSr);
            this.tPGeneral.Controls.Add(this.groupBox5);
            this.tPGeneral.Controls.Add(this.groupBox4);
            this.tPGeneral.Controls.Add(this.groupBox3);
            this.tPGeneral.Controls.Add(this.groupBox1);
            this.tPGeneral.Location = new System.Drawing.Point(4, 26);
            this.tPGeneral.Name = "tPGeneral";
            this.tPGeneral.Size = new System.Drawing.Size(653, 451);
            this.tPGeneral.TabIndex = 0;
            this.tPGeneral.Text = "基本配置";
            this.tPGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox_PosSr
            // 
            this.groupBox_PosSr.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_PosSr.Controls.Add(this.radioButton_Ex_In);
            this.groupBox_PosSr.Controls.Add(this.radioButton_Ex_Sur);
            this.groupBox_PosSr.Controls.Add(this.radioButton_In_Ex);
            this.groupBox_PosSr.Controls.Add(this.radioButton_In_Sur);
            this.groupBox_PosSr.Controls.Add(this.radioButton_Ex);
            this.groupBox_PosSr.Controls.Add(this.radioButton_In);
            this.groupBox_PosSr.Controls.Add(this.radioButton_Sur);
            this.groupBox_PosSr.Location = new System.Drawing.Point(261, 7);
            this.groupBox_PosSr.Name = "groupBox_PosSr";
            this.groupBox_PosSr.Size = new System.Drawing.Size(282, 232);
            this.groupBox_PosSr.TabIndex = 25;
            this.groupBox_PosSr.TabStop = false;
            this.groupBox_PosSr.Text = "定位源";
            this.groupBox_PosSr.UseCompatibleTextRendering = true;
            // 
            // radioButton_Ex_In
            // 
            this.radioButton_Ex_In.AutoSize = true;
            this.radioButton_Ex_In.Location = new System.Drawing.Point(15, 201);
            this.radioButton_Ex_In.Name = "radioButton_Ex_In";
            this.radioButton_Ex_In.Size = new System.Drawing.Size(208, 20);
            this.radioButton_Ex_In.TabIndex = 31;
            this.radioButton_Ex_In.Text = "使用外部EPFS备用内部位置信息源";
            this.radioButton_Ex_In.UseCompatibleTextRendering = true;
            this.radioButton_Ex_In.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ex_Sur
            // 
            this.radioButton_Ex_Sur.AutoSize = true;
            this.radioButton_Ex_Sur.Location = new System.Drawing.Point(15, 171);
            this.radioButton_Ex_Sur.Name = "radioButton_Ex_Sur";
            this.radioButton_Ex_Sur.Size = new System.Drawing.Size(171, 20);
            this.radioButton_Ex_Sur.TabIndex = 30;
            this.radioButton_Ex_Sur.Text = "使用外部EPFS备用勘测位置";
            this.radioButton_Ex_Sur.UseCompatibleTextRendering = true;
            this.radioButton_Ex_Sur.UseVisualStyleBackColor = true;
            // 
            // radioButton_In_Ex
            // 
            this.radioButton_In_Ex.AutoSize = true;
            this.radioButton_In_Ex.Location = new System.Drawing.Point(15, 141);
            this.radioButton_In_Ex.Name = "radioButton_In_Ex";
            this.radioButton_In_Ex.Size = new System.Drawing.Size(171, 20);
            this.radioButton_In_Ex.TabIndex = 29;
            this.radioButton_In_Ex.Text = "使用内部EPFS备用外部EPFS";
            this.radioButton_In_Ex.UseCompatibleTextRendering = true;
            this.radioButton_In_Ex.UseVisualStyleBackColor = true;
            // 
            // radioButton_In_Sur
            // 
            this.radioButton_In_Sur.AutoSize = true;
            this.radioButton_In_Sur.Location = new System.Drawing.Point(15, 111);
            this.radioButton_In_Sur.Name = "radioButton_In_Sur";
            this.radioButton_In_Sur.Size = new System.Drawing.Size(171, 20);
            this.radioButton_In_Sur.TabIndex = 28;
            this.radioButton_In_Sur.Text = "使用内部EPFS备用勘测位置";
            this.radioButton_In_Sur.UseCompatibleTextRendering = true;
            this.radioButton_In_Sur.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ex
            // 
            this.radioButton_Ex.AutoSize = true;
            this.radioButton_Ex.Location = new System.Drawing.Point(15, 81);
            this.radioButton_Ex.Name = "radioButton_Ex";
            this.radioButton_Ex.Size = new System.Drawing.Size(72, 20);
            this.radioButton_Ex.TabIndex = 27;
            this.radioButton_Ex.Text = "外部EPFS";
            this.radioButton_Ex.UseCompatibleTextRendering = true;
            this.radioButton_Ex.UseVisualStyleBackColor = true;
            // 
            // radioButton_In
            // 
            this.radioButton_In.AutoSize = true;
            this.radioButton_In.Location = new System.Drawing.Point(15, 51);
            this.radioButton_In.Name = "radioButton_In";
            this.radioButton_In.Size = new System.Drawing.Size(72, 20);
            this.radioButton_In.TabIndex = 26;
            this.radioButton_In.Text = "内部EPFS";
            this.radioButton_In.UseCompatibleTextRendering = true;
            this.radioButton_In.UseVisualStyleBackColor = true;
            // 
            // radioButton_Sur
            // 
            this.radioButton_Sur.AutoSize = true;
            this.radioButton_Sur.Checked = true;
            this.radioButton_Sur.Location = new System.Drawing.Point(15, 21);
            this.radioButton_Sur.Name = "radioButton_Sur";
            this.radioButton_Sur.Size = new System.Drawing.Size(47, 20);
            this.radioButton_Sur.TabIndex = 25;
            this.radioButton_Sur.TabStop = true;
            this.radioButton_Sur.Text = "勘测";
            this.radioButton_Sur.UseCompatibleTextRendering = true;
            this.radioButton_Sur.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ckb_TxB_Powerlevel);
            this.groupBox5.Controls.Add(this.ckb_TxA_Powerlevel);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.ckb_TxB_Enable);
            this.groupBox5.Controls.Add(this.ckb_TxA_Enable);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txt_TxB);
            this.groupBox5.Controls.Add(this.txt_RxB);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_TxA);
            this.groupBox5.Controls.Add(this.txt_RxA);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(6, 245);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 167);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "无线通道";
            // 
            // ckb_TxB_Powerlevel
            // 
            this.ckb_TxB_Powerlevel.AutoSize = true;
            this.ckb_TxB_Powerlevel.Location = new System.Drawing.Point(180, 126);
            this.ckb_TxB_Powerlevel.Name = "ckb_TxB_Powerlevel";
            this.ckb_TxB_Powerlevel.Size = new System.Drawing.Size(15, 14);
            this.ckb_TxB_Powerlevel.TabIndex = 25;
            this.ckb_TxB_Powerlevel.UseVisualStyleBackColor = true;
            // 
            // ckb_TxA_Powerlevel
            // 
            this.ckb_TxA_Powerlevel.AutoSize = true;
            this.ckb_TxA_Powerlevel.Location = new System.Drawing.Point(106, 126);
            this.ckb_TxA_Powerlevel.Name = "ckb_TxA_Powerlevel";
            this.ckb_TxA_Powerlevel.Size = new System.Drawing.Size(15, 14);
            this.ckb_TxA_Powerlevel.TabIndex = 24;
            this.ckb_TxA_Powerlevel.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "高功率使能：";
            // 
            // ckb_TxB_Enable
            // 
            this.ckb_TxB_Enable.AutoSize = true;
            this.ckb_TxB_Enable.Location = new System.Drawing.Point(180, 102);
            this.ckb_TxB_Enable.Name = "ckb_TxB_Enable";
            this.ckb_TxB_Enable.Size = new System.Drawing.Size(15, 14);
            this.ckb_TxB_Enable.TabIndex = 22;
            this.ckb_TxB_Enable.UseVisualStyleBackColor = true;
            // 
            // ckb_TxA_Enable
            // 
            this.ckb_TxA_Enable.AutoSize = true;
            this.ckb_TxA_Enable.Location = new System.Drawing.Point(106, 102);
            this.ckb_TxA_Enable.Name = "ckb_TxA_Enable";
            this.ckb_TxA_Enable.Size = new System.Drawing.Size(15, 14);
            this.ckb_TxA_Enable.TabIndex = 21;
            this.ckb_TxA_Enable.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tx 使能：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "B 通道";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "A 通道";
            // 
            // txt_TxB
            // 
            this.txt_TxB.Location = new System.Drawing.Point(161, 70);
            this.txt_TxB.MaxLength = 4;
            this.txt_TxB.Name = "txt_TxB";
            this.txt_TxB.Size = new System.Drawing.Size(52, 21);
            this.txt_TxB.TabIndex = 17;
            this.txt_TxB.Text = "2088";
            this.txt_TxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txt_RxB
            // 
            this.txt_RxB.Location = new System.Drawing.Point(161, 44);
            this.txt_RxB.MaxLength = 4;
            this.txt_RxB.Name = "txt_RxB";
            this.txt_RxB.Size = new System.Drawing.Size(52, 21);
            this.txt_RxB.TabIndex = 16;
            this.txt_RxB.Text = "2088";
            this.txt_RxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rx 通道：";
            // 
            // txt_TxA
            // 
            this.txt_TxA.Location = new System.Drawing.Point(87, 70);
            this.txt_TxA.MaxLength = 4;
            this.txt_TxA.Name = "txt_TxA";
            this.txt_TxA.Size = new System.Drawing.Size(53, 21);
            this.txt_TxA.TabIndex = 15;
            this.txt_TxA.Text = "2087";
            this.txt_TxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txt_RxA
            // 
            this.txt_RxA.Location = new System.Drawing.Point(87, 44);
            this.txt_RxA.MaxLength = 4;
            this.txt_RxA.Name = "txt_RxA";
            this.txt_RxA.Size = new System.Drawing.Size(53, 21);
            this.txt_RxA.TabIndex = 13;
            this.txt_RxA.Text = "2087";
            this.txt_RxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tx 通道：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckb_RATDMA);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_ADSInterval);
            this.groupBox4.Controls.Add(this.txt_MMSI);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_RepeatIndicator);
            this.groupBox4.Controls.Add(this.txt_BaseNum);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_MsgRetires);
            this.groupBox4.Controls.Add(this.txt_TalkerID);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 233);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "基本参数";
            // 
            // ckb_RATDMA
            // 
            this.ckb_RATDMA.AutoSize = true;
            this.ckb_RATDMA.Location = new System.Drawing.Point(30, 202);
            this.ckb_RATDMA.Name = "ckb_RATDMA";
            this.ckb_RATDMA.Size = new System.Drawing.Size(102, 16);
            this.ckb_RATDMA.TabIndex = 16;
            this.ckb_RATDMA.Text = "  允许 RATDMA";
            this.ckb_RATDMA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "MMSI：";
            // 
            // txt_ADSInterval
            // 
            this.txt_ADSInterval.Location = new System.Drawing.Point(106, 162);
            this.txt_ADSInterval.MaxLength = 3;
            this.txt_ADSInterval.Name = "txt_ADSInterval";
            this.txt_ADSInterval.Size = new System.Drawing.Size(51, 21);
            this.txt_ADSInterval.TabIndex = 15;
            this.txt_ADSInterval.Text = "60";
            // 
            // txt_MMSI
            // 
            this.txt_MMSI.Location = new System.Drawing.Point(106, 27);
            this.txt_MMSI.MaxLength = 9;
            this.txt_MMSI.Name = "txt_MMSI";
            this.txt_MMSI.Size = new System.Drawing.Size(100, 21);
            this.txt_MMSI.TabIndex = 5;
            this.txt_MMSI.TextChanged += new System.EventHandler(this.txt_MMSI_TextChanged);
            this.txt_MMSI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "ADS间隔：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "基站编号：";
            // 
            // txt_RepeatIndicator
            // 
            this.txt_RepeatIndicator.Location = new System.Drawing.Point(106, 135);
            this.txt_RepeatIndicator.MaxLength = 2;
            this.txt_RepeatIndicator.Name = "txt_RepeatIndicator";
            this.txt_RepeatIndicator.Size = new System.Drawing.Size(32, 21);
            this.txt_RepeatIndicator.TabIndex = 13;
            this.txt_RepeatIndicator.Text = "0";
            // 
            // txt_BaseNum
            // 
            this.txt_BaseNum.Location = new System.Drawing.Point(106, 54);
            this.txt_BaseNum.MaxLength = 15;
            this.txt_BaseNum.Name = "txt_BaseNum";
            this.txt_BaseNum.Size = new System.Drawing.Size(100, 21);
            this.txt_BaseNum.TabIndex = 7;
            this.txt_BaseNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMChar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "转发指示：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "数据源编号：";
            // 
            // txt_MsgRetires
            // 
            this.txt_MsgRetires.Location = new System.Drawing.Point(106, 106);
            this.txt_MsgRetires.MaxLength = 3;
            this.txt_MsgRetires.Name = "txt_MsgRetires";
            this.txt_MsgRetires.Size = new System.Drawing.Size(32, 21);
            this.txt_MsgRetires.TabIndex = 11;
            this.txt_MsgRetires.Text = "3";
            // 
            // txt_TalkerID
            // 
            this.txt_TalkerID.Location = new System.Drawing.Point(106, 80);
            this.txt_TalkerID.MaxLength = 2;
            this.txt_TalkerID.Name = "txt_TalkerID";
            this.txt_TalkerID.Size = new System.Drawing.Size(32, 21);
            this.txt_TalkerID.TabIndex = 9;
            this.txt_TalkerID.Text = "AB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "消息重复数：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbt_MTP_B);
            this.groupBox3.Controls.Add(this.rbt_MTP_A);
            this.groupBox3.Location = new System.Drawing.Point(261, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 46);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "A/B机切换";
            // 
            // rbt_MTP_B
            // 
            this.rbt_MTP_B.AutoSize = true;
            this.rbt_MTP_B.Location = new System.Drawing.Point(141, 20);
            this.rbt_MTP_B.Name = "rbt_MTP_B";
            this.rbt_MTP_B.Size = new System.Drawing.Size(41, 16);
            this.rbt_MTP_B.TabIndex = 1;
            this.rbt_MTP_B.TabStop = true;
            this.rbt_MTP_B.Text = "B机";
            this.rbt_MTP_B.UseVisualStyleBackColor = true;
            // 
            // rbt_MTP_A
            // 
            this.rbt_MTP_A.AutoSize = true;
            this.rbt_MTP_A.Location = new System.Drawing.Point(46, 20);
            this.rbt_MTP_A.Name = "rbt_MTP_A";
            this.rbt_MTP_A.Size = new System.Drawing.Size(41, 16);
            this.rbt_MTP_A.TabIndex = 0;
            this.rbt_MTP_A.TabStop = true;
            this.rbt_MTP_A.Text = "A机";
            this.rbt_MTP_A.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.ckbPosAccuary);
            this.groupBox1.Location = new System.Drawing.Point(261, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "定位信息";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxSN);
            this.panel2.Controls.Add(this.cbxEW);
            this.panel2.Controls.Add(this.txtLatFen2);
            this.panel2.Controls.Add(this.txtLatFen1);
            this.panel2.Controls.Add(this.label94);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtLatDu);
            this.panel2.Controls.Add(this.txtLongFen2);
            this.panel2.Controls.Add(this.txtLongFen1);
            this.panel2.Controls.Add(this.txtLongDu);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label93);
            this.panel2.Controls.Add(this.label91);
            this.panel2.Controls.Add(this.label92);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label95);
            this.panel2.Location = new System.Drawing.Point(15, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 69);
            this.panel2.TabIndex = 30;
            // 
            // cbxSN
            // 
            this.cbxSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSN.FormattingEnabled = true;
            this.cbxSN.Items.AddRange(new object[] {
            "N",
            "S"});
            this.cbxSN.Location = new System.Drawing.Point(179, 39);
            this.cbxSN.Name = "cbxSN";
            this.cbxSN.Size = new System.Drawing.Size(39, 20);
            this.cbxSN.TabIndex = 48;
            // 
            // cbxEW
            // 
            this.cbxEW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEW.FormattingEnabled = true;
            this.cbxEW.Items.AddRange(new object[] {
            "E",
            "W"});
            this.cbxEW.Location = new System.Drawing.Point(179, 11);
            this.cbxEW.Name = "cbxEW";
            this.cbxEW.Size = new System.Drawing.Size(39, 20);
            this.cbxEW.TabIndex = 47;
            // 
            // txtLatFen2
            // 
            this.txtLatFen2.Location = new System.Drawing.Point(132, 38);
            this.txtLatFen2.MaxLength = 4;
            this.txtLatFen2.Name = "txtLatFen2";
            this.txtLatFen2.Size = new System.Drawing.Size(36, 21);
            this.txtLatFen2.TabIndex = 44;
            this.txtLatFen2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txtLatFen1
            // 
            this.txtLatFen1.Location = new System.Drawing.Point(102, 37);
            this.txtLatFen1.MaxLength = 2;
            this.txtLatFen1.Name = "txtLatFen1";
            this.txtLatFen1.Size = new System.Drawing.Size(20, 21);
            this.txtLatFen1.TabIndex = 43;
            this.txtLatFen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLatFen1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(169, 38);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(17, 12);
            this.label94.TabIndex = 46;
            this.label94.Text = "＇";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 42;
            this.label16.Text = "纬 度：";
            // 
            // txtLatDu
            // 
            this.txtLatDu.Location = new System.Drawing.Point(60, 36);
            this.txtLatDu.MaxLength = 2;
            this.txtLatDu.Name = "txtLatDu";
            this.txtLatDu.Size = new System.Drawing.Size(28, 21);
            this.txtLatDu.TabIndex = 41;
            this.txtLatDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLatDu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txtLongFen2
            // 
            this.txtLongFen2.Location = new System.Drawing.Point(132, 11);
            this.txtLongFen2.MaxLength = 4;
            this.txtLongFen2.Name = "txtLongFen2";
            this.txtLongFen2.Size = new System.Drawing.Size(36, 21);
            this.txtLongFen2.TabIndex = 39;
            this.txtLongFen2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txtLongFen1
            // 
            this.txtLongFen1.Location = new System.Drawing.Point(102, 12);
            this.txtLongFen1.MaxLength = 2;
            this.txtLongFen1.Name = "txtLongFen1";
            this.txtLongFen1.Size = new System.Drawing.Size(20, 21);
            this.txtLongFen1.TabIndex = 38;
            this.txtLongFen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLongFen1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txtLongDu
            // 
            this.txtLongDu.Location = new System.Drawing.Point(60, 11);
            this.txtLongDu.MaxLength = 3;
            this.txtLongDu.Name = "txtLongDu";
            this.txtLongDu.Size = new System.Drawing.Size(28, 21);
            this.txtLongDu.TabIndex = 36;
            this.txtLongDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLongDu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 37;
            this.label17.Text = "经 度：";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(169, 12);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(17, 12);
            this.label93.TabIndex = 49;
            this.label93.Text = "＇";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(85, 36);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(17, 12);
            this.label91.TabIndex = 45;
            this.label91.Text = "";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(85, 11);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(17, 12);
            this.label92.TabIndex = 40;
            this.label92.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(121, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 21);
            this.label15.TabIndex = 50;
            this.label15.Text = ".";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label95.Location = new System.Drawing.Point(121, 35);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(21, 21);
            this.label95.TabIndex = 51;
            this.label95.Text = ".";
            // 
            // ckbPosAccuary
            // 
            this.ckbPosAccuary.AutoSize = true;
            this.ckbPosAccuary.Location = new System.Drawing.Point(15, 94);
            this.ckbPosAccuary.Name = "ckbPosAccuary";
            this.ckbPosAccuary.Size = new System.Drawing.Size(84, 16);
            this.ckbPosAccuary.TabIndex = 28;
            this.ckbPosAccuary.Text = "高精度使能";
            this.ckbPosAccuary.UseVisualStyleBackColor = true;
            // 
            // tPNet
            // 
            this.tPNet.Controls.Add(this.groupBox7);
            this.tPNet.Location = new System.Drawing.Point(4, 26);
            this.tPNet.Name = "tPNet";
            this.tPNet.Size = new System.Drawing.Size(653, 451);
            this.tPNet.TabIndex = 1;
            this.tPNet.Text = "网络";
            this.tPNet.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.gpNet0);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.gpWIFI);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(621, 432);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "基站网络设置";
            this.groupBox7.UseCompatibleTextRendering = true;
            // 
            // gpNet0
            // 
            this.gpNet0.BackColor = System.Drawing.Color.Transparent;
            this.gpNet0.Controls.Add(this.txtWired_MAC);
            this.gpNet0.Controls.Add(this.label119);
            this.gpNet0.Controls.Add(this.txtWired_Gateway);
            this.gpNet0.Controls.Add(this.txtWired_SubNetMask);
            this.gpNet0.Controls.Add(this.txtWired_IP);
            this.gpNet0.Controls.Add(this.label187);
            this.gpNet0.Controls.Add(this.label188);
            this.gpNet0.Controls.Add(this.label189);
            this.gpNet0.Location = new System.Drawing.Point(6, 20);
            this.gpNet0.Name = "gpNet0";
            this.gpNet0.Size = new System.Drawing.Size(220, 148);
            this.gpNet0.TabIndex = 40;
            this.gpNet0.TabStop = false;
            this.gpNet0.Text = "网络参数";
            // 
            // txtWired_MAC
            // 
            this.txtWired_MAC.Font = new System.Drawing.Font("宋体", 9F);
            this.txtWired_MAC.Location = new System.Drawing.Point(80, 117);
            this.txtWired_MAC.MaxLength = 5;
            this.txtWired_MAC.Name = "txtWired_MAC";
            this.txtWired_MAC.Size = new System.Drawing.Size(127, 21);
            this.txtWired_MAC.TabIndex = 25;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("宋体", 9F);
            this.label119.Location = new System.Drawing.Point(15, 120);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(59, 12);
            this.label119.TabIndex = 24;
            this.label119.Text = "MAC地址：";
            // 
            // txtWired_Gateway
            // 
            this.txtWired_Gateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtWired_Gateway.Location = new System.Drawing.Point(80, 86);
            this.txtWired_Gateway.Name = "txtWired_Gateway";
            this.txtWired_Gateway.Size = new System.Drawing.Size(134, 26);
            this.txtWired_Gateway.TabIndex = 11;
            this.txtWired_Gateway.Value = ((System.Net.IPAddress)(resources.GetObject("txtWired_Gateway.Value")));
            // 
            // txtWired_SubNetMask
            // 
            this.txtWired_SubNetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtWired_SubNetMask.Location = new System.Drawing.Point(80, 54);
            this.txtWired_SubNetMask.Name = "txtWired_SubNetMask";
            this.txtWired_SubNetMask.Size = new System.Drawing.Size(134, 26);
            this.txtWired_SubNetMask.TabIndex = 10;
            this.txtWired_SubNetMask.Value = ((System.Net.IPAddress)(resources.GetObject("txtWired_SubNetMask.Value")));
            // 
            // txtWired_IP
            // 
            this.txtWired_IP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtWired_IP.Location = new System.Drawing.Point(80, 22);
            this.txtWired_IP.Name = "txtWired_IP";
            this.txtWired_IP.Size = new System.Drawing.Size(134, 26);
            this.txtWired_IP.TabIndex = 9;
            this.txtWired_IP.Value = ((System.Net.IPAddress)(resources.GetObject("txtWired_IP.Value")));
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Font = new System.Drawing.Font("宋体", 9F);
            this.label187.Location = new System.Drawing.Point(9, 91);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(65, 12);
            this.label187.TabIndex = 8;
            this.label187.Text = "默认网关：";
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Font = new System.Drawing.Font("宋体", 9F);
            this.label188.Location = new System.Drawing.Point(9, 59);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(65, 12);
            this.label188.TabIndex = 7;
            this.label188.Text = "子网掩码：";
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Font = new System.Drawing.Font("宋体", 9F);
            this.label189.Location = new System.Drawing.Point(9, 28);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(53, 12);
            this.label189.TabIndex = 6;
            this.label189.Text = "IP地址：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtLocalCFGPort);
            this.groupBox2.Controls.Add(this.label123);
            this.groupBox2.Controls.Add(this.txtLocalDataPort);
            this.groupBox2.Controls.Add(this.label124);
            this.groupBox2.Location = new System.Drawing.Point(6, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 69);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务端网络参数";
            // 
            // txtLocalCFGPort
            // 
            this.txtLocalCFGPort.Font = new System.Drawing.Font("宋体", 9F);
            this.txtLocalCFGPort.Location = new System.Drawing.Point(98, 41);
            this.txtLocalCFGPort.MaxLength = 5;
            this.txtLocalCFGPort.Name = "txtLocalCFGPort";
            this.txtLocalCFGPort.Size = new System.Drawing.Size(53, 21);
            this.txtLocalCFGPort.TabIndex = 24;
            this.txtLocalCFGPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtLocalCFGPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("宋体", 9F);
            this.label123.Location = new System.Drawing.Point(9, 44);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(89, 12);
            this.label123.TabIndex = 22;
            this.label123.Text = "管理服务端口：";
            // 
            // txtLocalDataPort
            // 
            this.txtLocalDataPort.Font = new System.Drawing.Font("宋体", 9F);
            this.txtLocalDataPort.Location = new System.Drawing.Point(98, 19);
            this.txtLocalDataPort.MaxLength = 5;
            this.txtLocalDataPort.Name = "txtLocalDataPort";
            this.txtLocalDataPort.Size = new System.Drawing.Size(53, 21);
            this.txtLocalDataPort.TabIndex = 23;
            this.txtLocalDataPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtLocalDataPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("宋体", 9F);
            this.label124.Location = new System.Drawing.Point(9, 22);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(89, 12);
            this.label124.TabIndex = 21;
            this.label124.Text = "数据服务端口：";
            // 
            // gpWIFI
            // 
            this.gpWIFI.BackColor = System.Drawing.Color.Transparent;
            this.gpWIFI.Controls.Add(this.label121);
            this.gpWIFI.Controls.Add(this.label120);
            this.gpWIFI.Controls.Add(this.label96);
            this.gpWIFI.Controls.Add(this.txtLocalPort_3);
            this.gpWIFI.Controls.Add(this.txtLocalPort_2);
            this.gpWIFI.Controls.Add(this.txtLocalPort_1);
            this.gpWIFI.Controls.Add(this.txtLocalPort_0);
            this.gpWIFI.Controls.Add(this.txtAddr_IP_3);
            this.gpWIFI.Controls.Add(this.txtAddr_IP_2);
            this.gpWIFI.Controls.Add(this.txtAddr_IP_1);
            this.gpWIFI.Controls.Add(this.txtDesPort_3);
            this.gpWIFI.Controls.Add(this.label125);
            this.gpWIFI.Controls.Add(this.txtDesPort_2);
            this.gpWIFI.Controls.Add(this.label126);
            this.gpWIFI.Controls.Add(this.txtDesPort_1);
            this.gpWIFI.Controls.Add(this.label127);
            this.gpWIFI.Controls.Add(this.txtDesPort_0);
            this.gpWIFI.Controls.Add(this.label122);
            this.gpWIFI.Controls.Add(this.txtAddr_IP_0);
            this.gpWIFI.Location = new System.Drawing.Point(239, 20);
            this.gpWIFI.Name = "gpWIFI";
            this.gpWIFI.Size = new System.Drawing.Size(366, 223);
            this.gpWIFI.TabIndex = 37;
            this.gpWIFI.TabStop = false;
            this.gpWIFI.Text = "TCPl连接服务端—目的地址&&端口";
            this.gpWIFI.UseCompatibleTextRendering = true;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label121.Location = new System.Drawing.Point(306, 22);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(53, 12);
            this.label121.TabIndex = 65;
            this.label121.Text = "本地端口";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label120.Location = new System.Drawing.Point(242, 22);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(53, 12);
            this.label120.TabIndex = 64;
            this.label120.Text = "目标端口";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label96.Location = new System.Drawing.Point(123, 23);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(59, 12);
            this.label96.TabIndex = 63;
            this.label96.Text = "TCP服务IP";
            // 
            // txtLocalPort_3
            // 
            this.txtLocalPort_3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocalPort_3.Location = new System.Drawing.Point(309, 139);
            this.txtLocalPort_3.MaxLength = 5;
            this.txtLocalPort_3.Name = "txtLocalPort_3";
            this.txtLocalPort_3.Size = new System.Drawing.Size(45, 21);
            this.txtLocalPort_3.TabIndex = 62;
            this.txtLocalPort_3.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtLocalPort_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txtLocalPort_2
            // 
            this.txtLocalPort_2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocalPort_2.Location = new System.Drawing.Point(308, 106);
            this.txtLocalPort_2.MaxLength = 5;
            this.txtLocalPort_2.Name = "txtLocalPort_2";
            this.txtLocalPort_2.Size = new System.Drawing.Size(45, 21);
            this.txtLocalPort_2.TabIndex = 61;
            this.txtLocalPort_2.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtLocalPort_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txtLocalPort_1
            // 
            this.txtLocalPort_1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocalPort_1.Location = new System.Drawing.Point(308, 73);
            this.txtLocalPort_1.MaxLength = 5;
            this.txtLocalPort_1.Name = "txtLocalPort_1";
            this.txtLocalPort_1.Size = new System.Drawing.Size(45, 21);
            this.txtLocalPort_1.TabIndex = 60;
            this.txtLocalPort_1.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtLocalPort_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txtLocalPort_0
            // 
            this.txtLocalPort_0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocalPort_0.Location = new System.Drawing.Point(308, 41);
            this.txtLocalPort_0.MaxLength = 5;
            this.txtLocalPort_0.Name = "txtLocalPort_0";
            this.txtLocalPort_0.Size = new System.Drawing.Size(45, 21);
            this.txtLocalPort_0.TabIndex = 59;
            this.txtLocalPort_0.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtLocalPort_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txtAddr_IP_3
            // 
            this.txtAddr_IP_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAddr_IP_3.Location = new System.Drawing.Point(108, 137);
            this.txtAddr_IP_3.Name = "txtAddr_IP_3";
            this.txtAddr_IP_3.Size = new System.Drawing.Size(134, 26);
            this.txtAddr_IP_3.TabIndex = 58;
            this.txtAddr_IP_3.Value = ((System.Net.IPAddress)(resources.GetObject("txtAddr_IP_3.Value")));
            // 
            // txtAddr_IP_2
            // 
            this.txtAddr_IP_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAddr_IP_2.Location = new System.Drawing.Point(108, 105);
            this.txtAddr_IP_2.Name = "txtAddr_IP_2";
            this.txtAddr_IP_2.Size = new System.Drawing.Size(134, 26);
            this.txtAddr_IP_2.TabIndex = 57;
            this.txtAddr_IP_2.Value = ((System.Net.IPAddress)(resources.GetObject("txtAddr_IP_2.Value")));
            // 
            // txtAddr_IP_1
            // 
            this.txtAddr_IP_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAddr_IP_1.Location = new System.Drawing.Point(108, 72);
            this.txtAddr_IP_1.Name = "txtAddr_IP_1";
            this.txtAddr_IP_1.Size = new System.Drawing.Size(134, 26);
            this.txtAddr_IP_1.TabIndex = 56;
            this.txtAddr_IP_1.Value = ((System.Net.IPAddress)(resources.GetObject("txtAddr_IP_1.Value")));
            // 
            // txtDesPort_3
            // 
            this.txtDesPort_3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDesPort_3.Location = new System.Drawing.Point(247, 140);
            this.txtDesPort_3.MaxLength = 5;
            this.txtDesPort_3.Name = "txtDesPort_3";
            this.txtDesPort_3.Size = new System.Drawing.Size(45, 21);
            this.txtDesPort_3.TabIndex = 55;
            this.txtDesPort_3.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtDesPort_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label125.Location = new System.Drawing.Point(10, 144);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(89, 12);
            this.label125.TabIndex = 54;
            this.label125.Text = "目的地址&&端口:";
            // 
            // txtDesPort_2
            // 
            this.txtDesPort_2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDesPort_2.Location = new System.Drawing.Point(246, 107);
            this.txtDesPort_2.MaxLength = 5;
            this.txtDesPort_2.Name = "txtDesPort_2";
            this.txtDesPort_2.Size = new System.Drawing.Size(45, 21);
            this.txtDesPort_2.TabIndex = 52;
            this.txtDesPort_2.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtDesPort_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label126.Location = new System.Drawing.Point(10, 110);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(89, 12);
            this.label126.TabIndex = 51;
            this.label126.Text = "目的地址&&端口:";
            // 
            // txtDesPort_1
            // 
            this.txtDesPort_1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDesPort_1.Location = new System.Drawing.Point(246, 74);
            this.txtDesPort_1.MaxLength = 5;
            this.txtDesPort_1.Name = "txtDesPort_1";
            this.txtDesPort_1.Size = new System.Drawing.Size(45, 21);
            this.txtDesPort_1.TabIndex = 49;
            this.txtDesPort_1.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtDesPort_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label127.Location = new System.Drawing.Point(10, 77);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(89, 12);
            this.label127.TabIndex = 48;
            this.label127.Text = "目的地址&&端口:";
            // 
            // txtDesPort_0
            // 
            this.txtDesPort_0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDesPort_0.Location = new System.Drawing.Point(246, 42);
            this.txtDesPort_0.MaxLength = 5;
            this.txtDesPort_0.Name = "txtDesPort_0";
            this.txtDesPort_0.Size = new System.Drawing.Size(45, 21);
            this.txtDesPort_0.TabIndex = 46;
            this.txtDesPort_0.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            this.txtDesPort_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label122.Location = new System.Drawing.Point(10, 45);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(89, 12);
            this.label122.TabIndex = 45;
            this.label122.Text = "目的地址&&端口:";
            // 
            // txtAddr_IP_0
            // 
            this.txtAddr_IP_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAddr_IP_0.Location = new System.Drawing.Point(108, 41);
            this.txtAddr_IP_0.Name = "txtAddr_IP_0";
            this.txtAddr_IP_0.Size = new System.Drawing.Size(134, 26);
            this.txtAddr_IP_0.TabIndex = 11;
            this.txtAddr_IP_0.Value = ((System.Net.IPAddress)(resources.GetObject("txtAddr_IP_0.Value")));
            // 
            // tPTimeSlot
            // 
            this.tPTimeSlot.Controls.Add(this.groupBox13);
            this.tPTimeSlot.Controls.Add(this.groupBox12);
            this.tPTimeSlot.Controls.Add(this.groupBox11);
            this.tPTimeSlot.Controls.Add(this.groupBox10);
            this.tPTimeSlot.Controls.Add(this.groupBox9);
            this.tPTimeSlot.Location = new System.Drawing.Point(4, 26);
            this.tPTimeSlot.Name = "tPTimeSlot";
            this.tPTimeSlot.Size = new System.Drawing.Size(653, 451);
            this.tPTimeSlot.TabIndex = 2;
            this.tPTimeSlot.Text = "时隙分配";
            this.tPTimeSlot.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Transparent;
            this.groupBox13.Controls.Add(this.txtChBSlotCounts17);
            this.groupBox13.Controls.Add(this.label49);
            this.groupBox13.Controls.Add(this.txtChASlotCounts17);
            this.groupBox13.Controls.Add(this.label48);
            this.groupBox13.Controls.Add(this.txtChBSlotInterval17);
            this.groupBox13.Controls.Add(this.txtChASlotInterval17);
            this.groupBox13.Controls.Add(this.label42);
            this.groupBox13.Controls.Add(this.label43);
            this.groupBox13.Controls.Add(this.txtChBStartSlot17);
            this.groupBox13.Controls.Add(this.txtChBStartTime17);
            this.groupBox13.Controls.Add(this.label44);
            this.groupBox13.Controls.Add(this.label45);
            this.groupBox13.Controls.Add(this.label46);
            this.groupBox13.Controls.Add(this.txtChAStartSlot17);
            this.groupBox13.Controls.Add(this.txtChAStartTime17);
            this.groupBox13.Controls.Add(this.label47);
            this.groupBox13.Location = new System.Drawing.Point(222, 14);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(196, 239);
            this.groupBox13.TabIndex = 45;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "消息17（DGNSS）";
            this.groupBox13.UseCompatibleTextRendering = true;
            // 
            // txtChBSlotCounts17
            // 
            this.txtChBSlotCounts17.Location = new System.Drawing.Point(137, 211);
            this.txtChBSlotCounts17.MaxLength = 1;
            this.txtChBSlotCounts17.Name = "txtChBSlotCounts17";
            this.txtChBSlotCounts17.Size = new System.Drawing.Size(53, 21);
            this.txtChBSlotCounts17.TabIndex = 47;
            this.txtChBSlotCounts17.TextChanged += new System.EventHandler(this.txtChSlotCounts17_TextChanged);
            this.txtChBSlotCounts17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(18, 214);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(95, 12);
            this.label49.TabIndex = 46;
            this.label49.Text = "通道B时隙总数：";
            // 
            // txtChASlotCounts17
            // 
            this.txtChASlotCounts17.Location = new System.Drawing.Point(137, 105);
            this.txtChASlotCounts17.MaxLength = 1;
            this.txtChASlotCounts17.Name = "txtChASlotCounts17";
            this.txtChASlotCounts17.Size = new System.Drawing.Size(53, 21);
            this.txtChASlotCounts17.TabIndex = 45;
            this.txtChASlotCounts17.TextChanged += new System.EventHandler(this.txtChSlotCounts17_TextChanged);
            this.txtChASlotCounts17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(18, 108);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(95, 12);
            this.label48.TabIndex = 44;
            this.label48.Text = "通道A时隙总数：";
            // 
            // txtChBSlotInterval17
            // 
            this.txtChBSlotInterval17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChBSlotInterval17.FormattingEnabled = true;
            this.txtChBSlotInterval17.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChBSlotInterval17.Location = new System.Drawing.Point(137, 185);
            this.txtChBSlotInterval17.Name = "txtChBSlotInterval17";
            this.txtChBSlotInterval17.Size = new System.Drawing.Size(53, 20);
            this.txtChBSlotInterval17.TabIndex = 43;
            // 
            // txtChASlotInterval17
            // 
            this.txtChASlotInterval17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChASlotInterval17.FormattingEnabled = true;
            this.txtChASlotInterval17.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChASlotInterval17.Location = new System.Drawing.Point(137, 80);
            this.txtChASlotInterval17.Name = "txtChASlotInterval17";
            this.txtChASlotInterval17.Size = new System.Drawing.Size(53, 20);
            this.txtChASlotInterval17.TabIndex = 42;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(18, 188);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(95, 12);
            this.label42.TabIndex = 22;
            this.label42.Text = "通道B时隙间隔：";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(18, 135);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(119, 12);
            this.label43.TabIndex = 18;
            this.label43.Text = "通道B开始时隙时间：";
            // 
            // txtChBStartSlot17
            // 
            this.txtChBStartSlot17.Location = new System.Drawing.Point(137, 159);
            this.txtChBStartSlot17.MaxLength = 4;
            this.txtChBStartSlot17.Name = "txtChBStartSlot17";
            this.txtChBStartSlot17.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartSlot17.TabIndex = 21;
            this.txtChBStartSlot17.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txtChBStartSlot17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChBStartTime17
            // 
            this.txtChBStartTime17.Location = new System.Drawing.Point(137, 132);
            this.txtChBStartTime17.MaxLength = 2;
            this.txtChBStartTime17.Name = "txtChBStartTime17";
            this.txtChBStartTime17.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartTime17.TabIndex = 19;
            this.txtChBStartTime17.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChBStartTime17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(18, 162);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(95, 12);
            this.label44.TabIndex = 20;
            this.label44.Text = "通道B开始时隙：";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(18, 83);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(95, 12);
            this.label45.TabIndex = 16;
            this.label45.Text = "通道A时隙间隔：";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(18, 30);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(119, 12);
            this.label46.TabIndex = 12;
            this.label46.Text = "通道A开始时隙时间：";
            // 
            // txtChAStartSlot17
            // 
            this.txtChAStartSlot17.Location = new System.Drawing.Point(137, 54);
            this.txtChAStartSlot17.MaxLength = 4;
            this.txtChAStartSlot17.Name = "txtChAStartSlot17";
            this.txtChAStartSlot17.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartSlot17.TabIndex = 15;
            this.txtChAStartSlot17.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txtChAStartSlot17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChAStartTime17
            // 
            this.txtChAStartTime17.Location = new System.Drawing.Point(137, 27);
            this.txtChAStartTime17.MaxLength = 2;
            this.txtChAStartTime17.Name = "txtChAStartTime17";
            this.txtChAStartTime17.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartTime17.TabIndex = 13;
            this.txtChAStartTime17.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChAStartTime17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(18, 57);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(95, 12);
            this.label47.TabIndex = 14;
            this.label47.Text = "通道A开始时隙：";
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.Transparent;
            this.groupBox12.Controls.Add(this.txtChASlotInterval20);
            this.groupBox12.Controls.Add(this.txtChBSlotInterval20);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.label37);
            this.groupBox12.Controls.Add(this.txtChBStartSlot20);
            this.groupBox12.Controls.Add(this.txtChBStartTime20);
            this.groupBox12.Controls.Add(this.label38);
            this.groupBox12.Controls.Add(this.label39);
            this.groupBox12.Controls.Add(this.label40);
            this.groupBox12.Controls.Add(this.txtChAStartSlot20);
            this.groupBox12.Controls.Add(this.txtChAStartTime20);
            this.groupBox12.Controls.Add(this.label41);
            this.groupBox12.Location = new System.Drawing.Point(428, 14);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(196, 191);
            this.groupBox12.TabIndex = 44;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "消息20（数据链路管理）";
            this.groupBox12.UseCompatibleTextRendering = true;
            // 
            // txtChASlotInterval20
            // 
            this.txtChASlotInterval20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChASlotInterval20.FormattingEnabled = true;
            this.txtChASlotInterval20.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChASlotInterval20.Location = new System.Drawing.Point(137, 80);
            this.txtChASlotInterval20.Name = "txtChASlotInterval20";
            this.txtChASlotInterval20.Size = new System.Drawing.Size(53, 20);
            this.txtChASlotInterval20.TabIndex = 42;
            // 
            // txtChBSlotInterval20
            // 
            this.txtChBSlotInterval20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChBSlotInterval20.FormattingEnabled = true;
            this.txtChBSlotInterval20.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChBSlotInterval20.Location = new System.Drawing.Point(137, 159);
            this.txtChBSlotInterval20.Name = "txtChBSlotInterval20";
            this.txtChBSlotInterval20.Size = new System.Drawing.Size(53, 20);
            this.txtChBSlotInterval20.TabIndex = 41;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(18, 162);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(95, 12);
            this.label36.TabIndex = 22;
            this.label36.Text = "通道B时隙间隔：";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(18, 109);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(119, 12);
            this.label37.TabIndex = 18;
            this.label37.Text = "通道B开始时隙时间：";
            // 
            // txtChBStartSlot20
            // 
            this.txtChBStartSlot20.Location = new System.Drawing.Point(137, 133);
            this.txtChBStartSlot20.MaxLength = 4;
            this.txtChBStartSlot20.Name = "txtChBStartSlot20";
            this.txtChBStartSlot20.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartSlot20.TabIndex = 21;
            this.txtChBStartSlot20.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txtChBStartSlot20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChBStartTime20
            // 
            this.txtChBStartTime20.Location = new System.Drawing.Point(137, 106);
            this.txtChBStartTime20.MaxLength = 2;
            this.txtChBStartTime20.Name = "txtChBStartTime20";
            this.txtChBStartTime20.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartTime20.TabIndex = 19;
            this.txtChBStartTime20.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChBStartTime20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(18, 136);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(95, 12);
            this.label38.TabIndex = 20;
            this.label38.Text = "通道B开始时隙：";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(18, 83);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 12);
            this.label39.TabIndex = 16;
            this.label39.Text = "通道A时隙间隔：";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(18, 30);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(119, 12);
            this.label40.TabIndex = 12;
            this.label40.Text = "通道A开始时隙时间：";
            // 
            // txtChAStartSlot20
            // 
            this.txtChAStartSlot20.Location = new System.Drawing.Point(137, 54);
            this.txtChAStartSlot20.MaxLength = 4;
            this.txtChAStartSlot20.Name = "txtChAStartSlot20";
            this.txtChAStartSlot20.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartSlot20.TabIndex = 15;
            this.txtChAStartSlot20.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txtChAStartSlot20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChAStartTime20
            // 
            this.txtChAStartTime20.Location = new System.Drawing.Point(137, 27);
            this.txtChAStartTime20.MaxLength = 2;
            this.txtChAStartTime20.Name = "txtChAStartTime20";
            this.txtChAStartTime20.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartTime20.TabIndex = 13;
            this.txtChAStartTime20.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChAStartTime20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(18, 57);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(95, 12);
            this.label41.TabIndex = 14;
            this.label41.Text = "通道A开始时隙：";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Transparent;
            this.groupBox11.Controls.Add(this.txtChASlotInterval23);
            this.groupBox11.Controls.Add(this.txtChBSlotInterval23);
            this.groupBox11.Controls.Add(this.label30);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.txtChBStartSlot23);
            this.groupBox11.Controls.Add(this.txtChBStartTime23);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Controls.Add(this.label33);
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.txtChAStartSlot23);
            this.groupBox11.Controls.Add(this.txtChAStartTime23);
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Location = new System.Drawing.Point(428, 211);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(196, 191);
            this.groupBox11.TabIndex = 43;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "消息23（群组指配）";
            this.groupBox11.UseCompatibleTextRendering = true;
            // 
            // txtChASlotInterval23
            // 
            this.txtChASlotInterval23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChASlotInterval23.FormattingEnabled = true;
            this.txtChASlotInterval23.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChASlotInterval23.Location = new System.Drawing.Point(137, 80);
            this.txtChASlotInterval23.Name = "txtChASlotInterval23";
            this.txtChASlotInterval23.Size = new System.Drawing.Size(53, 20);
            this.txtChASlotInterval23.TabIndex = 42;
            // 
            // txtChBSlotInterval23
            // 
            this.txtChBSlotInterval23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChBSlotInterval23.FormattingEnabled = true;
            this.txtChBSlotInterval23.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChBSlotInterval23.Location = new System.Drawing.Point(137, 159);
            this.txtChBSlotInterval23.Name = "txtChBSlotInterval23";
            this.txtChBSlotInterval23.Size = new System.Drawing.Size(53, 20);
            this.txtChBSlotInterval23.TabIndex = 41;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 162);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 12);
            this.label30.TabIndex = 22;
            this.label30.Text = "通道B时隙间隔：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 109);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(119, 12);
            this.label31.TabIndex = 18;
            this.label31.Text = "通道B开始时隙时间：";
            // 
            // txtChBStartSlot23
            // 
            this.txtChBStartSlot23.Location = new System.Drawing.Point(137, 133);
            this.txtChBStartSlot23.MaxLength = 4;
            this.txtChBStartSlot23.Name = "txtChBStartSlot23";
            this.txtChBStartSlot23.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartSlot23.TabIndex = 21;
            this.txtChBStartSlot23.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txtChBStartSlot23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChBStartTime23
            // 
            this.txtChBStartTime23.Location = new System.Drawing.Point(137, 106);
            this.txtChBStartTime23.MaxLength = 2;
            this.txtChBStartTime23.Name = "txtChBStartTime23";
            this.txtChBStartTime23.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartTime23.TabIndex = 19;
            this.txtChBStartTime23.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChBStartTime23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(18, 136);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 12);
            this.label32.TabIndex = 20;
            this.label32.Text = "通道B开始时隙：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 83);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(95, 12);
            this.label33.TabIndex = 16;
            this.label33.Text = "通道A时隙间隔：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(18, 30);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(119, 12);
            this.label34.TabIndex = 12;
            this.label34.Text = "通道A开始时隙时间：";
            // 
            // txtChAStartSlot23
            // 
            this.txtChAStartSlot23.Location = new System.Drawing.Point(137, 54);
            this.txtChAStartSlot23.MaxLength = 4;
            this.txtChAStartSlot23.Name = "txtChAStartSlot23";
            this.txtChAStartSlot23.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartSlot23.TabIndex = 15;
            this.txtChAStartSlot23.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txtChAStartSlot23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChAStartTime23
            // 
            this.txtChAStartTime23.Location = new System.Drawing.Point(137, 27);
            this.txtChAStartTime23.MaxLength = 2;
            this.txtChAStartTime23.Name = "txtChAStartTime23";
            this.txtChAStartTime23.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartTime23.TabIndex = 13;
            this.txtChAStartTime23.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChAStartTime23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(18, 57);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(95, 12);
            this.label35.TabIndex = 14;
            this.label35.Text = "通道A开始时隙：";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Transparent;
            this.groupBox10.Controls.Add(this.txtChASlotInterval22);
            this.groupBox10.Controls.Add(this.txtChBSlotInterval22);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.txtChBStartSlot22);
            this.groupBox10.Controls.Add(this.txtChBStartTime22);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.txtChAStartSlot22);
            this.groupBox10.Controls.Add(this.txtChAStartTime22);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Location = new System.Drawing.Point(13, 211);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(196, 191);
            this.groupBox10.TabIndex = 39;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "消息22（信道管理）";
            this.groupBox10.UseCompatibleTextRendering = true;
            // 
            // txtChASlotInterval22
            // 
            this.txtChASlotInterval22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChASlotInterval22.FormattingEnabled = true;
            this.txtChASlotInterval22.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChASlotInterval22.Location = new System.Drawing.Point(137, 80);
            this.txtChASlotInterval22.Name = "txtChASlotInterval22";
            this.txtChASlotInterval22.Size = new System.Drawing.Size(53, 20);
            this.txtChASlotInterval22.TabIndex = 42;
            // 
            // txtChBSlotInterval22
            // 
            this.txtChBSlotInterval22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChBSlotInterval22.FormattingEnabled = true;
            this.txtChBSlotInterval22.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChBSlotInterval22.Location = new System.Drawing.Point(137, 159);
            this.txtChBSlotInterval22.Name = "txtChBSlotInterval22";
            this.txtChBSlotInterval22.Size = new System.Drawing.Size(53, 20);
            this.txtChBSlotInterval22.TabIndex = 41;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 162);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 12);
            this.label24.TabIndex = 22;
            this.label24.Text = "通道B时隙间隔：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 109);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 12);
            this.label25.TabIndex = 18;
            this.label25.Text = "通道B开始时隙时间：";
            // 
            // txtChBStartSlot22
            // 
            this.txtChBStartSlot22.Location = new System.Drawing.Point(137, 133);
            this.txtChBStartSlot22.MaxLength = 4;
            this.txtChBStartSlot22.Name = "txtChBStartSlot22";
            this.txtChBStartSlot22.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartSlot22.TabIndex = 21;
            this.txtChBStartSlot22.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txtChBStartSlot22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChBStartTime22
            // 
            this.txtChBStartTime22.Location = new System.Drawing.Point(137, 106);
            this.txtChBStartTime22.MaxLength = 2;
            this.txtChBStartTime22.Name = "txtChBStartTime22";
            this.txtChBStartTime22.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartTime22.TabIndex = 19;
            this.txtChBStartTime22.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChBStartTime22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 136);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 12);
            this.label26.TabIndex = 20;
            this.label26.Text = "通道B开始时隙：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 83);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 12);
            this.label27.TabIndex = 16;
            this.label27.Text = "通道A时隙间隔：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 30);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(119, 12);
            this.label28.TabIndex = 12;
            this.label28.Text = "通道A开始时隙时间：";
            // 
            // txtChAStartSlot22
            // 
            this.txtChAStartSlot22.Location = new System.Drawing.Point(137, 54);
            this.txtChAStartSlot22.MaxLength = 4;
            this.txtChAStartSlot22.Name = "txtChAStartSlot22";
            this.txtChAStartSlot22.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartSlot22.TabIndex = 15;
            this.txtChAStartSlot22.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txtChAStartSlot22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChAStartTime22
            // 
            this.txtChAStartTime22.Location = new System.Drawing.Point(137, 27);
            this.txtChAStartTime22.MaxLength = 2;
            this.txtChAStartTime22.Name = "txtChAStartTime22";
            this.txtChAStartTime22.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartTime22.TabIndex = 13;
            this.txtChAStartTime22.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChAStartTime22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 12);
            this.label29.TabIndex = 14;
            this.label29.Text = "通道A开始时隙：";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.txtChBSlotInterval4);
            this.groupBox9.Controls.Add(this.txtChASlotInterval4);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.txtChBStartSlot4);
            this.groupBox9.Controls.Add(this.txtChBStartTime4);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.txtChAStartSlot4);
            this.groupBox9.Controls.Add(this.txtChAStartTime4);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Location = new System.Drawing.Point(13, 14);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(196, 191);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "消息4（基站报告）";
            this.groupBox9.UseCompatibleTextRendering = true;
            // 
            // txtChBSlotInterval4
            // 
            this.txtChBSlotInterval4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtChBSlotInterval4.Enabled = false;
            this.txtChBSlotInterval4.FormattingEnabled = true;
            this.txtChBSlotInterval4.Items.AddRange(new object[] {
            "750"});
            this.txtChBSlotInterval4.Location = new System.Drawing.Point(137, 159);
            this.txtChBSlotInterval4.Name = "txtChBSlotInterval4";
            this.txtChBSlotInterval4.Size = new System.Drawing.Size(53, 20);
            this.txtChBSlotInterval4.TabIndex = 43;
            this.txtChBSlotInterval4.Text = "750";
            // 
            // txtChASlotInterval4
            // 
            this.txtChASlotInterval4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtChASlotInterval4.Enabled = false;
            this.txtChASlotInterval4.FormattingEnabled = true;
            this.txtChASlotInterval4.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125",
            "2250",
            "4500",
            "6750",
            "13500"});
            this.txtChASlotInterval4.Location = new System.Drawing.Point(137, 80);
            this.txtChASlotInterval4.Name = "txtChASlotInterval4";
            this.txtChASlotInterval4.Size = new System.Drawing.Size(53, 20);
            this.txtChASlotInterval4.TabIndex = 42;
            this.txtChASlotInterval4.Text = "750";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 162);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 12);
            this.label21.TabIndex = 22;
            this.label21.Text = "通道B时隙间隔：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 109);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 12);
            this.label22.TabIndex = 18;
            this.label22.Text = "通道B开始时隙时间：";
            // 
            // txtChBStartSlot4
            // 
            this.txtChBStartSlot4.Location = new System.Drawing.Point(137, 133);
            this.txtChBStartSlot4.MaxLength = 4;
            this.txtChBStartSlot4.Name = "txtChBStartSlot4";
            this.txtChBStartSlot4.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartSlot4.TabIndex = 21;
            this.txtChBStartSlot4.TextChanged += new System.EventHandler(this.txtChStartSlot4_TextChanged);
            this.txtChBStartSlot4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChBStartTime4
            // 
            this.txtChBStartTime4.Location = new System.Drawing.Point(137, 106);
            this.txtChBStartTime4.MaxLength = 2;
            this.txtChBStartTime4.Name = "txtChBStartTime4";
            this.txtChBStartTime4.Size = new System.Drawing.Size(53, 21);
            this.txtChBStartTime4.TabIndex = 19;
            this.txtChBStartTime4.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChBStartTime4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 12);
            this.label23.TabIndex = 20;
            this.label23.Text = "通道B开始时隙：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 12);
            this.label20.TabIndex = 16;
            this.label20.Text = "通道A时隙间隔：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "通道A开始时隙时间：";
            // 
            // txtChAStartSlot4
            // 
            this.txtChAStartSlot4.Location = new System.Drawing.Point(137, 54);
            this.txtChAStartSlot4.MaxLength = 4;
            this.txtChAStartSlot4.Name = "txtChAStartSlot4";
            this.txtChAStartSlot4.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartSlot4.TabIndex = 15;
            this.txtChAStartSlot4.TextChanged += new System.EventHandler(this.txtChStartSlot4_TextChanged);
            this.txtChAStartSlot4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUMStartSlot_KeyPress);
            // 
            // txtChAStartTime4
            // 
            this.txtChAStartTime4.Location = new System.Drawing.Point(137, 27);
            this.txtChAStartTime4.MaxLength = 2;
            this.txtChAStartTime4.Name = "txtChAStartTime4";
            this.txtChAStartTime4.Size = new System.Drawing.Size(53, 21);
            this.txtChAStartTime4.TabIndex = 13;
            this.txtChAStartTime4.TextChanged += new System.EventHandler(this.txtChStartTime_TextChanged);
            this.txtChAStartTime4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 12);
            this.label19.TabIndex = 14;
            this.label19.Text = "通道A开始时隙：";
            // 
            // tPDLM
            // 
            this.tPDLM.Controls.Add(this.groupBox15);
            this.tPDLM.Controls.Add(this.cbxDLMIndex);
            this.tPDLM.Controls.Add(this.label50);
            this.tPDLM.Controls.Add(this.groupBox14);
            this.tPDLM.Location = new System.Drawing.Point(4, 26);
            this.tPDLM.Name = "tPDLM";
            this.tPDLM.Size = new System.Drawing.Size(653, 451);
            this.tPDLM.TabIndex = 3;
            this.tPDLM.Text = "数据链路管理";
            this.tPDLM.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.Transparent;
            this.groupBox15.Controls.Add(this.cbx_Incerment_ChB4);
            this.groupBox15.Controls.Add(this.txt_TimeOut_ChB4);
            this.groupBox15.Controls.Add(this.label71);
            this.groupBox15.Controls.Add(this.cbx_Owner_ChB4);
            this.groupBox15.Controls.Add(this.label72);
            this.groupBox15.Controls.Add(this.txt_SlotCounts_ChB4);
            this.groupBox15.Controls.Add(this.label73);
            this.groupBox15.Controls.Add(this.label74);
            this.groupBox15.Controls.Add(this.txt_StartSlot_ChB4);
            this.groupBox15.Controls.Add(this.label75);
            this.groupBox15.Controls.Add(this.cbx_Incerment_ChB3);
            this.groupBox15.Controls.Add(this.txt_TimeOut_ChB3);
            this.groupBox15.Controls.Add(this.label76);
            this.groupBox15.Controls.Add(this.cbx_Owner_ChB3);
            this.groupBox15.Controls.Add(this.label77);
            this.groupBox15.Controls.Add(this.txt_SlotCounts_ChB3);
            this.groupBox15.Controls.Add(this.label78);
            this.groupBox15.Controls.Add(this.label79);
            this.groupBox15.Controls.Add(this.txt_StartSlot_ChB3);
            this.groupBox15.Controls.Add(this.label80);
            this.groupBox15.Controls.Add(this.cbx_Incerment_ChB2);
            this.groupBox15.Controls.Add(this.txt_TimeOut_ChB2);
            this.groupBox15.Controls.Add(this.label81);
            this.groupBox15.Controls.Add(this.cbx_Owner_ChB2);
            this.groupBox15.Controls.Add(this.label82);
            this.groupBox15.Controls.Add(this.txt_SlotCounts_ChB2);
            this.groupBox15.Controls.Add(this.label83);
            this.groupBox15.Controls.Add(this.label84);
            this.groupBox15.Controls.Add(this.txt_StartSlot_ChB2);
            this.groupBox15.Controls.Add(this.label85);
            this.groupBox15.Controls.Add(this.cbx_Incerment_ChB1);
            this.groupBox15.Controls.Add(this.txt_TimeOut_ChB1);
            this.groupBox15.Controls.Add(this.label86);
            this.groupBox15.Controls.Add(this.cbx_Owner_ChB1);
            this.groupBox15.Controls.Add(this.label87);
            this.groupBox15.Controls.Add(this.txt_SlotCounts_ChB1);
            this.groupBox15.Controls.Add(this.label88);
            this.groupBox15.Controls.Add(this.label89);
            this.groupBox15.Controls.Add(this.txt_StartSlot_ChB1);
            this.groupBox15.Controls.Add(this.label90);
            this.groupBox15.Location = new System.Drawing.Point(19, 239);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(581, 162);
            this.groupBox15.TabIndex = 45;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "通道 B";
            this.groupBox15.UseCompatibleTextRendering = true;
            // 
            // cbx_Incerment_ChB4
            // 
            this.cbx_Incerment_ChB4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Incerment_ChB4.FormattingEnabled = true;
            this.cbx_Incerment_ChB4.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125"});
            this.cbx_Incerment_ChB4.Location = new System.Drawing.Point(509, 47);
            this.cbx_Incerment_ChB4.Name = "cbx_Incerment_ChB4";
            this.cbx_Incerment_ChB4.Size = new System.Drawing.Size(60, 20);
            this.cbx_Incerment_ChB4.TabIndex = 92;
            // 
            // txt_TimeOut_ChB4
            // 
            this.txt_TimeOut_ChB4.Location = new System.Drawing.Point(509, 126);
            this.txt_TimeOut_ChB4.MaxLength = 1;
            this.txt_TimeOut_ChB4.Name = "txt_TimeOut_ChB4";
            this.txt_TimeOut_ChB4.Size = new System.Drawing.Size(60, 21);
            this.txt_TimeOut_ChB4.TabIndex = 91;
            this.txt_TimeOut_ChB4.TextChanged += new System.EventHandler(this.txt_TimeOut_Ch_TextChanged);
            this.txt_TimeOut_ChB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(438, 129);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(41, 12);
            this.label71.TabIndex = 90;
            this.label71.Text = "超时：";
            // 
            // cbx_Owner_ChB4
            // 
            this.cbx_Owner_ChB4.FormattingEnabled = true;
            this.cbx_Owner_ChB4.Items.AddRange(new object[] {
            "Clear",
            "Local",
            "Remote"});
            this.cbx_Owner_ChB4.Location = new System.Drawing.Point(509, 99);
            this.cbx_Owner_ChB4.Name = "cbx_Owner_ChB4";
            this.cbx_Owner_ChB4.Size = new System.Drawing.Size(60, 20);
            this.cbx_Owner_ChB4.TabIndex = 89;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(438, 102);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(53, 12);
            this.label72.TabIndex = 87;
            this.label72.Text = "所有者：";
            // 
            // txt_SlotCounts_ChB4
            // 
            this.txt_SlotCounts_ChB4.Location = new System.Drawing.Point(509, 73);
            this.txt_SlotCounts_ChB4.MaxLength = 1;
            this.txt_SlotCounts_ChB4.Name = "txt_SlotCounts_ChB4";
            this.txt_SlotCounts_ChB4.Size = new System.Drawing.Size(60, 21);
            this.txt_SlotCounts_ChB4.TabIndex = 88;
            this.txt_SlotCounts_ChB4.TextChanged += new System.EventHandler(this.txt_SlotCounts_Ch_TextChanged);
            this.txt_SlotCounts_ChB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(438, 76);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(65, 12);
            this.label73.TabIndex = 86;
            this.label73.Text = "时隙数量：";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(438, 23);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(65, 12);
            this.label74.TabIndex = 83;
            this.label74.Text = "起始时隙：";
            // 
            // txt_StartSlot_ChB4
            // 
            this.txt_StartSlot_ChB4.Location = new System.Drawing.Point(509, 20);
            this.txt_StartSlot_ChB4.MaxLength = 4;
            this.txt_StartSlot_ChB4.Name = "txt_StartSlot_ChB4";
            this.txt_StartSlot_ChB4.Size = new System.Drawing.Size(60, 21);
            this.txt_StartSlot_ChB4.TabIndex = 84;
            this.txt_StartSlot_ChB4.TextChanged += new System.EventHandler(this.txt_StartSlot_Ch_TextChanged);
            this.txt_StartSlot_ChB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(438, 50);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(41, 12);
            this.label75.TabIndex = 85;
            this.label75.Text = "增量：";
            // 
            // cbx_Incerment_ChB3
            // 
            this.cbx_Incerment_ChB3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Incerment_ChB3.FormattingEnabled = true;
            this.cbx_Incerment_ChB3.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125"});
            this.cbx_Incerment_ChB3.Location = new System.Drawing.Point(369, 50);
            this.cbx_Incerment_ChB3.Name = "cbx_Incerment_ChB3";
            this.cbx_Incerment_ChB3.Size = new System.Drawing.Size(60, 20);
            this.cbx_Incerment_ChB3.TabIndex = 82;
            // 
            // txt_TimeOut_ChB3
            // 
            this.txt_TimeOut_ChB3.Location = new System.Drawing.Point(369, 129);
            this.txt_TimeOut_ChB3.MaxLength = 1;
            this.txt_TimeOut_ChB3.Name = "txt_TimeOut_ChB3";
            this.txt_TimeOut_ChB3.Size = new System.Drawing.Size(60, 21);
            this.txt_TimeOut_ChB3.TabIndex = 81;
            this.txt_TimeOut_ChB3.TextChanged += new System.EventHandler(this.txt_TimeOut_Ch_TextChanged);
            this.txt_TimeOut_ChB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(298, 132);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(41, 12);
            this.label76.TabIndex = 80;
            this.label76.Text = "超时：";
            // 
            // cbx_Owner_ChB3
            // 
            this.cbx_Owner_ChB3.FormattingEnabled = true;
            this.cbx_Owner_ChB3.Items.AddRange(new object[] {
            "Clear",
            "Local",
            "Remote"});
            this.cbx_Owner_ChB3.Location = new System.Drawing.Point(369, 102);
            this.cbx_Owner_ChB3.Name = "cbx_Owner_ChB3";
            this.cbx_Owner_ChB3.Size = new System.Drawing.Size(60, 20);
            this.cbx_Owner_ChB3.TabIndex = 79;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(298, 105);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(53, 12);
            this.label77.TabIndex = 77;
            this.label77.Text = "所有者：";
            // 
            // txt_SlotCounts_ChB3
            // 
            this.txt_SlotCounts_ChB3.Location = new System.Drawing.Point(369, 76);
            this.txt_SlotCounts_ChB3.MaxLength = 1;
            this.txt_SlotCounts_ChB3.Name = "txt_SlotCounts_ChB3";
            this.txt_SlotCounts_ChB3.Size = new System.Drawing.Size(60, 21);
            this.txt_SlotCounts_ChB3.TabIndex = 78;
            this.txt_SlotCounts_ChB3.TextChanged += new System.EventHandler(this.txt_SlotCounts_Ch_TextChanged);
            this.txt_SlotCounts_ChB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(298, 79);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(65, 12);
            this.label78.TabIndex = 76;
            this.label78.Text = "时隙数量：";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(298, 26);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(65, 12);
            this.label79.TabIndex = 73;
            this.label79.Text = "起始时隙：";
            // 
            // txt_StartSlot_ChB3
            // 
            this.txt_StartSlot_ChB3.Location = new System.Drawing.Point(369, 23);
            this.txt_StartSlot_ChB3.MaxLength = 4;
            this.txt_StartSlot_ChB3.Name = "txt_StartSlot_ChB3";
            this.txt_StartSlot_ChB3.Size = new System.Drawing.Size(60, 21);
            this.txt_StartSlot_ChB3.TabIndex = 74;
            this.txt_StartSlot_ChB3.TextChanged += new System.EventHandler(this.txt_StartSlot_Ch_TextChanged);
            this.txt_StartSlot_ChB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(298, 53);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(41, 12);
            this.label80.TabIndex = 75;
            this.label80.Text = "增量：";
            // 
            // cbx_Incerment_ChB2
            // 
            this.cbx_Incerment_ChB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Incerment_ChB2.FormattingEnabled = true;
            this.cbx_Incerment_ChB2.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125"});
            this.cbx_Incerment_ChB2.Location = new System.Drawing.Point(231, 50);
            this.cbx_Incerment_ChB2.Name = "cbx_Incerment_ChB2";
            this.cbx_Incerment_ChB2.Size = new System.Drawing.Size(60, 20);
            this.cbx_Incerment_ChB2.TabIndex = 72;
            // 
            // txt_TimeOut_ChB2
            // 
            this.txt_TimeOut_ChB2.Location = new System.Drawing.Point(231, 129);
            this.txt_TimeOut_ChB2.MaxLength = 1;
            this.txt_TimeOut_ChB2.Name = "txt_TimeOut_ChB2";
            this.txt_TimeOut_ChB2.Size = new System.Drawing.Size(60, 21);
            this.txt_TimeOut_ChB2.TabIndex = 71;
            this.txt_TimeOut_ChB2.TextChanged += new System.EventHandler(this.txt_TimeOut_Ch_TextChanged);
            this.txt_TimeOut_ChB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(160, 132);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(41, 12);
            this.label81.TabIndex = 70;
            this.label81.Text = "超时：";
            // 
            // cbx_Owner_ChB2
            // 
            this.cbx_Owner_ChB2.FormattingEnabled = true;
            this.cbx_Owner_ChB2.Items.AddRange(new object[] {
            "Clear",
            "Local",
            "Remote"});
            this.cbx_Owner_ChB2.Location = new System.Drawing.Point(231, 102);
            this.cbx_Owner_ChB2.Name = "cbx_Owner_ChB2";
            this.cbx_Owner_ChB2.Size = new System.Drawing.Size(60, 20);
            this.cbx_Owner_ChB2.TabIndex = 69;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(160, 105);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(53, 12);
            this.label82.TabIndex = 67;
            this.label82.Text = "所有者：";
            // 
            // txt_SlotCounts_ChB2
            // 
            this.txt_SlotCounts_ChB2.Location = new System.Drawing.Point(231, 76);
            this.txt_SlotCounts_ChB2.MaxLength = 1;
            this.txt_SlotCounts_ChB2.Name = "txt_SlotCounts_ChB2";
            this.txt_SlotCounts_ChB2.Size = new System.Drawing.Size(60, 21);
            this.txt_SlotCounts_ChB2.TabIndex = 68;
            this.txt_SlotCounts_ChB2.TextChanged += new System.EventHandler(this.txt_SlotCounts_Ch_TextChanged);
            this.txt_SlotCounts_ChB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(160, 79);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(65, 12);
            this.label83.TabIndex = 66;
            this.label83.Text = "时隙数量：";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(160, 26);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(65, 12);
            this.label84.TabIndex = 63;
            this.label84.Text = "起始时隙：";
            // 
            // txt_StartSlot_ChB2
            // 
            this.txt_StartSlot_ChB2.Location = new System.Drawing.Point(231, 23);
            this.txt_StartSlot_ChB2.MaxLength = 4;
            this.txt_StartSlot_ChB2.Name = "txt_StartSlot_ChB2";
            this.txt_StartSlot_ChB2.Size = new System.Drawing.Size(60, 21);
            this.txt_StartSlot_ChB2.TabIndex = 64;
            this.txt_StartSlot_ChB2.TextChanged += new System.EventHandler(this.txt_StartSlot_Ch_TextChanged);
            this.txt_StartSlot_ChB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(160, 53);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(41, 12);
            this.label85.TabIndex = 65;
            this.label85.Text = "增量：";
            // 
            // cbx_Incerment_ChB1
            // 
            this.cbx_Incerment_ChB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Incerment_ChB1.FormattingEnabled = true;
            this.cbx_Incerment_ChB1.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125"});
            this.cbx_Incerment_ChB1.Location = new System.Drawing.Point(89, 50);
            this.cbx_Incerment_ChB1.Name = "cbx_Incerment_ChB1";
            this.cbx_Incerment_ChB1.Size = new System.Drawing.Size(60, 20);
            this.cbx_Incerment_ChB1.TabIndex = 62;
            // 
            // txt_TimeOut_ChB1
            // 
            this.txt_TimeOut_ChB1.Location = new System.Drawing.Point(89, 129);
            this.txt_TimeOut_ChB1.MaxLength = 1;
            this.txt_TimeOut_ChB1.Name = "txt_TimeOut_ChB1";
            this.txt_TimeOut_ChB1.Size = new System.Drawing.Size(60, 21);
            this.txt_TimeOut_ChB1.TabIndex = 61;
            this.txt_TimeOut_ChB1.TextChanged += new System.EventHandler(this.txt_TimeOut_Ch_TextChanged);
            this.txt_TimeOut_ChB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(18, 132);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(41, 12);
            this.label86.TabIndex = 60;
            this.label86.Text = "超时：";
            // 
            // cbx_Owner_ChB1
            // 
            this.cbx_Owner_ChB1.FormattingEnabled = true;
            this.cbx_Owner_ChB1.Items.AddRange(new object[] {
            "Clear",
            "Local",
            "Remote"});
            this.cbx_Owner_ChB1.Location = new System.Drawing.Point(89, 102);
            this.cbx_Owner_ChB1.Name = "cbx_Owner_ChB1";
            this.cbx_Owner_ChB1.Size = new System.Drawing.Size(60, 20);
            this.cbx_Owner_ChB1.TabIndex = 58;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(18, 105);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(53, 12);
            this.label87.TabIndex = 53;
            this.label87.Text = "所有者：";
            // 
            // txt_SlotCounts_ChB1
            // 
            this.txt_SlotCounts_ChB1.Location = new System.Drawing.Point(89, 76);
            this.txt_SlotCounts_ChB1.MaxLength = 1;
            this.txt_SlotCounts_ChB1.Name = "txt_SlotCounts_ChB1";
            this.txt_SlotCounts_ChB1.Size = new System.Drawing.Size(60, 21);
            this.txt_SlotCounts_ChB1.TabIndex = 54;
            this.txt_SlotCounts_ChB1.TextChanged += new System.EventHandler(this.txt_SlotCounts_Ch_TextChanged);
            this.txt_SlotCounts_ChB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(18, 79);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(65, 12);
            this.label88.TabIndex = 52;
            this.label88.Text = "时隙数量：";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(18, 26);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(65, 12);
            this.label89.TabIndex = 48;
            this.label89.Text = "起始时隙：";
            // 
            // txt_StartSlot_ChB1
            // 
            this.txt_StartSlot_ChB1.Location = new System.Drawing.Point(89, 23);
            this.txt_StartSlot_ChB1.MaxLength = 4;
            this.txt_StartSlot_ChB1.Name = "txt_StartSlot_ChB1";
            this.txt_StartSlot_ChB1.Size = new System.Drawing.Size(60, 21);
            this.txt_StartSlot_ChB1.TabIndex = 49;
            this.txt_StartSlot_ChB1.TextChanged += new System.EventHandler(this.txt_StartSlot_Ch_TextChanged);
            this.txt_StartSlot_ChB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(18, 53);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(41, 12);
            this.label90.TabIndex = 50;
            this.label90.Text = "增量：";
            // 
            // cbxDLMIndex
            // 
            this.cbxDLMIndex.FormattingEnabled = true;
            this.cbxDLMIndex.Items.AddRange(new object[] {
            "1-4",
            "5-8",
            "9-12",
            "13-16",
            "17-20",
            "21-24",
            "25-28",
            "29-32",
            "33-36",
            "37-40"});
            this.cbxDLMIndex.Location = new System.Drawing.Point(177, 17);
            this.cbxDLMIndex.Name = "cbxDLMIndex";
            this.cbxDLMIndex.Size = new System.Drawing.Size(61, 20);
            this.cbxDLMIndex.TabIndex = 44;
            this.cbxDLMIndex.Text = "1-4";
            this.cbxDLMIndex.SelectedIndexChanged += new System.EventHandler(this.cbxDLMIndex_SelectedIndexChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label50.Location = new System.Drawing.Point(12, 14);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(170, 21);
            this.label50.TabIndex = 43;
            this.label50.Text = "选择设置项进行编辑：";
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.Transparent;
            this.groupBox14.Controls.Add(this.cbx_Incerment_ChA4);
            this.groupBox14.Controls.Add(this.txt_TimeOut_ChA4);
            this.groupBox14.Controls.Add(this.label66);
            this.groupBox14.Controls.Add(this.cbx_Owner_ChA4);
            this.groupBox14.Controls.Add(this.label67);
            this.groupBox14.Controls.Add(this.txt_SlotCounts_ChA4);
            this.groupBox14.Controls.Add(this.label68);
            this.groupBox14.Controls.Add(this.label69);
            this.groupBox14.Controls.Add(this.txt_StartSlot_ChA4);
            this.groupBox14.Controls.Add(this.label70);
            this.groupBox14.Controls.Add(this.cbx_Incerment_ChA3);
            this.groupBox14.Controls.Add(this.txt_TimeOut_ChA3);
            this.groupBox14.Controls.Add(this.label61);
            this.groupBox14.Controls.Add(this.cbx_Owner_ChA3);
            this.groupBox14.Controls.Add(this.label62);
            this.groupBox14.Controls.Add(this.txt_SlotCounts_ChA3);
            this.groupBox14.Controls.Add(this.label63);
            this.groupBox14.Controls.Add(this.label64);
            this.groupBox14.Controls.Add(this.txt_StartSlot_ChA3);
            this.groupBox14.Controls.Add(this.label65);
            this.groupBox14.Controls.Add(this.cbx_Incerment_ChA2);
            this.groupBox14.Controls.Add(this.txt_TimeOut_ChA2);
            this.groupBox14.Controls.Add(this.label51);
            this.groupBox14.Controls.Add(this.cbx_Owner_ChA2);
            this.groupBox14.Controls.Add(this.label53);
            this.groupBox14.Controls.Add(this.txt_SlotCounts_ChA2);
            this.groupBox14.Controls.Add(this.label55);
            this.groupBox14.Controls.Add(this.label59);
            this.groupBox14.Controls.Add(this.txt_StartSlot_ChA2);
            this.groupBox14.Controls.Add(this.label60);
            this.groupBox14.Controls.Add(this.cbx_Incerment_ChA1);
            this.groupBox14.Controls.Add(this.txt_TimeOut_ChA1);
            this.groupBox14.Controls.Add(this.label52);
            this.groupBox14.Controls.Add(this.cbx_Owner_ChA1);
            this.groupBox14.Controls.Add(this.label54);
            this.groupBox14.Controls.Add(this.txt_SlotCounts_ChA1);
            this.groupBox14.Controls.Add(this.label56);
            this.groupBox14.Controls.Add(this.label57);
            this.groupBox14.Controls.Add(this.txt_StartSlot_ChA1);
            this.groupBox14.Controls.Add(this.label58);
            this.groupBox14.Location = new System.Drawing.Point(19, 53);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(581, 162);
            this.groupBox14.TabIndex = 38;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "通道 A";
            this.groupBox14.UseCompatibleTextRendering = true;
            // 
            // cbx_Incerment_ChA4
            // 
            this.cbx_Incerment_ChA4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Incerment_ChA4.FormattingEnabled = true;
            this.cbx_Incerment_ChA4.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125"});
            this.cbx_Incerment_ChA4.Location = new System.Drawing.Point(509, 47);
            this.cbx_Incerment_ChA4.Name = "cbx_Incerment_ChA4";
            this.cbx_Incerment_ChA4.Size = new System.Drawing.Size(60, 20);
            this.cbx_Incerment_ChA4.TabIndex = 92;
            // 
            // txt_TimeOut_ChA4
            // 
            this.txt_TimeOut_ChA4.Location = new System.Drawing.Point(509, 126);
            this.txt_TimeOut_ChA4.MaxLength = 1;
            this.txt_TimeOut_ChA4.Name = "txt_TimeOut_ChA4";
            this.txt_TimeOut_ChA4.Size = new System.Drawing.Size(60, 21);
            this.txt_TimeOut_ChA4.TabIndex = 91;
            this.txt_TimeOut_ChA4.TextChanged += new System.EventHandler(this.txt_TimeOut_Ch_TextChanged);
            this.txt_TimeOut_ChA4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(438, 129);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(41, 12);
            this.label66.TabIndex = 90;
            this.label66.Text = "超时：";
            // 
            // cbx_Owner_ChA4
            // 
            this.cbx_Owner_ChA4.FormattingEnabled = true;
            this.cbx_Owner_ChA4.Items.AddRange(new object[] {
            "Clear",
            "Local",
            "Remote"});
            this.cbx_Owner_ChA4.Location = new System.Drawing.Point(509, 99);
            this.cbx_Owner_ChA4.Name = "cbx_Owner_ChA4";
            this.cbx_Owner_ChA4.Size = new System.Drawing.Size(60, 20);
            this.cbx_Owner_ChA4.TabIndex = 89;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(438, 102);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(53, 12);
            this.label67.TabIndex = 87;
            this.label67.Text = "所有者：";
            // 
            // txt_SlotCounts_ChA4
            // 
            this.txt_SlotCounts_ChA4.Location = new System.Drawing.Point(509, 73);
            this.txt_SlotCounts_ChA4.MaxLength = 1;
            this.txt_SlotCounts_ChA4.Name = "txt_SlotCounts_ChA4";
            this.txt_SlotCounts_ChA4.Size = new System.Drawing.Size(60, 21);
            this.txt_SlotCounts_ChA4.TabIndex = 88;
            this.txt_SlotCounts_ChA4.TextChanged += new System.EventHandler(this.txt_SlotCounts_Ch_TextChanged);
            this.txt_SlotCounts_ChA4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(438, 76);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(65, 12);
            this.label68.TabIndex = 86;
            this.label68.Text = "时隙数量：";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(438, 23);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(65, 12);
            this.label69.TabIndex = 83;
            this.label69.Text = "起始时隙：";
            // 
            // txt_StartSlot_ChA4
            // 
            this.txt_StartSlot_ChA4.Location = new System.Drawing.Point(509, 20);
            this.txt_StartSlot_ChA4.MaxLength = 4;
            this.txt_StartSlot_ChA4.Name = "txt_StartSlot_ChA4";
            this.txt_StartSlot_ChA4.Size = new System.Drawing.Size(60, 21);
            this.txt_StartSlot_ChA4.TabIndex = 84;
            this.txt_StartSlot_ChA4.TextChanged += new System.EventHandler(this.txt_StartSlot_Ch_TextChanged);
            this.txt_StartSlot_ChA4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(438, 50);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(41, 12);
            this.label70.TabIndex = 85;
            this.label70.Text = "增量：";
            // 
            // cbx_Incerment_ChA3
            // 
            this.cbx_Incerment_ChA3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Incerment_ChA3.FormattingEnabled = true;
            this.cbx_Incerment_ChA3.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125"});
            this.cbx_Incerment_ChA3.Location = new System.Drawing.Point(369, 50);
            this.cbx_Incerment_ChA3.Name = "cbx_Incerment_ChA3";
            this.cbx_Incerment_ChA3.Size = new System.Drawing.Size(60, 20);
            this.cbx_Incerment_ChA3.TabIndex = 82;
            // 
            // txt_TimeOut_ChA3
            // 
            this.txt_TimeOut_ChA3.Location = new System.Drawing.Point(369, 129);
            this.txt_TimeOut_ChA3.MaxLength = 1;
            this.txt_TimeOut_ChA3.Name = "txt_TimeOut_ChA3";
            this.txt_TimeOut_ChA3.Size = new System.Drawing.Size(60, 21);
            this.txt_TimeOut_ChA3.TabIndex = 81;
            this.txt_TimeOut_ChA3.TextChanged += new System.EventHandler(this.txt_TimeOut_Ch_TextChanged);
            this.txt_TimeOut_ChA3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(298, 132);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(41, 12);
            this.label61.TabIndex = 80;
            this.label61.Text = "超时：";
            // 
            // cbx_Owner_ChA3
            // 
            this.cbx_Owner_ChA3.FormattingEnabled = true;
            this.cbx_Owner_ChA3.Items.AddRange(new object[] {
            "Clear",
            "Local",
            "Remote"});
            this.cbx_Owner_ChA3.Location = new System.Drawing.Point(369, 102);
            this.cbx_Owner_ChA3.Name = "cbx_Owner_ChA3";
            this.cbx_Owner_ChA3.Size = new System.Drawing.Size(60, 20);
            this.cbx_Owner_ChA3.TabIndex = 79;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(298, 105);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(53, 12);
            this.label62.TabIndex = 77;
            this.label62.Text = "所有者：";
            // 
            // txt_SlotCounts_ChA3
            // 
            this.txt_SlotCounts_ChA3.Location = new System.Drawing.Point(369, 76);
            this.txt_SlotCounts_ChA3.MaxLength = 1;
            this.txt_SlotCounts_ChA3.Name = "txt_SlotCounts_ChA3";
            this.txt_SlotCounts_ChA3.Size = new System.Drawing.Size(60, 21);
            this.txt_SlotCounts_ChA3.TabIndex = 78;
            this.txt_SlotCounts_ChA3.TextChanged += new System.EventHandler(this.txt_SlotCounts_Ch_TextChanged);
            this.txt_SlotCounts_ChA3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(298, 79);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(65, 12);
            this.label63.TabIndex = 76;
            this.label63.Text = "时隙数量：";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(298, 26);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(65, 12);
            this.label64.TabIndex = 73;
            this.label64.Text = "起始时隙：";
            // 
            // txt_StartSlot_ChA3
            // 
            this.txt_StartSlot_ChA3.Location = new System.Drawing.Point(369, 23);
            this.txt_StartSlot_ChA3.MaxLength = 4;
            this.txt_StartSlot_ChA3.Name = "txt_StartSlot_ChA3";
            this.txt_StartSlot_ChA3.Size = new System.Drawing.Size(60, 21);
            this.txt_StartSlot_ChA3.TabIndex = 74;
            this.txt_StartSlot_ChA3.TextChanged += new System.EventHandler(this.txt_StartSlot_Ch_TextChanged);
            this.txt_StartSlot_ChA3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(298, 53);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(41, 12);
            this.label65.TabIndex = 75;
            this.label65.Text = "增量：";
            // 
            // cbx_Incerment_ChA2
            // 
            this.cbx_Incerment_ChA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Incerment_ChA2.FormattingEnabled = true;
            this.cbx_Incerment_ChA2.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125"});
            this.cbx_Incerment_ChA2.Location = new System.Drawing.Point(231, 50);
            this.cbx_Incerment_ChA2.Name = "cbx_Incerment_ChA2";
            this.cbx_Incerment_ChA2.Size = new System.Drawing.Size(60, 20);
            this.cbx_Incerment_ChA2.TabIndex = 72;
            // 
            // txt_TimeOut_ChA2
            // 
            this.txt_TimeOut_ChA2.Location = new System.Drawing.Point(231, 129);
            this.txt_TimeOut_ChA2.MaxLength = 1;
            this.txt_TimeOut_ChA2.Name = "txt_TimeOut_ChA2";
            this.txt_TimeOut_ChA2.Size = new System.Drawing.Size(60, 21);
            this.txt_TimeOut_ChA2.TabIndex = 71;
            this.txt_TimeOut_ChA2.TextChanged += new System.EventHandler(this.txt_TimeOut_Ch_TextChanged);
            this.txt_TimeOut_ChA2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(160, 132);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(41, 12);
            this.label51.TabIndex = 70;
            this.label51.Text = "超时：";
            // 
            // cbx_Owner_ChA2
            // 
            this.cbx_Owner_ChA2.FormattingEnabled = true;
            this.cbx_Owner_ChA2.Items.AddRange(new object[] {
            "Clear",
            "Local",
            "Remote"});
            this.cbx_Owner_ChA2.Location = new System.Drawing.Point(231, 102);
            this.cbx_Owner_ChA2.Name = "cbx_Owner_ChA2";
            this.cbx_Owner_ChA2.Size = new System.Drawing.Size(60, 20);
            this.cbx_Owner_ChA2.TabIndex = 69;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(160, 105);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(53, 12);
            this.label53.TabIndex = 67;
            this.label53.Text = "所有者：";
            // 
            // txt_SlotCounts_ChA2
            // 
            this.txt_SlotCounts_ChA2.Location = new System.Drawing.Point(231, 76);
            this.txt_SlotCounts_ChA2.MaxLength = 1;
            this.txt_SlotCounts_ChA2.Name = "txt_SlotCounts_ChA2";
            this.txt_SlotCounts_ChA2.Size = new System.Drawing.Size(60, 21);
            this.txt_SlotCounts_ChA2.TabIndex = 68;
            this.txt_SlotCounts_ChA2.TextChanged += new System.EventHandler(this.txt_SlotCounts_Ch_TextChanged);
            this.txt_SlotCounts_ChA2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(160, 79);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(65, 12);
            this.label55.TabIndex = 66;
            this.label55.Text = "时隙数量：";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(160, 26);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(65, 12);
            this.label59.TabIndex = 63;
            this.label59.Text = "起始时隙：";
            // 
            // txt_StartSlot_ChA2
            // 
            this.txt_StartSlot_ChA2.Location = new System.Drawing.Point(231, 23);
            this.txt_StartSlot_ChA2.MaxLength = 4;
            this.txt_StartSlot_ChA2.Name = "txt_StartSlot_ChA2";
            this.txt_StartSlot_ChA2.Size = new System.Drawing.Size(60, 21);
            this.txt_StartSlot_ChA2.TabIndex = 64;
            this.txt_StartSlot_ChA2.TextChanged += new System.EventHandler(this.txt_StartSlot_Ch_TextChanged);
            this.txt_StartSlot_ChA2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(160, 53);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(41, 12);
            this.label60.TabIndex = 65;
            this.label60.Text = "增量：";
            // 
            // cbx_Incerment_ChA1
            // 
            this.cbx_Incerment_ChA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Incerment_ChA1.FormattingEnabled = true;
            this.cbx_Incerment_ChA1.Items.AddRange(new object[] {
            "",
            "0",
            "45",
            "50",
            "75",
            "90",
            "125",
            "150",
            "225",
            "375",
            "450",
            "750",
            "1125"});
            this.cbx_Incerment_ChA1.Location = new System.Drawing.Point(89, 50);
            this.cbx_Incerment_ChA1.Name = "cbx_Incerment_ChA1";
            this.cbx_Incerment_ChA1.Size = new System.Drawing.Size(60, 20);
            this.cbx_Incerment_ChA1.TabIndex = 62;
            // 
            // txt_TimeOut_ChA1
            // 
            this.txt_TimeOut_ChA1.Location = new System.Drawing.Point(89, 129);
            this.txt_TimeOut_ChA1.MaxLength = 1;
            this.txt_TimeOut_ChA1.Name = "txt_TimeOut_ChA1";
            this.txt_TimeOut_ChA1.Size = new System.Drawing.Size(60, 21);
            this.txt_TimeOut_ChA1.TabIndex = 61;
            this.txt_TimeOut_ChA1.TextChanged += new System.EventHandler(this.txt_TimeOut_Ch_TextChanged);
            this.txt_TimeOut_ChA1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(18, 132);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(41, 12);
            this.label52.TabIndex = 60;
            this.label52.Text = "超时：";
            // 
            // cbx_Owner_ChA1
            // 
            this.cbx_Owner_ChA1.FormattingEnabled = true;
            this.cbx_Owner_ChA1.Items.AddRange(new object[] {
            "Clear",
            "Local",
            "Remote"});
            this.cbx_Owner_ChA1.Location = new System.Drawing.Point(89, 102);
            this.cbx_Owner_ChA1.Name = "cbx_Owner_ChA1";
            this.cbx_Owner_ChA1.Size = new System.Drawing.Size(60, 20);
            this.cbx_Owner_ChA1.TabIndex = 58;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(18, 105);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(53, 12);
            this.label54.TabIndex = 53;
            this.label54.Text = "所有者：";
            // 
            // txt_SlotCounts_ChA1
            // 
            this.txt_SlotCounts_ChA1.Location = new System.Drawing.Point(89, 76);
            this.txt_SlotCounts_ChA1.MaxLength = 1;
            this.txt_SlotCounts_ChA1.Name = "txt_SlotCounts_ChA1";
            this.txt_SlotCounts_ChA1.Size = new System.Drawing.Size(60, 21);
            this.txt_SlotCounts_ChA1.TabIndex = 54;
            this.txt_SlotCounts_ChA1.TextChanged += new System.EventHandler(this.txt_SlotCounts_Ch_TextChanged);
            this.txt_SlotCounts_ChA1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(18, 79);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(65, 12);
            this.label56.TabIndex = 52;
            this.label56.Text = "时隙数量：";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(18, 26);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(65, 12);
            this.label57.TabIndex = 48;
            this.label57.Text = "起始时隙：";
            // 
            // txt_StartSlot_ChA1
            // 
            this.txt_StartSlot_ChA1.Location = new System.Drawing.Point(89, 23);
            this.txt_StartSlot_ChA1.MaxLength = 4;
            this.txt_StartSlot_ChA1.Name = "txt_StartSlot_ChA1";
            this.txt_StartSlot_ChA1.Size = new System.Drawing.Size(60, 21);
            this.txt_StartSlot_ChA1.TabIndex = 49;
            this.txt_StartSlot_ChA1.TextChanged += new System.EventHandler(this.txt_StartSlot_Ch_TextChanged);
            this.txt_StartSlot_ChA1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(18, 53);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(41, 12);
            this.label58.TabIndex = 50;
            this.label58.Text = "增量：";
            // 
            // tPGroupAssignment
            // 
            this.tPGroupAssignment.Controls.Add(this.groupBox25);
            this.tPGroupAssignment.Location = new System.Drawing.Point(4, 26);
            this.tPGroupAssignment.Name = "tPGroupAssignment";
            this.tPGroupAssignment.Size = new System.Drawing.Size(653, 451);
            this.tPGroupAssignment.TabIndex = 6;
            this.tPGroupAssignment.Text = "VSI/FSR消息管理";
            this.tPGroupAssignment.UseVisualStyleBackColor = true;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.groupBox21);
            this.groupBox25.Controls.Add(this.cbx_SPO_Channel);
            this.groupBox25.Controls.Add(this.groupBox16);
            this.groupBox25.Location = new System.Drawing.Point(3, 3);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(561, 286);
            this.groupBox25.TabIndex = 49;
            this.groupBox25.TabStop = false;
            // 
            // groupBox21
            // 
            this.groupBox21.BackColor = System.Drawing.Color.Transparent;
            this.groupBox21.Controls.Add(this.ckb_SNR);
            this.groupBox21.Controls.Add(this.ckb_TimeOfMsgArrival);
            this.groupBox21.Controls.Add(this.ckb_FisrtSlotNumForFirstRecvMsg);
            this.groupBox21.Controls.Add(this.ckb_SingalStrength);
            this.groupBox21.Controls.Add(this.ckb_VSI4VDO);
            this.groupBox21.Controls.Add(this.ckb_VSI4VDM);
            this.groupBox21.Location = new System.Drawing.Point(15, 45);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(265, 208);
            this.groupBox21.TabIndex = 19;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "VSI 语句";
            this.groupBox21.UseCompatibleTextRendering = true;
            // 
            // ckb_SNR
            // 
            this.ckb_SNR.AutoSize = true;
            this.ckb_SNR.Location = new System.Drawing.Point(22, 178);
            this.ckb_SNR.Name = "ckb_SNR";
            this.ckb_SNR.Size = new System.Drawing.Size(84, 16);
            this.ckb_SNR.TabIndex = 34;
            this.ckb_SNR.Text = "信号信噪比";
            this.ckb_SNR.UseVisualStyleBackColor = true;
            // 
            // ckb_TimeOfMsgArrival
            // 
            this.ckb_TimeOfMsgArrival.AutoSize = true;
            this.ckb_TimeOfMsgArrival.Location = new System.Drawing.Point(22, 150);
            this.ckb_TimeOfMsgArrival.Name = "ckb_TimeOfMsgArrival";
            this.ckb_TimeOfMsgArrival.Size = new System.Drawing.Size(144, 16);
            this.ckb_TimeOfMsgArrival.TabIndex = 33;
            this.ckb_TimeOfMsgArrival.Text = "消息到达时间输出使能";
            this.ckb_TimeOfMsgArrival.UseVisualStyleBackColor = true;
            // 
            // ckb_FisrtSlotNumForFirstRecvMsg
            // 
            this.ckb_FisrtSlotNumForFirstRecvMsg.AutoSize = true;
            this.ckb_FisrtSlotNumForFirstRecvMsg.Location = new System.Drawing.Point(22, 120);
            this.ckb_FisrtSlotNumForFirstRecvMsg.Name = "ckb_FisrtSlotNumForFirstRecvMsg";
            this.ckb_FisrtSlotNumForFirstRecvMsg.Size = new System.Drawing.Size(228, 16);
            this.ckb_FisrtSlotNumForFirstRecvMsg.TabIndex = 32;
            this.ckb_FisrtSlotNumForFirstRecvMsg.Text = "每个接受消息的第一个时隙号输出使能";
            this.ckb_FisrtSlotNumForFirstRecvMsg.UseVisualStyleBackColor = true;
            // 
            // ckb_SingalStrength
            // 
            this.ckb_SingalStrength.AutoSize = true;
            this.ckb_SingalStrength.Location = new System.Drawing.Point(22, 90);
            this.ckb_SingalStrength.Name = "ckb_SingalStrength";
            this.ckb_SingalStrength.Size = new System.Drawing.Size(120, 16);
            this.ckb_SingalStrength.TabIndex = 31;
            this.ckb_SingalStrength.Text = "信号强度输出使能";
            this.ckb_SingalStrength.UseVisualStyleBackColor = true;
            // 
            // ckb_VSI4VDO
            // 
            this.ckb_VSI4VDO.AutoSize = true;
            this.ckb_VSI4VDO.Location = new System.Drawing.Point(22, 60);
            this.ckb_VSI4VDO.Name = "ckb_VSI4VDO";
            this.ckb_VSI4VDO.Size = new System.Drawing.Size(156, 16);
            this.ckb_VSI4VDO.TabIndex = 30;
            this.ckb_VSI4VDO.Text = "VDO语句输出VSI语句使能";
            this.ckb_VSI4VDO.UseVisualStyleBackColor = true;
            // 
            // ckb_VSI4VDM
            // 
            this.ckb_VSI4VDM.AutoSize = true;
            this.ckb_VSI4VDM.Location = new System.Drawing.Point(22, 30);
            this.ckb_VSI4VDM.Name = "ckb_VSI4VDM";
            this.ckb_VSI4VDM.Size = new System.Drawing.Size(156, 16);
            this.ckb_VSI4VDM.TabIndex = 29;
            this.ckb_VSI4VDM.Text = "VDM语句输出VSI语句使能";
            this.ckb_VSI4VDM.UseVisualStyleBackColor = true;
            // 
            // cbx_SPO_Channel
            // 
            this.cbx_SPO_Channel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_SPO_Channel.FormattingEnabled = true;
            this.cbx_SPO_Channel.Items.AddRange(new object[] {
            "选择通道 A",
            "选择通道 B",
            "选择所有通道 E",
            "所有通道均不选择 N"});
            this.cbx_SPO_Channel.Location = new System.Drawing.Point(15, 20);
            this.cbx_SPO_Channel.Name = "cbx_SPO_Channel";
            this.cbx_SPO_Channel.Size = new System.Drawing.Size(193, 24);
            this.cbx_SPO_Channel.TabIndex = 46;
            this.cbx_SPO_Channel.Text = "选择通道 A";
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.Transparent;
            this.groupBox16.Controls.Add(this.ckb_RecvSingalStrength);
            this.groupBox16.Controls.Add(this.ckb_AverageNoiseLevel);
            this.groupBox16.Controls.Add(this.ckb_ForecastCHLoad);
            this.groupBox16.Controls.Add(this.ckb_NumOfBadCRC);
            this.groupBox16.Controls.Add(this.ckb_PreFrameCHLoad);
            this.groupBox16.Controls.Add(this.ckb_ProFSRSens);
            this.groupBox16.Location = new System.Drawing.Point(286, 45);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(241, 208);
            this.groupBox16.TabIndex = 47;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "FSR 语句";
            this.groupBox16.UseCompatibleTextRendering = true;
            // 
            // ckb_RecvSingalStrength
            // 
            this.ckb_RecvSingalStrength.AutoSize = true;
            this.ckb_RecvSingalStrength.Location = new System.Drawing.Point(17, 178);
            this.ckb_RecvSingalStrength.Name = "ckb_RecvSingalStrength";
            this.ckb_RecvSingalStrength.Size = new System.Drawing.Size(144, 16);
            this.ckb_RecvSingalStrength.TabIndex = 39;
            this.ckb_RecvSingalStrength.Text = "接受信号强度输出使能";
            this.ckb_RecvSingalStrength.UseVisualStyleBackColor = true;
            // 
            // ckb_AverageNoiseLevel
            // 
            this.ckb_AverageNoiseLevel.AutoSize = true;
            this.ckb_AverageNoiseLevel.Location = new System.Drawing.Point(17, 150);
            this.ckb_AverageNoiseLevel.Name = "ckb_AverageNoiseLevel";
            this.ckb_AverageNoiseLevel.Size = new System.Drawing.Size(144, 16);
            this.ckb_AverageNoiseLevel.TabIndex = 38;
            this.ckb_AverageNoiseLevel.Text = "平均噪声电平输出使能";
            this.ckb_AverageNoiseLevel.UseVisualStyleBackColor = true;
            // 
            // ckb_ForecastCHLoad
            // 
            this.ckb_ForecastCHLoad.AutoSize = true;
            this.ckb_ForecastCHLoad.Location = new System.Drawing.Point(17, 120);
            this.ckb_ForecastCHLoad.Name = "ckb_ForecastCHLoad";
            this.ckb_ForecastCHLoad.Size = new System.Drawing.Size(156, 16);
            this.ckb_ForecastCHLoad.TabIndex = 37;
            this.ckb_ForecastCHLoad.Text = "预测通道负载量输出使能";
            this.ckb_ForecastCHLoad.UseVisualStyleBackColor = true;
            // 
            // ckb_NumOfBadCRC
            // 
            this.ckb_NumOfBadCRC.AutoSize = true;
            this.ckb_NumOfBadCRC.Location = new System.Drawing.Point(17, 90);
            this.ckb_NumOfBadCRC.Name = "ckb_NumOfBadCRC";
            this.ckb_NumOfBadCRC.Size = new System.Drawing.Size(198, 16);
            this.ckb_NumOfBadCRC.TabIndex = 36;
            this.ckb_NumOfBadCRC.Text = "CRC校验错误的消息数量输出使能";
            this.ckb_NumOfBadCRC.UseVisualStyleBackColor = true;
            // 
            // ckb_PreFrameCHLoad
            // 
            this.ckb_PreFrameCHLoad.AutoSize = true;
            this.ckb_PreFrameCHLoad.Location = new System.Drawing.Point(17, 60);
            this.ckb_PreFrameCHLoad.Name = "ckb_PreFrameCHLoad";
            this.ckb_PreFrameCHLoad.Size = new System.Drawing.Size(120, 16);
            this.ckb_PreFrameCHLoad.TabIndex = 35;
            this.ckb_PreFrameCHLoad.Text = "上一帧通道负载量";
            this.ckb_PreFrameCHLoad.UseVisualStyleBackColor = true;
            // 
            // ckb_ProFSRSens
            // 
            this.ckb_ProFSRSens.AutoSize = true;
            this.ckb_ProFSRSens.Location = new System.Drawing.Point(17, 30);
            this.ckb_ProFSRSens.Name = "ckb_ProFSRSens";
            this.ckb_ProFSRSens.Size = new System.Drawing.Size(162, 16);
            this.ckb_ProFSRSens.TabIndex = 34;
            this.ckb_ProFSRSens.Text = "每一帧后输出FSR语句使能";
            this.ckb_ProFSRSens.UseVisualStyleBackColor = true;
            // 
            // tPVtoN
            // 
            this.tPVtoN.Controls.Add(this.btn_AtoN_1);
            this.tPVtoN.Controls.Add(this.groupBox17);
            this.tPVtoN.Controls.Add(this.btn_AtoN_32);
            this.tPVtoN.Controls.Add(this.btn_AtoN_31);
            this.tPVtoN.Controls.Add(this.btn_AtoN_30);
            this.tPVtoN.Controls.Add(this.btn_AtoN_29);
            this.tPVtoN.Controls.Add(this.btn_AtoN_28);
            this.tPVtoN.Controls.Add(this.btn_AtoN_27);
            this.tPVtoN.Controls.Add(this.btn_AtoN_26);
            this.tPVtoN.Controls.Add(this.btn_AtoN_25);
            this.tPVtoN.Controls.Add(this.btn_AtoN_24);
            this.tPVtoN.Controls.Add(this.btn_AtoN_23);
            this.tPVtoN.Controls.Add(this.btn_AtoN_22);
            this.tPVtoN.Controls.Add(this.btn_AtoN_21);
            this.tPVtoN.Controls.Add(this.btn_AtoN_20);
            this.tPVtoN.Controls.Add(this.btn_AtoN_19);
            this.tPVtoN.Controls.Add(this.btn_AtoN_18);
            this.tPVtoN.Controls.Add(this.btn_AtoN_17);
            this.tPVtoN.Controls.Add(this.btn_AtoN_16);
            this.tPVtoN.Controls.Add(this.btn_AtoN_15);
            this.tPVtoN.Controls.Add(this.btn_AtoN_14);
            this.tPVtoN.Controls.Add(this.btn_AtoN_13);
            this.tPVtoN.Controls.Add(this.btn_AtoN_12);
            this.tPVtoN.Controls.Add(this.btn_AtoN_11);
            this.tPVtoN.Controls.Add(this.btn_AtoN_10);
            this.tPVtoN.Controls.Add(this.btn_AtoN_9);
            this.tPVtoN.Controls.Add(this.btn_AtoN_8);
            this.tPVtoN.Controls.Add(this.btn_AtoN_7);
            this.tPVtoN.Controls.Add(this.btn_AtoN_6);
            this.tPVtoN.Controls.Add(this.btn_AtoN_5);
            this.tPVtoN.Controls.Add(this.btn_AtoN_4);
            this.tPVtoN.Controls.Add(this.btn_AtoN_3);
            this.tPVtoN.Controls.Add(this.btn_AtoN_2);
            this.tPVtoN.Controls.Add(this.label13);
            this.tPVtoN.Location = new System.Drawing.Point(4, 26);
            this.tPVtoN.Name = "tPVtoN";
            this.tPVtoN.Size = new System.Drawing.Size(653, 451);
            this.tPVtoN.TabIndex = 5;
            this.tPVtoN.Text = "虚拟航标管理";
            this.tPVtoN.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_1
            // 
            this.btn_AtoN_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_1.Location = new System.Drawing.Point(14, 44);
            this.btn_AtoN_1.Name = "btn_AtoN_1";
            this.btn_AtoN_1.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_1.TabIndex = 94;
            this.btn_AtoN_1.Text = "1";
            this.btn_AtoN_1.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.Transparent;
            this.groupBox17.Controls.Add(this.pAtoN);
            this.groupBox17.Controls.Add(this.ckb_AtoN_Enable);
            this.groupBox17.Location = new System.Drawing.Point(14, 130);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(606, 310);
            this.groupBox17.TabIndex = 93;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = " 虚拟航标配置参数";
            // 
            // pAtoN
            // 
            this.pAtoN.Controls.Add(this.label132);
            this.pAtoN.Controls.Add(this.txt_ATN_StartSlotChA);
            this.pAtoN.Controls.Add(this.groupBox19);
            this.pAtoN.Controls.Add(this.groupBox18);
            this.pAtoN.Controls.Add(this.ckb_ATN_SingedMode);
            this.pAtoN.Controls.Add(this.ckb_ATN_RAIM_Flag);
            this.pAtoN.Controls.Add(this.ckb_ATN_OffPos);
            this.pAtoN.Controls.Add(this.ckb_ATN_PosAccuray);
            this.pAtoN.Controls.Add(this.ckb_AtoN_VirtualATN);
            this.pAtoN.Controls.Add(this.txt_ATN_UpdateTime);
            this.pAtoN.Controls.Add(this.label100);
            this.pAtoN.Controls.Add(this.label101);
            this.pAtoN.Controls.Add(this.txt_AtoN_TimeStamp);
            this.pAtoN.Controls.Add(this.txt_AtoN_SendIntervalChA);
            this.pAtoN.Controls.Add(this.label102);
            this.pAtoN.Controls.Add(this.cbx_AtoN_PosDeviceType);
            this.pAtoN.Controls.Add(this.label99);
            this.pAtoN.Controls.Add(this.label98);
            this.pAtoN.Controls.Add(this.txt_AtoN_Name);
            this.pAtoN.Controls.Add(this.cbxAtoNType);
            this.pAtoN.Controls.Add(this.label14);
            this.pAtoN.Controls.Add(this.txt_AtoN_MMSI);
            this.pAtoN.Controls.Add(this.label97);
            this.pAtoN.Enabled = false;
            this.pAtoN.Location = new System.Drawing.Point(16, 40);
            this.pAtoN.Name = "pAtoN";
            this.pAtoN.Size = new System.Drawing.Size(574, 264);
            this.pAtoN.TabIndex = 18;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(13, 133);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(65, 12);
            this.label132.TabIndex = 39;
            this.label132.Text = "起始时隙：";
            // 
            // txt_ATN_StartSlotChA
            // 
            this.txt_ATN_StartSlotChA.Location = new System.Drawing.Point(81, 128);
            this.txt_ATN_StartSlotChA.MaxLength = 4;
            this.txt_ATN_StartSlotChA.Name = "txt_ATN_StartSlotChA";
            this.txt_ATN_StartSlotChA.Size = new System.Drawing.Size(43, 21);
            this.txt_ATN_StartSlotChA.TabIndex = 40;
            this.txt_ATN_StartSlotChA.TextChanged += new System.EventHandler(this.txtChStartSlot_TextChanged);
            this.txt_ATN_StartSlotChA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.pictureBox1);
            this.groupBox19.Controls.Add(this.label111);
            this.groupBox19.Controls.Add(this.label112);
            this.groupBox19.Controls.Add(this.label113);
            this.groupBox19.Controls.Add(this.label114);
            this.groupBox19.Controls.Add(this.label115);
            this.groupBox19.Controls.Add(this.txtSizeD);
            this.groupBox19.Controls.Add(this.label116);
            this.groupBox19.Controls.Add(this.txtSizeC);
            this.groupBox19.Controls.Add(this.label117);
            this.groupBox19.Controls.Add(this.txtSizeB);
            this.groupBox19.Controls.Add(this.label118);
            this.groupBox19.Controls.Add(this.txtSizeA);
            this.groupBox19.Location = new System.Drawing.Point(312, 108);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(255, 146);
            this.groupBox19.TabIndex = 38;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "尺寸信息";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(93, 116);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(17, 12);
            this.label111.TabIndex = 36;
            this.label111.Text = "米";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(93, 86);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(17, 12);
            this.label112.TabIndex = 35;
            this.label112.Text = "米";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(93, 52);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(17, 12);
            this.label113.TabIndex = 34;
            this.label113.Text = "米";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(93, 20);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(17, 12);
            this.label114.TabIndex = 33;
            this.label114.Text = "米";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(16, 117);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(11, 12);
            this.label115.TabIndex = 32;
            this.label115.Text = "D";
            // 
            // txtSizeD
            // 
            this.txtSizeD.Location = new System.Drawing.Point(41, 113);
            this.txtSizeD.MaxLength = 2;
            this.txtSizeD.Name = "txtSizeD";
            this.txtSizeD.Size = new System.Drawing.Size(46, 21);
            this.txtSizeD.TabIndex = 31;
            this.txtSizeD.Text = "0";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(16, 87);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(11, 12);
            this.label116.TabIndex = 30;
            this.label116.Text = "C";
            // 
            // txtSizeC
            // 
            this.txtSizeC.Location = new System.Drawing.Point(41, 81);
            this.txtSizeC.MaxLength = 2;
            this.txtSizeC.Name = "txtSizeC";
            this.txtSizeC.Size = new System.Drawing.Size(46, 21);
            this.txtSizeC.TabIndex = 29;
            this.txtSizeC.Text = "0";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(16, 53);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(11, 12);
            this.label117.TabIndex = 28;
            this.label117.Text = "B";
            // 
            // txtSizeB
            // 
            this.txtSizeB.Location = new System.Drawing.Point(41, 49);
            this.txtSizeB.MaxLength = 3;
            this.txtSizeB.Name = "txtSizeB";
            this.txtSizeB.Size = new System.Drawing.Size(46, 21);
            this.txtSizeB.TabIndex = 27;
            this.txtSizeB.Text = "0";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(16, 20);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(11, 12);
            this.label118.TabIndex = 26;
            this.label118.Text = "A";
            // 
            // txtSizeA
            // 
            this.txtSizeA.Location = new System.Drawing.Point(41, 17);
            this.txtSizeA.MaxLength = 3;
            this.txtSizeA.Name = "txtSizeA";
            this.txtSizeA.Size = new System.Drawing.Size(46, 21);
            this.txtSizeA.TabIndex = 25;
            this.txtSizeA.Text = "0";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.panel3);
            this.groupBox18.Location = new System.Drawing.Point(312, 3);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(255, 100);
            this.groupBox18.TabIndex = 37;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "定位";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckb_ATN_NS);
            this.panel3.Controls.Add(this.ckb_ATN_EW);
            this.panel3.Controls.Add(this.txt_ATN_LatSecond);
            this.panel3.Controls.Add(this.txt_ATN_LatFen);
            this.panel3.Controls.Add(this.label106);
            this.panel3.Controls.Add(this.txt_ATN_LatDu);
            this.panel3.Controls.Add(this.txt_ATN_LongSeconds);
            this.panel3.Controls.Add(this.label109);
            this.panel3.Controls.Add(this.txt_ATN_LongFen);
            this.panel3.Controls.Add(this.txt_ATN_LongDu);
            this.panel3.Controls.Add(this.label110);
            this.panel3.Controls.Add(this.label107);
            this.panel3.Controls.Add(this.label104);
            this.panel3.Controls.Add(this.label103);
            this.panel3.Controls.Add(this.label108);
            this.panel3.Controls.Add(this.label105);
            this.panel3.Location = new System.Drawing.Point(12, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 69);
            this.panel3.TabIndex = 36;
            // 
            // ckb_ATN_NS
            // 
            this.ckb_ATN_NS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ckb_ATN_NS.FormattingEnabled = true;
            this.ckb_ATN_NS.Items.AddRange(new object[] {
            "N",
            "S"});
            this.ckb_ATN_NS.Location = new System.Drawing.Point(179, 39);
            this.ckb_ATN_NS.Name = "ckb_ATN_NS";
            this.ckb_ATN_NS.Size = new System.Drawing.Size(39, 20);
            this.ckb_ATN_NS.TabIndex = 48;
            // 
            // ckb_ATN_EW
            // 
            this.ckb_ATN_EW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ckb_ATN_EW.FormattingEnabled = true;
            this.ckb_ATN_EW.Items.AddRange(new object[] {
            "E",
            "W"});
            this.ckb_ATN_EW.Location = new System.Drawing.Point(179, 11);
            this.ckb_ATN_EW.Name = "ckb_ATN_EW";
            this.ckb_ATN_EW.Size = new System.Drawing.Size(39, 20);
            this.ckb_ATN_EW.TabIndex = 47;
            // 
            // txt_ATN_LatSecond
            // 
            this.txt_ATN_LatSecond.Location = new System.Drawing.Point(132, 38);
            this.txt_ATN_LatSecond.MaxLength = 4;
            this.txt_ATN_LatSecond.Name = "txt_ATN_LatSecond";
            this.txt_ATN_LatSecond.Size = new System.Drawing.Size(36, 21);
            this.txt_ATN_LatSecond.TabIndex = 44;
            // 
            // txt_ATN_LatFen
            // 
            this.txt_ATN_LatFen.Location = new System.Drawing.Point(102, 37);
            this.txt_ATN_LatFen.MaxLength = 2;
            this.txt_ATN_LatFen.Name = "txt_ATN_LatFen";
            this.txt_ATN_LatFen.Size = new System.Drawing.Size(20, 21);
            this.txt_ATN_LatFen.TabIndex = 43;
            this.txt_ATN_LatFen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(7, 38);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(47, 12);
            this.label106.TabIndex = 42;
            this.label106.Text = "纬 度：";
            // 
            // txt_ATN_LatDu
            // 
            this.txt_ATN_LatDu.Location = new System.Drawing.Point(60, 36);
            this.txt_ATN_LatDu.MaxLength = 2;
            this.txt_ATN_LatDu.Name = "txt_ATN_LatDu";
            this.txt_ATN_LatDu.Size = new System.Drawing.Size(28, 21);
            this.txt_ATN_LatDu.TabIndex = 41;
            this.txt_ATN_LatDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ATN_LongSeconds
            // 
            this.txt_ATN_LongSeconds.Location = new System.Drawing.Point(132, 11);
            this.txt_ATN_LongSeconds.MaxLength = 4;
            this.txt_ATN_LongSeconds.Name = "txt_ATN_LongSeconds";
            this.txt_ATN_LongSeconds.Size = new System.Drawing.Size(36, 21);
            this.txt_ATN_LongSeconds.TabIndex = 39;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(85, 36);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(17, 12);
            this.label109.TabIndex = 45;
            this.label109.Text = "";
            // 
            // txt_ATN_LongFen
            // 
            this.txt_ATN_LongFen.Location = new System.Drawing.Point(102, 12);
            this.txt_ATN_LongFen.MaxLength = 2;
            this.txt_ATN_LongFen.Name = "txt_ATN_LongFen";
            this.txt_ATN_LongFen.Size = new System.Drawing.Size(20, 21);
            this.txt_ATN_LongFen.TabIndex = 38;
            this.txt_ATN_LongFen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ATN_LongDu
            // 
            this.txt_ATN_LongDu.Location = new System.Drawing.Point(60, 11);
            this.txt_ATN_LongDu.MaxLength = 3;
            this.txt_ATN_LongDu.Name = "txt_ATN_LongDu";
            this.txt_ATN_LongDu.Size = new System.Drawing.Size(28, 21);
            this.txt_ATN_LongDu.TabIndex = 36;
            this.txt_ATN_LongDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(7, 13);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(47, 12);
            this.label110.TabIndex = 37;
            this.label110.Text = "经 度：";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label107.Location = new System.Drawing.Point(122, 15);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(16, 16);
            this.label107.TabIndex = 49;
            this.label107.Text = ".";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(167, 11);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(17, 12);
            this.label104.TabIndex = 50;
            this.label104.Text = "＇";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(167, 38);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(17, 12);
            this.label103.TabIndex = 51;
            this.label103.Text = "＇";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(85, 11);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(17, 12);
            this.label108.TabIndex = 40;
            this.label108.Text = "";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label105.Location = new System.Drawing.Point(122, 39);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(16, 16);
            this.label105.TabIndex = 95;
            this.label105.Text = ".";
            // 
            // ckb_ATN_SingedMode
            // 
            this.ckb_ATN_SingedMode.AutoSize = true;
            this.ckb_ATN_SingedMode.Location = new System.Drawing.Point(158, 236);
            this.ckb_ATN_SingedMode.Name = "ckb_ATN_SingedMode";
            this.ckb_ATN_SingedMode.Size = new System.Drawing.Size(102, 16);
            this.ckb_ATN_SingedMode.TabIndex = 35;
            this.ckb_ATN_SingedMode.Text = " 分配模式使能";
            this.ckb_ATN_SingedMode.UseVisualStyleBackColor = true;
            // 
            // ckb_ATN_RAIM_Flag
            // 
            this.ckb_ATN_RAIM_Flag.AutoSize = true;
            this.ckb_ATN_RAIM_Flag.Location = new System.Drawing.Point(158, 209);
            this.ckb_ATN_RAIM_Flag.Name = "ckb_ATN_RAIM_Flag";
            this.ckb_ATN_RAIM_Flag.Size = new System.Drawing.Size(102, 16);
            this.ckb_ATN_RAIM_Flag.TabIndex = 34;
            this.ckb_ATN_RAIM_Flag.Text = " RAIM标志使能";
            this.ckb_ATN_RAIM_Flag.UseVisualStyleBackColor = true;
            // 
            // ckb_ATN_OffPos
            // 
            this.ckb_ATN_OffPos.AutoSize = true;
            this.ckb_ATN_OffPos.Location = new System.Drawing.Point(158, 182);
            this.ckb_ATN_OffPos.Name = "ckb_ATN_OffPos";
            this.ckb_ATN_OffPos.Size = new System.Drawing.Size(102, 16);
            this.ckb_ATN_OffPos.TabIndex = 33;
            this.ckb_ATN_OffPos.Text = " 偏置位置指示";
            this.ckb_ATN_OffPos.UseVisualStyleBackColor = true;
            // 
            // ckb_ATN_PosAccuray
            // 
            this.ckb_ATN_PosAccuray.AutoSize = true;
            this.ckb_ATN_PosAccuray.Location = new System.Drawing.Point(158, 155);
            this.ckb_ATN_PosAccuray.Name = "ckb_ATN_PosAccuray";
            this.ckb_ATN_PosAccuray.Size = new System.Drawing.Size(90, 16);
            this.ckb_ATN_PosAccuray.TabIndex = 32;
            this.ckb_ATN_PosAccuray.Text = " 高精度使能";
            this.ckb_ATN_PosAccuray.UseVisualStyleBackColor = true;
            // 
            // ckb_AtoN_VirtualATN
            // 
            this.ckb_AtoN_VirtualATN.AutoSize = true;
            this.ckb_AtoN_VirtualATN.Location = new System.Drawing.Point(158, 128);
            this.ckb_AtoN_VirtualATN.Name = "ckb_AtoN_VirtualATN";
            this.ckb_AtoN_VirtualATN.Size = new System.Drawing.Size(102, 16);
            this.ckb_AtoN_VirtualATN.TabIndex = 31;
            this.ckb_AtoN_VirtualATN.Text = " 虚拟目标使能";
            this.ckb_AtoN_VirtualATN.UseVisualStyleBackColor = true;
            this.ckb_AtoN_VirtualATN.CheckedChanged += new System.EventHandler(this.ckb_AtoN_VirtualATN_CheckedChanged);
            // 
            // txt_ATN_UpdateTime
            // 
            this.txt_ATN_UpdateTime.Location = new System.Drawing.Point(81, 234);
            this.txt_ATN_UpdateTime.Name = "txt_ATN_UpdateTime";
            this.txt_ATN_UpdateTime.Size = new System.Drawing.Size(43, 21);
            this.txt_ATN_UpdateTime.TabIndex = 30;
            this.txt_ATN_UpdateTime.Text = "1";
            this.txt_ATN_UpdateTime.Visible = false;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(12, 237);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(65, 12);
            this.label100.TabIndex = 29;
            this.label100.Text = "更新时间：";
            this.label100.Visible = false;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(13, 166);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(65, 12);
            this.label101.TabIndex = 25;
            this.label101.Text = "报告间隔：";
            // 
            // txt_AtoN_TimeStamp
            // 
            this.txt_AtoN_TimeStamp.Location = new System.Drawing.Point(81, 197);
            this.txt_AtoN_TimeStamp.MaxLength = 2;
            this.txt_AtoN_TimeStamp.Name = "txt_AtoN_TimeStamp";
            this.txt_AtoN_TimeStamp.Size = new System.Drawing.Size(43, 21);
            this.txt_AtoN_TimeStamp.TabIndex = 28;
            this.txt_AtoN_TimeStamp.TextChanged += new System.EventHandler(this.txt_AtoN_TimeStamp_TextChanged);
            this.txt_AtoN_TimeStamp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txt_AtoN_SendIntervalChA
            // 
            this.txt_AtoN_SendIntervalChA.Location = new System.Drawing.Point(81, 163);
            this.txt_AtoN_SendIntervalChA.MaxLength = 3;
            this.txt_AtoN_SendIntervalChA.Name = "txt_AtoN_SendIntervalChA";
            this.txt_AtoN_SendIntervalChA.Size = new System.Drawing.Size(43, 21);
            this.txt_AtoN_SendIntervalChA.TabIndex = 26;
            this.txt_AtoN_SendIntervalChA.TextChanged += new System.EventHandler(this.txt_AtoN_SendIntervalChA_TextChanged);
            this.txt_AtoN_SendIntervalChA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(37, 200);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(41, 12);
            this.label102.TabIndex = 27;
            this.label102.Text = "时戳：";
            // 
            // cbx_AtoN_PosDeviceType
            // 
            this.cbx_AtoN_PosDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_AtoN_PosDeviceType.FormattingEnabled = true;
            this.cbx_AtoN_PosDeviceType.Items.AddRange(new object[] {
            "未定义",
            "GPS",
            "GLONASS",
            "GPS/GLONASS",
            "Loran-C",
            "Chayka",
            "Integr.Nav.Syst.",
            "Surveyed"});
            this.cbx_AtoN_PosDeviceType.Location = new System.Drawing.Point(80, 96);
            this.cbx_AtoN_PosDeviceType.Name = "cbx_AtoN_PosDeviceType";
            this.cbx_AtoN_PosDeviceType.Size = new System.Drawing.Size(165, 20);
            this.cbx_AtoN_PosDeviceType.TabIndex = 24;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(37, 99);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(41, 12);
            this.label99.TabIndex = 23;
            this.label99.Text = "EPFS：";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(37, 72);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(41, 12);
            this.label98.TabIndex = 21;
            this.label98.Text = "名称：";
            // 
            // txt_AtoN_Name
            // 
            this.txt_AtoN_Name.Location = new System.Drawing.Point(81, 69);
            this.txt_AtoN_Name.MaxLength = 34;
            this.txt_AtoN_Name.Name = "txt_AtoN_Name";
            this.txt_AtoN_Name.Size = new System.Drawing.Size(164, 21);
            this.txt_AtoN_Name.TabIndex = 22;
            this.txt_AtoN_Name.TextChanged += new System.EventHandler(this.txt_AtoN_Name_TextChanged);
            this.txt_AtoN_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AtoN_Name_KeyPress);
            // 
            // cbxAtoNType
            // 
            this.cbxAtoNType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtoNType.FormattingEnabled = true;
            this.cbxAtoNType.Items.AddRange(new object[] {
            " ",
            " 0 缺省",
            " 1 参考点",
            " 2 雷康 雷达信标",
            " 3 离岸构筑物",
            " 4 保留备用",
            " 5 全向灯-固定航标",
            " 6 扇形灯-固定航标",
            " 7 前导灯标-固定航标",
            " 8 后导灯标-固定航标",
            " 9 北方位标-固定航标",
            "10 东方位标-固定航标",
            "11 南方位标-固定航标",
            "12 西方位标-固定航标",
            "13 左侧标-固定航标",
            "14 右侧标-固定航标",
            "15 推荐航道左侧标-固定航标",
            "16 推荐航道右侧标-固定航标",
            "17 孤立危险物标-固定航标",
            "18 安全水域标-固定航标",
            "19 专用标-固定航标",
            "20 北方位标-浮动航标",
            "21 东方位标-浮动航标",
            "22 南方位标-浮动航标",
            "23 西方位标-浮动航标",
            "24 左侧标-浮动航标",
            "25 右侧标-浮动航标",
            "26 推荐航道左侧标-浮动航标",
            "27 推荐航道右侧标-浮动航标",
            "28 孤立危险物标-浮动航标",
            "29 安全水域标-浮动航标",
            "30 专用标-浮动航标",
            "31 灯船/大型浮标"});
            this.cbxAtoNType.Location = new System.Drawing.Point(80, 41);
            this.cbxAtoNType.Name = "cbxAtoNType";
            this.cbxAtoNType.Size = new System.Drawing.Size(211, 20);
            this.cbxAtoNType.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "MMSI：";
            // 
            // txt_AtoN_MMSI
            // 
            this.txt_AtoN_MMSI.Location = new System.Drawing.Point(80, 14);
            this.txt_AtoN_MMSI.MaxLength = 9;
            this.txt_AtoN_MMSI.Name = "txt_AtoN_MMSI";
            this.txt_AtoN_MMSI.Size = new System.Drawing.Size(100, 21);
            this.txt_AtoN_MMSI.TabIndex = 9;
            this.txt_AtoN_MMSI.TextChanged += new System.EventHandler(this.txt_MMSI_TextChanged);
            this.txt_AtoN_MMSI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(37, 44);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(41, 12);
            this.label97.TabIndex = 10;
            this.label97.Text = "类型：";
            // 
            // ckb_AtoN_Enable
            // 
            this.ckb_AtoN_Enable.AutoSize = true;
            this.ckb_AtoN_Enable.Location = new System.Drawing.Point(16, 21);
            this.ckb_AtoN_Enable.Name = "ckb_AtoN_Enable";
            this.ckb_AtoN_Enable.Size = new System.Drawing.Size(84, 16);
            this.ckb_AtoN_Enable.TabIndex = 17;
            this.ckb_AtoN_Enable.Text = " AtoN 使能";
            this.ckb_AtoN_Enable.UseVisualStyleBackColor = true;
            this.ckb_AtoN_Enable.CheckedChanged += new System.EventHandler(this.ckb_AtoN_Enable_CheckedChanged);
            // 
            // btn_AtoN_32
            // 
            this.btn_AtoN_32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_32.Location = new System.Drawing.Point(584, 85);
            this.btn_AtoN_32.Name = "btn_AtoN_32";
            this.btn_AtoN_32.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_32.TabIndex = 92;
            this.btn_AtoN_32.Text = "32";
            this.btn_AtoN_32.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_31
            // 
            this.btn_AtoN_31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_31.Location = new System.Drawing.Point(546, 85);
            this.btn_AtoN_31.Name = "btn_AtoN_31";
            this.btn_AtoN_31.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_31.TabIndex = 91;
            this.btn_AtoN_31.Text = "31";
            this.btn_AtoN_31.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_30
            // 
            this.btn_AtoN_30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_30.Location = new System.Drawing.Point(508, 85);
            this.btn_AtoN_30.Name = "btn_AtoN_30";
            this.btn_AtoN_30.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_30.TabIndex = 90;
            this.btn_AtoN_30.Text = "30";
            this.btn_AtoN_30.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_29
            // 
            this.btn_AtoN_29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_29.Location = new System.Drawing.Point(470, 85);
            this.btn_AtoN_29.Name = "btn_AtoN_29";
            this.btn_AtoN_29.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_29.TabIndex = 89;
            this.btn_AtoN_29.Text = "29";
            this.btn_AtoN_29.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_28
            // 
            this.btn_AtoN_28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_28.Location = new System.Drawing.Point(432, 85);
            this.btn_AtoN_28.Name = "btn_AtoN_28";
            this.btn_AtoN_28.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_28.TabIndex = 88;
            this.btn_AtoN_28.Text = "28";
            this.btn_AtoN_28.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_27
            // 
            this.btn_AtoN_27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_27.Location = new System.Drawing.Point(394, 85);
            this.btn_AtoN_27.Name = "btn_AtoN_27";
            this.btn_AtoN_27.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_27.TabIndex = 87;
            this.btn_AtoN_27.Text = "27";
            this.btn_AtoN_27.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_26
            // 
            this.btn_AtoN_26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_26.Location = new System.Drawing.Point(356, 85);
            this.btn_AtoN_26.Name = "btn_AtoN_26";
            this.btn_AtoN_26.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_26.TabIndex = 86;
            this.btn_AtoN_26.Text = "26";
            this.btn_AtoN_26.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_25
            // 
            this.btn_AtoN_25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_25.Location = new System.Drawing.Point(318, 85);
            this.btn_AtoN_25.Name = "btn_AtoN_25";
            this.btn_AtoN_25.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_25.TabIndex = 85;
            this.btn_AtoN_25.Text = "25";
            this.btn_AtoN_25.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_24
            // 
            this.btn_AtoN_24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_24.Location = new System.Drawing.Point(280, 85);
            this.btn_AtoN_24.Name = "btn_AtoN_24";
            this.btn_AtoN_24.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_24.TabIndex = 84;
            this.btn_AtoN_24.Text = "24";
            this.btn_AtoN_24.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_23
            // 
            this.btn_AtoN_23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_23.Location = new System.Drawing.Point(242, 85);
            this.btn_AtoN_23.Name = "btn_AtoN_23";
            this.btn_AtoN_23.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_23.TabIndex = 83;
            this.btn_AtoN_23.Text = "23";
            this.btn_AtoN_23.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_22
            // 
            this.btn_AtoN_22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_22.Location = new System.Drawing.Point(204, 85);
            this.btn_AtoN_22.Name = "btn_AtoN_22";
            this.btn_AtoN_22.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_22.TabIndex = 82;
            this.btn_AtoN_22.Text = "22";
            this.btn_AtoN_22.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_21
            // 
            this.btn_AtoN_21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_21.Location = new System.Drawing.Point(166, 85);
            this.btn_AtoN_21.Name = "btn_AtoN_21";
            this.btn_AtoN_21.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_21.TabIndex = 81;
            this.btn_AtoN_21.Text = "21";
            this.btn_AtoN_21.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_20
            // 
            this.btn_AtoN_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_20.Location = new System.Drawing.Point(128, 85);
            this.btn_AtoN_20.Name = "btn_AtoN_20";
            this.btn_AtoN_20.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_20.TabIndex = 80;
            this.btn_AtoN_20.Text = "20";
            this.btn_AtoN_20.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_19
            // 
            this.btn_AtoN_19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_19.Location = new System.Drawing.Point(90, 85);
            this.btn_AtoN_19.Name = "btn_AtoN_19";
            this.btn_AtoN_19.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_19.TabIndex = 79;
            this.btn_AtoN_19.Text = "19";
            this.btn_AtoN_19.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_18
            // 
            this.btn_AtoN_18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_18.Location = new System.Drawing.Point(52, 85);
            this.btn_AtoN_18.Name = "btn_AtoN_18";
            this.btn_AtoN_18.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_18.TabIndex = 78;
            this.btn_AtoN_18.Text = "18";
            this.btn_AtoN_18.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_17
            // 
            this.btn_AtoN_17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_17.Location = new System.Drawing.Point(14, 85);
            this.btn_AtoN_17.Name = "btn_AtoN_17";
            this.btn_AtoN_17.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_17.TabIndex = 77;
            this.btn_AtoN_17.Text = "17";
            this.btn_AtoN_17.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_16
            // 
            this.btn_AtoN_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_16.Location = new System.Drawing.Point(584, 44);
            this.btn_AtoN_16.Name = "btn_AtoN_16";
            this.btn_AtoN_16.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_16.TabIndex = 60;
            this.btn_AtoN_16.Text = "16";
            this.btn_AtoN_16.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_15
            // 
            this.btn_AtoN_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_15.Location = new System.Drawing.Point(546, 44);
            this.btn_AtoN_15.Name = "btn_AtoN_15";
            this.btn_AtoN_15.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_15.TabIndex = 59;
            this.btn_AtoN_15.Text = "15";
            this.btn_AtoN_15.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_14
            // 
            this.btn_AtoN_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_14.Location = new System.Drawing.Point(508, 44);
            this.btn_AtoN_14.Name = "btn_AtoN_14";
            this.btn_AtoN_14.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_14.TabIndex = 58;
            this.btn_AtoN_14.Text = "14";
            this.btn_AtoN_14.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_13
            // 
            this.btn_AtoN_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_13.Location = new System.Drawing.Point(470, 44);
            this.btn_AtoN_13.Name = "btn_AtoN_13";
            this.btn_AtoN_13.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_13.TabIndex = 57;
            this.btn_AtoN_13.Text = "13";
            this.btn_AtoN_13.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_12
            // 
            this.btn_AtoN_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_12.Location = new System.Drawing.Point(432, 44);
            this.btn_AtoN_12.Name = "btn_AtoN_12";
            this.btn_AtoN_12.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_12.TabIndex = 56;
            this.btn_AtoN_12.Text = "12";
            this.btn_AtoN_12.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_11
            // 
            this.btn_AtoN_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_11.Location = new System.Drawing.Point(394, 44);
            this.btn_AtoN_11.Name = "btn_AtoN_11";
            this.btn_AtoN_11.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_11.TabIndex = 55;
            this.btn_AtoN_11.Text = "11";
            this.btn_AtoN_11.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_10
            // 
            this.btn_AtoN_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_10.Location = new System.Drawing.Point(356, 44);
            this.btn_AtoN_10.Name = "btn_AtoN_10";
            this.btn_AtoN_10.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_10.TabIndex = 54;
            this.btn_AtoN_10.Text = "10";
            this.btn_AtoN_10.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_9
            // 
            this.btn_AtoN_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_9.Location = new System.Drawing.Point(318, 44);
            this.btn_AtoN_9.Name = "btn_AtoN_9";
            this.btn_AtoN_9.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_9.TabIndex = 53;
            this.btn_AtoN_9.Text = "9";
            this.btn_AtoN_9.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_8
            // 
            this.btn_AtoN_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_8.Location = new System.Drawing.Point(280, 44);
            this.btn_AtoN_8.Name = "btn_AtoN_8";
            this.btn_AtoN_8.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_8.TabIndex = 52;
            this.btn_AtoN_8.Text = "8";
            this.btn_AtoN_8.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_7
            // 
            this.btn_AtoN_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_7.Location = new System.Drawing.Point(242, 44);
            this.btn_AtoN_7.Name = "btn_AtoN_7";
            this.btn_AtoN_7.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_7.TabIndex = 51;
            this.btn_AtoN_7.Text = "7";
            this.btn_AtoN_7.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_6
            // 
            this.btn_AtoN_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_6.Location = new System.Drawing.Point(204, 44);
            this.btn_AtoN_6.Name = "btn_AtoN_6";
            this.btn_AtoN_6.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_6.TabIndex = 50;
            this.btn_AtoN_6.Text = "6";
            this.btn_AtoN_6.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_5
            // 
            this.btn_AtoN_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_5.Location = new System.Drawing.Point(166, 44);
            this.btn_AtoN_5.Name = "btn_AtoN_5";
            this.btn_AtoN_5.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_5.TabIndex = 49;
            this.btn_AtoN_5.Text = "5";
            this.btn_AtoN_5.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_4
            // 
            this.btn_AtoN_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_4.Location = new System.Drawing.Point(128, 44);
            this.btn_AtoN_4.Name = "btn_AtoN_4";
            this.btn_AtoN_4.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_4.TabIndex = 48;
            this.btn_AtoN_4.Text = "4";
            this.btn_AtoN_4.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_3
            // 
            this.btn_AtoN_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_3.Location = new System.Drawing.Point(90, 44);
            this.btn_AtoN_3.Name = "btn_AtoN_3";
            this.btn_AtoN_3.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_3.TabIndex = 47;
            this.btn_AtoN_3.Text = "3";
            this.btn_AtoN_3.UseVisualStyleBackColor = true;
            // 
            // btn_AtoN_2
            // 
            this.btn_AtoN_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtoN_2.Location = new System.Drawing.Point(52, 44);
            this.btn_AtoN_2.Name = "btn_AtoN_2";
            this.btn_AtoN_2.Size = new System.Drawing.Size(36, 36);
            this.btn_AtoN_2.TabIndex = 46;
            this.btn_AtoN_2.Text = "2";
            this.btn_AtoN_2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(18, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 21);
            this.label13.TabIndex = 44;
            this.label13.Text = "选择需要配置的虚拟航标：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 510);
            this.tabControl1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 557);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIS物理基站配置工具（V1.1）";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.TabControlALL.ResumeLayout(false);
            this.tPGeneral.ResumeLayout(false);
            this.groupBox_PosSr.ResumeLayout(false);
            this.groupBox_PosSr.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tPNet.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.gpNet0.ResumeLayout(false);
            this.gpNet0.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpWIFI.ResumeLayout(false);
            this.gpWIFI.PerformLayout();
            this.tPTimeSlot.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tPDLM.ResumeLayout(false);
            this.tPDLM.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tPGroupAssignment.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tPVtoN.ResumeLayout(false);
            this.tPVtoN.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.pAtoN.ResumeLayout(false);
            this.pAtoN.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnMode;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem 串口配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网口连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_DataMonitor;
        private System.Windows.Forms.Button btn_SetCMD;
        private System.Windows.Forms.Button btn_QueryCMD;
        private System.Windows.Forms.TabControl TabControlALL;
        private System.Windows.Forms.TabPage tPGeneral;
        private System.Windows.Forms.GroupBox groupBox_PosSr;
        private System.Windows.Forms.RadioButton radioButton_Ex_In;
        private System.Windows.Forms.RadioButton radioButton_Ex_Sur;
        private System.Windows.Forms.RadioButton radioButton_In_Ex;
        private System.Windows.Forms.RadioButton radioButton_In_Sur;
        private System.Windows.Forms.RadioButton radioButton_Ex;
        private System.Windows.Forms.RadioButton radioButton_In;
        private System.Windows.Forms.RadioButton radioButton_Sur;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckb_TxB_Powerlevel;
        private System.Windows.Forms.CheckBox ckb_TxA_Powerlevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ckb_TxB_Enable;
        private System.Windows.Forms.CheckBox ckb_TxA_Enable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TxB;
        private System.Windows.Forms.TextBox txt_RxB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TxA;
        private System.Windows.Forms.TextBox txt_RxA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckb_RATDMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ADSInterval;
        private System.Windows.Forms.TextBox txt_MMSI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RepeatIndicator;
        private System.Windows.Forms.TextBox txt_BaseNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MsgRetires;
        private System.Windows.Forms.TextBox txt_TalkerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbt_MTP_B;
        private System.Windows.Forms.RadioButton rbt_MTP_A;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxSN;
        private System.Windows.Forms.ComboBox cbxEW;
        private System.Windows.Forms.TextBox txtLatFen2;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLatDu;
        private System.Windows.Forms.TextBox txtLongFen2;
        private System.Windows.Forms.TextBox txtLongDu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.CheckBox ckbPosAccuary;
        private System.Windows.Forms.TabPage tPNet;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TabPage tPTimeSlot;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtChBSlotCounts17;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtChASlotCounts17;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ComboBox txtChBSlotInterval17;
        private System.Windows.Forms.ComboBox txtChASlotInterval17;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtChBStartSlot17;
        private System.Windows.Forms.TextBox txtChBStartTime17;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtChAStartSlot17;
        private System.Windows.Forms.TextBox txtChAStartTime17;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox txtChASlotInterval20;
        private System.Windows.Forms.ComboBox txtChBSlotInterval20;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtChBStartSlot20;
        private System.Windows.Forms.TextBox txtChBStartTime20;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtChAStartSlot20;
        private System.Windows.Forms.TextBox txtChAStartTime20;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox txtChASlotInterval23;
        private System.Windows.Forms.ComboBox txtChBSlotInterval23;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtChBStartSlot23;
        private System.Windows.Forms.TextBox txtChBStartTime23;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtChAStartSlot23;
        private System.Windows.Forms.TextBox txtChAStartTime23;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox txtChASlotInterval22;
        private System.Windows.Forms.ComboBox txtChBSlotInterval22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtChBStartSlot22;
        private System.Windows.Forms.TextBox txtChBStartTime22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtChAStartSlot22;
        private System.Windows.Forms.TextBox txtChAStartTime22;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox txtChBSlotInterval4;
        private System.Windows.Forms.ComboBox txtChASlotInterval4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtChBStartSlot4;
        private System.Windows.Forms.TextBox txtChBStartTime4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtChAStartSlot4;
        private System.Windows.Forms.TextBox txtChAStartTime4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tPDLM;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.ComboBox cbx_Incerment_ChB4;
        private System.Windows.Forms.TextBox txt_TimeOut_ChB4;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.ComboBox cbx_Owner_ChB4;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txt_SlotCounts_ChB4;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox txt_StartSlot_ChB4;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ComboBox cbx_Incerment_ChB3;
        private System.Windows.Forms.TextBox txt_TimeOut_ChB3;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.ComboBox cbx_Owner_ChB3;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox txt_SlotCounts_ChB3;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox txt_StartSlot_ChB3;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.ComboBox cbx_Incerment_ChB2;
        private System.Windows.Forms.TextBox txt_TimeOut_ChB2;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.ComboBox cbx_Owner_ChB2;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox txt_SlotCounts_ChB2;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox txt_StartSlot_ChB2;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.ComboBox cbx_Incerment_ChB1;
        private System.Windows.Forms.TextBox txt_TimeOut_ChB1;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.ComboBox cbx_Owner_ChB1;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TextBox txt_SlotCounts_ChB1;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox txt_StartSlot_ChB1;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.ComboBox cbxDLMIndex;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ComboBox cbx_Incerment_ChA4;
        private System.Windows.Forms.TextBox txt_TimeOut_ChA4;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.ComboBox cbx_Owner_ChA4;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox txt_SlotCounts_ChA4;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox txt_StartSlot_ChA4;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.ComboBox cbx_Incerment_ChA3;
        private System.Windows.Forms.TextBox txt_TimeOut_ChA3;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox cbx_Owner_ChA3;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox txt_SlotCounts_ChA3;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox txt_StartSlot_ChA3;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox cbx_Incerment_ChA2;
        private System.Windows.Forms.TextBox txt_TimeOut_ChA2;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox cbx_Owner_ChA2;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txt_SlotCounts_ChA2;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox txt_StartSlot_ChA2;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ComboBox cbx_Incerment_ChA1;
        private System.Windows.Forms.TextBox txt_TimeOut_ChA1;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ComboBox cbx_Owner_ChA1;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txt_SlotCounts_ChA1;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox txt_StartSlot_ChA1;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TabPage tPVtoN;
        private System.Windows.Forms.Button btn_AtoN_1;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Panel pAtoN;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.TextBox txt_ATN_StartSlotChA;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.TextBox txtSizeD;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TextBox txtSizeC;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox txtSizeB;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox txtSizeA;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ckb_ATN_NS;
        private System.Windows.Forms.ComboBox ckb_ATN_EW;
        private System.Windows.Forms.TextBox txt_ATN_LatSecond;
        private System.Windows.Forms.TextBox txt_ATN_LatFen;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.TextBox txt_ATN_LatDu;
        private System.Windows.Forms.TextBox txt_ATN_LongSeconds;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.TextBox txt_ATN_LongFen;
        private System.Windows.Forms.TextBox txt_ATN_LongDu;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.CheckBox ckb_ATN_SingedMode;
        private System.Windows.Forms.CheckBox ckb_ATN_RAIM_Flag;
        private System.Windows.Forms.CheckBox ckb_ATN_OffPos;
        private System.Windows.Forms.CheckBox ckb_ATN_PosAccuray;
        private System.Windows.Forms.CheckBox ckb_AtoN_VirtualATN;
        private System.Windows.Forms.TextBox txt_ATN_UpdateTime;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox txt_AtoN_TimeStamp;
        private System.Windows.Forms.TextBox txt_AtoN_SendIntervalChA;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.ComboBox cbx_AtoN_PosDeviceType;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.TextBox txt_AtoN_Name;
        private System.Windows.Forms.ComboBox cbxAtoNType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_AtoN_MMSI;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.CheckBox ckb_AtoN_Enable;
        private System.Windows.Forms.Button btn_AtoN_32;
        private System.Windows.Forms.Button btn_AtoN_31;
        private System.Windows.Forms.Button btn_AtoN_30;
        private System.Windows.Forms.Button btn_AtoN_29;
        private System.Windows.Forms.Button btn_AtoN_28;
        private System.Windows.Forms.Button btn_AtoN_27;
        private System.Windows.Forms.Button btn_AtoN_26;
        private System.Windows.Forms.Button btn_AtoN_25;
        private System.Windows.Forms.Button btn_AtoN_24;
        private System.Windows.Forms.Button btn_AtoN_23;
        private System.Windows.Forms.Button btn_AtoN_22;
        private System.Windows.Forms.Button btn_AtoN_21;
        private System.Windows.Forms.Button btn_AtoN_20;
        private System.Windows.Forms.Button btn_AtoN_19;
        private System.Windows.Forms.Button btn_AtoN_18;
        private System.Windows.Forms.Button btn_AtoN_17;
        private System.Windows.Forms.Button btn_AtoN_16;
        private System.Windows.Forms.Button btn_AtoN_15;
        private System.Windows.Forms.Button btn_AtoN_14;
        private System.Windows.Forms.Button btn_AtoN_13;
        private System.Windows.Forms.Button btn_AtoN_12;
        private System.Windows.Forms.Button btn_AtoN_11;
        private System.Windows.Forms.Button btn_AtoN_10;
        private System.Windows.Forms.Button btn_AtoN_9;
        private System.Windows.Forms.Button btn_AtoN_8;
        private System.Windows.Forms.Button btn_AtoN_7;
        private System.Windows.Forms.Button btn_AtoN_6;
        private System.Windows.Forms.Button btn_AtoN_5;
        private System.Windows.Forms.Button btn_AtoN_4;
        private System.Windows.Forms.Button btn_AtoN_3;
        private System.Windows.Forms.Button btn_AtoN_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tPGroupAssignment;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.CheckBox ckb_SNR;
        private System.Windows.Forms.CheckBox ckb_TimeOfMsgArrival;
        private System.Windows.Forms.CheckBox ckb_FisrtSlotNumForFirstRecvMsg;
        private System.Windows.Forms.CheckBox ckb_SingalStrength;
        private System.Windows.Forms.CheckBox ckb_VSI4VDO;
        private System.Windows.Forms.CheckBox ckb_VSI4VDM;
        private System.Windows.Forms.ComboBox cbx_SPO_Channel;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox ckb_RecvSingalStrength;
        private System.Windows.Forms.CheckBox ckb_AverageNoiseLevel;
        private System.Windows.Forms.CheckBox ckb_ForecastCHLoad;
        private System.Windows.Forms.CheckBox ckb_NumOfBadCRC;
        private System.Windows.Forms.CheckBox ckb_PreFrameCHLoad;
        private System.Windows.Forms.CheckBox ckb_ProFSRSens;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLocalCFGPort;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox txtLocalDataPort;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.GroupBox gpWIFI;
        private System.Windows.Forms.TextBox txtDesPort_0;
        private System.Windows.Forms.Label label122;
        private IPAddressTextBox txtAddr_IP_0;
        private IPAddressTextBox txtAddr_IP_3;
        private IPAddressTextBox txtAddr_IP_2;
        private IPAddressTextBox txtAddr_IP_1;
        private System.Windows.Forms.TextBox txtDesPort_3;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.TextBox txtDesPort_2;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.TextBox txtDesPort_1;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.GroupBox gpNet0;
        private IPAddressTextBox txtWired_Gateway;
        private IPAddressTextBox txtWired_SubNetMask;
        private IPAddressTextBox txtWired_IP;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.TextBox txtWired_MAC;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.TextBox txtLatFen1;
        private System.Windows.Forms.TextBox txtLongFen1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.TextBox txtLocalPort_3;
        private System.Windows.Forms.TextBox txtLocalPort_2;
        private System.Windows.Forms.TextBox txtLocalPort_1;
        private System.Windows.Forms.TextBox txtLocalPort_0;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label105;
    }
}

