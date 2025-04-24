namespace cp1_winforms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbResult = new TextBox();
            sevenBtn = new Button();
            eightBtn = new Button();
            nineBtn = new Button();
            fourBtn = new Button();
            threeBtn = new Button();
            twoBtn = new Button();
            oneBtn = new Button();
            multiplyBtn = new Button();
            subtractionBtn = new Button();
            fiveBtn = new Button();
            divideBtn = new Button();
            zeroBtn = new Button();
            sixBtn = new Button();
            sumBtn = new Button();
            equalBtn = new Button();
            squareRootBtn = new Button();
            cubeRootBtn = new Button();
            cleanBtn = new Button();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            integrantesToolStripMenuItem = new ToolStripMenuItem();
            samuelHeitorRM556731ToolStripMenuItem = new ToolStripMenuItem();
            renatoDavidToolStripMenuItem = new ToolStripMenuItem();
            lucasNicoliniRM557613ToolStripMenuItem = new ToolStripMenuItem();
            gustavoLopesRM556859ToolStripMenuItem = new ToolStripMenuItem();
            gabrielJablonskiRMToolStripMenuItem = new ToolStripMenuItem();
            gustavoLopesToolStripMenuItem = new ToolStripMenuItem();
            resumoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.HighlightText;
            lbResult.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResult.ForeColor = Color.Black;
            lbResult.Location = new Point(22, 34);
            lbResult.Margin = new Padding(3, 2, 3, 2);
            lbResult.Name = "lbResult";
            lbResult.PlaceholderText = "0";
            lbResult.RightToLeft = RightToLeft.Yes;
            lbResult.Size = new Size(269, 71);
            lbResult.TabIndex = 0;
            lbResult.KeyPress += LbResult_KeyPress;
            // 
            // sevenBtn
            // 
            sevenBtn.BackColor = Color.Silver;
            sevenBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            sevenBtn.Location = new Point(20, 179);
            sevenBtn.Margin = new Padding(3, 2, 3, 2);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(61, 52);
            sevenBtn.TabIndex = 1;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = false;
            sevenBtn.Click += numberBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.BackColor = Color.Silver;
            eightBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            eightBtn.Location = new Point(87, 179);
            eightBtn.Margin = new Padding(3, 2, 3, 2);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(61, 52);
            eightBtn.TabIndex = 2;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = false;
            eightBtn.Click += numberBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.BackColor = Color.Silver;
            nineBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            nineBtn.Location = new Point(153, 179);
            nineBtn.Margin = new Padding(3, 2, 3, 2);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(61, 52);
            nineBtn.TabIndex = 3;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = false;
            nineBtn.Click += numberBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.BackColor = Color.Silver;
            fourBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            fourBtn.Location = new Point(20, 236);
            fourBtn.Margin = new Padding(3, 2, 3, 2);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(61, 52);
            fourBtn.TabIndex = 4;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = false;
            fourBtn.Click += numberBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.BackColor = Color.Silver;
            threeBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            threeBtn.Location = new Point(153, 293);
            threeBtn.Margin = new Padding(3, 2, 3, 2);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(61, 52);
            threeBtn.TabIndex = 7;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = false;
            threeBtn.Click += numberBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.BackColor = Color.Silver;
            twoBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            twoBtn.Location = new Point(87, 293);
            twoBtn.Margin = new Padding(3, 2, 3, 2);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(61, 52);
            twoBtn.TabIndex = 6;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = false;
            twoBtn.Click += numberBtn_Click;
            // 
            // oneBtn
            // 
            oneBtn.BackColor = Color.Silver;
            oneBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            oneBtn.Location = new Point(20, 293);
            oneBtn.Margin = new Padding(3, 2, 3, 2);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(61, 52);
            oneBtn.TabIndex = 5;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = false;
            oneBtn.Click += numberBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.BackColor = Color.FromArgb(255, 192, 192);
            multiplyBtn.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multiplyBtn.ForeColor = Color.Transparent;
            multiplyBtn.Image = (Image)resources.GetObject("multiplyBtn.Image");
            multiplyBtn.Location = new Point(228, 121);
            multiplyBtn.Margin = new Padding(3, 2, 3, 2);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(61, 52);
            multiplyBtn.TabIndex = 10;
            multiplyBtn.UseVisualStyleBackColor = false;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // subtractionBtn
            // 
            subtractionBtn.BackColor = Color.FromArgb(255, 192, 192);
            subtractionBtn.Image = (Image)resources.GetObject("subtractionBtn.Image");
            subtractionBtn.Location = new Point(228, 178);
            subtractionBtn.Margin = new Padding(3, 2, 3, 2);
            subtractionBtn.Name = "subtractionBtn";
            subtractionBtn.Size = new Size(61, 52);
            subtractionBtn.TabIndex = 9;
            subtractionBtn.UseVisualStyleBackColor = false;
            subtractionBtn.Click += subtractionBtn_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.BackColor = Color.Silver;
            fiveBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            fiveBtn.Location = new Point(87, 236);
            fiveBtn.Margin = new Padding(3, 2, 3, 2);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(61, 52);
            fiveBtn.TabIndex = 8;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = false;
            fiveBtn.Click += numberBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.BackColor = Color.FromArgb(255, 192, 192);
            divideBtn.Image = (Image)resources.GetObject("divideBtn.Image");
            divideBtn.Location = new Point(228, 235);
            divideBtn.Margin = new Padding(3, 2, 3, 2);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(61, 52);
            divideBtn.TabIndex = 13;
            divideBtn.UseVisualStyleBackColor = false;
            divideBtn.Click += divideBtn_Click;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = Color.Silver;
            zeroBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            zeroBtn.Location = new Point(87, 352);
            zeroBtn.Margin = new Padding(3, 2, 3, 2);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(61, 52);
            zeroBtn.TabIndex = 12;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.Click += numberBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = Color.Silver;
            sixBtn.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            sixBtn.Location = new Point(153, 236);
            sixBtn.Margin = new Padding(3, 2, 3, 2);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(61, 52);
            sixBtn.TabIndex = 11;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.Click += numberBtn_Click;
            // 
            // sumBtn
            // 
            sumBtn.BackColor = Color.FromArgb(255, 192, 192);
            sumBtn.Image = (Image)resources.GetObject("sumBtn.Image");
            sumBtn.Location = new Point(228, 293);
            sumBtn.Margin = new Padding(3, 2, 3, 2);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(61, 52);
            sumBtn.TabIndex = 14;
            sumBtn.UseVisualStyleBackColor = false;
            sumBtn.Click += sumBtn_Click;
            // 
            // equalBtn
            // 
            equalBtn.Image = (Image)resources.GetObject("equalBtn.Image");
            equalBtn.Location = new Point(228, 352);
            equalBtn.Margin = new Padding(3, 2, 3, 2);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(61, 52);
            equalBtn.TabIndex = 15;
            equalBtn.UseVisualStyleBackColor = true;
            equalBtn.Click += equalBtn_Click;
            // 
            // squareRootBtn
            // 
            squareRootBtn.BackColor = Color.FromArgb(192, 255, 255);
            squareRootBtn.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            squareRootBtn.ForeColor = SystemColors.ActiveBorder;
            squareRootBtn.Image = (Image)resources.GetObject("squareRootBtn.Image");
            squareRootBtn.Location = new Point(153, 121);
            squareRootBtn.Margin = new Padding(3, 2, 3, 2);
            squareRootBtn.Name = "squareRootBtn";
            squareRootBtn.Size = new Size(61, 52);
            squareRootBtn.TabIndex = 16;
            squareRootBtn.UseVisualStyleBackColor = false;
            squareRootBtn.Click += squareRootBtn_Click;
            // 
            // cubeRootBtn
            // 
            cubeRootBtn.BackColor = Color.FromArgb(192, 255, 255);
            cubeRootBtn.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cubeRootBtn.ForeColor = SystemColors.ActiveBorder;
            cubeRootBtn.Image = (Image)resources.GetObject("cubeRootBtn.Image");
            cubeRootBtn.Location = new Point(87, 121);
            cubeRootBtn.Margin = new Padding(3, 2, 3, 2);
            cubeRootBtn.Name = "cubeRootBtn";
            cubeRootBtn.Size = new Size(61, 52);
            cubeRootBtn.TabIndex = 17;
            cubeRootBtn.UseVisualStyleBackColor = false;
            cubeRootBtn.Click += cubeRootBtn_Click;
            // 
            // cleanBtn
            // 
            cleanBtn.BackColor = Color.FromArgb(255, 128, 0);
            cleanBtn.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cleanBtn.ForeColor = SystemColors.ButtonHighlight;
            cleanBtn.Location = new Point(21, 121);
            cleanBtn.Margin = new Padding(3, 2, 3, 2);
            cleanBtn.Name = "cleanBtn";
            cleanBtn.Size = new Size(61, 52);
            cleanBtn.TabIndex = 18;
            cleanBtn.Text = "C";
            cleanBtn.UseVisualStyleBackColor = false;
            cleanBtn.Click += cleanBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(312, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { integrantesToolStripMenuItem, resumoToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // integrantesToolStripMenuItem
            // 
            integrantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { samuelHeitorRM556731ToolStripMenuItem, renatoDavidToolStripMenuItem, lucasNicoliniRM557613ToolStripMenuItem, gustavoLopesRM556859ToolStripMenuItem, gabrielJablonskiRMToolStripMenuItem, gustavoLopesToolStripMenuItem });
            integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            integrantesToolStripMenuItem.Size = new Size(206, 22);
            integrantesToolStripMenuItem.Text = "Integrantes";
            // 
            // samuelHeitorRM556731ToolStripMenuItem
            // 
            samuelHeitorRM556731ToolStripMenuItem.Name = "samuelHeitorRM556731ToolStripMenuItem";
            samuelHeitorRM556731ToolStripMenuItem.Size = new Size(239, 22);
            samuelHeitorRM556731ToolStripMenuItem.Text = "Samuel Heitor - RM 556731";
            // 
            // renatoDavidToolStripMenuItem
            // 
            renatoDavidToolStripMenuItem.Name = "renatoDavidToolStripMenuItem";
            renatoDavidToolStripMenuItem.Size = new Size(239, 22);
            renatoDavidToolStripMenuItem.Text = "Renato David - RM 555627";
            renatoDavidToolStripMenuItem.Click += renatoDavidToolStripMenuItem_Click;
            // 
            // lucasNicoliniRM557613ToolStripMenuItem
            // 
            lucasNicoliniRM557613ToolStripMenuItem.Name = "lucasNicoliniRM557613ToolStripMenuItem";
            lucasNicoliniRM557613ToolStripMenuItem.Size = new Size(239, 22);
            lucasNicoliniRM557613ToolStripMenuItem.Text = "Lucas Nicolini - RM 557613";
            // 
            // gustavoLopesRM556859ToolStripMenuItem
            // 
            gustavoLopesRM556859ToolStripMenuItem.Name = "gustavoLopesRM556859ToolStripMenuItem";
            gustavoLopesRM556859ToolStripMenuItem.Size = new Size(239, 22);
            gustavoLopesRM556859ToolStripMenuItem.Text = "Gustavo Lopes - RM 556859";
            // 
            // gabrielJablonskiRMToolStripMenuItem
            // 
            gabrielJablonskiRMToolStripMenuItem.Name = "gabrielJablonskiRMToolStripMenuItem";
            gabrielJablonskiRMToolStripMenuItem.Size = new Size(239, 22);
            gabrielJablonskiRMToolStripMenuItem.Text = "Gabriel Jablonski - RM 555452";
            gabrielJablonskiRMToolStripMenuItem.Click += gabrielJablonskiRMToolStripMenuItem_Click;
            // 
            // gustavoLopesToolStripMenuItem
            // 
            gustavoLopesToolStripMenuItem.Name = "gustavoLopesToolStripMenuItem";
            gustavoLopesToolStripMenuItem.Size = new Size(239, 22);
            gustavoLopesToolStripMenuItem.Text = "Matheus Munuera - RM 557812";
            // 
            // resumoToolStripMenuItem
            // 
            resumoToolStripMenuItem.Name = "resumoToolStripMenuItem";
            resumoToolStripMenuItem.Size = new Size(206, 22);
            resumoToolStripMenuItem.Text = "Resumo sobre o trabalho";
            resumoToolStripMenuItem.Click += resumoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(312, 416);
            Controls.Add(cleanBtn);
            Controls.Add(cubeRootBtn);
            Controls.Add(squareRootBtn);
            Controls.Add(equalBtn);
            Controls.Add(sumBtn);
            Controls.Add(divideBtn);
            Controls.Add(zeroBtn);
            Controls.Add(sixBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(subtractionBtn);
            Controls.Add(fiveBtn);
            Controls.Add(threeBtn);
            Controls.Add(twoBtn);
            Controls.Add(oneBtn);
            Controls.Add(fourBtn);
            Controls.Add(nineBtn);
            Controls.Add(eightBtn);
            Controls.Add(sevenBtn);
            Controls.Add(lbResult);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lbResult;
        private Button sevenBtn;
        private Button eightBtn;
        private Button nineBtn;
        private Button fourBtn;
        private Button threeBtn;
        private Button twoBtn;
        private Button oneBtn;
        private Button multiplyBtn;
        private Button subtractionBtn;
        private Button fiveBtn;
        private Button divideBtn;
        private Button zeroBtn;
        private Button sixBtn;
        private Button sumBtn;
        private Button equalBtn;
        private Button squareRootBtn;
        private Button cubeRootBtn;
        private Button cleanBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem integrantesToolStripMenuItem;
        private ToolStripMenuItem resumoToolStripMenuItem;
        private ToolStripMenuItem samuelHeitorRM556731ToolStripMenuItem;
        private ToolStripMenuItem renatoDavidToolStripMenuItem;
        private ToolStripMenuItem lucasNicoliniRM557613ToolStripMenuItem;
        private ToolStripMenuItem gustavoLopesRM556859ToolStripMenuItem;
        private ToolStripMenuItem gabrielJablonskiRMToolStripMenuItem;
        private ToolStripMenuItem gustavoLopesToolStripMenuItem;
    }
}
