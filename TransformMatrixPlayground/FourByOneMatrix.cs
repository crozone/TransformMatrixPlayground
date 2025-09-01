using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformMatrixPlayground
{
    public partial class FourByOneMatrix : UserControl
    {
        private readonly TextBox[] matrixTextBoxes;

        public event EventHandler<Vector4>? MatrixChanged;

        [Description("The title of the Matrix"), Category("Data")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text {
            get => grpMatrixCells.Text;
            set => grpMatrixCells.Text = value;
        }

        public FourByOneMatrix()
        {
            InitializeComponent();

            this.Resize += OneByFourMatrix_Resize;

            matrixTextBoxes = new TextBox[1 * 4];

            // Create matrix grid
            SuspendLayout();

            // Create grid of textboxes
            for (int i = 0; i < 4; i++)
            {
                TextBox thisTextBox = new TextBox
                {
                    Name = $"txtCell_0_{i}",
                    TabIndex = i
                };
                grpMatrixCells.Controls.Add(thisTextBox);
                matrixTextBoxes[i] = thisTextBox;
                thisTextBox.TextChanged += CellTextBox_TextChanged;
            }

            SetMatrix(Vector4.UnitW);

            ResumeLayout(false);
        }

        private void CellTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (TryGetMatrix(out Vector4 matrix))
            {
                MatrixChanged?.Invoke(this, matrix);
            }
        }

        private void OneByFourMatrix_Resize(object? sender, EventArgs e)
        {
            var matrixTextBoxEdgePad = new Size(10, 20);
            var matrixTextBoxPadding = new Size(10, 10);
            var matrixTextBoxSize = new Size(
                (grpMatrixCells.Width - matrixTextBoxEdgePad.Width * 2),
                23
                );

            SuspendLayout();

            // Create grid of textboxes
            for (int i = 0; i < 4; i++)
            {
                TextBox thisTextBox = matrixTextBoxes[i];

                thisTextBox.Location = new Point(
                            matrixTextBoxEdgePad.Width,
                            matrixTextBoxEdgePad.Height + i * (matrixTextBoxSize.Height + matrixTextBoxPadding.Height)
                        );
                thisTextBox.Size = matrixTextBoxSize;
            }

            ResumeLayout(false);
        }

        private void FourByOneMatrix_Load(object sender, System.EventArgs e)
        {
        }

        public bool TryGetMatrix(out Vector4 matrix)
        {
            matrix = new Vector4();
            for (int i = 0; i < 4; i++)
            {
                if (float.TryParse(matrixTextBoxes[i].Text, out float textboxValue))
                {
                    matrix[i] = textboxValue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public void SetMatrix(Vector4 matrix)
        {
            for (int i = 0; i < 4; i++)
            {
                matrixTextBoxes[i].Text = matrix[i].ToString();
            }
        }
    }
}
