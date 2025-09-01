using System.Drawing;
using System.Windows.Forms;

namespace TransformMatrixPlayground
{
    partial class FourByFourMatrix
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
            btnCopy = new Button();
            btnPaste = new Button();
            btnIdentity = new Button();
            SuspendLayout();
            // 
            // grpMatrixCells
            // 
            grpMatrixCells.Dock = DockStyle.Top;
            grpMatrixCells.Location = new Point(0, 0);
            grpMatrixCells.Name = "grpMatrixCells";
            grpMatrixCells.Padding = new Padding(3, 16, 0, 0);
            grpMatrixCells.Size = new Size(150, 126);
            grpMatrixCells.TabIndex = 0;
            grpMatrixCells.TabStop = false;
            grpMatrixCells.Text = "4x4 Matrix";
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Segoe UI", 7F);
            btnCopy.Location = new Point(3, 129);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(38, 18);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnPaste
            // 
            btnPaste.Font = new Font("Segoe UI", 7F);
            btnPaste.Location = new Point(47, 129);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(41, 18);
            btnPaste.TabIndex = 2;
            btnPaste.Text = "Paste";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnIdentity
            // 
            btnIdentity.Font = new Font("Segoe UI", 7F);
            btnIdentity.Location = new Point(94, 129);
            btnIdentity.Name = "btnIdentity";
            btnIdentity.Size = new Size(53, 18);
            btnIdentity.TabIndex = 3;
            btnIdentity.Text = "Identity";
            btnIdentity.UseVisualStyleBackColor = true;
            btnIdentity.Click += btnIdentity_Click;
            // 
            // FourByFourMatrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnIdentity);
            Controls.Add(btnPaste);
            Controls.Add(btnCopy);
            Controls.Add(grpMatrixCells);
            Name = "FourByFourMatrix";
            Load += FourByFourMatrix_Load;
            DragDrop += FourByFourMatrix_DragDrop;
            DragEnter += FourByFourMatrix_DragEnter;
            MouseDown += FourByFourMatrix_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMatrixCells;
        private Button btnCopy;
        private Button btnPaste;
        private Button btnIdentity;
    }
}
