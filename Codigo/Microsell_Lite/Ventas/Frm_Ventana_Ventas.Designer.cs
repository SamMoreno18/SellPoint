namespace Microsell_Lite.Ventas
{
    partial class Frm_Ventana_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ventana_Ventas));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.btn_minimi = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gru_det = new Klik.Windows.Forms.v1.EntryLib.ELGroupBox();
            this.btn_listo = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnl_sinProd = new System.Windows.Forms.Panel();
            this.btn_Nuevo_buscarProd = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.ElDivider3 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.Label17 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnl_titu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_listo)).BeginInit();
            this.pnl_sinProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Nuevo_buscarProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElDivider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.DimGray;
            this.pnl_titu.Controls.Add(this.btn_minimi);
            this.pnl_titu.Controls.Add(this.btn_cerrar);
            this.pnl_titu.Controls.Add(this.label1);
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(1190, 43);
            this.pnl_titu.TabIndex = 1;
            this.pnl_titu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titu_MouseMove);
            // 
            // btn_minimi
            // 
            this.btn_minimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimi.FlatAppearance.BorderSize = 0;
            this.btn_minimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_minimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_minimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimi.ForeColor = System.Drawing.Color.White;
            this.btn_minimi.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimi.Image")));
            this.btn_minimi.Location = new System.Drawing.Point(1098, 4);
            this.btn_minimi.Name = "btn_minimi";
            this.btn_minimi.Size = new System.Drawing.Size(32, 32);
            this.btn_minimi.TabIndex = 7;
            this.btn_minimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_minimi.UseVisualStyleBackColor = true;
            this.btn_minimi.Click += new System.EventHandler(this.btn_minimi_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1148, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(32, 32);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventana de Atencion al Cliente";
            // 
            // gru_det
            // 
            this.gru_det.BackgroundStyle.GradientAngle = 45F;
            this.gru_det.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.gru_det.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.gru_det.BorderStyle.SolidColor = System.Drawing.Color.SkyBlue;
            this.gru_det.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.gru_det.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption;
            this.gru_det.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.gru_det.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.gru_det.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.gru_det.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.gru_det.CaptionStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.gru_det.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.gru_det.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.gru_det.CaptionStyle.TextStyle.BackColor = System.Drawing.SystemColors.ControlText;
            this.gru_det.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gru_det.CaptionStyle.TextStyle.ForeColor = System.Drawing.SystemColors.Window;
            this.gru_det.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gru_det.CaptionStyle.TextStyle.TextType = Klik.Windows.Forms.v1.Common.TextTypes.BlockShadow;
            this.gru_det.CaptionStyle.Visible = false;
            this.gru_det.CaptionStyle.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.gru_det.Location = new System.Drawing.Point(7, 50);
            this.gru_det.Name = "gru_det";
            this.gru_det.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gru_det.Size = new System.Drawing.Size(761, 354);
            this.gru_det.TabIndex = 2;
            this.gru_det.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // btn_listo
            // 
            this.btn_listo.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_listo.BackgroundStyle.SolidColor = System.Drawing.Color.DodgerBlue;
            this.btn_listo.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_listo.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_listo.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_listo.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_listo.BorderStyle.EdgeRadius = 7;
            this.btn_listo.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btn_listo.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            this.btn_listo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_listo.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_listo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_listo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_listo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_listo.Location = new System.Drawing.Point(895, 510);
            this.btn_listo.Name = "btn_listo";
            this.btn_listo.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btn_listo.Size = new System.Drawing.Size(246, 70);
            this.btn_listo.TabIndex = 6;
            this.btn_listo.TextStyle.Font = new System.Drawing.Font("Oxygen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listo.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_listo.TextStyle.Text = "Cobrar";
            this.btn_listo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_listo.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(837, 481);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(341, 35);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pnl_sinProd
            // 
            this.pnl_sinProd.BackColor = System.Drawing.Color.SkyBlue;
            this.pnl_sinProd.Controls.Add(this.btn_Nuevo_buscarProd);
            this.pnl_sinProd.Controls.Add(this.ElDivider3);
            this.pnl_sinProd.Controls.Add(this.Label17);
            this.pnl_sinProd.Controls.Add(this.PictureBox3);
            this.pnl_sinProd.ForeColor = System.Drawing.Color.Black;
            this.pnl_sinProd.Location = new System.Drawing.Point(0, 42);
            this.pnl_sinProd.Name = "pnl_sinProd";
            this.pnl_sinProd.Size = new System.Drawing.Size(1190, 564);
            this.pnl_sinProd.TabIndex = 480;
            this.pnl_sinProd.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_sinProd_Paint);
            // 
            // btn_Nuevo_buscarProd
            // 
            this.btn_Nuevo_buscarProd.BackgroundStyle.GradientAngle = 0F;
            this.btn_Nuevo_buscarProd.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_Nuevo_buscarProd.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nuevo_buscarProd.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Nuevo_buscarProd.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Nuevo_buscarProd.BorderStyle.SolidColor = System.Drawing.Color.DodgerBlue;
            this.btn_Nuevo_buscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo_buscarProd.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_Nuevo_buscarProd.EnableThemes = false;
            this.btn_Nuevo_buscarProd.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Nuevo_buscarProd.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Nuevo_buscarProd.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Nuevo_buscarProd.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Nuevo_buscarProd.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo_buscarProd.Location = new System.Drawing.Point(441, 329);
            this.btn_Nuevo_buscarProd.Name = "btn_Nuevo_buscarProd";
            this.btn_Nuevo_buscarProd.Size = new System.Drawing.Size(282, 50);
            this.btn_Nuevo_buscarProd.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.btn_Nuevo_buscarProd.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.btn_Nuevo_buscarProd.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
            this.btn_Nuevo_buscarProd.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.White;
            this.btn_Nuevo_buscarProd.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.White;
            this.btn_Nuevo_buscarProd.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.White;
            this.btn_Nuevo_buscarProd.TabIndex = 407;
            this.btn_Nuevo_buscarProd.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nuevo_buscarProd.TextStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo_buscarProd.TextStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Nuevo_buscarProd.TextStyle.Text = "Buscar Productos | Nuevo [F1]";
            this.btn_Nuevo_buscarProd.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo_buscarProd.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // ElDivider3
            // 
            this.ElDivider3.FadeStyle = Klik.Windows.Forms.v1.EntryLib.DividerFadeStyles.Center;
            this.ElDivider3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ElDivider3.Location = new System.Drawing.Point(206, 245);
            this.ElDivider3.Name = "ElDivider3";
            this.ElDivider3.Size = new System.Drawing.Size(706, 23);
            this.ElDivider3.TabIndex = 408;
            this.ElDivider3.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.White;
            this.Label17.Location = new System.Drawing.Point(386, 208);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(347, 32);
            this.Label17.TabIndex = 405;
            this.Label17.Text = "Tu carrito de Ventas está Vacio";
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.ForeColor = System.Drawing.Color.Black;
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(526, 120);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(96, 96);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox3.TabIndex = 406;
            this.PictureBox3.TabStop = false;
            // 
            // Frm_Ventana_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 608);
            this.Controls.Add(this.pnl_sinProd);
            this.Controls.Add(this.btn_listo);
            this.Controls.Add(this.gru_det);
            this.Controls.Add(this.pnl_titu);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ventana_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atencion al Cliente";
            this.Load += new System.EventHandler(this.Frm_Ventana_Ventas_Load);
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gru_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_listo)).EndInit();
            this.pnl_sinProd.ResumeLayout(false);
            this.pnl_sinProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Nuevo_buscarProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElDivider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_titu;
        private System.Windows.Forms.Button btn_minimi;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELGroupBox gru_det;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_listo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        internal System.Windows.Forms.Panel pnl_sinProd;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_Nuevo_buscarProd;
        internal Klik.Windows.Forms.v1.EntryLib.ELDivider ElDivider3;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.PictureBox PictureBox3;
    }
}