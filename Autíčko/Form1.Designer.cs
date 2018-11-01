namespace Autíčko
{
    partial class Form1
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
            this.tlZrychli = new System.Windows.Forms.Button();
            this.tlZpomal = new System.Windows.Forms.Button();
            this.časovač = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tlZrychli
            // 
            this.tlZrychli.Location = new System.Drawing.Point(119, 162);
            this.tlZrychli.Name = "tlZrychli";
            this.tlZrychli.Size = new System.Drawing.Size(75, 23);
            this.tlZrychli.TabIndex = 0;
            this.tlZrychli.Text = "Zrychli";
            this.tlZrychli.UseVisualStyleBackColor = true;
            this.tlZrychli.Click += new System.EventHandler(this.tlZrychli_Click);
            // 
            // tlZpomal
            // 
            this.tlZpomal.Location = new System.Drawing.Point(285, 162);
            this.tlZpomal.Name = "tlZpomal";
            this.tlZpomal.Size = new System.Drawing.Size(75, 23);
            this.tlZpomal.TabIndex = 1;
            this.tlZpomal.Text = "Zpomal";
            this.tlZpomal.UseVisualStyleBackColor = true;
            this.tlZpomal.Click += new System.EventHandler(this.tlZpomal_Click);
            // 
            // časovač
            // 
            this.časovač.Enabled = true;
            this.časovač.Interval = 50;
            this.časovač.Tick += new System.EventHandler(this.časovač_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 217);
            this.Controls.Add(this.tlZpomal);
            this.Controls.Add(this.tlZrychli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlZrychli;
        private System.Windows.Forms.Button tlZpomal;
        private System.Windows.Forms.Timer časovač;
    }
}

