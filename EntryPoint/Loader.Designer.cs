namespace EntryPoint
{
    partial class Loader
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
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(9, 10);
            this.btnInsertionSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(247, 19);
            this.btnInsertionSort.TabIndex = 0;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(9, 34);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(247, 19);
            this.btnMergeSort.TabIndex = 1;
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 147);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnInsertionSort);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Loader";
            this.Text = "Loader";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eExit);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnMergeSort;
    }
}

