using System.Drawing;

namespace Parcial_1
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btTareas = new System.Windows.Forms.Button();
            this.btCalculadora = new System.Windows.Forms.Button();
            this.btInicio = new System.Windows.Forms.Button();
            this.panelSub = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btTareas);
            this.pnlMenu.Controls.Add(this.btCalculadora);
            this.pnlMenu.Controls.Add(this.btInicio);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(134, 450);
            this.pnlMenu.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(36, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Utils";
            // 
            // btTareas
            // 
            this.btTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.btTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTareas.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btTareas.Location = new System.Drawing.Point(0, 86);
            this.btTareas.Name = "btTareas";
            this.btTareas.Size = new System.Drawing.Size(132, 43);
            this.btTareas.TabIndex = 24;
            this.btTareas.Text = "Lista de Tareas";
            this.btTareas.UseVisualStyleBackColor = false;
            this.btTareas.Click += new System.EventHandler(this.btTareas_Click);
            // 
            // btCalculadora
            // 
            this.btCalculadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.btCalculadora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalculadora.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculadora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btCalculadora.Location = new System.Drawing.Point(0, 43);
            this.btCalculadora.Name = "btCalculadora";
            this.btCalculadora.Size = new System.Drawing.Size(132, 43);
            this.btCalculadora.TabIndex = 23;
            this.btCalculadora.Text = "Calculadora";
            this.btCalculadora.UseVisualStyleBackColor = false;
            this.btCalculadora.Click += new System.EventHandler(this.btCalculadora_Click);
            // 
            // btInicio
            // 
            this.btInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.btInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btInicio.Location = new System.Drawing.Point(0, 0);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(132, 43);
            this.btInicio.TabIndex = 22;
            this.btInicio.Text = "Inicio";
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // panelSub
            // 
            this.panelSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSub.Location = new System.Drawing.Point(134, 0);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(562, 450);
            this.panelSub.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.panelSub);
            this.Controls.Add(this.pnlMenu);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btTareas;
        private System.Windows.Forms.Button btCalculadora;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSub;
    }
}

