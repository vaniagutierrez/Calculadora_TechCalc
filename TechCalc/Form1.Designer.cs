namespace TechCalc
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label5 = new Label();
            operacionlbl = new Label();
            primernumlbl = new Label();
            panel3 = new Panel();
            resultadolbl = new Label();
            segundonumlbl = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            exitbutton = new Button();
            label3 = new Label();
            divbutton = new Button();
            mulbutton = new Button();
            resbutton = new Button();
            sumbutton = new Button();
            segundonumtxt = new TextBox();
            primernumtxt = new TextBox();
            label2 = new Label();
            primernum = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(operacionlbl);
            groupBox2.Controls.Add(primernumlbl);
            groupBox2.Controls.Add(panel3);
            groupBox2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(410, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 373);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "RESULTADO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(123, 130);
            label5.Name = "label5";
            label5.Size = new Size(139, 18);
            label5.TabIndex = 3;
            label5.Text = "EL RESULTADO ES:";
            label5.Click += label5_Click;
            // 
            // operacionlbl
            // 
            operacionlbl.AutoSize = true;
            operacionlbl.ForeColor = Color.DarkSeaGreen;
            operacionlbl.Location = new Point(74, 109);
            operacionlbl.Name = "operacionlbl";
            operacionlbl.Size = new Size(0, 18);
            operacionlbl.TabIndex = 2;
            // 
            // primernumlbl
            // 
            primernumlbl.AutoSize = true;
            primernumlbl.Location = new Point(74, 73);
            primernumlbl.Name = "primernumlbl";
            primernumlbl.Size = new Size(0, 18);
            primernumlbl.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(resultadolbl);
            panel3.Controls.Add(segundonumlbl);
            panel3.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(51, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 50);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // resultadolbl
            // 
            resultadolbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultadolbl.Location = new Point(0, 0);
            resultadolbl.Name = "resultadolbl";
            resultadolbl.Size = new Size(283, 50);
            resultadolbl.TabIndex = 4;
            resultadolbl.Text = "...";
            resultadolbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // segundonumlbl
            // 
            segundonumlbl.AutoSize = true;
            segundonumlbl.Location = new Point(24, 27);
            segundonumlbl.Name = "segundonumlbl";
            segundonumlbl.Size = new Size(0, 25);
            segundonumlbl.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(exitbutton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(divbutton);
            groupBox1.Controls.Add(mulbutton);
            groupBox1.Controls.Add(resbutton);
            groupBox1.Controls.Add(sumbutton);
            groupBox1.Controls.Add(segundonumtxt);
            groupBox1.Controls.Add(primernumtxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(primernum);
            groupBox1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 373);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "¿QUÉ DESEA CALCULAR HOY?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 311);
            label4.Name = "label4";
            label4.Size = new Size(230, 18);
            label4.TabIndex = 10;
            label4.Text = "¿MUCHA MATEMÁTICA POR HOY?";
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(144, 339);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(87, 28);
            exitbutton.TabIndex = 9;
            exitbutton.Text = "SALIR";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 215);
            label3.Name = "label3";
            label3.Size = new Size(295, 18);
            label3.TabIndex = 8;
            label3.Text = "SELECCIONE LA OPERACIÓN A REALIZAR:";
            // 
            // divbutton
            // 
            divbutton.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divbutton.Location = new Point(182, 246);
            divbutton.Name = "divbutton";
            divbutton.Size = new Size(69, 26);
            divbutton.TabIndex = 7;
            divbutton.Text = "DIVIDIR";
            divbutton.UseVisualStyleBackColor = true;
            divbutton.Click += divbutton_Click;
            // 
            // mulbutton
            // 
            mulbutton.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mulbutton.Location = new Point(257, 246);
            mulbutton.Name = "mulbutton";
            mulbutton.Size = new Size(118, 26);
            mulbutton.TabIndex = 6;
            mulbutton.Text = "MULTIPLICAR";
            mulbutton.UseVisualStyleBackColor = true;
            mulbutton.Click += mulbutton_Click;
            // 
            // resbutton
            // 
            resbutton.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resbutton.Location = new Point(104, 246);
            resbutton.Name = "resbutton";
            resbutton.Size = new Size(72, 26);
            resbutton.TabIndex = 5;
            resbutton.Text = "RESTAR";
            resbutton.UseVisualStyleBackColor = true;
            resbutton.Click += resbutton_Click;
            // 
            // sumbutton
            // 
            sumbutton.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sumbutton.Location = new Point(28, 246);
            sumbutton.Name = "sumbutton";
            sumbutton.Size = new Size(69, 26);
            sumbutton.TabIndex = 4;
            sumbutton.Text = "SUMAR";
            sumbutton.UseVisualStyleBackColor = true;
            sumbutton.Click += sumbutton_Click;
            // 
            // segundonumtxt
            // 
            segundonumtxt.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            segundonumtxt.Location = new Point(104, 160);
            segundonumtxt.Name = "segundonumtxt";
            segundonumtxt.Size = new Size(167, 30);
            segundonumtxt.TabIndex = 3;
            segundonumtxt.TextChanged += segundonumtxt_TextChanged;
            // 
            // primernumtxt
            // 
            primernumtxt.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            primernumtxt.Location = new Point(104, 73);
            primernumtxt.Name = "primernumtxt";
            primernumtxt.Size = new Size(167, 30);
            primernumtxt.TabIndex = 2;
            primernumtxt.TextChanged += primernumtxt_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(81, 130);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(234, 18);
            label2.TabIndex = 1;
            label2.Text = "INGRESE EL SEGUNDO NÚMERO:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // primernum
            // 
            primernum.AutoSize = true;
            primernum.Location = new Point(81, 43);
            primernum.Name = "primernum";
            primernum.Size = new Size(219, 18);
            primernum.TabIndex = 0;
            primernum.Text = "INGRESE EL PRIMER NÚMERO:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(800, 50);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 50);
            label1.TabIndex = 0;
            label1.Text = "TECH CALC: MATEMÁTICAS EN UN CLICK!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private GroupBox groupBox1;
        private Label primernum;
        private TextBox primernumtxt;
        private Label label2;
        private TextBox segundonumtxt;
        private Button divbutton;
        private Button mulbutton;
        private Button resbutton;
        private Button sumbutton;
        private Label label3;
        private GroupBox groupBox2;
        private Button exitbutton;
        private Label label4;
        private Label primernumlbl;
        private Label operacionlbl;
        private Label segundonumlbl;
        private Label label5;
        private Panel panel3;
        private Label resultadolbl;
    }
}
