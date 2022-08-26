namespace bibliobook
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
            this.components = new System.ComponentModel.Container();
            this.grbReader = new System.Windows.Forms.GroupBox();
            this.lblKol = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.chkBook = new System.Windows.Forms.CheckBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rdbStatus3 = new System.Windows.Forms.RadioButton();
            this.rdbStatus2 = new System.Windows.Forms.RadioButton();
            this.rdbStatus1 = new System.Windows.Forms.RadioButton();
            this.cmbReader = new System.Windows.Forms.ComboBox();
            this.lblReader = new System.Windows.Forms.Label();
            this.grbInform = new System.Windows.Forms.GroupBox();
            this.lstInform = new System.Windows.Forms.ListBox();
            this.btnInform = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVisibleInform = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grbReader.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.grbInform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbReader
            // 
            this.grbReader.Controls.Add(this.lblKol);
            this.grbReader.Controls.Add(this.lblBooks);
            this.grbReader.Controls.Add(this.lstBooks);
            this.grbReader.Controls.Add(this.txtKol);
            this.grbReader.Controls.Add(this.chkBook);
            this.grbReader.Controls.Add(this.grbStatus);
            this.grbReader.Controls.Add(this.cmbReader);
            this.grbReader.Controls.Add(this.lblReader);
            this.grbReader.Location = new System.Drawing.Point(12, 12);
            this.grbReader.Name = "grbReader";
            this.grbReader.Size = new System.Drawing.Size(348, 258);
            this.grbReader.TabIndex = 0;
            this.grbReader.TabStop = false;
            this.grbReader.Text = "Карточка читателя";
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Location = new System.Drawing.Point(16, 205);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(101, 15);
            this.lblKol.TabIndex = 7;
            this.lblKol.Text = "Количество дней";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(131, 63);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(121, 15);
            this.lblBooks.TabIndex = 6;
            this.lblBooks.Text = "Список книг фондов";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 15;
            this.lstBooks.Items.AddRange(new object[] {
            "Достоевский \"Идиот\"",
            "Куприн \"Сборник рассказов\"",
            "Лермонтов \"Мцыри\"",
            "Толстой \"Война и мир\""});
            this.lstBooks.Location = new System.Drawing.Point(131, 85);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(211, 94);
            this.lstBooks.TabIndex = 5;
            // 
            // txtKol
            // 
            this.txtKol.Location = new System.Drawing.Point(123, 202);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(92, 23);
            this.txtKol.TabIndex = 4;
            // 
            // chkBook
            // 
            this.chkBook.AutoSize = true;
            this.chkBook.Location = new System.Drawing.Point(16, 173);
            this.chkBook.Name = "chkBook";
            this.chkBook.Size = new System.Drawing.Size(109, 19);
            this.chkBook.TabIndex = 3;
            this.chkBook.Text = "Книги на руках";
            this.chkBook.UseVisualStyleBackColor = true;
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rdbStatus3);
            this.grbStatus.Controls.Add(this.rdbStatus2);
            this.grbStatus.Controls.Add(this.rdbStatus1);
            this.grbStatus.Location = new System.Drawing.Point(16, 63);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(101, 95);
            this.grbStatus.TabIndex = 2;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Статус";
            // 
            // rdbStatus3
            // 
            this.rdbStatus3.AutoSize = true;
            this.rdbStatus3.Location = new System.Drawing.Point(6, 70);
            this.rdbStatus3.Name = "rdbStatus3";
            this.rdbStatus3.Size = new System.Drawing.Size(77, 19);
            this.rdbStatus3.TabIndex = 0;
            this.rdbStatus3.TabStop = true;
            this.rdbStatus3.Text = "Работник";
            this.rdbStatus3.UseVisualStyleBackColor = true;
            // 
            // rdbStatus2
            // 
            this.rdbStatus2.AutoSize = true;
            this.rdbStatus2.Location = new System.Drawing.Point(7, 47);
            this.rdbStatus2.Name = "rdbStatus2";
            this.rdbStatus2.Size = new System.Drawing.Size(68, 19);
            this.rdbStatus2.TabIndex = 0;
            this.rdbStatus2.TabStop = true;
            this.rdbStatus2.Text = "Студент";
            this.rdbStatus2.UseVisualStyleBackColor = true;
            // 
            // rdbStatus1
            // 
            this.rdbStatus1.AutoSize = true;
            this.rdbStatus1.Location = new System.Drawing.Point(7, 22);
            this.rdbStatus1.Name = "rdbStatus1";
            this.rdbStatus1.Size = new System.Drawing.Size(82, 19);
            this.rdbStatus1.TabIndex = 0;
            this.rdbStatus1.TabStop = true;
            this.rdbStatus1.Text = "Школьник";
            this.rdbStatus1.UseVisualStyleBackColor = true;
            // 
            // cmbReader
            // 
            this.cmbReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReader.FormattingEnabled = true;
            this.cmbReader.Items.AddRange(new object[] {
            "Арбузов Н.В.",
            "Вылегжанина О.Ю.",
            "Иванов П.Р.",
            "Петров С.Е.",
            "Сидоров А.И."});
            this.cmbReader.Location = new System.Drawing.Point(79, 25);
            this.cmbReader.Name = "cmbReader";
            this.cmbReader.Size = new System.Drawing.Size(263, 23);
            this.cmbReader.Sorted = true;
            this.cmbReader.TabIndex = 1;
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Location = new System.Drawing.Point(16, 28);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(57, 15);
            this.lblReader.TabIndex = 0;
            this.lblReader.Text = "Читатель";
            // 
            // grbInform
            // 
            this.grbInform.Controls.Add(this.lstInform);
            this.grbInform.Location = new System.Drawing.Point(12, 276);
            this.grbInform.Name = "grbInform";
            this.grbInform.Size = new System.Drawing.Size(348, 136);
            this.grbInform.TabIndex = 1;
            this.grbInform.TabStop = false;
            this.grbInform.Text = "Информация";
            // 
            // lstInform
            // 
            this.lstInform.FormattingEnabled = true;
            this.lstInform.ItemHeight = 15;
            this.lstInform.Location = new System.Drawing.Point(6, 22);
            this.lstInform.Name = "lstInform";
            this.lstInform.Size = new System.Drawing.Size(336, 109);
            this.lstInform.TabIndex = 0;
            // 
            // btnInform
            // 
            this.btnInform.Location = new System.Drawing.Point(366, 12);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(149, 23);
            this.btnInform.TabIndex = 2;
            this.btnInform.Text = "Получить информацию";
            this.btnInform.UseVisualStyleBackColor = true;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(366, 41);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить строку";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(366, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVisibleInform
            // 
            this.btnVisibleInform.Enabled = false;
            this.btnVisibleInform.Location = new System.Drawing.Point(366, 105);
            this.btnVisibleInform.Name = "btnVisibleInform";
            this.btnVisibleInform.Size = new System.Drawing.Size(149, 23);
            this.btnVisibleInform.TabIndex = 5;
            this.btnVisibleInform.Text = "Скрыть информацию";
            this.btnVisibleInform.UseVisualStyleBackColor = true;
            this.btnVisibleInform.Click += new System.EventHandler(this.btnVisibleInform_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 417);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVisibleInform);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInform);
            this.Controls.Add(this.grbInform);
            this.Controls.Add(this.grbReader);
            this.Name = "Form1";
            this.Text = "Выдача литературы на дом";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbReader.ResumeLayout(false);
            this.grbReader.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.grbInform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbReader;
        private Label lblKol;
        private Label lblBooks;
        private ListBox lstBooks;
        private TextBox txtKol;
        private CheckBox chkBook;
        private GroupBox grbStatus;
        private RadioButton rdbStatus3;
        private RadioButton rdbStatus2;
        private RadioButton rdbStatus1;
        private ComboBox cmbReader;
        private Label lblReader;
        private GroupBox grbInform;
        private ListBox lstInform;
        private Button btnInform;
        private Button btnRemove;
        private Button btnClear;
        private Button btnVisibleInform;
        private Button btnExit;
        private BindingSource bindingSource1;
    }
}