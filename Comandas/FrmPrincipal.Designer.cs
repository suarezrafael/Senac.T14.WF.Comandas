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
            btnSair = new ReaLTaiizor.Controls.CyberButton();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.Controls.Add(btnUsuarios);
            gpxPrincipal.Controls.Add(btnPedidoCozinha);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Location = new Point(30, 62);
            gpxPrincipal.Margin = new Padding(2);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Padding = new Padding(2);
            gpxPrincipal.Size = new Size(488, 165);
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
            btnUsuarios.Location = new Point(373, 44);
            btnUsuarios.Margin = new Padding(2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnUsuarios.NormalColor = Color.FromArgb(65, 177, 225);
            btnUsuarios.NormalTextColor = Color.White;
            btnUsuarios.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnUsuarios.PressColor = Color.FromArgb(35, 147, 195);
            btnUsuarios.PressTextColor = Color.White;
            btnUsuarios.Size = new Size(104, 81);
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
            btnPedidoCozinha.Location = new Point(257, 44);
            btnPedidoCozinha.Margin = new Padding(2);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalTextColor = Color.White;
            btnPedidoCozinha.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressTextColor = Color.White;
            btnPedidoCozinha.Size = new Size(104, 81);
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
            btnComanda.Location = new Point(138, 44);
            btnComanda.Margin = new Padding(2);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalTextColor = Color.White;
            btnComanda.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressTextColor = Color.White;
            btnComanda.Size = new Size(104, 81);
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
            btnCardapio.Location = new Point(19, 44);
            btnCardapio.Margin = new Padding(2);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalTextColor = Color.White;
            btnCardapio.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressTextColor = Color.White;
            btnCardapio.Size = new Size(104, 81);
            btnCardapio.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnCardapio.StyleManager = null;
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.ThemeAuthor = "Taiizor";
            btnCardapio.ThemeName = "MetroLight";
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnSair
            // 
            btnSair.Alpha = 20;
            btnSair.BackColor = Color.Transparent;
            btnSair.Background = true;
            btnSair.Background_WidthPen = 4F;
            btnSair.BackgroundPen = true;
            btnSair.ColorBackground = Color.FromArgb(37, 52, 68);
            btnSair.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSair.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSair.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnSair.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSair.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSair.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSair.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSair.Effect_1 = true;
            btnSair.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSair.Effect_1_Transparency = 25;
            btnSair.Effect_2 = true;
            btnSair.Effect_2_ColorBackground = Color.White;
            btnSair.Effect_2_Transparency = 20;
            btnSair.Font = new Font("Arial", 11F);
            btnSair.ForeColor = Color.FromArgb(245, 245, 245);
            btnSair.Lighting = false;
            btnSair.LinearGradient_Background = false;
            btnSair.LinearGradientPen = false;
            btnSair.Location = new Point(23, 240);
            btnSair.Name = "btnSair";
            btnSair.PenWidth = 15;
            btnSair.Rounding = true;
            btnSair.RoundingInt = 70;
            btnSair.Size = new Size(130, 50);
            btnSair.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSair.TabIndex = 1;
            btnSair.Tag = "Cyber";
            btnSair.TextButton = "Sair";
            btnSair.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSair.Timer_Effect_1 = 5;
            btnSair.Timer_RGB = 300;
            btnSair.Click += btnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 302);
            Controls.Add(btnSair);
            Controls.Add(gpxPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Comandas";
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.MetroButton btnUsuarios;
        private ReaLTaiizor.Controls.MetroButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.MetroButton btnComanda;
        private ReaLTaiizor.Controls.MetroButton btnCardapio;
        private ReaLTaiizor.Controls.CyberButton btnSair;
    }
}
