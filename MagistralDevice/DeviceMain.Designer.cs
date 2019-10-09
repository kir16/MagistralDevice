namespace MagistralDevice
{
  partial class DeviceMain
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
      this.lbName = new System.Windows.Forms.Label();
      this.tbName = new System.Windows.Forms.TextBox();
      this.lbSerial = new System.Windows.Forms.Label();
      this.tbSerial = new System.Windows.Forms.TextBox();
      this.lbVersion = new System.Windows.Forms.Label();
      this.tbVersion = new System.Windows.Forms.TextBox();
      this.gbAttributes = new System.Windows.Forms.GroupBox();
      this.btStartStop = new System.Windows.Forms.Button();
      this.gbParameters = new System.Windows.Forms.GroupBox();
      this.tcParameters = new System.Windows.Forms.TabControl();
      this.tpSysParams = new System.Windows.Forms.TabPage();
      this.tlpSysParams = new System.Windows.Forms.TableLayoutPanel();
      this.lbSysBool = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tsSysBool = new System.Windows.Forms.ToolStrip();
      this.tsbSysBoolAdd = new System.Windows.Forms.ToolStripButton();
      this.tsbSysBoolDelete = new System.Windows.Forms.ToolStripButton();
      this.tsSysInt = new System.Windows.Forms.ToolStrip();
      this.tsbSysIntAdd = new System.Windows.Forms.ToolStripButton();
      this.tsbSysIntDelete = new System.Windows.Forms.ToolStripButton();
      this.tlpSysBoolValues = new System.Windows.Forms.TableLayoutPanel();
      this.tlpSysIntValues = new System.Windows.Forms.TableLayoutPanel();
      this.tpUserParams = new System.Windows.Forms.TabPage();
      this.tlpUserParams = new System.Windows.Forms.TableLayoutPanel();
      this.lbUserInt = new System.Windows.Forms.Label();
      this.lbUserBool = new System.Windows.Forms.Label();
      this.tsUserBool = new System.Windows.Forms.ToolStrip();
      this.tsbUserBoolAdd = new System.Windows.Forms.ToolStripButton();
      this.tsbUserBoolDelete = new System.Windows.Forms.ToolStripButton();
      this.tsUserInt = new System.Windows.Forms.ToolStrip();
      this.tsbUserIntAdd = new System.Windows.Forms.ToolStripButton();
      this.tsbUserIntDelete = new System.Windows.Forms.ToolStripButton();
      this.tlpUserBoolValues = new System.Windows.Forms.TableLayoutPanel();
      this.tlpUserIntValues = new System.Windows.Forms.TableLayoutPanel();
      this.statusDeviceState = new System.Windows.Forms.StatusStrip();
      this.tsslDeviceState = new System.Windows.Forms.ToolStripStatusLabel();
      this.gbAttributes.SuspendLayout();
      this.gbParameters.SuspendLayout();
      this.tcParameters.SuspendLayout();
      this.tpSysParams.SuspendLayout();
      this.tlpSysParams.SuspendLayout();
      this.tsSysBool.SuspendLayout();
      this.tsSysInt.SuspendLayout();
      this.tpUserParams.SuspendLayout();
      this.tlpUserParams.SuspendLayout();
      this.tsUserBool.SuspendLayout();
      this.tsUserInt.SuspendLayout();
      this.statusDeviceState.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbName
      // 
      this.lbName.Location = new System.Drawing.Point(8, 16);
      this.lbName.Name = "lbName";
      this.lbName.Size = new System.Drawing.Size(89, 20);
      this.lbName.TabIndex = 0;
      this.lbName.Text = "Имя устройства";
      this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbName
      // 
      this.tbName.Location = new System.Drawing.Point(98, 16);
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(160, 20);
      this.tbName.TabIndex = 1;
      this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
      // 
      // lbSerial
      // 
      this.lbSerial.Location = new System.Drawing.Point(266, 16);
      this.lbSerial.Name = "lbSerial";
      this.lbSerial.Size = new System.Drawing.Size(93, 20);
      this.lbSerial.TabIndex = 2;
      this.lbSerial.Text = "Серийный номер";
      this.lbSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbSerial
      // 
      this.tbSerial.Location = new System.Drawing.Point(362, 16);
      this.tbSerial.Name = "tbSerial";
      this.tbSerial.Size = new System.Drawing.Size(120, 20);
      this.tbSerial.TabIndex = 3;
      this.tbSerial.Leave += new System.EventHandler(this.tbSerial_Leave);
      // 
      // lbVersion
      // 
      this.lbVersion.Location = new System.Drawing.Point(490, 16);
      this.lbVersion.Name = "lbVersion";
      this.lbVersion.Size = new System.Drawing.Size(44, 20);
      this.lbVersion.TabIndex = 4;
      this.lbVersion.Text = "Версия";
      this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbVersion
      // 
      this.tbVersion.Location = new System.Drawing.Point(535, 16);
      this.tbVersion.Name = "tbVersion";
      this.tbVersion.Size = new System.Drawing.Size(100, 20);
      this.tbVersion.TabIndex = 5;
      this.tbVersion.Leave += new System.EventHandler(this.tbVersion_Leave);
      // 
      // gbAttributes
      // 
      this.gbAttributes.Controls.Add(this.tbVersion);
      this.gbAttributes.Controls.Add(this.lbName);
      this.gbAttributes.Controls.Add(this.lbVersion);
      this.gbAttributes.Controls.Add(this.tbName);
      this.gbAttributes.Controls.Add(this.tbSerial);
      this.gbAttributes.Controls.Add(this.lbSerial);
      this.gbAttributes.Location = new System.Drawing.Point(8, 8);
      this.gbAttributes.Name = "gbAttributes";
      this.gbAttributes.Size = new System.Drawing.Size(651, 46);
      this.gbAttributes.TabIndex = 6;
      this.gbAttributes.TabStop = false;
      this.gbAttributes.Text = "Реквизиты устройства";
      // 
      // btStartStop
      // 
      this.btStartStop.Location = new System.Drawing.Point(668, 24);
      this.btStartStop.Name = "btStartStop";
      this.btStartStop.Size = new System.Drawing.Size(75, 23);
      this.btStartStop.TabIndex = 7;
      this.btStartStop.Text = "Запустить";
      this.btStartStop.UseVisualStyleBackColor = true;
      this.btStartStop.Click += new System.EventHandler(this.btStartStop_Click);
      // 
      // gbParameters
      // 
      this.gbParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbParameters.Controls.Add(this.tcParameters);
      this.gbParameters.Location = new System.Drawing.Point(8, 62);
      this.gbParameters.Name = "gbParameters";
      this.gbParameters.Size = new System.Drawing.Size(735, 363);
      this.gbParameters.TabIndex = 8;
      this.gbParameters.TabStop = false;
      this.gbParameters.Text = "Параметры устройства";
      // 
      // tcParameters
      // 
      this.tcParameters.Controls.Add(this.tpSysParams);
      this.tcParameters.Controls.Add(this.tpUserParams);
      this.tcParameters.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tcParameters.Location = new System.Drawing.Point(3, 16);
      this.tcParameters.Name = "tcParameters";
      this.tcParameters.SelectedIndex = 0;
      this.tcParameters.Size = new System.Drawing.Size(729, 344);
      this.tcParameters.TabIndex = 1;
      // 
      // tpSysParams
      // 
      this.tpSysParams.BackColor = System.Drawing.SystemColors.Control;
      this.tpSysParams.Controls.Add(this.tlpSysParams);
      this.tpSysParams.Location = new System.Drawing.Point(4, 22);
      this.tpSysParams.Name = "tpSysParams";
      this.tpSysParams.Padding = new System.Windows.Forms.Padding(3);
      this.tpSysParams.Size = new System.Drawing.Size(721, 318);
      this.tpSysParams.TabIndex = 0;
      this.tpSysParams.Text = "Системные";
      // 
      // tlpSysParams
      // 
      this.tlpSysParams.ColumnCount = 2;
      this.tlpSysParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpSysParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpSysParams.Controls.Add(this.lbSysBool, 0, 0);
      this.tlpSysParams.Controls.Add(this.label1, 1, 0);
      this.tlpSysParams.Controls.Add(this.tsSysBool, 0, 1);
      this.tlpSysParams.Controls.Add(this.tsSysInt, 1, 1);
      this.tlpSysParams.Controls.Add(this.tlpSysBoolValues, 0, 2);
      this.tlpSysParams.Controls.Add(this.tlpSysIntValues, 1, 2);
      this.tlpSysParams.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpSysParams.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tlpSysParams.Location = new System.Drawing.Point(3, 3);
      this.tlpSysParams.Margin = new System.Windows.Forms.Padding(0);
      this.tlpSysParams.Name = "tlpSysParams";
      this.tlpSysParams.RowCount = 3;
      this.tlpSysParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpSysParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tlpSysParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpSysParams.Size = new System.Drawing.Size(715, 312);
      this.tlpSysParams.TabIndex = 0;
      // 
      // lbSysBool
      // 
      this.lbSysBool.AutoSize = true;
      this.lbSysBool.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbSysBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbSysBool.Location = new System.Drawing.Point(3, 0);
      this.lbSysBool.Name = "lbSysBool";
      this.lbSysBool.Size = new System.Drawing.Size(351, 20);
      this.lbSysBool.TabIndex = 0;
      this.lbSysBool.Text = "Логические";
      this.lbSysBool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(360, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(352, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Числовые";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tsSysBool
      // 
      this.tsSysBool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSysBoolAdd,
            this.tsbSysBoolDelete});
      this.tsSysBool.Location = new System.Drawing.Point(0, 20);
      this.tsSysBool.Name = "tsSysBool";
      this.tsSysBool.Size = new System.Drawing.Size(357, 23);
      this.tsSysBool.TabIndex = 2;
      this.tsSysBool.Text = "tsSysBool";
      // 
      // tsbSysBoolAdd
      // 
      this.tsbSysBoolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbSysBoolAdd.Image = global::MagistralDevice.Properties.Resources.Add;
      this.tsbSysBoolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbSysBoolAdd.Name = "tsbSysBoolAdd";
      this.tsbSysBoolAdd.Size = new System.Drawing.Size(23, 20);
      this.tsbSysBoolAdd.Text = "Добавить";
      this.tsbSysBoolAdd.Click += new System.EventHandler(this.tsbSysBoolAdd_Click);
      this.tsbSysBoolAdd.EnabledChanged += new System.EventHandler(this.tsbAdd_EnabledChanged);
      // 
      // tsbSysBoolDelete
      // 
      this.tsbSysBoolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbSysBoolDelete.Image = global::MagistralDevice.Properties.Resources.Del;
      this.tsbSysBoolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbSysBoolDelete.Name = "tsbSysBoolDelete";
      this.tsbSysBoolDelete.Size = new System.Drawing.Size(23, 20);
      this.tsbSysBoolDelete.Text = "Удалить";
      this.tsbSysBoolDelete.Click += new System.EventHandler(this.tsbSysBoolDelete_Click);
      this.tsbSysBoolDelete.EnabledChanged += new System.EventHandler(this.tsbDel_EnabledChanged);
      // 
      // tsSysInt
      // 
      this.tsSysInt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSysIntAdd,
            this.tsbSysIntDelete});
      this.tsSysInt.Location = new System.Drawing.Point(357, 20);
      this.tsSysInt.Name = "tsSysInt";
      this.tsSysInt.Size = new System.Drawing.Size(358, 23);
      this.tsSysInt.TabIndex = 3;
      this.tsSysInt.Text = "tsSysInt";
      // 
      // tsbSysIntAdd
      // 
      this.tsbSysIntAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbSysIntAdd.Image = global::MagistralDevice.Properties.Resources.Add;
      this.tsbSysIntAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbSysIntAdd.Name = "tsbSysIntAdd";
      this.tsbSysIntAdd.Size = new System.Drawing.Size(23, 20);
      this.tsbSysIntAdd.Text = "Добавить";
      this.tsbSysIntAdd.Click += new System.EventHandler(this.tsbSysIntAdd_Click);
      this.tsbSysIntAdd.EnabledChanged += new System.EventHandler(this.tsbAdd_EnabledChanged);
      // 
      // tsbSysIntDelete
      // 
      this.tsbSysIntDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbSysIntDelete.Image = global::MagistralDevice.Properties.Resources.Del;
      this.tsbSysIntDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbSysIntDelete.Name = "tsbSysIntDelete";
      this.tsbSysIntDelete.Size = new System.Drawing.Size(23, 20);
      this.tsbSysIntDelete.Text = "Удалить";
      this.tsbSysIntDelete.Click += new System.EventHandler(this.tsbSysIntDelete_Click);
      this.tsbSysIntDelete.EnabledChanged += new System.EventHandler(this.tsbDel_EnabledChanged);
      // 
      // tlpSysBoolValues
      // 
      this.tlpSysBoolValues.ColumnCount = 2;
      this.tlpSysBoolValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
      this.tlpSysBoolValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tlpSysBoolValues.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpSysBoolValues.Location = new System.Drawing.Point(3, 46);
      this.tlpSysBoolValues.Name = "tlpSysBoolValues";
      this.tlpSysBoolValues.RowCount = 2;
      this.tlpSysBoolValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tlpSysBoolValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpSysBoolValues.Size = new System.Drawing.Size(351, 263);
      this.tlpSysBoolValues.TabIndex = 4;
      // 
      // tlpSysIntValues
      // 
      this.tlpSysIntValues.ColumnCount = 2;
      this.tlpSysIntValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.tlpSysIntValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tlpSysIntValues.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpSysIntValues.Location = new System.Drawing.Point(360, 46);
      this.tlpSysIntValues.Name = "tlpSysIntValues";
      this.tlpSysIntValues.RowCount = 2;
      this.tlpSysIntValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tlpSysIntValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpSysIntValues.Size = new System.Drawing.Size(352, 263);
      this.tlpSysIntValues.TabIndex = 5;
      // 
      // tpUserParams
      // 
      this.tpUserParams.BackColor = System.Drawing.SystemColors.Control;
      this.tpUserParams.Controls.Add(this.tlpUserParams);
      this.tpUserParams.Location = new System.Drawing.Point(4, 22);
      this.tpUserParams.Name = "tpUserParams";
      this.tpUserParams.Padding = new System.Windows.Forms.Padding(3);
      this.tpUserParams.Size = new System.Drawing.Size(721, 318);
      this.tpUserParams.TabIndex = 1;
      this.tpUserParams.Text = "Пользовательские";
      // 
      // tlpUserParams
      // 
      this.tlpUserParams.ColumnCount = 2;
      this.tlpUserParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpUserParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpUserParams.Controls.Add(this.lbUserInt, 1, 0);
      this.tlpUserParams.Controls.Add(this.lbUserBool, 0, 0);
      this.tlpUserParams.Controls.Add(this.tsUserBool, 0, 1);
      this.tlpUserParams.Controls.Add(this.tsUserInt, 1, 1);
      this.tlpUserParams.Controls.Add(this.tlpUserBoolValues, 0, 2);
      this.tlpUserParams.Controls.Add(this.tlpUserIntValues, 1, 2);
      this.tlpUserParams.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpUserParams.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tlpUserParams.Location = new System.Drawing.Point(3, 3);
      this.tlpUserParams.Name = "tlpUserParams";
      this.tlpUserParams.RowCount = 3;
      this.tlpUserParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpUserParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tlpUserParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpUserParams.Size = new System.Drawing.Size(715, 312);
      this.tlpUserParams.TabIndex = 0;
      // 
      // lbUserInt
      // 
      this.lbUserInt.AutoSize = true;
      this.lbUserInt.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbUserInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbUserInt.Location = new System.Drawing.Point(360, 0);
      this.lbUserInt.Name = "lbUserInt";
      this.lbUserInt.Size = new System.Drawing.Size(352, 20);
      this.lbUserInt.TabIndex = 1;
      this.lbUserInt.Text = "Числовые";
      this.lbUserInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbUserBool
      // 
      this.lbUserBool.AutoSize = true;
      this.lbUserBool.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbUserBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbUserBool.Location = new System.Drawing.Point(3, 0);
      this.lbUserBool.Name = "lbUserBool";
      this.lbUserBool.Size = new System.Drawing.Size(351, 20);
      this.lbUserBool.TabIndex = 0;
      this.lbUserBool.Text = "Логические";
      this.lbUserBool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tsUserBool
      // 
      this.tsUserBool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUserBoolAdd,
            this.tsbUserBoolDelete});
      this.tsUserBool.Location = new System.Drawing.Point(0, 20);
      this.tsUserBool.Name = "tsUserBool";
      this.tsUserBool.Size = new System.Drawing.Size(357, 23);
      this.tsUserBool.TabIndex = 2;
      this.tsUserBool.Text = "tsUserBool";
      // 
      // tsbUserBoolAdd
      // 
      this.tsbUserBoolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbUserBoolAdd.Image = global::MagistralDevice.Properties.Resources.Add;
      this.tsbUserBoolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbUserBoolAdd.Name = "tsbUserBoolAdd";
      this.tsbUserBoolAdd.Size = new System.Drawing.Size(23, 20);
      this.tsbUserBoolAdd.Text = "Добавить";
      this.tsbUserBoolAdd.ToolTipText = "Добавить";
      this.tsbUserBoolAdd.Click += new System.EventHandler(this.tsbUserBoolAdd_Click);
      this.tsbUserBoolAdd.EnabledChanged += new System.EventHandler(this.tsbAdd_EnabledChanged);
      // 
      // tsbUserBoolDelete
      // 
      this.tsbUserBoolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbUserBoolDelete.Image = global::MagistralDevice.Properties.Resources.Del;
      this.tsbUserBoolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbUserBoolDelete.Name = "tsbUserBoolDelete";
      this.tsbUserBoolDelete.Size = new System.Drawing.Size(23, 20);
      this.tsbUserBoolDelete.Text = "Удалить";
      this.tsbUserBoolDelete.Click += new System.EventHandler(this.tsbUserBoolDelete_Click);
      this.tsbUserBoolDelete.EnabledChanged += new System.EventHandler(this.tsbDel_EnabledChanged);
      // 
      // tsUserInt
      // 
      this.tsUserInt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUserIntAdd,
            this.tsbUserIntDelete});
      this.tsUserInt.Location = new System.Drawing.Point(357, 20);
      this.tsUserInt.Name = "tsUserInt";
      this.tsUserInt.Size = new System.Drawing.Size(358, 23);
      this.tsUserInt.TabIndex = 3;
      this.tsUserInt.Text = "tsUserInt";
      // 
      // tsbUserIntAdd
      // 
      this.tsbUserIntAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbUserIntAdd.Image = global::MagistralDevice.Properties.Resources.Add;
      this.tsbUserIntAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbUserIntAdd.Name = "tsbUserIntAdd";
      this.tsbUserIntAdd.Size = new System.Drawing.Size(23, 20);
      this.tsbUserIntAdd.Text = "Добавить";
      this.tsbUserIntAdd.Click += new System.EventHandler(this.tsbUserIntAdd_Click);
      this.tsbUserIntAdd.EnabledChanged += new System.EventHandler(this.tsbAdd_EnabledChanged);
      // 
      // tsbUserIntDelete
      // 
      this.tsbUserIntDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbUserIntDelete.Image = global::MagistralDevice.Properties.Resources.Del;
      this.tsbUserIntDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbUserIntDelete.Name = "tsbUserIntDelete";
      this.tsbUserIntDelete.Size = new System.Drawing.Size(23, 20);
      this.tsbUserIntDelete.Text = "Удалить";
      this.tsbUserIntDelete.Click += new System.EventHandler(this.tsbUserIntDelete_Click);
      this.tsbUserIntDelete.EnabledChanged += new System.EventHandler(this.tsbDel_EnabledChanged);
      // 
      // tlpUserBoolValues
      // 
      this.tlpUserBoolValues.ColumnCount = 2;
      this.tlpUserBoolValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
      this.tlpUserBoolValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tlpUserBoolValues.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpUserBoolValues.Location = new System.Drawing.Point(3, 46);
      this.tlpUserBoolValues.Name = "tlpUserBoolValues";
      this.tlpUserBoolValues.RowCount = 2;
      this.tlpUserBoolValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tlpUserBoolValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpUserBoolValues.Size = new System.Drawing.Size(351, 263);
      this.tlpUserBoolValues.TabIndex = 4;
      // 
      // tlpUserIntValues
      // 
      this.tlpUserIntValues.ColumnCount = 2;
      this.tlpUserIntValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.tlpUserIntValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tlpUserIntValues.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpUserIntValues.Location = new System.Drawing.Point(360, 46);
      this.tlpUserIntValues.Name = "tlpUserIntValues";
      this.tlpUserIntValues.RowCount = 2;
      this.tlpUserIntValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tlpUserIntValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpUserIntValues.Size = new System.Drawing.Size(352, 263);
      this.tlpUserIntValues.TabIndex = 5;
      // 
      // statusDeviceState
      // 
      this.statusDeviceState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDeviceState});
      this.statusDeviceState.Location = new System.Drawing.Point(0, 428);
      this.statusDeviceState.Name = "statusDeviceState";
      this.statusDeviceState.Size = new System.Drawing.Size(751, 22);
      this.statusDeviceState.TabIndex = 9;
      this.statusDeviceState.Text = "statusStrip1";
      // 
      // tsslDeviceState
      // 
      this.tsslDeviceState.AutoSize = false;
      this.tsslDeviceState.Name = "tsslDeviceState";
      this.tsslDeviceState.Size = new System.Drawing.Size(500, 17);
      this.tsslDeviceState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // DeviceMain
      // 
      this.ClientSize = new System.Drawing.Size(751, 450);
      this.Controls.Add(this.statusDeviceState);
      this.Controls.Add(this.gbParameters);
      this.Controls.Add(this.btStartStop);
      this.Controls.Add(this.gbAttributes);
      this.Name = "DeviceMain";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceMain_FormClosing);
      this.Load += new System.EventHandler(this.DeviceMain_Load);
      this.gbAttributes.ResumeLayout(false);
      this.gbAttributes.PerformLayout();
      this.gbParameters.ResumeLayout(false);
      this.tcParameters.ResumeLayout(false);
      this.tpSysParams.ResumeLayout(false);
      this.tlpSysParams.ResumeLayout(false);
      this.tlpSysParams.PerformLayout();
      this.tsSysBool.ResumeLayout(false);
      this.tsSysBool.PerformLayout();
      this.tsSysInt.ResumeLayout(false);
      this.tsSysInt.PerformLayout();
      this.tpUserParams.ResumeLayout(false);
      this.tlpUserParams.ResumeLayout(false);
      this.tlpUserParams.PerformLayout();
      this.tsUserBool.ResumeLayout(false);
      this.tsUserBool.PerformLayout();
      this.tsUserInt.ResumeLayout(false);
      this.tsUserInt.PerformLayout();
      this.statusDeviceState.ResumeLayout(false);
      this.statusDeviceState.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbName;
    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.Label lbSerial;
    private System.Windows.Forms.TextBox tbSerial;
    private System.Windows.Forms.Label lbVersion;
    private System.Windows.Forms.TextBox tbVersion;
    private System.Windows.Forms.GroupBox gbAttributes;
    private System.Windows.Forms.Button btStartStop;
    private System.Windows.Forms.GroupBox gbParameters;
    private System.Windows.Forms.StatusStrip statusDeviceState;
    private System.Windows.Forms.ToolStripStatusLabel tsslDeviceState;
    private System.Windows.Forms.TabControl tcParameters;
    private System.Windows.Forms.TabPage tpSysParams;
    private System.Windows.Forms.TabPage tpUserParams;
    private System.Windows.Forms.TableLayoutPanel tlpSysParams;
    private System.Windows.Forms.TableLayoutPanel tlpUserParams;
    private System.Windows.Forms.Label lbSysBool;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStrip tsSysBool;
    private System.Windows.Forms.ToolStripButton tsbSysBoolAdd;
    private System.Windows.Forms.ToolStripButton tsbSysBoolDelete;
    private System.Windows.Forms.ToolStrip tsSysInt;
    private System.Windows.Forms.ToolStripButton tsbSysIntAdd;
    private System.Windows.Forms.ToolStripButton tsbSysIntDelete;
    private System.Windows.Forms.TableLayoutPanel tlpSysBoolValues;
    private System.Windows.Forms.TableLayoutPanel tlpSysIntValues;
    private System.Windows.Forms.Label lbUserInt;
    private System.Windows.Forms.Label lbUserBool;
    private System.Windows.Forms.ToolStrip tsUserBool;
    private System.Windows.Forms.ToolStripButton tsbUserBoolAdd;
    private System.Windows.Forms.ToolStripButton tsbUserBoolDelete;
    private System.Windows.Forms.ToolStrip tsUserInt;
    private System.Windows.Forms.ToolStripButton tsbUserIntAdd;
    private System.Windows.Forms.ToolStripButton tsbUserIntDelete;
    private System.Windows.Forms.TableLayoutPanel tlpUserBoolValues;
    private System.Windows.Forms.TableLayoutPanel tlpUserIntValues;
  }
}

