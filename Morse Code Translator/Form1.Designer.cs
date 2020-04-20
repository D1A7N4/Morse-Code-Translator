namespace Morse_Code_Translator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_InputTo = new System.Windows.Forms.TextBox();
            this.TBX_OutputTo = new System.Windows.Forms.TextBox();
            this.BTN_From = new System.Windows.Forms.Button();
            this.BTN_To = new System.Windows.Forms.Button();
            this.TBX_OutputFrom = new System.Windows.Forms.TextBox();
            this.TBX_InputFrom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Morse Code Translator";
            // 
            // TBX_InputTo
            // 
            this.TBX_InputTo.Location = new System.Drawing.Point(19, 106);
            this.TBX_InputTo.Name = "TBX_InputTo";
            this.TBX_InputTo.Size = new System.Drawing.Size(143, 20);
            this.TBX_InputTo.TabIndex = 1;
            this.TBX_InputTo.Text = "Input";
            // 
            // TBX_OutputTo
            // 
            this.TBX_OutputTo.Location = new System.Drawing.Point(19, 184);
            this.TBX_OutputTo.Name = "TBX_OutputTo";
            this.TBX_OutputTo.Size = new System.Drawing.Size(143, 20);
            this.TBX_OutputTo.TabIndex = 2;
            this.TBX_OutputTo.Text = "Output";
            // 
            // BTN_From
            // 
            this.BTN_From.Location = new System.Drawing.Point(290, 132);
            this.BTN_From.Name = "BTN_From";
            this.BTN_From.Size = new System.Drawing.Size(143, 46);
            this.BTN_From.TabIndex = 3;
            this.BTN_From.Text = "Translate from morse code";
            this.BTN_From.UseVisualStyleBackColor = true;
            this.BTN_From.Click += new System.EventHandler(this.BTN_From_Click);
            // 
            // BTN_To
            // 
            this.BTN_To.Location = new System.Drawing.Point(19, 132);
            this.BTN_To.Name = "BTN_To";
            this.BTN_To.Size = new System.Drawing.Size(143, 46);
            this.BTN_To.TabIndex = 6;
            this.BTN_To.Text = "Translate to morse code";
            this.BTN_To.UseVisualStyleBackColor = true;
            this.BTN_To.Click += new System.EventHandler(this.BTN_To_Click);
            // 
            // TBX_OutputFrom
            // 
            this.TBX_OutputFrom.Location = new System.Drawing.Point(290, 184);
            this.TBX_OutputFrom.Name = "TBX_OutputFrom";
            this.TBX_OutputFrom.Size = new System.Drawing.Size(143, 20);
            this.TBX_OutputFrom.TabIndex = 5;
            this.TBX_OutputFrom.Text = "Output";
            // 
            // TBX_InputFrom
            // 
            this.TBX_InputFrom.Location = new System.Drawing.Point(290, 106);
            this.TBX_InputFrom.Name = "TBX_InputFrom";
            this.TBX_InputFrom.Size = new System.Drawing.Size(143, 20);
            this.TBX_InputFrom.TabIndex = 4;
            this.TBX_InputFrom.Text = "Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 236);
            this.Controls.Add(this.BTN_To);
            this.Controls.Add(this.TBX_OutputFrom);
            this.Controls.Add(this.TBX_InputFrom);
            this.Controls.Add(this.BTN_From);
            this.Controls.Add(this.TBX_OutputTo);
            this.Controls.Add(this.TBX_InputTo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_InputTo;
        private System.Windows.Forms.TextBox TBX_OutputTo;
        private System.Windows.Forms.Button BTN_From;
        private System.Windows.Forms.Button BTN_To;
        private System.Windows.Forms.TextBox TBX_OutputFrom;
        private System.Windows.Forms.TextBox TBX_InputFrom;
    }
}

