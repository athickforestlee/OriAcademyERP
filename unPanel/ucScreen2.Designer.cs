
namespace OriAcademyProject.unPanel
{
    partial class ucScreen2
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.txtStudentFindName = new System.Windows.Forms.TextBox();
            this.txtStudentFind = new System.Windows.Forms.TextBox();
            this.txtStudentFindCategory = new System.Windows.Forms.TextBox();
            this.lblStudentFind = new System.Windows.Forms.Label();
            this.lblStudentFindCategory = new System.Windows.Forms.Label();
            this.zipcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.school = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnpaymentsave = new System.Windows.Forms.Button();
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LecturepaymentstatusList = new System.Windows.Forms.ListView();
            this.paynumch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lecnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentyn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.paydate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.baccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.sphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stdnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllstudentList = new System.Windows.Forms.ListView();
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnFindStudent.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFindStudent.Location = new System.Drawing.Point(815, 19);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(75, 30);
            this.btnFindStudent.TabIndex = 17;
            this.btnFindStudent.Text = "조회";
            this.btnFindStudent.UseVisualStyleBackColor = false;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // txtStudentFindName
            // 
            this.txtStudentFindName.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentFindName.Location = new System.Drawing.Point(661, 21);
            this.txtStudentFindName.Name = "txtStudentFindName";
            this.txtStudentFindName.Size = new System.Drawing.Size(139, 31);
            this.txtStudentFindName.TabIndex = 16;
            // 
            // txtStudentFind
            // 
            this.txtStudentFind.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentFind.Location = new System.Drawing.Point(515, 21);
            this.txtStudentFind.Name = "txtStudentFind";
            this.txtStudentFind.Size = new System.Drawing.Size(139, 31);
            this.txtStudentFind.TabIndex = 15;
            // 
            // txtStudentFindCategory
            // 
            this.txtStudentFindCategory.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentFindCategory.Location = new System.Drawing.Point(183, 21);
            this.txtStudentFindCategory.Name = "txtStudentFindCategory";
            this.txtStudentFindCategory.ReadOnly = true;
            this.txtStudentFindCategory.Size = new System.Drawing.Size(141, 31);
            this.txtStudentFindCategory.TabIndex = 14;
            this.txtStudentFindCategory.Text = "오리원_수납정보";
            // 
            // lblStudentFind
            // 
            this.lblStudentFind.AutoSize = true;
            this.lblStudentFind.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentFind.Location = new System.Drawing.Point(394, 21);
            this.lblStudentFind.Name = "lblStudentFind";
            this.lblStudentFind.Size = new System.Drawing.Size(134, 25);
            this.lblStudentFind.TabIndex = 13;
            this.lblStudentFind.Text = "학생번호/성명";
            // 
            // lblStudentFindCategory
            // 
            this.lblStudentFindCategory.AutoSize = true;
            this.lblStudentFindCategory.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentFindCategory.Location = new System.Drawing.Point(106, 21);
            this.lblStudentFindCategory.Name = "lblStudentFindCategory";
            this.lblStudentFindCategory.Size = new System.Drawing.Size(88, 25);
            this.lblStudentFindCategory.TabIndex = 12;
            this.lblStudentFindCategory.Text = "조직분류";
            this.lblStudentFindCategory.UseMnemonic = false;
            // 
            // zipcode
            // 
            this.zipcode.Text = "학생우편번호";
            this.zipcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zipcode.Width = 0;
            // 
            // school
            // 
            this.school.Text = "학생학교명";
            this.school.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.school.Width = 0;
            // 
            // Class
            // 
            this.Class.Text = "학생반";
            this.Class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Class.Width = 0;
            // 
            // note
            // 
            this.note.Text = "특이사항";
            this.note.Width = 0;
            // 
            // btnpaymentsave
            // 
            this.btnpaymentsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnpaymentsave.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnpaymentsave.Location = new System.Drawing.Point(1029, 596);
            this.btnpaymentsave.Name = "btnpaymentsave";
            this.btnpaymentsave.Size = new System.Drawing.Size(75, 30);
            this.btnpaymentsave.TabIndex = 54;
            this.btnpaymentsave.Text = "저장";
            this.btnpaymentsave.UseVisualStyleBackColor = false;
            this.btnpaymentsave.Click += new System.EventHandler(this.btnpaymentsave_Click);
            // 
            // address
            // 
            this.address.Text = "학생주소";
            this.address.Width = 0;
            // 
            // LecturepaymentstatusList
            // 
            this.LecturepaymentstatusList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.paynumch,
            this.lecnum,
            this.lname,
            this.price,
            this.paymentyn});
            this.LecturepaymentstatusList.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LecturepaymentstatusList.FullRowSelect = true;
            this.LecturepaymentstatusList.GridLines = true;
            this.LecturepaymentstatusList.HideSelection = false;
            this.LecturepaymentstatusList.Location = new System.Drawing.Point(318, 403);
            this.LecturepaymentstatusList.Name = "LecturepaymentstatusList";
            this.LecturepaymentstatusList.Size = new System.Drawing.Size(629, 168);
            this.LecturepaymentstatusList.TabIndex = 67;
            this.LecturepaymentstatusList.UseCompatibleStateImageBehavior = false;
            this.LecturepaymentstatusList.View = System.Windows.Forms.View.Details;
            this.LecturepaymentstatusList.Click += new System.EventHandler(this.LecturepaymentstatusList_Click);
            // 
            // paynumch
            // 
            this.paynumch.Text = "";
            this.paynumch.Width = 0;
            // 
            // lecnum
            // 
            this.lecnum.Text = "강의번호";
            this.lecnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lecnum.Width = 120;
            // 
            // lname
            // 
            this.lname.Text = "강의명";
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lname.Width = 140;
            // 
            // price
            // 
            this.price.Text = "금액";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 120;
            // 
            // paymentyn
            // 
            this.paymentyn.Text = "강의료납부여부";
            this.paymentyn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paymentyn.Width = 160;
            // 
            // txtstatus
            // 
            this.txtstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtstatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtstatus.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtstatus.Location = new System.Drawing.Point(879, 599);
            this.txtstatus.MaxLength = 1;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(112, 27);
            this.txtstatus.TabIndex = 65;
            this.txtstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtname.Location = new System.Drawing.Point(417, 599);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(112, 27);
            this.txtname.TabIndex = 64;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtnum.Location = new System.Drawing.Point(207, 599);
            this.txtnum.Name = "txtnum";
            this.txtnum.ReadOnly = true;
            this.txtnum.Size = new System.Drawing.Size(112, 27);
            this.txtnum.TabIndex = 63;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pname
            // 
            this.pname.Text = "학부모성함";
            this.pname.Width = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(556, 599);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 23);
            this.label14.TabIndex = 61;
            this.label14.Text = "금액";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(349, 599);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 23);
            this.label13.TabIndex = 60;
            this.label13.Text = "강의명";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(126, 599);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "강의번호";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(44, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 28);
            this.label11.TabIndex = 57;
            this.label11.Text = "[강의납부여부]";
            // 
            // pphone
            // 
            this.pphone.Text = "학부모번호";
            this.pphone.Width = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(44, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 28);
            this.label10.TabIndex = 55;
            this.label10.Text = "[전체학생리스트]";
            // 
            // paydate
            // 
            this.paydate.Text = "강의료납부일";
            this.paydate.Width = 0;
            // 
            // bank
            // 
            this.bank.Text = "은행명";
            this.bank.Width = 0;
            // 
            // baccount
            // 
            this.baccount.Text = "계좌번호";
            this.baccount.Width = 0;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtprice.Location = new System.Drawing.Point(604, 599);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(112, 27);
            this.txtprice.TabIndex = 68;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(744, 599);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 23);
            this.label15.TabIndex = 62;
            this.label15.Text = "강의료납부여부";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(31, 356);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1169, 290);
            this.listView2.TabIndex = 58;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // sphone
            // 
            this.sphone.Text = "핸드폰번호";
            this.sphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sphone.Width = 200;
            // 
            // sname
            // 
            this.sname.Text = "성명";
            this.sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sname.Width = 140;
            // 
            // stdnum
            // 
            this.stdnum.Text = "학생번호";
            this.stdnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stdnum.Width = 140;
            // 
            // AllstudentList
            // 
            this.AllstudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stdnum,
            this.sname,
            this.sphone,
            this.email,
            this.zipcode,
            this.address,
            this.school,
            this.Class,
            this.note,
            this.pname,
            this.pphone,
            this.paydate,
            this.bank,
            this.baccount,
            this.bname});
            this.AllstudentList.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AllstudentList.FullRowSelect = true;
            this.AllstudentList.GridLines = true;
            this.AllstudentList.HideSelection = false;
            this.AllstudentList.Location = new System.Drawing.Point(347, 126);
            this.AllstudentList.Name = "AllstudentList";
            this.AllstudentList.Size = new System.Drawing.Size(572, 192);
            this.AllstudentList.TabIndex = 66;
            this.AllstudentList.UseCompatibleStateImageBehavior = false;
            this.AllstudentList.View = System.Windows.Forms.View.Details;
            this.AllstudentList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllstudentList_MouseDoubleClick);
            // 
            // email
            // 
            this.email.Text = "이메일";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Width = 0;
            // 
            // bname
            // 
            this.bname.Text = "예금주";
            this.bname.Width = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1169, 274);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ucScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnpaymentsave);
            this.Controls.Add(this.LecturepaymentstatusList);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.AllstudentList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.txtStudentFindName);
            this.Controls.Add(this.txtStudentFind);
            this.Controls.Add(this.txtStudentFindCategory);
            this.Controls.Add(this.lblStudentFind);
            this.Controls.Add(this.lblStudentFindCategory);
            this.Name = "ucScreen2";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.ucScreen2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.TextBox txtStudentFindName;
        private System.Windows.Forms.TextBox txtStudentFind;
        private System.Windows.Forms.TextBox txtStudentFindCategory;
        private System.Windows.Forms.Label lblStudentFind;
        private System.Windows.Forms.Label lblStudentFindCategory;
        private System.Windows.Forms.ColumnHeader zipcode;
        private System.Windows.Forms.ColumnHeader school;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader note;
        private System.Windows.Forms.Button btnpaymentsave;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader paynumch;
        private System.Windows.Forms.ColumnHeader lecnum;
        private System.Windows.Forms.ColumnHeader lname;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader paymentyn;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.ColumnHeader pname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader pphone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader paydate;
        private System.Windows.Forms.ColumnHeader bank;
        private System.Windows.Forms.ColumnHeader baccount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader sphone;
        private System.Windows.Forms.ColumnHeader sname;
        private System.Windows.Forms.ColumnHeader stdnum;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader bname;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ListView AllstudentList;
        public System.Windows.Forms.ListView LecturepaymentstatusList;
    }
}
