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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceMain));
      this.lbName = new System.Windows.Forms.Label();
      this.tbName = new System.Windows.Forms.TextBox();
      this.lbSerial = new System.Windows.Forms.Label();
      this.tbSerial = new System.Windows.Forms.TextBox();
      this.lbVersion = new System.Windows.Forms.Label();
      this.tbVersion = new System.Windows.Forms.TextBox();
      this.gbAttributes = new System.Windows.Forms.GroupBox();
      this.btStartStop = new System.Windows.Forms.Button();
      this.gbParameters = new System.Windows.Forms.GroupBox();
      this.tstrParametersButtons = new System.Windows.Forms.ToolStrip();
      this.tstbAddParameter = new System.Windows.Forms.ToolStripButton();
      this.tstbDeleteParameter = new System.Windows.Forms.ToolStripButton();
      this.statusDeviceState = new System.Windows.Forms.StatusStrip();
      this.tsslDeviceState = new System.Windows.Forms.ToolStripStatusLabel();
      this.gbAttributes.SuspendLayout();
      this.gbParameters.SuspendLayout();
      this.tstrParametersButtons.SuspendLayout();
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
      this.gbParameters.Controls.Add(this.tstrParametersButtons);
      this.gbParameters.Location = new System.Drawing.Point(8, 62);
      this.gbParameters.Name = "gbParameters";
      this.gbParameters.Size = new System.Drawing.Size(735, 363);
      this.gbParameters.TabIndex = 8;
      this.gbParameters.TabStop = false;
      this.gbParameters.Text = "Параметры устройства";
      // 
      // tstrParametersButtons
      // 
      this.tstrParametersButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbAddParameter,
            this.tstbDeleteParameter});
      this.tstrParametersButtons.Location = new System.Drawing.Point(3, 16);
      this.tstrParametersButtons.Name = "tstrParametersButtons";
      this.tstrParametersButtons.Size = new System.Drawing.Size(729, 25);
      this.tstrParametersButtons.TabIndex = 0;
      this.tstrParametersButtons.Text = "Управление списокм параметров";
      // 
      // tstbAddParameter
      // 
      this.tstbAddParameter.Image = global::MagistralDevice.Properties.Resources.Symbol_Add;
      this.tstbAddParameter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.tstbAddParameter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tstbAddParameter.Name = "tstbAddParameter";
      this.tstbAddParameter.Size = new System.Drawing.Size(79, 22);
      this.tstbAddParameter.Text = "Добавить";
      this.tstbAddParameter.EnabledChanged += new System.EventHandler(this.tstbAddParameter_EnabledChanged);
      // 
      // tstbDeleteParameter
      // 
      this.tstbDeleteParameter.Image = global::MagistralDevice.Properties.Resources.Symbol_Delete;
      this.tstbDeleteParameter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.tstbDeleteParameter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tstbDeleteParameter.Name = "tstbDeleteParameter";
      this.tstbDeleteParameter.Size = new System.Drawing.Size(71, 22);
      this.tstbDeleteParameter.Text = "Удалить";
      this.tstbDeleteParameter.EnabledChanged += new System.EventHandler(this.tstbDeleteParameter_EnabledChanged);
      // 
      // statusDeviceState
      // 
      this.statusDeviceState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDeviceState});
      this.statusDeviceState.Location = new System.Drawing.Point(0, 428);
      this.statusDeviceState.Name = "statusDeviceState";
      this.statusDeviceState.Size = new System.Drawing.Size(755, 22);
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
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(755, 450);
      this.Controls.Add(this.statusDeviceState);
      this.Controls.Add(this.gbParameters);
      this.Controls.Add(this.btStartStop);
      this.Controls.Add(this.gbAttributes);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DeviceMain";
      this.Text = "Эмулятор \"Магистраль\"";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceMain_FormClosing);
      this.Load += new System.EventHandler(this.DeviceMain_Load);
      this.Shown += new System.EventHandler(this.DeviceMain_Shown);
      this.gbAttributes.ResumeLayout(false);
      this.gbAttributes.PerformLayout();
      this.gbParameters.ResumeLayout(false);
      this.gbParameters.PerformLayout();
      this.tstrParametersButtons.ResumeLayout(false);
      this.tstrParametersButtons.PerformLayout();
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
    private System.Windows.Forms.ToolStrip tstrParametersButtons;
    private System.Windows.Forms.ToolStripButton tstbAddParameter;
    private System.Windows.Forms.ToolStripButton tstbDeleteParameter;
  }
}

