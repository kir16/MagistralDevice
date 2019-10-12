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
      this.gbParameters = new System.Windows.Forms.GroupBox();
      this.tlpParameters = new System.Windows.Forms.TableLayoutPanel();
      this.lbParameterAccess = new System.Windows.Forms.Label();
      this.lbParameterType = new System.Windows.Forms.Label();
      this.lbParameterName = new System.Windows.Forms.Label();
      this.lbParameterValue = new System.Windows.Forms.Label();
      this.tsParametersCommands = new System.Windows.Forms.ToolStrip();
      this.tsbAddParameter = new System.Windows.Forms.ToolStripButton();
      this.tsbRemoveParameter = new System.Windows.Forms.ToolStripButton();
      this.statusDeviceState = new System.Windows.Forms.StatusStrip();
      this.tsslDeviceState = new System.Windows.Forms.ToolStripStatusLabel();
      this.sfdParameters = new System.Windows.Forms.SaveFileDialog();
      this.ofdParameters = new System.Windows.Forms.OpenFileDialog();
      this.tsMainCommands = new System.Windows.Forms.ToolStrip();
      this.tsbLoadConfig = new System.Windows.Forms.ToolStripButton();
      this.tsbSaveConfig = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbStartStopEmulation = new System.Windows.Forms.ToolStripButton();
      this.tbMessageLog = new System.Windows.Forms.TextBox();
      this.gbAttributes.SuspendLayout();
      this.gbParameters.SuspendLayout();
      this.tlpParameters.SuspendLayout();
      this.tsParametersCommands.SuspendLayout();
      this.statusDeviceState.SuspendLayout();
      this.tsMainCommands.SuspendLayout();
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
      this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbName.Location = new System.Drawing.Point(98, 16);
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(211, 20);
      this.tbName.TabIndex = 1;
      this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
      // 
      // lbSerial
      // 
      this.lbSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lbSerial.Location = new System.Drawing.Point(315, 16);
      this.lbSerial.Name = "lbSerial";
      this.lbSerial.Size = new System.Drawing.Size(93, 20);
      this.lbSerial.TabIndex = 2;
      this.lbSerial.Text = "Серийный номер";
      this.lbSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbSerial
      // 
      this.tbSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.tbSerial.Location = new System.Drawing.Point(411, 16);
      this.tbSerial.Name = "tbSerial";
      this.tbSerial.Size = new System.Drawing.Size(164, 20);
      this.tbSerial.TabIndex = 3;
      this.tbSerial.TextChanged += new System.EventHandler(this.tbSerial_TextChanged);
      // 
      // lbVersion
      // 
      this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lbVersion.Location = new System.Drawing.Point(576, 16);
      this.lbVersion.Name = "lbVersion";
      this.lbVersion.Size = new System.Drawing.Size(44, 20);
      this.lbVersion.TabIndex = 4;
      this.lbVersion.Text = "Версия";
      this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbVersion
      // 
      this.tbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.tbVersion.Location = new System.Drawing.Point(621, 16);
      this.tbVersion.Name = "tbVersion";
      this.tbVersion.Size = new System.Drawing.Size(100, 20);
      this.tbVersion.TabIndex = 5;
      this.tbVersion.TextChanged += new System.EventHandler(this.tbVersion_TextChanged);
      // 
      // gbAttributes
      // 
      this.gbAttributes.Controls.Add(this.tbVersion);
      this.gbAttributes.Controls.Add(this.lbName);
      this.gbAttributes.Controls.Add(this.lbVersion);
      this.gbAttributes.Controls.Add(this.tbName);
      this.gbAttributes.Controls.Add(this.tbSerial);
      this.gbAttributes.Controls.Add(this.lbSerial);
      this.gbAttributes.Location = new System.Drawing.Point(12, 29);
      this.gbAttributes.Name = "gbAttributes";
      this.gbAttributes.Size = new System.Drawing.Size(731, 46);
      this.gbAttributes.TabIndex = 6;
      this.gbAttributes.TabStop = false;
      this.gbAttributes.Text = "Реквизиты устройства";
      // 
      // gbParameters
      // 
      this.gbParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbParameters.Controls.Add(this.tlpParameters);
      this.gbParameters.Controls.Add(this.tsParametersCommands);
      this.gbParameters.Location = new System.Drawing.Point(12, 79);
      this.gbParameters.Name = "gbParameters";
      this.gbParameters.Size = new System.Drawing.Size(731, 334);
      this.gbParameters.TabIndex = 8;
      this.gbParameters.TabStop = false;
      this.gbParameters.Text = "Параметры устройства";
      // 
      // tlpParameters
      // 
      this.tlpParameters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tlpParameters.ColumnCount = 4;
      this.tlpParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.tlpParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tlpParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tlpParameters.Controls.Add(this.lbParameterAccess, 0, 0);
      this.tlpParameters.Controls.Add(this.lbParameterType, 1, 0);
      this.tlpParameters.Controls.Add(this.lbParameterName, 2, 0);
      this.tlpParameters.Controls.Add(this.lbParameterValue, 3, 0);
      this.tlpParameters.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpParameters.Location = new System.Drawing.Point(3, 41);
      this.tlpParameters.Name = "tlpParameters";
      this.tlpParameters.RowCount = 3;
      this.tlpParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
      this.tlpParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
      this.tlpParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpParameters.Size = new System.Drawing.Size(725, 290);
      this.tlpParameters.TabIndex = 1;
      // 
      // lbParameterAccess
      // 
      this.lbParameterAccess.AutoSize = true;
      this.lbParameterAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbParameterAccess.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbParameterAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbParameterAccess.Location = new System.Drawing.Point(1, 1);
      this.lbParameterAccess.Margin = new System.Windows.Forms.Padding(0);
      this.lbParameterAccess.Name = "lbParameterAccess";
      this.lbParameterAccess.Size = new System.Drawing.Size(55, 22);
      this.lbParameterAccess.TabIndex = 0;
      this.lbParameterAccess.Text = "Доступ";
      this.lbParameterAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbParameterType
      // 
      this.lbParameterType.AutoSize = true;
      this.lbParameterType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbParameterType.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbParameterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbParameterType.Location = new System.Drawing.Point(57, 1);
      this.lbParameterType.Margin = new System.Windows.Forms.Padding(0);
      this.lbParameterType.Name = "lbParameterType";
      this.lbParameterType.Size = new System.Drawing.Size(50, 22);
      this.lbParameterType.TabIndex = 1;
      this.lbParameterType.Text = "Тип";
      this.lbParameterType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbParameterName
      // 
      this.lbParameterName.AutoSize = true;
      this.lbParameterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbParameterName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbParameterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbParameterName.Location = new System.Drawing.Point(108, 1);
      this.lbParameterName.Margin = new System.Windows.Forms.Padding(0);
      this.lbParameterName.Name = "lbParameterName";
      this.lbParameterName.Size = new System.Drawing.Size(535, 22);
      this.lbParameterName.TabIndex = 2;
      this.lbParameterName.Text = "Имя";
      this.lbParameterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbParameterValue
      // 
      this.lbParameterValue.AutoSize = true;
      this.lbParameterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbParameterValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbParameterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbParameterValue.Location = new System.Drawing.Point(644, 1);
      this.lbParameterValue.Margin = new System.Windows.Forms.Padding(0);
      this.lbParameterValue.Name = "lbParameterValue";
      this.lbParameterValue.Size = new System.Drawing.Size(80, 22);
      this.lbParameterValue.TabIndex = 3;
      this.lbParameterValue.Text = "Значение";
      this.lbParameterValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tsParametersCommands
      // 
      this.tsParametersCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddParameter,
            this.tsbRemoveParameter});
      this.tsParametersCommands.Location = new System.Drawing.Point(3, 16);
      this.tsParametersCommands.Name = "tsParametersCommands";
      this.tsParametersCommands.Size = new System.Drawing.Size(725, 25);
      this.tsParametersCommands.TabIndex = 0;
      this.tsParametersCommands.Text = "toolStrip1";
      // 
      // tsbAddParameter
      // 
      this.tsbAddParameter.Image = global::MagistralDevice.Properties.Resources.Add;
      this.tsbAddParameter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbAddParameter.Name = "tsbAddParameter";
      this.tsbAddParameter.Size = new System.Drawing.Size(79, 22);
      this.tsbAddParameter.Text = "Добавить";
      this.tsbAddParameter.ToolTipText = "Добавить параметр";
      this.tsbAddParameter.Click += new System.EventHandler(this.tsbAddParameter_Click);
      // 
      // tsbRemoveParameter
      // 
      this.tsbRemoveParameter.Image = global::MagistralDevice.Properties.Resources.Del;
      this.tsbRemoveParameter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbRemoveParameter.Name = "tsbRemoveParameter";
      this.tsbRemoveParameter.Size = new System.Drawing.Size(71, 22);
      this.tsbRemoveParameter.Text = "Удалить";
      this.tsbRemoveParameter.ToolTipText = "Удалить параметр";
      this.tsbRemoveParameter.Click += new System.EventHandler(this.tsbRemoveParameter_Click);
      // 
      // statusDeviceState
      // 
      this.statusDeviceState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDeviceState});
      this.statusDeviceState.Location = new System.Drawing.Point(0, 551);
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
      // sfdParameters
      // 
      this.sfdParameters.DefaultExt = "xml";
      this.sfdParameters.Filter = "Файлы xml (*.xml)|*.xml|Все файлы (*.*)|*.*";
      this.sfdParameters.RestoreDirectory = true;
      // 
      // ofdParameters
      // 
      this.ofdParameters.DefaultExt = "xml";
      this.ofdParameters.Filter = "Файлы xml (*.xml)|*.xml|Все файлы (*.*)|*.*";
      this.ofdParameters.RestoreDirectory = true;
      // 
      // tsMainCommands
      // 
      this.tsMainCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadConfig,
            this.tsbSaveConfig,
            this.toolStripSeparator1,
            this.tsbStartStopEmulation});
      this.tsMainCommands.Location = new System.Drawing.Point(0, 0);
      this.tsMainCommands.Name = "tsMainCommands";
      this.tsMainCommands.Size = new System.Drawing.Size(751, 25);
      this.tsMainCommands.TabIndex = 10;
      this.tsMainCommands.Text = "Main commands";
      // 
      // tsbLoadConfig
      // 
      this.tsbLoadConfig.Image = global::MagistralDevice.Properties.Resources.Open;
      this.tsbLoadConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbLoadConfig.Name = "tsbLoadConfig";
      this.tsbLoadConfig.Size = new System.Drawing.Size(81, 22);
      this.tsbLoadConfig.Text = "Загрузить";
      this.tsbLoadConfig.Click += new System.EventHandler(this.tsbLoad_Click);
      // 
      // tsbSaveConfig
      // 
      this.tsbSaveConfig.Image = global::MagistralDevice.Properties.Resources.Save;
      this.tsbSaveConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbSaveConfig.Name = "tsbSaveConfig";
      this.tsbSaveConfig.Size = new System.Drawing.Size(85, 22);
      this.tsbSaveConfig.Text = "Сохранить";
      this.tsbSaveConfig.Click += new System.EventHandler(this.tsbSave_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // tsbStartStopEmulation
      // 
      this.tsbStartStopEmulation.Image = global::MagistralDevice.Properties.Resources.Conn_Add;
      this.tsbStartStopEmulation.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbStartStopEmulation.Name = "tsbStartStopEmulation";
      this.tsbStartStopEmulation.Size = new System.Drawing.Size(82, 22);
      this.tsbStartStopEmulation.Text = "Запустить";
      this.tsbStartStopEmulation.ToolTipText = "Запустить/остановить эмуляцию";
      this.tsbStartStopEmulation.Click += new System.EventHandler(this.tsbStartStopEmulation_Click);
      // 
      // tbMessageLog
      // 
      this.tbMessageLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbMessageLog.BackColor = System.Drawing.SystemColors.Window;
      this.tbMessageLog.Location = new System.Drawing.Point(12, 417);
      this.tbMessageLog.Multiline = true;
      this.tbMessageLog.Name = "tbMessageLog";
      this.tbMessageLog.ReadOnly = true;
      this.tbMessageLog.Size = new System.Drawing.Size(731, 131);
      this.tbMessageLog.TabIndex = 11;
      // 
      // DeviceMain
      // 
      this.ClientSize = new System.Drawing.Size(751, 573);
      this.Controls.Add(this.tbMessageLog);
      this.Controls.Add(this.tsMainCommands);
      this.Controls.Add(this.statusDeviceState);
      this.Controls.Add(this.gbParameters);
      this.Controls.Add(this.gbAttributes);
      this.MinimumSize = new System.Drawing.Size(767, 521);
      this.Name = "DeviceMain";
      this.Text = "Эмулятор \"Магистраль\"";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceMain_FormClosing);
      this.Load += new System.EventHandler(this.DeviceMain_Load);
      this.gbAttributes.ResumeLayout(false);
      this.gbAttributes.PerformLayout();
      this.gbParameters.ResumeLayout(false);
      this.gbParameters.PerformLayout();
      this.tlpParameters.ResumeLayout(false);
      this.tlpParameters.PerformLayout();
      this.tsParametersCommands.ResumeLayout(false);
      this.tsParametersCommands.PerformLayout();
      this.statusDeviceState.ResumeLayout(false);
      this.statusDeviceState.PerformLayout();
      this.tsMainCommands.ResumeLayout(false);
      this.tsMainCommands.PerformLayout();
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
    private System.Windows.Forms.GroupBox gbParameters;
    private System.Windows.Forms.StatusStrip statusDeviceState;
    private System.Windows.Forms.ToolStripStatusLabel tsslDeviceState;
    private System.Windows.Forms.SaveFileDialog sfdParameters;
    private System.Windows.Forms.OpenFileDialog ofdParameters;
    private System.Windows.Forms.ToolStrip tsMainCommands;
    private System.Windows.Forms.ToolStripButton tsbLoadConfig;
    private System.Windows.Forms.ToolStripButton tsbSaveConfig;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbStartStopEmulation;
    private System.Windows.Forms.TextBox tbMessageLog;
    private System.Windows.Forms.ToolStrip tsParametersCommands;
    private System.Windows.Forms.ToolStripButton tsbAddParameter;
    private System.Windows.Forms.ToolStripButton tsbRemoveParameter;
    private System.Windows.Forms.TableLayoutPanel tlpParameters;
    private System.Windows.Forms.Label lbParameterAccess;
    private System.Windows.Forms.Label lbParameterType;
    private System.Windows.Forms.Label lbParameterName;
    private System.Windows.Forms.Label lbParameterValue;
  }
}

