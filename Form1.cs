using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class LoginScreen : Form
    {
        //정답 계정 정보
        string correctId = "23017031";
        string correctPw = "1234";

        //로그인 제한 관련 변수
        int failCount = 0;     // 실패 횟수
        int maxFail = 3;       // 최대 허용 횟수
        bool isLocked = false; // 잠금 여부
        DateTime lockUntil;    // 잠금 해제 시간

        public LoginScreen()
        {
            InitializeComponent();
            InitPlaceholder();
        }

        //Placeholder 초기 설정
        private void InitPlaceholder()
        {
            txtID.Text = "아이디";
            txtID.ForeColor = Color.Gray;

            txtPW.Text = "비밀번호";
            txtPW.ForeColor = Color.Gray;
            txtPW.UseSystemPasswordChar = false;

            lblError.Visible = false;
        }

        //아이디 입력 시작 시 Placeholder 제거
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        //아이디 입력 없으면 Placeholder 복구
        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Gray;
            }
        }

        //비밀번호 입력 시작
        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "비밀번호")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;

                //체크 안 되어 있으면 비밀번호 숨김
                if (!chkShowPw.Checked)
                {
                    txtPW.UseSystemPasswordChar = true;
                }
            }
        }

        //비밀번호 입력 없으면 Placeholder 복구
        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (txtPW.Text == "")
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "비밀번호";
                txtPW.ForeColor = Color.Gray;
            }
        }

        //로그인 버튼 클릭
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //로그인 잠금 상태 체크
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
                    //잠금 해제
                    isLocked = false;
                    failCount = 0;
                }
            }

            string id = txtID.Text;
            string pw = txtPW.Text;

            //입력 안 했을 때
            if (id == "아이디" || pw == "비밀번호" || id == "" || pw == "")
            {
                lblError.Text = "아이디와 비밀번호를 입력하세요.";
                lblError.Visible = true;
                return;
            }

            //아이디 형식 검사 (영문 + 숫자)
            if (!Regex.IsMatch(id, "^[a-zA-Z0-9]+$"))
            {
                lblError.Text = "아이디는 영문과 숫자만 입력 가능합니다.";
                lblError.Visible = true;
                return;
            }

            //비밀번호 검사 (숫자 포함 + 4자 이상)
            if (!Regex.IsMatch(pw, @"^(?=.*\d).{4,}$"))
            {
                lblError.Text = "숫자를 포함하고 4자 이상이어야 합니다.";
                lblError.Visible = true;
                return;
            }

            //로그인 성공
            if (id == correctId && pw == correctPw)
            {
                lblError.Visible = false;
                failCount = 0;
                MessageBox.Show("로그인 성공!", "성공");
            }
            else
            {
                //로그인 실패 처리
                failCount++;
                lblError.Text = $"아이디 또는 비밀번호가 틀렸습니다. ({failCount}/{maxFail})";
                lblError.Visible = true;

                //3회 실패 시 잠금
                if (failCount >= maxFail)
                {
                    isLocked = true;
                    lockUntil = DateTime.Now.AddSeconds(10);
                    lblError.Text = "로그인 3회 실패로 10초간 제한됩니다.";
                }
            }
        }

        //입력 시 에러 메시지 제거
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        //Enter 키 UX 개선
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

        //전체 지우기
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPW.Text = "";
            lblError.Visible = false;
            chkShowPw.Checked = false;
            txtID.Focus();
        }

        //비밀번호 보기/숨기기
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
    }
}