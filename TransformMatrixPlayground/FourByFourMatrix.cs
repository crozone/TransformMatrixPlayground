using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformMatrixPlayground
{
    public partial class FourByFourMatrix : UserControl
    {
        private readonly TextBox[] matrixTextBoxes;
        private bool suppressMatrixChanged = false;

        public event EventHandler<Matrix4x4>? MatrixChanged;

        [Description("The title of the Matrix"), Category("Data")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text {
            get => grpMatrixCells.Text;
            set => grpMatrixCells.Text = value;
        }

        public FourByFourMatrix()
        {
            InitializeComponent();

            this.Resize += FourByFourMatrix_Resize;

            matrixTextBoxes = new TextBox[4 * 4];

            // Create matrix grid
            SuspendLayout();

            // Create grid of textboxes
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    TextBox thisTextBox = new TextBox
                    {
                        Name = $"txtCell_{y}_{x}",
                        TabIndex = y * 4 + x
                    };
                    grpMatrixCells.Controls.Add(thisTextBox);
                    GetTextboxForCellRef(x, y) = thisTextBox;
                    thisTextBox.TextChanged += CellTextBox_TextChanged;
                }
            }

            this.SetMatrix(Matrix4x4.Identity, true);

            ResumeLayout(false);
        }

        private void CellTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (!suppressMatrixChanged)
            {
                OnMatrixChanged();
            }
        }

        private void OnMatrixChanged()
        {
            if (TryGetMatrix(out Matrix4x4 matrix))
            {
                MatrixChanged?.Invoke(this, matrix);
            }
        }

        private void FourByFourMatrix_Resize(object? sender, EventArgs e)
        {
            var matrixTextBoxPadding = new Size(10, 10);
            var matrixTextBoxSize = new Size(
                (grpMatrixCells.Width - matrixTextBoxPadding.Width * 3 - grpMatrixCells.Padding.Left - grpMatrixCells.Padding.Right) / 4,
                23
                );

            SuspendLayout();

            // Create grid of textboxes
            // Note: The Matrix4x4 type is row-major, so is transposed in terms of row/column.
            // We need to take this into account when ordering the text boxes.
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    TextBox thisTextBox = GetTextboxForCellRef(x, y);
                    thisTextBox.Size = matrixTextBoxSize;

                    thisTextBox.Location = new Point(
                                grpMatrixCells.Padding.Left
                                + thisTextBox.Margin.Left
                                + x * (thisTextBox.Width + thisTextBox.Margin.Right),

                                grpMatrixCells.Padding.Top
                                + thisTextBox.Margin.Top
                                + y * (thisTextBox.Height + thisTextBox.Margin.Top)
                            );
                }
            }

            ResumeLayout(false);
        }

        private ref TextBox GetTextboxForCellRef(int row, int column) => ref matrixTextBoxes[row * 4 + column];

        public bool TryGetMatrix(out Matrix4x4 matrix)
        {
            matrix = new Matrix4x4();
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    if (float.TryParse(GetTextboxForCellRef(row, column).Text, out float textboxValue))
                    {
                        matrix[row, column] = textboxValue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public void SetMatrix(Matrix4x4 matrix) => SetMatrix(matrix, false);

        public void SetMatrix(Matrix4x4 matrix, bool suppressMatrixChanged)
        {
            this.suppressMatrixChanged = true;

            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    GetTextboxForCellRef(row, column).Text = matrix[row, column].ToString();
                }
            }

            if (!suppressMatrixChanged)
            {
                OnMatrixChanged();
            }

            this.suppressMatrixChanged = false;
        }

        private void FourByFourMatrix_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FourByFourMatrix_MouseDown(object sender, MouseEventArgs e)
        {
            //if (this.TryGetMatrix(out Matrix4x4 matrix))
            //{
            //    this.DoDragDrop(new Matrix4x4CopyData(matrix), DragDropEffects.Move);
            //}
        }

        private void FourByFourMatrix_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data?.GetDataPresent(typeof(Matrix4x4CopyData)) ?? false)
            //{
            //    e.Effect = DragDropEffects.Copy;
            //}
            //else
            //{
            //    e.Effect = DragDropEffects.None;
            //}
        }

        private void FourByFourMatrix_DragDrop(object sender, DragEventArgs e)
        {
            //if (e.Data?.GetData(typeof(Matrix4x4CopyData)) is Matrix4x4CopyData matrixData)
            //{
            //    this.SetMatrix(matrixData.Matrix);
            //}
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (TryGetMatrix(out Matrix4x4 matrix))
            {
                var array = new float[4][];
                for (int row = 0; row < 4; row++) {
                    array[row] = new float[4];
                    for (int column = 0; column < 4; column++)
                    {
                        // Transpose the matrix to get from row-vector convention
                        // to column-vector convention
                        array[row][column] = matrix[column, row];
                    }
                }
                
                string arrayText = System.Text.Json.JsonSerializer.Serialize(array);
                Clipboard.SetText(arrayText);
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() is string matrixText)
            {
                try
                {
                    if (System.Text.Json.JsonSerializer.Deserialize<float[][]>(matrixText) is float[][] matrixArray
                        && matrixArray.Length == 4
                        && matrixArray[0].Length == 4
                        && matrixArray[1].Length == 4
                        && matrixArray[2].Length == 4
                        && matrixArray[3].Length == 4)
                    {
                        Matrix4x4 matrix = new Matrix4x4();
                        for (int row = 0; row < 4; row++)
                        {
                            for (int column = 0; column < 4; column++)
                            {
                                // Transpose the matrix to get from column-vector convention
                                // to row-vector convention
                                matrix[column, row] = matrixArray[row][column];
                            }
                        }

                        SetMatrix(matrix);
                        return;
                    }
                }
                catch
                {
                }
            }
        }

        private void btnIdentity_Click(object sender, EventArgs e)
        {
            SetMatrix(Matrix4x4.Identity);
        }
    }
}
