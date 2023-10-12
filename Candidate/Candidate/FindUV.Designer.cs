namespace Candidate
{
    partial class FindUV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFindUV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.txtSalary2 = new System.Windows.Forms.TextBox();
            this.txtMinEX = new System.Windows.Forms.TextBox();
            this.cmbVTUT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindUV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vị trí ứng tuyên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ứng viên phù hợp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yêu cầu kinh nghiệm ít nhất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mức lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Skill";
            // 
            // dgvFindUV
            // 
            this.dgvFindUV.AllowUserToAddRows = false;
            this.dgvFindUV.AllowUserToDeleteRows = false;
            this.dgvFindUV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFindUV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindUV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvFindUV.Location = new System.Drawing.Point(48, 247);
            this.dgvFindUV.Name = "dgvFindUV";
            this.dgvFindUV.ReadOnly = true;
            this.dgvFindUV.RowHeadersWidth = 51;
            this.dgvFindUV.RowTemplate.Height = 24;
            this.dgvFindUV.Size = new System.Drawing.Size(975, 191);
            this.dgvFindUV.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CVNo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kinh nghiệm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mức lương";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSkill);
            this.groupBox1.Controls.Add(this.txtSalary2);
            this.groupBox1.Controls.Add(this.txtMinEX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(172, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtSkill
            // 
            this.txtSkill.Location = new System.Drawing.Point(214, 99);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.ReadOnly = true;
            this.txtSkill.Size = new System.Drawing.Size(100, 22);
            this.txtSkill.TabIndex = 7;
            // 
            // txtSalary2
            // 
            this.txtSalary2.Location = new System.Drawing.Point(214, 68);
            this.txtSalary2.Name = "txtSalary2";
            this.txtSalary2.ReadOnly = true;
            this.txtSalary2.Size = new System.Drawing.Size(100, 22);
            this.txtSalary2.TabIndex = 6;
            // 
            // txtMinEX
            // 
            this.txtMinEX.Location = new System.Drawing.Point(214, 31);
            this.txtMinEX.Name = "txtMinEX";
            this.txtMinEX.ReadOnly = true;
            this.txtMinEX.Size = new System.Drawing.Size(100, 22);
            this.txtMinEX.TabIndex = 5;
            // 
            // cmbVTUT
            // 
            this.cmbVTUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVTUT.FormattingEnabled = true;
            this.cmbVTUT.Location = new System.Drawing.Point(172, 45);
            this.cmbVTUT.Name = "cmbVTUT";
            this.cmbVTUT.Size = new System.Drawing.Size(314, 24);
            this.cmbVTUT.TabIndex = 8;
            this.cmbVTUT.SelectedIndexChanged += new System.EventHandler(this.cmbVTUT_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbVTUT);
            this.Controls.Add(this.dgvFindUV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindUV";
            this.Text = "FindUV";
            this.Load += new System.EventHandler(this.FindUV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindUV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFindUV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.TextBox txtSalary2;
        private System.Windows.Forms.TextBox txtMinEX;
        private System.Windows.Forms.ComboBox cmbVTUT;
        private System.Windows.Forms.Button button1;
    }
}