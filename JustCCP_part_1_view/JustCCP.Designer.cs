namespace JustCCP_part_1_view
{
    partial class JustCCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JustCCP));
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.cutPage = new System.Windows.Forms.TabPage();
            this.cutButton = new System.Windows.Forms.Button();
            this.cutPauseButton = new System.Windows.Forms.Button();
            this.cutSkipButton = new System.Windows.Forms.Button();
            this.cutQuitButton = new System.Windows.Forms.Button();
            this.cutTotalProgressBar = new System.Windows.Forms.ProgressBar();
            this.cutPresentProgressBar = new System.Windows.Forms.ProgressBar();
            this.cutDestinationButton = new System.Windows.Forms.Button();
            this.imageListButton3 = new System.Windows.Forms.ImageList(this.components);
            this.cutSourceButton = new System.Windows.Forms.Button();
            this.imageListButton2 = new System.Windows.Forms.ImageList(this.components);
            this.copyPage = new System.Windows.Forms.TabPage();
            this.copyButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.totalProgressBar = new System.Windows.Forms.ProgressBar();
            this.presentprogressBar = new System.Windows.Forms.ProgressBar();
            this.destinationButton = new System.Windows.Forms.Button();
            this.sourceButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cutPage.SuspendLayout();
            this.copyPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListButton
            // 
            this.imageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton.ImageStream")));
            this.imageListButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton.Images.SetKeyName(0, "02_pause-512.ico");
            this.imageListButton.Images.SetKeyName(1, "copy_page-512.ico");
            this.imageListButton.Images.SetKeyName(2, "cut-512.ico");
            this.imageListButton.Images.SetKeyName(3, "quitPng.ico");
            this.imageListButton.Images.SetKeyName(4, "skip_forward-512.ico");
            this.imageListButton.Images.SetKeyName(5, "sourcePng.ico");
            this.imageListButton.Images.SetKeyName(6, "destinationPng.ico");
            this.imageListButton.Images.SetKeyName(7, "favicon(1).ico");
            this.imageListButton.Images.SetKeyName(8, "resumeIcon.ico");
            // 
            // aboutPage
            // 
            this.aboutPage.Location = new System.Drawing.Point(4, 22);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(362, 238);
            this.aboutPage.TabIndex = 3;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            this.aboutPage.Click += new System.EventHandler(this.aboutPage_Click);
            // 
            // cutPage
            // 
            this.cutPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cutPage.BackgroundImage = global::JustCCP_part_1_view.Properties.Resources.backgroundImage1;
            this.cutPage.Controls.Add(this.cutButton);
            this.cutPage.Controls.Add(this.cutPauseButton);
            this.cutPage.Controls.Add(this.cutSkipButton);
            this.cutPage.Controls.Add(this.cutQuitButton);
            this.cutPage.Controls.Add(this.cutTotalProgressBar);
            this.cutPage.Controls.Add(this.cutPresentProgressBar);
            this.cutPage.Controls.Add(this.cutDestinationButton);
            this.cutPage.Controls.Add(this.cutSourceButton);
            this.cutPage.Location = new System.Drawing.Point(4, 22);
            this.cutPage.Name = "cutPage";
            this.cutPage.Padding = new System.Windows.Forms.Padding(3);
            this.cutPage.Size = new System.Drawing.Size(362, 238);
            this.cutPage.TabIndex = 1;
            this.cutPage.Text = "Cut";
            this.cutPage.Click += new System.EventHandler(this.cutPage_Click);
            // 
            // cutButton
            // 
            this.cutButton.BackColor = System.Drawing.Color.White;
            this.cutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutButton.ImageIndex = 2;
            this.cutButton.ImageList = this.imageListButton;
            this.cutButton.Location = new System.Drawing.Point(23, 198);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(60, 29);
            this.cutButton.TabIndex = 24;
            this.cutButton.Text = "Cut";
            this.cutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cutButton.UseVisualStyleBackColor = false;
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // cutPauseButton
            // 
            this.cutPauseButton.BackColor = System.Drawing.Color.White;
            this.cutPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutPauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutPauseButton.ImageIndex = 0;
            this.cutPauseButton.ImageList = this.imageListButton;
            this.cutPauseButton.Location = new System.Drawing.Point(102, 198);
            this.cutPauseButton.Name = "cutPauseButton";
            this.cutPauseButton.Size = new System.Drawing.Size(80, 29);
            this.cutPauseButton.TabIndex = 23;
            this.cutPauseButton.Text = "Pause";
            this.cutPauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cutPauseButton.UseVisualStyleBackColor = false;
            this.cutPauseButton.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // cutSkipButton
            // 
            this.cutSkipButton.BackColor = System.Drawing.Color.White;
            this.cutSkipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutSkipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutSkipButton.ImageIndex = 4;
            this.cutSkipButton.ImageList = this.imageListButton;
            this.cutSkipButton.Location = new System.Drawing.Point(200, 198);
            this.cutSkipButton.Name = "cutSkipButton";
            this.cutSkipButton.Size = new System.Drawing.Size(68, 29);
            this.cutSkipButton.TabIndex = 22;
            this.cutSkipButton.Text = "Skip";
            this.cutSkipButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cutSkipButton.UseVisualStyleBackColor = false;
            this.cutSkipButton.Click += new System.EventHandler(this.cutSkipButton_Click);
            // 
            // cutQuitButton
            // 
            this.cutQuitButton.BackColor = System.Drawing.Color.White;
            this.cutQuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutQuitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutQuitButton.ImageIndex = 3;
            this.cutQuitButton.ImageList = this.imageListButton;
            this.cutQuitButton.Location = new System.Drawing.Point(285, 198);
            this.cutQuitButton.Name = "cutQuitButton";
            this.cutQuitButton.Size = new System.Drawing.Size(65, 29);
            this.cutQuitButton.TabIndex = 21;
            this.cutQuitButton.Text = "Quit";
            this.cutQuitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cutQuitButton.UseVisualStyleBackColor = false;
            this.cutQuitButton.Click += new System.EventHandler(this.cutQuitButton_Click);
            this.cutQuitButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cutQuitButton_KeyDown);
            // 
            // cutTotalProgressBar
            // 
            this.cutTotalProgressBar.Location = new System.Drawing.Point(13, 159);
            this.cutTotalProgressBar.Name = "cutTotalProgressBar";
            this.cutTotalProgressBar.Size = new System.Drawing.Size(337, 23);
            this.cutTotalProgressBar.TabIndex = 20;
            // 
            // cutPresentProgressBar
            // 
            this.cutPresentProgressBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cutPresentProgressBar.Location = new System.Drawing.Point(13, 120);
            this.cutPresentProgressBar.Name = "cutPresentProgressBar";
            this.cutPresentProgressBar.Size = new System.Drawing.Size(337, 23);
            this.cutPresentProgressBar.TabIndex = 19;
            // 
            // cutDestinationButton
            // 
            this.cutDestinationButton.BackColor = System.Drawing.Color.White;
            this.cutDestinationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutDestinationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutDestinationButton.ImageIndex = 1;
            this.cutDestinationButton.ImageList = this.imageListButton3;
            this.cutDestinationButton.Location = new System.Drawing.Point(194, 16);
            this.cutDestinationButton.Name = "cutDestinationButton";
            this.cutDestinationButton.Size = new System.Drawing.Size(156, 91);
            this.cutDestinationButton.TabIndex = 18;
            this.cutDestinationButton.Text = "Destination";
            this.cutDestinationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cutDestinationButton.UseVisualStyleBackColor = false;
            this.cutDestinationButton.Click += new System.EventHandler(this.cutDestinationButton_Click);
            // 
            // imageListButton3
            // 
            this.imageListButton3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton3.ImageStream")));
            this.imageListButton3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton3.Images.SetKeyName(0, "DestinationIconHign.ico");
            this.imageListButton3.Images.SetKeyName(1, "DestinationIconHigh2.ico");
            // 
            // cutSourceButton
            // 
            this.cutSourceButton.BackColor = System.Drawing.Color.White;
            this.cutSourceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutSourceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutSourceButton.ImageIndex = 1;
            this.cutSourceButton.ImageList = this.imageListButton2;
            this.cutSourceButton.Location = new System.Drawing.Point(13, 15);
            this.cutSourceButton.Name = "cutSourceButton";
            this.cutSourceButton.Size = new System.Drawing.Size(147, 91);
            this.cutSourceButton.TabIndex = 17;
            this.cutSourceButton.Text = "Source";
            this.cutSourceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cutSourceButton.UseVisualStyleBackColor = false;
            this.cutSourceButton.Click += new System.EventHandler(this.cutSourceButton_Click);
            // 
            // imageListButton2
            // 
            this.imageListButton2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton2.ImageStream")));
            this.imageListButton2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton2.Images.SetKeyName(0, "DestinationIconHign.ico");
            this.imageListButton2.Images.SetKeyName(1, "SourceIconHigh.ico");
            // 
            // copyPage
            // 
            this.copyPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.copyPage.BackgroundImage = global::JustCCP_part_1_view.Properties.Resources.backgroundImage1;
            this.copyPage.Controls.Add(this.copyButton);
            this.copyPage.Controls.Add(this.pauseButton);
            this.copyPage.Controls.Add(this.skipButton);
            this.copyPage.Controls.Add(this.quitButton);
            this.copyPage.Controls.Add(this.totalProgressBar);
            this.copyPage.Controls.Add(this.presentprogressBar);
            this.copyPage.Controls.Add(this.destinationButton);
            this.copyPage.Controls.Add(this.sourceButton);
            this.copyPage.Location = new System.Drawing.Point(4, 22);
            this.copyPage.Name = "copyPage";
            this.copyPage.Padding = new System.Windows.Forms.Padding(3);
            this.copyPage.Size = new System.Drawing.Size(362, 238);
            this.copyPage.TabIndex = 0;
            this.copyPage.Text = "Copy";
            this.copyPage.Click += new System.EventHandler(this.copyPage_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.White;
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyButton.ImageIndex = 1;
            this.copyButton.ImageList = this.imageListButton;
            this.copyButton.Location = new System.Drawing.Point(13, 198);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(69, 29);
            this.copyButton.TabIndex = 16;
            this.copyButton.Text = "Copy";
            this.copyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.White;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pauseButton.ImageIndex = 0;
            this.pauseButton.ImageList = this.imageListButton;
            this.pauseButton.Location = new System.Drawing.Point(102, 198);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(80, 29);
            this.pauseButton.TabIndex = 15;
            this.pauseButton.Text = "Pause";
            this.pauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.White;
            this.skipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skipButton.ImageIndex = 4;
            this.skipButton.ImageList = this.imageListButton;
            this.skipButton.Location = new System.Drawing.Point(200, 198);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(68, 29);
            this.skipButton.TabIndex = 14;
            this.skipButton.Text = "Skip";
            this.skipButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.White;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitButton.ImageIndex = 3;
            this.quitButton.ImageList = this.imageListButton;
            this.quitButton.Location = new System.Drawing.Point(285, 198);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(65, 29);
            this.quitButton.TabIndex = 13;
            this.quitButton.Text = "Quit";
            this.quitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // totalProgressBar
            // 
            this.totalProgressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalProgressBar.Location = new System.Drawing.Point(13, 159);
            this.totalProgressBar.Name = "totalProgressBar";
            this.totalProgressBar.Size = new System.Drawing.Size(337, 23);
            this.totalProgressBar.TabIndex = 11;
            this.totalProgressBar.Click += new System.EventHandler(this.totalProgressBar_Click);
            // 
            // presentprogressBar
            // 
            this.presentprogressBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.presentprogressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.presentprogressBar.Location = new System.Drawing.Point(13, 120);
            this.presentprogressBar.Name = "presentprogressBar";
            this.presentprogressBar.Size = new System.Drawing.Size(337, 23);
            this.presentprogressBar.TabIndex = 9;
            this.presentprogressBar.Click += new System.EventHandler(this.presentprogressBar_Click);
            // 
            // destinationButton
            // 
            this.destinationButton.BackColor = System.Drawing.Color.White;
            this.destinationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.destinationButton.ImageIndex = 1;
            this.destinationButton.ImageList = this.imageListButton3;
            this.destinationButton.Location = new System.Drawing.Point(194, 16);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(156, 91);
            this.destinationButton.TabIndex = 7;
            this.destinationButton.Text = "Destination";
            this.destinationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.destinationButton.UseVisualStyleBackColor = false;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // sourceButton
            // 
            this.sourceButton.BackColor = System.Drawing.Color.White;
            this.sourceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sourceButton.ImageIndex = 1;
            this.sourceButton.ImageList = this.imageListButton2;
            this.sourceButton.Location = new System.Drawing.Point(13, 15);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(147, 91);
            this.sourceButton.TabIndex = 4;
            this.sourceButton.Text = "Source";
            this.sourceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sourceButton.UseVisualStyleBackColor = false;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.copyPage);
            this.tabControl1.Controls.Add(this.cutPage);
            this.tabControl1.Controls.Add(this.aboutPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 264);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // JustCCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JustCCP_part_1_view.Properties.Resources.backgroundImage2;
            this.ClientSize = new System.Drawing.Size(394, 287);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "JustCCP";
            this.Text = "JustCCP";
            this.Load += new System.EventHandler(this.JustCCP_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JustCCP_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustCCP_KeyPress);
            this.cutPage.ResumeLayout(false);
            this.copyPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListButton;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.TabPage cutPage;
        private System.Windows.Forms.TabPage copyPage;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.ProgressBar totalProgressBar;
        private System.Windows.Forms.ProgressBar presentprogressBar;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.ImageList imageListButton3;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.ImageList imageListButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button cutButton;
        private System.Windows.Forms.Button cutPauseButton;
        private System.Windows.Forms.Button cutSkipButton;
        private System.Windows.Forms.Button cutQuitButton;
        private System.Windows.Forms.ProgressBar cutTotalProgressBar;
        private System.Windows.Forms.ProgressBar cutPresentProgressBar;
        private System.Windows.Forms.Button cutDestinationButton;
        private System.Windows.Forms.Button cutSourceButton;

    }
}

