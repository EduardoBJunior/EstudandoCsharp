﻿namespace Agenda
{
    partial class frmResultados
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_nova_pesquisa = new System.Windows.Forms.Button();
            this.lista_final = new System.Windows.Forms.ListBox();
            this.lb_nRegistros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(273, 114);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(102, 36);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_nova_pesquisa
            // 
            this.btn_nova_pesquisa.Location = new System.Drawing.Point(161, 114);
            this.btn_nova_pesquisa.Name = "btn_nova_pesquisa";
            this.btn_nova_pesquisa.Size = new System.Drawing.Size(102, 36);
            this.btn_nova_pesquisa.TabIndex = 1;
            this.btn_nova_pesquisa.Text = "Nova Pesquisa";
            this.btn_nova_pesquisa.UseVisualStyleBackColor = true;
            this.btn_nova_pesquisa.Click += new System.EventHandler(this.btn_nova_pesquisa_Click);
            // 
            // lista_final
            // 
            this.lista_final.FormattingEnabled = true;
            this.lista_final.Location = new System.Drawing.Point(33, 13);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(342, 95);
            this.lista_final.TabIndex = 2;
            // 
            // lb_nRegistros
            // 
            this.lb_nRegistros.Location = new System.Drawing.Point(30, 114);
            this.lb_nRegistros.Name = "lb_nRegistros";
            this.lb_nRegistros.Size = new System.Drawing.Size(127, 20);
            this.lb_nRegistros.TabIndex = 11;
            this.lb_nRegistros.Text = "Registros : 0";
            this.lb_nRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 162);
            this.Controls.Add(this.lb_nRegistros);
            this.Controls.Add(this.lista_final);
            this.Controls.Add(this.btn_nova_pesquisa);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_nova_pesquisa;
        private System.Windows.Forms.ListBox lista_final;
        private System.Windows.Forms.Label lb_nRegistros;
    }
}