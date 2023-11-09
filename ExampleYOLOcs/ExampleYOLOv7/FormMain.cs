using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMT;
using TGMTcs;

namespace ExampleYOLOv7
{
    public partial class FormMain : Form
    {
        YOLOcs yolo;

        public FormMain()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_Load(object sender, EventArgs e)
        {
            txt_weightPath.pattern = "ONXX file|*.onnx";
            txt_classesPath.pattern = "Classes file|*.names";

            TGMTregistry.GetInstance().Init("YOLOcs");
            txt_weightPath.Text = TGMTregistry.GetInstance().ReadString("txt_weightPath");
            txt_classesPath.Text = TGMTregistry.GetInstance().ReadString("txt_classesPath");
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_loadModel_Click(object sender, EventArgs e)
        {
            btn_loadModel.Enabled = false;
            loading1.Visible = true;
            bg_loadModel.RunWorkerAsync();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_weightPath_TextChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("txt_weightPath", txt_weightPath.Text);
            btn_loadModel.Enabled = txt_weightPath.Text != "" && txt_classesPath.Text != "";            
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_classesPath_TextChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("txt_classesPath", txt_classesPath.Text);
            btn_loadModel.Enabled = txt_weightPath.Text != "" && txt_classesPath.Text != "";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_imagePath_TextChanged(object sender, EventArgs e)
        {
            Predict();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnPredict_Click(object sender, EventArgs e)
        {
            Predict();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void Predict()
        {
            if (yolo == null)
                return;
            if (!File.Exists(txt_imagePath.Text))
                return;

            loading1.Visible = true;
            bg_predict.RunWorkerAsync();
            
            
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bg_loadModel_DoWork(object sender, DoWorkEventArgs e)
        {
            yolo = new YOLOcs(txt_weightPath.Text, txt_classesPath.Text, (int)txt_inputWidth.Value, (int)txt_inputHeight.Value);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bg_loadModel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loading1.Visible = false;
            btn_loadModel.Enabled = true;
            btn_predict.Enabled = true;
            txt_imagePath.Enabled = true;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bg_predict_DoWork(object sender, DoWorkEventArgs e)
        {
            YOLOresult result = yolo.Predict(txt_imagePath.Text);
            e.Result = result;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bg_predict_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            YOLOresult result = (YOLOresult)e.Result;
            lbl_result.Text = "Num objects: " + result.objects.Length.ToString() + " (" + result.elapsedMilisecond.ToString() + "ms)";
            pictureBox1.Image = result.bitmap;

            loading1.Visible = false;
        }
    }
}
