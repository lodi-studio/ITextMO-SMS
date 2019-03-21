namespace Twilio_SMS
{
    partial class Form1
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
            this.txtRecipient = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecipient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(12, 32);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Properties.Mask.EditMask = "00000000000";
            this.txtRecipient.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtRecipient.Properties.Mask.PlaceHolder = '#';
            this.txtRecipient.Properties.MaxLength = 11;
            this.txtRecipient.Size = new System.Drawing.Size(237, 20);
            this.txtRecipient.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Recipient";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 85);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.MaxLength = 100;
            this.txtMessage.Size = new System.Drawing.Size(237, 197);
            this.txtMessage.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(93, 298);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "&Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 344);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtRecipient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItexMo SMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRecipient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRecipient;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtMessage;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}

