namespace WindowsFormsApp3.Views
{
    partial class PetrolViewForm
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
            this.PetrolCmbBx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PriceTxtBx = new System.Windows.Forms.TextBox();
            this.LitrRdBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.PriceRdBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.LitrNumPDwn = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.PriceNumPDwn = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PayBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ShowAllPaymentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TotalPaymentLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LitrNumPDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumPDwn)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PetrolCmbBx
            // 
            this.PetrolCmbBx.Animated = true;
            this.PetrolCmbBx.AutoRoundedCorners = true;
            this.PetrolCmbBx.BackColor = System.Drawing.Color.Transparent;
            this.PetrolCmbBx.BorderRadius = 17;
            this.PetrolCmbBx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PetrolCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PetrolCmbBx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetrolCmbBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetrolCmbBx.FocusedState.Parent = this.PetrolCmbBx;
            this.PetrolCmbBx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PetrolCmbBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PetrolCmbBx.HoverState.Parent = this.PetrolCmbBx;
            this.PetrolCmbBx.ItemHeight = 30;
            this.PetrolCmbBx.ItemsAppearance.Parent = this.PetrolCmbBx;
            this.PetrolCmbBx.Location = new System.Drawing.Point(89, 52);
            this.PetrolCmbBx.Name = "PetrolCmbBx";
            this.PetrolCmbBx.ShadowDecoration.Parent = this.PetrolCmbBx;
            this.PetrolCmbBx.Size = new System.Drawing.Size(140, 36);
            this.PetrolCmbBx.TabIndex = 0;
            this.PetrolCmbBx.SelectedIndexChanged += new System.EventHandler(this.PetrolCmbBx_SelectedIndexChanged);
            // 
            // PriceTxtBx
            // 
            this.PriceTxtBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTxtBx.Location = new System.Drawing.Point(89, 117);
            this.PriceTxtBx.Name = "PriceTxtBx";
            this.PriceTxtBx.ReadOnly = true;
            this.PriceTxtBx.Size = new System.Drawing.Size(140, 25);
            this.PriceTxtBx.TabIndex = 1;
            // 
            // LitrRdBtn
            // 
            this.LitrRdBtn.AutoSize = true;
            this.LitrRdBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LitrRdBtn.CheckedState.BorderThickness = 0;
            this.LitrRdBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LitrRdBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LitrRdBtn.CheckedState.InnerOffset = -4;
            this.LitrRdBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LitrRdBtn.Location = new System.Drawing.Point(89, 204);
            this.LitrRdBtn.Name = "LitrRdBtn";
            this.LitrRdBtn.Size = new System.Drawing.Size(44, 21);
            this.LitrRdBtn.TabIndex = 2;
            this.LitrRdBtn.Text = "Litr";
            this.LitrRdBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LitrRdBtn.UncheckedState.BorderThickness = 2;
            this.LitrRdBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LitrRdBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LitrRdBtn.CheckedChanged += new System.EventHandler(this.LitrRdBtn_CheckedChanged);
            // 
            // PriceRdBtn
            // 
            this.PriceRdBtn.AutoSize = true;
            this.PriceRdBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceRdBtn.CheckedState.BorderThickness = 0;
            this.PriceRdBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceRdBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.PriceRdBtn.CheckedState.InnerOffset = -4;
            this.PriceRdBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceRdBtn.Location = new System.Drawing.Point(89, 270);
            this.PriceRdBtn.Name = "PriceRdBtn";
            this.PriceRdBtn.Size = new System.Drawing.Size(54, 21);
            this.PriceRdBtn.TabIndex = 3;
            this.PriceRdBtn.Text = "Price";
            this.PriceRdBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.PriceRdBtn.UncheckedState.BorderThickness = 2;
            this.PriceRdBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.PriceRdBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.PriceRdBtn.CheckedChanged += new System.EventHandler(this.PriceRdBtn_CheckedChanged);
            // 
            // LitrNumPDwn
            // 
            this.LitrNumPDwn.AutoRoundedCorners = true;
            this.LitrNumPDwn.BackColor = System.Drawing.Color.Transparent;
            this.LitrNumPDwn.BorderRadius = 17;
            this.LitrNumPDwn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LitrNumPDwn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LitrNumPDwn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LitrNumPDwn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LitrNumPDwn.DisabledState.Parent = this.LitrNumPDwn;
            this.LitrNumPDwn.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.LitrNumPDwn.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.LitrNumPDwn.Enabled = false;
            this.LitrNumPDwn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LitrNumPDwn.FocusedState.Parent = this.LitrNumPDwn;
            this.LitrNumPDwn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LitrNumPDwn.ForeColor = System.Drawing.Color.Black;
            this.LitrNumPDwn.Location = new System.Drawing.Point(191, 195);
            this.LitrNumPDwn.Name = "LitrNumPDwn";
            this.LitrNumPDwn.ShadowDecoration.Parent = this.LitrNumPDwn;
            this.LitrNumPDwn.Size = new System.Drawing.Size(100, 36);
            this.LitrNumPDwn.TabIndex = 4;
            this.LitrNumPDwn.UseTransparentBackground = true;
            this.LitrNumPDwn.ValueChanged += new System.EventHandler(this.LitrNumPDwn_ValueChanged);
            // 
            // PriceNumPDwn
            // 
            this.PriceNumPDwn.AutoRoundedCorners = true;
            this.PriceNumPDwn.BackColor = System.Drawing.Color.Transparent;
            this.PriceNumPDwn.BorderRadius = 17;
            this.PriceNumPDwn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceNumPDwn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceNumPDwn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceNumPDwn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceNumPDwn.DisabledState.Parent = this.PriceNumPDwn;
            this.PriceNumPDwn.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.PriceNumPDwn.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.PriceNumPDwn.Enabled = false;
            this.PriceNumPDwn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceNumPDwn.FocusedState.Parent = this.PriceNumPDwn;
            this.PriceNumPDwn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PriceNumPDwn.ForeColor = System.Drawing.Color.Black;
            this.PriceNumPDwn.Location = new System.Drawing.Point(191, 261);
            this.PriceNumPDwn.Name = "PriceNumPDwn";
            this.PriceNumPDwn.ShadowDecoration.Parent = this.PriceNumPDwn;
            this.PriceNumPDwn.Size = new System.Drawing.Size(100, 36);
            this.PriceNumPDwn.TabIndex = 5;
            this.PriceNumPDwn.UseTransparentBackground = true;
            this.PriceNumPDwn.ValueChanged += new System.EventHandler(this.PriceNumPDwn_ValueChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(324, 200);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(11, 29);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "l";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(320, 265);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(15, 29);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "$";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 56);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(47, 23);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "Petrol";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 117);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(40, 23);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.Text = "Price";
            // 
            // PayBtn
            // 
            this.PayBtn.BorderRadius = 15;
            this.PayBtn.CheckedState.Parent = this.PayBtn;
            this.PayBtn.CustomImages.Parent = this.PayBtn;
            this.PayBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.HoverState.Parent = this.PayBtn;
            this.PayBtn.Location = new System.Drawing.Point(310, 334);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.ShadowDecoration.Parent = this.PayBtn;
            this.PayBtn.Size = new System.Drawing.Size(180, 45);
            this.PayBtn.TabIndex = 10;
            this.PayBtn.Text = "Pay";
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.ShowAllPaymentBtn);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(12, 458);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(889, 100);
            this.guna2ShadowPanel1.TabIndex = 11;
            // 
            // ShowAllPaymentBtn
            // 
            this.ShowAllPaymentBtn.BorderRadius = 15;
            this.ShowAllPaymentBtn.CheckedState.Parent = this.ShowAllPaymentBtn;
            this.ShowAllPaymentBtn.CustomImages.Parent = this.ShowAllPaymentBtn;
            this.ShowAllPaymentBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShowAllPaymentBtn.ForeColor = System.Drawing.Color.White;
            this.ShowAllPaymentBtn.HoverState.Parent = this.ShowAllPaymentBtn;
            this.ShowAllPaymentBtn.Location = new System.Drawing.Point(48, 34);
            this.ShowAllPaymentBtn.Name = "ShowAllPaymentBtn";
            this.ShowAllPaymentBtn.ShadowDecoration.Parent = this.ShowAllPaymentBtn;
            this.ShowAllPaymentBtn.Size = new System.Drawing.Size(180, 45);
            this.ShowAllPaymentBtn.TabIndex = 0;
            this.ShowAllPaymentBtn.Text = "Show All Payments";
            this.ShowAllPaymentBtn.Click += new System.EventHandler(this.ShowAllPaymentBtn_Click);
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2ShadowPanel2.Controls.Add(this.TotalPaymentLbl);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(89, 323);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(202, 75);
            this.guna2ShadowPanel2.TabIndex = 12;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(177, 43);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(15, 29);
            this.guna2HtmlLabel6.TabIndex = 13;
            this.guna2HtmlLabel6.Text = "$";
            // 
            // TotalPaymentLbl
            // 
            this.TotalPaymentLbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalPaymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPaymentLbl.Location = new System.Drawing.Point(28, 24);
            this.TotalPaymentLbl.Name = "TotalPaymentLbl";
            this.TotalPaymentLbl.Size = new System.Drawing.Size(31, 26);
            this.TotalPaymentLbl.TabIndex = 0;
            this.TotalPaymentLbl.Text = "0.0";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(250, 113);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(15, 29);
            this.guna2HtmlLabel5.TabIndex = 13;
            this.guna2HtmlLabel5.Text = "$";
            // 
            // PetrolViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 570);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.PriceNumPDwn);
            this.Controls.Add(this.LitrNumPDwn);
            this.Controls.Add(this.PriceRdBtn);
            this.Controls.Add(this.LitrRdBtn);
            this.Controls.Add(this.PriceTxtBx);
            this.Controls.Add(this.PetrolCmbBx);
            this.Name = "PetrolViewForm";
            this.Text = "PetrolViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.LitrNumPDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumPDwn)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox PetrolCmbBx;
        private System.Windows.Forms.TextBox PriceTxtBx;
        private Guna.UI2.WinForms.Guna2RadioButton LitrRdBtn;
        private Guna.UI2.WinForms.Guna2RadioButton PriceRdBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown LitrNumPDwn;
        private Guna.UI2.WinForms.Guna2NumericUpDown PriceNumPDwn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button PayBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button ShowAllPaymentBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel TotalPaymentLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}