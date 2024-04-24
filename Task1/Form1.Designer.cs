namespace Task1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            buttonSort = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxMaxPrice = new TextBox();
            textBoxMinArea = new TextBox();
            textBoxCity = new TextBox();
            textBoxDistrict = new TextBox();
            textBoxYearBuilt = new TextBox();
            textBoxMinRoomsCount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1080, 363);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Area";
            Column1.HeaderText = "Площадь";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Rooms";
            Column2.HeaderText = "Количесвто комнат";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Options";
            Column3.HeaderText = "Комнаты";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "YearBuilt";
            Column4.HeaderText = "Год постройки";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MaterialType";
            Column5.HeaderText = "Тип материала";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Floor";
            Column6.HeaderText = "Этаж";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Price";
            Column7.HeaderText = "Цена";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Address";
            Column8.HeaderText = "Адресс";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(357, 194);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(94, 29);
            buttonSort.TabIndex = 1;
            buttonSort.Text = "Искать";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 389);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Квартиры";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(buttonSort);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxMaxPrice);
            groupBox2.Controls.Add(textBoxMinArea);
            groupBox2.Controls.Add(textBoxCity);
            groupBox2.Controls.Add(textBoxDistrict);
            groupBox2.Controls.Add(textBoxYearBuilt);
            groupBox2.Controls.Add(textBoxMinRoomsCount);
            groupBox2.Location = new Point(12, 407);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(828, 246);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск по:";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(735, 151);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(18, 17);
            checkBox6.TabIndex = 17;
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(357, 151);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(18, 17);
            checkBox5.TabIndex = 16;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(735, 91);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 15;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(357, 95);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 14;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(735, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 13;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(357, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 12;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 151);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 11;
            label6.Text = "Максимальная цена:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 151);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 10;
            label5.Text = "Минимальная площадь:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 91);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Город:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 95);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 8;
            label3.Text = "Район:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 45);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 7;
            label2.Text = "Построена с:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 45);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 6;
            label1.Text = "Минимум комнат:";
            // 
            // textBoxMaxPrice
            // 
            textBoxMaxPrice.Location = new Point(575, 148);
            textBoxMaxPrice.Name = "textBoxMaxPrice";
            textBoxMaxPrice.Size = new Size(125, 27);
            textBoxMaxPrice.TabIndex = 5;
            // 
            // textBoxMinArea
            // 
            textBoxMinArea.Location = new Point(197, 148);
            textBoxMinArea.Name = "textBoxMinArea";
            textBoxMinArea.Size = new Size(125, 27);
            textBoxMinArea.TabIndex = 4;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(575, 88);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 3;
            // 
            // textBoxDistrict
            // 
            textBoxDistrict.Location = new Point(197, 92);
            textBoxDistrict.Name = "textBoxDistrict";
            textBoxDistrict.Size = new Size(125, 27);
            textBoxDistrict.TabIndex = 2;
            // 
            // textBoxYearBuilt
            // 
            textBoxYearBuilt.Location = new Point(575, 42);
            textBoxYearBuilt.Name = "textBoxYearBuilt";
            textBoxYearBuilt.Size = new Size(125, 27);
            textBoxYearBuilt.TabIndex = 1;
            // 
            // textBoxMinRoomsCount
            // 
            textBoxMinRoomsCount.Location = new Point(197, 42);
            textBoxMinRoomsCount.Name = "textBoxMinRoomsCount";
            textBoxMinRoomsCount.Size = new Size(125, 27);
            textBoxMinRoomsCount.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 668);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private BindingSource bindingSource1;
        private Button buttonSort;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxMaxPrice;
        private TextBox textBoxMinArea;
        private TextBox textBoxCity;
        private TextBox textBoxDistrict;
        private TextBox textBoxYearBuilt;
        private TextBox textBoxMinRoomsCount;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
