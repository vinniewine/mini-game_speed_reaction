namespace Reaction
{
    partial class FormReaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReaction));
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelHelp = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            this.SuspendLayout();
            // 
            // picture1
            // 
            this.picture1.Image = global::Reaction.Properties.Resources.A_Cat;
            this.picture1.Location = new System.Drawing.Point(89, 121);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(193, 176);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            this.picture1.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture2
            // 
            this.picture2.Image = global::Reaction.Properties.Resources.panda;
            this.picture2.Location = new System.Drawing.Point(307, 121);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(193, 176);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 1;
            this.picture2.TabStop = false;
            this.picture2.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture3
            // 
            this.picture3.Image = global::Reaction.Properties.Resources.Red_Neon_Aesthetic_Wallpaper_Desktop;
            this.picture3.Location = new System.Drawing.Point(530, 121);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(193, 176);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture3.TabIndex = 2;
            this.picture3.TabStop = false;
            this.picture3.Click += new System.EventHandler(this.picture1_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(276, 336);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(242, 63);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelHelp
            // 
            this.labelHelp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(49, 48);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(686, 37);
            this.labelHelp.TabIndex = 4;
            this.labelHelp.Text = "Click to the picture after their appearance ";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(44, 312);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(723, 18);
            this.progress.TabIndex = 5;
            // 
            // FormReaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReaction";
            this.Text = "Game Reaction";
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.ProgressBar progress;
    }
}

