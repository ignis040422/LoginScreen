using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class LoginScreen : Form
    {
        // 정답 계정
        string myID = "admin";
        string myPW = "superman";

        // 로그인 실패 제한 관련 변수
        int failCount = 0;
        int maxFail = 3;
        bool isLocked = false;
        DateTime lockUntil;

        public LoginScreen()
        {
            InitializeComponent();
            InitPlaceholder();
        }

        // 초기 Placeholder 설정
        private void InitPlaceholder()
        {
            txtID.Text = "아이디";
            txtID.ForeColor = Color.Silver;

            txtPW.Text = "패스워드";
            txtPW.ForeColor = Color.Silver;
            txtPW.UseSystemPasswordChar = false;

            lblErrorMsg.Visible = false;
        }

        // 아이디 Enter
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        // 아이디 Leave
        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        // 비밀번호 Enter
        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;

                // 비밀번호 보기 체크 안 되어 있으면 숨김
                if (!chkShowPw.Checked)
                {
                    txtPW.UseSystemPasswordChar = true;
                }
            }
        }

        // 비밀번호 Leave
        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        // 로그인 버튼 클릭
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 로그인 잠금 상태 확인
            if (isLocked)
            {
                if (DateTime.Now < lockUntil)
                {
                    int remain = (int)(lockUntil - DateTime.Now).TotalSeconds;
                    lblErrorMsg.Text = $"로그인 제한 상태입니다. {remain}초 후 다시 시도하세요.";
                    lblErrorMsg.Visible = true;

                    MessageBox.Show(
                        "로그인 제한 상태입니다.",
                        "로그인",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
                else
                {
                    isLocked = false;
                    failCount = 0;
                }
            }

            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

            // 입력 안 했을 때
            if (inputID == "아이디" || inputPW == "패스워드" ||
                string.IsNullOrWhiteSpace(inputID) || string.IsNullOrWhiteSpace(inputPW))
            {
                lblErrorMsg.Text = "아이디와 패스워드를 입력하세요.";
                lblErrorMsg.Visible = true;

                MessageBox.Show(
                    "아이디와 패스워드를 입력하세요.",
                    "로그인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 아이디 형식 검사 : 영문 + 숫자만 허용
            if (!Regex.IsMatch(inputID, "^[a-zA-Z0-9]+$"))
            {
                lblErrorMsg.Text = "아이디는 영문과 숫자만 입력 가능합니다.";
                lblErrorMsg.Visible = true;

                MessageBox.Show(
                    "아이디는 영문과 숫자만 입력 가능합니다.",
                    "로그인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 비밀번호 형식 검사 : 숫자 1개 이상 포함, 4자 이상
            if (!Regex.IsMatch(inputPW, @"^(?=.*\d).{4,}$"))
            {
                lblErrorMsg.Text = "패스워드는 숫자를 포함하고 4자 이상 해야합니다.";
                lblErrorMsg.Visible = true;

                MessageBox.Show(
                    "패스워드는 숫자를 포함하고 4자 이상 해야합니다.",
                    "로그인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 로그인 성공
            if (inputID == myID && inputPW == myPW)
            {
                failCount = 0;
                lblErrorMsg.Visible = false;

                MessageBox.Show(
                    "로그인 성공!",
                    "로그인",
                    MessageBoxButtons.OK);
            }
            else
            {
                failCount++;
                lblErrorMsg.Text = $"아이디 또는 패스워드가 잘못 되었습니다. ({failCount}/{maxFail})";
                lblErrorMsg.Visible = true;

                MessageBox.Show(
                    "로그인 실패~",
                    "로그인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                // 3회 실패 시 잠금
                if (failCount >= maxFail)
                {
                    isLocked = true;
                    lockUntil = DateTime.Now.AddSeconds(10);
                    lblErrorMsg.Text = "로그인 3회 실패로 10초간 제한됩니다.";
                    lblErrorMsg.Visible = true;
                }
            }
        }

        // Enter 키 (아이디 → 비밀번호)
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                txtPW.Focus(); // 패스워드입력창이포커스를갖게끔
            }
        }

        // Enter 키 (비밀번호 → 로그인)
        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                btnLogin.PerformClick(); // 버튼이눌린것처럼만들기
            }
        }

        // 입력 시 에러 숨김
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
        }

        // 전체 지우기 버튼
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPW.Text = "";
            txtID.Focus();

            lblErrorMsg.Visible = false;
            chkShowPw.Checked = false;
        }

        // 비밀번호 보기 / 숨기기
        private void chkShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtPW.UseSystemPasswordChar = !chkShowPw.Checked;
            }
        }
    }
}