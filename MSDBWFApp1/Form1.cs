using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace MSDBWFApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------
        private SqlConnection sqlConnection = null;
        private int RC = 0;
        //------------------------------
        public void gList()
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(new string[]
            {
                "Аниме",
                "Биографический",
                "Боевик",
                "Вестерн",
                "Военный",
                "Детектив",
                "Детский",
                "Документальный",
                "Драма",
                "Исторический",
                "Кинокомикс",
                "Комедия",
                "Концерт",
                "Короткометражный",
                "Криминал",
                "Мелодрама",
                "Мистика",
                "Мультфильм",
                "Мюзикл",
                "Научный",
                "Нуар",
                "Приключения",
                "Реалити-шоу",
                "Семейный",
                "Спорт",
                "Ток-шоу",
                "Триллер",
                "Ужасы",
                "Фантастика",
                "Фэнтези",
                "Эротика",
                "Фолк",
                "Кантри",
                "Латиноамерика",
                "Блюз",
                "Джаз",
                "Ритм-н-Блюз",
                "Шансон",
                "Барды",
                "Поэты",
                "Электроника",
                "Рок",
                "Хип-хоп",
                "Регги",
                "Поп"
            });

            tBoxTheme.AutoCompleteCustomSource = source;
            tBoxTheme.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tBoxTheme.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tBoxUpdTheme.AutoCompleteCustomSource = source;
            tBoxUpdTheme.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tBoxUpdTheme.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        //------------------------------
        private void iFill()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Number AS 'Номер', " +
                                                                   "Name AS 'Название', " +
                                                                   "Theme AS 'Тематика', " +
                                                                   "Purpose AS 'Назначение' , " +
                                                                   "Notes AS 'Примечание' FROM Disk", sqlConnection);
            DataSet dbDisk = new DataSet();
            dataAdapter.Fill(dbDisk);
            dataGridView1.DataSource = dbDisk.Tables[0];
            dataGridView2.DataSource = dbDisk.Tables[0];

        }
        //------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBDisk"].ConnectionString);
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                labelState.Text = "Подключение установлено";
                iFill();
            } 
            else
            {
                labelState.Text = "Нет подключения";
            }

            gList();

            RC = dataGridView1.Rows.Count;
        }
        //------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Disk] (Name, Theme, Purpose, Notes) " +
                                                $"VALUES (@Name, @Theme, @Purpose, @Notes)", sqlConnection);

            command.Parameters.AddWithValue("Name", tBoxName.Text);
            command.Parameters.AddWithValue("Theme", tBoxTheme.Text);
            command.Parameters.AddWithValue("Purpose", cBoxPurpose.Text);
            command.Parameters.AddWithValue("Notes", tBoxNotes.Text);

            if (command.ExecuteNonQuery() == 1)
            {
                labelState.Text = "Строка добавлена";
                tBoxName.Text = "";
                tBoxNotes.Text = "";
                tBoxTheme.Text = "";
                cBoxPurpose.Text = null;
                iFill();
            }
            else
            {
                labelState.Text = "Ошибка добавления";
            }

            RC = dataGridView1.Rows.Count;
        }
        //------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cBoxPSearch.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Назначение LIKE '%{tBoxSearch.Text}%'";
                    break;
                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Тематика LIKE '%{tBoxSearch.Text}%'";
                    break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Название LIKE '%{tBoxSearch.Text}%'";
                    break;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                labelState.Text = "Элементы не найдены";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            else
            {
                labelState.Text = "Вот что нашлось";
            }
        }
        //------------------------------
        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            cBoxPSearch.Text = null;
            tBoxSearch.Text = "";
            labelState.Text = "Поиск сброшен";
        }
        //------------------------------
        private void btnUpd_Click(object sender, EventArgs e)
        {
            int i = 0;

            try
            {
                Int32.Parse(tBoxWhereRow.Text);

                if (tBoxUpdName.Text != "")
                {
                    SqlCommand command = new SqlCommand($"UPDATE Disk SET Name =@Name WHERE Number =@Number", sqlConnection);
                    command.Parameters.AddWithValue("Name", tBoxUpdName.Text);
                    command.Parameters.AddWithValue("Number", tBoxWhereRow.Text);
                    command.ExecuteNonQuery();
                    i++;
                }
                if (tBoxUpdTheme.Text != "")
                {
                    SqlCommand command = new SqlCommand($"UPDATE Disk SET Theme =@Theme WHERE Number =@Number", sqlConnection);
                    command.Parameters.AddWithValue("Theme", tBoxUpdTheme.Text);
                    command.Parameters.AddWithValue("Number", tBoxWhereRow.Text);
                    command.ExecuteNonQuery();
                    i++;
                }
                if (cBoxUpdPurpose.Text != "")
                {
                    SqlCommand command = new SqlCommand($"UPDATE Disk SET Purpose =@Purpose WHERE Number =@Number", sqlConnection);
                    command.Parameters.AddWithValue("Purpose", cBoxUpdPurpose.Text);
                    command.Parameters.AddWithValue("Number", tBoxWhereRow.Text);
                    command.ExecuteNonQuery();
                    i++;
                }
                if (tBoxUpdNotes.Text != "")
                {
                    SqlCommand command = new SqlCommand($"UPDATE Disk SET Notes =@Notes WHERE Number =@Number", sqlConnection);
                    command.Parameters.AddWithValue("Notes", tBoxUpdNotes.Text);
                    command.Parameters.AddWithValue("Number", tBoxWhereRow.Text);
                    command.ExecuteNonQuery();
                    i++;
                }

                if (i >= 1)
                {
                    labelState.Text = "Изменения внесены";
                    tBoxUpdName.Text = "";
                    tBoxUpdTheme.Text = "";
                    tBoxUpdNotes.Text = "";
                    cBoxUpdPurpose.Text = null;
                    iFill();
                }
                else
                {
                    labelState.Text = "Изменения не внесены";
                }
            }
            catch (FormatException)
            {
                labelState.Text = "Необходимо ввести номер эелемента";
            }
        }
        //------------------------------
        private void button1_Click(object sender, EventArgs e)
        {

            string purValue = "";

            for (int row = 0; row < dataGridView2.RowCount - 1; row++)
            {

                if (row + 1 > RC)
                {
                    for (int colmn = 1; colmn < dataGridView2.ColumnCount; colmn++)
                    {
                        string cellText = null;

                        if (colmn == 1)
                        {
                            cellText = Convert.ToString(dataGridView2[colmn, row].Value);
                            SqlCommand command = new SqlCommand($"INSERT INTO [Disk] (Name) VALUES (@Name)", sqlConnection);
                            command.Parameters.AddWithValue("Name", cellText);
                            command.ExecuteNonQuery();
                        }
                        else if (colmn == 2)
                        {
                            cellText = Convert.ToString(dataGridView2[colmn, row].Value);
                            SqlCommand command = new SqlCommand($"UPDATE Disk SET Theme =@Theme WHERE Number =@Number", sqlConnection);
                            command.Parameters.AddWithValue("Theme", cellText);
                            command.Parameters.AddWithValue("Number", row + 1);
                            command.ExecuteNonQuery();
                        }
                        else if (colmn == 3)
                        {
                            cellText = Convert.ToString(dataGridView2[colmn, row].Value);
                            if (cellText != "Аудио" && cellText != "Видео" && cellText != "Цифровой")
                            {
                                purValue = " Назначение принимает только: Аудио, Видео, Цифровой";
                                cellText = "";
                            }
                            SqlCommand command = new SqlCommand($"UPDATE Disk SET Purpose =@Purpose WHERE Number =@Number", sqlConnection);
                            command.Parameters.AddWithValue("Purpose", cellText);
                            command.Parameters.AddWithValue("Number", row + 1);
                            command.ExecuteNonQuery();
                        }
                        else if (colmn == 4)
                        {
                            cellText = Convert.ToString(dataGridView2[colmn, row].Value);
                            SqlCommand command = new SqlCommand($"UPDATE Disk SET Notes =@Notes WHERE Number =@Number", sqlConnection);
                            command.Parameters.AddWithValue("Notes", cellText);
                            command.Parameters.AddWithValue("Number", row + 1);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    for (int colmn = 1; colmn < dataGridView2.ColumnCount; colmn++)
                    {
                        string cellText = null;

                        if (colmn == 1)
                        {
                            cellText = Convert.ToString(dataGridView2[colmn, row].Value);
                            SqlCommand command = new SqlCommand($"UPDATE Disk SET Name =@Name WHERE Number =@Number", sqlConnection);
                            command.Parameters.AddWithValue("Name", cellText);
                            command.Parameters.AddWithValue("Number", row + 1);
                            command.ExecuteNonQuery();
                        }
                        else if (colmn == 2)
                        {
                            cellText = Convert.ToString(dataGridView2[colmn, row].Value);
                            SqlCommand command = new SqlCommand($"UPDATE Disk SET Theme =@Theme WHERE Number =@Number", sqlConnection);
                            command.Parameters.AddWithValue("Theme", cellText);
                            command.Parameters.AddWithValue("Number", row + 1);
                            command.ExecuteNonQuery();
                        }
                        else if (colmn == 3)
                        {
                            cellText = Convert.ToString(dataGridView2[colmn, row].Value);
                            if (cellText != "Аудио" && cellText != "Видео" && cellText != "Цифровой")
                            {
                                purValue = " Назначение принимает только: Аудио, Видео, Цифровой";
                                cellText = "";
                            }
                            SqlCommand command = new SqlCommand($"UPDATE Disk SET Purpose =@Purpose WHERE Number =@Number", sqlConnection);
                            command.Parameters.AddWithValue("Purpose", cellText);
                            command.Parameters.AddWithValue("Number", row + 1);
                            command.ExecuteNonQuery();
                        }
                        else if (colmn == 4)
                        {
                            cellText = Convert.ToString(dataGridView2[colmn, row].Value);
                            SqlCommand command = new SqlCommand($"UPDATE Disk SET Notes =@Notes WHERE Number =@Number", sqlConnection);
                            command.Parameters.AddWithValue("Notes", cellText);
                            command.Parameters.AddWithValue("Number", row + 1);
                            command.ExecuteNonQuery();
                        }
                    }
                }         
            }

            RC = dataGridView2.Rows.Count-1;
            labelState.Text = "Изменения сохранены" + purValue;
            iFill();

        }
    }
}
