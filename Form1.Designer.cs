namespace LoginScreen
{
    partial class Form1
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
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("맑은 고딕", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Login.Location = new Point(133, 42);
            Login.Name = "Login";
            Login.Size = new Size(107, 45);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.Click += Login_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 140);
            txtId.Name = "txtId";
            txtId.Size = new Size(199, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            txtId.Enter += txtId_Enter;
            txtId.Leave += txtId_Leave;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(86, 198);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(199, 23);
            txtPw.TabIndex = 2;
            txtPw.TextChanged += txtPw_TextChanged;
            txtPw.Enter += txtPw_Enter;
            txtPw.Leave += txtPw_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.Font = new Font("맑은 고딕", 14F);
            btnLogin.Location = new Point(133, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += Login_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(86, 292);
            lblError.Name = "lblError";
            lblError.Size = new Size(199, 15);
            lblError.TabIndex = 4;
            lblError.Text = "아이디 또는 비밀번호가 틀렸습니다";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 366);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(txtPw);
            Controls.Add(txtId);
            Controls.Add(Login);
            Name = "Form1";
            Text = "ㄴ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login;
        private TextBox txtId;
        private TextBox txtPw;
        private Button btnLogin;
        private Label lblError;
    }
}
