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
            this.tableLayoutTop = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.comboBoxEngineType = new System.Windows.Forms.ComboBox();
            this.textBoxEnginePower = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxEngineCapacity = new System.Windows.Forms.TextBox();
            this.tableLayoutResult = new System.Windows.Forms.TableLayoutPanel();
            this.labelFeeRecycleResult = new System.Windows.Forms.Label();
            this.labelSecondaryFeeResult = new System.Windows.Forms.Label();
            this.labelTaxResult = new System.Windows.Forms.Label();
            this.labelMainName = new System.Windows.Forms.Label();
            this.buttonCalulate = new System.Windows.Forms.Button();
            this.tableLayoutMid = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEng1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.tableLayoutLegal = new System.Windows.Forms.TableLayoutPanel();
            this.labelExcise = new System.Windows.Forms.Label();
            this.labelNDS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBottomLine = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelExciseResult = new System.Windows.Forms.Label();
            this.labelNDSResult = new System.Windows.Forms.Label();
            this.labelFinalResult = new System.Windows.Forms.Label();
            this.tableLayoutTop.SuspendLayout();
            this.tableLayoutResult.SuspendLayout();
            this.tableLayoutMid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutLegal.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBar
            // 
            this.labelBar.AutoSize = true;
            this.labelBar.Location = new System.Drawing.Point(-46, 54);
            this.labelBar.Name = "labelBar";
            this.labelBar.Size = new System.Drawing.Size(757, 13);
            this.labelBar.TabIndex = 0;
            this.labelBar.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-46, 294);
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
            this.labelPerson.Location = new System.Drawing.Point(8, 12);
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
            this.labelAutoAge.Location = new System.Drawing.Point(8, 52);
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
            this.labelEngineType.Location = new System.Drawing.Point(8, 92);
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
            this.labelEnginePower.Location = new System.Drawing.Point(8, 12);
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
            this.labelEngineSize.Location = new System.Drawing.Point(8, 52);
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
            this.labelAutoPrice.Location = new System.Drawing.Point(8, 12);
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
            this.labelSecondaryFee.Location = new System.Drawing.Point(8, 52);
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
            this.labelTax.Location = new System.Drawing.Point(8, 12);
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
            this.labelFeeRecycle.Location = new System.Drawing.Point(8, 92);
            this.labelFeeRecycle.Name = "labelFeeRecycle";
            this.labelFeeRecycle.Size = new System.Drawing.Size(158, 16);
            this.labelFeeRecycle.TabIndex = 11;
            this.labelFeeRecycle.Text = "Утилизационный сбор:";
            // 
            // tableLayoutTop
            // 
            this.tableLayoutTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.tableLayoutTop.ColumnCount = 2;
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTop.Controls.Add(this.comboBoxAge, 1, 1);
            this.tableLayoutTop.Controls.Add(this.labelAutoAge, 0, 1);
            this.tableLayoutTop.Controls.Add(this.labelEngineType, 0, 2);
            this.tableLayoutTop.Controls.Add(this.labelPerson, 0, 0);
            this.tableLayoutTop.Controls.Add(this.comboBoxPerson, 1, 0);
            this.tableLayoutTop.Controls.Add(this.comboBoxEngineType, 1, 2);
            this.tableLayoutTop.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutTop.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutTop.Name = "tableLayoutTop";
            this.tableLayoutTop.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutTop.RowCount = 3;
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutTop.Size = new System.Drawing.Size(403, 120);
            this.tableLayoutTop.TabIndex = 12;
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
            this.comboBoxAge.Location = new System.Drawing.Point(178, 48);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(153, 24);
            this.comboBoxAge.TabIndex = 2;
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
            this.comboBoxPerson.Location = new System.Drawing.Point(178, 8);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(153, 24);
            this.comboBoxPerson.TabIndex = 1;
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
            "Бензиновый",
            "Дизельный"});
            this.comboBoxEngineType.Location = new System.Drawing.Point(178, 88);
            this.comboBoxEngineType.Name = "comboBoxEngineType";
            this.comboBoxEngineType.Size = new System.Drawing.Size(153, 24);
            this.comboBoxEngineType.TabIndex = 3;
            // 
            // textBoxEnginePower
            // 
            this.textBoxEnginePower.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEnginePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnginePower.Location = new System.Drawing.Point(177, 9);
            this.textBoxEnginePower.MaxLength = 4;
            this.textBoxEnginePower.Name = "textBoxEnginePower";
            this.textBoxEnginePower.Size = new System.Drawing.Size(46, 22);
            this.textBoxEnginePower.TabIndex = 4;
            this.textBoxEnginePower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnginePower_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(177, 9);
            this.textBoxPrice.MaxLength = 9;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(86, 22);
            this.textBoxPrice.TabIndex = 6;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxEngineCapacity
            // 
            this.textBoxEngineCapacity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEngineCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEngineCapacity.Location = new System.Drawing.Point(177, 49);
            this.textBoxEngineCapacity.MaxLength = 4;
            this.textBoxEngineCapacity.Name = "textBoxEngineCapacity";
            this.textBoxEngineCapacity.Size = new System.Drawing.Size(46, 22);
            this.textBoxEngineCapacity.TabIndex = 5;
            this.textBoxEngineCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEngineCapacity_KeyPress);
            // 
            // tableLayoutResult
            // 
            this.tableLayoutResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.tableLayoutResult.ColumnCount = 2;
            this.tableLayoutResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutResult.Controls.Add(this.labelFeeRecycleResult, 1, 2);
            this.tableLayoutResult.Controls.Add(this.labelSecondaryFeeResult, 1, 1);
            this.tableLayoutResult.Controls.Add(this.labelTaxResult, 1, 0);
            this.tableLayoutResult.Controls.Add(this.labelTax, 0, 0);
            this.tableLayoutResult.Controls.Add(this.labelSecondaryFee, 0, 1);
            this.tableLayoutResult.Controls.Add(this.labelFeeRecycle, 0, 2);
            this.tableLayoutResult.Location = new System.Drawing.Point(0, 307);
            this.tableLayoutResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutResult.Name = "tableLayoutResult";
            this.tableLayoutResult.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutResult.RowCount = 3;
            this.tableLayoutResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutResult.Size = new System.Drawing.Size(403, 120);
            this.tableLayoutResult.TabIndex = 13;
            // 
            // labelFeeRecycleResult
            // 
            this.labelFeeRecycleResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFeeRecycleResult.AutoSize = true;
            this.labelFeeRecycleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFeeRecycleResult.Location = new System.Drawing.Point(175, 92);
            this.labelFeeRecycleResult.Name = "labelFeeRecycleResult";
            this.labelFeeRecycleResult.Size = new System.Drawing.Size(0, 16);
            this.labelFeeRecycleResult.TabIndex = 14;
            // 
            // labelSecondaryFeeResult
            // 
            this.labelSecondaryFeeResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSecondaryFeeResult.AutoSize = true;
            this.labelSecondaryFeeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondaryFeeResult.Location = new System.Drawing.Point(175, 52);
            this.labelSecondaryFeeResult.Name = "labelSecondaryFeeResult";
            this.labelSecondaryFeeResult.Size = new System.Drawing.Size(0, 16);
            this.labelSecondaryFeeResult.TabIndex = 13;
            // 
            // labelTaxResult
            // 
            this.labelTaxResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTaxResult.AutoSize = true;
            this.labelTaxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaxResult.Location = new System.Drawing.Point(175, 12);
            this.labelTaxResult.Name = "labelTaxResult";
            this.labelTaxResult.Size = new System.Drawing.Size(0, 16);
            this.labelTaxResult.TabIndex = 12;
            // 
            // labelMainName
            // 
            this.labelMainName.AutoSize = true;
            this.labelMainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.labelMainName.Location = new System.Drawing.Point(7, 24);
            this.labelMainName.Name = "labelMainName";
            this.labelMainName.Size = new System.Drawing.Size(385, 20);
            this.labelMainName.TabIndex = 12;
            this.labelMainName.Text = "Калькулятор растаможивания автомобилей";
            // 
            // buttonCalulate
            // 
            this.buttonCalulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalulate.Location = new System.Drawing.Point(11, 557);
            this.buttonCalulate.Name = "buttonCalulate";
            this.buttonCalulate.Size = new System.Drawing.Size(362, 38);
            this.buttonCalulate.TabIndex = 7;
            this.buttonCalulate.Text = "Рассчитать";
            this.buttonCalulate.UseVisualStyleBackColor = true;
            this.buttonCalulate.Click += new System.EventHandler(this.buttonCalulate_Click);
            // 
            // tableLayoutMid
            // 
            this.tableLayoutMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.tableLayoutMid.ColumnCount = 3;
            this.tableLayoutMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutMid.Controls.Add(this.label3, 2, 1);
            this.tableLayoutMid.Controls.Add(this.labelEnginePower, 0, 0);
            this.tableLayoutMid.Controls.Add(this.textBoxEnginePower, 1, 0);
            this.tableLayoutMid.Controls.Add(this.labelEngineSize, 0, 1);
            this.tableLayoutMid.Controls.Add(this.textBoxEngineCapacity, 1, 1);
            this.tableLayoutMid.Controls.Add(this.labelEng1, 2, 0);
            this.tableLayoutMid.Location = new System.Drawing.Point(0, 187);
            this.tableLayoutMid.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutMid.Name = "tableLayoutMid";
            this.tableLayoutMid.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutMid.RowCount = 2;
            this.tableLayoutMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMid.Size = new System.Drawing.Size(403, 80);
            this.tableLayoutMid.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(242, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "см2";
            // 
            // labelEng1
            // 
            this.labelEng1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEng1.AutoSize = true;
            this.labelEng1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEng1.Location = new System.Drawing.Point(242, 12);
            this.labelEng1.Name = "labelEng1";
            this.labelEng1.Size = new System.Drawing.Size(29, 16);
            this.labelEng1.TabIndex = 21;
            this.labelEng1.Text = "л.с.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAutoPrice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPrice, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 266);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 40);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(282, 12);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 16);
            this.labelPrice.TabIndex = 23;
            this.labelPrice.Text = "руб.";
            // 
            // tableLayoutLegal
            // 
            this.tableLayoutLegal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.tableLayoutLegal.ColumnCount = 2;
            this.tableLayoutLegal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutLegal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutLegal.Controls.Add(this.labelNDSResult, 1, 1);
            this.tableLayoutLegal.Controls.Add(this.labelExcise, 0, 0);
            this.tableLayoutLegal.Controls.Add(this.labelNDS, 0, 1);
            this.tableLayoutLegal.Controls.Add(this.labelExciseResult, 1, 0);
            this.tableLayoutLegal.Location = new System.Drawing.Point(0, 428);
            this.tableLayoutLegal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutLegal.Name = "tableLayoutLegal";
            this.tableLayoutLegal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutLegal.RowCount = 2;
            this.tableLayoutLegal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutLegal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutLegal.Size = new System.Drawing.Size(403, 80);
            this.tableLayoutLegal.TabIndex = 15;
            // 
            // labelExcise
            // 
            this.labelExcise.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExcise.AutoSize = true;
            this.labelExcise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExcise.Location = new System.Drawing.Point(8, 12);
            this.labelExcise.Name = "labelExcise";
            this.labelExcise.Size = new System.Drawing.Size(51, 16);
            this.labelExcise.TabIndex = 10;
            this.labelExcise.Text = "Акциз:";
            // 
            // labelNDS
            // 
            this.labelNDS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNDS.AutoSize = true;
            this.labelNDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNDS.Location = new System.Drawing.Point(8, 52);
            this.labelNDS.Name = "labelNDS";
            this.labelNDS.Size = new System.Drawing.Size(39, 16);
            this.labelNDS.TabIndex = 9;
            this.labelNDS.Text = "НДС:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-21, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // labelBottomLine
            // 
            this.labelBottomLine.AutoSize = true;
            this.labelBottomLine.Location = new System.Drawing.Point(-201, 496);
            this.labelBottomLine.Name = "labelBottomLine";
            this.labelBottomLine.Size = new System.Drawing.Size(757, 13);
            this.labelBottomLine.TabIndex = 22;
            this.labelBottomLine.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(40, 10);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(97, 20);
            this.labelResult.TabIndex = 23;
            this.labelResult.Text = "Результат: ";
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBottom.Controls.Add(this.labelResult, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.labelFinalResult, 1, 0);
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 509);
            this.tableLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(403, 40);
            this.tableLayoutPanelBottom.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-201, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(757, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // labelExciseResult
            // 
            this.labelExciseResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExciseResult.AutoSize = true;
            this.labelExciseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExciseResult.Location = new System.Drawing.Point(87, 12);
            this.labelExciseResult.Name = "labelExciseResult";
            this.labelExciseResult.Size = new System.Drawing.Size(0, 16);
            this.labelExciseResult.TabIndex = 11;
            // 
            // labelNDSResult
            // 
            this.labelNDSResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNDSResult.AutoSize = true;
            this.labelNDSResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNDSResult.Location = new System.Drawing.Point(87, 52);
            this.labelNDSResult.Name = "labelNDSResult";
            this.labelNDSResult.Size = new System.Drawing.Size(0, 16);
            this.labelNDSResult.TabIndex = 12;
            // 
            // labelFinalResult
            // 
            this.labelFinalResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFinalResult.AutoSize = true;
            this.labelFinalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalResult.Location = new System.Drawing.Point(175, 12);
            this.labelFinalResult.Name = "labelFinalResult";
            this.labelFinalResult.Size = new System.Drawing.Size(0, 16);
            this.labelFinalResult.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(400, 607);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutLegal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutMid);
            this.Controls.Add(this.tableLayoutTop);
            this.Controls.Add(this.buttonCalulate);
            this.Controls.Add(this.labelMainName);
            this.Controls.Add(this.labelBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBottomLine);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таможенный калькулятор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutTop.ResumeLayout(false);
            this.tableLayoutTop.PerformLayout();
            this.tableLayoutResult.ResumeLayout(false);
            this.tableLayoutResult.PerformLayout();
            this.tableLayoutMid.ResumeLayout(false);
            this.tableLayoutMid.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutLegal.ResumeLayout(false);
            this.tableLayoutLegal.PerformLayout();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBar;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutResult;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutMid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEng1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLegal;
        private System.Windows.Forms.Label labelExcise;
        private System.Windows.Forms.Label labelNDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBottomLine;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNDSResult;
        private System.Windows.Forms.Label labelExciseResult;
        private System.Windows.Forms.Label labelFinalResult;
    }
}

