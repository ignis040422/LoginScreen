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
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("맑은 고딕", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Login.Location = new Point(135, 52);
            Login.Name = "Login";
            Login.Size = new Size(107, 45);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.Click += Login_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 139);
            txtId.Name = "txtId";
            txtId.Size = new Size(211, 23);
            txtId.TabIndex = 1;
            txtId.Enter += txtId_Enter;
            txtId.Leave += txtId_Leave;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(86, 202);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(211, 23);
            txtPw.TabIndex = 2;
            txtPw.Enter += txtPw_Enter;
            txtPw.Leave += txtPw_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.Font = new Font("맑은 고딕", 14F);
            btnLogin.Location = new Point(135, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 366);
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
    }
}
