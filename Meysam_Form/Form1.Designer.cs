namespace Meysam_Form
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
            this.Btn_delete = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.Btn_send = new System.Windows.Forms.Button();
            this.txt = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_delete
            // 
            this.Btn_delete.BackColor = System.Drawing.Color.Maroon;
            this.Btn_delete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_delete.ForeColor = System.Drawing.Color.White;
            this.Btn_delete.Location = new System.Drawing.Point(257, 51);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(61, 38);
            this.Btn_delete.TabIndex = 8;
            this.Btn_delete.Text = "حذف ";
            this.Btn_delete.UseVisualStyleBackColor = false;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(125, 95);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(126, 95);
            this.list.TabIndex = 7;
            this.list.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(125, 196);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(126, 21);
            this.cmb.TabIndex = 6;
            // 
            // Btn_send
            // 
            this.Btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_send.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_send.Location = new System.Drawing.Point(125, 51);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(126, 38);
            this.Btn_send.TabIndex = 5;
            this.Btn_send.Text = "ارسال";
            this.Btn_send.UseVisualStyleBackColor = false;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(137, 25);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(442, 268);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.list);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.Btn_send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button Btn_send;
        private DevExpress.XtraEditors.TextEdit txt;
    }
}

