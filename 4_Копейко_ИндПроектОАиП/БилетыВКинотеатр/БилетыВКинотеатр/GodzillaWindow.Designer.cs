
namespace БилетыВКинотеатр
{
    partial class GodzillaWindow
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
            this.TBPay = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.CBTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBPay
            // 
            this.TBPay.Location = new System.Drawing.Point(360, 98);
            this.TBPay.MaxLength = 16;
            this.TBPay.Name = "TBPay";
            this.TBPay.Size = new System.Drawing.Size(192, 23);
            this.TBPay.TabIndex = 17;
            this.TBPay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TBPay_MouseClick);
            this.TBPay.TextChanged += new System.EventHandler(this.TBPay_TextChanged);
            this.TBPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPay_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(360, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(195, 60);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Цена билета: 1000 рублей\r\n\r\nДля оплаты введите номер карты \r\nи номер телефона";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(440, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // CheckBtn
            // 
            this.CheckBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBtn.Location = new System.Drawing.Point(249, 241);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckBtn.TabIndex = 13;
            this.CheckBtn.Text = "Оформить";
            this.CheckBtn.UseVisualStyleBackColor = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click_1);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlace.Location = new System.Drawing.Point(12, 82);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(97, 15);
            this.lblPlace.TabIndex = 11;
            this.lblPlace.Text = "Выберите место";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLine.Location = new System.Drawing.Point(12, 9);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(83, 15);
            this.lblLine.TabIndex = 10;
            this.lblLine.Text = "Выберите ряд";
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar.Location = new System.Drawing.Point(160, 9);
            this.monthCalendar.MaxDate = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            this.monthCalendar.MinDate = new System.DateTime(2021, 5, 21, 7, 57, 44, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.TabIndex = 9;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged_1);
            // 
            // CBTime
            // 
            this.CBTime.FormattingEnabled = true;
            this.CBTime.Location = new System.Drawing.Point(12, 150);
            this.CBTime.Name = "CBTime";
            this.CBTime.Size = new System.Drawing.Size(121, 23);
            this.CBTime.TabIndex = 12;
            this.CBTime.Text = "Выберите время";
            this.CBTime.SelectedIndexChanged += new System.EventHandler(this.CBTime_SelectedIndexChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(160, 182);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 15);
            this.lblTime.TabIndex = 18;
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(57, 240);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GodzillaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::БилетыВКинотеатр.Properties.Resources.фонгодзиллы1;
            this.ClientSize = new System.Drawing.Size(608, 319);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.TBPay);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.CBTime);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.monthCalendar);
            this.Name = "GodzillaWindow";
            this.Text = "Кинотеатр \"Октябрь\"";
            this.Load += new System.EventHandler(this.GodzillaWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBPay;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox CBTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnBack;
    }
}