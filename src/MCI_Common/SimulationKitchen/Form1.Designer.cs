﻿namespace SimulationKitchen
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.LogDisplay = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_conf_nb_cookers = new System.Windows.Forms.TextBox();
            this.label_nb_cooker = new System.Windows.Forms.Label();
            this.btn_conf_save = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogDisplay
            // 
            this.LogDisplay.Location = new System.Drawing.Point(3, 6);
            this.LogDisplay.Multiline = true;
            this.LogDisplay.Name = "LogDisplay";
            this.LogDisplay.ReadOnly = true;
            this.LogDisplay.Size = new System.Drawing.Size(517, 188);
            this.LogDisplay.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 255);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogDisplay);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_conf_save);
            this.tabPage2.Controls.Add(this.txt_conf_nb_cookers);
            this.tabPage2.Controls.Add(this.label_nb_cooker);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_conf_nb_cookers
            // 
            this.txt_conf_nb_cookers.Location = new System.Drawing.Point(124, 14);
            this.txt_conf_nb_cookers.Name = "txt_conf_nb_cookers";
            this.txt_conf_nb_cookers.Size = new System.Drawing.Size(34, 20);
            this.txt_conf_nb_cookers.TabIndex = 1;
            // 
            // label_nb_cooker
            // 
            this.label_nb_cooker.AutoSize = true;
            this.label_nb_cooker.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_nb_cooker.Location = new System.Drawing.Point(6, 17);
            this.label_nb_cooker.Name = "label_nb_cooker";
            this.label_nb_cooker.Size = new System.Drawing.Size(112, 13);
            this.label_nb_cooker.TabIndex = 0;
            this.label_nb_cooker.Text = "Nombre de Cuisinier(s)";
            // 
            // btn_conf_save
            // 
            this.btn_conf_save.Location = new System.Drawing.Point(8, 198);
            this.btn_conf_save.Name = "btn_conf_save";
            this.btn_conf_save.Size = new System.Drawing.Size(90, 23);
            this.btn_conf_save.TabIndex = 2;
            this.btn_conf_save.Text = "Save";
            this.btn_conf_save.UseVisualStyleBackColor = true;
            this.btn_conf_save.Click += new System.EventHandler(this.btn_conf_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 255);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LogDisplay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_conf_nb_cookers;
        private System.Windows.Forms.Label label_nb_cooker;
        private System.Windows.Forms.Button btn_conf_save;
    }
}
