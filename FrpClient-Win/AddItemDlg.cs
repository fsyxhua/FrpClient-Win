using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FrpClient_Win
{
    public partial class AddItemDlg : Form
    {
        private ItemInfo cNewItemInfo = null;

        public AddItemDlg()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, System.EventArgs e)
        {
            cNewItemInfo.strType = InputAddType.Text;
            cNewItemInfo.nLocalPort = InputAddLoaclPort.Text;
            cNewItemInfo.strLocalIp = InputAddLoaclIP.Text;
            cNewItemInfo.nRemotePort = InputAddRemotePort.Text;
            cNewItemInfo.strDomain = InputAddDomain.Text;
            cNewItemInfo.strSectionName = (Regex.IsMatch(InputAddLoaclPort.Text+InputAddRemotePort.Text, @"[,-]") && !Regex.IsMatch(InputAddSectionName.Text, @"^range:.*")) ? ("range:" + InputAddSectionName.Text) : InputAddSectionName.Text;
            cNewItemInfo.strUseEncryption = CheckAddUseEncryption.Checked;
            cNewItemInfo.strUseCompression = CheckAddUseCompression.Checked;
            cNewItemInfo.strRole = CheckAddRoleVisitor.Checked?"visitor":"";
            cNewItemInfo.strServerName = InputAddServerName.Text;
            cNewItemInfo.strSk = InputAddSK.Text;

            DB.Instance().AddItem(cNewItemInfo);
            cNewItemInfo = null;

            Close();
        }

        private void CancelAdd_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OnAddItemDlgLoad(object sender, System.EventArgs e)
        {
            //初始化输入框
            if(null == cNewItemInfo)
                InitShow();
        }

        public void InitShow(string strSectionName = null)
        {
            cNewItemInfo = DB.Instance().GetItem(strSectionName);

            InputAddType.Text = cNewItemInfo.strType;
            InputAddLoaclPort.Text = cNewItemInfo.nLocalPort.ToString();
            InputAddLoaclIP.Text = cNewItemInfo.strLocalIp;
            InputAddRemotePort.Text = cNewItemInfo.nRemotePort.ToString();
            InputAddDomain.Text = cNewItemInfo.strDomain;
            CheckAddUseEncryption.Checked = cNewItemInfo.strUseEncryption;
            CheckAddUseCompression.Checked = cNewItemInfo.strUseCompression;
            if (cNewItemInfo.strRole == "visitor")
            {
                CheckAddRoleVisitor.Checked = true;
            }
            else
            {
                CheckAddRoleVisitor.Checked = false;
            }
            InputAddServerName.Text = cNewItemInfo.strServerName;
            InputAddSK.Text = cNewItemInfo.strSk;
            InputAddSectionName.Text = cNewItemInfo.strSectionName;
        }

        private void DeleteItem_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show("确定要删除吗？", "删除条目", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK) {
                DB.Instance().DelItem(cNewItemInfo.strSectionName);
                Close();
            }
        }

        private void InputAddLoaclIP_DoubleClick(object sender, EventArgs e) {
            InputAddLoaclIP.Text = "127.0.0.1";
        }

        private void InputAddRemotePort_DoubleClick(object sender, EventArgs e) {
            InputAddRemotePort.Text = InputAddLoaclPort.Text;
        }

        private void InputAddType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputAddType.SelectedItem.ToString() == "stcp")
            {
                InputAddSK.Enabled = true;
                InputAddServerName.Enabled = CheckAddRoleVisitor.Checked;
                CheckAddRoleVisitor.Enabled = true;
                InputAddRemotePort.Enabled = false;
                InputAddDomain.Enabled = false;

            }
            else if (InputAddType.SelectedItem.ToString() == "http" || InputAddType.SelectedItem.ToString() == "https")
            {
                InputAddDomain.Enabled = true;
                InputAddSK.Enabled = false;
                InputAddServerName.Enabled = false;
                CheckAddRoleVisitor.Enabled = false;
                InputAddRemotePort.Enabled = false;
            }
            else
            {
                InputAddDomain.Enabled = false;
                InputAddSK.Enabled = false;
                InputAddServerName.Enabled = false;
                CheckAddRoleVisitor.Enabled = false;
                InputAddRemotePort.Enabled = true;
            }
        }

        private void CheckAddRoleVisitor_CheckedChanged(object sender, EventArgs e)
        {
            if(InputAddType.SelectedItem.ToString() == "stcp")
            {
                InputAddServerName.Enabled = CheckAddRoleVisitor.Checked;
            }
        }
    }
}
