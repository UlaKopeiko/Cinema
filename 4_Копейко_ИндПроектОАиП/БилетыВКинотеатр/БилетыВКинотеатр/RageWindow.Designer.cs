
namespace БилетыВКинотеатр
{
    partial class RageWindow
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.CBTime = new System.Windows.Forms.ComboBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.TBPay = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(161, 13);
            this.monthCalendar.MaxDate = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            this.monthCalendar.MinDate = new System.DateTime(2021, 5, 21, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLine.Location = new System.Drawing.Point(13, 13);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(83, 15);
            this.lblLine.TabIndex = 1;
            this.lblLine.Text = "Выберите ряд";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlace.Location = new System.Drawing.Point(12, 86);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(97, 15);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Выберите место";
            // 
            // CBTime
            // 
            this.CBTime.FormattingEnabled = true;
            this.CBTime.Location = new System.Drawing.Point(13, 154);
            this.CBTime.Name = "CBTime";
            this.CBTime.Size = new System.Drawing.Size(121, 23);
            this.CBTime.TabIndex = 3;
            this.CBTime.Text = "Выберите время";
            // 
            // CheckBtn
            // 
            this.CheckBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBtn.Location = new System.Drawing.Point(250, 245);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckBtn.TabIndex = 4;
            this.CheckBtn.Text = "Оформить";
            this.CheckBtn.UseVisualStyleBackColor = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(447, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(161, 186);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 15);
            this.lblTime.TabIndex = 6;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(59, 245);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TBPay
            // 
            this.TBPay.Location = new System.Drawing.Point(367, 102);
            this.TBPay.MaxLength = 16;
            this.TBPay.Name = "TBPay";
            this.TBPay.Size = new System.Drawing.Size(192, 23);
            this.TBPay.TabIndex = 22;
            this.TBPay.TextChanged += new System.EventHandler(this.TBPay_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(367, 23);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(195, 60);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Цена билета: 400 рублей\r\n\r\nДля оплаты введите номер карты \r\nи номер телефона";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // RageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::БилетыВКинотеатр.Properties.Resources.фонгнева1;
            this.ClientSize = new System.Drawing.Size(587, 289);
            this.ControlBox = false;
            this.Controls.Add(this.TBPay);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.CBTime);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.monthCalendar);
            this.Name = "RageWindow";
            this.Text = "Кинотеатр \"Октябрь\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.ComboBox CBTime;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox TBPay;
        private System.Windows.Forms.Label lblPrice;
    }
}