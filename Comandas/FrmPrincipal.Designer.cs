﻿namespace Comandas
{
    partial class FrmPrincipal
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
            gpxPrincipal = new GroupBox();
            btnUsuarios = new ReaLTaiizor.Controls.MetroButton();
            btnPedidoCozinha = new ReaLTaiizor.Controls.MetroButton();
            btnComanda = new ReaLTaiizor.Controls.MetroButton();
            btnCardapio = new ReaLTaiizor.Controls.MetroButton();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.Controls.Add(btnUsuarios);
            gpxPrincipal.Controls.Add(btnPedidoCozinha);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Location = new Point(43, 102);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(698, 275);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuarios.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuarios.DisabledForeColor = Color.Gray;
            btnUsuarios.Font = new Font("Microsoft Sans Serif", 10F);
            btnUsuarios.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnUsuarios.HoverColor = Color.FromArgb(95, 207, 255);
            btnUsuarios.HoverTextColor = Color.White;
            btnUsuarios.IsDerivedStyle = true;
            btnUsuarios.Location = new Point(532, 72);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnUsuarios.NormalColor = Color.FromArgb(65, 177, 225);
            btnUsuarios.NormalTextColor = Color.White;
            btnUsuarios.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnUsuarios.PressColor = Color.FromArgb(35, 147, 195);
            btnUsuarios.PressTextColor = Color.White;
            btnUsuarios.Size = new Size(149, 135);
            btnUsuarios.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnUsuarios.StyleManager = null;
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.ThemeAuthor = "Taiizor";
            btnUsuarios.ThemeName = "MetroLight";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidoCozinha.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidoCozinha.DisabledForeColor = Color.Gray;
            btnPedidoCozinha.Font = new Font("Microsoft Sans Serif", 10F);
            btnPedidoCozinha.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnPedidoCozinha.HoverColor = Color.FromArgb(95, 207, 255);
            btnPedidoCozinha.HoverTextColor = Color.White;
            btnPedidoCozinha.IsDerivedStyle = true;
            btnPedidoCozinha.Location = new Point(367, 72);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalTextColor = Color.White;
            btnPedidoCozinha.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressTextColor = Color.White;
            btnPedidoCozinha.Size = new Size(149, 135);
            btnPedidoCozinha.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnPedidoCozinha.StyleManager = null;
            btnPedidoCozinha.TabIndex = 2;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.ThemeAuthor = "Taiizor";
            btnPedidoCozinha.ThemeName = "MetroLight";
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledForeColor = Color.Gray;
            btnComanda.Font = new Font("Microsoft Sans Serif", 10F);
            btnComanda.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverTextColor = Color.White;
            btnComanda.IsDerivedStyle = true;
            btnComanda.Location = new Point(198, 72);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalTextColor = Color.White;
            btnComanda.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressTextColor = Color.White;
            btnComanda.Size = new Size(149, 135);
            btnComanda.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnComanda.StyleManager = null;
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.ThemeAuthor = "Taiizor";
            btnComanda.ThemeName = "MetroLight";
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledForeColor = Color.Gray;
            btnCardapio.Font = new Font("Microsoft Sans Serif", 10F);
            btnCardapio.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverTextColor = Color.White;
            btnCardapio.IsDerivedStyle = true;
            btnCardapio.Location = new Point(27, 72);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalTextColor = Color.White;
            btnCardapio.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressTextColor = Color.White;
            btnCardapio.Size = new Size(149, 135);
            btnCardapio.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnCardapio.StyleManager = null;
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.ThemeAuthor = "Taiizor";
            btnCardapio.ThemeName = "MetroLight";
            btnCardapio.Click += btnCardapio_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpxPrincipal);
            Name = "FrmPrincipal";
            Text = "Form1";

            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.MetroButton btnUsuarios;
        private ReaLTaiizor.Controls.MetroButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.MetroButton btnComanda;
        private ReaLTaiizor.Controls.MetroButton btnCardapio;
    }
}
