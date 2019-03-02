namespace CookieMonster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.BtnLevel4 = new System.Windows.Forms.Button();
            this.LblNrOfMoves = new System.Windows.Forms.Label();
            this.BtnLevel3 = new System.Windows.Forms.Button();
            this.BtnLevel2 = new System.Windows.Forms.Button();
            this.PbPlayground = new System.Windows.Forms.PictureBox();
            this.BtnLevel1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayground)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Yellow;
            this.ImageList.Images.SetKeyName(0, "PlateWith0.png");
            this.ImageList.Images.SetKeyName(1, "PlateWith1.png");
            this.ImageList.Images.SetKeyName(2, "PlateWith2.png");
            this.ImageList.Images.SetKeyName(3, "PlateWith3.png");
            // 
            // BtnLevel4
            // 
            this.BtnLevel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLevel4.Location = new System.Drawing.Point(270, 12);
            this.BtnLevel4.Name = "BtnLevel4";
            this.BtnLevel4.Size = new System.Drawing.Size(80, 40);
            this.BtnLevel4.TabIndex = 11;
            this.BtnLevel4.Text = "level 4";
            this.BtnLevel4.UseVisualStyleBackColor = true;
            this.BtnLevel4.Click += new System.EventHandler(this.BtnLevel4_Click);
            // 
            // LblNrOfMoves
            // 
            this.LblNrOfMoves.AutoSize = true;
            this.LblNrOfMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNrOfMoves.Location = new System.Drawing.Point(450, 28);
            this.LblNrOfMoves.Name = "LblNrOfMoves";
            this.LblNrOfMoves.Size = new System.Drawing.Size(157, 24);
            this.LblNrOfMoves.TabIndex = 10;
            this.LblNrOfMoves.Text = "number of moves";
            // 
            // BtnLevel3
            // 
            this.BtnLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLevel3.Location = new System.Drawing.Point(184, 12);
            this.BtnLevel3.Name = "BtnLevel3";
            this.BtnLevel3.Size = new System.Drawing.Size(80, 40);
            this.BtnLevel3.TabIndex = 9;
            this.BtnLevel3.Text = "level 3";
            this.BtnLevel3.UseVisualStyleBackColor = true;
            this.BtnLevel3.Click += new System.EventHandler(this.BtnLevel3_Click);
            // 
            // BtnLevel2
            // 
            this.BtnLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLevel2.Location = new System.Drawing.Point(98, 12);
            this.BtnLevel2.Name = "BtnLevel2";
            this.BtnLevel2.Size = new System.Drawing.Size(80, 40);
            this.BtnLevel2.TabIndex = 8;
            this.BtnLevel2.Text = "level 2";
            this.BtnLevel2.UseVisualStyleBackColor = true;
            this.BtnLevel2.Click += new System.EventHandler(this.BtnLevel2_Click);
            // 
            // PbPlayground
            // 
            this.PbPlayground.Location = new System.Drawing.Point(10, 62);
            this.PbPlayground.Name = "PbPlayground";
            this.PbPlayground.Size = new System.Drawing.Size(427, 314);
            this.PbPlayground.TabIndex = 7;
            this.PbPlayground.TabStop = false;
            this.PbPlayground.Paint += new System.Windows.Forms.PaintEventHandler(this.PbPlayground_Paint);
            this.PbPlayground.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbPlayground_MouseUp);
            // 
            // BtnLevel1
            // 
            this.BtnLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLevel1.Location = new System.Drawing.Point(12, 12);
            this.BtnLevel1.Name = "BtnLevel1";
            this.BtnLevel1.Size = new System.Drawing.Size(80, 40);
            this.BtnLevel1.TabIndex = 6;
            this.BtnLevel1.Text = "level 1";
            this.BtnLevel1.UseVisualStyleBackColor = true;
            this.BtnLevel1.Click += new System.EventHandler(this.BtnLevel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLevel4);
            this.Controls.Add(this.LblNrOfMoves);
            this.Controls.Add(this.BtnLevel3);
            this.Controls.Add(this.BtnLevel2);
            this.Controls.Add(this.PbPlayground);
            this.Controls.Add(this.BtnLevel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button BtnLevel4;
        private System.Windows.Forms.Label LblNrOfMoves;
        private System.Windows.Forms.Button BtnLevel3;
        private System.Windows.Forms.Button BtnLevel2;
        private System.Windows.Forms.PictureBox PbPlayground;
        private System.Windows.Forms.Button BtnLevel1;
    }
}

