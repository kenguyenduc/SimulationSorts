using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace SimulationSorts
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        //Tao biến random chứa giá trị số ngẫu nhiên cho nút
        Random random = new Random();
        int[] M;//mảng chứa các giá trị số nguyên
        Button[] Mn;//mảng tao nút
        int HEIGHT = 50;//chiều cao lúc di chuyên của button
        int SIZE = 50;//kích thước nút
        int KhoangCachNut = 50;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBoxThuanToan.SelectedItem = null;
            comboBoxThuanToan.SelectedText = "----Chọn thuật toán----";
            radiobtnTangDan.Checked = true;
        }


        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        #region XỬ LÝ NHẬP DỮ LIỆU MẢNG TẠO NÚT
        private void btnNhapTuBanPhim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapDuLieuMang frm = new frmNhapDuLieuMang(getDataTaoNut);
            //frm.data = new frmNhapDuLieuMang.SendMessage(getData);
            frm.ShowDialog();
        }

        public void getDataTaoNut(int[] arrDuLieuMang)
        {
            int soPhanTuMang = arrDuLieuMang.Length;
            M = new int[soPhanTuMang];
            Mn = new Button[soPhanTuMang];
            //xoá giao diện cũ đi trong panel nút
            pnNut.Controls.Clear();
            for (int i = 0; i < soPhanTuMang; i++)
            {
                Button btn = new Button();
                int value = arrDuLieuMang[i];
                btn.Text = value.ToString();
                btn.Width = btn.Height = SIZE;
                btn.BackColor = Color.Orange;
                //Tạo vị trí button trên giao diện hàm point vẽ button theo trục x và y
                //Đối số 1 là trục x, đối số 2 trong hàm la trục y
                btn.Location = new Point(KhoangCachNut + pnNut.Controls.Count * (btn.Width + KhoangCachNut), pnNut.Height / 2 - btn.Height / 2);
                //ccho nút xuất hiện giữa trong panel
                //Add nút vào panel
                pnNut.Controls.Add(btn);
                //gán giá trị số ngẫu nhiên cho từng phần tử mảng
                //gán từng nút cho mảng Mn
                M[i] = value;
                Mn[i] = btn;
            }
        }

        private void btnNhapNgauNhien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoiTaoNgauNhien frm = new frmKhoiTaoNgauNhien(GetDataTaoNutNgauNhien);
            frm.ShowDialog();
        }

        public void GetDataTaoNutNgauNhien(int soPhanTuMang)
        {
            M = new int[soPhanTuMang];
            Mn = new Button[soPhanTuMang];
            //xoá giao diện cũ đi trong panel nút
            pnNut.Controls.Clear();
            for (int i = 0; i < soPhanTuMang; i++)
            {
                Button btn = new Button();
                //lấy giá trị ngẫu nhiên từ 1 đến 100
                int value = random.Next(1, 100);
                btn.Text = value.ToString();
                btn.Width = btn.Height = SIZE;
                btn.BackColor = Color.Orange;
                //Tạo vị trí button trên giao diện hàm point vẽ button theo trục x và y
                //Đối số 1 là trục x, đối số 2 trong hàm la trục y
                btn.Location = new Point(KhoangCachNut + pnNut.Controls.Count * (btn.Width + KhoangCachNut), pnNut.Height / 2 - btn.Height / 2);
                //ccho nút xuất hiện giữa trong panel
                //Add nút vào panel
                pnNut.Controls.Add(btn);
                //gán giá trị số ngẫu nhiên cho từng phần tử mảng
                //gán từng nút cho mảng Mn
                M[i] = value;
                Mn[i] = btn;
            }
        }

        private void btnNhapTuFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                    String strText = streamReader.ReadToEnd();
                    string[] arrText = strText.Split(' ');
                    int n = arrText.Length > 10 ? 10 : arrText.Length;
                    int[] arrDuLieuMang = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arrDuLieuMang[i] = int.Parse(arrText[i]);
                    }
                    getDataTaoNut(arrDuLieuMang);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

            }
        }
        #endregion

        #region XỬ LÝ ĐIỀU KHIỂN
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            switch (comboBoxThuanToan.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Bạn chưa chọn thuật toán sắp xếp");
                    break;
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4: // BubbleSort
                    bgWorkerBubbleSort.RunWorkerAsync();//gọi hàm do work
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 0 - THUẬT TOÁN SẮP XẾP Selection Sort

        #endregion

        #region 1 - THUẬT TOÁN SẮP XẾP Insertion Sort

        #endregion

        #region 2 - THUẬT TOÁN SẮP XẾP Binary Insertion Sort

        #endregion

        #region 3 - THUẬT TOÁN SẮP XẾP Interchange Sort

        #endregion

        #region 4 - THUẬT TOÁN SẮP XẾP Bubble Sort
        private void bgWorkerBubbleSort_DoWork(object sender, DoWorkEventArgs e)
        {
            //Hàm dowork xử lý thông tin nhưng ko cập nhật được giao diện
            BubbleSort(M);//truyền vào mảng M
        }

        private void BubbleSort(int[] m)
        {
            int i, j;
            StatusLocation st = new StatusLocation();//khởi tạo vi trí st
            for (i = 0; i < M.Length; i++)
            {
                for (j = M.Length - 1; j > i; j--)
                {
                    if (M[j] < M[j - 1])
                    {
                        int tam = M[j];
                        M[j] = M[j - 1];
                        M[j - 1] = tam;
                        System.Threading.Thread.Sleep(15);//delay cho nguoi dung xem  nut di chuyen
                        //tiep tuc tao ham di chuyen nut
                        DiChuyenBubbleSort(j, j - 1);
                    }
                }
            }
        }

        private void DiChuyenBubbleSort(int vt1, int vt2)
        {
            StatusLocation st = new StatusLocation();
            st.location1 = vt1;
            st.location2 = vt2;
            st.movingTypes = MovingTypes.UP_DOWN;

            for (int i = 0; i < HEIGHT; i++) //Di chuyen len xuong bang chieu cao height khoi tao ban dau
            {
                //đói số 1  là 0 , tức là ko quan tâm phần trăm chạy 
                //các bạn tưởng tượng giống phần loading của game vưa load vào
                //ơ phần mềm mính để 0 là ko quan tâm đến nó
                //đói số 2 là mấy cái vị trí của nút
                bgWorkerBubbleSort.ReportProgress(0, st); //gọi hàm _ProgressChanged để cập nhât giao diện
                System.Threading.Thread.Sleep(15);
            }

            st.movingTypes = MovingTypes.RIGHT_LEFT;
            int WIDTH = Math.Abs(vt1 - vt2) * (SIZE + KhoangCachNut);
            for (int i = 0; i < WIDTH; i++)
            {
                bgWorkerBubbleSort.ReportProgress(0, st); //gọi hàm _ProgressChanged để cập nhât giao diện
                System.Threading.Thread.Sleep(15);
            }

            st.movingTypes = MovingTypes.DOWN_UP;
            for (int i = 0; i < HEIGHT; i++) //Di chuyen len xuong bang chieu cao height khoi tao ban dau
            {
                //đói số 1  là 0 , tức là ko quan tâm phần trăm chạy 
                //các bạn tưởng tượng giống phần loading của game vưa load vào
                //ơ phần mềm mính để 0 là ko quan tâm đến nó
                //đói số 2 là mấy cái vị trí của nút
                bgWorkerBubbleSort.ReportProgress(0, st); //gọi hàm _ProgressChanged để cập nhât giao diện
                System.Threading.Thread.Sleep(15);
            }

            st.movingTypes = MovingTypes.STOP;
            bgWorkerBubbleSort.ReportProgress(0, st);
        }

        private void bgWorkerBubbleSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //cập nhật giao diện thời gian thực xong chuyển đến hàm dowork
            StatusLocation st = e.UserState as StatusLocation;

            if (st == null) return;//ko làm gì cả
            if (st.movingTypes == MovingTypes.STOP)//nếu dừng tiến trình thì thay đổi giá trị của 2 nút trong mảng
            {
                Button tam = Mn[st.location2];
                Mn[st.location2] = Mn[st.location1];
                Mn[st.location1] = tam;
                return;
            }
            Button btn1 = Mn[st.location1];
            Button btn2 = Mn[st.location2];
            if (st.movingTypes == MovingTypes.UP_DOWN)
            {
                btn1.Top = btn1.Top + 1;//nút 1 đi lên
                btn2.Top = btn2.Top - 1;//nút 2 đi xuống
            }
            else if (st.movingTypes == MovingTypes.RIGHT_LEFT)
            {
                btn1.Left = btn1.Left - 1; //nút 1 qua phải
                btn2.Left = btn2.Left + 1; //nút 2 qua trái
            }
            else if (st.movingTypes == MovingTypes.DOWN_UP)
            {
                btn1.Top = btn1.Top - 1;//nút 1 đi xuống
                btn2.Top = btn2.Top + 1;//nút 2 đi lên
            }
        }

        private void bgWorkerBubbleSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //kết thúc tiến trình cho nút màu xanh lá cây
            //chữ màu đỏ
            foreach (Button btn in pnNut.Controls)
            {
                btn.BackColor = Color.LightGreen;
                //btn.ForeColor = Color.White;

            }
            btnBatDau.Enabled = true;

            MessageBox.Show("Mảng đã được sắp xếp xong.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        #endregion

        #region 5 - THUẬT TOÁN SẮP XẾP Shaker Sort

        #endregion

        #region 6 - THUẬT TOÁN SẮP XẾP Shell Sort

        #endregion

        #region 7 - THUẬT TOÁN SẮP XẾP Heap Sort

        #endregion

        #region 8 - THUẬT TOÁN SẮP XẾP Quick Sort

        #endregion

        #region 9 - THUẬT TOÁN SẮP XẾP Merge Sort

        #endregion
    }
}
