
using System.Windows.Forms;

namespace Budget
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.income_button = new System.Windows.Forms.Button();
            this.expense_button = new System.Windows.Forms.Button();
            this.summary_button = new System.Windows.Forms.Button();
            this.chart_button = new System.Windows.Forms.Button();
            this.income_name_lab = new System.Windows.Forms.Label();
            this.income_date_picker = new System.Windows.Forms.DateTimePicker();
            this.income_name_field = new System.Windows.Forms.TextBox();
            this.income_date_lab = new System.Windows.Forms.Label();
            this.income_amount_lab = new System.Windows.Forms.Label();
            this.income_amount_field = new System.Windows.Forms.TextBox();
            this.income_repeating_checkbox = new System.Windows.Forms.CheckBox();
            this.income_add = new System.Windows.Forms.Button();
            this.income_reset = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.GroupBox();
            this.splinechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_back = new System.Windows.Forms.Button();
            this.barchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_group = new System.Windows.Forms.GroupBox();
            this.chart_include_combo = new System.Windows.Forms.ComboBox();
            this.chart_type_combo = new System.Windows.Forms.ComboBox();
            this.chart_generate = new System.Windows.Forms.Button();
            this.chart_checkbox_lab = new System.Windows.Forms.Label();
            this.chart_type_lab = new System.Windows.Forms.Label();
            this.summary_total_field = new System.Windows.Forms.TextBox();
            this.summary_total_lab = new System.Windows.Forms.Label();
            this.edit_group = new System.Windows.Forms.GroupBox();
            this.edit_type_lab = new System.Windows.Forms.Label();
            this.edit_combo = new System.Windows.Forms.ComboBox();
            this.edit_cancel = new System.Windows.Forms.Button();
            this.edit_edit = new System.Windows.Forms.Button();
            this.edit_rep = new System.Windows.Forms.CheckBox();
            this.edit_datepicker = new System.Windows.Forms.DateTimePicker();
            this.edit_amount_field = new System.Windows.Forms.TextBox();
            this.edit_name_field = new System.Windows.Forms.TextBox();
            this.edit_date_lab = new System.Windows.Forms.Label();
            this.edit_amount_lab = new System.Windows.Forms.Label();
            this.edit_name_lab = new System.Windows.Forms.Label();
            this.summary_update = new System.Windows.Forms.Button();
            this.summary_delete = new System.Windows.Forms.Button();
            this.summary_edit = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.data_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_rep = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.data_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expense_reset = new System.Windows.Forms.Button();
            this.expense_add = new System.Windows.Forms.Button();
            this.expense_repeating_checkbox = new System.Windows.Forms.CheckBox();
            this.expense_amount_field = new System.Windows.Forms.TextBox();
            this.expense_amount_lab = new System.Windows.Forms.Label();
            this.expense_date_lab = new System.Windows.Forms.Label();
            this.expense_name_field = new System.Windows.Forms.TextBox();
            this.expense_date_picker = new System.Windows.Forms.DateTimePicker();
            this.expense_name_lab = new System.Windows.Forms.Label();
            this.prediction = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.settings_test = new System.Windows.Forms.Button();
            this.settings_test_lab = new System.Windows.Forms.Label();
            this.prediction_period_lab = new System.Windows.Forms.Label();
            this.prediction_amount_lab = new System.Windows.Forms.Label();
            this.prediction_period_combo = new System.Windows.Forms.ComboBox();
            this.prediction_generate = new System.Windows.Forms.Button();
            this.prediction_total = new System.Windows.Forms.TextBox();
            this.prediction_amount_field = new System.Windows.Forms.TextBox();
            this.prediction_total_info_lab = new System.Windows.Forms.Label();
            this.prediction_start_m_lab = new System.Windows.Forms.Label();
            this.prediction_start_m_combo = new System.Windows.Forms.ComboBox();
            this.prediction_start_y_lab = new System.Windows.Forms.Label();
            this.prediction_start_y_field = new System.Windows.Forms.TextBox();
            this.prediction_checkbox = new System.Windows.Forms.CheckBox();
            this.prediction_reset = new System.Windows.Forms.Button();
            this.prediction_total_lab = new System.Windows.Forms.Label();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splinechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barchart)).BeginInit();
            this.chart_group.SuspendLayout();
            this.edit_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // income_button
            // 
            this.income_button.BackColor = System.Drawing.Color.GreenYellow;
            this.income_button.Location = new System.Drawing.Point(12, 3);
            this.income_button.Name = "income_button";
            this.income_button.Size = new System.Drawing.Size(130, 50);
            this.income_button.TabIndex = 2;
            this.income_button.Text = "Income";
            this.income_button.UseVisualStyleBackColor = false;
            this.income_button.Click += new System.EventHandler(this.income_button_Click);
            // 
            // expense_button
            // 
            this.expense_button.BackColor = System.Drawing.Color.OrangeRed;
            this.expense_button.Location = new System.Drawing.Point(148, 3);
            this.expense_button.Name = "expense_button";
            this.expense_button.Size = new System.Drawing.Size(130, 50);
            this.expense_button.TabIndex = 3;
            this.expense_button.Text = "Expense";
            this.expense_button.UseVisualStyleBackColor = false;
            this.expense_button.Click += new System.EventHandler(this.expense_button_Click);
            // 
            // summary_button
            // 
            this.summary_button.BackColor = System.Drawing.Color.Aqua;
            this.summary_button.Location = new System.Drawing.Point(284, 3);
            this.summary_button.Name = "summary_button";
            this.summary_button.Size = new System.Drawing.Size(130, 50);
            this.summary_button.TabIndex = 4;
            this.summary_button.Text = "Summary";
            this.summary_button.UseVisualStyleBackColor = false;
            this.summary_button.Click += new System.EventHandler(this.summary_button_Click);
            // 
            // chart_button
            // 
            this.chart_button.BackColor = System.Drawing.Color.MediumPurple;
            this.chart_button.Location = new System.Drawing.Point(420, 3);
            this.chart_button.Name = "chart_button";
            this.chart_button.Size = new System.Drawing.Size(130, 50);
            this.chart_button.TabIndex = 5;
            this.chart_button.Text = "Chart";
            this.chart_button.UseVisualStyleBackColor = false;
            this.chart_button.Click += new System.EventHandler(this.chart_button_Click);
            // 
            // income_name_lab
            // 
            this.income_name_lab.AutoSize = true;
            this.income_name_lab.Location = new System.Drawing.Point(6, 36);
            this.income_name_lab.Name = "income_name_lab";
            this.income_name_lab.Size = new System.Drawing.Size(45, 17);
            this.income_name_lab.TabIndex = 0;
            this.income_name_lab.Text = "Name";
            // 
            // income_date_picker
            // 
            this.income_date_picker.Location = new System.Drawing.Point(136, 124);
            this.income_date_picker.Name = "income_date_picker";
            this.income_date_picker.Size = new System.Drawing.Size(200, 22);
            this.income_date_picker.TabIndex = 1;
            // 
            // income_name_field
            // 
            this.income_name_field.Location = new System.Drawing.Point(136, 33);
            this.income_name_field.Name = "income_name_field";
            this.income_name_field.Size = new System.Drawing.Size(100, 22);
            this.income_name_field.TabIndex = 2;
            // 
            // income_date_lab
            // 
            this.income_date_lab.AutoSize = true;
            this.income_date_lab.Location = new System.Drawing.Point(6, 124);
            this.income_date_lab.Name = "income_date_lab";
            this.income_date_lab.Size = new System.Drawing.Size(38, 17);
            this.income_date_lab.TabIndex = 3;
            this.income_date_lab.Text = "Date";
            // 
            // income_amount_lab
            // 
            this.income_amount_lab.AutoSize = true;
            this.income_amount_lab.Location = new System.Drawing.Point(6, 80);
            this.income_amount_lab.Name = "income_amount_lab";
            this.income_amount_lab.Size = new System.Drawing.Size(44, 17);
            this.income_amount_lab.TabIndex = 4;
            this.income_amount_lab.Text = "Value";
            // 
            // income_amount_field
            // 
            this.income_amount_field.Location = new System.Drawing.Point(136, 80);
            this.income_amount_field.Name = "income_amount_field";
            this.income_amount_field.Size = new System.Drawing.Size(100, 22);
            this.income_amount_field.TabIndex = 5;
            // 
            // income_repeating_checkbox
            // 
            this.income_repeating_checkbox.AutoSize = true;
            this.income_repeating_checkbox.Location = new System.Drawing.Point(9, 175);
            this.income_repeating_checkbox.Name = "income_repeating_checkbox";
            this.income_repeating_checkbox.Size = new System.Drawing.Size(95, 21);
            this.income_repeating_checkbox.TabIndex = 6;
            this.income_repeating_checkbox.Text = "Repeating";
            this.income_repeating_checkbox.UseVisualStyleBackColor = true;
            // 
            // income_add
            // 
            this.income_add.Location = new System.Drawing.Point(62, 249);
            this.income_add.Name = "income_add";
            this.income_add.Size = new System.Drawing.Size(80, 40);
            this.income_add.TabIndex = 7;
            this.income_add.Text = "Add";
            this.income_add.UseVisualStyleBackColor = true;
            this.income_add.Click += new System.EventHandler(this.income_add_Click);
            // 
            // income_reset
            // 
            this.income_reset.Location = new System.Drawing.Point(201, 249);
            this.income_reset.Name = "income_reset";
            this.income_reset.Size = new System.Drawing.Size(80, 40);
            this.income_reset.TabIndex = 8;
            this.income_reset.Text = "Reset";
            this.income_reset.UseVisualStyleBackColor = true;
            this.income_reset.Click += new System.EventHandler(this.income_reset_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.LightSeaGreen;
            this.main.Controls.Add(this.prediction_total_lab);
            this.main.Controls.Add(this.prediction_reset);
            this.main.Controls.Add(this.prediction_checkbox);
            this.main.Controls.Add(this.prediction_start_y_field);
            this.main.Controls.Add(this.prediction_start_y_lab);
            this.main.Controls.Add(this.prediction_start_m_combo);
            this.main.Controls.Add(this.prediction_start_m_lab);
            this.main.Controls.Add(this.prediction_total_info_lab);
            this.main.Controls.Add(this.prediction_amount_field);
            this.main.Controls.Add(this.prediction_total);
            this.main.Controls.Add(this.prediction_generate);
            this.main.Controls.Add(this.prediction_period_combo);
            this.main.Controls.Add(this.prediction_amount_lab);
            this.main.Controls.Add(this.prediction_period_lab);
            this.main.Controls.Add(this.settings_test_lab);
            this.main.Controls.Add(this.settings_test);
            this.main.Controls.Add(this.splinechart);
            this.main.Controls.Add(this.piechart);
            this.main.Controls.Add(this.chart_back);
            this.main.Controls.Add(this.barchart);
            this.main.Controls.Add(this.chart_group);
            this.main.Controls.Add(this.summary_total_field);
            this.main.Controls.Add(this.summary_total_lab);
            this.main.Controls.Add(this.edit_group);
            this.main.Controls.Add(this.summary_update);
            this.main.Controls.Add(this.summary_delete);
            this.main.Controls.Add(this.summary_edit);
            this.main.Controls.Add(this.data);
            this.main.Controls.Add(this.expense_reset);
            this.main.Controls.Add(this.expense_add);
            this.main.Controls.Add(this.expense_repeating_checkbox);
            this.main.Controls.Add(this.expense_amount_field);
            this.main.Controls.Add(this.expense_amount_lab);
            this.main.Controls.Add(this.expense_date_lab);
            this.main.Controls.Add(this.expense_name_field);
            this.main.Controls.Add(this.expense_date_picker);
            this.main.Controls.Add(this.expense_name_lab);
            this.main.Controls.Add(this.income_reset);
            this.main.Controls.Add(this.income_add);
            this.main.Controls.Add(this.income_repeating_checkbox);
            this.main.Controls.Add(this.income_amount_field);
            this.main.Controls.Add(this.income_amount_lab);
            this.main.Controls.Add(this.income_date_lab);
            this.main.Controls.Add(this.income_name_field);
            this.main.Controls.Add(this.income_date_picker);
            this.main.Controls.Add(this.income_name_lab);
            this.main.Location = new System.Drawing.Point(12, 56);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(776, 382);
            this.main.TabIndex = 1;
            this.main.TabStop = false;
            this.main.Text = "groupBox1";
            // 
            // splinechart
            // 
            chartArea13.Name = "ChartArea1";
            this.splinechart.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.splinechart.Legends.Add(legend13);
            this.splinechart.Location = new System.Drawing.Point(9, 56);
            this.splinechart.Name = "splinechart";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.splinechart.Series.Add(series13);
            this.splinechart.Size = new System.Drawing.Size(761, 308);
            this.splinechart.TabIndex = 30;
            this.splinechart.Text = "chart1";
            // 
            // piechart
            // 
            chartArea14.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.piechart.Legends.Add(legend14);
            this.piechart.Location = new System.Drawing.Point(9, 57);
            this.piechart.Name = "piechart";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series14.Legend = "Legend1";
            series14.Name = "s1";
            this.piechart.Series.Add(series14);
            this.piechart.Size = new System.Drawing.Size(761, 308);
            this.piechart.TabIndex = 29;
            this.piechart.Text = "chart1";
            // 
            // chart_back
            // 
            this.chart_back.Location = new System.Drawing.Point(292, 10);
            this.chart_back.Name = "chart_back";
            this.chart_back.Size = new System.Drawing.Size(159, 38);
            this.chart_back.TabIndex = 28;
            this.chart_back.Text = "Back";
            this.chart_back.UseVisualStyleBackColor = true;
            this.chart_back.Click += new System.EventHandler(this.chart_back_Click);
            // 
            // barchart
            // 
            chartArea15.Name = "ChartArea1";
            this.barchart.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.barchart.Legends.Add(legend15);
            this.barchart.Location = new System.Drawing.Point(9, 56);
            this.barchart.Name = "barchart";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.barchart.Series.Add(series15);
            this.barchart.Size = new System.Drawing.Size(761, 308);
            this.barchart.TabIndex = 27;
            this.barchart.Text = "chart1";
            // 
            // chart_group
            // 
            this.chart_group.BackColor = System.Drawing.Color.LightBlue;
            this.chart_group.Controls.Add(this.chart_include_combo);
            this.chart_group.Controls.Add(this.chart_type_combo);
            this.chart_group.Controls.Add(this.chart_generate);
            this.chart_group.Controls.Add(this.chart_checkbox_lab);
            this.chart_group.Controls.Add(this.chart_type_lab);
            this.chart_group.Location = new System.Drawing.Point(201, 33);
            this.chart_group.Name = "chart_group";
            this.chart_group.Size = new System.Drawing.Size(410, 179);
            this.chart_group.TabIndex = 26;
            this.chart_group.TabStop = false;
            this.chart_group.Text = "Create chart";
            // 
            // chart_include_combo
            // 
            this.chart_include_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chart_include_combo.FormattingEnabled = true;
            this.chart_include_combo.Items.AddRange(new object[] {
            "income",
            "expense",
            "total"});
            this.chart_include_combo.Location = new System.Drawing.Point(129, 54);
            this.chart_include_combo.Name = "chart_include_combo";
            this.chart_include_combo.Size = new System.Drawing.Size(121, 24);
            this.chart_include_combo.TabIndex = 7;
            // 
            // chart_type_combo
            // 
            this.chart_type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chart_type_combo.FormattingEnabled = true;
            this.chart_type_combo.Items.AddRange(new object[] {
            "bar",
            "pie",
            "spline"});
            this.chart_type_combo.Location = new System.Drawing.Point(129, 21);
            this.chart_type_combo.Name = "chart_type_combo";
            this.chart_type_combo.Size = new System.Drawing.Size(121, 24);
            this.chart_type_combo.TabIndex = 6;
            // 
            // chart_generate
            // 
            this.chart_generate.Location = new System.Drawing.Point(135, 99);
            this.chart_generate.Name = "chart_generate";
            this.chart_generate.Size = new System.Drawing.Size(156, 60);
            this.chart_generate.TabIndex = 5;
            this.chart_generate.Text = "Generate chart";
            this.chart_generate.UseVisualStyleBackColor = true;
            this.chart_generate.Click += new System.EventHandler(this.chart_generate_Click);
            // 
            // chart_checkbox_lab
            // 
            this.chart_checkbox_lab.AutoSize = true;
            this.chart_checkbox_lab.Location = new System.Drawing.Point(23, 57);
            this.chart_checkbox_lab.Name = "chart_checkbox_lab";
            this.chart_checkbox_lab.Size = new System.Drawing.Size(98, 17);
            this.chart_checkbox_lab.TabIndex = 1;
            this.chart_checkbox_lab.Text = "Chart includes";
            // 
            // chart_type_lab
            // 
            this.chart_type_lab.AutoSize = true;
            this.chart_type_lab.Location = new System.Drawing.Point(23, 24);
            this.chart_type_lab.Name = "chart_type_lab";
            this.chart_type_lab.Size = new System.Drawing.Size(73, 17);
            this.chart_type_lab.TabIndex = 0;
            this.chart_type_lab.Text = "Chart type";
            // 
            // summary_total_field
            // 
            this.summary_total_field.Enabled = false;
            this.summary_total_field.Location = new System.Drawing.Point(230, 250);
            this.summary_total_field.Name = "summary_total_field";
            this.summary_total_field.Size = new System.Drawing.Size(146, 22);
            this.summary_total_field.TabIndex = 25;
            // 
            // summary_total_lab
            // 
            this.summary_total_lab.AutoSize = true;
            this.summary_total_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summary_total_lab.Location = new System.Drawing.Point(174, 253);
            this.summary_total_lab.Name = "summary_total_lab";
            this.summary_total_lab.Size = new System.Drawing.Size(45, 17);
            this.summary_total_lab.TabIndex = 24;
            this.summary_total_lab.Text = "Total";
            // 
            // edit_group
            // 
            this.edit_group.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.edit_group.Controls.Add(this.edit_type_lab);
            this.edit_group.Controls.Add(this.edit_combo);
            this.edit_group.Controls.Add(this.edit_cancel);
            this.edit_group.Controls.Add(this.edit_edit);
            this.edit_group.Controls.Add(this.edit_rep);
            this.edit_group.Controls.Add(this.edit_datepicker);
            this.edit_group.Controls.Add(this.edit_amount_field);
            this.edit_group.Controls.Add(this.edit_name_field);
            this.edit_group.Controls.Add(this.edit_date_lab);
            this.edit_group.Controls.Add(this.edit_amount_lab);
            this.edit_group.Controls.Add(this.edit_name_lab);
            this.edit_group.Location = new System.Drawing.Point(201, 36);
            this.edit_group.Name = "edit_group";
            this.edit_group.Size = new System.Drawing.Size(366, 236);
            this.edit_group.TabIndex = 23;
            this.edit_group.TabStop = false;
            this.edit_group.Text = "Edit";
            // 
            // edit_type_lab
            // 
            this.edit_type_lab.AutoSize = true;
            this.edit_type_lab.Location = new System.Drawing.Point(178, 145);
            this.edit_type_lab.Name = "edit_type_lab";
            this.edit_type_lab.Size = new System.Drawing.Size(40, 17);
            this.edit_type_lab.TabIndex = 11;
            this.edit_type_lab.Text = "Type";
            // 
            // edit_combo
            // 
            this.edit_combo.AllowDrop = true;
            this.edit_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edit_combo.FormattingEnabled = true;
            this.edit_combo.Items.AddRange(new object[] {
            "income",
            "expense"});
            this.edit_combo.Location = new System.Drawing.Point(230, 142);
            this.edit_combo.Name = "edit_combo";
            this.edit_combo.Size = new System.Drawing.Size(121, 24);
            this.edit_combo.TabIndex = 10;
            // 
            // edit_cancel
            // 
            this.edit_cancel.Location = new System.Drawing.Point(203, 183);
            this.edit_cancel.Name = "edit_cancel";
            this.edit_cancel.Size = new System.Drawing.Size(80, 45);
            this.edit_cancel.TabIndex = 9;
            this.edit_cancel.Text = "Cancel";
            this.edit_cancel.UseVisualStyleBackColor = true;
            this.edit_cancel.Click += new System.EventHandler(this.edit_cancel_Click);
            // 
            // edit_edit
            // 
            this.edit_edit.Location = new System.Drawing.Point(91, 183);
            this.edit_edit.Name = "edit_edit";
            this.edit_edit.Size = new System.Drawing.Size(80, 45);
            this.edit_edit.TabIndex = 8;
            this.edit_edit.Text = "Edit";
            this.edit_edit.UseVisualStyleBackColor = true;
            this.edit_edit.Click += new System.EventHandler(this.edit_edit_Click);
            // 
            // edit_rep
            // 
            this.edit_rep.AutoSize = true;
            this.edit_rep.Location = new System.Drawing.Point(40, 142);
            this.edit_rep.Name = "edit_rep";
            this.edit_rep.Size = new System.Drawing.Size(95, 21);
            this.edit_rep.TabIndex = 7;
            this.edit_rep.Text = "Repeating";
            this.edit_rep.UseVisualStyleBackColor = true;
            // 
            // edit_datepicker
            // 
            this.edit_datepicker.Location = new System.Drawing.Point(91, 104);
            this.edit_datepicker.Name = "edit_datepicker";
            this.edit_datepicker.Size = new System.Drawing.Size(200, 22);
            this.edit_datepicker.TabIndex = 6;
            // 
            // edit_amount_field
            // 
            this.edit_amount_field.Location = new System.Drawing.Point(91, 68);
            this.edit_amount_field.Name = "edit_amount_field";
            this.edit_amount_field.Size = new System.Drawing.Size(178, 22);
            this.edit_amount_field.TabIndex = 5;
            // 
            // edit_name_field
            // 
            this.edit_name_field.Location = new System.Drawing.Point(91, 37);
            this.edit_name_field.Name = "edit_name_field";
            this.edit_name_field.Size = new System.Drawing.Size(178, 22);
            this.edit_name_field.TabIndex = 4;
            // 
            // edit_date_lab
            // 
            this.edit_date_lab.AutoSize = true;
            this.edit_date_lab.Location = new System.Drawing.Point(35, 104);
            this.edit_date_lab.Name = "edit_date_lab";
            this.edit_date_lab.Size = new System.Drawing.Size(38, 17);
            this.edit_date_lab.TabIndex = 2;
            this.edit_date_lab.Text = "Date";
            // 
            // edit_amount_lab
            // 
            this.edit_amount_lab.AutoSize = true;
            this.edit_amount_lab.Location = new System.Drawing.Point(35, 68);
            this.edit_amount_lab.Name = "edit_amount_lab";
            this.edit_amount_lab.Size = new System.Drawing.Size(44, 17);
            this.edit_amount_lab.TabIndex = 1;
            this.edit_amount_lab.Text = "Value";
            // 
            // edit_name_lab
            // 
            this.edit_name_lab.AutoSize = true;
            this.edit_name_lab.Location = new System.Drawing.Point(35, 37);
            this.edit_name_lab.Name = "edit_name_lab";
            this.edit_name_lab.Size = new System.Drawing.Size(45, 17);
            this.edit_name_lab.TabIndex = 0;
            this.edit_name_lab.Text = "Name";
            // 
            // summary_update
            // 
            this.summary_update.Location = new System.Drawing.Point(148, 295);
            this.summary_update.Name = "summary_update";
            this.summary_update.Size = new System.Drawing.Size(100, 70);
            this.summary_update.TabIndex = 22;
            this.summary_update.Text = "Update";
            this.summary_update.UseVisualStyleBackColor = true;
            this.summary_update.Click += new System.EventHandler(this.summary_update_Click);
            // 
            // summary_delete
            // 
            this.summary_delete.Location = new System.Drawing.Point(482, 295);
            this.summary_delete.Name = "summary_delete";
            this.summary_delete.Size = new System.Drawing.Size(100, 70);
            this.summary_delete.TabIndex = 21;
            this.summary_delete.Text = "Delete";
            this.summary_delete.UseVisualStyleBackColor = true;
            this.summary_delete.Click += new System.EventHandler(this.summary_delete_Click);
            // 
            // summary_edit
            // 
            this.summary_edit.Location = new System.Drawing.Point(313, 295);
            this.summary_edit.Name = "summary_edit";
            this.summary_edit.Size = new System.Drawing.Size(100, 70);
            this.summary_edit.TabIndex = 20;
            this.summary_edit.Text = "Edit";
            this.summary_edit.UseVisualStyleBackColor = true;
            this.summary_edit.Click += new System.EventHandler(this.summary_edit_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.BackgroundColor = System.Drawing.Color.Lavender;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_id,
            this.data_name,
            this.data_amount,
            this.data_date,
            this.data_rep,
            this.data_type});
            this.data.Location = new System.Drawing.Point(0, 21);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(770, 203);
            this.data.TabIndex = 19;
            // 
            // data_id
            // 
            this.data_id.HeaderText = "ID";
            this.data_id.MinimumWidth = 6;
            this.data_id.Name = "data_id";
            this.data_id.Width = 125;
            // 
            // data_name
            // 
            this.data_name.HeaderText = "Name";
            this.data_name.MinimumWidth = 6;
            this.data_name.Name = "data_name";
            this.data_name.ReadOnly = true;
            this.data_name.Width = 125;
            // 
            // data_amount
            // 
            this.data_amount.HeaderText = "Amount";
            this.data_amount.MinimumWidth = 6;
            this.data_amount.Name = "data_amount";
            this.data_amount.ReadOnly = true;
            this.data_amount.Width = 125;
            // 
            // data_date
            // 
            this.data_date.HeaderText = "Date";
            this.data_date.MinimumWidth = 6;
            this.data_date.Name = "data_date";
            this.data_date.ReadOnly = true;
            this.data_date.Width = 125;
            // 
            // data_rep
            // 
            this.data_rep.HeaderText = "Repeating";
            this.data_rep.MinimumWidth = 6;
            this.data_rep.Name = "data_rep";
            this.data_rep.ReadOnly = true;
            this.data_rep.Width = 125;
            // 
            // data_type
            // 
            this.data_type.HeaderText = "Type";
            this.data_type.MinimumWidth = 6;
            this.data_type.Name = "data_type";
            this.data_type.ReadOnly = true;
            this.data_type.Width = 125;
            // 
            // expense_reset
            // 
            this.expense_reset.Location = new System.Drawing.Point(201, 249);
            this.expense_reset.Name = "expense_reset";
            this.expense_reset.Size = new System.Drawing.Size(80, 40);
            this.expense_reset.TabIndex = 17;
            this.expense_reset.Text = "Reset";
            this.expense_reset.UseVisualStyleBackColor = true;
            this.expense_reset.Click += new System.EventHandler(this.expense_reset_Click);
            // 
            // expense_add
            // 
            this.expense_add.Location = new System.Drawing.Point(62, 249);
            this.expense_add.Name = "expense_add";
            this.expense_add.Size = new System.Drawing.Size(80, 40);
            this.expense_add.TabIndex = 16;
            this.expense_add.Text = "Add";
            this.expense_add.UseVisualStyleBackColor = true;
            this.expense_add.Click += new System.EventHandler(this.expense_add_Click);
            // 
            // expense_repeating_checkbox
            // 
            this.expense_repeating_checkbox.AutoSize = true;
            this.expense_repeating_checkbox.Location = new System.Drawing.Point(9, 175);
            this.expense_repeating_checkbox.Name = "expense_repeating_checkbox";
            this.expense_repeating_checkbox.Size = new System.Drawing.Size(95, 21);
            this.expense_repeating_checkbox.TabIndex = 15;
            this.expense_repeating_checkbox.Text = "Repeating";
            this.expense_repeating_checkbox.UseVisualStyleBackColor = true;
            // 
            // expense_amount_field
            // 
            this.expense_amount_field.Location = new System.Drawing.Point(136, 80);
            this.expense_amount_field.Name = "expense_amount_field";
            this.expense_amount_field.Size = new System.Drawing.Size(100, 22);
            this.expense_amount_field.TabIndex = 14;
            // 
            // expense_amount_lab
            // 
            this.expense_amount_lab.AutoSize = true;
            this.expense_amount_lab.Location = new System.Drawing.Point(6, 80);
            this.expense_amount_lab.Name = "expense_amount_lab";
            this.expense_amount_lab.Size = new System.Drawing.Size(44, 17);
            this.expense_amount_lab.TabIndex = 13;
            this.expense_amount_lab.Text = "Value";
            // 
            // expense_date_lab
            // 
            this.expense_date_lab.AutoSize = true;
            this.expense_date_lab.Location = new System.Drawing.Point(6, 124);
            this.expense_date_lab.Name = "expense_date_lab";
            this.expense_date_lab.Size = new System.Drawing.Size(38, 17);
            this.expense_date_lab.TabIndex = 12;
            this.expense_date_lab.Text = "Date";
            // 
            // expense_name_field
            // 
            this.expense_name_field.Location = new System.Drawing.Point(136, 33);
            this.expense_name_field.Name = "expense_name_field";
            this.expense_name_field.Size = new System.Drawing.Size(100, 22);
            this.expense_name_field.TabIndex = 11;
            // 
            // expense_date_picker
            // 
            this.expense_date_picker.Location = new System.Drawing.Point(136, 124);
            this.expense_date_picker.Name = "expense_date_picker";
            this.expense_date_picker.Size = new System.Drawing.Size(200, 22);
            this.expense_date_picker.TabIndex = 10;
            // 
            // expense_name_lab
            // 
            this.expense_name_lab.AutoSize = true;
            this.expense_name_lab.Location = new System.Drawing.Point(6, 36);
            this.expense_name_lab.Name = "expense_name_lab";
            this.expense_name_lab.Size = new System.Drawing.Size(45, 17);
            this.expense_name_lab.TabIndex = 9;
            this.expense_name_lab.Text = "Name";
            // 
            // prediction
            // 
            this.prediction.BackColor = System.Drawing.Color.LightPink;
            this.prediction.Location = new System.Drawing.Point(556, 3);
            this.prediction.Name = "prediction";
            this.prediction.Size = new System.Drawing.Size(130, 50);
            this.prediction.TabIndex = 6;
            this.prediction.Text = "Prediction";
            this.prediction.UseVisualStyleBackColor = false;
            this.prediction.Click += new System.EventHandler(this.prediction_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.settings.Location = new System.Drawing.Point(692, 3);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(96, 50);
            this.settings.TabIndex = 7;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // settings_test
            // 
            this.settings_test.Location = new System.Drawing.Point(81, 36);
            this.settings_test.Name = "settings_test";
            this.settings_test.Size = new System.Drawing.Size(155, 49);
            this.settings_test.TabIndex = 31;
            this.settings_test.Text = "Generate test values";
            this.settings_test.UseVisualStyleBackColor = true;
            this.settings_test.Click += new System.EventHandler(this.settings_test_Click);
            // 
            // settings_test_lab
            // 
            this.settings_test_lab.AutoSize = true;
            this.settings_test_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settings_test_lab.Location = new System.Drawing.Point(269, 52);
            this.settings_test_lab.Name = "settings_test_lab";
            this.settings_test_lab.Size = new System.Drawing.Size(423, 20);
            this.settings_test_lab.TabIndex = 32;
            this.settings_test_lab.Text = "* Warning this action will clear your current data!";
            // 
            // prediction_period_lab
            // 
            this.prediction_period_lab.AutoSize = true;
            this.prediction_period_lab.Location = new System.Drawing.Point(20, 76);
            this.prediction_period_lab.Name = "prediction_period_lab";
            this.prediction_period_lab.Size = new System.Drawing.Size(49, 17);
            this.prediction_period_lab.TabIndex = 33;
            this.prediction_period_lab.Text = "Period";
            // 
            // prediction_amount_lab
            // 
            this.prediction_amount_lab.AutoSize = true;
            this.prediction_amount_lab.Location = new System.Drawing.Point(20, 124);
            this.prediction_amount_lab.Name = "prediction_amount_lab";
            this.prediction_amount_lab.Size = new System.Drawing.Size(56, 17);
            this.prediction_amount_lab.TabIndex = 34;
            this.prediction_amount_lab.Text = "Amount";
            // 
            // prediction_period_combo
            // 
            this.prediction_period_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prediction_period_combo.FormattingEnabled = true;
            this.prediction_period_combo.Items.AddRange(new object[] {
            "months",
            "years"});
            this.prediction_period_combo.Location = new System.Drawing.Point(127, 71);
            this.prediction_period_combo.Name = "prediction_period_combo";
            this.prediction_period_combo.Size = new System.Drawing.Size(121, 24);
            this.prediction_period_combo.TabIndex = 35;
            // 
            // prediction_generate
            // 
            this.prediction_generate.Location = new System.Drawing.Point(239, 121);
            this.prediction_generate.Name = "prediction_generate";
            this.prediction_generate.Size = new System.Drawing.Size(120, 50);
            this.prediction_generate.TabIndex = 37;
            this.prediction_generate.Text = "Predict";
            this.prediction_generate.UseVisualStyleBackColor = true;
            this.prediction_generate.Click += new System.EventHandler(this.prediction_generate_Click);
            // 
            // prediction_total
            // 
            this.prediction_total.Location = new System.Drawing.Point(127, 181);
            this.prediction_total.Name = "prediction_total";
            this.prediction_total.ReadOnly = true;
            this.prediction_total.Size = new System.Drawing.Size(100, 22);
            this.prediction_total.TabIndex = 38;
            // 
            // prediction_amount_field
            // 
            this.prediction_amount_field.Location = new System.Drawing.Point(127, 121);
            this.prediction_amount_field.Name = "prediction_amount_field";
            this.prediction_amount_field.Size = new System.Drawing.Size(100, 22);
            this.prediction_amount_field.TabIndex = 39;
            // 
            // prediction_total_info_lab
            // 
            this.prediction_total_info_lab.AutoSize = true;
            this.prediction_total_info_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prediction_total_info_lab.Location = new System.Drawing.Point(20, 227);
            this.prediction_total_info_lab.Name = "prediction_total_info_lab";
            this.prediction_total_info_lab.Size = new System.Drawing.Size(736, 17);
            this.prediction_total_info_lab.TabIndex = 40;
            this.prediction_total_info_lab.Text = "*Predicted value of all incomes and expenses in selected range that would be adde" +
    "d or removed from your balance.";
            // 
            // prediction_start_m_lab
            // 
            this.prediction_start_m_lab.AutoSize = true;
            this.prediction_start_m_lab.Location = new System.Drawing.Point(20, 37);
            this.prediction_start_m_lab.Name = "prediction_start_m_lab";
            this.prediction_start_m_lab.Size = new System.Drawing.Size(81, 17);
            this.prediction_start_m_lab.TabIndex = 42;
            this.prediction_start_m_lab.Text = "Start month";
            // 
            // prediction_start_m_combo
            // 
            this.prediction_start_m_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prediction_start_m_combo.FormattingEnabled = true;
            this.prediction_start_m_combo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.prediction_start_m_combo.Location = new System.Drawing.Point(127, 33);
            this.prediction_start_m_combo.Name = "prediction_start_m_combo";
            this.prediction_start_m_combo.Size = new System.Drawing.Size(121, 24);
            this.prediction_start_m_combo.TabIndex = 43;
            // 
            // prediction_start_y_lab
            // 
            this.prediction_start_y_lab.AutoSize = true;
            this.prediction_start_y_lab.Location = new System.Drawing.Point(269, 37);
            this.prediction_start_y_lab.Name = "prediction_start_y_lab";
            this.prediction_start_y_lab.Size = new System.Drawing.Size(70, 17);
            this.prediction_start_y_lab.TabIndex = 44;
            this.prediction_start_y_lab.Text = "Start year";
            // 
            // prediction_start_y_field
            // 
            this.prediction_start_y_field.Location = new System.Drawing.Point(370, 34);
            this.prediction_start_y_field.Name = "prediction_start_y_field";
            this.prediction_start_y_field.Size = new System.Drawing.Size(100, 22);
            this.prediction_start_y_field.TabIndex = 45;
            // 
            // prediction_checkbox
            // 
            this.prediction_checkbox.AutoSize = true;
            this.prediction_checkbox.Location = new System.Drawing.Point(273, 75);
            this.prediction_checkbox.Name = "prediction_checkbox";
            this.prediction_checkbox.Size = new System.Drawing.Size(219, 21);
            this.prediction_checkbox.TabIndex = 46;
            this.prediction_checkbox.Text = "Consider non-reapiting items?";
            this.prediction_checkbox.UseVisualStyleBackColor = true;
            // 
            // prediction_reset
            // 
            this.prediction_reset.Location = new System.Drawing.Point(239, 173);
            this.prediction_reset.Name = "prediction_reset";
            this.prediction_reset.Size = new System.Drawing.Size(120, 30);
            this.prediction_reset.TabIndex = 47;
            this.prediction_reset.Text = "reset";
            this.prediction_reset.UseVisualStyleBackColor = true;
            this.prediction_reset.Click += new System.EventHandler(this.prediction_reset_Click);
            // 
            // prediction_total_lab
            // 
            this.prediction_total_lab.AutoSize = true;
            this.prediction_total_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prediction_total_lab.Location = new System.Drawing.Point(71, 184);
            this.prediction_total_lab.Name = "prediction_total_lab";
            this.prediction_total_lab.Size = new System.Drawing.Size(50, 17);
            this.prediction_total_lab.TabIndex = 48;
            this.prediction_total_lab.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.prediction);
            this.Controls.Add(this.chart_button);
            this.Controls.Add(this.summary_button);
            this.Controls.Add(this.expense_button);
            this.Controls.Add(this.income_button);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Budget";
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splinechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barchart)).EndInit();
            this.chart_group.ResumeLayout(false);
            this.chart_group.PerformLayout();
            this.edit_group.ResumeLayout(false);
            this.edit_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button income_button;
        private System.Windows.Forms.Button expense_button;
        private System.Windows.Forms.Button summary_button;
        private System.Windows.Forms.Button chart_button;
        private System.Windows.Forms.Label income_name_lab;
        private System.Windows.Forms.DateTimePicker income_date_picker;
        private System.Windows.Forms.TextBox income_name_field;
        private System.Windows.Forms.Label income_date_lab;
        private System.Windows.Forms.Label income_amount_lab;
        private System.Windows.Forms.TextBox income_amount_field;
        private System.Windows.Forms.CheckBox income_repeating_checkbox;
        private System.Windows.Forms.Button income_add;
        private System.Windows.Forms.Button income_reset;
        private System.Windows.Forms.GroupBox main;
        private System.Windows.Forms.Button expense_reset;
        private System.Windows.Forms.Button expense_add;
        private System.Windows.Forms.CheckBox expense_repeating_checkbox;
        private System.Windows.Forms.TextBox expense_amount_field;
        private System.Windows.Forms.Label expense_amount_lab;
        private System.Windows.Forms.Label expense_date_lab;
        private System.Windows.Forms.TextBox expense_name_field;
        private System.Windows.Forms.DateTimePicker expense_date_picker;
        private System.Windows.Forms.Label expense_name_lab;
        private DataGridView data;
        private Button summary_delete;
        private Button summary_edit;
        private Button summary_update;
        private DataGridViewTextBoxColumn data_id;
        private DataGridViewTextBoxColumn data_name;
        private DataGridViewTextBoxColumn data_amount;
        private DataGridViewTextBoxColumn data_date;
        private DataGridViewCheckBoxColumn data_rep;
        private DataGridViewTextBoxColumn data_type;
        private GroupBox edit_group;
        private Button edit_cancel;
        private Button edit_edit;
        private CheckBox edit_rep;
        private DateTimePicker edit_datepicker;
        private TextBox edit_amount_field;
        private TextBox edit_name_field;
        private Label edit_date_lab;
        private Label edit_amount_lab;
        private Label edit_name_lab;
        private ComboBox edit_combo;
        private Label edit_type_lab;
        private Label summary_total_lab;
        private TextBox summary_total_field;
        private GroupBox chart_group;
        private ComboBox chart_type_combo;
        private Button chart_generate;
        private Label chart_checkbox_lab;
        private Label chart_type_lab;
        private Button prediction;
        private Button settings;
        private System.Windows.Forms.DataVisualization.Charting.Chart barchart;
        private ComboBox chart_include_combo;
        private Button chart_back;
        private System.Windows.Forms.DataVisualization.Charting.Chart splinechart;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private Button settings_test;
        private Label settings_test_lab;
        private Label prediction_total_info_lab;
        private TextBox prediction_amount_field;
        private TextBox prediction_total;
        private Button prediction_generate;
        private ComboBox prediction_period_combo;
        private Label prediction_amount_lab;
        private Label prediction_period_lab;
        private ComboBox prediction_start_m_combo;
        private Label prediction_start_m_lab;
        private TextBox prediction_start_y_field;
        private Label prediction_start_y_lab;
        private CheckBox prediction_checkbox;
        private Label prediction_total_lab;
        private Button prediction_reset;
    }
}

