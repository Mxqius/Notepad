
namespace Notepad
{
    partial class frm_feedback
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
            this.grs_rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rate_ok = new Guna.UI2.WinForms.Guna2Button();
            this.md_confirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // grs_rating
            // 
            this.grs_rating.BorderColor = System.Drawing.Color.Gold;
            this.grs_rating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grs_rating.Location = new System.Drawing.Point(180, 25);
            this.grs_rating.Name = "grs_rating";
            this.grs_rating.RatingColor = System.Drawing.Color.Gold;
            this.grs_rating.Size = new System.Drawing.Size(370, 66);
            this.grs_rating.TabIndex = 0;
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rating.Location = new System.Drawing.Point(20, 110);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(132, 28);
            this.lbl_rating.TabIndex = 1;
            this.lbl_rating.Text = "Rating Score :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "5";
            // 
            // btn_rate_ok
            // 
            this.btn_rate_ok.BorderRadius = 4;
            this.btn_rate_ok.CheckedState.Parent = this.btn_rate_ok;
            this.btn_rate_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rate_ok.CustomImages.Parent = this.btn_rate_ok;
            this.btn_rate_ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rate_ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rate_ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rate_ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rate_ok.DisabledState.Parent = this.btn_rate_ok;
            this.btn_rate_ok.FillColor = System.Drawing.Color.Gold;
            this.btn_rate_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rate_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_rate_ok.HoverState.Parent = this.btn_rate_ok;
            this.btn_rate_ok.Location = new System.Drawing.Point(25, 25);
            this.btn_rate_ok.Name = "btn_rate_ok";
            this.btn_rate_ok.PressedColor = System.Drawing.Color.Silver;
            this.btn_rate_ok.ShadowDecoration.Parent = this.btn_rate_ok;
            this.btn_rate_ok.Size = new System.Drawing.Size(127, 66);
            this.btn_rate_ok.TabIndex = 1;
            this.btn_rate_ok.Text = "Confrim";
            this.btn_rate_ok.Click += new System.EventHandler(this.btn_rate_ok_Click);
            // 
            // md_confirm
            // 
            this.md_confirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.md_confirm.Caption = "Feedback Result";
            this.md_confirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.md_confirm.Parent = this;
            this.md_confirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.md_confirm.Text = "You Rate Sended. Thanks for rating";
            // 
            // frm_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 162);
            this.Controls.Add(this.btn_rate_ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_rating);
            this.Controls.Add(this.grs_rating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_feedback";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RatingStar grs_rating;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_rate_ok;
        private Guna.UI2.WinForms.Guna2MessageDialog md_confirm;
    }
}