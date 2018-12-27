namespace ColorSpectrum
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelImages = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrig = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSBlue = new System.Windows.Forms.Button();
            this.buttonSGreen = new System.Windows.Forms.Button();
            this.buttonOpenImg = new System.Windows.Forms.Button();
            this.buttonSRed = new System.Windows.Forms.Button();
            this.buttonSMono = new System.Windows.Forms.Button();
            this.pictureBoxMono = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrig)).BeginInit();
            this.tableLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMono)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelImages, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.32817F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.67183F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(708, 449);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelImages
            // 
            this.tableLayoutPanelImages.ColumnCount = 3;
            this.tableLayoutPanelImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelImages.Controls.Add(this.pictureBoxBlue, 1, 1);
            this.tableLayoutPanelImages.Controls.Add(this.pictureBoxGreen, 0, 1);
            this.tableLayoutPanelImages.Controls.Add(this.pictureBoxRed, 1, 0);
            this.tableLayoutPanelImages.Controls.Add(this.pictureBoxOrig, 0, 0);
            this.tableLayoutPanelImages.Controls.Add(this.pictureBoxMono, 2, 0);
            this.tableLayoutPanelImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelImages.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelImages.Name = "tableLayoutPanelImages";
            this.tableLayoutPanelImages.RowCount = 2;
            this.tableLayoutPanelImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelImages.Size = new System.Drawing.Size(702, 345);
            this.tableLayoutPanelImages.TabIndex = 0;
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBlue.Image = global::ColorSpectrum.Properties.Resources.background;
            this.pictureBoxBlue.Location = new System.Drawing.Point(236, 175);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(227, 167);
            this.pictureBoxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBlue.TabIndex = 3;
            this.pictureBoxBlue.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGreen.Image = global::ColorSpectrum.Properties.Resources.background;
            this.pictureBoxGreen.Location = new System.Drawing.Point(3, 175);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(227, 167);
            this.pictureBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGreen.TabIndex = 2;
            this.pictureBoxGreen.TabStop = false;
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRed.Image = global::ColorSpectrum.Properties.Resources.background;
            this.pictureBoxRed.Location = new System.Drawing.Point(236, 3);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(227, 166);
            this.pictureBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRed.TabIndex = 1;
            this.pictureBoxRed.TabStop = false;
            // 
            // pictureBoxOrig
            // 
            this.pictureBoxOrig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOrig.Image = global::ColorSpectrum.Properties.Resources.background;
            this.pictureBoxOrig.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxOrig.Name = "pictureBoxOrig";
            this.pictureBoxOrig.Size = new System.Drawing.Size(227, 166);
            this.pictureBoxOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrig.TabIndex = 0;
            this.pictureBoxOrig.TabStop = false;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 3;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSBlue, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSGreen, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonOpenImg, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSRed, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSMono, 2, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(702, 92);
            this.tableLayoutPanelButtons.TabIndex = 1;
            // 
            // buttonSBlue
            // 
            this.buttonSBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSBlue.Enabled = false;
            this.buttonSBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSBlue.ForeColor = System.Drawing.Color.Blue;
            this.buttonSBlue.Location = new System.Drawing.Point(236, 49);
            this.buttonSBlue.Name = "buttonSBlue";
            this.buttonSBlue.Size = new System.Drawing.Size(227, 40);
            this.buttonSBlue.TabIndex = 3;
            this.buttonSBlue.Text = "SAVE BLUE";
            this.buttonSBlue.UseVisualStyleBackColor = true;
            this.buttonSBlue.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSGreen
            // 
            this.buttonSGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSGreen.Enabled = false;
            this.buttonSGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSGreen.ForeColor = System.Drawing.Color.Green;
            this.buttonSGreen.Location = new System.Drawing.Point(3, 49);
            this.buttonSGreen.Name = "buttonSGreen";
            this.buttonSGreen.Size = new System.Drawing.Size(227, 40);
            this.buttonSGreen.TabIndex = 2;
            this.buttonSGreen.Text = "SAVE GREEN";
            this.buttonSGreen.UseVisualStyleBackColor = true;
            this.buttonSGreen.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpenImg
            // 
            this.buttonOpenImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenImg.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenImg.Name = "buttonOpenImg";
            this.buttonOpenImg.Size = new System.Drawing.Size(227, 40);
            this.buttonOpenImg.TabIndex = 1;
            this.buttonOpenImg.Text = "OPEN IMAGE";
            this.buttonOpenImg.UseVisualStyleBackColor = true;
            this.buttonOpenImg.Click += new System.EventHandler(this.buttonOpenImg_Click);
            // 
            // buttonSRed
            // 
            this.buttonSRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSRed.Enabled = false;
            this.buttonSRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSRed.ForeColor = System.Drawing.Color.Red;
            this.buttonSRed.Location = new System.Drawing.Point(236, 3);
            this.buttonSRed.Name = "buttonSRed";
            this.buttonSRed.Size = new System.Drawing.Size(227, 40);
            this.buttonSRed.TabIndex = 0;
            this.buttonSRed.Text = "SAVE RED";
            this.buttonSRed.UseVisualStyleBackColor = true;
            this.buttonSRed.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSMono
            // 
            this.buttonSMono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSMono.Enabled = false;
            this.buttonSMono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSMono.Location = new System.Drawing.Point(469, 3);
            this.buttonSMono.Name = "buttonSMono";
            this.buttonSMono.Size = new System.Drawing.Size(230, 40);
            this.buttonSMono.TabIndex = 4;
            this.buttonSMono.Text = "SAVE MONO";
            this.buttonSMono.UseVisualStyleBackColor = true;
            this.buttonSMono.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxMono
            // 
            this.pictureBoxMono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMono.Image = global::ColorSpectrum.Properties.Resources.background;
            this.pictureBoxMono.Location = new System.Drawing.Point(469, 3);
            this.pictureBoxMono.Name = "pictureBoxMono";
            this.pictureBoxMono.Size = new System.Drawing.Size(230, 166);
            this.pictureBoxMono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMono.TabIndex = 4;
            this.pictureBoxMono.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 449);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Color spectrum";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrig)).EndInit();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelImages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxOrig;
        private System.Windows.Forms.Button buttonSBlue;
        private System.Windows.Forms.Button buttonSGreen;
        private System.Windows.Forms.Button buttonOpenImg;
        private System.Windows.Forms.Button buttonSRed;
        private System.Windows.Forms.PictureBox pictureBoxMono;
        private System.Windows.Forms.Button buttonSMono;
    }
}

