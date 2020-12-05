namespace Practice1_WinFOrms
{
    partial class Form_Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbx_Login = new System.Windows.Forms.TextBox();
            this.txbx_Password = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbx_Login
            // 
            this.txbx_Login.Location = new System.Drawing.Point(92, 27);
            this.txbx_Login.Name = "txbx_Login";
            this.txbx_Login.Size = new System.Drawing.Size(271, 20);
            this.txbx_Login.TabIndex = 0;
            this.txbx_Login.TextChanged += new System.EventHandler(this.txbx_Login_TextChanged);
            // 
            // txbx_Password
            // 
            this.txbx_Password.Location = new System.Drawing.Point(92, 71);
            this.txbx_Password.Name = "txbx_Password";
            this.txbx_Password.Size = new System.Drawing.Size(271, 20);
            this.txbx_Password.TabIndex = 1;
            this.txbx_Password.TextChanged += new System.EventHandler(this.txbx_Password_TextChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(243, 130);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Enabled = false;
            this.btn_Confirm.Location = new System.Drawing.Point(139, 130);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 5;
            this.btn_Confirm.TabStop = false;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(42, 30);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(33, 13);
            this.lbl_Login.TabIndex = 6;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(22, 74);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password";
            // 
            // Form_Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 175);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txbx_Password);
            this.Controls.Add(this.txbx_Login);
            this.Name = "Form_Authorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Form_Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_Login;
        private System.Windows.Forms.TextBox txbx_Password;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Password;
    }
}

