namespace TransformMatrixPlayground
{
    partial class Form1
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
            matrixProductInput1 = new FourByFourMatrix();
            grpMatrixMultiply = new System.Windows.Forms.GroupBox();
            matrixProductResult = new FourByFourMatrix();
            matrixProductInput3 = new FourByFourMatrix();
            matrixProductInput2 = new FourByFourMatrix();
            matrixTransformFourByFour = new FourByFourMatrix();
            groupBox2 = new System.Windows.Forms.GroupBox();
            matrixTransformResult = new FourByOneMatrix();
            matrixTransformFourByOne = new FourByOneMatrix();
            grpScaleBuilder = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            txtScaleBuilderZ = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtScaleBuilderY = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtScaleBuilderX = new System.Windows.Forms.TextBox();
            matrixScaleBuilderResult = new FourByFourMatrix();
            grpRotationBuilder = new System.Windows.Forms.GroupBox();
            txtRotationDegrees = new System.Windows.Forms.TextBox();
            matrixRotationBuilderResult = new FourByFourMatrix();
            trkRotationDegrees = new System.Windows.Forms.TrackBar();
            label4 = new System.Windows.Forms.Label();
            grpRotationAxisRadioGroup = new System.Windows.Forms.GroupBox();
            rdoRotationAxisZ = new System.Windows.Forms.RadioButton();
            rdoRotationAxisY = new System.Windows.Forms.RadioButton();
            rdoRotationAxisX = new System.Windows.Forms.RadioButton();
            grpTranslationBuilder = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            txtTranslationBuilderZ = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtTranslationBuilderY = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtTranslationBuilderX = new System.Windows.Forms.TextBox();
            matrixTranslationBuilderResult = new FourByFourMatrix();
            grpMatrixTransformBuilder = new System.Windows.Forms.GroupBox();
            grpCompositionCalculator = new System.Windows.Forms.GroupBox();
            grpOrderRadioGroup = new System.Windows.Forms.GroupBox();
            rdoComposeTranslateRotateScale = new System.Windows.Forms.RadioButton();
            rdoComposeTranslateScaleRotate = new System.Windows.Forms.RadioButton();
            rdoComposeScaleTranslateRotate = new System.Windows.Forms.RadioButton();
            rdoComposeScaleRotateTranslate = new System.Windows.Forms.RadioButton();
            matrixCompositionResult = new FourByFourMatrix();
            grpRawValue = new System.Windows.Forms.GroupBox();
            lblRawMatrixValue = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            matrixRawValue = new FourByFourMatrix();
            grpMatrixMultiply.SuspendLayout();
            groupBox2.SuspendLayout();
            grpScaleBuilder.SuspendLayout();
            grpRotationBuilder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkRotationDegrees).BeginInit();
            grpRotationAxisRadioGroup.SuspendLayout();
            grpTranslationBuilder.SuspendLayout();
            grpMatrixTransformBuilder.SuspendLayout();
            grpCompositionCalculator.SuspendLayout();
            grpOrderRadioGroup.SuspendLayout();
            grpRawValue.SuspendLayout();
            SuspendLayout();
            // 
            // matrixProductInput1
            // 
            matrixProductInput1.Location = new System.Drawing.Point(6, 22);
            matrixProductInput1.Name = "matrixProductInput1";
            matrixProductInput1.Size = new System.Drawing.Size(229, 173);
            matrixProductInput1.TabIndex = 0;
            matrixProductInput1.Text = "4x4 Matrix";
            matrixProductInput1.MatrixChanged += matrixTransformBuilder_MatrixChanged;
            // 
            // grpMatrixMultiply
            // 
            grpMatrixMultiply.Controls.Add(matrixProductResult);
            grpMatrixMultiply.Controls.Add(matrixProductInput3);
            grpMatrixMultiply.Controls.Add(matrixProductInput2);
            grpMatrixMultiply.Controls.Add(matrixProductInput1);
            grpMatrixMultiply.Location = new System.Drawing.Point(12, 310);
            grpMatrixMultiply.Name = "grpMatrixMultiply";
            grpMatrixMultiply.Size = new System.Drawing.Size(982, 202);
            grpMatrixMultiply.TabIndex = 1;
            grpMatrixMultiply.TabStop = false;
            grpMatrixMultiply.Text = "Matrix Multiplier";
            // 
            // matrixProductResult
            // 
            matrixProductResult.Location = new System.Drawing.Point(747, 22);
            matrixProductResult.Name = "matrixProductResult";
            matrixProductResult.Size = new System.Drawing.Size(229, 173);
            matrixProductResult.TabIndex = 3;
            matrixProductResult.Text = "Result";
            // 
            // matrixProductInput3
            // 
            matrixProductInput3.Location = new System.Drawing.Point(476, 22);
            matrixProductInput3.Name = "matrixProductInput3";
            matrixProductInput3.Size = new System.Drawing.Size(229, 173);
            matrixProductInput3.TabIndex = 2;
            matrixProductInput3.Text = "4x4 Matrix";
            matrixProductInput3.MatrixChanged += matrixTransformBuilder_MatrixChanged;
            // 
            // matrixProductInput2
            // 
            matrixProductInput2.Location = new System.Drawing.Point(241, 22);
            matrixProductInput2.Name = "matrixProductInput2";
            matrixProductInput2.Size = new System.Drawing.Size(229, 173);
            matrixProductInput2.TabIndex = 1;
            matrixProductInput2.Text = "4x4 Matrix";
            matrixProductInput2.MatrixChanged += matrixTransformBuilder_MatrixChanged;
            // 
            // matrixTransformFourByFour
            // 
            matrixTransformFourByFour.Location = new System.Drawing.Point(6, 22);
            matrixTransformFourByFour.Name = "matrixTransformFourByFour";
            matrixTransformFourByFour.Size = new System.Drawing.Size(229, 173);
            matrixTransformFourByFour.TabIndex = 0;
            matrixTransformFourByFour.Text = "4x4 Transformation Matrix";
            matrixTransformFourByFour.MatrixChanged += matrixTransformFourByFour_MatrixChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(matrixTransformResult);
            groupBox2.Controls.Add(matrixTransformFourByOne);
            groupBox2.Controls.Add(matrixTransformFourByFour);
            groupBox2.Location = new System.Drawing.Point(12, 518);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(435, 202);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Matrix transform";
            // 
            // matrixTransformResult
            // 
            matrixTransformResult.Location = new System.Drawing.Point(342, 23);
            matrixTransformResult.Name = "matrixTransformResult";
            matrixTransformResult.Size = new System.Drawing.Size(79, 173);
            matrixTransformResult.TabIndex = 2;
            matrixTransformResult.Text = "Result";
            // 
            // matrixTransformFourByOne
            // 
            matrixTransformFourByOne.Location = new System.Drawing.Point(250, 22);
            matrixTransformFourByOne.Name = "matrixTransformFourByOne";
            matrixTransformFourByOne.Size = new System.Drawing.Size(79, 173);
            matrixTransformFourByOne.TabIndex = 1;
            matrixTransformFourByOne.Text = "Input";
            matrixTransformFourByOne.MatrixChanged += matrixInput_MatrixChanged;
            matrixTransformFourByOne.Load += oneByFourMatrix1_Load;
            // 
            // grpScaleBuilder
            // 
            grpScaleBuilder.Controls.Add(label3);
            grpScaleBuilder.Controls.Add(txtScaleBuilderZ);
            grpScaleBuilder.Controls.Add(label2);
            grpScaleBuilder.Controls.Add(txtScaleBuilderY);
            grpScaleBuilder.Controls.Add(label1);
            grpScaleBuilder.Controls.Add(txtScaleBuilderX);
            grpScaleBuilder.Controls.Add(matrixScaleBuilderResult);
            grpScaleBuilder.Location = new System.Drawing.Point(6, 22);
            grpScaleBuilder.Name = "grpScaleBuilder";
            grpScaleBuilder.Size = new System.Drawing.Size(344, 227);
            grpScaleBuilder.TabIndex = 4;
            grpScaleBuilder.TabStop = false;
            grpScaleBuilder.Text = "Scale";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Scale Z";
            // 
            // txtScaleBuilderZ
            // 
            txtScaleBuilderZ.Location = new System.Drawing.Point(6, 150);
            txtScaleBuilderZ.Name = "txtScaleBuilderZ";
            txtScaleBuilderZ.Size = new System.Drawing.Size(100, 23);
            txtScaleBuilderZ.TabIndex = 6;
            txtScaleBuilderZ.Text = "1";
            txtScaleBuilderZ.TextChanged += txtScaleBuilderValue_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Scale Y";
            // 
            // txtScaleBuilderY
            // 
            txtScaleBuilderY.Location = new System.Drawing.Point(6, 106);
            txtScaleBuilderY.Name = "txtScaleBuilderY";
            txtScaleBuilderY.Size = new System.Drawing.Size(100, 23);
            txtScaleBuilderY.TabIndex = 4;
            txtScaleBuilderY.Text = "1";
            txtScaleBuilderY.TextChanged += txtScaleBuilderValue_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Scale X";
            // 
            // txtScaleBuilderX
            // 
            txtScaleBuilderX.Location = new System.Drawing.Point(6, 62);
            txtScaleBuilderX.Name = "txtScaleBuilderX";
            txtScaleBuilderX.Size = new System.Drawing.Size(100, 23);
            txtScaleBuilderX.TabIndex = 2;
            txtScaleBuilderX.Text = "1";
            txtScaleBuilderX.TextChanged += txtScaleBuilderValue_TextChanged;
            // 
            // matrixScaleBuilderResult
            // 
            matrixScaleBuilderResult.Location = new System.Drawing.Point(112, 22);
            matrixScaleBuilderResult.Name = "matrixScaleBuilderResult";
            matrixScaleBuilderResult.Size = new System.Drawing.Size(229, 173);
            matrixScaleBuilderResult.TabIndex = 1;
            matrixScaleBuilderResult.Text = "4x4 Matrix";
            matrixScaleBuilderResult.MatrixChanged += matrixScaleBuilderResult_MatrixChanged;
            // 
            // grpRotationBuilder
            // 
            grpRotationBuilder.Controls.Add(txtRotationDegrees);
            grpRotationBuilder.Controls.Add(matrixRotationBuilderResult);
            grpRotationBuilder.Controls.Add(trkRotationDegrees);
            grpRotationBuilder.Controls.Add(label4);
            grpRotationBuilder.Controls.Add(grpRotationAxisRadioGroup);
            grpRotationBuilder.Location = new System.Drawing.Point(353, 22);
            grpRotationBuilder.Name = "grpRotationBuilder";
            grpRotationBuilder.Size = new System.Drawing.Size(324, 260);
            grpRotationBuilder.TabIndex = 5;
            grpRotationBuilder.TabStop = false;
            grpRotationBuilder.Text = "Rotation";
            // 
            // txtRotationDegrees
            // 
            txtRotationDegrees.Location = new System.Drawing.Point(12, 103);
            txtRotationDegrees.Name = "txtRotationDegrees";
            txtRotationDegrees.Size = new System.Drawing.Size(73, 23);
            txtRotationDegrees.TabIndex = 1;
            txtRotationDegrees.Text = "0";
            txtRotationDegrees.TextChanged += txtRotationDegrees_TextChanged;
            // 
            // matrixRotationBuilderResult
            // 
            matrixRotationBuilderResult.Location = new System.Drawing.Point(91, 85);
            matrixRotationBuilderResult.Name = "matrixRotationBuilderResult";
            matrixRotationBuilderResult.Size = new System.Drawing.Size(229, 173);
            matrixRotationBuilderResult.TabIndex = 3;
            matrixRotationBuilderResult.Text = "4x4 Matrix";
            matrixRotationBuilderResult.MatrixChanged += matrixRotationBuilderResult_MatrixChanged;
            matrixRotationBuilderResult.Load += matrixRotationBuilderResult_Load;
            // 
            // trkRotationDegrees
            // 
            trkRotationDegrees.LargeChange = 45;
            trkRotationDegrees.Location = new System.Drawing.Point(12, 42);
            trkRotationDegrees.Maximum = 180;
            trkRotationDegrees.Minimum = -180;
            trkRotationDegrees.Name = "trkRotationDegrees";
            trkRotationDegrees.Size = new System.Drawing.Size(308, 45);
            trkRotationDegrees.SmallChange = 5;
            trkRotationDegrees.TabIndex = 0;
            trkRotationDegrees.Scroll += trkRotationDegrees_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 15);
            label4.TabIndex = 1;
            label4.Text = "Rotation (degrees)";
            // 
            // grpRotationAxisRadioGroup
            // 
            grpRotationAxisRadioGroup.Controls.Add(rdoRotationAxisZ);
            grpRotationAxisRadioGroup.Controls.Add(rdoRotationAxisY);
            grpRotationAxisRadioGroup.Controls.Add(rdoRotationAxisX);
            grpRotationAxisRadioGroup.Location = new System.Drawing.Point(9, 158);
            grpRotationAxisRadioGroup.Name = "grpRotationAxisRadioGroup";
            grpRotationAxisRadioGroup.Size = new System.Drawing.Size(76, 96);
            grpRotationAxisRadioGroup.TabIndex = 2;
            grpRotationAxisRadioGroup.TabStop = false;
            grpRotationAxisRadioGroup.Text = "Axis";
            // 
            // rdoRotationAxisZ
            // 
            rdoRotationAxisZ.AutoSize = true;
            rdoRotationAxisZ.Checked = true;
            rdoRotationAxisZ.Location = new System.Drawing.Point(6, 72);
            rdoRotationAxisZ.Name = "rdoRotationAxisZ";
            rdoRotationAxisZ.Size = new System.Drawing.Size(56, 19);
            rdoRotationAxisZ.TabIndex = 2;
            rdoRotationAxisZ.TabStop = true;
            rdoRotationAxisZ.Text = "Z Axis";
            rdoRotationAxisZ.UseVisualStyleBackColor = true;
            // 
            // rdoRotationAxisY
            // 
            rdoRotationAxisY.AutoSize = true;
            rdoRotationAxisY.Location = new System.Drawing.Point(6, 47);
            rdoRotationAxisY.Name = "rdoRotationAxisY";
            rdoRotationAxisY.Size = new System.Drawing.Size(56, 19);
            rdoRotationAxisY.TabIndex = 1;
            rdoRotationAxisY.TabStop = true;
            rdoRotationAxisY.Text = "Y Axis";
            rdoRotationAxisY.UseVisualStyleBackColor = true;
            // 
            // rdoRotationAxisX
            // 
            rdoRotationAxisX.AutoSize = true;
            rdoRotationAxisX.Location = new System.Drawing.Point(6, 22);
            rdoRotationAxisX.Name = "rdoRotationAxisX";
            rdoRotationAxisX.Size = new System.Drawing.Size(56, 19);
            rdoRotationAxisX.TabIndex = 0;
            rdoRotationAxisX.TabStop = true;
            rdoRotationAxisX.Text = "X Axis";
            rdoRotationAxisX.UseVisualStyleBackColor = true;
            // 
            // grpTranslationBuilder
            // 
            grpTranslationBuilder.Controls.Add(label5);
            grpTranslationBuilder.Controls.Add(txtTranslationBuilderZ);
            grpTranslationBuilder.Controls.Add(label6);
            grpTranslationBuilder.Controls.Add(txtTranslationBuilderY);
            grpTranslationBuilder.Controls.Add(label7);
            grpTranslationBuilder.Controls.Add(txtTranslationBuilderX);
            grpTranslationBuilder.Controls.Add(matrixTranslationBuilderResult);
            grpTranslationBuilder.Location = new System.Drawing.Point(683, 22);
            grpTranslationBuilder.Name = "grpTranslationBuilder";
            grpTranslationBuilder.Size = new System.Drawing.Size(344, 198);
            grpTranslationBuilder.TabIndex = 6;
            grpTranslationBuilder.TabStop = false;
            grpTranslationBuilder.Text = "Translation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 132);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 15);
            label5.TabIndex = 7;
            label5.Text = "Translate Z";
            // 
            // txtTranslationBuilderZ
            // 
            txtTranslationBuilderZ.Location = new System.Drawing.Point(6, 150);
            txtTranslationBuilderZ.Name = "txtTranslationBuilderZ";
            txtTranslationBuilderZ.Size = new System.Drawing.Size(100, 23);
            txtTranslationBuilderZ.TabIndex = 6;
            txtTranslationBuilderZ.Text = "0";
            txtTranslationBuilderZ.TextChanged += txtTranslationBuilderValue_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 88);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Translate Y";
            // 
            // txtTranslationBuilderY
            // 
            txtTranslationBuilderY.Location = new System.Drawing.Point(6, 106);
            txtTranslationBuilderY.Name = "txtTranslationBuilderY";
            txtTranslationBuilderY.Size = new System.Drawing.Size(100, 23);
            txtTranslationBuilderY.TabIndex = 4;
            txtTranslationBuilderY.Text = "0";
            txtTranslationBuilderY.TextChanged += txtTranslationBuilderValue_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 44);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(64, 15);
            label7.TabIndex = 3;
            label7.Text = "Translate X";
            // 
            // txtTranslationBuilderX
            // 
            txtTranslationBuilderX.Location = new System.Drawing.Point(6, 62);
            txtTranslationBuilderX.Name = "txtTranslationBuilderX";
            txtTranslationBuilderX.Size = new System.Drawing.Size(100, 23);
            txtTranslationBuilderX.TabIndex = 2;
            txtTranslationBuilderX.Text = "0";
            txtTranslationBuilderX.TextChanged += txtTranslationBuilderValue_TextChanged;
            // 
            // matrixTranslationBuilderResult
            // 
            matrixTranslationBuilderResult.Location = new System.Drawing.Point(112, 22);
            matrixTranslationBuilderResult.Name = "matrixTranslationBuilderResult";
            matrixTranslationBuilderResult.Size = new System.Drawing.Size(229, 173);
            matrixTranslationBuilderResult.TabIndex = 1;
            matrixTranslationBuilderResult.Text = "4x4 Matrix";
            matrixTranslationBuilderResult.MatrixChanged += matrixTranslationBuilderResult_MatrixChanged;
            // 
            // grpMatrixTransformBuilder
            // 
            grpMatrixTransformBuilder.Controls.Add(grpCompositionCalculator);
            grpMatrixTransformBuilder.Controls.Add(grpScaleBuilder);
            grpMatrixTransformBuilder.Controls.Add(grpRotationBuilder);
            grpMatrixTransformBuilder.Controls.Add(grpTranslationBuilder);
            grpMatrixTransformBuilder.Location = new System.Drawing.Point(12, 12);
            grpMatrixTransformBuilder.Name = "grpMatrixTransformBuilder";
            grpMatrixTransformBuilder.Size = new System.Drawing.Size(1468, 292);
            grpMatrixTransformBuilder.TabIndex = 7;
            grpMatrixTransformBuilder.TabStop = false;
            grpMatrixTransformBuilder.Text = "4x4 Transformation Matrix Builder";
            // 
            // grpCompositionCalculator
            // 
            grpCompositionCalculator.Controls.Add(grpOrderRadioGroup);
            grpCompositionCalculator.Controls.Add(matrixCompositionResult);
            grpCompositionCalculator.Location = new System.Drawing.Point(1033, 23);
            grpCompositionCalculator.Name = "grpCompositionCalculator";
            grpCompositionCalculator.Size = new System.Drawing.Size(429, 198);
            grpCompositionCalculator.TabIndex = 8;
            grpCompositionCalculator.TabStop = false;
            grpCompositionCalculator.Text = "Composition";
            // 
            // grpOrderRadioGroup
            // 
            grpOrderRadioGroup.Controls.Add(rdoComposeTranslateRotateScale);
            grpOrderRadioGroup.Controls.Add(rdoComposeTranslateScaleRotate);
            grpOrderRadioGroup.Controls.Add(rdoComposeScaleTranslateRotate);
            grpOrderRadioGroup.Controls.Add(rdoComposeScaleRotateTranslate);
            grpOrderRadioGroup.Location = new System.Drawing.Point(6, 29);
            grpOrderRadioGroup.Name = "grpOrderRadioGroup";
            grpOrderRadioGroup.Size = new System.Drawing.Size(163, 125);
            grpOrderRadioGroup.TabIndex = 3;
            grpOrderRadioGroup.TabStop = false;
            grpOrderRadioGroup.Text = "Order";
            // 
            // rdoComposeTranslateRotateScale
            // 
            rdoComposeTranslateRotateScale.AutoSize = true;
            rdoComposeTranslateRotateScale.Location = new System.Drawing.Point(6, 97);
            rdoComposeTranslateRotateScale.Name = "rdoComposeTranslateRotateScale";
            rdoComposeTranslateRotateScale.Size = new System.Drawing.Size(155, 19);
            rdoComposeTranslateRotateScale.TabIndex = 3;
            rdoComposeTranslateRotateScale.Text = "Translate * Rotate * Scale";
            rdoComposeTranslateRotateScale.UseVisualStyleBackColor = true;
            rdoComposeTranslateRotateScale.CheckedChanged += rdoComposeOrder_CheckedChanged;
            // 
            // rdoComposeTranslateScaleRotate
            // 
            rdoComposeTranslateScaleRotate.AutoSize = true;
            rdoComposeTranslateScaleRotate.Location = new System.Drawing.Point(6, 72);
            rdoComposeTranslateScaleRotate.Name = "rdoComposeTranslateScaleRotate";
            rdoComposeTranslateScaleRotate.Size = new System.Drawing.Size(155, 19);
            rdoComposeTranslateScaleRotate.TabIndex = 2;
            rdoComposeTranslateScaleRotate.Text = "Translate * Scale * Rotate";
            rdoComposeTranslateScaleRotate.UseVisualStyleBackColor = true;
            rdoComposeTranslateScaleRotate.CheckedChanged += rdoComposeOrder_CheckedChanged;
            // 
            // rdoComposeScaleTranslateRotate
            // 
            rdoComposeScaleTranslateRotate.AutoSize = true;
            rdoComposeScaleTranslateRotate.Location = new System.Drawing.Point(6, 47);
            rdoComposeScaleTranslateRotate.Name = "rdoComposeScaleTranslateRotate";
            rdoComposeScaleTranslateRotate.Size = new System.Drawing.Size(155, 19);
            rdoComposeScaleTranslateRotate.TabIndex = 1;
            rdoComposeScaleTranslateRotate.Text = "Scale * Translate * Rotate";
            rdoComposeScaleTranslateRotate.UseVisualStyleBackColor = true;
            rdoComposeScaleTranslateRotate.CheckedChanged += rdoComposeOrder_CheckedChanged;
            // 
            // rdoComposeScaleRotateTranslate
            // 
            rdoComposeScaleRotateTranslate.AutoSize = true;
            rdoComposeScaleRotateTranslate.Checked = true;
            rdoComposeScaleRotateTranslate.Location = new System.Drawing.Point(6, 22);
            rdoComposeScaleRotateTranslate.Name = "rdoComposeScaleRotateTranslate";
            rdoComposeScaleRotateTranslate.Size = new System.Drawing.Size(155, 19);
            rdoComposeScaleRotateTranslate.TabIndex = 0;
            rdoComposeScaleRotateTranslate.TabStop = true;
            rdoComposeScaleRotateTranslate.Text = "Scale * Rotate * Translate";
            rdoComposeScaleRotateTranslate.UseVisualStyleBackColor = true;
            rdoComposeScaleRotateTranslate.CheckedChanged += rdoComposeOrder_CheckedChanged;
            // 
            // matrixCompositionResult
            // 
            matrixCompositionResult.Location = new System.Drawing.Point(194, 18);
            matrixCompositionResult.Name = "matrixCompositionResult";
            matrixCompositionResult.Size = new System.Drawing.Size(229, 173);
            matrixCompositionResult.TabIndex = 1;
            matrixCompositionResult.Text = "4x4 Matrix";
            // 
            // grpRawValue
            // 
            grpRawValue.Controls.Add(lblRawMatrixValue);
            grpRawValue.Controls.Add(label8);
            grpRawValue.Controls.Add(matrixRawValue);
            grpRawValue.Location = new System.Drawing.Point(456, 518);
            grpRawValue.Name = "grpRawValue";
            grpRawValue.Size = new System.Drawing.Size(429, 198);
            grpRawValue.TabIndex = 9;
            grpRawValue.TabStop = false;
            grpRawValue.Text = "Raw Value";
            // 
            // lblRawMatrixValue
            // 
            lblRawMatrixValue.AutoSize = true;
            lblRawMatrixValue.Location = new System.Drawing.Point(241, 34);
            lblRawMatrixValue.Name = "lblRawMatrixValue";
            lblRawMatrixValue.Size = new System.Drawing.Size(67, 15);
            lblRawMatrixValue.TabIndex = 3;
            lblRawMatrixValue.Text = "Matrix Data";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(241, 19);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 15);
            label8.TabIndex = 2;
            label8.Text = "Value:";
            // 
            // matrixRawValue
            // 
            matrixRawValue.Location = new System.Drawing.Point(6, 18);
            matrixRawValue.Name = "matrixRawValue";
            matrixRawValue.Size = new System.Drawing.Size(229, 173);
            matrixRawValue.TabIndex = 1;
            matrixRawValue.Text = "4x4 Matrix";
            matrixRawValue.MatrixChanged += matrixRawValue_MatrixChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1520, 805);
            Controls.Add(grpRawValue);
            Controls.Add(grpMatrixTransformBuilder);
            Controls.Add(groupBox2);
            Controls.Add(grpMatrixMultiply);
            Name = "Form1";
            Text = "Transform Matrix Playground";
            grpMatrixMultiply.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            grpScaleBuilder.ResumeLayout(false);
            grpScaleBuilder.PerformLayout();
            grpRotationBuilder.ResumeLayout(false);
            grpRotationBuilder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkRotationDegrees).EndInit();
            grpRotationAxisRadioGroup.ResumeLayout(false);
            grpRotationAxisRadioGroup.PerformLayout();
            grpTranslationBuilder.ResumeLayout(false);
            grpTranslationBuilder.PerformLayout();
            grpMatrixTransformBuilder.ResumeLayout(false);
            grpCompositionCalculator.ResumeLayout(false);
            grpOrderRadioGroup.ResumeLayout(false);
            grpOrderRadioGroup.PerformLayout();
            grpRawValue.ResumeLayout(false);
            grpRawValue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FourByFourMatrix matrixProductInput1;
        private System.Windows.Forms.GroupBox grpMatrixMultiply;
        private FourByFourMatrix matrixTransformFourByFour;
        private FourByFourMatrix matrixProductResult;
        private FourByFourMatrix matrixProductInput3;
        private FourByFourMatrix matrixProductInput2;
        private System.Windows.Forms.GroupBox groupBox2;
        private FourByOneMatrix matrixTransformFourByOne;
        private FourByOneMatrix matrixTransformResult;
        private System.Windows.Forms.GroupBox grpScaleBuilder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScaleBuilderZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScaleBuilderY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScaleBuilderX;
        private FourByFourMatrix matrixScaleBuilderResult;
        private System.Windows.Forms.GroupBox grpRotationBuilder;
        private System.Windows.Forms.TrackBar trkRotationDegrees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpRotationAxisRadioGroup;
        private System.Windows.Forms.RadioButton rdoRotationAxisZ;
        private System.Windows.Forms.RadioButton rdoRotationAxisY;
        private System.Windows.Forms.RadioButton rdoRotationAxisX;
        private FourByFourMatrix matrixRotationBuilderResult;
        private System.Windows.Forms.TextBox txtRotationDegrees;
        private System.Windows.Forms.GroupBox grpTranslationBuilder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTranslationBuilderZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTranslationBuilderY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTranslationBuilderX;
        private FourByFourMatrix matrixTranslationBuilderResult;
        private System.Windows.Forms.GroupBox grpMatrixTransformBuilder;
        private System.Windows.Forms.GroupBox grpCompositionCalculator;
        private FourByFourMatrix matrixCompositionResult;
        private System.Windows.Forms.GroupBox grpOrderRadioGroup;
        private System.Windows.Forms.RadioButton rdoComposeTranslateScaleRotate;
        private System.Windows.Forms.RadioButton rdoComposeScaleTranslateRotate;
        private System.Windows.Forms.RadioButton rdoComposeScaleRotateTranslate;
        private System.Windows.Forms.RadioButton rdoComposeTranslateRotateScale;
        private System.Windows.Forms.GroupBox grpRawValue;
        private System.Windows.Forms.Label lblRawMatrixValue;
        private System.Windows.Forms.Label label8;
        private FourByFourMatrix matrixRawValue;
    }
}
