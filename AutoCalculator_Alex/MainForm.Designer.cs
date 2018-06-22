namespace AutoCalculator_Alex
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPerson = new System.Windows.Forms.Label();
            this.labelAutoAge = new System.Windows.Forms.Label();
            this.labelEngineType = new System.Windows.Forms.Label();
            this.labelEnginePower = new System.Windows.Forms.Label();
            this.labelEngineSize = new System.Windows.Forms.Label();
            this.labelAutoPrice = new System.Windows.Forms.Label();
            this.labelSecondaryFee = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelFeeRecycle = new System.Windows.Forms.Label();
            this.tableLayoutInput = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxEnginePower = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.comboBoxEngineType = new System.Windows.Forms.ComboBox();
            this.textBoxEngineCapacity = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFeeRecycleResult = new System.Windows.Forms.Label();
            this.labelSecondaryFeeResult = new System.Windows.Forms.Label();
            this.labelTaxResult = new System.Windows.Forms.Label();
            this.labelMainName = new System.Windows.Forms.Label();
            this.buttonCalulate = new System.Windows.Forms.Button();
            this.tableLayoutInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBar
            // 
            this.labelBar.AutoSize = true;
            this.labelBar.Location = new System.Drawing.Point(-43, 62);
            this.labelBar.Name = "labelBar";
            this.labelBar.Size = new System.Drawing.Size(757, 13);
            this.labelBar.TabIndex = 0;
            this.labelBar.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-15, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-64, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(757, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // labelPerson
            // 
            this.labelPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPerson.AutoSize = true;
            this.labelPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerson.Location = new System.Drawing.Point(3, 13);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(141, 16);
            this.labelPerson.TabIndex = 3;
            this.labelPerson.Text = "Автомобиль ввозит:";
            // 
            // labelAutoAge
            // 
            this.labelAutoAge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAutoAge.AutoSize = true;
            this.labelAutoAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoAge.Location = new System.Drawing.Point(3, 56);
            this.labelAutoAge.Name = "labelAutoAge";
            this.labelAutoAge.Size = new System.Drawing.Size(148, 16);
            this.labelAutoAge.TabIndex = 4;
            this.labelAutoAge.Text = "Возраст автомобиля:";
            // 
            // labelEngineType
            // 
            this.labelEngineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEngineType.AutoSize = true;
            this.labelEngineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEngineType.Location = new System.Drawing.Point(3, 99);
            this.labelEngineType.Name = "labelEngineType";
            this.labelEngineType.Size = new System.Drawing.Size(107, 16);
            this.labelEngineType.TabIndex = 5;
            this.labelEngineType.Text = "Тип двигателя:";
            // 
            // labelEnginePower
            // 
            this.labelEnginePower.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEnginePower.AutoSize = true;
            this.labelEnginePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnginePower.Location = new System.Drawing.Point(3, 142);
            this.labelEnginePower.Name = "labelEnginePower";
            this.labelEnginePower.Size = new System.Drawing.Size(147, 16);
            this.labelEnginePower.TabIndex = 6;
            this.labelEnginePower.Text = "Мощность двигателя:";
            // 
            // labelEngineSize
            // 
            this.labelEngineSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEngineSize.AutoSize = true;
            this.labelEngineSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEngineSize.Location = new System.Drawing.Point(3, 185);
            this.labelEngineSize.Name = "labelEngineSize";
            this.labelEngineSize.Size = new System.Drawing.Size(126, 16);
            this.labelEngineSize.TabIndex = 7;
            this.labelEngineSize.Text = "Объём двигателя:";
            // 
            // labelAutoPrice
            // 
            this.labelAutoPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAutoPrice.AutoSize = true;
            this.labelAutoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoPrice.Location = new System.Drawing.Point(3, 229);
            this.labelAutoPrice.Name = "labelAutoPrice";
            this.labelAutoPrice.Size = new System.Drawing.Size(163, 16);
            this.labelAutoPrice.TabIndex = 8;
            this.labelAutoPrice.Text = "Стоимость автомобиля:";
            // 
            // labelSecondaryFee
            // 
            this.labelSecondaryFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSecondaryFee.AutoSize = true;
            this.labelSecondaryFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondaryFee.Location = new System.Drawing.Point(3, 52);
            this.labelSecondaryFee.Name = "labelSecondaryFee";
            this.labelSecondaryFee.Size = new System.Drawing.Size(150, 16);
            this.labelSecondaryFee.TabIndex = 9;
            this.labelSecondaryFee.Text = "Сбор за оформление:";
            // 
            // labelTax
            // 
            this.labelTax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTax.Location = new System.Drawing.Point(3, 12);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(153, 16);
            this.labelTax.TabIndex = 10;
            this.labelTax.Text = "Таможенная пошлина:";
            // 
            // labelFeeRecycle
            // 
            this.labelFeeRecycle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFeeRecycle.AutoSize = true;
            this.labelFeeRecycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFeeRecycle.Location = new System.Drawing.Point(3, 92);
            this.labelFeeRecycle.Name = "labelFeeRecycle";
            this.labelFeeRecycle.Size = new System.Drawing.Size(158, 16);
            this.labelFeeRecycle.TabIndex = 11;
            this.labelFeeRecycle.Text = "Утилизационный сбор:";
            // 
            // tableLayoutInput
            // 
            this.tableLayoutInput.ColumnCount = 2;
            this.tableLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInput.Controls.Add(this.textBoxEnginePower, 1, 3);
            this.tableLayoutInput.Controls.Add(this.textBoxPrice, 1, 5);
            this.tableLayoutInput.Controls.Add(this.comboBoxAge, 1, 1);
            this.tableLayoutInput.Controls.Add(this.labelAutoAge, 0, 1);
            this.tableLayoutInput.Controls.Add(this.labelEngineType, 0, 2);
            this.tableLayoutInput.Controls.Add(this.labelEnginePower, 0, 3);
            this.tableLayoutInput.Controls.Add(this.labelPerson, 0, 0);
            this.tableLayoutInput.Controls.Add(this.labelAutoPrice, 0, 5);
            this.tableLayoutInput.Controls.Add(this.labelEngineSize, 0, 4);
            this.tableLayoutInput.Controls.Add(this.comboBoxPerson, 1, 0);
            this.tableLayoutInput.Controls.Add(this.comboBoxEngineType, 1, 2);
            this.tableLayoutInput.Controls.Add(this.textBoxEngineCapacity, 1, 4);
            this.tableLayoutInput.Location = new System.Drawing.Point(17, 72);
            this.tableLayoutInput.Name = "tableLayoutInput";
            this.tableLayoutInput.RowCount = 6;
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutInput.Size = new System.Drawing.Size(339, 260);
            this.tableLayoutInput.TabIndex = 12;
            // 
            // textBoxEnginePower
            // 
            this.textBoxEnginePower.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEnginePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnginePower.Location = new System.Drawing.Point(172, 139);
            this.textBoxEnginePower.MaxLength = 4;
            this.textBoxEnginePower.Name = "textBoxEnginePower";
            this.textBoxEnginePower.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnginePower.TabIndex = 20;
            this.textBoxEnginePower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnginePower_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(172, 226);
            this.textBoxPrice.MaxLength = 10;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 19;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.ItemHeight = 16;
            this.comboBoxAge.Items.AddRange(new object[] {
            "До 3 лет",
            "От 3 до 5 лет",
            "От 5 до 7 лет"});
            this.comboBoxAge.Location = new System.Drawing.Point(172, 52);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(153, 24);
            this.comboBoxAge.TabIndex = 15;
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.ItemHeight = 16;
            this.comboBoxPerson.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
            this.comboBoxPerson.Location = new System.Drawing.Point(172, 9);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(153, 24);
            this.comboBoxPerson.TabIndex = 14;
            // 
            // comboBoxEngineType
            // 
            this.comboBoxEngineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEngineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEngineType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEngineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEngineType.FormattingEnabled = true;
            this.comboBoxEngineType.ItemHeight = 16;
            this.comboBoxEngineType.Items.AddRange(new object[] {
            "Бензиновый"});
            this.comboBoxEngineType.Location = new System.Drawing.Point(172, 95);
            this.comboBoxEngineType.Name = "comboBoxEngineType";
            this.comboBoxEngineType.Size = new System.Drawing.Size(153, 24);
            this.comboBoxEngineType.TabIndex = 16;
            // 
            // textBoxEngineCapacity
            // 
            this.textBoxEngineCapacity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEngineCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEngineCapacity.Location = new System.Drawing.Point(172, 182);
            this.textBoxEngineCapacity.MaxLength = 4;
            this.textBoxEngineCapacity.Name = "textBoxEngineCapacity";
            this.textBoxEngineCapacity.Size = new System.Drawing.Size(100, 22);
            this.textBoxEngineCapacity.TabIndex = 18;
            this.textBoxEngineCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEngineCapacity_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelFeeRecycleResult, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSecondaryFeeResult, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTaxResult, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTax, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSecondaryFee, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFeeRecycle, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 339);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 121);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // labelFeeRecycleResult
            // 
            this.labelFeeRecycleResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFeeRecycleResult.AutoSize = true;
            this.labelFeeRecycleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFeeRecycleResult.Location = new System.Drawing.Point(172, 92);
            this.labelFeeRecycleResult.Name = "labelFeeRecycleResult";
            this.labelFeeRecycleResult.Size = new System.Drawing.Size(0, 16);
            this.labelFeeRecycleResult.TabIndex = 14;
            // 
            // labelSecondaryFeeResult
            // 
            this.labelSecondaryFeeResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSecondaryFeeResult.AutoSize = true;
            this.labelSecondaryFeeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondaryFeeResult.Location = new System.Drawing.Point(172, 52);
            this.labelSecondaryFeeResult.Name = "labelSecondaryFeeResult";
            this.labelSecondaryFeeResult.Size = new System.Drawing.Size(0, 16);
            this.labelSecondaryFeeResult.TabIndex = 13;
            // 
            // labelTaxResult
            // 
            this.labelTaxResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTaxResult.AutoSize = true;
            this.labelTaxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaxResult.Location = new System.Drawing.Point(172, 12);
            this.labelTaxResult.Name = "labelTaxResult";
            this.labelTaxResult.Size = new System.Drawing.Size(0, 16);
            this.labelTaxResult.TabIndex = 12;
            // 
            // labelMainName
            // 
            this.labelMainName.AutoSize = true;
            this.labelMainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainName.Location = new System.Drawing.Point(12, 27);
            this.labelMainName.Name = "labelMainName";
            this.labelMainName.Size = new System.Drawing.Size(362, 24);
            this.labelMainName.TabIndex = 12;
            this.labelMainName.Text = "Калькулятор растаможки автомобилей";
            // 
            // buttonCalulate
            // 
            this.buttonCalulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalulate.Location = new System.Drawing.Point(12, 489);
            this.buttonCalulate.Name = "buttonCalulate";
            this.buttonCalulate.Size = new System.Drawing.Size(362, 38);
            this.buttonCalulate.TabIndex = 14;
            this.buttonCalulate.Text = "Рассчитать";
            this.buttonCalulate.UseVisualStyleBackColor = true;
            this.buttonCalulate.Click += new System.EventHandler(this.buttonCalulate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 541);
            this.Controls.Add(this.buttonCalulate);
            this.Controls.Add(this.labelMainName);
            this.Controls.Add(this.labelBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таможенный калькулятор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutInput.ResumeLayout(false);
            this.tableLayoutInput.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.Label labelAutoAge;
        private System.Windows.Forms.Label labelEngineType;
        private System.Windows.Forms.Label labelEnginePower;
        private System.Windows.Forms.Label labelEngineSize;
        private System.Windows.Forms.Label labelAutoPrice;
        private System.Windows.Forms.Label labelSecondaryFee;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelFeeRecycle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.ComboBox comboBoxEngineType;
        private System.Windows.Forms.TextBox textBoxEngineCapacity;
        private System.Windows.Forms.TextBox textBoxEnginePower;
        private System.Windows.Forms.Label labelMainName;
        private System.Windows.Forms.Button buttonCalulate;
        private System.Windows.Forms.Label labelFeeRecycleResult;
        private System.Windows.Forms.Label labelSecondaryFeeResult;
        private System.Windows.Forms.Label labelTaxResult;
    }
}

