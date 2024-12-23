﻿using System.Drawing;

namespace FinalPaint
{
    partial class PaintApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintApp));
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            selectionBtn = new Button();
            PencilBtn = new Button();
            FillBtn = new Button();
            TypographyBtn = new Button();
            EraserBtn = new Button();
            DroppperBtn = new Button();
            ToolsLabel = new Label();
            flowLayoutPanel9 = new FlowLayoutPanel();
            fontLabel = new Label();
            fontFamilyLabel = new Label();
            label2 = new Label();
            fontStyleLabel = new Label();
            label3 = new Label();
            fontSizeLabel = new Label();
            changeTextBtn = new Button();
            TypographyLabel = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            sizeInput = new NumericUpDown();
            SizeLabel = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            LineBtn = new Button();
            EllipseBtn = new Button();
            TriangleBtn = new Button();
            RightTriangleBtn = new Button();
            RectangleBtn = new Button();
            RombBtn = new Button();
            TrapezBtn = new Button();
            PentagonBtn = new Button();
            HexagonBtn = new Button();
            StarBtn = new Button();
            ShapeLabel = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            black = new Label();
            white = new Label();
            red = new Label();
            orange = new Label();
            yellow = new Label();
            green = new Label();
            blue = new Label();
            violet = new Label();
            pink = new Label();
            brown = new Label();
            peru = new Label();
            bisque = new Label();
            maroon = new Label();
            coral = new Label();
            olive = new Label();
            gold = new Label();
            palegreen = new Label();
            highlight = new Label();
            hotpink = new Label();
            greenyellow = new Label();
            fuchsia = new Label();
            turquoise = new Label();
            lightcoral = new Label();
            indigo = new Label();
            aquamarine = new Label();
            midnightBlue = new Label();
            customColor = new Button();
            ColorLabel = new Label();
            label1 = new Label();
            currentColor = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ShortcutsBtn = new Button();
            locationLabel = new Label();
            Board = new PictureBox();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sizeInput).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Board).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel9);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(PencilBtn);
            flowLayoutPanel3.Controls.Add(FillBtn);
            flowLayoutPanel3.Controls.Add(EraserBtn);
            flowLayoutPanel3.Controls.Add(selectionBtn);
            flowLayoutPanel3.Controls.Add(TypographyBtn);
            flowLayoutPanel3.Controls.Add(DroppperBtn);
            flowLayoutPanel3.Controls.Add(ToolsLabel);
            flowLayoutPanel3.Location = new Point(10, 3);
            flowLayoutPanel3.Margin = new Padding(7, 3, 3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(17, 0, 0, 0);
            flowLayoutPanel3.Size = new Size(154, 125);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // selectionBtn
            // 
            selectionBtn.BackColor = Color.FromArgb(224, 224, 224);
            selectionBtn.BackgroundImage = Properties.Resources.icons8_rectan_30;
            //selectionBtn.BackgroundImage = Properties.Resources.icons8_rectangle_dashes_30;
            selectionBtn.BackgroundImageLayout = ImageLayout.Center;
            selectionBtn.Cursor = Cursors.Hand;
            selectionBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            selectionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            selectionBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            selectionBtn.FlatStyle = FlatStyle.Flat;
            selectionBtn.Location = new Point(17, 47);
            selectionBtn.Margin = new Padding(0, 5, 3, 0);
            selectionBtn.Name = "selectionBtn";
            selectionBtn.Size = new Size(36, 29);
            selectionBtn.TabIndex = 15;
            selectionBtn.Tag = "Selection";
            selectionBtn.UseVisualStyleBackColor = false;
            selectionBtn.Click += selectionBtn_Click;
            // 
            // PencilBtn
            // 
            PencilBtn.BackColor = Color.FromArgb(224, 224, 224);
            PencilBtn.BackgroundImage = Properties.Resources.icons8_pencil_30;
            PencilBtn.BackgroundImageLayout = ImageLayout.Center;
            PencilBtn.Cursor = Cursors.Hand;
            PencilBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            PencilBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            PencilBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            PencilBtn.FlatStyle = FlatStyle.Flat;
            PencilBtn.Location = new Point(17, 10);
            PencilBtn.Margin = new Padding(0, 10, 3, 3);
            PencilBtn.Name = "PencilBtn";
            PencilBtn.Size = new Size(36, 29);
            PencilBtn.TabIndex = 0;
            PencilBtn.Tag = "Pencil";
            PencilBtn.UseVisualStyleBackColor = false;
            PencilBtn.Click += PencilBtn_Click;
            // 
            // FillBtn
            // 
            FillBtn.BackColor = Color.FromArgb(224, 224, 224);
            FillBtn.BackgroundImage = Properties.Resources.icons8_fill_color_30;
            FillBtn.BackgroundImageLayout = ImageLayout.Center;
            FillBtn.Cursor = Cursors.Hand;
            FillBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            FillBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            FillBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            FillBtn.FlatStyle = FlatStyle.Flat;
            FillBtn.Location = new Point(59, 10);
            FillBtn.Margin = new Padding(3, 10, 3, 3);
            FillBtn.Name = "FillBtn";
            FillBtn.Size = new Size(36, 29);
            FillBtn.TabIndex = 8;
            FillBtn.Tag = "Fill";
            FillBtn.UseVisualStyleBackColor = false;
            FillBtn.Click += FillBtn_Click;
            // 
            // TypographyBtn
            // 
            TypographyBtn.BackColor = Color.FromArgb(224, 224, 224);
            TypographyBtn.BackgroundImage = Properties.Resources.icons8_typography_30;
            TypographyBtn.BackgroundImageLayout = ImageLayout.Center;
            TypographyBtn.Cursor = Cursors.Hand;
            TypographyBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            TypographyBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            TypographyBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            TypographyBtn.FlatStyle = FlatStyle.Flat;
            TypographyBtn.Location = new Point(56, 47);
            TypographyBtn.Margin = new Padding(0, 5, 3, 3);
            TypographyBtn.Name = "TypographyBtn";
            TypographyBtn.Size = new Size(36, 29);
            TypographyBtn.TabIndex = 11;
            TypographyBtn.Tag = "Typography";
            TypographyBtn.UseVisualStyleBackColor = false;
            TypographyBtn.Click += TypographyBtn_Click;
            // 
            // EraserBtn
            // 
            EraserBtn.BackColor = Color.FromArgb(224, 224, 224);
            EraserBtn.BackgroundImage = Properties.Resources.icons8_eraser_30;
            EraserBtn.BackgroundImageLayout = ImageLayout.Center;
            EraserBtn.Cursor = Cursors.Hand;
            EraserBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            EraserBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            EraserBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            EraserBtn.FlatStyle = FlatStyle.Flat;
            EraserBtn.Location = new Point(101, 10);
            EraserBtn.Margin = new Padding(3, 10, 3, 3);
            EraserBtn.Name = "EraserBtn";
            EraserBtn.Size = new Size(36, 29);
            EraserBtn.TabIndex = 9;
            EraserBtn.Tag = "Eraser";
            EraserBtn.UseVisualStyleBackColor = false;
            EraserBtn.Click += EraserBtn_Click;
            // 
            // DroppperBtn
            // 
            DroppperBtn.BackColor = Color.FromArgb(224, 224, 224);
            DroppperBtn.BackgroundImage = Properties.Resources.icons8_dropper_30;
            DroppperBtn.BackgroundImageLayout = ImageLayout.Center;
            DroppperBtn.Cursor = Cursors.Hand;
            DroppperBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            DroppperBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            DroppperBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            DroppperBtn.FlatStyle = FlatStyle.Flat;
            DroppperBtn.Location = new Point(98, 47);
            DroppperBtn.Margin = new Padding(3, 5, 3, 3);
            DroppperBtn.Name = "DroppperBtn";
            DroppperBtn.Size = new Size(36, 29);
            DroppperBtn.TabIndex = 10;
            DroppperBtn.Tag = "Dropper";
            DroppperBtn.UseVisualStyleBackColor = false;
            DroppperBtn.Click += DroppperBtn_Click;
            // 
            // ToolsLabel
            // 
            ToolsLabel.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            ToolsLabel.Location = new Point(20, 86);
            ToolsLabel.Margin = new Padding(3, 7, 3, 0);
            ToolsLabel.Name = "ToolsLabel";
            ToolsLabel.Size = new Size(123, 25);
            ToolsLabel.TabIndex = 7;
            ToolsLabel.Text = "Tools";
            ToolsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
                // flowLayoutPanel9
            flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel9.Controls.Add(fontLabel);
            flowLayoutPanel9.Controls.Add(fontFamilyLabel);
            flowLayoutPanel9.Controls.Add(label2);
            flowLayoutPanel9.Controls.Add(fontStyleLabel);
            flowLayoutPanel9.Controls.Add(label3);
            flowLayoutPanel9.Controls.Add(fontSizeLabel);
            flowLayoutPanel9.Controls.Add(changeTextBtn);
            flowLayoutPanel9.Controls.Add(TypographyLabel);
            flowLayoutPanel9.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel9.Location = new Point(10, 140);
            flowLayoutPanel9.Margin = new Padding(7, 3, 3, 3);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(154, 200);
            flowLayoutPanel9.WrapContents = false;
            flowLayoutPanel9.TabIndex = 11;

            // fontLabel
            fontLabel.AutoSize = true;
            fontLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            fontLabel.Location = new Point(3, 3);
            fontLabel.Margin = new Padding(3, 3, 3, 0);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(50, 20);
            fontLabel.TabIndex = 10;
            fontLabel.Text = "Font :";

            // fontFamilyLabel
            fontFamilyLabel.AutoSize = true;
            fontFamilyLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fontFamilyLabel.Location = new Point(3, 25);
            fontFamilyLabel.Margin = new Padding(3, 0, 3, 0);
            fontFamilyLabel.Name = "fontFamilyLabel";
            fontFamilyLabel.Size = new Size(50, 20);
            fontFamilyLabel.TabIndex = 11;
            fontFamilyLabel.Text = "Segoe";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 50);
            label2.Margin = new Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 12;
            label2.Text = "Style :";

            // fontStyleLabel
            fontStyleLabel.AutoSize = true;
            fontStyleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fontStyleLabel.Location = new Point(3, 70);
            fontStyleLabel.Margin = new Padding(3, 0, 3, 0);
            fontStyleLabel.Name = "fontStyleLabel";
            fontStyleLabel.Size = new Size(70, 20);
            fontStyleLabel.TabIndex = 13;
            fontStyleLabel.Text = "Normal";

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 95);
            label3.Margin = new Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 14;
            label3.Text = "Size :";

            // fontSizeLabel
            fontSizeLabel.AutoSize = true;
            fontSizeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fontSizeLabel.Location = new Point(3, 115);
            fontSizeLabel.Margin = new Padding(3, 0, 3, 0);
            fontSizeLabel.Name = "fontSizeLabel";
            fontSizeLabel.Size = new Size(20, 20);
            fontSizeLabel.TabIndex = 15;
            fontSizeLabel.Text = "12";

            // changeTextBtn
            changeTextBtn.Cursor = Cursors.Hand;
            changeTextBtn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            changeTextBtn.Location = new Point(3, 140);
            changeTextBtn.Margin = new Padding(3, 0, 3, 0);
            changeTextBtn.Name = "changeTextBtn";
            changeTextBtn.Size = new Size(100, 30);
            changeTextBtn.TabIndex = 23;
            changeTextBtn.Text = "Change ..";
            changeTextBtn.UseVisualStyleBackColor = true;
            changeTextBtn.Click += changeFont_btn_Click;

            // TypographyLabel
            TypographyLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TypographyLabel.Location = new Point(3, 180);
            TypographyLabel.Margin = new Padding(3, 0, 3, 0);
            TypographyLabel.Name = "TypographyLabel";
            TypographyLabel.Padding = new Padding(0, 0, 0, 10);
            TypographyLabel.Size = new Size(100, 30);
            TypographyLabel.TabIndex = 9;
            TypographyLabel.Text = "Text";
            TypographyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // flowLayoutPanel4
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(sizeInput);
            flowLayoutPanel4.Controls.Add(SizeLabel);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(10, 350);
            flowLayoutPanel4.Margin = new Padding(7, 3, 3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10);
            flowLayoutPanel4.Size = new Size(154, 100);
            flowLayoutPanel4.WrapContents = false;
            flowLayoutPanel4.TabIndex = 10;

            // sizeInput
            sizeInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sizeInput.Location = new Point(3, 3);
            sizeInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            sizeInput.Name = "sizeInput";
            sizeInput.Size = new Size(120, 25);
            sizeInput.TabIndex = 10;
            sizeInput.TextAlign = HorizontalAlignment.Right;
            sizeInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            sizeInput.ValueChanged += sizeInput_ValueChanged;

            // SizeLabel
            SizeLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SizeLabel.Location = new Point(3, 35);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Padding = new Padding(0);
            SizeLabel.Size = new Size(120, 30);
            SizeLabel.TabIndex = 9;
            SizeLabel.Text = "Size";
            SizeLabel.TextAlign = ContentAlignment.MiddleCenter;

            // flowLayoutPanel5
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Controls.Add(ShapeLabel);
            flowLayoutPanel5.Controls.Add(LineBtn);
            flowLayoutPanel5.Controls.Add(EllipseBtn);
            flowLayoutPanel5.Controls.Add(TriangleBtn);
            flowLayoutPanel5.Controls.Add(RightTriangleBtn);
            flowLayoutPanel5.Controls.Add(RectangleBtn);
            flowLayoutPanel5.Controls.Add(RombBtn);
            flowLayoutPanel5.Controls.Add(TrapezBtn);
            flowLayoutPanel5.Controls.Add(PentagonBtn);
            flowLayoutPanel5.Controls.Add(HexagonBtn);
            flowLayoutPanel5.Controls.Add(StarBtn);
            flowLayoutPanel5.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel5.Location = new Point(10, 470);
            flowLayoutPanel5.Margin = new Padding(7, 3, 3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(154, 170);
            flowLayoutPanel5.WrapContents = true;
            flowLayoutPanel5.TabIndex = 8;

            // ShapeLabel
            ShapeLabel.AutoSize = true;
            ShapeLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ShapeLabel.Location = new Point(3, 393);
            ShapeLabel.Margin = new Padding(3);
            ShapeLabel.Name = "ShapeLabel";
            ShapeLabel.Size = new Size(70, 20);
            ShapeLabel.TabIndex = 12;
            ShapeLabel.Text = "Shapes";

            // LineBtn
            LineBtn.BackColor = Color.FromArgb(224, 224, 224);
            LineBtn.BackgroundImage = Properties.Resources.icons8_line_30;
            LineBtn.BackgroundImageLayout = ImageLayout.Center;
            LineBtn.Cursor = Cursors.Hand;
            LineBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            LineBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            LineBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            LineBtn.FlatStyle = FlatStyle.Flat;
            LineBtn.Location = new Point(3, 3);
            LineBtn.Size = new Size(32, 32); 
            LineBtn.Margin = new Padding(3, 3, 3, 3); // Margine uniformă
            LineBtn.Name = "LineBtn";
            LineBtn.TabIndex = 13;
            LineBtn.Tag = "Line";
            LineBtn.UseVisualStyleBackColor = false;
            LineBtn.Click += LineBtn_Click;

            // EllipseBtn
            EllipseBtn.BackColor = Color.FromArgb(224, 224, 224);
            EllipseBtn.BackgroundImage = Properties.Resources.icons8_circle_30;
            EllipseBtn.BackgroundImageLayout = ImageLayout.Center;
            EllipseBtn.Cursor = Cursors.Hand;
            EllipseBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            EllipseBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            EllipseBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            EllipseBtn.FlatStyle = FlatStyle.Flat;
            EllipseBtn.Location = new Point(3, 42);
            EllipseBtn.Margin = new Padding(3, 3, 3, 3);
            EllipseBtn.Name = "EllipseBtn";
            EllipseBtn.Size = new Size(32, 32);
            EllipseBtn.TabIndex = 15;
            EllipseBtn.Tag = "Ellipse";
            EllipseBtn.UseVisualStyleBackColor = false;
            EllipseBtn.Click += EllipseBtn_Click;

            // TriangleBtn
            TriangleBtn.BackColor = Color.FromArgb(224, 224, 224);
            TriangleBtn.BackgroundImage = (Image)resources.GetObject("TriangleBtn.BackgroundImage");
            TriangleBtn.BackgroundImageLayout = ImageLayout.Center;
            TriangleBtn.Cursor = Cursors.Hand;
            TriangleBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            TriangleBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            TriangleBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            TriangleBtn.FlatStyle = FlatStyle.Flat;
            TriangleBtn.Location = new Point(3, 81);
            TriangleBtn.Margin = new Padding(3, 3, 3, 3);
            TriangleBtn.Name = "TriangleBtn";
            TriangleBtn.Size = new Size(32, 32);
            TriangleBtn.TabIndex = 17;
            TriangleBtn.Tag = "Triangle";
            TriangleBtn.UseVisualStyleBackColor = false;
            TriangleBtn.Click += Triangle_Click;

            // RightTriangleBtn
            RightTriangleBtn.BackColor = Color.FromArgb(224, 224, 224);
            RightTriangleBtn.BackgroundImage = (Image)resources.GetObject("RightTriangleBtn.BackgroundImage");
            RightTriangleBtn.BackgroundImageLayout = ImageLayout.Center;
            RightTriangleBtn.Cursor = Cursors.Hand;
            RightTriangleBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            RightTriangleBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            RightTriangleBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            RightTriangleBtn.FlatStyle = FlatStyle.Flat;
            RightTriangleBtn.Location = new Point(3, 120);
            RightTriangleBtn.Margin = new Padding(3, 3, 3, 3);
            RightTriangleBtn.Name = "RightTriangleBtn";
            RightTriangleBtn.Size = new Size(32, 32);
            RightTriangleBtn.TabIndex = 16;
            RightTriangleBtn.Tag = "RightTriangle";
            RightTriangleBtn.UseVisualStyleBackColor = false;
            RightTriangleBtn.Click += RightTriangleBtn_Click;

            // RectangleBtn
            RectangleBtn.BackColor = Color.FromArgb(224, 224, 224);
            RectangleBtn.BackgroundImage = (Image)resources.GetObject("RectangleBtn.BackgroundImage");
            RectangleBtn.BackgroundImageLayout = ImageLayout.Center;
            RectangleBtn.Cursor = Cursors.Hand;
            RectangleBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            RectangleBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            RectangleBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            RectangleBtn.FlatStyle = FlatStyle.Flat;
            RectangleBtn.Location = new Point(3, 159);
            RectangleBtn.Margin = new Padding(3, 3, 3, 3);
            RectangleBtn.Name = "RectangleBtn";
            RectangleBtn.Size = new Size(32, 32);
            RectangleBtn.TabIndex = 14;
            RectangleBtn.Tag = "Rectangle";
            RectangleBtn.UseVisualStyleBackColor = false;
            RectangleBtn.Click += RectangleBtn_Click;

            // RombBtn
            RombBtn.BackColor = Color.FromArgb(224, 224, 224);
            RombBtn.BackgroundImage = (Image)resources.GetObject("RombBtn.BackgroundImage");
            RombBtn.BackgroundImageLayout = ImageLayout.Center;
            RombBtn.Cursor = Cursors.Hand;
            RombBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            RombBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            RombBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            RombBtn.FlatStyle = FlatStyle.Flat;
            RombBtn.Location = new Point(3, 198);
            RombBtn.Margin = new Padding(3, 3, 3, 3);
            RombBtn.Name = "RombBtn";
            RombBtn.Size = new Size(32, 32);
            RombBtn.TabIndex = 21;
            RombBtn.Tag = "Romb";
            RombBtn.UseVisualStyleBackColor = false;
            RombBtn.Click += RombBtn_Click;

            // TrapezBtn
            TrapezBtn.BackColor = Color.FromArgb(224, 224, 224);
            TrapezBtn.BackgroundImage = (Image)resources.GetObject("TrapezBtn.BackgroundImage");
            TrapezBtn.BackgroundImageLayout = ImageLayout.Center;
            TrapezBtn.Cursor = Cursors.Hand;
            TrapezBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            TrapezBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            TrapezBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            TrapezBtn.FlatStyle = FlatStyle.Flat;
            TrapezBtn.Location = new Point(3, 237);
            TrapezBtn.Margin = new Padding(3, 3, 3, 3);
            TrapezBtn.Name = "TrapezBtn";
            TrapezBtn.Size = new Size(32, 32);
            TrapezBtn.TabIndex = 22;
            TrapezBtn.Tag = "Trapez";
            TrapezBtn.UseVisualStyleBackColor = false;
            TrapezBtn.Click += HeartBtn_Click;
            // PentagonBtn
            PentagonBtn.BackColor = Color.FromArgb(224, 224, 224);
            PentagonBtn.BackgroundImage = (Image)resources.GetObject("PentagonBtn.BackgroundImage");
            PentagonBtn.BackgroundImageLayout = ImageLayout.Center;
            PentagonBtn.Cursor = Cursors.Hand;
            PentagonBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            PentagonBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            PentagonBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            PentagonBtn.FlatStyle = FlatStyle.Flat;
            PentagonBtn.Location = new Point(3, 276);
            PentagonBtn.Margin = new Padding(3, 3, 3, 3);
            PentagonBtn.Name = "PentagonBtn";
            PentagonBtn.Size = new Size(32, 32);
            PentagonBtn.TabIndex = 18;
            PentagonBtn.Tag = "Pentagon";
            PentagonBtn.UseVisualStyleBackColor = false;
            PentagonBtn.Click += PentagonBtn_Click;

            // HexagonBtn
            HexagonBtn.BackColor = Color.FromArgb(224, 224, 224);
            HexagonBtn.BackgroundImage = (Image)resources.GetObject("HexagonBtn.BackgroundImage");
            HexagonBtn.BackgroundImageLayout = ImageLayout.Center;
            HexagonBtn.Cursor = Cursors.Hand;
            HexagonBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            HexagonBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            HexagonBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            HexagonBtn.FlatStyle = FlatStyle.Flat;
            HexagonBtn.Location = new Point(3, 315);
            HexagonBtn.Margin = new Padding(3, 3, 3, 3);
            HexagonBtn.Name = "HexagonBtn";
            HexagonBtn.Size = new Size(32, 32);
            HexagonBtn.TabIndex = 19;
            HexagonBtn.Tag = "Hexagon";
            HexagonBtn.UseVisualStyleBackColor = false;
            HexagonBtn.Click += HexagonBtn_Click;

            // StarBtn
            StarBtn.BackColor = Color.FromArgb(224, 224, 224);
            StarBtn.BackgroundImage = (Image)resources.GetObject("StarBtn.BackgroundImage");
            StarBtn.BackgroundImageLayout = ImageLayout.Center;
            StarBtn.Cursor = Cursors.Hand;
            StarBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            StarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            StarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            StarBtn.FlatStyle = FlatStyle.Flat;
            StarBtn.Location = new Point(3, 354);
            StarBtn.Margin = new Padding(3, 3, 3, 3);
            StarBtn.Name = "StarBtn";
            StarBtn.Size = new Size(32, 32);
            StarBtn.TabIndex = 20;
            StarBtn.Tag = "Star";
            StarBtn.UseVisualStyleBackColor = false;
            StarBtn.Click += StarBtn_Click;

            

            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Controls.Add(black);
            flowLayoutPanel6.Controls.Add(white);
            flowLayoutPanel6.Controls.Add(red);
            flowLayoutPanel6.Controls.Add(orange);
            flowLayoutPanel6.Controls.Add(yellow);
            flowLayoutPanel6.Controls.Add(green);
            flowLayoutPanel6.Controls.Add(blue);
            flowLayoutPanel6.Controls.Add(violet);
            flowLayoutPanel6.Controls.Add(pink);
            flowLayoutPanel6.Controls.Add(brown);
            flowLayoutPanel6.Controls.Add(peru);
            flowLayoutPanel6.Controls.Add(bisque);
            flowLayoutPanel6.Controls.Add(maroon);
            flowLayoutPanel6.Controls.Add(coral);
            flowLayoutPanel6.Controls.Add(olive);
            flowLayoutPanel6.Controls.Add(gold);
            flowLayoutPanel6.Controls.Add(palegreen);
            flowLayoutPanel6.Controls.Add(highlight);
            flowLayoutPanel6.Controls.Add(hotpink);
            flowLayoutPanel6.Controls.Add(greenyellow);
            flowLayoutPanel6.Controls.Add(fuchsia);
            flowLayoutPanel6.Controls.Add(turquoise);
            flowLayoutPanel6.Controls.Add(lightcoral);
            flowLayoutPanel6.Controls.Add(indigo);
            flowLayoutPanel6.Controls.Add(aquamarine);
            flowLayoutPanel6.Controls.Add(midnightBlue);
            flowLayoutPanel6.Controls.Add(customColor);
            flowLayoutPanel6.Controls.Add(ColorLabel);
            flowLayoutPanel6.Controls.Add(label1);
            flowLayoutPanel6.Controls.Add(currentColor);
            flowLayoutPanel6.Cursor = Cursors.Hand;
            flowLayoutPanel6.Location = new Point(972, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(0, 7, 0, 0);
            flowLayoutPanel6.Size = new Size(162, 325); 
            flowLayoutPanel6.TabIndex = 9;
            flowLayoutPanel6.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel6.WrapContents = true;
            // 
            // black
            // 
            black.BackColor = Color.Black;
            black.Location = new Point(3, 7);
            black.Name = "black";
            black.Size = new Size(34, 34);
            black.Margin = new Padding(3);
            black.TabIndex = 37;
            black.Tag = "black";
            black.Click += color_Click;
            // 
            // white
            // 
            white.BackColor = Color.White;
            white.Location = new Point(43, 7);
            white.Name = "white";
            white.Size = new Size(34, 34);
            white.Margin = new Padding(3);
            white.TabIndex = 12;
            white.Tag = "white";
            white.Click += color_Click;
            // 
            // red
            // 
            red.BackColor = Color.Red;
            red.Location = new Point(83, 7);
            red.Name = "red";
            red.Size = new Size(34, 34);
            red.Margin = new Padding(3);
            red.TabIndex = 13;
            red.Tag = "red";
            red.Click += color_Click;
            // 
            // orange
            // 
            orange.BackColor = Color.Orange;
            orange.Location = new Point(123, 7);
            orange.Name = "orange";
            orange.Size = new Size(34, 34);
            orange.Margin = new Padding(3);
            orange.TabIndex = 14;
            orange.Tag = "orange";
            orange.Click += color_Click;
            // 
            // yellow
            // 
            yellow.BackColor = Color.Yellow;
            yellow.Location = new Point(163, 7);
            yellow.Name = "yellow";
            yellow.Size = new Size(34, 34);
            orange.Margin = new Padding(3);
            yellow.TabIndex = 15;
            yellow.Tag = "yellow";
            yellow.Click += color_Click;
            // 
            // green
            // 
            green.BackColor = Color.Green;
            green.Location = new Point(203, 7);
            green.Name = "green";
            green.Size = new Size(34, 34);
            green.Margin = new Padding(3);
            green.TabIndex = 16;
            green.Tag = "green";
            green.Click += color_Click;
            // 
            // blue
            // 
            blue.BackColor = Color.Aqua;
            blue.Location = new Point(243, 7);
            blue.Name = "blue";
            blue.Size = new Size(34, 34);
            blue.Margin = new Padding(3);
            blue.TabIndex = 17;
            blue.Tag = "blue";
            blue.Click += color_Click;
            // 
            // violet
            // 
            violet.BackColor = Color.Violet;
            violet.Location = new Point(283, 7);
            violet.Name = "violet";
            violet.Size = new Size(34, 34);
            violet.Margin = new Padding(3);
            violet.TabIndex = 18;
            violet.Tag = "violet";
            violet.Click += color_Click;
            // 
            // pink
            // 
            pink.BackColor = Color.Pink;
            pink.Location = new Point(323, 7);
            pink.Name = "pink";
            pink.Size = new Size(34, 34);
            pink.Margin = new Padding(3);
            pink.TabIndex = 19;
            pink.Tag = "pink";
            pink.Click += color_Click;
            // 
            // brown
            // 
            brown.BackColor = Color.Brown;
            brown.Location = new Point(363, 7);
            brown.Name = "brown";
            brown.Size = new Size(34, 34);
            brown.Margin = new Padding(3);
            brown.TabIndex = 20;
            brown.Tag = "brown";
            brown.Click += color_Click;
            // 
            // peru
            // 
            peru.BackColor = Color.Peru;
            peru.Location = new Point(403, 7);
            peru.Name = "peru";
            peru.Size = new Size(34, 34);
            peru.Margin = new Padding(3);
            peru.TabIndex = 21;
            peru.Tag = "peru";
            peru.Click += color_Click;
            // 
            // bisque
            // 
            bisque.BackColor = Color.Bisque;
            bisque.Location = new Point(443, 7);
            bisque.Name = "bisque";
            bisque.Size = new Size(34, 34);
            bisque.Margin = new Padding(3);
            bisque.TabIndex = 23;
            bisque.Tag = "bisque";
            bisque.Click += color_Click;
            // 
            // maroon
            // 
            maroon.BackColor = Color.Maroon;
            maroon.Location = new Point(483, 7);
            maroon.Name = "maroon";
            maroon.Size = new Size(34, 34);
            maroon.Margin = new Padding(3);
            maroon.TabIndex = 24;
            maroon.Tag = "maroon";
            maroon.Click += color_Click;
            // 
            // coral
            // 
            coral.BackColor = Color.Coral;
            coral.Location = new Point(3, 47);
            coral.Margin = new Padding(3, 7, 3, 0);
            coral.Name = "coral";
            coral.Size = new Size(34, 34);
            coral.Margin = new Padding(3);
            coral.TabIndex = 25;
            coral.Tag = "coral";
            coral.Click += color_Click;
            // 
            // olive
            // 
            olive.BackColor = Color.Olive;
            olive.Location = new Point(43, 47);
            olive.Margin = new Padding(3, 7, 3, 0);
            olive.Name = "olive";
            olive.Size = new Size(34, 34);
            olive.Margin = new Padding(3);
            olive.TabIndex = 26;
            olive.Tag = "olive";
            olive.Click += color_Click;
            // 
            // gold
            // 
            gold.BackColor = Color.Gold;
            gold.Location = new Point(83, 47);
            gold.Margin = new Padding(3, 7, 3, 0);
            gold.Name = "gold";
            gold.Size = new Size(34, 34);
            gold.Margin = new Padding(3);
            gold.TabIndex = 27;
            gold.Tag = "gold";
            gold.Click += color_Click;
            // 
            // palegreen
            // 
            palegreen.BackColor = Color.PaleGreen;
            palegreen.Location = new Point(123, 47);
            palegreen.Margin = new Padding(3, 7, 3, 0);
            palegreen.Name = "palegreen";
            palegreen.Size = new Size(34, 34);
            palegreen.Margin = new Padding(3);
            palegreen.TabIndex = 28;
            palegreen.Tag = "palegreen";
            palegreen.Click += color_Click;
            // 
            // highlight
            // 
            highlight.BackColor = SystemColors.Highlight;
            highlight.Location = new Point(163, 47);
            highlight.Margin = new Padding(3, 7, 3, 0);
            highlight.Name = "highlight";
            highlight.Size = new Size(34, 34);
            highlight.Margin = new Padding(3);
            highlight.TabIndex = 29;
            highlight.Tag = "highlight";
            highlight.Click += color_Click;
            // 
            // hotpink
            // 
            hotpink.BackColor = Color.HotPink;
            hotpink.Location = new Point(203, 47);
            hotpink.Margin = new Padding(3, 7, 3, 0);
            hotpink.Name = "hotpink";
            hotpink.Size = new Size(34, 34);
            hotpink.Margin = new Padding(3);
            hotpink.TabIndex = 30;
            hotpink.Tag = "hotpink";
            hotpink.Click += color_Click;
            // 
            // greenyellow
            // 
            greenyellow.BackColor = Color.GreenYellow;
            greenyellow.Location = new Point(243, 47);
            greenyellow.Margin = new Padding(3, 3, 3, 3);
            greenyellow.Name = "greenyellow";
            greenyellow.Size = new Size(34, 34);
            greenyellow.Margin = new Padding(3);
            greenyellow.TabIndex = 31;
            greenyellow.Tag = "greenyellow";
            greenyellow.Click += color_Click;
            // 
            // fuchsia
            // 
            fuchsia.BackColor = Color.Fuchsia;
            fuchsia.Location = new Point(283, 47);
            fuchsia.Margin = new Padding(3, 7, 3, 0);
            fuchsia.Name = "fuchsia";
            fuchsia.Size = new Size(34, 34);
            fuchsia.Margin = new Padding(3);
            fuchsia.TabIndex = 32;
            fuchsia.Tag = "fuchsia";
            fuchsia.Click += color_Click;
            // 
            // turquoise
            // 
            turquoise.BackColor = Color.Turquoise;
            turquoise.Location = new Point(323, 47);
            turquoise.Margin = new Padding(3, 7, 3, 0);
            turquoise.Name = "turquoise";
            turquoise.Size = new Size(34, 34);
            turquoise.Margin = new Padding(3);
            turquoise.TabIndex = 36;
            turquoise.Tag = "turquoise";
            turquoise.Click += color_Click;
            // 
            // lightcoral
            // 
            lightcoral.BackColor = Color.LightCoral;
            lightcoral.Location = new Point(363, 47);
            lightcoral.Margin = new Padding(3, 7, 3, 0);
            lightcoral.Name = "lightcoral";
            lightcoral.Size = new Size(34, 34);
            lightcoral.Margin = new Padding(3);
            lightcoral.TabIndex = 34;
            lightcoral.Tag = "lightcoral";
            lightcoral.Click += color_Click;
            // 
            // indigo
            // 
            indigo.BackColor = Color.Indigo;
            indigo.Location = new Point(403, 47);
            indigo.Margin = new Padding(3, 7, 3, 0);
            indigo.Name = "indigo";
            indigo.Size = new Size(34, 34);
            indigo.Margin = new Padding(3);
            indigo.TabIndex = 33;
            indigo.Tag = "indigo";
            indigo.Click += color_Click;
            // 
            // aquamarine
            // 
            aquamarine.BackColor = Color.Aquamarine;
            aquamarine.Location = new Point(443, 47);
            aquamarine.Margin = new Padding(3, 7, 3, 0);
            aquamarine.Name = "aquamarine";
            aquamarine.Size = new Size(34, 34);
            aquamarine.Margin = new Padding(3);
            aquamarine.TabIndex = 35;
            aquamarine.Tag = "aquamarine";
            aquamarine.Click += color_Click;
            // 
            // midnightBlue
            // 
            midnightBlue.BackColor = Color.MidnightBlue;
            midnightBlue.Location = new Point(483, 47);
            midnightBlue.Margin = new Padding(3, 7, 3, 0);
            midnightBlue.Name = "midnightBlue";
            midnightBlue.Size = new Size(34, 34);
            midnightBlue.Margin = new Padding(3);
            midnightBlue.TabIndex = 11;
            midnightBlue.Tag = "midnightBlue";
            midnightBlue.Click += color_Click;
            // 
            //
            // customColor
            //
            customColor.Text = "Add ...";
            customColor.BackColor = Color.LightGray;
            customColor.Margin = new Padding(30, 5, 10, 10); 
            customColor.Size = new Size(100, 30);
            customColor.Click += customColor_Click;
            flowLayoutPanel6.SetFlowBreak(customColor, true);

            // 
            // ColorLabel
            // 
            ColorLabel.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            ColorLabel.Location = new Point(229, 87);
            ColorLabel.Margin = new Padding(137, 7, 3, 0);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(78, 31);
            ColorLabel.TabIndex = 10;
            ColorLabel.Text = "Colors";
            ColorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(385, 88);
            label1.Margin = new Padding(75, 8, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 38;
            label1.Text = "Current :";
            // 
            // currentColor
            // 
            currentColor.BackColor = Color.Black;
            currentColor.Location = new Point(483, 85);
            currentColor.Margin = new Padding(2, 5, 3, 0);
            currentColor.Name = "currentColor";
            currentColor.Size = new Size(33, 33);
            currentColor.TabIndex = 39;
            currentColor.Text = "ngjgjggj";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel2.Controls.Add(ShortcutsBtn);
            flowLayoutPanel2.Controls.Add(locationLabel);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 971);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1536, 70);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // ShortcutsBtn
            // 
            ShortcutsBtn.Cursor = Cursors.Hand;
            ShortcutsBtn.FlatAppearance.BorderSize = 0;
            ShortcutsBtn.FlatStyle = FlatStyle.Flat;
            ShortcutsBtn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ShortcutsBtn.ForeColor = Color.White;
            ShortcutsBtn.Location = new Point(3, 0);
            ShortcutsBtn.Margin = new Padding(3, 0, 3, 3);
            ShortcutsBtn.Name = "ShortcutsBtn";
            ShortcutsBtn.Size = new Size(151, 70);
            ShortcutsBtn.TabIndex = 2;
            ShortcutsBtn.Text = "Shortcuts";
            ShortcutsBtn.TextAlign = ContentAlignment.TopCenter;
            ShortcutsBtn.UseVisualStyleBackColor = true;
            ShortcutsBtn.Click += ShortcutsBtn_Click;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            locationLabel.ForeColor = Color.White;
            locationLabel.Location = new Point(160, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Padding = new Padding(0, 3, 20, 0);
            locationLabel.Size = new Size(265, 30);
            locationLabel.TabIndex = 1;
            locationLabel.Text = "Location  : { X=0,Y=0}";
            locationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Board
            // 
            Board.Dock = DockStyle.Fill;
            Board.Location = new Point(0, 0);
            Board.Margin = new Padding(30, 3, 3, 3);
            Board.Name = "Board";
            Board.Size = new Size(1536, 1041);
            Board.TabIndex = 2;
            Board.TabStop = false;
            Board.Click += Board_Click;
            Board.Paint += Board_Paint;
            Board.MouseDown += Board_MouseDown;
            Board.MouseMove += Board_MouseMove;
            Board.MouseUp += Board_MouseUp;
            // 
            // PaintApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 1041);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Board);
            KeyPreview = true;
            Name = "PaintApp";
            Text = "Form1";
            Load += PaintApp_Load;
            SizeChanged += PaintApp_SizeChanged;
            KeyDown += PaintApp_KeyDown;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sizeInput).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Board).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox Board;
        private Button PencilBtn;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button FillBtn;
        private Label ToolsLabel;
        private Button EraserBtn;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button LineBtn;
        private Button EllipseBtn;
        private Button RectangleBtn;
        private Label ShapeLabel;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label midnightBlue;
        private Label white;
        private Label red;
        private Label orange;
        private Label yellow;
        private Label green;
        private Label blue;
        private Label violet;
        private Label pink;
        private Label brown;
        private Label peru;
        private Label bisque;
        private Label maroon;
        private Label coral;
        private Label olive;
        private Label gold;
        private Label palegreen;
        private Label highlight;
        private Label hotpink;
        private Label greenyellow;
        private Label fuchsia;
        private Label lightcoral;
        private Label indigo;
        private Label aquamarine;
        private Label turquoise;
        private Label black;
        private Button customColor;
        private Label ColorLabel;
        private FlowLayoutPanel flowLayoutPanel4;
        private NumericUpDown sizeInput;
        private Label SizeLabel;
        private Label locationLabel;
        private Label label1;
        private Label currentColor;
        private Button RightTriangleBtn;
        private Button TriangleBtn;
        private Button PentagonBtn;
        private Button HexagonBtn;
        private Button StarBtn;
        private Button RombBtn;
        private Button TrapezBtn;
        private Button DroppperBtn;
        private ToolTip toolTip1;
        private Button ShortcutsBtn;
        private Button TypographyBtn;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label TypographyLabel;
        private Label fontLabel;
        private Label fontFamilyLabel;
        private Label label2;
        private Label fontStyleLabel;
        private Label label3;
        private Label fontSizeLabel;
        private Button changeTextBtn;
        private Button selectionBtn;
    }
}