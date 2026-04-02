namespace LoginScreen
{
    partial class LoginScreen
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            idbox = new TextBox();
            pwbox = new TextBox();
            btnClear = new Button();
            chkShowPw = new CheckBox();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(131, 19);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(107, 45);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Location = new Point(106, 114);
            txtID.Name = "txtID";
            txtID.Size = new Size(199, 23);
            txtID.TabIndex = 2;
            txtID.TextChanged += txtID_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(106, 164);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(199, 23);
            txtPW.TabIndex = 3;
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.Font = new Font("맑은 고딕", 12F);
            btnLogin.Location = new Point(60, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 28);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(106, 224);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(199, 15);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 틀렸습니다";
            lblErrorMsg.Visible = false;
            // 
            // idbox
            // 
            idbox.BackColor = SystemColors.Control;
            idbox.BorderStyle = BorderStyle.None;
            idbox.Location = new Point(50, 117);
            idbox.Name = "idbox";
            idbox.ReadOnly = true;
            idbox.Size = new Size(50, 16);
            idbox.TabIndex = 5;
            idbox.TabStop = false;
            idbox.Text = "아이디:";
            // 
            // pwbox
            // 
            pwbox.BackColor = SystemColors.Control;
            pwbox.BorderStyle = BorderStyle.None;
            pwbox.Location = new Point(50, 167);
            pwbox.Name = "pwbox";
            pwbox.ReadOnly = true;
            pwbox.Size = new Size(50, 16);
            pwbox.TabIndex = 6;
            pwbox.TabStop = false;
            pwbox.Text = "패스워드:";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Font = new Font("맑은 고딕", 11F);
            btnClear.Location = new Point(198, 261);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 28);
            btnClear.TabIndex = 7;
            btnClear.Text = "전체 지우기";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // chkShowPw
            // 
            chkShowPw.AutoSize = true;
            chkShowPw.Location = new Point(106, 193);
            chkShowPw.Name = "chkShowPw";
            chkShowPw.Size = new Size(102, 19);
            chkShowPw.TabIndex = 8;
            chkShowPw.Text = "비밀번호 보기";
            chkShowPw.UseVisualStyleBackColor = true;
            chkShowPw.CheckedChanged += chkShowPw_CheckedChanged;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 366);
            Controls.Add(chkShowPw);
            Controls.Add(btnClear);
            Controls.Add(pwbox);
            Controls.Add(idbox);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "LoginScreen";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMsg;
        private TextBox idbox;
        private TextBox pwbox;
        private Button btnClear;
        private CheckBox chkShowPw;
    }
}