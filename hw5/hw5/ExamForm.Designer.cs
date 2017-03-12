namespace hw5
{
    partial class ExamForm
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
            this.startExamButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.studentListView = new System.Windows.Forms.ListView();
            this.numberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // startExamButton
            // 
            this.startExamButton.Location = new System.Drawing.Point(373, 25);
            this.startExamButton.Name = "startExamButton";
            this.startExamButton.Size = new System.Drawing.Size(198, 37);
            this.startExamButton.TabIndex = 1;
            this.startExamButton.Text = "Start Exam";
            this.startExamButton.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(336, 81);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(285, 23);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Click the button to start exam";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentListView
            // 
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numberColumn,
            this.nameColumn,
            this.markColumn});
            this.studentListView.Location = new System.Drawing.Point(25, 25);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(281, 305);
            this.studentListView.TabIndex = 3;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // numberColumn
            // 
            this.numberColumn.Text = "№";
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // markColumn
            // 
            this.markColumn.Text = "Mark";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 386);
            this.Controls.Add(this.studentListView);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.startExamButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExamForm";
            this.Text = "Exam";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startExamButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader numberColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader markColumn;
    }
}

