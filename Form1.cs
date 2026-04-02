using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class LoginScreen : Form
    {
        string correctId = "23017031";
        string correctPw = "0000";

        public LoginScreen()
        {
            InitializeComponent();
            InitPlaceholder();
        }

        // Placeholder 초기 설정
        private void InitPlaceholder()
        {
            txtId.Text = "아이디";
            txtId.ForeColor = Color.Gray;

            txtPw.Text = "비밀번호";
            txtPw.ForeColor = Color.Gray;
            txtPw.UseSystemPasswordChar = false;

            lblError.Visible = false;
        }

        // 아이디 클릭
        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "아이디")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
        }

        // 아이디 벗어남
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "아이디";
                txtId.ForeColor = Color.Gray;
            }
        }

        // 비밀번호 클릭
        private void txtPw_Enter(object sender, EventArgs e)
        {
            if (txtPw.Text == "비밀번호")
            {
                txtPw.Text = "";
                txtPw.ForeColor = Color.Black;

                if (!chkShowPw.Checked)
                {
                    txtPw.UseSystemPasswordChar = true;
                }
            }
        }

        // 비밀번호 벗어남
        private void txtPw_Leave(object sender, EventArgs e)
        {
            if (txtPw.Text == "")
            {
                txtPw.UseSystemPasswordChar = false;
                txtPw.Text = "비밀번호";
                txtPw.ForeColor = Color.Gray;
            }
        }

        // 로그인 버튼 클릭
        private void Login_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string pw = txtPw.Text;

            // 입력 안 했을 때
            if (id == "아이디" || pw == "비밀번호" || id == "" || pw == "")
            {
                lblError.Text = "아이디와 비밀번호를 입력하세요.";
                lblError.Visible = true;
                return;
            }

            if (id == correctId && pw == correctPw)
            {
                lblError.Visible = false;
                MessageBox.Show("로그인 성공!", "성공");
            }
            else
            {
                // 과제1 커밋용으로 쓸 때는 아래 2줄 대신 MessageBox 사용
                // MessageBox.Show("로그인 실패!", "실패");

                lblError.Text = "아이디 또는 비밀번호가 틀렸습니다.";
                lblError.Visible = true;
            }
        }

        // 에러 메시지 숨기기
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        // Enter 키로 포커스 이동 / 로그인
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPw.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        // 전체 지우기 버튼
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPw.Text = "";
            lblError.Visible = false;
            chkShowPw.Checked = false;
            txtId.Focus();
        }

        // 비밀번호 보기 체크박스
        private void chkShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPw.Text == "비밀번호")
            {
                txtPw.UseSystemPasswordChar = false;
            }
            else
            {
                txtPw.UseSystemPasswordChar = !chkShowPw.Checked;
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}