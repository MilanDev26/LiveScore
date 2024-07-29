
namespace LiveScore
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnNotStarted = new System.Windows.Forms.Button();
            this.BtnFinished = new System.Windows.Forms.Button();
            this.BtnLive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLeagueDetail = new System.Windows.Forms.Button();
            this.BtnLeague = new System.Windows.Forms.Button();
            this.BtnStartEvent = new System.Windows.Forms.Button();
            this.BtnNotAuto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PickerMatchDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHide = new System.Windows.Forms.Button();
            this.BtnViewSetting = new System.Windows.Forms.Button();
            this.LeagueTimer = new System.Windows.Forms.Timer(this.components);
            this.GetMatchTimer = new System.Windows.Forms.Timer(this.components);
            this.GetMatchOnLiveStartEventTimer = new System.Windows.Forms.Timer(this.components);
            this.GetMatchOnLiveByLeaguetimer = new System.Windows.Forms.Timer(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnResize = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FLPanelShowLiveMatchByTime = new LiveScore.MyFlowLayoutPanel();
            this.FLPanelRight = new LiveScore.MyFlowLayoutPanel();
            this.FLPanelLeft = new LiveScore.MyFlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.BtnAll, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnNotStarted, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnFinished, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnLive, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 17);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(301, 34);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // BtnAll
            // 
            this.BtnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAll.Location = new System.Drawing.Point(2, 1);
            this.BtnAll.Margin = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(72, 32);
            this.BtnAll.TabIndex = 0;
            this.BtnAll.Text = "Tutti";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnNotStarted
            // 
            this.BtnNotStarted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotStarted.Location = new System.Drawing.Point(226, 1);
            this.BtnNotStarted.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNotStarted.Name = "BtnNotStarted";
            this.BtnNotStarted.Size = new System.Drawing.Size(74, 32);
            this.BtnNotStarted.TabIndex = 3;
            this.BtnNotStarted.Text = "Non Iniziati";
            this.BtnNotStarted.UseVisualStyleBackColor = true;
            this.BtnNotStarted.Click += new System.EventHandler(this.BtnNotStarted_Click);
            // 
            // BtnFinished
            // 
            this.BtnFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinished.Location = new System.Drawing.Point(151, 1);
            this.BtnFinished.Margin = new System.Windows.Forms.Padding(1);
            this.BtnFinished.Name = "BtnFinished";
            this.BtnFinished.Size = new System.Drawing.Size(73, 32);
            this.BtnFinished.TabIndex = 2;
            this.BtnFinished.Text = "Terminati";
            this.BtnFinished.UseVisualStyleBackColor = true;
            this.BtnFinished.Click += new System.EventHandler(this.BtnFinished_Click);
            // 
            // BtnLive
            // 
            this.BtnLive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLive.Location = new System.Drawing.Point(76, 1);
            this.BtnLive.Margin = new System.Windows.Forms.Padding(1);
            this.BtnLive.Name = "BtnLive";
            this.BtnLive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLive.Size = new System.Drawing.Size(73, 32);
            this.BtnLive.TabIndex = 1;
            this.BtnLive.Text = "Live";
            this.BtnLive.UseVisualStyleBackColor = true;
            this.BtnLive.Click += new System.EventHandler(this.BtnLive_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtro sugli Eventi";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(313, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.BtnLeagueDetail, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnLeague, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnStartEvent, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnNotAuto, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 17);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(380, 33);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // BtnLeagueDetail
            // 
            this.BtnLeagueDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLeagueDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeagueDetail.Location = new System.Drawing.Point(0, 0);
            this.BtnLeagueDetail.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLeagueDetail.Name = "BtnLeagueDetail";
            this.BtnLeagueDetail.Size = new System.Drawing.Size(95, 33);
            this.BtnLeagueDetail.TabIndex = 0;
            this.BtnLeagueDetail.Text = "Camp. Dettaglio";
            this.BtnLeagueDetail.UseVisualStyleBackColor = true;
            this.BtnLeagueDetail.Click += new System.EventHandler(this.BtnLeagueDetail_Click);
            // 
            // BtnLeague
            // 
            this.BtnLeague.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeague.Location = new System.Drawing.Point(95, 0);
            this.BtnLeague.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLeague.Name = "BtnLeague";
            this.BtnLeague.Size = new System.Drawing.Size(95, 33);
            this.BtnLeague.TabIndex = 1;
            this.BtnLeague.Text = "x Campionato";
            this.BtnLeague.UseVisualStyleBackColor = true;
            this.BtnLeague.Click += new System.EventHandler(this.BtnLeague_Click);
            // 
            // BtnStartEvent
            // 
            this.BtnStartEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStartEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartEvent.Location = new System.Drawing.Point(190, 0);
            this.BtnStartEvent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStartEvent.Name = "BtnStartEvent";
            this.BtnStartEvent.Size = new System.Drawing.Size(95, 33);
            this.BtnStartEvent.TabIndex = 2;
            this.BtnStartEvent.Text = "x Orario";
            this.BtnStartEvent.UseVisualStyleBackColor = true;
            this.BtnStartEvent.Click += new System.EventHandler(this.BtnStartEvent_Click);
            // 
            // BtnNotAuto
            // 
            this.BtnNotAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNotAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotAuto.Location = new System.Drawing.Point(285, 0);
            this.BtnNotAuto.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNotAuto.Name = "BtnNotAuto";
            this.BtnNotAuto.Size = new System.Drawing.Size(95, 33);
            this.BtnNotAuto.TabIndex = 3;
            this.BtnNotAuto.Text = "x Camp Fisso";
            this.BtnNotAuto.UseVisualStyleBackColor = true;
            this.BtnNotAuto.Click += new System.EventHandler(this.BtnNotAuto_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo di visualizzazione";
            // 
            // PickerMatchDate
            // 
            this.PickerMatchDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PickerMatchDate.CustomFormat = "YYYY.MM.DD";
            this.PickerMatchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickerMatchDate.Location = new System.Drawing.Point(2, 23);
            this.PickerMatchDate.Name = "PickerMatchDate";
            this.PickerMatchDate.ShowCheckBox = true;
            this.PickerMatchDate.Size = new System.Drawing.Size(179, 20);
            this.PickerMatchDate.TabIndex = 2;
            this.PickerMatchDate.ValueChanged += new System.EventHandler(this.PickerMatchDate_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.PickerMatchDate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(702, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 57);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleziona la data";
            // 
            // BtnSetting
            // 
            this.BtnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetting.Location = new System.Drawing.Point(6, 31);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(82, 26);
            this.BtnSetting.TabIndex = 5;
            this.BtnSetting.Text = "Campionati...";
            this.BtnSetting.UseVisualStyleBackColor = true;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(28, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(891, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "This is the banner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnHide
            // 
            this.BtnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHide.BackgroundImage")));
            this.BtnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHide.Location = new System.Drawing.Point(3, 3);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(19, 20);
            this.BtnHide.TabIndex = 8;
            this.BtnHide.UseVisualStyleBackColor = true;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // BtnViewSetting
            // 
            this.BtnViewSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViewSetting.Location = new System.Drawing.Point(6, 2);
            this.BtnViewSetting.Name = "BtnViewSetting";
            this.BtnViewSetting.Size = new System.Drawing.Size(82, 23);
            this.BtnViewSetting.TabIndex = 9;
            this.BtnViewSetting.Text = "Impostazioni";
            this.BtnViewSetting.UseVisualStyleBackColor = true;
            this.BtnViewSetting.Click += new System.EventHandler(this.BtnViewSetting_Click);
            // 
            // LeagueTimer
            // 
            this.LeagueTimer.Enabled = true;
            this.LeagueTimer.Interval = 5000;
            this.LeagueTimer.Tick += new System.EventHandler(this.LeagueTimer_Tick);
            // 
            // GetMatchTimer
            // 
            this.GetMatchTimer.Enabled = true;
            this.GetMatchTimer.Interval = 3000;
            this.GetMatchTimer.Tick += new System.EventHandler(this.GetMatchTimer_Tick);
            // 
            // GetMatchOnLiveStartEventTimer
            // 
            this.GetMatchOnLiveStartEventTimer.Interval = 5000;
            this.GetMatchOnLiveStartEventTimer.Tick += new System.EventHandler(this.GetMatchOnLiveStartEventTimer_Tick);
            // 
            // GetMatchOnLiveByLeaguetimer
            // 
            this.GetMatchOnLiveByLeaguetimer.Interval = 5000;
            this.GetMatchOnLiveByLeaguetimer.Tick += new System.EventHandler(this.GetMatchOnLiveByLeaguetimer_Tick);
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Location = new System.Drawing.Point(955, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(20, 20);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnResize
            // 
            this.BtnResize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnResize.BackgroundImage")));
            this.BtnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnResize.Location = new System.Drawing.Point(925, 3);
            this.BtnResize.Name = "BtnResize";
            this.BtnResize.Size = new System.Drawing.Size(20, 20);
            this.BtnResize.TabIndex = 11;
            this.BtnResize.UseVisualStyleBackColor = true;
            this.BtnResize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 63);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.BtnViewSetting);
            this.groupBox4.Controls.Add(this.BtnSetting);
            this.groupBox4.Location = new System.Drawing.Point(894, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 57);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Controls.Add(this.BtnHide, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClose, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnResize, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(986, 30);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.FLPanelRight, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.FLPanelLeft, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 101);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(986, 447);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // FLPanelShowLiveMatchByTime
            // 
            this.FLPanelShowLiveMatchByTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPanelShowLiveMatchByTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FLPanelShowLiveMatchByTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FLPanelShowLiveMatchByTime.Location = new System.Drawing.Point(7, 104);
            this.FLPanelShowLiveMatchByTime.Name = "FLPanelShowLiveMatchByTime";
            this.FLPanelShowLiveMatchByTime.Size = new System.Drawing.Size(983, 444);
            this.FLPanelShowLiveMatchByTime.TabIndex = 0;
            // 
            // FLPanelRight
            // 
            this.FLPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPanelRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FLPanelRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPanelRight.Location = new System.Drawing.Point(496, 3);
            this.FLPanelRight.Name = "FLPanelRight";
            this.FLPanelRight.Size = new System.Drawing.Size(487, 441);
            this.FLPanelRight.TabIndex = 6;
            this.FLPanelRight.WrapContents = false;
            // 
            // FLPanelLeft
            // 
            this.FLPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPanelLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FLPanelLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.FLPanelLeft.Name = "FLPanelLeft";
            this.FLPanelLeft.Size = new System.Drawing.Size(487, 441);
            this.FLPanelLeft.TabIndex = 6;
            this.FLPanelLeft.WrapContents = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 552);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.FLPanelShowLiveMatchByTime);
            this.Controls.Add(this.tableLayoutPanel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNotStarted;
        private System.Windows.Forms.Button BtnFinished;
        private System.Windows.Forms.Button BtnLive;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnLeagueDetail;
        private System.Windows.Forms.Button BtnStartEvent;
        private System.Windows.Forms.Button BtnLeague;
        private System.Windows.Forms.Button BtnNotAuto;
        private System.Windows.Forms.DateTimePicker PickerMatchDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHide;
        private System.Windows.Forms.Button BtnViewSetting;
        private System.Windows.Forms.Timer LeagueTimer;
        private System.Windows.Forms.Timer GetMatchTimer;
        private System.Windows.Forms.Timer GetMatchOnLiveStartEventTimer;
        private System.Windows.Forms.Timer GetMatchOnLiveByLeaguetimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnResize;
        private MyFlowLayoutPanel FLPanelLeft;
        private MyFlowLayoutPanel FLPanelRight;
        private MyFlowLayoutPanel FLPanelShowLiveMatchByTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}