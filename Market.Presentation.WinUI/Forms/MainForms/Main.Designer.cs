namespace Market.Presentation.WinUI.Forms.MainForms
{
  partial class Main
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
      this.menuStripMain = new System.Windows.Forms.MenuStrip();
      this.wwwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.kullanıcıListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblStripClientName = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblStripClientIP = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStripMain.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStripMain
      // 
      this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wwwToolStripMenuItem});
      this.menuStripMain.Location = new System.Drawing.Point(0, 0);
      this.menuStripMain.Name = "menuStripMain";
      this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
      this.menuStripMain.Size = new System.Drawing.Size(1188, 30);
      this.menuStripMain.TabIndex = 0;
      this.menuStripMain.Text = "menuStrip1";
      // 
      // wwwToolStripMenuItem
      // 
      this.wwwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
      this.wwwToolStripMenuItem.Name = "wwwToolStripMenuItem";
      this.wwwToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
      this.wwwToolStripMenuItem.Text = "Ayarlar";
      // 
      // testToolStripMenuItem
      // 
      this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıListesiToolStripMenuItem});
      this.testToolStripMenuItem.Name = "testToolStripMenuItem";
      this.testToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
      this.testToolStripMenuItem.Tag = "1";
      this.testToolStripMenuItem.Text = "Kullanıcı İşlemleri";
      // 
      // kullanıcıListesiToolStripMenuItem
      // 
      this.kullanıcıListesiToolStripMenuItem.Name = "kullanıcıListesiToolStripMenuItem";
      this.kullanıcıListesiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.kullanıcıListesiToolStripMenuItem.Tag = "MarketUserList";
      this.kullanıcıListesiToolStripMenuItem.Text = "Kullanıcı Listesi";
      this.kullanıcıListesiToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStripClientName,
            this.lblStripClientIP});
      this.statusStrip1.Location = new System.Drawing.Point(0, 481);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.statusStrip1.Size = new System.Drawing.Size(1188, 26);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // lblStripClientName
      // 
      this.lblStripClientName.Name = "lblStripClientName";
      this.lblStripClientName.Size = new System.Drawing.Size(66, 20);
      this.lblStripClientName.Text = "QWERTY";
      // 
      // lblStripClientIP
      // 
      this.lblStripClientIP.Name = "lblStripClientIP";
      this.lblStripClientIP.Size = new System.Drawing.Size(66, 20);
      this.lblStripClientIP.Text = "IP:IP:IP:IP";
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1188, 507);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStripMain);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStripMain;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Main";
      this.Text = "Main";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
      this.Load += new System.EventHandler(this.Main_Load);
      this.menuStripMain.ResumeLayout(false);
      this.menuStripMain.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MenuStrip menuStripMain;
    private ToolStripMenuItem wwwToolStripMenuItem;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblStripClientName;
    private ToolStripStatusLabel lblStripClientIP;
    private ToolStripMenuItem testToolStripMenuItem;
    private ToolStripMenuItem kullanıcıListesiToolStripMenuItem;
  }
}