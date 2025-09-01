using System;
using System.Numerics;
using System.Windows.Forms;

namespace TransformMatrixPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oneByFourMatrix1_Load(object sender, System.EventArgs e)
        {

        }

        private void matrixTransformBuilder_MatrixChanged(object sender, Matrix4x4 e)
        {
            RecalculateMatrixBuilder();
        }

        private void RecalculateMatrixBuilder()
        {
            if (matrixProductInput1.TryGetMatrix(out Matrix4x4 matrix1)
                && matrixProductInput2.TryGetMatrix(out Matrix4x4 matrix2)
                && matrixProductInput3.TryGetMatrix(out Matrix4x4 matrix3))
            {
                Matrix4x4 result = matrix1 * matrix2 * matrix3;

                matrixProductResult.SetMatrix(result);
            }
        }

        private void trkRotationDegrees_Scroll(object sender, System.EventArgs e)
        {
            if (sender is TrackBar trackBar)
            {
                txtRotationDegrees.Text = trackBar.Value.ToString();
            }
        }

        private void txtRotationDegrees_TextChanged(object sender, System.EventArgs e)
        {
            Matrix4x4 rotationResult = Matrix4x4.Identity;

            if ((sender is TextBox textbox) && double.TryParse(textbox.Text, out double degrees))
            {
                float radians = (float)(degrees * (Math.PI / 180d));

                rotationResult = rdoRotationAxisX.Checked
                    ? Matrix4x4.CreateRotationX(radians)
                    : rdoRotationAxisY.Checked
                        ? Matrix4x4.CreateRotationY(radians)
                        : rdoRotationAxisZ.Checked
                            ? Matrix4x4.CreateRotationZ(radians)
                            : Matrix4x4.Identity;
            }

            // Round any extremely small values to zero
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    if (MathF.Abs(rotationResult[row, column]) < 1e-7f)
                    {
                        rotationResult[row, column] = 0;
                    }
                }
            }

            matrixRotationBuilderResult.SetMatrix(rotationResult);
        }

        private void txtScaleBuilderValue_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtScaleBuilderX.Text, out float scaleX)
                && float.TryParse(txtScaleBuilderY.Text, out float scaleY)
                && float.TryParse(txtScaleBuilderZ.Text, out float scaleZ))
            {
                Matrix4x4 scaleMatrix = Matrix4x4.CreateScale(scaleX, scaleY, scaleZ);
                matrixScaleBuilderResult.SetMatrix(scaleMatrix);
            }
        }

        private void txtTranslationBuilderValue_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtTranslationBuilderX.Text, out float translationX)
                && float.TryParse(txtTranslationBuilderY.Text, out float translationY)
                && float.TryParse(txtTranslationBuilderZ.Text, out float translationZ))
            {
                Matrix4x4 translationMatrix = Matrix4x4.CreateTranslation(translationX, translationY, translationZ);
                matrixTranslationBuilderResult.SetMatrix(translationMatrix);
            }
        }

        private void matrixTransformFourByFour_MatrixChanged(object sender, Matrix4x4 e)
        {
            CalculateMatrixTransformResult();
        }

        private void matrixInput_MatrixChanged(object sender, Vector4 e)
        {
            CalculateMatrixTransformResult();
        }

        private void CalculateMatrixTransformResult()
        {
            if (matrixTransformFourByFour.TryGetMatrix(out Matrix4x4 transform)
                && matrixTransformFourByOne.TryGetMatrix(out Vector4 input))
            {
                Vector4 result = Vector4.Transform(input, transform);
                matrixTransformResult.SetMatrix(result);
            }
        }

        private void matrixScaleBuilderResult_MatrixChanged(object sender, Matrix4x4 e)
        {
            CalculateTransformComposition();
        }

        private void matrixRotationBuilderResult_MatrixChanged(object sender, Matrix4x4 e)
        {
            CalculateTransformComposition();
        }

        private void matrixTranslationBuilderResult_MatrixChanged(object sender, Matrix4x4 e)
        {
            CalculateTransformComposition();
        }

        private void rdoComposeOrder_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTransformComposition();
        }

        private void CalculateTransformComposition()
        {
            Matrix4x4 result = Matrix4x4.Identity;

            if (matrixScaleBuilderResult.TryGetMatrix(out Matrix4x4 scaleTransform)
                && matrixRotationBuilderResult.TryGetMatrix(out Matrix4x4 rotationTransform)
                && matrixTranslationBuilderResult.TryGetMatrix(out Matrix4x4 translationTransform))
            {
                result =
                    rdoComposeScaleRotateTranslate.Checked
                        ? scaleTransform * rotationTransform * translationTransform
                        : rdoComposeScaleTranslateRotate.Checked
                            ? scaleTransform * translationTransform * rotationTransform
                            : rdoComposeTranslateScaleRotate.Checked
                                ? translationTransform * scaleTransform * rotationTransform
                                : rdoComposeTranslateRotateScale.Checked
                                    ? translationTransform * rotationTransform * scaleTransform
                                    : Matrix4x4.Identity;

            }

            matrixCompositionResult.SetMatrix(result);
        }

        private void matrixRawValue_MatrixChanged(object sender, Matrix4x4 e)
        {
            lblRawMatrixValue.Text = e.ToString().Replace("}", "}\r\n");
        }

        private void matrixRotationBuilderResult_Load(object sender, EventArgs e)
        {

        }
    }
}
