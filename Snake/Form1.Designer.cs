namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.pb_Food = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Points = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_Player
            // 
            this.pb_Player.Image = global::Snake.Properties.Resources.Kopf;
            this.pb_Player.Location = new System.Drawing.Point(64, 64);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(32, 32);
            this.pb_Player.TabIndex = 0;
            this.pb_Player.TabStop = false;
            // 
            // pb_Food
            // 
            this.pb_Food.Image = global::Snake.Properties.Resources.Food1;
            this.pb_Food.Location = new System.Drawing.Point(264, 236);
            this.pb_Food.Name = "pb_Food";
            this.pb_Food.Size = new System.Drawing.Size(16, 16);
            this.pb_Food.TabIndex = 1;
            this.pb_Food.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Selena", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punkte:";
            // 
            // lb_Points
            // 
            this.lb_Points.AutoSize = true;
            this.lb_Points.BackColor = System.Drawing.Color.Transparent;
            this.lb_Points.Font = new System.Drawing.Font("Selena", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Points.ForeColor = System.Drawing.Color.White;
            this.lb_Points.Location = new System.Drawing.Point(137, 27);
            this.lb_Points.Name = "lb_Points";
            this.lb_Points.Size = new System.Drawing.Size(29, 33);
            this.lb_Points.TabIndex = 3;
            this.lb_Points.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 953);
            this.Controls.Add(this.lb_Points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_Food);
            this.Controls.Add(this.pb_Player);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox pb_Player;
        private PictureBox pb_Food;
        private Label label1;
        private Label lb_Points;
    }
}