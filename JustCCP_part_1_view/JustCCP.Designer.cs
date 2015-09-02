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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.imageListButton3 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
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
            this.cutPage.Controls.Add(this.button1);
            this.cutPage.Controls.Add(this.button2);
            this.cutPage.Controls.Add(this.button3);
            this.cutPage.Controls.Add(this.button4);
            this.cutPage.Controls.Add(this.progressBar1);
            this.cutPage.Controls.Add(this.progressBar2);
            this.cutPage.Controls.Add(this.button5);
            this.cutPage.Controls.Add(this.button6);
            this.cutPage.Location = new System.Drawing.Point(4, 22);
            this.cutPage.Name = "cutPage";
            this.cutPage.Padding = new System.Windows.Forms.Padding(3);
            this.cutPage.Size = new System.Drawing.Size(362, 238);
            this.cutPage.TabIndex = 1;
            this.cutPage.Text = "Cut";
            this.cutPage.Click += new System.EventHandler(this.cutPage_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.imageListButton;
            this.button1.Location = new System.Drawing.Point(13, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Copy";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageListButton;
            this.button2.Location = new System.Drawing.Point(102, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Pause";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.imageListButton;
            this.button3.Location = new System.Drawing.Point(200, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "Skip";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 3;
            this.button4.ImageList = this.imageListButton;
            this.button4.Location = new System.Drawing.Point(285, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 29);
            this.button4.TabIndex = 21;
            this.button4.Text = "Quit";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 156);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.progressBar2.Location = new System.Drawing.Point(13, 117);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(337, 23);
            this.progressBar2.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 1;
            this.button5.ImageList = this.imageListButton3;
            this.button5.Location = new System.Drawing.Point(194, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 91);
            this.button5.TabIndex = 18;
            this.button5.Text = "Destination";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // imageListButton3
            // 
            this.imageListButton3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton3.ImageStream")));
            this.imageListButton3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton3.Images.SetKeyName(0, "DestinationIconHign.ico");
            this.imageListButton3.Images.SetKeyName(1, "DestinationIconHigh2.ico");
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 1;
            this.button6.ImageList = this.imageListButton2;
            this.button6.Location = new System.Drawing.Point(13, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 91);
            this.button6.TabIndex = 17;
            this.button6.Text = "Source";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
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
            this.totalProgressBar.Location = new System.Drawing.Point(13, 156);
            this.totalProgressBar.Name = "totalProgressBar";
            this.totalProgressBar.Size = new System.Drawing.Size(337, 23);
            this.totalProgressBar.TabIndex = 11;
            this.totalProgressBar.Click += new System.EventHandler(this.totalProgressBar_Click);
            // 
            // presentprogressBar
            // 
            this.presentprogressBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.presentprogressBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.presentprogressBar.Location = new System.Drawing.Point(13, 117);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

    }
}

