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
      this.tpUserParams = new System.Windows.Forms.TabPage();
      this.tlpUserParams = new System.Windows.Forms.TableLayoutPanel();
      this.statusDeviceState = new System.Windows.Forms.StatusStrip();
      this.tsslDeviceState = new System.Windows.Forms.ToolStripStatusLabel();
      this.gbAttributes.SuspendLayout();
      this.gbParameters.SuspendLayout();
      this.tcParameters.SuspendLayout();
      this.tpSysParams.SuspendLayout();
      this.tpUserParams.SuspendLayout();
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
      this.tlpSysParams.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpSysParams.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tlpSysParams.Location = new System.Drawing.Point(3, 3);
      this.tlpSysParams.Margin = new System.Windows.Forms.Padding(0);
      this.tlpSysParams.Name = "tlpSysParams";
      this.tlpSysParams.RowCount = 1;
      this.tlpSysParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpSysParams.Size = new System.Drawing.Size(715, 312);
      this.tlpSysParams.TabIndex = 0;
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
      this.tlpUserParams.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpUserParams.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tlpUserParams.Location = new System.Drawing.Point(3, 3);
      this.tlpUserParams.Name = "tlpUserParams";
      this.tlpUserParams.RowCount = 1;
      this.tlpUserParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpUserParams.Size = new System.Drawing.Size(715, 312);
      this.tlpUserParams.TabIndex = 0;
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
      this.tpUserParams.ResumeLayout(false);
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
  }
}

