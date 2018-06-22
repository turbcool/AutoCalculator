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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelMainName = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(-16, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-64, 337);
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
            this.labelSecondaryFee.AutoSize = true;
            this.labelSecondaryFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondaryFee.Location = new System.Drawing.Point(3, 40);
            this.labelSecondaryFee.Name = "labelSecondaryFee";
            this.labelSecondaryFee.Size = new System.Drawing.Size(150, 16);
            this.labelSecondaryFee.TabIndex = 9;
            this.labelSecondaryFee.Text = "Сбор за оформление:";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTax.Location = new System.Drawing.Point(3, 0);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(153, 16);
            this.labelTax.TabIndex = 10;
            this.labelTax.Text = "Таможенная пошлина:";
            // 
            // labelFeeRecycle
            // 
            this.labelFeeRecycle.AutoSize = true;
            this.labelFeeRecycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFeeRecycle.Location = new System.Drawing.Point(3, 80);
            this.labelFeeRecycle.Name = "labelFeeRecycle";
            this.labelFeeRecycle.Size = new System.Drawing.Size(158, 16);
            this.labelFeeRecycle.TabIndex = 11;
            this.labelFeeRecycle.Text = "Утилизационный сбор:";
            // 
            // tableLayoutInput
            // 
            this.tableLayoutInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutInput.ColumnCount = 2;
            this.tableLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInput.Controls.Add(this.textBox3, 1, 3);
            this.tableLayoutInput.Controls.Add(this.textBox2, 1, 5);
            this.tableLayoutInput.Controls.Add(this.comboBox2, 1, 1);
            this.tableLayoutInput.Controls.Add(this.labelAutoAge, 0, 1);
            this.tableLayoutInput.Controls.Add(this.labelEngineType, 0, 2);
            this.tableLayoutInput.Controls.Add(this.labelEnginePower, 0, 3);
            this.tableLayoutInput.Controls.Add(this.labelPerson, 0, 0);
            this.tableLayoutInput.Controls.Add(this.labelAutoPrice, 0, 5);
            this.tableLayoutInput.Controls.Add(this.labelEngineSize, 0, 4);
            this.tableLayoutInput.Controls.Add(this.comboBoxPerson, 1, 0);
            this.tableLayoutInput.Controls.Add(this.comboBox3, 1, 2);
            this.tableLayoutInput.Controls.Add(this.textBox1, 1, 4);
            this.tableLayoutInput.Location = new System.Drawing.Point(17, 78);
            this.tableLayoutInput.Name = "tableLayoutInput";
            this.tableLayoutInput.RowCount = 6;
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutInput.Size = new System.Drawing.Size(362, 260);
            this.tableLayoutInput.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelTax, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSecondaryFee, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFeeRecycle, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 362);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 121);
            this.tableLayoutPanel1.TabIndex = 13;
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
            this.comboBoxPerson.Location = new System.Drawing.Point(184, 10);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(153, 24);
            this.comboBoxPerson.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 16;
            this.comboBox2.Items.AddRange(new object[] {
            "До 3 лет",
            "От 3 до 5 лет",
            "От 5 до 7 лет"});
            this.comboBox2.Location = new System.Drawing.Point(184, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 16;
            this.comboBox3.Items.AddRange(new object[] {
            "Бензиновый"});
            this.comboBox3.Location = new System.Drawing.Point(184, 96);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 24);
            this.comboBox3.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(184, 182);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(184, 226);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(184, 139);
            this.textBox3.MaxLength = 4;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 20;
            // 
            // labelMainName
            // 
            this.labelMainName.AutoSize = true;
            this.labelMainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainName.Location = new System.Drawing.Point(64, 29);
            this.labelMainName.Name = "labelMainName";
            this.labelMainName.Size = new System.Drawing.Size(362, 24);
            this.labelMainName.TabIndex = 12;
            this.labelMainName.Text = "Калькулятор растаможки автомобилей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 576);
            this.Controls.Add(this.labelMainName);
            this.Controls.Add(this.labelBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutInput);
            this.Name = "MainForm";
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelMainName;
    }
}

