namespace bibliobook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbReader.SelectedIndex = 0;        // выделение/первого элемента списка
            lstBooks.SelectedIndex = 0;		// выделение/первого элемента списка

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();					// закрытие приложения
        }

        private void btnVisibleInform_Click(object sender, EventArgs e)
        {
            grbInform.Visible = false;      // рамка «Информация» невидима
            btnRemove.Enabled = false;      // кнопка «Удалить строку» недоступна
            btnClear.Enabled = false;       // кнопка «Очистить» недоступна
            btnVisibleInform.Enabled = false;	// кнопка «Скрыть информацию» недоступна
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstInform.Items.Clear();        // очистка элементов списка
            btnRemove.Enabled = false;      // кнопка «Удалить строку» недоступна
            btnClear.Enabled = false;		// кнопка «Очистить» недоступна
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstInform.Items.Remove(lstInform.Text); // удаление выделенного элемента
            lstInform.SelectedIndex = lstInform.Items.Count - 1; // выделение последнего             элемента

            if (lstInform.Items.Count == 0)
            {// если список пустой, тогда кнопки недоступны
                btnRemove.Enabled = false;
                btnClear.Enabled = false;
            }
        }

        private void btnInform_Click(object sender, EventArgs e)
        {
            grbInform.Visible = true;
            btnRemove.Enabled = true;
            btnClear.Enabled = true;
            btnVisibleInform.Enabled = true;
            lstInform.Items.Clear();
            lstInform.Items.Add(cmbReader.Text);    // добавление нового элемента в список
            if (rdbStatus1.Checked)
                lstInform.Items.Add(rdbStatus1.Text);
            else if (rdbStatus2.Checked)
                lstInform.Items.Add(rdbStatus2.Text);
            else
                lstInform.Items.Add(rdbStatus3.Text);
            if (chkBook.Checked)
                lstInform.Items.Add("Книги на руках");
            lstInform.Items.Add(lstBooks.Text);
            lstInform.Items.Add("Количество дней " + txtKol.Text);
            lstInform.SelectedIndex = lstInform.Items.Count - 1;

        }
    }
}