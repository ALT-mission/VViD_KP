namespace VViD
{
    partial class F_task
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startrouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endRouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approveUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAproveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kP_TagmetDataSet1 = new VViD.KP_TagmetDataSet();
            this.v_TasksTableAdapter = new VViD.KP_TagmetDataSetTableAdapters.v_TasksTableAdapter();
            this.CB_St = new System.Windows.Forms.ComboBox();
            this.CB_TC = new System.Windows.Forms.ComboBox();
            this.CB_Fio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_add = new System.Windows.Forms.Button();
            this.Bt_Ed = new System.Windows.Forms.Button();
            this.Bt_Del = new System.Windows.Forms.Button();
            this.Bt_aprove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Et = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kP_TagmetDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.tMDataGridViewTextBoxColumn,
            this.regNumDataGridViewTextBoxColumn,
            this.startrouteDataGridViewTextBoxColumn,
            this.endRouteDataGridViewTextBoxColumn,
            this.CreateUser,
            this.CreateDate,
            this.approveUserDataGridViewTextBoxColumn,
            this.dateAproveDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Номер заявки";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tMDataGridViewTextBoxColumn
            // 
            this.tMDataGridViewTextBoxColumn.DataPropertyName = "T_M";
            this.tMDataGridViewTextBoxColumn.HeaderText = "Транспортное средство";
            this.tMDataGridViewTextBoxColumn.Name = "tMDataGridViewTextBoxColumn";
            this.tMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regNumDataGridViewTextBoxColumn
            // 
            this.regNumDataGridViewTextBoxColumn.DataPropertyName = "RegNum";
            this.regNumDataGridViewTextBoxColumn.HeaderText = "Номер ТС";
            this.regNumDataGridViewTextBoxColumn.Name = "regNumDataGridViewTextBoxColumn";
            this.regNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startrouteDataGridViewTextBoxColumn
            // 
            this.startrouteDataGridViewTextBoxColumn.DataPropertyName = "Startroute";
            this.startrouteDataGridViewTextBoxColumn.HeaderText = "Начало маршрута";
            this.startrouteDataGridViewTextBoxColumn.Name = "startrouteDataGridViewTextBoxColumn";
            this.startrouteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endRouteDataGridViewTextBoxColumn
            // 
            this.endRouteDataGridViewTextBoxColumn.DataPropertyName = "EndRoute";
            this.endRouteDataGridViewTextBoxColumn.HeaderText = "Конец маршрута";
            this.endRouteDataGridViewTextBoxColumn.Name = "endRouteDataGridViewTextBoxColumn";
            this.endRouteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CreateUser
            // 
            this.CreateUser.DataPropertyName = "CreateUser";
            this.CreateUser.HeaderText = "Автор заявки";
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Дата создания";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // approveUserDataGridViewTextBoxColumn
            // 
            this.approveUserDataGridViewTextBoxColumn.DataPropertyName = "ApproveUser";
            this.approveUserDataGridViewTextBoxColumn.HeaderText = "Оператор подтверждения";
            this.approveUserDataGridViewTextBoxColumn.Name = "approveUserDataGridViewTextBoxColumn";
            this.approveUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAproveDataGridViewTextBoxColumn
            // 
            this.dateAproveDataGridViewTextBoxColumn.DataPropertyName = "DateAprove";
            this.dateAproveDataGridViewTextBoxColumn.HeaderText = "Дата подтверждения";
            this.dateAproveDataGridViewTextBoxColumn.Name = "dateAproveDataGridViewTextBoxColumn";
            this.dateAproveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "v_Tasks";
            this.bindingSource1.DataSource = this.kP_TagmetDataSet1;
            // 
            // kP_TagmetDataSet1
            // 
            this.kP_TagmetDataSet1.DataSetName = "KP_TagmetDataSet";
            this.kP_TagmetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_TasksTableAdapter
            // 
            this.v_TasksTableAdapter.ClearBeforeFill = true;
            // 
            // CB_St
            // 
            this.CB_St.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_St.FormattingEnabled = true;
            this.CB_St.Location = new System.Drawing.Point(595, 350);
            this.CB_St.Name = "CB_St";
            this.CB_St.Size = new System.Drawing.Size(121, 21);
            this.CB_St.TabIndex = 1;
            // 
            // CB_TC
            // 
            this.CB_TC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_TC.FormattingEnabled = true;
            this.CB_TC.Location = new System.Drawing.Point(324, 350);
            this.CB_TC.Name = "CB_TC";
            this.CB_TC.Size = new System.Drawing.Size(190, 21);
            this.CB_TC.TabIndex = 2;
            // 
            // CB_Fio
            // 
            this.CB_Fio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Fio.FormattingEnabled = true;
            this.CB_Fio.Location = new System.Drawing.Point(53, 350);
            this.CB_Fio.Name = "CB_Fio";
            this.CB_Fio.Size = new System.Drawing.Size(221, 21);
            this.CB_Fio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ТС";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Начало пути";
            // 
            // Bt_add
            // 
            this.Bt_add.Location = new System.Drawing.Point(972, 348);
            this.Bt_add.Name = "Bt_add";
            this.Bt_add.Size = new System.Drawing.Size(126, 23);
            this.Bt_add.TabIndex = 7;
            this.Bt_add.Text = "Добавить заявку";
            this.Bt_add.UseVisualStyleBackColor = true;
            // 
            // Bt_Ed
            // 
            this.Bt_Ed.Location = new System.Drawing.Point(15, 12);
            this.Bt_Ed.Name = "Bt_Ed";
            this.Bt_Ed.Size = new System.Drawing.Size(146, 23);
            this.Bt_Ed.TabIndex = 8;
            this.Bt_Ed.Text = "Редактировать заявку";
            this.Bt_Ed.UseVisualStyleBackColor = true;
            // 
            // Bt_Del
            // 
            this.Bt_Del.Location = new System.Drawing.Point(194, 12);
            this.Bt_Del.Name = "Bt_Del";
            this.Bt_Del.Size = new System.Drawing.Size(139, 23);
            this.Bt_Del.TabIndex = 9;
            this.Bt_Del.Text = "Отменить заявку";
            this.Bt_Del.UseVisualStyleBackColor = true;
            // 
            // Bt_aprove
            // 
            this.Bt_aprove.Location = new System.Drawing.Point(368, 12);
            this.Bt_aprove.Name = "Bt_aprove";
            this.Bt_aprove.Size = new System.Drawing.Size(146, 23);
            this.Bt_aprove.TabIndex = 10;
            this.Bt_aprove.Text = "Подтвердить заявку";
            this.Bt_aprove.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Конец пути";
            // 
            // CB_Et
            // 
            this.CB_Et.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Et.FormattingEnabled = true;
            this.CB_Et.Location = new System.Drawing.Point(797, 350);
            this.CB_Et.Name = "CB_Et";
            this.CB_Et.Size = new System.Drawing.Size(121, 21);
            this.CB_Et.TabIndex = 11;
            // 
            // F_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Et);
            this.Controls.Add(this.Bt_aprove);
            this.Controls.Add(this.Bt_Del);
            this.Controls.Add(this.Bt_Ed);
            this.Controls.Add(this.Bt_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Fio);
            this.Controls.Add(this.CB_TC);
            this.Controls.Add(this.CB_St);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1126, 700);
            this.MinimumSize = new System.Drawing.Size(1126, 427);
            this.Name = "F_task";
            this.Text = "Просмотр Заявок";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kP_TagmetDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private KP_TagmetDataSet kP_TagmetDataSet1;
        private KP_TagmetDataSetTableAdapters.v_TasksTableAdapter v_TasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startrouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn approveUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAproveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CB_St;
        private System.Windows.Forms.ComboBox CB_TC;
        private System.Windows.Forms.ComboBox CB_Fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_add;
        private System.Windows.Forms.Button Bt_Ed;
        private System.Windows.Forms.Button Bt_Del;
        private System.Windows.Forms.Button Bt_aprove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Et;
    }
}

