﻿namespace DomaciZadatak
{
    partial class novaForma
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
            this.listBoxExerciseResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxExerciseResults
            // 
            this.listBoxExerciseResults.FormattingEnabled = true;
            this.listBoxExerciseResults.ItemHeight = 15;
            this.listBoxExerciseResults.Location = new System.Drawing.Point(247, 51);
            this.listBoxExerciseResults.Name = "listBoxExerciseResults";
            this.listBoxExerciseResults.Size = new System.Drawing.Size(380, 319);
            this.listBoxExerciseResults.TabIndex = 0;
            // 
            // novaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxExerciseResults);
            this.Name = "novaForma";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExerciseResults;
    }
}

