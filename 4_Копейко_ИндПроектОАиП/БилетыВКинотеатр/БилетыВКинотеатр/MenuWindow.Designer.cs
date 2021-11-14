
namespace БилетыВКинотеатр
{
    partial class MenuWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.lblRage = new System.Windows.Forms.Label();
            this.lblGodzilla = new System.Windows.Forms.Label();
            this.lblSaw = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnRage = new System.Windows.Forms.Button();
            this.btnSaw = new System.Windows.Forms.Button();
            this.btnGodzilla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRage
            // 
            this.lblRage.Image = global::БилетыВКинотеатр.Properties.Resources._4anev323C;
            this.lblRage.Location = new System.Drawing.Point(26, 9);
            this.lblRage.Name = "lblRage";
            this.lblRage.Size = new System.Drawing.Size(231, 337);
            this.lblRage.TabIndex = 0;
            this.lblRage.Click += new System.EventHandler(this.lblRage_Click);
            // 
            // lblGodzilla
            // 
            this.lblGodzilla.Image = global::БилетыВКинотеатр.Properties.Resources.годзилла;
            this.lblGodzilla.Location = new System.Drawing.Point(263, 9);
            this.lblGodzilla.Name = "lblGodzilla";
            this.lblGodzilla.Size = new System.Drawing.Size(306, 161);
            this.lblGodzilla.TabIndex = 1;
            // 
            // lblSaw
            // 
            this.lblSaw.Image = global::БилетыВКинотеатр.Properties.Resources.Пила;
            this.lblSaw.Location = new System.Drawing.Point(263, 179);
            this.lblSaw.Name = "lblSaw";
            this.lblSaw.Size = new System.Drawing.Size(306, 167);
            this.lblSaw.TabIndex = 2;
            this.lblSaw.Click += new System.EventHandler(this.lblSaw_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(576, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.SandyBrown;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(576, 92);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 35);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnRage
            // 
            this.btnRage.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRage.Location = new System.Drawing.Point(108, 248);
            this.btnRage.Name = "btnRage";
            this.btnRage.Size = new System.Drawing.Size(75, 32);
            this.btnRage.TabIndex = 5;
            this.btnRage.Text = "Выбрать";
            this.btnRage.UseVisualStyleBackColor = false;
            this.btnRage.Click += new System.EventHandler(this.btnRage_Click);
            // 
            // btnSaw
            // 
            this.btnSaw.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSaw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaw.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaw.Location = new System.Drawing.Point(375, 302);
            this.btnSaw.Name = "btnSaw";
            this.btnSaw.Size = new System.Drawing.Size(75, 32);
            this.btnSaw.TabIndex = 6;
            this.btnSaw.Text = "Выбрать";
            this.btnSaw.UseVisualStyleBackColor = false;
            this.btnSaw.Click += new System.EventHandler(this.btnSaw_Click);
            // 
            // btnGodzilla
            // 
            this.btnGodzilla.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGodzilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGodzilla.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGodzilla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGodzilla.Location = new System.Drawing.Point(375, 124);
            this.btnGodzilla.Name = "btnGodzilla";
            this.btnGodzilla.Size = new System.Drawing.Size(75, 31);
            this.btnGodzilla.TabIndex = 7;
            this.btnGodzilla.Text = "Выбрать";
            this.btnGodzilla.UseVisualStyleBackColor = false;
            this.btnGodzilla.Click += new System.EventHandler(this.btnGodzilla_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::БилетыВКинотеатр.Properties.Resources.фонменю;
            this.ClientSize = new System.Drawing.Size(660, 358);
            this.ControlBox = false;
            this.Controls.Add(this.btnGodzilla);
            this.Controls.Add(this.btnSaw);
            this.Controls.Add(this.btnRage);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSaw);
            this.Controls.Add(this.lblGodzilla);
            this.Controls.Add(this.lblRage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuWindow";
            this.Text = "Кинотеатр \"Октябрь\"";
            this.Load += new System.EventHandler(this.MenuWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRage;
        private System.Windows.Forms.Label lblGodzilla;
        private System.Windows.Forms.Label lblSaw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRage;
        private System.Windows.Forms.Button btnSaw;
        private System.Windows.Forms.Button btnGodzilla;
    }
}

