using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRequest
{
    public partial class RequestWrite_Form : Form
    {
        public RequestWrite_Form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RequestKind_CmBox.Items.Add("객실 상품 교체 요청");
            RequestKind_CmBox.Items.Add("어매니티 요청");
            RequestKind_CmBox.Items.Add("룸 서비스 요청");
            RequestKind_CmBox.Items.Add("기타사항 요청");
        }

        private void RequestKind_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
