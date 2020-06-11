using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhDonGian
{
    public partial class frmMayTinh : Form
    {
        public frmMayTinh()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int SoThu1 = int.Parse(txtSoThu1.Text);
            int SoThu2 = int.Parse(txtSoThu2.Text);
            //RadioButton radioBtn = sender as RadioButton;
            int tong, hieu, tich, thuong;
            try
            {
                if (btnCong.Checked)
                {
                    tong = SoThu1 + SoThu2;
                    txtKetQua.Text = tong.ToString();
                }
                if(btnTru.Checked)
                {
                    hieu = SoThu1 - SoThu2;
                    txtKetQua.Text = hieu.ToString();
                }
                if(btnNhan.Checked)
                {
                    tich = SoThu1 * SoThu2;
                    txtKetQua.Text = tich.ToString();
                }
                if(btnChia.Checked)
                {
                    if (SoThu2 == 0)
                    {
                        MessageBox.Show("Khong the chia cho 0");
                    }
                    else
                    {
                        thuong = (int)SoThu1 / SoThu2;
                        txtKetQua.Text = thuong.ToString();
                    }
                }
                //if (radioBtn.Checked)
                //{

                //    switch (radioBtn)
                //    {
                //        case btnCong.Checked:

                //            tong = SoThu1 + SoThu2;
                //            txtKetQua.Text = tong.ToString();
                //            break;

                //        case btnTru.Checked:
                //            hieu = SoThu1 - SoThu2;
                //            txtKetQua.Text = hieu.ToString();
                //            break;

                //        case btnNhan.Checked:
                //            tich = SoThu1 * SoThu2;
                //            txtKetQua.Text = tich.ToString();
                //            break;

                //        case btnChia.Checked:
                //            if (SoThu2 == 0)
                //            {

                //            }
                //            else
                //            {
                //                thuong = (int)SoThu1 / SoThu2;
                //                txtKetQua.Text = thuong.ToString();
                //            }
                //            break;
                //    }

                //}
            }
            catch(Exception err)
            {
                MessageBox.Show("Bi loi" + err.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
