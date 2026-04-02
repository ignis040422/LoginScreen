using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class LoginScreen : Form
    {
        string correctId = "23017031";
        string correctPw = "1234";

        int failCount = 0;
        int maxFail = 3;
        bool isLocked = false;
        DateTime lockUntil;

        public LoginScreen()
        {
            InitializeComponent();
            InitPlaceholder();
        }

        // Placeholder 초기 설정
        private void InitPlaceholder()
        {
            txtID.Text = "아이디";
            txtID.ForeColor = Color.Gray;

            txtPW.Text = "비밀번호";
            txtPW.ForeColor = Color.Gray;
            txtPW.UseSystemPasswordChar = false;

            lblError.Visible = false;
        }

        // 아이디 클릭
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        // 아이디 벗어남
        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Gray;
            }
        }

        // 비밀번호 클릭
        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "비밀번호")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;

                if (!chkShowPw.Checked)
                {
                    txtPW.UseSystemPasswordChar = true;
                }
            }
        }

        // 비밀번호 벗어남
        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (txtPW.Text == "")
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "비밀번호";
                txtPW.ForeColor = Color.Gray;
            }
        }

        // 로그인 버튼 클릭
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLocked)
            {
                if (DateTime.Now < lockUntil)
                {
                    int remain = (int)(lockUntil - DateTime.Now).TotalSeconds;
                    lblError.Text = $"로그인 제한 상태입니다. {remain}초 후 다시 시도하세요.";
                    lblError.Visible = true;
                    return;
                }
                else
                {
                    isLocked = false;
                    failCount = 0;
                }
            }

            string id = txtID.Text;
            string pw = txtPW.Text;

            if (id == "아이디" || pw == "비밀번호" || id == "" || pw == "")
            {
                lblError.Text = "아이디와 비밀번호를 입력하세요.";
                lblError.Visible = true;
                return;
            }

            if (!Regex.IsMatch(id, "^[a-zA-Z0-9]+$"))
            {
                lblError.Text = "아이디는 영문과 숫자만 입력 가능합니다.";
                lblError.Visible = true;
                return;
            }

            if (!Regex.IsMatch(pw, @"^(?=.*\d).{4,}$"))
            {
                lblError.Text = "비밀번호는 숫자를 포함하고 4자 이상이어야 합니다.";
                lblError.Visible = true;
                return;
            }

            if (id == correctId && pw == correctPw)
            {
                lblError.Visible = false;
                failCount = 0;
                MessageBox.Show("로그인 성공!", "성공");
            }
            else
            {
                failCount++;
                lblError.Text = $"아이디 또는 비밀번호가 틀렸습니다. ({failCount}/{maxFail})";
                lblError.Visible = true;

                if (failCount >= maxFail)
                {
                    isLocked = true;
                    lockUntil = DateTime.Now.AddSeconds(10);
                    lblError.Text = "로그인 3회 실패로 10초간 제한됩니다.";
                }
            }
        }

        // 에러 메시지 숨기기
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        // Enter 키로 포커스 이동 / 로그인
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPW.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        // 전체 지우기 버튼
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPW.Text = "";
            lblError.Visible = false;
            chkShowPw.Checked = false;
            txtID.Focus();
        }

        // 비밀번호 보기 체크박스
        private void chkShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPW.Text == "비밀번호")
            {
                txtPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtPW.UseSystemPasswordChar = !chkShowPw.Checked;
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}