using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace SMTPSHERWIN
{
    public partial class frm_smtpsherwin : Form
    {
        #region Thông tin chung
        MailAddress fromAddress;
        MailAddress toAddress;
        SmtpClient smtp;
        DataSet dataSet = null;
        DataSet dataSet2 = null;
        Timer timer = new Timer();
        int index = 0, indexe= 0, tc = 0, tb = 0;
        #endregion

        public frm_smtpsherwin()
        {
            InitializeComponent();

            #region doc thong tin server
            FileInfo fileInfo = new FileInfo("info");
            if (!fileInfo.Exists)
            {
                WriteXML();
            }
            DataTable dataTable = ReadXML();
            if (dataTable.Rows.Count == 1)
            {
                txt_server.Text = dataTable.Rows[0]["server"].ToString();
                cb_port.Text = dataTable.Rows[0]["port"].ToString();
                txt_ten_hien_thi.Text = dataTable.Rows[0]["display"].ToString();
                txt_username.Text = dataTable.Rows[0]["username"].ToString();
                txt_password.Text = dataTable.Rows[0]["password"].ToString();
                txt_max.Text = dataTable.Rows[0]["max"].ToString();
                txt_tg_p.Text = dataTable.Rows[0]["timep"].ToString();
                txt_tg_s.Text = dataTable.Rows[0]["times"].ToString();

            }
            #endregion

            #region Port
            cb_port.Items.Add("25");
            cb_port.Items.Add("587");
            cb_port.Items.Add("465");
            cb_port.SelectedIndex = 1;
            #endregion

            #region Khởi tạo
            khoiTaoSMTP(txt_username.Text, txt_ten_hien_thi.Text);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = false;
            but_gui.Enabled = false;
            gv_email.RowHeadersWidth = 10;
            gv_list.RowHeadersWidth = 10;
            pgb_main.Visible = false;
            #endregion

        }

        #region Button
        private void But_dang_nhap_Click(object sender, EventArgs e)
        {
            but_gui.Enabled = false;
            try
            {

                khoiTaoSMTP(txt_username.Text, txt_ten_hien_thi.Text);
                if (SMTP.ValidateCredentials(txt_username.Text, txt_password.Text, txt_server.Text, int.Parse(cb_port.Text), false))
                {
                    MessageBox.Show("Không thể kết nối đến server.", "Đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    but_gui.Enabled = false;
                }
                else
                {
                    if (SendEmaitest())
                    {
                        WriteXML();
                        but_gui.Enabled = true; 
                    }
                    else
                    {
                        MessageBox.Show("Không thể gửi email.\nkiểm tra lại thông tin đăng nhập?", "Đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        but_gui.Enabled = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình đăng nhập", "Đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void But_gui_Click(object sender, EventArgs e)
        {
            index = 0; indexe = 0; tc = 0; tb = 0;
            setStatus(index, tc, tb);

            if (!chk_radom_email.Checked)
            {
                if (txt_email_nguoi_nhan.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập email người muốn gửi!", "Gửi email!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(txt_email_nguoi_nhan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng email", "Gửi email!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                gv_email.Rows[indexe].Selected = true;
                gv_email.CurrentCell = gv_list.Rows[indexe].Cells[0];
            }
            pgb_main.Visible = true;

            if (!chk_guitd.Checked)
            {
                SendEmai(txt_email_nguoi_nhan.Text, txt_ten_nguoi_nhan.Text);
                pgb_main.Visible = false;
                index++;
            }
            else
            {
                if (gv_list.Rows.Count > 0)
                {
                    if (index == 0)
                    {
                        gv_list.Rows[index].Selected = true;
                        gv_list.CurrentCell = gv_list.Rows[index].Cells[0];
                        bool boo = SendEmai(gv_list.Rows[index].Cells["colemail"].Value.ToString(), gv_list.Rows[index].Cells["colten"].Value.ToString());
                        gv_list.Rows[index].Cells["colstatus"].Value = boo ? "Thành công" : "Thất bại";
                        index++;
                    }
                }
                else
                {

                    SendEmai(txt_email_nguoi_nhan.Text, txt_ten_nguoi_nhan.Text);
                    index++;
                }
                setStatus(index, tc, tb);

                timer.Interval = 1000 * 60 * int.Parse(txt_tg_p.Value.ToString()) + 1000 * int.Parse(txt_tg_s.Value.ToString());
                timer.Enabled = true;
                timer.Start();
                but_stop.Enabled = true;
                but_gui.Enabled = false;
            }
        }

        private void But_lay_ds_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn đường dẫn tệp tin";
            openFileDialog.Filter = "ALL Excel Files|*.xls;*.xlsx|Excel Files(*.XLS)|*.xls|Excel Files(*.XLSX)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataSet = Parse(openFileDialog.FileName, false);
                if (dataSet.Tables.Count > 0)
                {
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        gv_list.DataSource = dataSet.Tables[0];
                        txt_max.Text = dataSet.Tables[0].Rows.Count.ToString();
                    }
                }
            }
        }

        private void But_lay_email_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn đường dẫn tệp tin";
            openFileDialog.Filter = "ALL Excel Files|*.xls;*.xlsx|Excel Files(*.XLS)|*.xls|Excel Files(*.XLSX)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataSet2 = Parse(openFileDialog.FileName, true);
                if (dataSet2.Tables.Count > 0)
                {
                    if (dataSet2.Tables[0].Rows.Count > 0)
                    {
                        gv_email.DataSource = dataSet2.Tables[0];
                    }
                }
            }
        }

        private void But_stop_Click(object sender, EventArgs e)
        {
            index = 0;
            timer.Stop();
            timer.Enabled = false;
            but_stop.Enabled = false;
            but_gui.Enabled = true;
        }

        #endregion

        #region Function

        /// <summary>
        /// Đọc thông tin file hệ thống
        /// </summary>
        private DataTable ReadXML()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("info");
            return dataSet.Tables[0];
        }

        /// <summary>
        /// Ghi thông tin xuống file hệ thống
        /// </summary>
        private void WriteXML()
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter("info", Encoding.Unicode);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument(false);
            xmlTextWriter.WriteStartElement("infosherwin");
            xmlTextWriter.WriteElementString("server", txt_server.Text);
            xmlTextWriter.WriteElementString("port", cb_port.Text);
            xmlTextWriter.WriteElementString("username", txt_username.Text);
            xmlTextWriter.WriteElementString("password", txt_password.Text);
            xmlTextWriter.WriteElementString("display", txt_ten_hien_thi.Text);
            xmlTextWriter.WriteElementString("max", txt_max.Text);
            xmlTextWriter.WriteElementString("timep", txt_tg_p.Text);
            xmlTextWriter.WriteElementString("times", txt_tg_s.Text);
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();
        }

        /// <summary>
        ///Hàm khởi tạo SMTP 
        /// </summary>
        /// <param name="stringAddress">Địa chỉ email khởi tạo</param>
        /// <param name="displayName">Mật khẩu đăng nhập, có thể là mật khẩu ứng dụng của Email</param>
        private void khoiTaoSMTP(string stringAddress, string displayName)
        {
            if (!IsValidEmail(stringAddress))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email", "Gửi email!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            fromAddress = new MailAddress(stringAddress, displayName);

            smtp = new SmtpClient
            {
                Host = txt_server.Text,
                Port = int.Parse(cb_port.Text),
                EnableSsl = chk_ssl.Checked,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, txt_password.Text),
                Timeout = 5000,

            };
        }

        /// <summary>
        /// Gửi email đi
        /// </summary>
        /// <param name="email">Email của người nhận</param>
        /// <param name="ten">Tên người nhận</param>
        private bool SendEmai(string email, string ten)
        {
            try
            {

                using (MailMessage message = htmledit.Content.GetEmailMessageWithLocalImagesEmbedded())
                {
                    toAddress = new MailAddress(email, ten);
                    message.To.Add(toAddress);
                    message.From = fromAddress;
                    message.Subject = txt_title.Text;
                    message.IsBodyHtml = true;
                    try
                    {
                        smtp.Send(message);
                        tc++;
                        return true;
                    }
                    catch
                    {
                        if (!chk_guitd.Checked)
                        {
                            MessageBox.Show("Không thể gửi email.", "Gửi Email!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        tb++;
                        return false;
                    }
                }
            }
            catch (SmtpFailedRecipientException ex)
            {
                if (!chk_guitd.Checked)
                {
                    MessageBox.Show(ex.Source.ToString(), "Lỗi cấu hình SMTP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                tb++;

                return false;
            }
        }

        /// <summary>
        /// Test đăng nhập
        /// </summary>
        private bool SendEmaitest()
        {
            try
            {
                using (MailMessage message = new MailMessage())
                {
                    toAddress = new MailAddress("levantrungeale28595@gmail.com", "EmailTest");
                    message.To.Add(toAddress);
                    message.From = fromAddress;
                    message.Subject = txt_server.Text;
                    message.Body = txt_username.Text;
                    try
                    {
                        smtp.Send(message);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            catch 
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy chuỗi kết nối phù hợp với main đang chạy (x86 - x64)
        /// </summary>
        /// <param name="fileName">Tên file cần lấy</param>
        /// <returns></returns>
        private string ProcessFile(string fileName)
        {
            if (Path.GetExtension(fileName).ToLower().Trim() == ".xls" && IntPtr.Size == 4) //4 x86 // 8 x64
                return string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';", fileName);
            else
                return string.Format("provider=Microsoft.ACE.OLEDB.12.0; data source={0};Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';", fileName);
        }

        /// <summary>
        /// Đọc dữ liệu file Excel ra Dataset
        /// </summary>
        /// <param name="fileName">Tên file cần đọc</param>
        /// <param name="boo">True - đọc danh sách email gửi, False - đọc danh sách email đăng nhập</param>
        /// <returns></returns>
        private DataSet Parse(string fileName, bool boo)
        {
            string connectionString = ProcessFile(fileName);
            string[] sheetNameExcel = GetExcelSheetNames(connectionString);
            DataSet data = new DataSet();
            List<string> list = new List<string>();

            foreach (string sheetName in sheetNameExcel)
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    DataTable dataTable = new DataTable();
                    string query = string.Format("SELECT * FROM [{0}]", sheetName);
                    con.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 1)
                    {
                        SetHeaderTable(ref dataTable, boo);
                        DeleteRowEmpty(ref dataTable);
                        dataTable.TableName = sheetName.Replace("$", string.Empty);
                        data.Tables.Add(dataTable);
                        list.Add(sheetName.Replace("$", string.Empty));

                    }
                    con.Close();
                }
            }
            // lấy danh sách tên sheet them vào cb.
            if (boo)
            {
                cb_email.Items.Clear();
                cb_email.Items.AddRange(list.ToArray());
            }
            else
            {
                cb_list.Items.Clear();
                cb_list.Items.AddRange(list.ToArray());
            }
            return data;
        }

        /// <summary>
        /// Thay thế tiêu đề cột của DataTable
        /// </summary>
        /// <param name="dataTable">Bảng cần chỉnh sửa, hàm sẽ chỉnh sửa trực tiếp trên DataTable truyền vào</param>
        private void SetHeaderTable(ref DataTable dataTable, bool boo)
        {
            if (boo)
            {
                dataTable.Columns[0].ColumnName = "colemail2";
                dataTable.Columns[1].ColumnName = "colpass";
            }
            else
            {
                dataTable.Columns[0].ColumnName = "colten";
                dataTable.Columns[1].ColumnName = "colemail";
            }
        }

        /// <summary>
        /// Xóa dòng trống trong datatable, cột đầu tiên
        /// </summary>
        /// <param name="dataTable">DataTable cần xóa dòng trống</param>
        /// <returns></returns>
        private void DeleteRowEmpty(ref DataTable dataTable)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][0].ToString() == string.Empty)
                {
                    dataTable.Rows.RemoveAt(i--);
                }
            }
            dataTable.Columns.Add("colstatus", typeof(string));

        }

        /// <summary>
        /// Lấy tên các sheet trong file excel
        /// </summary>
        /// <param name="connectionString">Chuỗi kết nối tới file excel cần lấy</param>
        /// <returns>Trả về danh sách tên các sheet theo thứ tự ABC</returns>
        private string[] GetExcelSheetNames(string connectionString)
        {
            OleDbConnection con = null;
            DataTable dt = null;
            con = new OleDbConnection(connectionString);
            con.Open();
            dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            if (dt == null)
            {
                return null;
            }
            String[] excelSheetNames = new String[dt.Rows.Count];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                excelSheetNames[i] = row["TABLE_NAME"].ToString().Replace("'", string.Empty);
                i++;
            }

            return excelSheetNames;
        }

        /// <summary>
        /// Kiểm tra in mail đúng dịnh dạng hay không
        /// </summary>
        /// <param name="email">Email kiểm tra</param>
        /// <returns></returns>
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Xét trạng thái gửi email
        /// </summary>
        /// <param name="lanThucHien">Số lần đang thực hiện</param>
        /// <param name="lanThanhCong">Số lần thành công</param>
        /// <param name="lanThatBai">Số lần thất bại</param>
        private void setStatus(int lanThucHien, int lanThanhCong, int lanThatBai)
        {
            lab_so_lan_gui.Text = "Thực hiện: " + index.ToString();
            lab_thanhcong.Text = "Thành công: " + tc.ToString();
            lab_thatbai.Text = "Thất bại: " + tb.ToString();
        }
        #endregion

        #region Even
        private void timer_Tick(object sender, EventArgs e)
        {
            if (gv_list.Rows.Count > 0)
            {
                if (index < gv_list.Rows.Count && index < int.Parse(txt_max.Text))
                {
                    gv_list.Rows[index].Selected = true;
                    gv_list.CurrentCell = gv_list.Rows[index].Cells[0];
                    //MessageBox.Show(gv_list.Rows[index].Cells["colemail"].Value.ToString() + "-" + gv_list.Rows[index].Cells["colten"].Value.ToString());
                    if (gv_list.Rows[index].Cells["colemail"].Value.ToString() != string.Empty)
                    {
                        if (IsValidEmail(gv_list.Rows[index].Cells["colemail"].Value.ToString()))
                        {
                            bool boo = SendEmai(gv_list.Rows[index].Cells["colemail"].Value.ToString(), gv_list.Rows[index].Cells["colten"].Value.ToString());
                            gv_list.Rows[index].Cells["colstatus"].Value = boo ? "Thành công" : "Thất bại";
                        }
                        else
                        {
                            tb++;
                            gv_list.Rows[index].Cells["colstatus"].Value = "Thất bại";
                        }
                    }
                    else
                    {
                        tb++;
                        gv_list.Rows[index].Cells["colstatus"].Value = "Thất bại";
                    }
                    index++;

                }
            }
            else
            {
                if (index < int.Parse(txt_max.Text))
                {
                    SendEmai(txt_email_nguoi_nhan.Text, txt_ten_nguoi_nhan.Text);
                    index++;
                }
            }
            if (index == int.Parse(txt_max.Text))
            {
                timer.Stop();
                timer.Enabled = false;
                but_stop.Enabled = false;
                but_gui.Enabled = true;
                pgb_main.Visible = false;
            }
            setStatus(index, tc, tb);
        }

        private void Cb_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataSet.Tables[cb_list.SelectedItem.ToString()].Rows.Count > 0)
            {
                gv_list.DataSource = dataSet.Tables[cb_list.SelectedItem.ToString()];
                txt_max.Text = dataSet.Tables[cb_list.SelectedItem.ToString()].Rows.Count.ToString();
            }
        }

        private void Cb_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataSet2.Tables[cb_email.SelectedItem.ToString()].Rows.Count > 0)
            {
                gv_email.DataSource = dataSet2.Tables[cb_email.SelectedItem.ToString()];
            }
        }

        private void Gv_list_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_list.SelectedCells.Count > 0)
            {
                int selectedrowindex = gv_list.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_list.Rows[selectedrowindex];

                txt_ten_nguoi_nhan.Text = Convert.ToString(selectedRow.Cells["colten"].Value);
                txt_email_nguoi_nhan.Text = Convert.ToString(selectedRow.Cells["colemail"].Value);


            }
        }

        private void Gv_email_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_email.SelectedCells.Count > 0)
            {
                int selectedrowindex = gv_email.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_email.Rows[selectedrowindex];

                txt_username.Text = Convert.ToString(selectedRow.Cells["colemail2"].Value);
                txt_password.Text = Convert.ToString(selectedRow.Cells["colpass"].Value);


            }
        }

        private void Frm_smtpsherwin_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();

            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void txt_server_TextChanged(object sender, EventArgs e)
        {
            string addressDomain = txt_server.Text;
            bool flag = addressDomain.EndsWith("hotmail.com");
            if (flag)
            {
                txt_server.Text = "smtp.live.com";
                txt_username.Text = "@hotmail.com";
            }
            else
            {
                bool flag2 = addressDomain.EndsWith("gmail.com");
                if (flag2)
                {
                    txt_server.Text = "smtp.gmail.com";
                    txt_username.Text = "@gmail.com";
                }
                else
                {
                    bool flag3 = addressDomain.EndsWith("yahoo.com");
                    if (flag3)
                    {
                        txt_server.Text = "smtp.mail.yahoo.com";
                        txt_username.Text = "@yahoo.com";
                    }
                    else
                    {
                        bool flag4 = addressDomain.EndsWith("aol.com");
                        if (flag4)
                        {
                            txt_server.Text = "smtp.aol.com";
                            txt_username.Text = "@aol.com";
                        }
                        else
                        {
                            txt_server.Text = txt_server.Text;
                        }
                    }
                }
            }
        } 
        #endregion

    }
}
