namespace ZonesCashRegister
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
            this.totalButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.pupInput = new System.Windows.Forms.TextBox();
            this.raygunInput = new System.Windows.Forms.TextBox();
            this.batInput = new System.Windows.Forms.TextBox();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.batLabel = new System.Windows.Forms.Label();
            this.raygunLabel = new System.Windows.Forms.Label();
            this.pupLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.taxNoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalButton
            // 
            this.totalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.totalButton.FlatAppearance.BorderSize = 2;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Location = new System.Drawing.Point(66, 250);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(192, 27);
            this.totalButton.TabIndex = 0;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeButton.FlatAppearance.BorderSize = 2;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(66, 467);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(192, 27);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.receiptButton.FlatAppearance.BorderSize = 2;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Location = new System.Drawing.Point(66, 571);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(192, 27);
            this.receiptButton.TabIndex = 2;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newOrderButton.FlatAppearance.BorderSize = 2;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Location = new System.Drawing.Point(370, 571);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(192, 27);
            this.newOrderButton.TabIndex = 3;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // pupInput
            // 
            this.pupInput.Location = new System.Drawing.Point(204, 162);
            this.pupInput.Name = "pupInput";
            this.pupInput.Size = new System.Drawing.Size(54, 20);
            this.pupInput.TabIndex = 4;
            this.pupInput.Text = "0";
            // 
            // raygunInput
            // 
            this.raygunInput.Location = new System.Drawing.Point(204, 188);
            this.raygunInput.Name = "raygunInput";
            this.raygunInput.Size = new System.Drawing.Size(54, 20);
            this.raygunInput.TabIndex = 5;
            this.raygunInput.Text = "0";
            // 
            // batInput
            // 
            this.batInput.Location = new System.Drawing.Point(204, 214);
            this.batInput.Name = "batInput";
            this.batInput.Size = new System.Drawing.Size(54, 20);
            this.batInput.TabIndex = 6;
            this.batInput.Text = "0";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(204, 421);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(54, 20);
            this.tenderedInput.TabIndex = 7;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subtotalOutput.Location = new System.Drawing.Point(187, 296);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(71, 23);
            this.subtotalOutput.TabIndex = 8;
            this.subtotalOutput.Text = "-";
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Location = new System.Drawing.Point(63, 296);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(71, 23);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.Location = new System.Drawing.Point(187, 319);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(71, 23);
            this.taxOutput.TabIndex = 11;
            this.taxOutput.Text = "-";
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Location = new System.Drawing.Point(63, 319);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(71, 23);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax*";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Location = new System.Drawing.Point(63, 342);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(71, 23);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.Location = new System.Drawing.Point(187, 342);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(71, 23);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.Text = "-";
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.Color.Black;
            this.dividerLabel.Location = new System.Drawing.Point(66, 382);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(192, 10);
            this.dividerLabel.TabIndex = 14;
            this.dividerLabel.Text = "label1";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Location = new System.Drawing.Point(63, 419);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(71, 23);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Location = new System.Drawing.Point(63, 518);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(71, 23);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.Location = new System.Drawing.Point(187, 518);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(71, 23);
            this.changeOutput.TabIndex = 17;
            this.changeOutput.Text = "-";
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, -13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(812, 115);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "          Zones Supply";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.BackColor = System.Drawing.Color.Black;
            this.sloganLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel.ForeColor = System.Drawing.Color.White;
            this.sloganLabel.Location = new System.Drawing.Point(403, 40);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(383, 24);
            this.sloganLabel.TabIndex = 19;
            this.sloganLabel.Text = "The One-Stop Zones Shop For Every Killjoy";
            // 
            // batLabel
            // 
            this.batLabel.BackColor = System.Drawing.Color.Transparent;
            this.batLabel.Location = new System.Drawing.Point(63, 212);
            this.batLabel.Name = "batLabel";
            this.batLabel.Size = new System.Drawing.Size(135, 23);
            this.batLabel.TabIndex = 20;
            this.batLabel.Text = "10pk Batteries  - 25 C";
            this.batLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // raygunLabel
            // 
            this.raygunLabel.BackColor = System.Drawing.Color.Transparent;
            this.raygunLabel.Location = new System.Drawing.Point(63, 186);
            this.raygunLabel.Name = "raygunLabel";
            this.raygunLabel.Size = new System.Drawing.Size(135, 23);
            this.raygunLabel.TabIndex = 21;
            this.raygunLabel.Text = "Ray Gun - 115 C";
            this.raygunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pupLabel
            // 
            this.pupLabel.BackColor = System.Drawing.Color.Transparent;
            this.pupLabel.Location = new System.Drawing.Point(63, 160);
            this.pupLabel.Name = "pupLabel";
            this.pupLabel.Size = new System.Drawing.Size(135, 23);
            this.pupLabel.TabIndex = 22;
            this.pupLabel.Text = "Power Pup - 15 C";
            this.pupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Location = new System.Drawing.Point(330, 133);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(272, 420);
            this.receiptLabel.TabIndex = 23;
            // 
            // taxNoteLabel
            // 
            this.taxNoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxNoteLabel.Location = new System.Drawing.Point(72, 645);
            this.taxNoteLabel.Name = "taxNoteLabel";
            this.taxNoteLabel.Size = new System.Drawing.Size(181, 23);
            this.taxNoteLabel.TabIndex = 24;
            this.taxNoteLabel.Text = "*No tax on items under 10 Carbons!";
            this.taxNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 687);
            this.Controls.Add(this.taxNoteLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.pupLabel);
            this.Controls.Add(this.raygunLabel);
            this.Controls.Add(this.batLabel);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.batInput);
            this.Controls.Add(this.raygunInput);
            this.Controls.Add(this.pupInput);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalButton);
            this.Name = "Form1";
            this.Text = "TCM\'s Zone Supply Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.TextBox pupInput;
        private System.Windows.Forms.TextBox raygunInput;
        private System.Windows.Forms.TextBox batInput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label batLabel;
        private System.Windows.Forms.Label raygunLabel;
        private System.Windows.Forms.Label pupLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label taxNoteLabel;
    }
}

