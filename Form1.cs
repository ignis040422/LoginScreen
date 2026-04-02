using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string correctId = "23017031";
        string correctPw = "0000";

        public Form1()
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
                txtPw.UseSystemPasswordChar = true;
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

        // 🔥 로그인 버튼 클릭 (여기 핵심)
        private void Login_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string pw = txtPw.Text;

            if (id == correctId && pw == correctPw)
            {
                MessageBox.Show("로그인 성공!", "성공");
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다.", "실패");
            }
        }
    }
}
