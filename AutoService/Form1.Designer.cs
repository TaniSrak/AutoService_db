﻿namespace AutoService
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.lbMechanic = new System.Windows.Forms.Label();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(59, 107);
            this.cmbMechanic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(318, 67);
            this.cmbMechanic.TabIndex = 0;
            // 
            // lbMechanic
            // 
            this.lbMechanic.AutoSize = true;
            this.lbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMechanic.Location = new System.Drawing.Point(59, 24);
            this.lbMechanic.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMechanic.Name = "lbMechanic";
            this.lbMechanic.Size = new System.Drawing.Size(150, 44);
            this.lbMechanic.TabIndex = 1;
            this.lbMechanic.Text = "Мастер";
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picBoxAvatar.Location = new System.Drawing.Point(469, 107);
            this.picBoxAvatar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(220, 222);
            this.picBoxAvatar.TabIndex = 2;
            this.picBoxAvatar.TabStop = false;
            this.picBoxAvatar.Click += new System.EventHandler(this.picBoxAvatar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.picBoxAvatar);
            this.Controls.Add(this.lbMechanic);
            this.Controls.Add(this.cmbMechanic);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Label lbMechanic;
		private System.Windows.Forms.PictureBox picBoxAvatar;
	}
}

