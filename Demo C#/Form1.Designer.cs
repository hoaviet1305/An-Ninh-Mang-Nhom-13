
namespace RSA_Demo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();

            this.txtP = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();

            this.btnKey = new System.Windows.Forms.Button();

            this.txtInput = new System.Windows.Forms.TextBox();
            this.cbHash = new System.Windows.Forms.ComboBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnSaveSign = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtSign = new System.Windows.Forms.TextBox();

            this.txtCheckContent = new System.Windows.Forms.TextBox();
            this.txtCheckSign = new System.Windows.Forms.TextBox();

            this.btnOpenVerifyFile = new System.Windows.Forms.Button();
            this.btnOpenSign = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Text = "RSA Digital Signature";

            groupBox1.Text = "Tạo Khóa";
            groupBox1.Location = new System.Drawing.Point(10,10);
            groupBox1.Size = new System.Drawing.Size(250,500);

            txtP.Location = new System.Drawing.Point(20,40);
            txtQ.Location = new System.Drawing.Point(20,80);
            txtE.Location = new System.Drawing.Point(20,120);
            txtN.Location = new System.Drawing.Point(20,160);
            txtD.Location = new System.Drawing.Point(20,200);

            btnKey.Text = "Tạo Khóa";
            btnKey.Location = new System.Drawing.Point(50,260);
            btnKey.Click += new System.EventHandler(this.btnKey_Click);

            groupBox1.Controls.Add(txtP);
            groupBox1.Controls.Add(txtQ);
            groupBox1.Controls.Add(txtE);
            groupBox1.Controls.Add(txtN);
            groupBox1.Controls.Add(txtD);
            groupBox1.Controls.Add(btnKey);

            groupBox2.Text = "Tạo Chữ Ký";
            groupBox2.Location = new System.Drawing.Point(280,10);
            groupBox2.Size = new System.Drawing.Size(400,500);

            txtInput.Location = new System.Drawing.Point(20,30);
            txtInput.Size = new System.Drawing.Size(350,100);
            txtInput.Multiline = true;

            cbHash.Location = new System.Drawing.Point(20,150);

            btnOpenFile.Text = "Chọn File";
            btnOpenFile.Location = new System.Drawing.Point(240,150);
            btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);

            btnSign.Text = "Ký";
            btnSign.Location = new System.Drawing.Point(20,190);
            btnSign.Click += new System.EventHandler(this.btnSign_Click);

            btnSaveSign.Text = "Lưu";
            btnSaveSign.Location = new System.Drawing.Point(120,190);
            btnSaveSign.Click += new System.EventHandler(this.btnSaveSign_Click);

            btnTransfer.Text = "Chuyển";
            btnTransfer.Location = new System.Drawing.Point(220,190);
            btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);

            txtSign.Location = new System.Drawing.Point(20,240);
            txtSign.Size = new System.Drawing.Size(350,100);
            txtSign.Multiline = true;

            groupBox2.Controls.Add(txtInput);
            groupBox2.Controls.Add(cbHash);
            groupBox2.Controls.Add(btnOpenFile);
            groupBox2.Controls.Add(btnSign);
            groupBox2.Controls.Add(btnSaveSign);
            groupBox2.Controls.Add(btnTransfer);
            groupBox2.Controls.Add(txtSign);

            groupBox3.Text = "Kiểm Tra";
            groupBox3.Location = new System.Drawing.Point(700,10);
            groupBox3.Size = new System.Drawing.Size(400,500);

            txtCheckContent.Location = new System.Drawing.Point(20,30);
            txtCheckContent.Size = new System.Drawing.Size(350,100);
            txtCheckContent.Multiline = true;

            txtCheckSign.Location = new System.Drawing.Point(20,150);
            txtCheckSign.Size = new System.Drawing.Size(350,100);
            txtCheckSign.Multiline = true;

            btnOpenVerifyFile.Text = "Mở File";
            btnOpenVerifyFile.Location = new System.Drawing.Point(20,280);
            btnOpenVerifyFile.Click += new System.EventHandler(this.btnOpenVerifyFile_Click);

            btnOpenSign.Text = "Mở Chữ Ký";
            btnOpenSign.Location = new System.Drawing.Point(110,280);
            btnOpenSign.Click += new System.EventHandler(this.btnOpenSign_Click);

            btnVerify.Text = "Kiểm Tra";
            btnVerify.Location = new System.Drawing.Point(230,280);
            btnVerify.Click += new System.EventHandler(this.btnVerify_Click);

            btnEdit.Text = "Sửa";
            btnEdit.Location = new System.Drawing.Point(320,280);
            btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            groupBox3.Controls.Add(txtCheckContent);
            groupBox3.Controls.Add(txtCheckSign);
            groupBox3.Controls.Add(btnOpenVerifyFile);
            groupBox3.Controls.Add(btnOpenSign);
            groupBox3.Controls.Add(btnVerify);
            groupBox3.Controls.Add(btnEdit);

            this.Controls.Add(groupBox1);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox3);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtD;

        private System.Windows.Forms.Button btnKey;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cbHash;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnSaveSign;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtSign;

        private System.Windows.Forms.TextBox txtCheckContent;
        private System.Windows.Forms.TextBox txtCheckSign;

        private System.Windows.Forms.Button btnOpenVerifyFile;
        private System.Windows.Forms.Button btnOpenSign;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnEdit;
    }
}
