using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Globalization;
using System.Net;
using System.IO.Compression;
using System.Reflection;

namespace Notepad
{
    public partial class frm_notepad : Form
    {
        // ایجاد لیست Stack از نوع رشته
        Stack<string> undoList = new Stack<string>();
        string FileLocalAddress = "Null";
        // نمونه سازی از کلاس PersianCalender
        PersianCalendar PC = new PersianCalendar();
        // Variable date
        string date;
        // CurrenntDirectory
        string CurrentDirectory = Application.StartupPath;
        // Current Vesrion 
        string CurrentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public frm_notepad()
        {
            InitializeComponent();
            txt_notepad.MouseWheel += new MouseEventHandler(txt_notepad_MouseWheel);
        }

        private void txt_notepad_MouseWheel(object sender, MouseEventArgs e)
        {
            // Check if the Control key is pressed and the mouse wheel is scrolled up
            if (Control.ModifierKeys == Keys.Control && e.Delta > 0)
            {
                zoomIn();
            }
            else
                zoomOut();
        }

        private void txt_notepad_DragEnter(object sender, DragEventArgs e)
        {
            //  ذخیره ی فایل های درگ شده به textBox در آرایه
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string f in file)
            {
                if (!f.EndsWith(".txt"))
                {
                    e.Effect = DragDropEffects.None;
                }
                else
                {
                    e.Effect = DragDropEffects.All;
                }
            }
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            // exit app
            this.Close();
        }

        private void tsmi_open_Click(object sender, EventArgs e)
        {
            // مشخص کردن تنظیمات فایل دیالوگ
            ofd_openfiles.Filter = "TextFile |*.txt";
            ofd_openfiles.Title = "Open TextFile";
            ofd_openfiles.DefaultExt = ".txt";
            ofd_openfiles.Multiselect = false;
            // گرفتن نتیجه فرم فایل دیالوگ توسط Dialog Result
            DialogResult dr = ofd_openfiles.ShowDialog();
            // اگر کنسل نکرد وارد شرط شود
            if (!(dr == DialogResult.Cancel))
            {
                //ذخیره آدرس فایل وارد شده در متغییر 
                FileLocalAddress = ofd_openfiles.FileName;
                // گرفتن  فایل توسط Stream 
                Stream st = ofd_openfiles.OpenFile();
                // خواندن فایل تویط Stream Reader
                StreamReader str = new StreamReader(st);
                // تکست تکس باکس خود را مساوی نتیجه Stream Reader قرار میدیم
                txt_notepad.Text = str.ReadToEnd();
                // فایل ریدر و همگی رو بسته میکنیم
                str.Close();
                st.Close();
            }

        }

        private void tsmi_save_Click(object sender, EventArgs e)
        {
            if (!(FileLocalAddress == "Null"))
            {
                // رفتن به آدرس داده شده و ساختن از دوباره از فایل
                FileStream fs = new FileStream(FileLocalAddress, FileMode.Create);
                // نوشتن دوباره دیتای فایل
                StreamWriter swr = new StreamWriter(fs);
                // دادن دیتا برای نوشتن دوباره
                swr.Write(txt_notepad.Text);
                // بستن ریدر ها
                swr.Close();
                fs.Close();
            }
            else
            {
                // مشخص کردن تنظیمات فایل دیالوگ
                sfd_savefiles.Filter = "TextFile |*.txt";
                sfd_savefiles.Title = "Save TextFile";
                sfd_savefiles.DefaultExt = ".txt";
                // گرفتن نتیجه فرم فایل دیالوگ توسط Dialog Result
                DialogResult dr = sfd_savefiles.ShowDialog();
                if (!(dr == DialogResult.Cancel))
                {
                    // رفتن به آدرس داده شده و ساختن از دوباره از فایل
                    FileStream fs = new FileStream(sfd_savefiles.FileName, FileMode.Create);
                    // نوشتن دوباره دیتای فایل
                    StreamWriter swr = new StreamWriter(fs);
                    // دادن دیتا برای نوشتن دوباره
                    swr.Write(txt_notepad.Text);
                    // ست کردن آدرس با آدرس سیو شده فایل txt
                    FileLocalAddress = sfd_savefiles.FileName;
                    // بستن ریدر ها
                    swr.Close();
                    fs.Close();
                }
            }
        }

        private void tsmi_save_as_Click(object sender, EventArgs e)
        {
            // مشخص کردن تنظیمات فایل دیالوگ
            sfd_savefiles.Filter = "TextFile |*.txt";
            sfd_savefiles.Title = "Save TextFile";
            sfd_savefiles.DefaultExt = ".txt";
            // گرفتن نتیجه فرم فایل دیالوگ توسط Dialog Result
            DialogResult dr = sfd_savefiles.ShowDialog();
            if (!(dr == DialogResult.Cancel))
            {
                // رفتن به آدرس داده شده و ساختن از دوباره از فایل
                FileStream fs = new FileStream(sfd_savefiles.FileName, FileMode.Create);
                // نوشتن دوباره دیتای فایل
                StreamWriter swr = new StreamWriter(fs, Encoding.UTF8);
                // دادن دیتا برای نوشتن دوباره
                swr.Write(txt_notepad.Text);
                // بستن ریدر ها
                swr.Close();
                fs.Close();
            }
        }

        private void tsmi_serach_bing_Click(object sender, EventArgs e)
        {
            // ورود به بینگ و صفحه ای که جستجو شده است
            System.Diagnostics.Process.Start($"https://www.bing.com/search?q={txt_notepad.SelectedText}");
        }

        private void tsmi_select_all_Click(object sender, EventArgs e)
        {
            // استافده از تابع SelectAll  برای گرفتن کل متن تکست باکس
            txt_notepad.SelectAll();
        }
        private void timer_time_Tick(object sender, EventArgs e)
        {
            // گرفتن لحظه ای زمان در هر یک ثانیه  با استفاده از تایمر
            tsl_time_date.Text = $"{PC.GetHour(DateTime.Now).ToString().PadLeft(2, '0') + ":" + PC.GetMinute(DateTime.Now).ToString().PadLeft(2, '0') + ":" + PC.GetSecond(DateTime.Now).ToString().PadLeft(2, '0')} / {date}";
        }
        // Method Load Setting File Ini
        void LoadSettings()
        {
            // Set Address (File Name)
            var MyIni = new IniFile($@"{CurrentDirectory}\Setting.ini");
            // Size Form
            this.Size = new Size(Convert.ToInt32(MyIni.Read("SizeWidth")), Convert.ToInt32(MyIni.Read("SizeHeight")));
            // Form Size TextBox
            float size = (float)Convert.ToDouble(MyIni.Read("FontSize"));
            // FontFamily And FontSize
            txt_notepad.Font = new Font(MyIni.Read("FontName"), size);
            // Location Form X , Y
            int X = Convert.ToInt32(MyIni.Read("LocationX"));
            int Y = Convert.ToInt32(MyIni.Read("LocationY"));
            // Set Location X , Y
            this.Location = new Point(X, Y);
            // Check Wrap ON or OFF
            bool WrapMode = Convert.ToBoolean(MyIni.Read("WrapMode"));
            // Check StatusMenu ON or OFF
            bool StatusMenu = Convert.ToBoolean(MyIni.Read("StatusMenu"));
            if (WrapMode)
            {
                // TRUE
                tsmi_word_wrap.Checked = true;
                txt_notepad.WordWrap = true;
            }
            else
            {
                // FALSE
                tsmi_word_wrap.Checked = false;
                txt_notepad.WordWrap = false;

            }
            if (StatusMenu)
            {
                // TRUE
                tsmi_status_bar.Checked = true;
                sts_status.Visible = true;
            }
            else
            {
                // FALSE
                tsmi_status_bar.Checked = false;
                sts_status.Visible = false;
            }
        }

        private void frm_notepad_Load(object sender, EventArgs e)
        {
            // Load Settings
            LoadSettings();
            // گرفتن تاریخ در لحظه فرم لود
            int day = PC.GetDayOfMonth(DateTime.Now);
            int month = PC.GetMonth(DateTime.Now);
            int year = PC.GetYear(DateTime.Now);
            date = year.ToString() + "/" + month.ToString().PadLeft(2, '0') + "/" + day.ToString().PadLeft(2, '0');
            // فراخوانی متود ستون و ردیف تکست باکس
            setrowcol();
        }

        private void tsmi_time_date_Click(object sender, EventArgs e)
        {
            // اضافه کردن تازیخ و ساعت همان لحظه به روبروی نوشته با متود Past
            txt_notepad.Paste(tsl_time_date.Text);
        }
        // متود تعداد ردیف ها و موقعیت ستون ها / select
        public void setrowcol()
        {
            int row = txt_notepad.GetLineFromCharIndex(txt_notepad.SelectionStart) + 1;
            int col = txt_notepad.SelectionStart - txt_notepad.GetFirstCharIndexOfCurrentLine() + 1;
            tsl_lines_cols.Text = "Ln " + row.ToString() + ", Col " + col.ToString();

        }
        private void txt_notepad_TextChanged(object sender, EventArgs e)
        {
            // ریختن کل نوشته های تکس باکس درون لیست Stack <String>
            //undoList.Push(txt_notepad.Text);
            // فراخوانی متود
            setrowcol();
        }

        private void tsmi_undo_Click(object sender, EventArgs e)
        {
            //برگشت به کلمه حذف شده قبلی
            txt_notepad.Undo();
            txt_notepad.ClearUndo();
            //if (!(undoList.Count < 0))
            //{
            //    txt_notepad.Text = undoList.Pop();
            //}
        }

        private void tsmi_copy_Click(object sender, EventArgs e)
        {
            // در صورت select داشتن چیزی متن رو copy کن
            if (txt_notepad.SelectedText != "")
            {
                txt_notepad.Copy();
            }
            //راه حل دوم
            //Clipboard.SetText(txtnotepad.SelectedText);
        }

        private void tsmi_cut_Click(object sender, EventArgs e)
        {
            // اگر چیزی select بود cut کن
            if (txt_notepad.SelectedText != "")
            {
                txt_notepad.Cut();
            }
        }

        private void tsmi_delete_Click(object sender, EventArgs e)
        {
            // دلیت کردن فسمت select شده
            txt_notepad.SelectedText = "";
        }

        private void tsmi_past_Click(object sender, EventArgs e)
        {
            // past کردن 
            txt_notepad.Paste();
            // راه دوم
            //txt_notepad.SelectedText = Clipboard.GetText();
            //راه سوم
            //txt_notepad.AppendText(Clipboard.GetText());
        }

        private void tsl_clear_Clipboard_Click(object sender, EventArgs e)
        {
            // Clear Clipboard With This Code
            Clipboard.Clear();
        }

        private void tsmi_view_help_Click(object sender, EventArgs e)
        {
            //Soon
        }

        private void tsmi_word_wrap_Click(object sender, EventArgs e)
        {
            //  Wrap mode 
            if (tsmi_word_wrap.Checked == false)
            {
                tsmi_word_wrap.Checked = true;
                txt_notepad.WordWrap = true;
            }
            else
            {
                tsmi_word_wrap.Checked = false;
                txt_notepad.WordWrap = false;
            }
        }

        private void tsmi_font_Click(object sender, EventArgs e)
        {
            // تنظیم فونت دیالوگ بر اساس فونت فعلی 
            fdg_font.Font = txt_notepad.Font;
            // نمایش فونت دیالوگ
            DialogResult dr = fdg_font.ShowDialog();
            // اگر کنسل نکرد فونت تکست باکس مساوی فونت انتخاب شده شود
            if (dr != DialogResult.Cancel)
            {
                txt_notepad.Font = fdg_font.Font;
            }

        }

        private void txt_notepad_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string i in file)
            {
                FileLocalAddress = i;
                txt_notepad.Text = File.ReadAllText(i);
                break;
            }
        }

        private void tsmi_text_color_Click(object sender, EventArgs e)
        {
            // تنظیم رنگ فعلی با رنگ دیالوگ کولور
            cdg_color_text.Color = txt_notepad.ForeColor;
            // full open کردن دیالوگ باکس
            cdg_color_text.FullOpen = true;
            // نشان دادن دیالوگ
            DialogResult dr = cdg_color_text.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                // تنظیم رنگ جدید
                txt_notepad.ForeColor = cdg_color_text.Color;
            }
        }

        private void tsm_color_customize_Click(object sender, EventArgs e)
        {
            // توضیحات بالا 
            cdg_color_background.Color = txt_notepad.BackColor;
            DialogResult dr = cdg_color_background.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                txt_notepad.BackColor = cdg_color_background.Color;
            }
        }

        private void tsml_defult_color_Click(object sender, EventArgs e)
        {
            // تغییر رنگ بک کولور به سفید
            txt_notepad.BackColor = Color.White;
        }

        private void tsml_color_green_Click(object sender, EventArgs e)
        {
            // تغییر رنگ بک کولور به سبز
            txt_notepad.BackColor = Color.Green;
        }

        private void tsml_color_blue_Click(object sender, EventArgs e)
        {
            // تغییر رنگ بک کولور به آبی
            txt_notepad.BackColor = Color.Blue;
        }

        private void tsml_color_red_Click(object sender, EventArgs e)
        {
            // تغییر بک کولور به قرمز 
            txt_notepad.BackColor = Color.Red;
        }

        private void tsmi_status_bar_Click(object sender, EventArgs e)
        {
            if (tsmi_status_bar.Checked == true)
            {
                tsmi_status_bar.Checked = false;
                sts_status.Visible = false;
            }
            else
            {
                tsmi_status_bar.Checked = true;
                sts_status.Visible = true;
            }
        }

        private void tsmi_about_app_Click(object sender, EventArgs e)
        {
            frm_about fa = new frm_about();
            // فرم رو در Taskbar نشان ندهد
            fa.ShowInTaskbar = false;
            // نشان دادن فرم
            fa.ShowDialog();
        }
        // متود ذخیره رنگ ها و فونت در فایل txt
        public void GetLayout()
        {
            //// گرفتن آدرس و نوع کار فایل
            //FileStream fs = new FileStream(@"C:\Notepad\Layout.txt", FileMode.Create);
            //// ساخت شی از StreamWriter و دادن fs به متود
            //StreamWriter sw = new StreamWriter(fs);
            // دادن دیتا برای نوشتن دوباره دیتای فایل
            //sw.Write($"{txt_notepad.Font}\n{}\n{txt_notepad.ForeColor}");
            //File.WriteAllText(@"C:\Notepad\BackColor.txt",txt_notepad.BackColor.ToString());
            //File.WriteAllText(@"C:\Notepad\ForeColor.txt", txt_notepad.ForeColor.ToString());
            //File.WriteAllText(@"C:\Notepad\Font.txt", txt_notepad.Font.ToString());
            //// بستن فایل ها
            //sw.Close();

        }
        private void frm_notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txt_notepad.Text.Trim() == string.Empty)
            {
                UpdateSetting();
                return;
            }
            else
            {
                if (FileLocalAddress == "Null")
                {
                    DialogResult dr2 = gmd_save_or_not.Show();
                    if (dr2 == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else if (dr2 == DialogResult.Yes)
                    {
                        // مشخص کردن تنظیمات فایل دیالوگ
                        sfd_savefiles.Filter = "TextFile |*.txt";
                        sfd_savefiles.Title = "Save TextFile";
                        sfd_savefiles.DefaultExt = ".txt";
                        // گرفتن نتیجه فرم فایل دیالوگ توسط Dialog Result
                        DialogResult dr3 = sfd_savefiles.ShowDialog();
                        if (!(dr3 == DialogResult.Cancel))
                        {
                            // رفتن به آدرس داده شده و ساختن از دوباره از فایل
                            FileStream fs2 = new FileStream(sfd_savefiles.FileName, FileMode.Create);
                            // نوشتن دوباره دیتای فایل
                            StreamWriter swr2 = new StreamWriter(fs2);
                            // دادن دیتا برای نوشتن دوباره
                            swr2.Write(txt_notepad.Text);
                            // بستن ریدر ها
                            swr2.Close();
                            fs2.Close();
                            UpdateSetting();
                        }
                    }
                }
                else
                {
                    if (txt_notepad.Text != File.ReadAllText(FileLocalAddress))
                    {
                        DialogResult dr = gmd_save_or_not.Show();
                        if (dr == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                        else if (dr == DialogResult.Yes)
                        {
                            // رفتن به آدرس داده شده و ساختن از دوباره از فایل
                            FileStream fs = new FileStream(FileLocalAddress, FileMode.Create);
                            // نوشتن دوباره دیتای فایل
                            StreamWriter swr = new StreamWriter(fs, Encoding.UTF8);
                            // دادن دیتا برای نوشتن دوباره
                            swr.Write(txt_notepad.Text);
                            // بستن ریدر ها
                            swr.Close();
                            fs.Close();
                            UpdateSetting();
                        }
                    }
                }
            }
        }
        // Method For Save And Update Settings 
        void UpdateSetting()
        {
            // If File Exists Delete File 
            if (File.Exists($@"{CurrentDirectory}\Setting.ini"))
            {
                File.Delete($@"{CurrentDirectory}\Setting.ini");
            }
            // Create File Setting.ini
            FileStream fsini = new FileStream("Setting.ini", FileMode.Create);
            // Close File
            fsini.Close();
            // Set Address File (Name File)
            var MyIni = new IniFile($@"{CurrentDirectory}\Setting.ini");
            // Set Key and Value  File Ini
            MyIni.Write("BackColor", txt_notepad.BackColor.Name);
            MyIni.Write("ForeColor", txt_notepad.ForeColor.Name);
            MyIni.Write("FontSize", txt_notepad.Font.Size.ToString());
            MyIni.Write("FontName", txt_notepad.Font.Name);
            MyIni.Write("FontBold", txt_notepad.Font.Bold.ToString());
            MyIni.Write("SizeWidth", this.Size.Width.ToString());
            MyIni.Write("SizeHeight", this.Size.Height.ToString());
            MyIni.Write("LocationX", this.Location.X.ToString());
            MyIni.Write("LocationY", this.Location.Y.ToString());
            MyIni.Write("WrapMode", tsmi_word_wrap.Checked.ToString());
            MyIni.Write("StatusMenu", tsmi_status_bar.Checked.ToString());
        }
        private void tsmi_new_Click(object sender, EventArgs e)
        {
            // اگر متن داخل textbox خالی نبود وارد شرط شو
            if (txt_notepad.Text != string.Empty)
            {
                // اگر متغییر ادرس فایل خالی بود اینکارو بکن
                if (FileLocalAddress == "Null")
                {
                    DialogResult dr2 = gmd_save_or_not.Show();
                    if (dr2 == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dr2 == DialogResult.Yes)
                    {
                        // مشخص کردن تنظیمات فایل دیالوگ
                        sfd_savefiles.Filter = "TextFile |*.txt";
                        sfd_savefiles.Title = "Save TextFile";
                        sfd_savefiles.DefaultExt = ".txt";
                        // گرفتن نتیجه فرم فایل دیالوگ توسط Dialog Result
                        DialogResult dr3 = sfd_savefiles.ShowDialog();
                        if (!(dr3 == DialogResult.Cancel))
                        {
                            // رفتن به آدرس داده شده و ساختن از دوباره از فایل
                            FileStream fs2 = new FileStream(sfd_savefiles.FileName, FileMode.Create);
                            // نوشتن دوباره دیتای فایل
                            StreamWriter swr2 = new StreamWriter(fs2);
                            // دادن دیتا برای نوشتن دوباره
                            swr2.Write(txt_notepad.Text);
                            // بستن ریدر ها
                            swr2.Close();
                            fs2.Close();
                            txt_notepad.Clear();
                            FileLocalAddress = "Null";
                        }
                    }
                    else if (dr2 == DialogResult.No)
                    {
                        txt_notepad.Clear();
                    }
                }
                else
                {
                    // اگر فایل تکست باکس برابر فایل اصلی نبود این کارو بکن
                    if (txt_notepad.Text != File.ReadAllText(FileLocalAddress))
                    {
                        DialogResult dr = gmd_save_or_not.Show();
                        // اگر کنسل کرد کاری انجام نده و return کن
                        if (dr == DialogResult.Cancel)
                        {
                            return;
                        }
                        else if (dr == DialogResult.Yes)
                        {
                            // رفتن به آدرس داده شده و ساختن از دوباره از فایل
                            FileStream fs = new FileStream(FileLocalAddress, FileMode.Create);
                            // نوشتن دوباره دیتای فایل
                            StreamWriter swr = new StreamWriter(fs);
                            // دادن دیتا برای نوشتن دوباره
                            swr.Write(txt_notepad.Text);
                            // بستن ریدر ها
                            swr.Close();
                            fs.Close();
                            txt_notepad.Clear();
                            FileLocalAddress = "Null";
                        }
                        // اگر دکمه NO رو زد این کارو بکن
                        else if (dr == DialogResult.No)
                        {
                            txt_notepad.Clear();
                            FileLocalAddress = "Null";
                        }
                    }
                    // اگر فایل تکست باکس برابر فایل اصلی بود این کارو بکن
                    else
                    {
                        txt_notepad.Clear();
                        FileLocalAddress = "Null";
                    }
                }
            }
            // اگر متن داخل textbox خالی بود فقط textbox را خالی کن 
            else
            {
                // اگر آدرس داری دیتا بود این کارو انجام بده
                if (FileLocalAddress != "Null")
                {
                    txt_notepad.Clear();
                    FileLocalAddress = "Null";
                }
                // وگرنه این کارو بکن
                else
                {
                    txt_notepad.Clear();
                }
            }
        }

        private void tsmi_new_window_Click(object sender, EventArgs e)
        {
            // ساخت یک فرم دیگر مثل فرم اصلی یعنی از همون فرم یک شعی جدید میسازد و نمایش میدهد
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Notepad.exe");
        }

        private void tsmi_send_feedback_Click(object sender, EventArgs e)
        {
            // open form feedback
            frm_feedback fk = new frm_feedback();
            fk.ShowDialog();
        }

        private void tsmi_check_updates_Click(object sender, EventArgs e)
        {
            string vers = "";
            // ایجاد نمونه از WebClient
            WebClient web = new WebClient();
            try
            {
                // Download Data Version From Url
                vers = web.DownloadString("http://gloryweb.ir/");
            }
            catch (Exception)
            {
                MessageBox.Show("Server error Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentVersion != vers)
            {
                // تنظیم messagebox
                gmd_update.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                gmd_update.Caption = "Update Avalible!";
                gmd_update.Text = "Download Now?";
                gmd_update.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                // گرفتن نتیجه دیالوگ
                DialogResult dr = gmd_update.Show();
                // اگر نتیجه Yes بود وارد شرط شو
                if (dr == DialogResult.Yes)
                {
                    // دانلود کردن فایل در آدرس داده شده
                    web.DownloadFile("http://gloryweb.ir/FileUpdates/UpdateNotepad.zip", @"C:\Notepad\UpdateNotepad.zip");
                    // با استفاده از ZipFile فایل Zip را استخراج میکنیم
                    ZipFile.ExtractToDirectory(@"C:\Notepad\UpdateNotepad.zip", @"C:\Notepad");
                    // و بعد فایل نصبی را دلیت میکنیم
                    File.Delete(@"C:\Notepad\UpdateNotepad.zip");
                    // message box را نشان  میدهیم
                    gmd_complete.Show();
                }
                else
                {
                    return;
                }
            }
            else
            {
                // تنظیم Message Box و نمایش آن
                gmd_update.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                gmd_update.Caption = "No Update Avalible!";
                gmd_update.Text = " ";
                gmd_update.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                gmd_update.Show();
            }

        }

        private void tsmi_print_Click(object sender, EventArgs e)
        {
            pd_print.Document = pd_doc;
            DialogResult x = pd_print.ShowDialog();
            if (x == DialogResult.OK)
                pd_doc.Print();

        }

        private void tsmi_perview_print_Click(object sender, EventArgs e)
        {
            pd_perview.Document = pd_doc;
            pd_perview.ShowDialog();
        }

        private void pd_doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // با استفاده از کد زیر نوشته های نوت رو در page داکیومنت رسم میکند 
            e.Graphics.DrawString(txt_notepad.Text, txt_notepad.Font, Brushes.Black, 0, 0);
        }

        void zoomIn()
        {
            byte updatedSize = (byte)((byte)txt_notepad.Font.Size + 5);
            txt_notepad.Font = new Font(txt_notepad.Font.FontFamily, updatedSize);
        }
        void zoomOut()
        {

            byte updatedSize = (byte)((byte)txt_notepad.Font.Size - 5);
            txt_notepad.Font = new Font(txt_notepad.Font.FontFamily, updatedSize);
        }
        private void tsml_zoom_in_Click(object sender, EventArgs e)
        {
            zoomIn();
        }

        private void tsml_zoom_out_Click(object sender, EventArgs e)
        {
            zoomOut();
        }
    }
}
