
namespace Notepad
{
    partial class frm_notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_notepad));
            this.sts_status = new System.Windows.Forms.StatusStrip();
            this.tsl_encode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl_lines_cols = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl_time_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms_header = new System.Windows.Forms.MenuStrip();
            this.tsm_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_new_window = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_print = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_perview_print = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_past = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl_clear_Clipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_serach_bing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_select_all = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_time_date = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_format = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_word_wrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_font = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_persian = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_english = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_colors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_background_color = new System.Windows.Forms.ToolStripMenuItem();
            this.tsml_defult_color = new System.Windows.Forms.ToolStripMenuItem();
            this.tsml_color_green = new System.Windows.Forms.ToolStripMenuItem();
            this.tsml_color_blue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsml_color_red = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_color_customize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_text_color = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_view = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsml_zoom_in = new System.Windows.Forms.ToolStripMenuItem();
            this.tsml_zoom_out = new System.Windows.Forms.ToolStripMenuItem();
            this.tsml_defult_zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_status_bar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_send_feedback = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_check_updates = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about_app = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd_openfiles = new System.Windows.Forms.OpenFileDialog();
            this.sfd_savefiles = new System.Windows.Forms.SaveFileDialog();
            this.fdg_font = new System.Windows.Forms.FontDialog();
            this.cdg_color_text = new System.Windows.Forms.ColorDialog();
            this.txt_notepad = new System.Windows.Forms.TextBox();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.cdg_color_background = new System.Windows.Forms.ColorDialog();
            this.gmd_save_or_not = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.gmd_update = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.gmd_complete = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pd_print = new System.Windows.Forms.PrintDialog();
            this.pd_doc = new System.Drawing.Printing.PrintDocument();
            this.pd_perview = new System.Windows.Forms.PrintPreviewDialog();
            this.sts_status.SuspendLayout();
            this.ms_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // sts_status
            // 
            this.sts_status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sts_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_encode,
            this.tsl_lines_cols,
            this.tsl_time_date});
            this.sts_status.Location = new System.Drawing.Point(0, 499);
            this.sts_status.Name = "sts_status";
            this.sts_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sts_status.Size = new System.Drawing.Size(755, 26);
            this.sts_status.TabIndex = 4;
            this.sts_status.Text = "Footer_menu";
            // 
            // tsl_encode
            // 
            this.tsl_encode.Name = "tsl_encode";
            this.tsl_encode.Size = new System.Drawing.Size(58, 20);
            this.tsl_encode.Text = "Encode";
            // 
            // tsl_lines_cols
            // 
            this.tsl_lines_cols.Name = "tsl_lines_cols";
            this.tsl_lines_cols.Size = new System.Drawing.Size(84, 20);
            this.tsl_lines_cols.Text = "Lines / Cols";
            // 
            // tsl_time_date
            // 
            this.tsl_time_date.Name = "tsl_time_date";
            this.tsl_time_date.Size = new System.Drawing.Size(80, 20);
            this.tsl_time_date.Text = "Time/Date";
            // 
            // ms_header
            // 
            this.ms_header.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_file,
            this.tsm_edit,
            this.tsm_format,
            this.tsm_view,
            this.tsm_help});
            this.ms_header.Location = new System.Drawing.Point(0, 0);
            this.ms_header.Name = "ms_header";
            this.ms_header.Size = new System.Drawing.Size(755, 28);
            this.ms_header.TabIndex = 1;
            this.ms_header.Text = "MenuHeader";
            // 
            // tsm_file
            // 
            this.tsm_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_new,
            this.tsmi_new_window,
            this.tsmi_open,
            this.tsmi_save,
            this.tsmi_save_as,
            this.tsmi_print,
            this.tsmi_perview_print,
            this.tsmi_exit});
            this.tsm_file.Name = "tsm_file";
            this.tsm_file.Size = new System.Drawing.Size(46, 24);
            this.tsm_file.Text = "File";
            // 
            // tsmi_new
            // 
            this.tsmi_new.Image = global::Notepad.Properties.Resources.new_document;
            this.tsmi_new.Name = "tsmi_new";
            this.tsmi_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_new.Size = new System.Drawing.Size(274, 26);
            this.tsmi_new.Text = "New";
            this.tsmi_new.Click += new System.EventHandler(this.tsmi_new_Click);
            // 
            // tsmi_new_window
            // 
            this.tsmi_new_window.Image = global::Notepad.Properties.Resources.new_task;
            this.tsmi_new_window.Name = "tsmi_new_window";
            this.tsmi_new_window.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.tsmi_new_window.Size = new System.Drawing.Size(274, 26);
            this.tsmi_new_window.Text = "New Window";
            this.tsmi_new_window.Click += new System.EventHandler(this.tsmi_new_window_Click);
            // 
            // tsmi_open
            // 
            this.tsmi_open.Image = global::Notepad.Properties.Resources.open;
            this.tsmi_open.Name = "tsmi_open";
            this.tsmi_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmi_open.Size = new System.Drawing.Size(274, 26);
            this.tsmi_open.Text = "Open";
            this.tsmi_open.Click += new System.EventHandler(this.tsmi_open_Click);
            // 
            // tsmi_save
            // 
            this.tsmi_save.Image = global::Notepad.Properties.Resources.save;
            this.tsmi_save.Name = "tsmi_save";
            this.tsmi_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_save.Size = new System.Drawing.Size(274, 26);
            this.tsmi_save.Text = "Save";
            this.tsmi_save.Click += new System.EventHandler(this.tsmi_save_Click);
            // 
            // tsmi_save_as
            // 
            this.tsmi_save_as.Name = "tsmi_save_as";
            this.tsmi_save_as.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmi_save_as.Size = new System.Drawing.Size(274, 26);
            this.tsmi_save_as.Text = "Save As";
            this.tsmi_save_as.Click += new System.EventHandler(this.tsmi_save_as_Click);
            // 
            // tsmi_print
            // 
            this.tsmi_print.Image = global::Notepad.Properties.Resources.printer;
            this.tsmi_print.Name = "tsmi_print";
            this.tsmi_print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmi_print.Size = new System.Drawing.Size(274, 26);
            this.tsmi_print.Text = "Print";
            this.tsmi_print.Click += new System.EventHandler(this.tsmi_print_Click);
            // 
            // tsmi_perview_print
            // 
            this.tsmi_perview_print.Name = "tsmi_perview_print";
            this.tsmi_perview_print.Size = new System.Drawing.Size(274, 26);
            this.tsmi_perview_print.Text = "Print Perview";
            this.tsmi_perview_print.Click += new System.EventHandler(this.tsmi_perview_print_Click);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Image = global::Notepad.Properties.Resources.exit;
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(274, 26);
            this.tsmi_exit.Text = "Exit";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // tsm_edit
            // 
            this.tsm_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_undo,
            this.tsmi_cut,
            this.tsmi_copy,
            this.tsmi_past,
            this.tsmi_delete,
            this.tsl_clear_Clipboard,
            this.tsmi_serach_bing,
            this.tsmi_select_all,
            this.tsmi_time_date});
            this.tsm_edit.Name = "tsm_edit";
            this.tsm_edit.Size = new System.Drawing.Size(49, 24);
            this.tsm_edit.Text = "Edit";
            // 
            // tsmi_undo
            // 
            this.tsmi_undo.Image = global::Notepad.Properties.Resources.undo;
            this.tsmi_undo.Name = "tsmi_undo";
            this.tsmi_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmi_undo.Size = new System.Drawing.Size(255, 26);
            this.tsmi_undo.Text = "Undo";
            this.tsmi_undo.Click += new System.EventHandler(this.tsmi_undo_Click);
            // 
            // tsmi_cut
            // 
            this.tsmi_cut.Image = global::Notepad.Properties.Resources.cut;
            this.tsmi_cut.Name = "tsmi_cut";
            this.tsmi_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmi_cut.Size = new System.Drawing.Size(255, 26);
            this.tsmi_cut.Text = "Cut";
            this.tsmi_cut.Click += new System.EventHandler(this.tsmi_cut_Click);
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Image = global::Notepad.Properties.Resources.copy;
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmi_copy.Size = new System.Drawing.Size(255, 26);
            this.tsmi_copy.Text = "Copy";
            this.tsmi_copy.Click += new System.EventHandler(this.tsmi_copy_Click);
            // 
            // tsmi_past
            // 
            this.tsmi_past.Image = global::Notepad.Properties.Resources.paste;
            this.tsmi_past.Name = "tsmi_past";
            this.tsmi_past.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmi_past.Size = new System.Drawing.Size(255, 26);
            this.tsmi_past.Text = "Past";
            this.tsmi_past.Click += new System.EventHandler(this.tsmi_past_Click);
            // 
            // tsmi_delete
            // 
            this.tsmi_delete.Image = global::Notepad.Properties.Resources.delete;
            this.tsmi_delete.Name = "tsmi_delete";
            this.tsmi_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmi_delete.Size = new System.Drawing.Size(255, 26);
            this.tsmi_delete.Text = "Delete";
            this.tsmi_delete.Click += new System.EventHandler(this.tsmi_delete_Click);
            // 
            // tsl_clear_Clipboard
            // 
            this.tsl_clear_Clipboard.Image = global::Notepad.Properties.Resources.archeology;
            this.tsl_clear_Clipboard.Name = "tsl_clear_Clipboard";
            this.tsl_clear_Clipboard.Size = new System.Drawing.Size(255, 26);
            this.tsl_clear_Clipboard.Text = "Clear Clipboard";
            this.tsl_clear_Clipboard.Click += new System.EventHandler(this.tsl_clear_Clipboard_Click);
            // 
            // tsmi_serach_bing
            // 
            this.tsmi_serach_bing.Image = global::Notepad.Properties.Resources.search;
            this.tsmi_serach_bing.Name = "tsmi_serach_bing";
            this.tsmi_serach_bing.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmi_serach_bing.Size = new System.Drawing.Size(255, 26);
            this.tsmi_serach_bing.Text = "Search With Bing";
            this.tsmi_serach_bing.Click += new System.EventHandler(this.tsmi_serach_bing_Click);
            // 
            // tsmi_select_all
            // 
            this.tsmi_select_all.Image = global::Notepad.Properties.Resources.select_all;
            this.tsmi_select_all.Name = "tsmi_select_all";
            this.tsmi_select_all.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmi_select_all.Size = new System.Drawing.Size(255, 26);
            this.tsmi_select_all.Text = "Select All";
            this.tsmi_select_all.Click += new System.EventHandler(this.tsmi_select_all_Click);
            // 
            // tsmi_time_date
            // 
            this.tsmi_time_date.Image = global::Notepad.Properties.Resources.schedule;
            this.tsmi_time_date.Name = "tsmi_time_date";
            this.tsmi_time_date.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmi_time_date.Size = new System.Drawing.Size(255, 26);
            this.tsmi_time_date.Text = "Time/Date";
            this.tsmi_time_date.Click += new System.EventHandler(this.tsmi_time_date_Click);
            // 
            // tsm_format
            // 
            this.tsm_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_word_wrap,
            this.tsmi_font,
            this.languageToolStripMenuItem,
            this.tsm_colors});
            this.tsm_format.Name = "tsm_format";
            this.tsm_format.Size = new System.Drawing.Size(70, 24);
            this.tsm_format.Text = "Format";
            // 
            // tsmi_word_wrap
            // 
            this.tsmi_word_wrap.Name = "tsmi_word_wrap";
            this.tsmi_word_wrap.Size = new System.Drawing.Size(168, 26);
            this.tsmi_word_wrap.Text = "Word Wrap";
            this.tsmi_word_wrap.Click += new System.EventHandler(this.tsmi_word_wrap_Click);
            // 
            // tsmi_font
            // 
            this.tsmi_font.Image = global::Notepad.Properties.Resources.font;
            this.tsmi_font.Name = "tsmi_font";
            this.tsmi_font.Size = new System.Drawing.Size(168, 26);
            this.tsmi_font.Text = "Font";
            this.tsmi_font.Click += new System.EventHandler(this.tsmi_font_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_persian,
            this.tsmi_english});
            this.languageToolStripMenuItem.Enabled = false;
            this.languageToolStripMenuItem.Image = global::Notepad.Properties.Resources.languages;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // tsmi_persian
            // 
            this.tsmi_persian.Name = "tsmi_persian";
            this.tsmi_persian.Size = new System.Drawing.Size(139, 26);
            this.tsmi_persian.Text = "Persian";
            // 
            // tsmi_english
            // 
            this.tsmi_english.Name = "tsmi_english";
            this.tsmi_english.Size = new System.Drawing.Size(139, 26);
            this.tsmi_english.Text = "English";
            // 
            // tsm_colors
            // 
            this.tsm_colors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_background_color,
            this.tsmi_text_color});
            this.tsm_colors.Image = global::Notepad.Properties.Resources.colors;
            this.tsm_colors.Name = "tsm_colors";
            this.tsm_colors.Size = new System.Drawing.Size(168, 26);
            this.tsm_colors.Text = "Colors";
            // 
            // tsmi_background_color
            // 
            this.tsmi_background_color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsml_defult_color,
            this.tsml_color_green,
            this.tsml_color_blue,
            this.tsml_color_red,
            this.tsm_color_customize});
            this.tsmi_background_color.Image = global::Notepad.Properties.Resources.set;
            this.tsmi_background_color.Name = "tsmi_background_color";
            this.tsmi_background_color.Size = new System.Drawing.Size(171, 26);
            this.tsmi_background_color.Text = "Background";
            // 
            // tsml_defult_color
            // 
            this.tsml_defult_color.Name = "tsml_defult_color";
            this.tsml_defult_color.Size = new System.Drawing.Size(161, 26);
            this.tsml_defult_color.Text = "Defult";
            this.tsml_defult_color.Click += new System.EventHandler(this.tsml_defult_color_Click);
            // 
            // tsml_color_green
            // 
            this.tsml_color_green.Name = "tsml_color_green";
            this.tsml_color_green.Size = new System.Drawing.Size(161, 26);
            this.tsml_color_green.Text = "Green";
            this.tsml_color_green.Click += new System.EventHandler(this.tsml_color_green_Click);
            // 
            // tsml_color_blue
            // 
            this.tsml_color_blue.Name = "tsml_color_blue";
            this.tsml_color_blue.Size = new System.Drawing.Size(161, 26);
            this.tsml_color_blue.Text = "Blue";
            this.tsml_color_blue.Click += new System.EventHandler(this.tsml_color_blue_Click);
            // 
            // tsml_color_red
            // 
            this.tsml_color_red.Name = "tsml_color_red";
            this.tsml_color_red.Size = new System.Drawing.Size(161, 26);
            this.tsml_color_red.Text = "Red";
            this.tsml_color_red.Click += new System.EventHandler(this.tsml_color_red_Click);
            // 
            // tsm_color_customize
            // 
            this.tsm_color_customize.Image = global::Notepad.Properties.Resources.chromatic;
            this.tsm_color_customize.Name = "tsm_color_customize";
            this.tsm_color_customize.Size = new System.Drawing.Size(161, 26);
            this.tsm_color_customize.Text = "Customize";
            this.tsm_color_customize.Click += new System.EventHandler(this.tsm_color_customize_Click);
            // 
            // tsmi_text_color
            // 
            this.tsmi_text_color.Image = global::Notepad.Properties.Resources.color;
            this.tsmi_text_color.Name = "tsmi_text_color";
            this.tsmi_text_color.Size = new System.Drawing.Size(171, 26);
            this.tsmi_text_color.Text = "Text";
            this.tsmi_text_color.Click += new System.EventHandler(this.tsmi_text_color_Click);
            // 
            // tsm_view
            // 
            this.tsm_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_zoom,
            this.tsmi_status_bar});
            this.tsm_view.Name = "tsm_view";
            this.tsm_view.Size = new System.Drawing.Size(55, 24);
            this.tsm_view.Text = "View";
            // 
            // tsmi_zoom
            // 
            this.tsmi_zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsml_zoom_in,
            this.tsml_zoom_out,
            this.tsml_defult_zoom});
            this.tsmi_zoom.Enabled = false;
            this.tsmi_zoom.Image = global::Notepad.Properties.Resources.zoom;
            this.tsmi_zoom.Name = "tsmi_zoom";
            this.tsmi_zoom.Size = new System.Drawing.Size(158, 26);
            this.tsmi_zoom.Text = "Zoom";
            // 
            // tsml_zoom_in
            // 
            this.tsml_zoom_in.Name = "tsml_zoom_in";
            this.tsml_zoom_in.Size = new System.Drawing.Size(187, 26);
            this.tsml_zoom_in.Text = "Zoom In";
            // 
            // tsml_zoom_out
            // 
            this.tsml_zoom_out.Name = "tsml_zoom_out";
            this.tsml_zoom_out.Size = new System.Drawing.Size(187, 26);
            this.tsml_zoom_out.Text = "Zoom Out";
            // 
            // tsml_defult_zoom
            // 
            this.tsml_defult_zoom.Name = "tsml_defult_zoom";
            this.tsml_defult_zoom.Size = new System.Drawing.Size(187, 26);
            this.tsml_defult_zoom.Text = "Restore Defult";
            // 
            // tsmi_status_bar
            // 
            this.tsmi_status_bar.Checked = true;
            this.tsmi_status_bar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_status_bar.Image = global::Notepad.Properties.Resources.status;
            this.tsmi_status_bar.Name = "tsmi_status_bar";
            this.tsmi_status_bar.Size = new System.Drawing.Size(158, 26);
            this.tsmi_status_bar.Text = "Status Bar";
            this.tsmi_status_bar.Click += new System.EventHandler(this.tsmi_status_bar_Click);
            // 
            // tsm_help
            // 
            this.tsm_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_view_help,
            this.tsmi_send_feedback,
            this.tsmi_check_updates,
            this.tsmi_about_app});
            this.tsm_help.Name = "tsm_help";
            this.tsm_help.Size = new System.Drawing.Size(55, 24);
            this.tsm_help.Text = "Help";
            // 
            // tsmi_view_help
            // 
            this.tsmi_view_help.Enabled = false;
            this.tsmi_view_help.Image = global::Notepad.Properties.Resources.view_help;
            this.tsmi_view_help.Name = "tsmi_view_help";
            this.tsmi_view_help.Size = new System.Drawing.Size(196, 26);
            this.tsmi_view_help.Text = "View Help";
            this.tsmi_view_help.Click += new System.EventHandler(this.tsmi_view_help_Click);
            // 
            // tsmi_send_feedback
            // 
            this.tsmi_send_feedback.Image = global::Notepad.Properties.Resources.feedback;
            this.tsmi_send_feedback.Name = "tsmi_send_feedback";
            this.tsmi_send_feedback.Size = new System.Drawing.Size(196, 26);
            this.tsmi_send_feedback.Text = "Send Feedback";
            this.tsmi_send_feedback.Click += new System.EventHandler(this.tsmi_send_feedback_Click);
            // 
            // tsmi_check_updates
            // 
            this.tsmi_check_updates.Image = global::Notepad.Properties.Resources.update;
            this.tsmi_check_updates.Name = "tsmi_check_updates";
            this.tsmi_check_updates.Size = new System.Drawing.Size(196, 26);
            this.tsmi_check_updates.Text = "Check Updates";
            this.tsmi_check_updates.Click += new System.EventHandler(this.tsmi_check_updates_Click);
            // 
            // tsmi_about_app
            // 
            this.tsmi_about_app.Image = global::Notepad.Properties.Resources.information;
            this.tsmi_about_app.Name = "tsmi_about_app";
            this.tsmi_about_app.Size = new System.Drawing.Size(196, 26);
            this.tsmi_about_app.Text = "About Notepad";
            this.tsmi_about_app.Click += new System.EventHandler(this.tsmi_about_app_Click);
            // 
            // ofd_openfiles
            // 
            this.ofd_openfiles.FileName = "openFileDialog1";
            // 
            // txt_notepad
            // 
            this.txt_notepad.AllowDrop = true;
            this.txt_notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_notepad.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_notepad.Location = new System.Drawing.Point(0, 28);
            this.txt_notepad.MaxLength = 100000000;
            this.txt_notepad.Multiline = true;
            this.txt_notepad.Name = "txt_notepad";
            this.txt_notepad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_notepad.Size = new System.Drawing.Size(755, 471);
            this.txt_notepad.TabIndex = 0;
            this.txt_notepad.TabStop = false;
            this.txt_notepad.WordWrap = false;
            this.txt_notepad.TextChanged += new System.EventHandler(this.txt_notepad_TextChanged);
            this.txt_notepad.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_notepad_DragDrop);
            this.txt_notepad.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_notepad_DragEnter);
            // 
            // timer_time
            // 
            this.timer_time.Enabled = true;
            this.timer_time.Interval = 1000;
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // cdg_color_background
            // 
            this.cdg_color_background.FullOpen = true;
            // 
            // gmd_save_or_not
            // 
            this.gmd_save_or_not.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNoCancel;
            this.gmd_save_or_not.Caption = "Notepad";
            this.gmd_save_or_not.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.gmd_save_or_not.Parent = this;
            this.gmd_save_or_not.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.gmd_save_or_not.Text = "Do you want to save changes ?";
            // 
            // gmd_update
            // 
            this.gmd_update.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.gmd_update.Caption = "Update Avalible!";
            this.gmd_update.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.gmd_update.Parent = this;
            this.gmd_update.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.gmd_update.Text = "Download Now?";
            // 
            // gmd_complete
            // 
            this.gmd_complete.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.gmd_complete.Caption = "Update result";
            this.gmd_complete.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.gmd_complete.Parent = this;
            this.gmd_complete.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.gmd_complete.Text = "Download update complete!";
            // 
            // pd_print
            // 
            this.pd_print.AllowSelection = true;
            this.pd_print.Document = this.pd_doc;
            this.pd_print.UseEXDialog = true;
            // 
            // pd_doc
            // 
            this.pd_doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_doc_PrintPage);
            // 
            // pd_perview
            // 
            this.pd_perview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pd_perview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pd_perview.ClientSize = new System.Drawing.Size(400, 300);
            this.pd_perview.Document = this.pd_doc;
            this.pd_perview.Enabled = true;
            this.pd_perview.Icon = ((System.Drawing.Icon)(resources.GetObject("pd_perview.Icon")));
            this.pd_perview.Name = "pd_perview";
            this.pd_perview.Visible = false;
            // 
            // frm_notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 525);
            this.Controls.Add(this.txt_notepad);
            this.Controls.Add(this.sts_status);
            this.Controls.Add(this.ms_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(296, 297);
            this.Name = "frm_notepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_notepad_FormClosing);
            this.Load += new System.EventHandler(this.frm_notepad_Load);
            this.sts_status.ResumeLayout(false);
            this.sts_status.PerformLayout();
            this.ms_header.ResumeLayout(false);
            this.ms_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sts_status;
        private System.Windows.Forms.ToolStripStatusLabel tsl_encode;
        private System.Windows.Forms.ToolStripStatusLabel tsl_time_date;
        private System.Windows.Forms.MenuStrip ms_header;
        private System.Windows.Forms.ToolStripMenuItem tsm_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_open;
        private System.Windows.Forms.ToolStripMenuItem tsmi_save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_save_as;
        private System.Windows.Forms.ToolStripMenuItem tsmi_print;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem tsm_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_undo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_cut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_past;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete;
        private System.Windows.Forms.ToolStripMenuItem tsmi_serach_bing;
        private System.Windows.Forms.ToolStripMenuItem tsmi_select_all;
        private System.Windows.Forms.ToolStripMenuItem tsmi_time_date;
        private System.Windows.Forms.ToolStripMenuItem tsm_format;
        private System.Windows.Forms.ToolStripMenuItem tsmi_word_wrap;
        private System.Windows.Forms.ToolStripMenuItem tsmi_font;
        private System.Windows.Forms.ToolStripMenuItem tsm_view;
        private System.Windows.Forms.ToolStripMenuItem tsmi_zoom;
        private System.Windows.Forms.ToolStripMenuItem tsmi_status_bar;
        private System.Windows.Forms.ToolStripMenuItem tsm_help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_view_help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_send_feedback;
        private System.Windows.Forms.ToolStripMenuItem tsmi_check_updates;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about_app;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_persian;
        private System.Windows.Forms.ToolStripMenuItem tsmi_english;
        private System.Windows.Forms.ToolStripMenuItem tsm_colors;
        private System.Windows.Forms.ToolStripMenuItem tsmi_background_color;
        private System.Windows.Forms.ToolStripMenuItem tsmi_text_color;
        private System.Windows.Forms.ToolStripMenuItem tsml_defult_color;
        private System.Windows.Forms.ToolStripMenuItem tsml_color_green;
        private System.Windows.Forms.ToolStripMenuItem tsml_color_blue;
        private System.Windows.Forms.ToolStripMenuItem tsml_color_red;
        private System.Windows.Forms.ToolStripMenuItem tsm_color_customize;
        private System.Windows.Forms.ToolStripStatusLabel tsl_lines_cols;
        private System.Windows.Forms.OpenFileDialog ofd_openfiles;
        private System.Windows.Forms.SaveFileDialog sfd_savefiles;
        private System.Windows.Forms.FontDialog fdg_font;
        private System.Windows.Forms.ColorDialog cdg_color_text;
        private System.Windows.Forms.TextBox txt_notepad;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.ToolStripMenuItem tsl_clear_Clipboard;
        private System.Windows.Forms.ToolStripMenuItem tsml_zoom_in;
        private System.Windows.Forms.ToolStripMenuItem tsml_zoom_out;
        private System.Windows.Forms.ToolStripMenuItem tsml_defult_zoom;
        private System.Windows.Forms.ColorDialog cdg_color_background;
        private Guna.UI2.WinForms.Guna2MessageDialog gmd_save_or_not;
        private System.Windows.Forms.ToolStripMenuItem tsmi_new_window;
        private Guna.UI2.WinForms.Guna2MessageDialog gmd_update;
        private Guna.UI2.WinForms.Guna2MessageDialog gmd_complete;
        private System.Windows.Forms.PrintDialog pd_print;
        private System.Windows.Forms.ToolStripMenuItem tsmi_perview_print;
        private System.Windows.Forms.PrintPreviewDialog pd_perview;
        private System.Drawing.Printing.PrintDocument pd_doc;
    }
}

