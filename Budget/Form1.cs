using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Budget
{
    
    public partial class Form1 : Form
    {
        public static int ID = 0;
        public static int edit_ID = 0;
        public List<Item> items = new List<Item>();
        public Form1()
        {
            InitializeComponent();
            hide_all();
            string start = "create table if not EXISTS item(id int PRIMARY KEY auto_increment,name varchar(100),amount float,date date,rep boolean);";
            DB_create_table(start);
            data_update();

        }

        private void income_button_Click(object sender, EventArgs e)
        {
            hide_all();
            main.Text = ("Income");
            show_income();
        }

        private void expense_button_Click(object sender, EventArgs e)
        {
            hide_all();
            main.Text = ("Expense");
            show_expense();
        }

        private void summary_button_Click(object sender, EventArgs e)
        {
            hide_all();
            main.Text = ("Summary");
            show_summary();
        }

        private void chart_button_Click(object sender, EventArgs e)
        {
            hide_all();
            main.Text = ("Chart");
            show_chart_group();
        }
        private void prediction_Click(object sender, EventArgs e)
        {
            hide_all();
            main.Text = ("Prediction");
            show_prediction();
        }
        private void settings_Click(object sender, EventArgs e)
        {
            hide_all();
            main.Text = ("Settings");
            show_settings();
        }
        private void hide_all()
        {
            //income stuff
            income_add.Visible = false;
            income_reset.Visible = false;
            income_name_lab.Visible = false;
            income_name_field.Visible = false;
            income_amount_field.Visible = false;
            income_amount_lab.Visible = false;
            income_date_lab.Visible = false;
            income_date_picker.Visible = false;
            income_repeating_checkbox.Visible = false;

            //expense stuff
            expense_add.Visible = false;
            expense_reset.Visible = false;
            expense_name_lab.Visible = false;
            expense_name_field.Visible = false;
            expense_amount_field.Visible = false;
            expense_amount_lab.Visible = false;
            expense_date_lab.Visible = false;
            expense_date_picker.Visible = false;
            expense_repeating_checkbox.Visible = false;

            //summary stuff
            data.Visible = false;
            summary_update.Visible = false;
            summary_edit.Visible = false;
            summary_delete.Visible = false;
            summary_total_lab.Visible = false;
            summary_total_field.Visible = false;

            //edit_stuff
            edit_name_lab.Visible = false;
            edit_name_field.Visible = false;
            edit_amount_lab.Visible = false;
            edit_amount_field.Visible = false;
            edit_date_lab.Visible = false;
            edit_datepicker.Visible = false;
            edit_rep.Visible = false;
            edit_edit.Visible = false;
            edit_cancel.Visible = false;
            edit_group.Visible = false;
            edit_combo.Visible = false;
            edit_type_lab.Visible = false;

            //chart stuff
            chart_type_lab.Visible = false;
            chart_type_combo.Visible = false;
            chart_checkbox_lab.Visible = false;
            chart_include_combo.Visible = false;
            chart_generate.Visible = false;
            chart_group.Visible = false;
            barchart.Visible = false;
            piechart.Visible = false;
            splinechart.Visible = false;
            chart_back.Visible = false;

            //prediction stuff
            prediction_start_m_lab.Visible = false;
            prediction_start_m_combo.Visible = false;
            prediction_start_y_lab.Visible = false;
            prediction_start_y_field.Visible = false;
            prediction_period_lab.Visible = false;
            prediction_period_combo.Visible = false;
            prediction_amount_lab.Visible = false;
            prediction_amount_field.Visible = false;
            prediction_generate.Visible = false;
            prediction_total.Visible = false;
            prediction_total_info_lab.Visible = false;
            prediction_checkbox.Visible = false;
            prediction_total_lab.Visible = false;
            prediction_reset.Visible = false;

            //settings stuff
            settings_test.Visible = false;
            settings_test_lab.Visible = false;


              
        }
        private void show_prediction()
        {
            prediction_start_m_lab.Visible = true;
            prediction_start_m_combo.Visible = true;
            prediction_start_y_lab.Visible = true;
            prediction_start_y_field.Visible = true;
            prediction_period_lab.Visible = true;
            prediction_period_combo.Visible = true;
            prediction_amount_lab.Visible = true;
            prediction_amount_field.Visible = true;
            prediction_generate.Visible = true;
            prediction_total.Visible = true;
            prediction_total_info_lab.Visible = true;
            prediction_checkbox.Visible = true;
            prediction_total_lab.Visible = true;
            prediction_reset.Visible = true;
        }
        private void show_settings()
        {
            settings_test.Visible = true;
            settings_test_lab.Visible = true;
        }
        private void show_chart_group()
        {
            chart_type_lab.Visible = true;
            chart_type_combo.Visible = true;
            chart_checkbox_lab.Visible = true;
            chart_include_combo.Visible = true;
            chart_generate.Visible = true;
            chart_group.Visible = true;
        }
        private void show_edit()
        {
            hide_all();
            edit_name_lab.Visible = true;
            edit_name_field.Visible = true;
            edit_amount_lab.Visible = true;
            edit_amount_field.Visible = true;
            edit_date_lab.Visible = true;
            edit_datepicker.Visible = true;
            edit_rep.Visible = true;
            edit_edit.Visible = true;
            edit_cancel.Visible = true;
            edit_group.Visible = true;
            edit_combo.Visible = true;
            edit_type_lab.Visible = true;
        }
        private void show_summary()
        {
            data.Visible = true;
            summary_update.Visible = true;
            summary_edit.Visible = true;
            summary_delete.Visible = true;
            summary_total_lab.Visible = true;
            summary_total_field.Visible = true;
        }
        private void show_income()
        {
            income_add.Visible = true;
            income_reset.Visible = true;
            income_name_lab.Visible = true;
            income_name_field.Visible = true;
            income_amount_field.Visible = true;
            income_amount_lab.Visible = true;
            income_date_lab.Visible = true;
            income_date_picker.Visible = true;
            income_repeating_checkbox.Visible = true;
        }
        private void show_expense()
        {
            expense_add.Visible = true;
            expense_reset.Visible = true;
            expense_name_lab.Visible = true;
            expense_name_field.Visible = true;
            expense_amount_field.Visible = true;
            expense_amount_lab.Visible = true;
            expense_date_lab.Visible = true;
            expense_date_picker.Visible = true;
            expense_repeating_checkbox.Visible = true;
        }

        private void expense_reset_Click(object sender, EventArgs e)
        {
            expense_name_field.Text = "";
            expense_amount_field.Text = "";
            expense_date_picker.Text = "";
            expense_repeating_checkbox.Checked = false;
            data_update();
        }

        private void expense_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (expense_name_field.Text == "")
                    throw new Exception();
                float.Parse(expense_amount_field.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Name can't be empty, Value must be a number!");
                return;
            }
            int check;
            if (expense_repeating_checkbox.Checked)
                check = 1;
            else
                check = 0;
            string date = expense_date_picker.Value.Year.ToString() + "-" + expense_date_picker.Value.Month.ToString() + "-" + expense_date_picker.Value.Day.ToString();
            string item = "INSERT INTO item VALUES(NULL, '" + expense_name_field.Text + "', '" + "-" + expense_amount_field.Text + "', '" + date + "', '" + check + "');";
            //add item to list items
            bool rep;
            if (check == 1)
                rep = true;
            else
                rep = false;
            if (DB_Add_item(item))
            {
                items.Add(new Item(ID, expense_name_field.Text, float.Parse(expense_amount_field.Text), date, rep));
                ID += 1;
            }
            else
            {

            }
            data_update();
        }

        private void income_add_Click(object sender, EventArgs e)
        {
            try 
            {
                if (income_name_field.Text == "")
                    throw new Exception();
                float.Parse(income_amount_field.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Name can't be empty, Value must be a number!");
                return;
            }
            int check;
            if (income_repeating_checkbox.Checked)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
            string date = income_date_picker.Value.Year.ToString()+"-"+income_date_picker.Value.Month.ToString()+"-"+ income_date_picker.Value.Day.ToString();
            string item = "INSERT INTO item VALUES(NULL, '" + income_name_field.Text + "', '" + income_amount_field.Text + "', '" + date + "', '" + check + "')";
            //add item to list items
            bool rep;
            if (check == 1)
            {
                rep = true;
            }  
            else
            {
                rep = false;
            }
            if (DB_Add_item(item))
            {
                items.Add(new Item(ID, income_name_field.Text, float.Parse(income_amount_field.Text), date, rep));
                ID += 1;
            }
            else
            {

            }
            data_update();
        }

        private void income_reset_Click(object sender, EventArgs e)
        {
            income_name_field.Text = "";
            income_amount_field.Text = "";
            income_date_picker.Text = "";
            income_repeating_checkbox.Checked = false;
            data_update(); 
        }
        public bool DB_Add_item(string q)
        {
            var result = Task.Run<int>(() =>
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
                string query = q;

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }

                MessageBox.Show("Added new item!");
                return 1;
            });
            if(result.Result==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public  List<Item> DB_show_all(string q)
        {    
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
                string query = q;

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                List<Item> items = new List<Item>();

                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ID = reader.GetInt32(0);
                        items.Add(new Item(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetDateTime(3).ToString(), reader.GetBoolean(4)));
                    }
                    ID += 1;
                }
                else
                {
                    ID = 1;
                }
                databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                return items;
        }
        public void DB_remove_item(string q)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            string query = q;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Successfully deleted!");
        }
        public void DB_edit_item(string q)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            string query = q;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Successfully edited!");
        }
        public void data_update()
        {
            items = DB_show_all("Select * from item");
            data.Rows.Clear();
            
            foreach( Item item in items)
            {
                DateTime newDate = DateTime.Parse(item.date);
                
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(data);
                row.Cells[0].Value = item.id.ToString();
                row.Cells[1].Value = item.name.ToString();
                row.Cells[2].Value = item.amount.ToString();
                row.Cells[3].Value = newDate.ToString("dd-MM-yyyy");
                row.Cells[4].Value = item.rep.ToString();
                row.Cells[5].Value = item.type.ToString();
                data.Rows.Add(row);
            }
            update_total();
        }
        private void summary_update_Click(object sender, EventArgs e)
        {
            
            data_update();
           
        }

        private void summary_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(data.SelectedRows.Count==0)
            {
                MessageBox.Show("Before delete. You have to select any row or rows!");
                    return;
            }
            foreach (DataGridViewRow row in data.SelectedRows)
            {
                for (int j = 0; j < items.Count;j++)
                {
                    if (items[j].id == int.Parse(data.SelectedRows[i].Cells[0].Value.ToString()))
                    {
                        DB_remove_item("delete from item where id=" + items[j].id + ";");
                        items.RemoveAt(j);
                    }
                }
                
                data.Rows.RemoveAt(row.Index);
                i++;
            }
        }

        private void summary_edit_Click(object sender, EventArgs e)
        {
            if(data.SelectedRows.Count>1)
            {
                MessageBox.Show("You can't select more then one row to edit!");
                return;
            }
            if(data.SelectedRows.Count==0)
            {
                MessageBox.Show("You have to select atleast one row to edit!");
                return;
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].id == int.Parse(data.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    Item item = items[i];
                    edit_name_field.Text = item.name;
                    edit_amount_field.Text = item.amount.ToString();
                    edit_datepicker.Value = DateTime.Parse( item.date);
                    edit_rep.Checked = item.rep;
                    edit_ID = item.id;
                }
            }
            
            show_edit();
        }

        private void edit_cancel_Click(object sender, EventArgs e)
        {
            hide_all();
            show_summary();
        }

        private void edit_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_name_field.Text == "")
                    throw new Exception();
                float.Parse(edit_amount_field.Text);
                if (edit_combo.Text == "")
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Name can't be empty, Value must be a number, Type must be selected!");
                return;
            }
            int check;
            if (edit_rep.Checked)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
            float value = float.Parse(edit_amount_field.Text);
            if(edit_combo.Text=="expense")
            {
                value *= -1;
            }
            string date = edit_datepicker.Value.Year.ToString() + "-" + edit_datepicker.Value.Month.ToString() + "-" + edit_datepicker.Value.Day.ToString();
            string item = "Update item set name='" +edit_name_field.Text + "', amount='" + value.ToString() + "', date='" + date + "', rep='" + check
                + "' where id=" + edit_ID + ";";
            //edit item in list items
            bool rep;
            if (check == 1)
            {
                rep = true;
            }
            else
            {
                rep = false;
            }
            DB_edit_item(item);
            
            for(int i=0;i<items.Count;i++)
            {
                if(items[i].id==edit_ID)
                {
                    items[i].name = edit_name_field.Text;
                    items[i].amount = value;
                    items[i].date = date;
                    items[i].rep = rep;
                }
            }
            hide_all();
            show_summary();
            data_update();
        }
        public void update_total()
        {
            float value = 0;
            for (int i = 0; i < items.Count; i++)
            {
                value += items[i].amount;
            }
            summary_total_field.Text = value.ToString();
        }

        private void chart_generate_Click(object sender, EventArgs e)
        {
            string type = chart_type_combo.Text;
            if(type=="")
            {
                MessageBox.Show("You have to select type!");
                return;
            }
            else if(chart_include_combo.Text=="")
            {
                MessageBox.Show("You have to select includes!");
                return;
            }
            switch(type)
            {
                case "bar":
                    {
                        generate_barchart();
                        break;
                    }
                case "pie":
                    {
                        generate_piechart();
                        break;
                    }
                case "spline":
                    {
                        generate_splinechart();
                        break;
                    }
            }
        }
        private void generate_barchart()
        {
            hide_all();
            string include = chart_include_combo.Text;
            if (include == "")
            {
                MessageBox.Show("You have to choose includes!");
                return;
            }
            chart_back.Visible = true;
            barchart.Series.Clear();
            List<string> seriesArray = new List<string>();
            seriesArray = DB_show_date("select date from item group by date order by date;");

            List<float> pointsArray = new List<float>();
            for (int i = 0; i < seriesArray.Count; i++)
            {
                pointsArray.Add(0);
            }

           
            switch(include)
            {
                case "income":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i] && items[j].type=="income")
                                {
                                    pointsArray[i] += items[j].amount;
                                }
                            }
                        }
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            if (pointsArray[i] != 0)
                            {
                                Series series = barchart.Series.Add(seriesArray[i]);
                                series.Points.Add(pointsArray[i]);
                            }
                            
                        }
                        barchart.Visible = true;
                        break;
                    }
                case "expense":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i] && items[j].type == "expense")
                                {
                                    pointsArray[i] += (items[j].amount * (-1));
                                }
                            }
                        }
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            if (pointsArray[i] != 0)
                            {
                                Series series = barchart.Series.Add(seriesArray[i]);
                                series.Points.Add(pointsArray[i]);
                            }
                            
                        }
                        barchart.Visible = true;
                        break;
                    }
                case "total":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i])
                                {
                                    pointsArray[i] += items[j].amount;
                                }
                            }
                        }
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            Series series = barchart.Series.Add(seriesArray[i]);
                            series.Points.Add(pointsArray[i]);
                        }
                        barchart.Visible = true;
                        break;
                    }
            }
           
        }
        private void generate_piechart()
        {
            hide_all();
            string include = chart_include_combo.Text;
            if (include == "")
            {
                MessageBox.Show("You have to choose includes!");
                return;
            }
            chart_back.Visible = true;
            piechart.Series.Clear();
            List<string> seriesArray = new List<string>();
            seriesArray = DB_show_date("select date from item group by date order by date;");

            List<float> pointsArray = new List<float>();
            for (int i = 0; i < seriesArray.Count; i++)
            {
                pointsArray.Add(0);
            }

            
            switch (include)
            {
                case "income":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i] && items[j].type == "income")
                                {
                                    pointsArray[i] += items[j].amount;
                                }
                            }
                        }
                        string seriesname = "date";
                        piechart.Series.Add(seriesname);
                        piechart.Series[seriesname].ChartType = SeriesChartType.Pie;
                        piechart.Series[seriesname].IsValueShownAsLabel = true;
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            if (pointsArray[i] != 0)
                            {
                                piechart.Series[seriesname].Points.AddXY(seriesArray[i], pointsArray[i]);
                            }
                                
                        }
                        piechart.Visible = true;
                        break;
                    }
                case "expense":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i] && items[j].type == "expense")
                                {
                                    pointsArray[i] += (items[j].amount * (-1));
                                }
                            }
                        }
                        string seriesname = "date";
                        piechart.Series.Add(seriesname);
                        piechart.Series[seriesname].ChartType = SeriesChartType.Pie;
                        piechart.Series[seriesname].IsValueShownAsLabel = true;
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            if (pointsArray[i] != 0)
                            {
                                piechart.Series[seriesname].Points.AddXY(seriesArray[i], pointsArray[i]);
                            }
                                
                        }
                        piechart.Visible = true;
                        break;
                    }
                case "total":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i])
                                {
                                    pointsArray[i] += items[j].amount;
                                }
                            }
                        }
                        string seriesname = "date";
                        piechart.Series.Add(seriesname);
                        piechart.Series[seriesname].ChartType = SeriesChartType.Pie;
                        piechart.Series[seriesname].IsValueShownAsLabel = true;
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            piechart.Series[seriesname].Points.AddXY(seriesArray[i], pointsArray[i]);
                        }
                        piechart.Visible = true;
                        break;
                    }
                
            }

        }

        private void generate_splinechart()
        {
            hide_all();
            string include = chart_include_combo.Text;
            if (include == "")
            {
                MessageBox.Show("You have to choose includes!");
                return;
            }
            chart_back.Visible = true;
            splinechart.Series.Clear();
            List<string> seriesArray = new List<string>();
            seriesArray = DB_show_date("select date from item group by date order by date;");

            List<float> pointsArray = new List<float>();
            for (int i = 0; i < seriesArray.Count; i++)
            {
                pointsArray.Add(0);
            }

            
            switch (include)
            {
                case "income":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i] && items[j].type == "income")
                                {
                                    pointsArray[i] += items[j].amount;
                                }
                            }
                        }
                        string seriesname = "Value";
                        splinechart.Series.Add(seriesname);
                        splinechart.Series[seriesname].ChartType = SeriesChartType.Spline;
                        splinechart.Series[seriesname].IsValueShownAsLabel = true;
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            if (pointsArray[i] != 0)
                            {
                                splinechart.Series[seriesname].Points.AddXY(seriesArray[i], pointsArray[i]);
                            }
                                
                        }
                        splinechart.Visible = true;
                        break;
                    }
                case "expense":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i] && items[j].type == "expense")
                                {
                                    pointsArray[i] += (items[j].amount * (-1));
                                }
                            }
                        }
                        string seriesname = "Value";
                        splinechart.Series.Add(seriesname);
                        splinechart.Series[seriesname].ChartType = SeriesChartType.Spline;
                        splinechart.Series[seriesname].IsValueShownAsLabel = true;
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            if(pointsArray[i]!=0)
                            {
                                splinechart.Series[seriesname].Points.AddXY(seriesArray[i], pointsArray[i]);
                            }
                            
                        }
                        splinechart.Visible = true;
                        break;
                    }
                case "total":
                    {
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            for (int j = 0; j < items.Count; j++)
                            {
                                DateTime newdate = DateTime.Parse(items[j].date);
                                if (newdate.ToString("dd-MM-yyyy") == seriesArray[i])
                                {
                                    pointsArray[i] += items[j].amount;
                                }
                            }
                        }
                        string seriesname = "Value";
                        splinechart.Series.Add(seriesname);
                        splinechart.Series[seriesname].ChartType = SeriesChartType.Spline;
                        splinechart.Series[seriesname].IsValueShownAsLabel = true;
                        for (int i = 0; i < seriesArray.Count; i++)
                        {
                            splinechart.Series[seriesname].Points.AddXY(seriesArray[i], pointsArray[i]);
                        }
                        splinechart.Visible = true;
                        break;
                    }
            }
        }
        public List<string> DB_show_date(string q)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            string query = q;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            List<string> date = new List<string>();

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        date.Add(reader.GetDateTime(0).ToString("dd-MM-yyyy"));
                    }
                }
                else
                {
                    MessageBox.Show("Can't generate chart without any data inserted!");
                    return null;

                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            //MessageBox.Show("DB: Successfully readed!");
            return date;
        }
        public void DB_create_table(string q)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            string query = q;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void hide_charts()
        {
            barchart.Visible = false;
            piechart.Visible = false;
            splinechart.Visible = false;
        }

        private void chart_back_Click(object sender, EventArgs e)
        {
            
            chart_back.Visible = false;
            hide_charts();
            show_chart_group();
        }

        private void settings_test_Click(object sender, EventArgs e)
        {
            string test_query = "INSERT INTO `item` (`id`, `name`, `amount`, `date`, `rep`) VALUES"
                                                    + "(1, 'income 1', 1000, '2020-11-01', 1),"
                                                    + "(2, 'income 2', 570, '2020-11-02', 0),"
                                                    + "(3, 'income 3', 800, '2020-11-05', 0),"
                                                    + "(4, 'income 4', 100, '2020-11-12', 0),"
                                                    + "(5, 'income 6', 215, '2020-11-01', 1),"
                                                    + "(6, 'income 7', 800, '2020-11-26', 0),"
                                                    + "(7, 'income 8', 1500, '2020-11-25', 0),"
                                                    + "(8, 'income 9', 2670, '2020-11-30', 0),"
                                                    + "(9, 'income 10', 520, '2020-11-01', 0),"
                                                    + "(10, 'expense 1', -500, '2020-11-01', 1),"
                                                    + "(11, 'expense 2', -700, '2020-11-05', 1),"
                                                    + "(12, 'expense 3', -250, '2020-11-13', 0),"
                                                    + "(13, 'expense 4', -854, '2020-11-22', 0),"
                                                    + "(14, 'expense 5', -480, '2020-11-11', 1),"
                                                    + "(15, 'expense 6', -1000, '2020-11-21', 0),"
                                                    + "(16, 'expense 7', -150, '2020-11-26', 1),"
                                                    + "(17, 'expense 8', -280, '2020-11-30', 0),"
                                                    + "(18, 'expense 9', -50, '2020-11-05', 1),"
                                                    + "(19, 'expense 10', -500, '2020-11-27', 0);";
            DB_create_test(test_query);
        }
        public void DB_create_test(string q)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            string query1 = "drop table if exists item;";
            string query2 = "create table item(id int PRIMARY KEY auto_increment, name varchar(100),amount float, date date,rep boolean);";
            string query3 = q;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query1, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query2, databaseConnection);
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query3, databaseConnection);
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            data_update();
            MessageBox.Show("Successfully set test data!");
        }

        private void prediction_generate_Click(object sender, EventArgs e)
        {
            if (prediction_start_m_combo.Text == "" || prediction_start_y_field.Text == "")
            {
                MessageBox.Show("Prediction start month must be selected and year must be type of int!");
                return;
            }
            if (prediction_period_combo.Text == "") 
            {
                MessageBox.Show("Prediction period must be selected!");
                return;
            }
            if (prediction_amount_field.Text == "") 
            {
                MessageBox.Show("Prediction amount can't be empty!");
                return;
            }
            int number = 0;
            try
            {
                number = int.Parse(prediction_amount_field.Text);
                if(number<=0)
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Amount must be a type of int greater then 0");
                return;
            }
            int year = 0;
            try
            {
                year = int.Parse(prediction_start_y_field.Text);
                if (year < 2020)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Start year must be a type of int greater or equal 2020");
                return;
            }
            //0-month
            //1-year
            bool period = false ;
            if (prediction_period_combo.Text=="months")
            {
                period = false;
            }
            if(prediction_period_combo.Text == "years")
            {
                period = true;
            }
            
            string month = prediction_start_m_combo.Text;
            int month_no = 0;
            switch(month)
            {
                case "January":
                    {
                        month_no = 1;
                        break;
                    }
                case "February":
                    {
                        month_no = 2;
                        break;
                    }
                case "March":
                    {
                        month_no = 3;
                        break;
                    }
                case "April":
                    {
                        month_no = 4;
                        break;
                    }
                case "May":
                    {
                        month_no = 5;
                        break;
                    }
                case "June":
                    {
                        month_no = 6;
                        break;
                    }
                case "July":
                    {
                        month_no = 7;
                        break;
                    }
                case "August":
                    {
                        month_no = 8;
                        break;
                    }
                case "September":
                    {
                        month_no = 9;
                        break;
                    }
                case "October":
                    {
                        month_no = 10;
                        break;
                    }
                case "November":
                    {
                        month_no = 11;
                        break;
                    }
                case "December":
                    {
                        month_no = 12;
                        break;
                    }
            }
            List<Item> predict_rep = new List<Item>();
            List<Item> predict_norep = new List<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                DateTime newDate = DateTime.Parse(items[i].date);
                if (newDate.ToString("yyyy-MM") == year + "-" + month_no && items[i].rep)
                {
                    predict_rep.Add(items[i]);
                }
                else if(newDate.ToString("yyyy-MM") == year + "-" + month_no && !items[i].rep)
                {
                    predict_norep.Add(items[i]);
                }
            }
            //check if there are any items
            float Total = 0;
            if (predict_rep.Count == 0 && predict_norep.Count == 0)
            {
                prediction_total.Text = Total.ToString();
                MessageBox.Show("Didn't find any items in that range!");
                return;
            }
            //avg of non reapiting
            float non_rep_avg = 0;
            if(prediction_checkbox.Checked)
            {
                for (int i = 0; i < predict_norep.Count; i++)
                {
                    non_rep_avg += predict_norep[i].amount;
                }
            }
            
            
            //avg of reapiting
            float rep_avg = 0;
            for (int i = 0; i < predict_rep.Count; i++)
            {
                rep_avg += predict_rep[i].amount;
            }
            
            for (int i = 0; i < number; i++)
            {
                Total += rep_avg + non_rep_avg;
            }
            if(period)
            {
                Total *= 12;
                prediction_total.Text = Total.ToString();
            }
            else
            {
                prediction_total.Text = Total.ToString();
            }

        }

        private void prediction_reset_Click(object sender, EventArgs e)
        {
            prediction_start_m_combo.SelectedItem = null;
            prediction_start_y_field.Text = "";
            prediction_period_combo.SelectedItem = null;
            prediction_checkbox.Checked = false;
            prediction_amount_field.Text = "";
            prediction_total.Text = "";
        }
    }
}
