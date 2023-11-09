namespace ExampleYOLOv7
{
    partial class FormMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_predict = new AltoControls.AltoButton();
            this.txt_imagePath = new AltoControls.BrowseFile();
            this.btn_loadModel = new AltoControls.AltoButton();
            this.txt_classesPath = new AltoControls.BrowseFile();
            this.txt_weightPath = new AltoControls.BrowseFile();
            this.lbl_result = new System.Windows.Forms.Label();
            this.loading1 = new AltoControls.SpinningCircles();
            this.bg_loadModel = new System.ComponentModel.BackgroundWorker();
            this.bg_predict = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 187);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1041, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loading1);
            this.panel1.Controls.Add(this.lbl_result);
            this.panel1.Controls.Add(this.btn_predict);
            this.panel1.Controls.Add(this.txt_imagePath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_loadModel);
            this.panel1.Controls.Add(this.txt_classesPath);
            this.panel1.Controls.Add(this.txt_weightPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 187);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Image path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Classes path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight path";
            // 
            // btn_predict
            // 
            this.btn_predict.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btn_predict.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btn_predict.BackColor = System.Drawing.Color.Transparent;
            this.btn_predict.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_predict.Enabled = false;
            this.btn_predict.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_predict.ForeColor = System.Drawing.Color.White;
            this.btn_predict.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btn_predict.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btn_predict.Location = new System.Drawing.Point(741, 102);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Radius = 6;
            this.btn_predict.Size = new System.Drawing.Size(137, 38);
            this.btn_predict.Stroke = false;
            this.btn_predict.StrokeColor = System.Drawing.Color.Gray;
            this.btn_predict.TabIndex = 7;
            this.btn_predict.Text = "Predict";
            this.btn_predict.Transparency = false;
            this.btn_predict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // txt_imagePath
            // 
            this.txt_imagePath.BackColor = System.Drawing.Color.Transparent;
            this.txt_imagePath.Br = System.Drawing.Color.LightGray;
            this.txt_imagePath.Enabled = false;
            this.txt_imagePath.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_imagePath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_imagePath.Location = new System.Drawing.Point(153, 107);
            this.txt_imagePath.Name = "txt_imagePath";
            this.txt_imagePath.Padding = new System.Windows.Forms.Padding(5);
            this.txt_imagePath.Size = new System.Drawing.Size(563, 33);
            this.txt_imagePath.TabIndex = 6;
            this.txt_imagePath.TextChanged += new System.EventHandler(this.txt_imagePath_TextChanged);
            // 
            // btn_loadModel
            // 
            this.btn_loadModel.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btn_loadModel.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btn_loadModel.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadModel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_loadModel.Enabled = false;
            this.btn_loadModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loadModel.ForeColor = System.Drawing.Color.White;
            this.btn_loadModel.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btn_loadModel.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btn_loadModel.Location = new System.Drawing.Point(741, 18);
            this.btn_loadModel.Name = "btn_loadModel";
            this.btn_loadModel.Radius = 6;
            this.btn_loadModel.Size = new System.Drawing.Size(137, 38);
            this.btn_loadModel.Stroke = false;
            this.btn_loadModel.StrokeColor = System.Drawing.Color.Gray;
            this.btn_loadModel.TabIndex = 4;
            this.btn_loadModel.Text = "Load model";
            this.btn_loadModel.Transparency = false;
            this.btn_loadModel.Click += new System.EventHandler(this.btn_loadModel_Click);
            // 
            // txt_classesPath
            // 
            this.txt_classesPath.BackColor = System.Drawing.Color.Transparent;
            this.txt_classesPath.Br = System.Drawing.Color.White;
            this.txt_classesPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_classesPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_classesPath.Location = new System.Drawing.Point(153, 61);
            this.txt_classesPath.Name = "txt_classesPath";
            this.txt_classesPath.Padding = new System.Windows.Forms.Padding(5);
            this.txt_classesPath.Size = new System.Drawing.Size(563, 33);
            this.txt_classesPath.TabIndex = 3;
            this.txt_classesPath.TextChanged += new System.EventHandler(this.txt_classesPath_TextChanged);
            // 
            // txt_weightPath
            // 
            this.txt_weightPath.BackColor = System.Drawing.Color.Transparent;
            this.txt_weightPath.Br = System.Drawing.Color.White;
            this.txt_weightPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_weightPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_weightPath.Location = new System.Drawing.Point(153, 18);
            this.txt_weightPath.Name = "txt_weightPath";
            this.txt_weightPath.Padding = new System.Windows.Forms.Padding(5);
            this.txt_weightPath.Size = new System.Drawing.Size(563, 33);
            this.txt_weightPath.TabIndex = 2;
            this.txt_weightPath.TextChanged += new System.EventHandler(this.txt_weightPath_TextChanged);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(149, 155);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(53, 21);
            this.lbl_result.TabIndex = 8;
            this.lbl_result.Text = "Result";
            // 
            // loading1
            // 
            this.loading1.BackColor = System.Drawing.Color.Transparent;
            this.loading1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loading1.FullTransparent = true;
            this.loading1.Increment = 1F;
            this.loading1.Location = new System.Drawing.Point(899, 35);
            this.loading1.N = 8;
            this.loading1.Name = "loading1";
            this.loading1.Radius = 2.5F;
            this.loading1.Size = new System.Drawing.Size(90, 85);
            this.loading1.TabIndex = 9;
            this.loading1.Text = "spinningCircles1";
            this.loading1.Visible = false;
            // 
            // bg_loadModel
            // 
            this.bg_loadModel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_loadModel_DoWork);
            this.bg_loadModel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_loadModel_RunWorkerCompleted);
            // 
            // bg_predict
            // 
            this.bg_predict.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_predict_DoWork);
            this.bg_predict.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_predict_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "YOLOcs";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AltoControls.BrowseFile txt_weightPath;
        private AltoControls.BrowseFile txt_classesPath;
        private AltoControls.AltoButton btn_loadModel;
        private AltoControls.BrowseFile txt_imagePath;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoButton btn_predict;
        private System.Windows.Forms.Label lbl_result;
        private AltoControls.SpinningCircles loading1;
        private System.ComponentModel.BackgroundWorker bg_loadModel;
        private System.ComponentModel.BackgroundWorker bg_predict;
    }
}

