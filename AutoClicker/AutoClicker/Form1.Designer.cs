
namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.clicktimer = new System.Windows.Forms.Timer(this.components);
            this.maximumCpsLabel = new System.Windows.Forms.Label();
            this.minimumCpsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.autoClickToggleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 30);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(314, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 106);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(314, 45);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // clicktimer
            // 
            this.clicktimer.Tick += new System.EventHandler(this.clicktimer_Tick);
            // 
            // maximumCpsLabel
            // 
            this.maximumCpsLabel.AutoSize = true;
            this.maximumCpsLabel.Location = new System.Drawing.Point(12, 14);
            this.maximumCpsLabel.Name = "maximumCpsLabel";
            this.maximumCpsLabel.Size = new System.Drawing.Size(78, 13);
            this.maximumCpsLabel.TabIndex = 3;
            this.maximumCpsLabel.Text = "Maximum Cps: ";
            // 
            // minimumCpsLabel
            // 
            this.minimumCpsLabel.AutoSize = true;
            this.minimumCpsLabel.Location = new System.Drawing.Point(12, 78);
            this.minimumCpsLabel.Name = "minimumCpsLabel";
            this.minimumCpsLabel.Size = new System.Drawing.Size(75, 13);
            this.minimumCpsLabel.TabIndex = 4;
            this.minimumCpsLabel.Text = "Minimum Cps: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toglle Auto Clicker With Alt+S";
            // 
            // autoClickToggleBtn
            // 
            this.autoClickToggleBtn.BackColor = System.Drawing.Color.Red;
            this.autoClickToggleBtn.Location = new System.Drawing.Point(12, 157);
            this.autoClickToggleBtn.Name = "autoClickToggleBtn";
            this.autoClickToggleBtn.Size = new System.Drawing.Size(75, 23);
            this.autoClickToggleBtn.TabIndex = 0;
            this.autoClickToggleBtn.Text = "Off";
            this.autoClickToggleBtn.UseVisualStyleBackColor = false;
            this.autoClickToggleBtn.Click += new System.EventHandler(this.autoClickToggleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimumCpsLabel);
            this.Controls.Add(this.maximumCpsLabel);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.autoClickToggleBtn);
            this.Name = "Form1";
            this.Text = "Houqi\'s Auto Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Timer clicktimer;
        private System.Windows.Forms.Label maximumCpsLabel;
        private System.Windows.Forms.Label minimumCpsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button autoClickToggleBtn;
    }
}

