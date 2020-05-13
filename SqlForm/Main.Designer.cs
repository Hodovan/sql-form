namespace SqlForm
{
    partial class Main
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblMirror = new System.Windows.Forms.Label();
            this.radSum = new System.Windows.Forms.RadioButton();
            this.radDivide = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cobModifier = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.trbScale = new System.Windows.Forms.TrackBar();
            this.prbScale = new System.Windows.Forms.ProgressBar();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.tltScale = new System.Windows.Forms.ToolTip(this.components);
            this.numNumber1 = new System.Windows.Forms.NumericUpDown();
            this.NumNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutput.Location = new System.Drawing.Point(433, 361);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(355, 80);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "?????";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOutput.Click += new System.EventHandler(this.Output_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(350, 38);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lblMirror
            // 
            this.lblMirror.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMirror.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMirror.Location = new System.Drawing.Point(12, 57);
            this.lblMirror.Name = "lblMirror";
            this.lblMirror.Size = new System.Drawing.Size(350, 31);
            this.lblMirror.TabIndex = 2;
            // 
            // radSum
            // 
            this.radSum.AutoSize = true;
            this.radSum.Checked = true;
            this.radSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radSum.Location = new System.Drawing.Point(509, 16);
            this.radSum.Name = "radSum";
            this.radSum.Size = new System.Drawing.Size(87, 35);
            this.radSum.TabIndex = 3;
            this.radSum.TabStop = true;
            this.radSum.Text = "Sum";
            this.radSum.UseVisualStyleBackColor = true;
            // 
            // radDivide
            // 
            this.radDivide.AutoSize = true;
            this.radDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radDivide.Location = new System.Drawing.Point(509, 57);
            this.radDivide.Name = "radDivide";
            this.radDivide.Size = new System.Drawing.Size(108, 35);
            this.radDivide.TabIndex = 4;
            this.radDivide.Text = "Divide";
            this.radDivide.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAmount.Location = new System.Drawing.Point(205, 122);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(157, 38);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.DoubleClick += new System.EventHandler(this.Amount_DoubleClick);
            // 
            // cobModifier
            // 
            this.cobModifier.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cobModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cobModifier.FormattingEnabled = true;
            this.cobModifier.Items.AddRange(new object[] {
            "Decrease by 10%",
            "Increase by 10%"});
            this.cobModifier.Location = new System.Drawing.Point(18, 175);
            this.cobModifier.Name = "cobModifier";
            this.cobModifier.Size = new System.Drawing.Size(344, 39);
            this.cobModifier.TabIndex = 8;
            this.cobModifier.SelectedIndexChanged += new System.EventHandler(this.Modifier_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrice.Location = new System.Drawing.Point(368, 178);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(130, 31);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "??????";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trbScale
            // 
            this.trbScale.Location = new System.Drawing.Point(18, 242);
            this.trbScale.Maximum = 100;
            this.trbScale.Minimum = 1;
            this.trbScale.Name = "trbScale";
            this.trbScale.Size = new System.Drawing.Size(290, 45);
            this.trbScale.TabIndex = 10;
            this.trbScale.Value = 1;
            this.trbScale.Scroll += new System.EventHandler(this.trbScale_Scroll);
            this.trbScale.ValueChanged += new System.EventHandler(this.trbScale_ValueChanged);
            // 
            // prbScale
            // 
            this.prbScale.Location = new System.Drawing.Point(18, 293);
            this.prbScale.Minimum = 1;
            this.prbScale.Name = "prbScale";
            this.prbScale.Size = new System.Drawing.Size(218, 23);
            this.prbScale.TabIndex = 11;
            this.prbScale.Value = 1;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIncrease.Location = new System.Drawing.Point(275, 293);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(27, 23);
            this.btnIncrease.TabIndex = 12;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDecrease.Location = new System.Drawing.Point(242, 293);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(27, 23);
            this.btnDecrease.TabIndex = 13;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // numNumber1
            // 
            this.numNumber1.DecimalPlaces = 2;
            this.numNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numNumber1.Location = new System.Drawing.Point(374, 13);
            this.numNumber1.Name = "numNumber1";
            this.numNumber1.Size = new System.Drawing.Size(120, 38);
            this.numNumber1.TabIndex = 14;
            // 
            // NumNumber2
            // 
            this.NumNumber2.DecimalPlaces = 2;
            this.NumNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumNumber2.Location = new System.Drawing.Point(374, 57);
            this.NumNumber2.Name = "NumNumber2";
            this.NumNumber2.Size = new System.Drawing.Size(120, 38);
            this.NumNumber2.TabIndex = 15;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExecute.Location = new System.Drawing.Point(637, 12);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(122, 39);
            this.btnExecute.TabIndex = 16;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(631, 59);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 31);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "??????";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.NumNumber2);
            this.Controls.Add(this.numNumber1);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.prbScale);
            this.Controls.Add(this.trbScale);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cobModifier);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radDivide);
            this.Controls.Add(this.radSum);
            this.Controls.Add(this.lblMirror);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Name = "Main";
            this.Text = "SQL Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblMirror;
        private System.Windows.Forms.RadioButton radSum;
        private System.Windows.Forms.RadioButton radDivide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cobModifier;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TrackBar trbScale;
        private System.Windows.Forms.ProgressBar prbScale;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.ToolTip tltScale;
        private System.Windows.Forms.NumericUpDown numNumber1;
        private System.Windows.Forms.NumericUpDown NumNumber2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblResult;
    }
}

