using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiPhuongNam
{
    public partial class Form1 : Form
    {
        #region vars
        private List<SmartPhone> listDienThoai;
        private int itemIndex = 0, curRow = 0;
        private const int COLUMN_MAX = 5;
        private const int ROW_HEIGHT = 300;
        private bool stateDT, statePK = false;
        #endregion

        public Form1()
        {
            InitializeComponent();    
        }
        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            tablePanelItems.Padding = new Padding(0, 0, System.Windows.Forms.SystemInformation.VerticalScrollBarWidth, 0);

          
            this.WindowState = FormWindowState.Maximized;

            tablePanelItems.ColumnCount = COLUMN_MAX;
            for (int i = 0; i < COLUMN_MAX; i++)
                tablePanelItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)100 / COLUMN_MAX));

            //Set the splitter properly
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;

            tableLayoutPanel1.RowStyles[0] = new RowStyle(SizeType.Absolute, 80);


            uscButtonN1_DienThoai_click_event();
        }
        //
        private void uscButtonN1_DienThoai_click_event()
        {
            if (stateDT == false)
            {
                statePK = false;
                resetRadioButton();

                resetPanel();
                viewAll_SmartPhone();  
            }
            stateDT = !stateDT;
        }
        //

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            if (splitContainer1.Panel2Collapsed == true)
            {
                tableLayoutPanel1.RowStyles[0] = new RowStyle(SizeType.Absolute, 80);
            }
            else
            {
                tableLayoutPanel1.RowStyles[0] = new RowStyle(SizeType.Absolute, 260);
            }
        }

        private void radioCheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            var checkedMucGia = panelMucGia.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var checkedHangSX = panelHang.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var checkedHDH = panelHDH.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            List<SmartPhone> context = new List<SmartPhone>();

            //filters
            bool tatCaHang, tatCaHDH;
            Branch hangSX =Branch.Apple;
            OS hdh = OS.Android;

            tatCaHang = false;
            tatCaHDH = false;

            //Kiểm tra Hãng SX
            if (checkedHangSX == rbSamsung)
            {
                hangSX =Branch.Samsung;
            }
            else if (checkedHangSX == rbHTC)
            {
                hangSX =Branch.HTC;
            }
            else if (checkedHangSX == rbApple)
            {
                hangSX =Branch.Apple;
            }
            else if (checkedHangSX == rbSony)
            {
                hangSX =Branch.Sony;
            }
            else if (checkedHangSX == rbAsus)
            {
                hangSX =Branch.Asus;
            }
            else // Tất cả hãng
            {
                tatCaHang = true;
            }


            //Kiểm tra Hệ Điều Hành
            if (checkedHDH == rbAndroid)
            {
                hdh = OS.Android;
            }
            else if (checkedHDH == rbIOS)
            {
                hdh = OS.iOS;
            }
            else // Tất cả HĐH
            {
                tatCaHDH = true;
            }


            for (int i = 0; i < listDienThoai.Count; i++)
            {

                if (tatCaHang || tatCaHDH)
                {
                    if (tatCaHang && tatCaHDH)
                    {
                        //Kiểm tra Mức Giá
                        if (checkedMucGia == rbDuoi2Trieu)
                        {
                            if (listDienThoai[i].DonGia < 2000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbDuoi5Trieu)
                        {
                            if (listDienThoai[i].DonGia < 5000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbDuoi10Trieu)
                        {
                            if (listDienThoai[i].DonGia < 10000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbTren10Trieu)
                        {
                            if (listDienThoai[i].DonGia > 10000000)
                                context.Add(listDienThoai[i]);
                        }
                        else // Tất cả mức giá
                        {
                            context = listDienThoai;
                            break;
                        }
                    }
                    else if (tatCaHang)
                    {
                        if (listDienThoai[i].HDH != hdh)
                            continue;
                        //Kiểm tra Mức Giá
                        if (checkedMucGia == rbDuoi2Trieu)
                        {
                            if (listDienThoai[i].DonGia < 2000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbDuoi5Trieu)
                        {
                            if (listDienThoai[i].DonGia < 5000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbDuoi10Trieu)
                        {
                            if (listDienThoai[i].DonGia < 10000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbTren10Trieu)
                        {
                            if (listDienThoai[i].DonGia > 10000000)
                                context.Add(listDienThoai[i]);
                        }
                        else // Tất cả mức giá
                        {
                            context.Add(listDienThoai[i]);
                        }
                    }
                    else if (tatCaHDH)
                    {
                        if (listDienThoai[i].HangSX != hangSX)
                            continue;
                        //Kiểm tra Mức Giá
                        if (checkedMucGia == rbDuoi2Trieu)
                        {
                            if (listDienThoai[i].DonGia < 2000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbDuoi5Trieu)
                        {
                            if (listDienThoai[i].DonGia < 5000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbDuoi10Trieu)
                        {
                            if (listDienThoai[i].DonGia < 10000000)
                                context.Add(listDienThoai[i]);
                        }
                        else if (checkedMucGia == rbTren10Trieu)
                        {
                            if (listDienThoai[i].DonGia > 10000000)
                                context.Add(listDienThoai[i]);
                        }
                        else // Tất cả mức giá
                        {
                            context.Add(listDienThoai[i]);
                        }
                    }
                }
                else
                {
                    if (listDienThoai[i].HDH != hdh || listDienThoai[i].HangSX != hangSX)
                        continue;
                    //Kiểm tra Mức Giá
                    if (checkedMucGia == rbDuoi2Trieu)
                    {
                        if (listDienThoai[i].DonGia < 2000000)
                            context.Add(listDienThoai[i]);
                    }
                    else if (checkedMucGia == rbDuoi5Trieu)
                    {
                        if (listDienThoai[i].DonGia < 5000000)
                            context.Add(listDienThoai[i]);
                    }
                    else if (checkedMucGia == rbDuoi10Trieu)
                    {
                        if (listDienThoai[i].DonGia < 10000000)
                            context.Add(listDienThoai[i]);
                    }
                    else if (checkedMucGia == rbTren10Trieu)
                    {
                        if (listDienThoai[i].DonGia > 10000000)
                            context.Add(listDienThoai[i]);
                    }
                    else // Tất cả mức giá
                    {
                        context.Add(listDienThoai[i]);
                    }
                }
            }

            //Hiện thị danh mục theo bộ lọc
            resetPanel();

            if (context.Count == 0)
            {
                Label l = new Label() { Text = "Không có sản phẩm thỏa yêu cầu", AutoSize = true };
                tablePanelItems.Controls.Add(l);
                tablePanelItems.SetColumnSpan(l, 3);
            }
            else
                hienThiListDT(context);

        }

        private void pictureSearch_Click(object sender, EventArgs e)
        {
            string tenCanTim = tboxTimKiem.Text;

            if (tenCanTim == "" || tenCanTim == null)
                return;

            resetPanel();
            if (stateDT)
                hienThiListDT(SmartPhone.LayDanhSachDTTheoTuKhoa(tenCanTim));
            else if (statePK)
              //  hienThiListPhuKien(PhuKien.LayDanhSachPKTheoTuKhoa(tenCanTim));
            if (itemIndex == 0)
            {
                Label l = new Label() { Text = "Không có kết quả với từ khóa " + tenCanTim, AutoSize = true };
                tablePanelItems.Controls.Add(l);
                tablePanelItems.SetColumnSpan(l, 3);
            }

        }

        private void tboxTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region functional
        private void addItem(Control c)
        {
            if (itemIndex % COLUMN_MAX == 0 && itemIndex != 0) // nếu hết hàng và không phải là lần đầu 
            {
                curRow++;
                tablePanelItems.RowCount += 1;
                tablePanelItems.SuspendLayout();
                tablePanelItems.RowStyles.Add(new RowStyle(SizeType.Absolute, ROW_HEIGHT));
                tablePanelItems.ResumeLayout();
            }
            tablePanelItems.Controls.Add(c, itemIndex % COLUMN_MAX, curRow);
            itemIndex++;
        }

        private void resetRadioButton()
        {
            rbTatCaHang.Checked = true;
            rbTatCaMucGia.Checked = true;
            rbTatCaHDH.Checked = true;
        }

        private void viewAll_SmartPhone()
        {
            /*
             * Hiển thị tất cả điện thoại
             */
            listDienThoai = SmartPhone.LayDanhSachTatCaDienThoai();

            //chỉnh sửa giao diện
            hienThiListDT(listDienThoai);
        }

        private void hienThiListDT(List<SmartPhone> list)
        {

            tablePanelItems.SuspendLayout();
            for (int i = 0; i < list.Count; i++)
            {
                //add item
                addItem(new phoneItem()
                {
                    BackImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(list[i].MaSP),

                    Dock = DockStyle.Fill,
                    TextDescription = list[i].TaoDescription(),
                    TextTitle = dinhDangTien(list[i].DonGia),
                    Cursor = Cursors.Hand,
                    enableDescription = true
                });
            }
            tablePanelItems.ResumeLayout();
        }

        private void resetPanel()
        {
            tablePanelItems.AutoScroll = false;
            tablePanelItems.Controls.Clear();
            tablePanelItems.RowStyles.Clear();
            tablePanelItems.AutoScroll = true;

            tablePanelItems.RowCount = 1;


            tablePanelItems.RowStyles.Add(new RowStyle(SizeType.Absolute, ROW_HEIGHT));
            tablePanelItems.RowCount += 1;
            tablePanelItems.RowStyles.Add(new RowStyle(SizeType.Absolute, ROW_HEIGHT));
            curRow = 0;
            itemIndex = 0;

        }

        private string dinhDangTien(int tien)
        {
            string temp = tien.ToString();

            int pos = temp.Length;

            for (int i = pos - 3; i >= 1; i -= 3)
                temp = temp.Insert(i, ".");

            temp += " VND";
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            if (splitContainer1.Panel2Collapsed == true)
            {
                tableLayoutPanel1.RowStyles[0] = new RowStyle(SizeType.Absolute, 80);
            }
            else
            {
                tableLayoutPanel1.RowStyles[0] = new RowStyle(SizeType.Absolute, 260);
            }
        }

        #endregion

        #region search button beauty
        private void pictureSearch_MouseEnter(object sender, EventArgs e)
        {
            pictureSearch.BackColor = Color.Transparent;
        }

        private void pictureSearch_MouseLeave(object sender, EventArgs e)
        {
            pictureSearch.BackColor = Color.White;
        }
        #endregion

       
    }
}
