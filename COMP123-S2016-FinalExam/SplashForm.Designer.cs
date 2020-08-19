namespace COMP123_M2020_FinalExam
{
  partial class SplashForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
      this.SpalshFormTimer = new System.Windows.Forms.Timer(this.components);
      this.WelcomeLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // SpalshFormTimer
      // 
      this.SpalshFormTimer.Enabled = true;
      this.SpalshFormTimer.Interval = 3000;
      this.SpalshFormTimer.Tick += new System.EventHandler(this.SpalshFormTimer_Tick);
      // 
      // WelcomeLabel
      // 
      this.WelcomeLabel.AutoSize = true;
      this.WelcomeLabel.BackColor = System.Drawing.Color.Gainsboro;
      this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WelcomeLabel.Location = new System.Drawing.Point(291, 99);
      this.WelcomeLabel.Name = "WelcomeLabel";
      this.WelcomeLabel.Size = new System.Drawing.Size(223, 120);
      this.WelcomeLabel.TabIndex = 0;
      this.WelcomeLabel.Text = "    Welcome \r\n         To \r\n   Application";
      // 
      // SplashForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(600, 320);
      this.ControlBox = false;
      this.Controls.Add(this.WelcomeLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SplashForm";
      this.Opacity = 0.9D;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Timer SpalshFormTimer;
    private System.Windows.Forms.Label WelcomeLabel;
  }
}