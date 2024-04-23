namespace SearchAR
{
    partial class Form2
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
            System.Windows.Forms.Label номер_АктаLabel;
            System.Windows.Forms.Label факультетLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label тип_документаLabel;
            System.Windows.Forms.Label сотрудникиLabel;
            System.Windows.Forms.Label дата_приемаLabel;
            System.Windows.Forms.Label срок_храненияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BasicData = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.searcharDataSet1 = new SearchAR.searcharDataSet1();
            this.документыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документыTableAdapter = new SearchAR.searcharDataSet1TableAdapters.ДокументыTableAdapter();
            this.tableAdapterManager = new SearchAR.searcharDataSet1TableAdapters.TableAdapterManager();
            this.номер_АктаTextBox = new System.Windows.Forms.TextBox();
            this.факультетTextBox = new System.Windows.Forms.TextBox();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.тип_документаTextBox = new System.Windows.Forms.TextBox();
            this.сотрудникиTextBox = new System.Windows.Forms.TextBox();
            this.дата_приемаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.срок_храненияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            номер_АктаLabel = new System.Windows.Forms.Label();
            факультетLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            тип_документаLabel = new System.Windows.Forms.Label();
            сотрудникиLabel = new System.Windows.Forms.Label();
            дата_приемаLabel = new System.Windows.Forms.Label();
            срок_храненияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searcharDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_АктаLabel
            // 
            номер_АктаLabel.AutoSize = true;
            номер_АктаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_АктаLabel.Location = new System.Drawing.Point(27, 94);
            номер_АктаLabel.Name = "номер_АктаLabel";
            номер_АктаLabel.Size = new System.Drawing.Size(104, 20);
            номер_АктаLabel.TabIndex = 46;
            номер_АктаLabel.Text = "Номер Акта:";
            // 
            // факультетLabel
            // 
            факультетLabel.AutoSize = true;
            факультетLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            факультетLabel.Location = new System.Drawing.Point(27, 134);
            факультетLabel.Name = "факультетLabel";
            факультетLabel.Size = new System.Drawing.Size(98, 20);
            факультетLabel.TabIndex = 47;
            факультетLabel.Text = "Факультет:";
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            группаLabel.Location = new System.Drawing.Point(27, 171);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(65, 20);
            группаLabel.TabIndex = 48;
            группаLabel.Text = "Группа:";
            // 
            // тип_документаLabel
            // 
            тип_документаLabel.AutoSize = true;
            тип_документаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            тип_документаLabel.Location = new System.Drawing.Point(27, 210);
            тип_документаLabel.Name = "тип_документаLabel";
            тип_документаLabel.Size = new System.Drawing.Size(126, 20);
            тип_документаLabel.TabIndex = 49;
            тип_документаLabel.Text = "Тип документа:";
            // 
            // сотрудникиLabel
            // 
            сотрудникиLabel.AutoSize = true;
            сотрудникиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            сотрудникиLabel.Location = new System.Drawing.Point(27, 250);
            сотрудникиLabel.Name = "сотрудникиLabel";
            сотрудникиLabel.Size = new System.Drawing.Size(104, 20);
            сотрудникиLabel.TabIndex = 50;
            сотрудникиLabel.Text = "Сотрудники:";
            // 
            // дата_приемаLabel
            // 
            дата_приемаLabel.AutoSize = true;
            дата_приемаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_приемаLabel.Location = new System.Drawing.Point(27, 292);
            дата_приемаLabel.Name = "дата_приемаLabel";
            дата_приемаLabel.Size = new System.Drawing.Size(112, 20);
            дата_приемаLabel.TabIndex = 51;
            дата_приемаLabel.Text = "Дата приема:";
            // 
            // срок_храненияLabel
            // 
            срок_храненияLabel.AutoSize = true;
            срок_храненияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            срок_храненияLabel.Location = new System.Drawing.Point(27, 331);
            срок_храненияLabel.Name = "срок_храненияLabel";
            срок_храненияLabel.Size = new System.Drawing.Size(124, 20);
            срок_храненияLabel.TabIndex = 52;
            срок_храненияLabel.Text = "Срок хранения:";
            // 
            // BasicData
            // 
            this.BasicData.AutoSize = true;
            this.BasicData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasicData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BasicData.Location = new System.Drawing.Point(141, 15);
            this.BasicData.Margin = new System.Windows.Forms.Padding(8, 8, 2, 0);
            this.BasicData.Name = "BasicData";
            this.BasicData.Size = new System.Drawing.Size(311, 24);
            this.BasicData.TabIndex = 34;
            this.BasicData.Text = "Акт о выделении к уничтожению ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(419, 310);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 41);
            this.button5.TabIndex = 45;
            this.button5.Text = "ДОБАВИТЬ ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // searcharDataSet1
            // 
            this.searcharDataSet1.DataSetName = "searcharDataSet1";
            this.searcharDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // документыBindingSource
            // 
            this.документыBindingSource.DataMember = "Документы";
            this.документыBindingSource.DataSource = this.searcharDataSet1;
            // 
            // документыTableAdapter
            // 
            this.документыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SearchAR.searcharDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДокументыTableAdapter = this.документыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Сроки_храненияTableAdapter = null;
            this.tableAdapterManager.Тип_документаTableAdapter = null;
            // 
            // номер_АктаTextBox
            // 
            this.номер_АктаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.документыBindingSource, "Номер Акта", true));
            this.номер_АктаTextBox.Location = new System.Drawing.Point(170, 96);
            this.номер_АктаTextBox.Name = "номер_АктаTextBox";
            this.номер_АктаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_АктаTextBox.TabIndex = 47;
            // 
            // факультетTextBox
            // 
            this.факультетTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.документыBindingSource, "Факультет", true));
            this.факультетTextBox.Location = new System.Drawing.Point(170, 136);
            this.факультетTextBox.Name = "факультетTextBox";
            this.факультетTextBox.Size = new System.Drawing.Size(200, 20);
            this.факультетTextBox.TabIndex = 48;
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.документыBindingSource, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(170, 173);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(200, 20);
            this.группаTextBox.TabIndex = 49;
            // 
            // тип_документаTextBox
            // 
            this.тип_документаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.документыBindingSource, "Тип документа", true));
            this.тип_документаTextBox.Location = new System.Drawing.Point(170, 210);
            this.тип_документаTextBox.Name = "тип_документаTextBox";
            this.тип_документаTextBox.Size = new System.Drawing.Size(200, 20);
            this.тип_документаTextBox.TabIndex = 50;
            // 
            // сотрудникиTextBox
            // 
            this.сотрудникиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.документыBindingSource, "Сотрудники", true));
            this.сотрудникиTextBox.Location = new System.Drawing.Point(170, 252);
            this.сотрудникиTextBox.Name = "сотрудникиTextBox";
            this.сотрудникиTextBox.Size = new System.Drawing.Size(200, 20);
            this.сотрудникиTextBox.TabIndex = 51;
            // 
            // дата_приемаDateTimePicker
            // 
            this.дата_приемаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.документыBindingSource, "Дата приема", true));
            this.дата_приемаDateTimePicker.Location = new System.Drawing.Point(170, 292);
            this.дата_приемаDateTimePicker.Name = "дата_приемаDateTimePicker";
            this.дата_приемаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_приемаDateTimePicker.TabIndex = 52;
            // 
            // срок_храненияDateTimePicker
            // 
            this.срок_храненияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.документыBindingSource, "Срок хранения", true));
            this.срок_храненияDateTimePicker.Location = new System.Drawing.Point(170, 331);
            this.срок_храненияDateTimePicker.Name = "срок_храненияDateTimePicker";
            this.срок_храненияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.срок_храненияDateTimePicker.TabIndex = 53;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 369);
            this.Controls.Add(срок_храненияLabel);
            this.Controls.Add(this.срок_храненияDateTimePicker);
            this.Controls.Add(дата_приемаLabel);
            this.Controls.Add(this.дата_приемаDateTimePicker);
            this.Controls.Add(сотрудникиLabel);
            this.Controls.Add(this.сотрудникиTextBox);
            this.Controls.Add(тип_документаLabel);
            this.Controls.Add(this.тип_документаTextBox);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(факультетLabel);
            this.Controls.Add(this.факультетTextBox);
            this.Controls.Add(номер_АктаLabel);
            this.Controls.Add(this.номер_АктаTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BasicData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Акт о выделении к уничтожению ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searcharDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BasicData;
        private System.Windows.Forms.Button button5;
        private searcharDataSet1 searcharDataSet1;
        private System.Windows.Forms.BindingSource документыBindingSource;
        private searcharDataSet1TableAdapters.ДокументыTableAdapter документыTableAdapter;
        private searcharDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номер_АктаTextBox;
        private System.Windows.Forms.TextBox факультетTextBox;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.TextBox тип_документаTextBox;
        private System.Windows.Forms.TextBox сотрудникиTextBox;
        private System.Windows.Forms.DateTimePicker дата_приемаDateTimePicker;
        private System.Windows.Forms.DateTimePicker срок_храненияDateTimePicker;
    }
}