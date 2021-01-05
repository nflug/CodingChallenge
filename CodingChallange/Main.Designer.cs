namespace CodingChallange
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GrandientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DataDisplay = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Logo_BWI = new System.Windows.Forms.PictureBox();
            this.Logo_getinit = new System.Windows.Forms.PictureBox();
            this.CloseButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SelectJSONButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Title = new Bunifu.UI.WinForms.BunifuLabel();
            this.Info = new Bunifu.UI.WinForms.BunifuLabel();
            this.GrandientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_BWI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_getinit)).BeginInit();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.ElipseRadius = 50;
            this.MainForm.TargetControl = this;
            // 
            // GrandientPanel
            // 
            this.GrandientPanel.BackColor = System.Drawing.Color.Transparent;
            this.GrandientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GrandientPanel.BackgroundImage")));
            this.GrandientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrandientPanel.Controls.Add(this.DataDisplay);
            this.GrandientPanel.Controls.Add(this.SelectJSONButton);
            this.GrandientPanel.Controls.Add(this.Logo_getinit);
            this.GrandientPanel.Controls.Add(this.Logo_BWI);
            this.GrandientPanel.Controls.Add(this.CloseButton);
            this.GrandientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrandientPanel.GradientBottomLeft = System.Drawing.Color.Firebrick;
            this.GrandientPanel.GradientBottomRight = System.Drawing.Color.DarkRed;
            this.GrandientPanel.GradientTopLeft = System.Drawing.Color.Brown;
            this.GrandientPanel.GradientTopRight = System.Drawing.Color.IndianRed;
            this.GrandientPanel.Location = new System.Drawing.Point(0, 0);
            this.GrandientPanel.Name = "GrandientPanel";
            this.GrandientPanel.Quality = 10;
            this.GrandientPanel.Size = new System.Drawing.Size(800, 450);
            this.GrandientPanel.TabIndex = 3;
            // 
            // DataDisplay
            // 
            this.DataDisplay.AllowCustomTheming = true;
            this.DataDisplay.AllowUserToAddRows = false;
            this.DataDisplay.AllowUserToDeleteRows = false;
            this.DataDisplay.AllowUserToResizeColumns = false;
            this.DataDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDisplay.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DataDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDisplay.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DataDisplay.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataDisplay.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataDisplay.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DataDisplay.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataDisplay.CurrentTheme.BackColor = System.Drawing.Color.MediumAquamarine;
            this.DataDisplay.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.DataDisplay.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.DataDisplay.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataDisplay.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataDisplay.CurrentTheme.Name = null;
            this.DataDisplay.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DataDisplay.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataDisplay.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataDisplay.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DataDisplay.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataDisplay.EnableHeadersVisualStyles = false;
            this.DataDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.DataDisplay.HeaderBackColor = System.Drawing.Color.Maroon;
            this.DataDisplay.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataDisplay.HeaderForeColor = System.Drawing.Color.White;
            this.DataDisplay.Location = new System.Drawing.Point(21, 136);
            this.DataDisplay.MultiSelect = false;
            this.DataDisplay.Name = "DataDisplay";
            this.DataDisplay.ReadOnly = true;
            this.DataDisplay.RowHeadersVisible = false;
            this.DataDisplay.RowTemplate.Height = 40;
            this.DataDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataDisplay.ShowEditingIcon = false;
            this.DataDisplay.Size = new System.Drawing.Size(754, 289);
            this.DataDisplay.TabIndex = 5;
            this.DataDisplay.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            this.DataDisplay.SelectionChanged += new System.EventHandler(this.DataDisplay_SelectionChanged);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.GrandientPanel;
            this.DragControl.Vertical = true;
            // 
            // DragControlHeader
            // 
            this.DragControlHeader.Fixed = true;
            this.DragControlHeader.Horizontal = true;
            this.DragControlHeader.Vertical = true;
            // 
            // Logo_BWI
            // 
            this.Logo_BWI.BackColor = System.Drawing.Color.Transparent;
            this.Logo_BWI.Image = global::CodingChallange.Properties.Resources.BWI_logo;
            this.Logo_BWI.Location = new System.Drawing.Point(21, 14);
            this.Logo_BWI.Name = "Logo_BWI";
            this.Logo_BWI.Size = new System.Drawing.Size(127, 92);
            this.Logo_BWI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_BWI.TabIndex = 1;
            this.Logo_BWI.TabStop = false;
            // 
            // Logo_getinit
            // 
            this.Logo_getinit.BackColor = System.Drawing.Color.Transparent;
            this.Logo_getinit.Image = global::CodingChallange.Properties.Resources.getinit_logo;
            this.Logo_getinit.Location = new System.Drawing.Point(169, 14);
            this.Logo_getinit.Name = "Logo_getinit";
            this.Logo_getinit.Size = new System.Drawing.Size(132, 92);
            this.Logo_getinit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_getinit.TabIndex = 2;
            this.Logo_getinit.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Maroon;
            this.CloseButton.color = System.Drawing.Color.Maroon;
            this.CloseButton.colorActive = System.Drawing.Color.DarkRed;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImagePosition = 20;
            this.CloseButton.ImageZoom = 50;
            this.CloseButton.LabelPosition = 41;
            this.CloseButton.LabelText = "";
            this.CloseButton.Location = new System.Drawing.Point(748, 14);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 26);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SelectJSONButton
            // 
            this.SelectJSONButton.Active = false;
            this.SelectJSONButton.Activecolor = System.Drawing.Color.DarkRed;
            this.SelectJSONButton.BackColor = System.Drawing.Color.Maroon;
            this.SelectJSONButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectJSONButton.BorderRadius = 0;
            this.SelectJSONButton.ButtonText = "Daten auswählen";
            this.SelectJSONButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectJSONButton.DisabledColor = System.Drawing.Color.Gray;
            this.SelectJSONButton.ForeColor = System.Drawing.Color.White;
            this.SelectJSONButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SelectJSONButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SelectJSONButton.Iconimage")));
            this.SelectJSONButton.Iconimage_right = null;
            this.SelectJSONButton.Iconimage_right_Selected = null;
            this.SelectJSONButton.Iconimage_Selected = null;
            this.SelectJSONButton.IconMarginLeft = 0;
            this.SelectJSONButton.IconMarginRight = 0;
            this.SelectJSONButton.IconRightVisible = false;
            this.SelectJSONButton.IconRightZoom = 0D;
            this.SelectJSONButton.IconVisible = false;
            this.SelectJSONButton.IconZoom = 90D;
            this.SelectJSONButton.IsTab = false;
            this.SelectJSONButton.Location = new System.Drawing.Point(557, 14);
            this.SelectJSONButton.Name = "SelectJSONButton";
            this.SelectJSONButton.Normalcolor = System.Drawing.Color.Maroon;
            this.SelectJSONButton.OnHovercolor = System.Drawing.Color.DarkRed;
            this.SelectJSONButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SelectJSONButton.selected = false;
            this.SelectJSONButton.Size = new System.Drawing.Size(178, 26);
            this.SelectJSONButton.TabIndex = 0;
            this.SelectJSONButton.Text = "Daten auswählen";
            this.SelectJSONButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectJSONButton.Textcolor = System.Drawing.Color.White;
            this.SelectJSONButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectJSONButton.Click += new System.EventHandler(this.SelectJSON_Click);
            // 
            // Title
            // 
            this.Title.AutoEllipsis = false;
            this.Title.CursorType = null;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(579, 49);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Title.Size = new System.Drawing.Size(196, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Coding Challange";
            this.Title.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Title.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Info
            // 
            this.Info.AutoEllipsis = false;
            this.Info.CursorType = null;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(611, 86);
            this.Info.Name = "Info";
            this.Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Info.Size = new System.Drawing.Size(139, 15);
            this.Info.TabIndex = 3;
            this.Info.Text = "Coded by Patrick Deschauer";
            this.Info.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Info.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrandientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.GrandientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_BWI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_getinit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse MainForm;
        private Bunifu.Framework.UI.BunifuGradientPanel GrandientPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControlHeader;
        private Bunifu.UI.WinForms.BunifuDataGridView DataDisplay;
        private Bunifu.Framework.UI.BunifuFlatButton SelectJSONButton;
        private System.Windows.Forms.PictureBox Logo_getinit;
        private System.Windows.Forms.PictureBox Logo_BWI;
        private Bunifu.Framework.UI.BunifuTileButton CloseButton;
        private Bunifu.UI.WinForms.BunifuLabel Title;
        private Bunifu.UI.WinForms.BunifuLabel Info;
    }
}

