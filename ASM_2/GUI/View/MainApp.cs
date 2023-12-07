using ASM_2.BLL.Services;
using ASM_2.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_2.GUI.View
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }
        PhongBanServices phongBanServices = new PhongBanServices();
        NhanVienServices nhanVienServices = new NhanVienServices();

        private void MainApp_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadPB();
        }

        public void LoadDGV()
        {
            var query = from nv in nhanVienServices.GetAllNhanVien()
                        join pb in phongBanServices.GetAllPhongBan()
                        on nv.MaPb equals pb.MaPb
                        select
                        new
                        {
                            nv.MaNv,
                            nv.HoTen,
                            nv.NgaySinh,
                            nv.GioiTinh,
                            pb.TenPb
                        };
            dgv_Main.DataSource = query.ToList();

        }
        public void LoadPB()
        {
            cbo_PhongBan.DataSource = phongBanServices.GetAllPhongBan();
            cbo_PhongBan.ValueMember = "MaPb";
            cbo_PhongBan.DisplayMember = "TenPb";
        }
        private void dgv_Main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_Ma.Text = dgv_Main.Rows[d].Cells[0].Value.ToString();
            txt_HoTen.Text = dgv_Main.Rows[d].Cells[1].Value.ToString();
            dtp_birthday.Text = dgv_Main.Rows[d].Cells[2].Value.ToString();
            cbo_PhongBan.Text = dgv_Main.Rows[d].Cells[4].Value.ToString();
            if (dgv_Main.Rows[d].Cells[3].Value.Equals("Nam"))
            {
                rdb_Nam.Checked = true;

            }
            else rdb_Nu.Checked = true;


        }
        public void clear()
        {
            txt_Ma.Clear();
            txt_HoTen.Clear();
            dtp_birthday.Text = "";
            rdb_Nam.Checked = false;
            rdb_Nu.Checked = false;
            cbo_PhongBan.Text = "";
            LoadDGV();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = txt_Ma.Text.ToString();
                string HoTen = txt_HoTen.Text.ToString();
                DateTime NgaySinh = DateTime.ParseExact(dtp_birthday.Text.ToString(), ("dd-MM-yyyy"), null);
                string MaPhongBan = cbo_PhongBan.SelectedValue.ToString();
                string GioiTinh;
                if (rdb_Nam.Checked)
                {
                    GioiTinh = "Nam";
                }
                else
                    GioiTinh = "Nữ";

                if (MaNV == "" || HoTen == "" || GioiTinh == "" || MaPhongBan == "")
                {
                    MessageBox.Show("Không được điền thiếu thông tin");
                }
                else
                if (MaNV.Length > 4)
                {
                    MessageBox.Show("Mã nhân viên không quá 4 kí tự");
                }
                else
                {
                    MessageBox.Show(nhanVienServices.ThemNhanVien(
                    MaNV, HoTen,
                    NgaySinh,
                    GioiTinh,
                    MaPhongBan
                    ), "Chức năng thêm",
                    MessageBoxButtons.OKCancel);
                    clear();
                    LoadDGV();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            try
            {
                string MaNV = txt_Ma.Text.ToString();
                string HoTen = txt_HoTen.Text.ToString();
                DateTime NgaySinh = DateTime.ParseExact(dtp_birthday.Text.ToString(), ("dd-MM-yyyy"), null);
                string MaPhongBan = cbo_PhongBan.SelectedValue.ToString();
                string GioiTinh;
                if (rdb_Nam.Checked)
                {
                    GioiTinh = "Nam";
                }
                else
                    GioiTinh = "Nữ";

                if (MaNV == "" || HoTen == "" || GioiTinh == "" || MaPhongBan == "")
                {
                    MessageBox.Show("Không được điền thiếu thông tin");
                }
                else
                if (MaNV.Length > 4)
                {
                    MessageBox.Show("Mã nhân viên không quá 4 kí tự");
                }
                else
                {
                    MessageBox.Show(nhanVienServices.SuaNhanVien(
                    MaNV, HoTen,
                    NgaySinh,
                    GioiTinh,
                    MaPhongBan
                    ), "Chức năng sửa",
                    MessageBoxButtons.OKCancel);

                    clear();
                    LoadDGV();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = txt_Ma.Text.ToString();

                if (MaNV == "")
                {
                    MessageBox.Show("Bạn cần điền mã nhân viên muốn xóa");
                }
                else
                if (MaNV.Length > 4)
                {
                    MessageBox.Show("Mã nhân viên không quá 4 kí tự");
                }
                else
                {
                    MessageBox.Show(nhanVienServices.XoaNhanVien(MaNV)
                    , "Chức năng xóa",
                    MessageBoxButtons.OKCancel);

                    clear();
                    LoadDGV();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            var query = from nv in nhanVienServices.TimKiemTheoTen(txt_HoTen.Text.ToLower().ToString())
                        join pb in phongBanServices.GetAllPhongBan()
                        on nv.MaPb equals pb.MaPb
                        select
                        new

                        {
                            nv.MaNv,
                            nv.HoTen,
                            nv.NgaySinh,
                            nv.GioiTinh,
                            pb.TenPb
                        };
            dgv_Main.DataSource = query.ToList();

           

        }
    }
}
