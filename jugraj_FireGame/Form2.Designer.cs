namespace jugraj_FireGame
{
    partial class Form2
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
            this.stbtn = new System.Windows.Forms.Button();
            this.ldbtn = new System.Windows.Forms.Button();
            this.spinbtn = new System.Windows.Forms.Button();
            this.shotbtn = new System.Windows.Forms.Button();
            this.shotawaybtn = new System.Windows.Forms.Button();
            this.reloadbtn = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // stbtn
            // 
            this.stbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.stbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbtn.Location = new System.Drawing.Point(12, 401);
            this.stbtn.Name = "stbtn";
            this.stbtn.Size = new System.Drawing.Size(100, 41);
            this.stbtn.TabIndex = 0;
            this.stbtn.Text = "Start";
            this.stbtn.UseVisualStyleBackColor = false;
            this.stbtn.Click += new System.EventHandler(this.stbtn_Click);
            // 
            // ldbtn
            // 
            this.ldbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ldbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldbtn.Location = new System.Drawing.Point(130, 401);
            this.ldbtn.Name = "ldbtn";
            this.ldbtn.Size = new System.Drawing.Size(100, 41);
            this.ldbtn.TabIndex = 3;
            this.ldbtn.Text = "Load";
            this.ldbtn.UseVisualStyleBackColor = false;
            this.ldbtn.Click += new System.EventHandler(this.ldbtn_Click);
            // 
            // spinbtn
            // 
            this.spinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.spinbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinbtn.Location = new System.Drawing.Point(247, 401);
            this.spinbtn.Name = "spinbtn";
            this.spinbtn.Size = new System.Drawing.Size(100, 41);
            this.spinbtn.TabIndex = 4;
            this.spinbtn.Text = "Spin";
            this.spinbtn.UseVisualStyleBackColor = false;
            this.spinbtn.Click += new System.EventHandler(this.spinbtn_Click);
            // 
            // shotbtn
            // 
            this.shotbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.shotbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shotbtn.Location = new System.Drawing.Point(366, 401);
            this.shotbtn.Name = "shotbtn";
            this.shotbtn.Size = new System.Drawing.Size(100, 41);
            this.shotbtn.TabIndex = 5;
            this.shotbtn.Text = "Shoot";
            this.shotbtn.UseVisualStyleBackColor = false;
            this.shotbtn.Click += new System.EventHandler(this.shotbtn_Click);
            // 
            // shotawaybtn
            // 
            this.shotawaybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.shotawaybtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shotawaybtn.Location = new System.Drawing.Point(487, 401);
            this.shotawaybtn.Name = "shotawaybtn";
            this.shotawaybtn.Size = new System.Drawing.Size(116, 41);
            this.shotawaybtn.TabIndex = 6;
            this.shotawaybtn.Text = "Shoot Away";
            this.shotawaybtn.UseVisualStyleBackColor = false;
            this.shotawaybtn.Click += new System.EventHandler(this.shotawaybtn_Click);
            // 
            // reloadbtn
            // 
            this.reloadbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reloadbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadbtn.Location = new System.Drawing.Point(624, 401);
            this.reloadbtn.Name = "reloadbtn";
            this.reloadbtn.Size = new System.Drawing.Size(100, 41);
            this.reloadbtn.TabIndex = 7;
            this.reloadbtn.Text = "Reload";
            this.reloadbtn.UseVisualStyleBackColor = false;
            this.reloadbtn.Click += new System.EventHandler(this.reloadbtn_Click);
            // 
            // pb
            // 
            this.pb.Image = global::jugraj_FireGame.Properties.Resources.st1;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(832, 395);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 446);
            this.Controls.Add(this.reloadbtn);
            this.Controls.Add(this.shotawaybtn);
            this.Controls.Add(this.shotbtn);
            this.Controls.Add(this.spinbtn);
            this.Controls.Add(this.ldbtn);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.stbtn);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stbtn;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button ldbtn;
        private System.Windows.Forms.Button spinbtn;
        private System.Windows.Forms.Button shotbtn;
        private System.Windows.Forms.Button shotawaybtn;
        private System.Windows.Forms.Button reloadbtn;
    }
}