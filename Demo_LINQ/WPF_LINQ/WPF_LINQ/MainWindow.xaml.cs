using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Linq;

namespace WPF_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DataQLNVDataContext db = new DataQLNVDataContext();
        Table<NhanVien> nhanViens;
        Table<PhongBan> phongBans;
        public void load_PB()
        {
            //Load dữ liệu lên combobox
            phongBans = db.GetTable<PhongBan>();
            var query1 = from pb in phongBans
                         select new { ma = pb.MaPB, tenpb = pb.TenPB };
            cboPhongBan.ItemsSource = query1;
            cboPhongBan.DisplayMemberPath = "tenpb";
            cboPhongBan.SelectedValuePath = "ma";
        }
        public void load_Data()
        {
            //Load dữ liệu lên DataGird
            nhanViens = db.GetTable<NhanVien>();
            var query2 = from nv in nhanViens
                         select nv;

            data.ItemsSource = query2;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            load_PB();
            load_Data();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtHoTen.Text;
                nv.GioiTinh = rdNam.IsChecked == true ? true : false;
                nv.NgaySinh = Convert.ToDateTime(dpNgaySinh.Text);
                nv.SoDT = txtSDT.Text;
                nv.MaPB = cboPhongBan.SelectedValue.ToString();
                nhanViens.InsertOnSubmit(nv);
       
                db.SubmitChanges();
                load_Data();
            } catch
            {
                MessageBox.Show("Trùng mã nhân viên");
            }
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaNV.Clear();
            txtMaNV.Focus();
            txtHoTen.Clear();
            rdNam.IsChecked = true;
            dpNgaySinh.Text = DateTime.Now.ToString();
            txtSDT.Clear();
            cboPhongBan.SelectedIndex = 0;
            load_Data();

        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {

            var query = from nv in nhanViens
                        where nv.MaNV == txtMaNV.Text
                        select nv;
            foreach (var nv in query)
                nhanViens.DeleteOnSubmit(nv);
            db.SubmitChanges();
            load_Data();

        }

       
    }
}
    

