
namespace OriAcademyProject
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
            this.lbl_ClassInformation = new System.Windows.Forms.Label();
            this.lbl_ReportInformation_0 = new System.Windows.Forms.Label();
            this.lbl_PaymentInformation_0 = new System.Windows.Forms.Label();
            this.lbl_PersonalInformation_0 = new System.Windows.Forms.Label();
            this.lbl_MainLbl_0 = new System.Windows.Forms.Label();
            this.Pan_PageCenter_0 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(115, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ori Academy 학생정보전산시스템";
            // 
            // lbl_ClassInformation
            // 
            this.lbl_ClassInformation.AutoSize = true;
            this.lbl_ClassInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.lbl_ClassInformation.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ClassInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ClassInformation.Location = new System.Drawing.Point(22, 285);
            this.lbl_ClassInformation.Name = "lbl_ClassInformation";
            this.lbl_ClassInformation.Size = new System.Drawing.Size(141, 32);
            this.lbl_ClassInformation.TabIndex = 16;
            this.lbl_ClassInformation.Text = "◦ 강의정보";
            this.lbl_ClassInformation.Click += new System.EventHandler(this.lbl_ClassInformation_Click);
            // 
            // lbl_ReportInformation_0
            // 
            this.lbl_ReportInformation_0.AutoSize = true;
            this.lbl_ReportInformation_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.lbl_ReportInformation_0.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ReportInformation_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ReportInformation_0.Location = new System.Drawing.Point(22, 349);
            this.lbl_ReportInformation_0.Name = "lbl_ReportInformation_0";
            this.lbl_ReportInformation_0.Size = new System.Drawing.Size(141, 32);
            this.lbl_ReportInformation_0.TabIndex = 15;
            this.lbl_ReportInformation_0.Text = "◦ 성적정보";
            this.lbl_ReportInformation_0.Click += new System.EventHandler(this.lbl_ReportInformation_0_Click);
            // 
            // lbl_PaymentInformation_0
            // 
            this.lbl_PaymentInformation_0.AutoSize = true;
            this.lbl_PaymentInformation_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.lbl_PaymentInformation_0.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_PaymentInformation_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_PaymentInformation_0.Location = new System.Drawing.Point(22, 222);
            this.lbl_PaymentInformation_0.Name = "lbl_PaymentInformation_0";
            this.lbl_PaymentInformation_0.Size = new System.Drawing.Size(141, 32);
            this.lbl_PaymentInformation_0.TabIndex = 13;
            this.lbl_PaymentInformation_0.Text = "◦ 수납정보";
            this.lbl_PaymentInformation_0.Click += new System.EventHandler(this.lbl_PaymentInformation_0_Click);
            // 
            // lbl_PersonalInformation_0
            // 
            this.lbl_PersonalInformation_0.AutoSize = true;
            this.lbl_PersonalInformation_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.lbl_PersonalInformation_0.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_PersonalInformation_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_PersonalInformation_0.Location = new System.Drawing.Point(22, 160);
            this.lbl_PersonalInformation_0.Name = "lbl_PersonalInformation_0";
            this.lbl_PersonalInformation_0.Size = new System.Drawing.Size(141, 32);
            this.lbl_PersonalInformation_0.TabIndex = 12;
            this.lbl_PersonalInformation_0.Text = "◦ 개인정보";
            this.lbl_PersonalInformation_0.Click += new System.EventHandler(this.lbl_PersonalInformation_0_Click);
            // 
            // lbl_MainLbl_0
            // 
            this.lbl_MainLbl_0.AutoSize = true;
            this.lbl_MainLbl_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(81)))), ((int)(((byte)(151)))));
            this.lbl_MainLbl_0.Font = new System.Drawing.Font("맑은 고딕", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_MainLbl_0.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_MainLbl_0.Location = new System.Drawing.Point(32, 84);
            this.lbl_MainLbl_0.Name = "lbl_MainLbl_0";
            this.lbl_MainLbl_0.Size = new System.Drawing.Size(269, 38);
            this.lbl_MainLbl_0.TabIndex = 17;
            this.lbl_MainLbl_0.Text = "학생정보전산시스템";
            // 
            // Pan_PageCenter_0
            // 
            this.Pan_PageCenter_0.BackColor = System.Drawing.SystemColors.Control;
            this.Pan_PageCenter_0.Location = new System.Drawing.Point(173, 141);
            this.Pan_PageCenter_0.Name = "Pan_PageCenter_0";
            this.Pan_PageCenter_0.Size = new System.Drawing.Size(1089, 708);
            this.Pan_PageCenter_0.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OriAcademyProject.Properties.Resources.Logoimage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 44);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(81)))), ((int)(((byte)(151)))));
            this.pictureBox2.Location = new System.Drawing.Point(5, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1257, 65);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.pictureBox3.Location = new System.Drawing.Point(5, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 886);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Pan_PageCenter_0);
            this.Controls.Add(this.lbl_MainLbl_0);
            this.Controls.Add(this.lbl_ClassInformation);
            this.Controls.Add(this.lbl_ReportInformation_0);
            this.Controls.Add(this.lbl_PaymentInformation_0);
            this.Controls.Add(this.lbl_PersonalInformation_0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ClassInformation;
        private System.Windows.Forms.Label lbl_ReportInformation_0;
        private System.Windows.Forms.Label lbl_PaymentInformation_0;
        private System.Windows.Forms.Label lbl_PersonalInformation_0;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_MainLbl_0;
        public System.Windows.Forms.Panel Pan_PageCenter_0;
    }
}

