namespace Accounting.App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnReportPay = new System.Windows.Forms.ToolStripButton();
            this.btnReportRecive = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewAccounting,
            this.btnReportPay,
            this.btnReportRecive});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(71, 59);
            this.btnCustomers.Text = "طرف حساب";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(72, 59);
            this.btnNewAccounting.Text = "تراکنش جدید";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.btnReportPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.Size = new System.Drawing.Size(97, 59);
            this.btnReportPay.Text = "گزارش پرداختی ها";
            this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
            // 
            // btnReportRecive
            // 
            this.btnReportRecive.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.btnReportRecive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportRecive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportRecive.Name = "btnReportRecive";
            this.btnReportRecive.Size = new System.Drawing.Size(98, 59);
            this.btnReportRecive.Text = "گزارش دریافتی ها";
            this.btnReportRecive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportRecive.Click += new System.EventHandler(this.btnReportRecive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private System.Windows.Forms.ToolStripButton btnReportPay;
        private System.Windows.Forms.ToolStripButton btnReportRecive;
    }
}

