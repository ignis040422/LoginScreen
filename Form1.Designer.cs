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
            Login = new Label();
            txtId = new TextBox();
            txtPw = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            idbox = new TextBox();
            pwbox = new TextBox();
            btnClear = new Button();
            chkShowPw = new CheckBox();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("맑은 고딕", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Login.Location = new Point(131, 19);
            Login.Name = "Login";
            Login.Size = new Size(107, 45);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.Click += Login_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(106, 114);
            txtId.Name = "txtId";
            txtId.Size = new Size(199, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            txtId.Enter += txtId_Enter;
            txtId.KeyDown += txtId_KeyDown;
            txtId.Leave += txtId_Leave;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(106, 164);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(199, 23);
            txtPw.TabIndex = 2;
            txtPw.TextChanged += txtPw_TextChanged;
            txtPw.Enter += txtPw_Enter;
            txtPw.KeyDown += txtPw_KeyDown;
            txtPw.Leave += txtPw_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.Font = new Font("맑은 고딕", 12F);
            btnLogin.Location = new Point(60, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 28);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += Login_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(106, 224);
            lblError.Name = "lblError";
            lblError.Size = new Size(199, 15);
            lblError.TabIndex = 4;
            lblError.Text = "아이디 또는 비밀번호가 틀렸습니다";
            lblError.Visible = false;
            // 
            // idbox
            // 
            idbox.BackColor = SystemColors.Control;
            idbox.BorderStyle = BorderStyle.None;
            idbox.Location = new Point(50, 117);
            idbox.Name = "idbox";
            idbox.Size = new Size(50, 16);
            idbox.TabIndex = 5;
            idbox.Text = "아이디:";
            // 
            // pwbox
            // 
            pwbox.BackColor = SystemColors.Control;
            pwbox.BorderStyle = BorderStyle.None;
            pwbox.Location = new Point(50, 167);
            pwbox.Name = "pwbox";
            pwbox.Size = new Size(57, 16);
            pwbox.TabIndex = 6;
            pwbox.Text = "비밀번호:";
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
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(txtPw);
            Controls.Add(txtId);
            Controls.Add(Login);
            Name = "LoginScreen";
            Text = "Login Screen";
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login;
        private TextBox txtId;
        private TextBox txtPw;
        private Button btnLogin;
        private Label lblError;
        private TextBox idbox;
        private TextBox pwbox;
        private Button btnClear;
        private CheckBox chkShowPw;
    }
}
