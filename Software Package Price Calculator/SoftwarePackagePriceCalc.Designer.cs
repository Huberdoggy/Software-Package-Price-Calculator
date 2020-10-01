namespace Software_Package_Price_Calculator
{
    partial class SoftwarePackagePriceCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwarePackagePriceCalc));
            this.num_of_packagesTxtbox = new System.Windows.Forms.TextBox();
            this.num_of_packagesLbl = new System.Windows.Forms.Label();
            this.total_calcValueLbl = new System.Windows.Forms.Label();
            this.youPayLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.calc_purchaseBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.originalPriceLbl = new System.Windows.Forms.Label();
            this.original_price_outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num_of_packagesTxtbox
            // 
            this.num_of_packagesTxtbox.BackColor = System.Drawing.Color.White;
            this.num_of_packagesTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_of_packagesTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_of_packagesTxtbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num_of_packagesTxtbox.Location = new System.Drawing.Point(348, 34);
            this.num_of_packagesTxtbox.Name = "num_of_packagesTxtbox";
            this.num_of_packagesTxtbox.Size = new System.Drawing.Size(140, 22);
            this.num_of_packagesTxtbox.TabIndex = 0;
            // 
            // num_of_packagesLbl
            // 
            this.num_of_packagesLbl.AutoSize = true;
            this.num_of_packagesLbl.BackColor = System.Drawing.Color.Black;
            this.num_of_packagesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_of_packagesLbl.ForeColor = System.Drawing.Color.Yellow;
            this.num_of_packagesLbl.Location = new System.Drawing.Point(20, 36);
            this.num_of_packagesLbl.Name = "num_of_packagesLbl";
            this.num_of_packagesLbl.Size = new System.Drawing.Size(322, 18);
            this.num_of_packagesLbl.TabIndex = 1;
            this.num_of_packagesLbl.Text = "Enter the number of packages purchased:";
            // 
            // total_calcValueLbl
            // 
            this.total_calcValueLbl.BackColor = System.Drawing.Color.SteelBlue;
            this.total_calcValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_calcValueLbl.ForeColor = System.Drawing.Color.Yellow;
            this.total_calcValueLbl.Location = new System.Drawing.Point(92, 253);
            this.total_calcValueLbl.Name = "total_calcValueLbl";
            this.total_calcValueLbl.Size = new System.Drawing.Size(406, 66);
            this.total_calcValueLbl.TabIndex = 3;
            this.total_calcValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total_calcValueLbl.Visible = false;
            // 
            // youPayLbl
            // 
            this.youPayLbl.AutoSize = true;
            this.youPayLbl.BackColor = System.Drawing.Color.Black;
            this.youPayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youPayLbl.ForeColor = System.Drawing.Color.Yellow;
            this.youPayLbl.Location = new System.Drawing.Point(12, 276);
            this.youPayLbl.Name = "youPayLbl";
            this.youPayLbl.Size = new System.Drawing.Size(73, 18);
            this.youPayLbl.TabIndex = 3;
            this.youPayLbl.Text = "You pay:";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Black;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.exitBtn.FlatAppearance.BorderSize = 2;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Yellow;
            this.exitBtn.Location = new System.Drawing.Point(317, 336);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(104, 50);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // calc_purchaseBtn
            // 
            this.calc_purchaseBtn.BackColor = System.Drawing.Color.Black;
            this.calc_purchaseBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.calc_purchaseBtn.FlatAppearance.BorderSize = 2;
            this.calc_purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc_purchaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_purchaseBtn.ForeColor = System.Drawing.Color.Yellow;
            this.calc_purchaseBtn.Location = new System.Drawing.Point(223, 82);
            this.calc_purchaseBtn.Name = "calc_purchaseBtn";
            this.calc_purchaseBtn.Size = new System.Drawing.Size(119, 55);
            this.calc_purchaseBtn.TabIndex = 1;
            this.calc_purchaseBtn.Text = "Calculate My Purchase";
            this.calc_purchaseBtn.UseVisualStyleBackColor = false;
            this.calc_purchaseBtn.Click += new System.EventHandler(this.calc_purchaseBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Black;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.clearBtn.FlatAppearance.BorderSize = 2;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Yellow;
            this.clearBtn.Location = new System.Drawing.Point(126, 336);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(104, 50);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // originalPriceLbl
            // 
            this.originalPriceLbl.AutoSize = true;
            this.originalPriceLbl.BackColor = System.Drawing.Color.Black;
            this.originalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPriceLbl.ForeColor = System.Drawing.Color.Yellow;
            this.originalPriceLbl.Location = new System.Drawing.Point(20, 168);
            this.originalPriceLbl.Name = "originalPriceLbl";
            this.originalPriceLbl.Size = new System.Drawing.Size(115, 18);
            this.originalPriceLbl.TabIndex = 7;
            this.originalPriceLbl.Text = "Original Price:";
            // 
            // original_price_outputLbl
            // 
            this.original_price_outputLbl.BackColor = System.Drawing.Color.SteelBlue;
            this.original_price_outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.original_price_outputLbl.ForeColor = System.Drawing.Color.Yellow;
            this.original_price_outputLbl.Location = new System.Drawing.Point(143, 168);
            this.original_price_outputLbl.Name = "original_price_outputLbl";
            this.original_price_outputLbl.Size = new System.Drawing.Size(159, 33);
            this.original_price_outputLbl.TabIndex = 2;
            this.original_price_outputLbl.Visible = false;
            // 
            // SoftwarePackagePriceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Software_Package_Price_Calculator.Properties.Resources.software_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 424);
            this.Controls.Add(this.original_price_outputLbl);
            this.Controls.Add(this.originalPriceLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calc_purchaseBtn);
            this.Controls.Add(this.youPayLbl);
            this.Controls.Add(this.total_calcValueLbl);
            this.Controls.Add(this.num_of_packagesLbl);
            this.Controls.Add(this.num_of_packagesTxtbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoftwarePackagePriceCalc";
            this.Text = "Kyle\'s Software Package Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_of_packagesTxtbox;
        private System.Windows.Forms.Label num_of_packagesLbl;
        private System.Windows.Forms.Label total_calcValueLbl;
        private System.Windows.Forms.Label youPayLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button calc_purchaseBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label originalPriceLbl;
        private System.Windows.Forms.Label original_price_outputLbl;
    }
}

