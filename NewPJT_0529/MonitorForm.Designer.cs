namespace NewPJT_0529
{
    partial class MonitorForm
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
            this.components = new System.ComponentModel.Container();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.BTN_Recoding = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.TMR_Draw = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(430, 308);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 0;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Recoding
            // 
            this.BTN_Recoding.Location = new System.Drawing.Point(12, 308);
            this.BTN_Recoding.Name = "BTN_Recoding";
            this.BTN_Recoding.Size = new System.Drawing.Size(75, 23);
            this.BTN_Recoding.TabIndex = 2;
            this.BTN_Recoding.Text = "Recoding";
            this.BTN_Recoding.UseVisualStyleBackColor = true;
            this.BTN_Recoding.Click += new System.EventHandler(this.BTN_Recoding_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(93, 308);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // TMR_Draw
            // 
            this.TMR_Draw.Enabled = true;
            this.TMR_Draw.Tick += new System.EventHandler(this.TMR_Draw_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 291);
            this.panel1.TabIndex = 4;
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 341);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Recoding);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.panel1);
            this.Name = "MonitorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Button BTN_Recoding;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Timer TMR_Draw;
        private System.Windows.Forms.Panel panel1;
    }
}