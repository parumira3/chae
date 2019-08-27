namespace chae
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictNone = new System.Windows.Forms.PictureBox();
            this.pictStar = new System.Windows.Forms.PictureBox();
            this.pictDal = new System.Windows.Forms.PictureBox();
            this.pictHae = new System.Windows.Forms.PictureBox();
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            this.listResult1 = new System.Windows.Forms.ListBox();
            this.listResult2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHae)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "각 플레이어는 한번식 돌아가면서 그림을 선택합니다";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "플레이어는 각 5회 진행";
            // 
            // pictNone
            // 
            this.pictNone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictNone.Location = new System.Drawing.Point(406, 62);
            this.pictNone.Name = "pictNone";
            this.pictNone.Size = new System.Drawing.Size(120, 119);
            this.pictNone.TabIndex = 5;
            this.pictNone.TabStop = false;
            this.pictNone.Click += new System.EventHandler(this.pictNone_Click);
            // 
            // pictStar
            // 
            this.pictStar.Image = global::chae.Properties.Resources._3;
            this.pictStar.Location = new System.Drawing.Point(280, 62);
            this.pictStar.Name = "pictStar";
            this.pictStar.Size = new System.Drawing.Size(120, 119);
            this.pictStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictStar.TabIndex = 4;
            this.pictStar.TabStop = false;
            this.pictStar.Click += new System.EventHandler(this.pictStar_Click);
            // 
            // pictDal
            // 
            this.pictDal.Image = global::chae.Properties.Resources._2;
            this.pictDal.Location = new System.Drawing.Point(154, 62);
            this.pictDal.Name = "pictDal";
            this.pictDal.Size = new System.Drawing.Size(120, 119);
            this.pictDal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictDal.TabIndex = 3;
            this.pictDal.TabStop = false;
            this.pictDal.Click += new System.EventHandler(this.pictDal_Click);
            // 
            // pictHae
            // 
            this.pictHae.Image = global::chae.Properties.Resources._1;
            this.pictHae.Location = new System.Drawing.Point(28, 62);
            this.pictHae.Name = "pictHae";
            this.pictHae.Size = new System.Drawing.Size(120, 119);
            this.pictHae.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictHae.TabIndex = 2;
            this.pictHae.TabStop = false;
            this.pictHae.Click += new System.EventHandler(this.pictHae_Click);
            // 
            // rdoPlayer1
            // 
            this.rdoPlayer1.AutoSize = true;
            this.rdoPlayer1.Location = new System.Drawing.Point(128, 237);
            this.rdoPlayer1.Name = "rdoPlayer1";
            this.rdoPlayer1.Size = new System.Drawing.Size(77, 16);
            this.rdoPlayer1.TabIndex = 6;
            this.rdoPlayer1.TabStop = true;
            this.rdoPlayer1.Text = "플레이어1";
            this.rdoPlayer1.UseVisualStyleBackColor = true;
            // 
            // rdoPlayer2
            // 
            this.rdoPlayer2.AutoSize = true;
            this.rdoPlayer2.Location = new System.Drawing.Point(318, 237);
            this.rdoPlayer2.Name = "rdoPlayer2";
            this.rdoPlayer2.Size = new System.Drawing.Size(77, 16);
            this.rdoPlayer2.TabIndex = 7;
            this.rdoPlayer2.TabStop = true;
            this.rdoPlayer2.Text = "플레이어2";
            this.rdoPlayer2.UseVisualStyleBackColor = true;
            // 
            // listResult1
            // 
            this.listResult1.FormattingEnabled = true;
            this.listResult1.ItemHeight = 12;
            this.listResult1.Location = new System.Drawing.Point(12, 281);
            this.listResult1.Name = "listResult1";
            this.listResult1.Size = new System.Drawing.Size(251, 136);
            this.listResult1.TabIndex = 8;
            // 
            // listResult2
            // 
            this.listResult2.FormattingEnabled = true;
            this.listResult2.ItemHeight = 12;
            this.listResult2.Location = new System.Drawing.Point(292, 281);
            this.listResult2.Name = "listResult2";
            this.listResult2.Size = new System.Drawing.Size(251, 136);
            this.listResult2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.listResult2);
            this.Controls.Add(this.listResult1);
            this.Controls.Add(this.rdoPlayer2);
            this.Controls.Add(this.rdoPlayer1);
            this.Controls.Add(this.pictNone);
            this.Controls.Add(this.pictStar);
            this.Controls.Add(this.pictDal);
            this.Controls.Add(this.pictHae);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHae)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictHae;
        private System.Windows.Forms.PictureBox pictDal;
        private System.Windows.Forms.PictureBox pictStar;
        private System.Windows.Forms.PictureBox pictNone;
        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.RadioButton rdoPlayer2;
        private System.Windows.Forms.ListBox listResult1;
        private System.Windows.Forms.ListBox listResult2;
    }
}

