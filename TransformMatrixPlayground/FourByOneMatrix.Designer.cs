using System.Drawing;
using System.Windows.Forms;

namespace TransformMatrixPlayground
{
    partial class FourByOneMatrix
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpMatrixCells = new GroupBox();
            SuspendLayout();
            // 
            // grpMatrixCells
            // 
            grpMatrixCells.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpMatrixCells.Location = new Point(3, 3);
            grpMatrixCells.Name = "grpMatrixCells";
            grpMatrixCells.Padding = new Padding(0);
            grpMatrixCells.Size = new Size(94, 144);
            grpMatrixCells.TabIndex = 0;
            grpMatrixCells.TabStop = false;
            grpMatrixCells.Text = "4x1 Matrix";
            // 
            // FourByOneMatrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpMatrixCells);
            Name = "FourByOneMatrix";
            Size = new Size(100, 150);
            Load += FourByOneMatrix_Load;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMatrixCells;
    }
}
