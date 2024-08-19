namespace UsersWinForm
{
    partial class Pricipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_nuevoUser = new System.Windows.Forms.Button();
            this.l_title = new System.Windows.Forms.Label();
            this.btn_ModifyUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.gb_buttons = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._users_apiDataSet = new UsersWinForm._users_apiDataSet();
            this.usersTableAdapter = new UsersWinForm._users_apiDataSetTableAdapters.UsersTableAdapter();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.l_userid = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._users_apiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nuevoUser
            // 
            this.btn_nuevoUser.Location = new System.Drawing.Point(6, 11);
            this.btn_nuevoUser.Name = "btn_nuevoUser";
            this.btn_nuevoUser.Size = new System.Drawing.Size(127, 107);
            this.btn_nuevoUser.TabIndex = 0;
            this.btn_nuevoUser.Text = "Nuevo";
            this.btn_nuevoUser.UseVisualStyleBackColor = true;
            this.btn_nuevoUser.Click += new System.EventHandler(this.btn_nuevoUser_Click);
            // 
            // l_title
            // 
            this.l_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_title.AutoSize = true;
            this.l_title.Location = new System.Drawing.Point(373, -22);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(166, 16);
            this.l_title.TabIndex = 1;
            this.l_title.Text = "Administrador de Usuarios";
            this.l_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_ModifyUser
            // 
            this.btn_ModifyUser.Location = new System.Drawing.Point(139, 11);
            this.btn_ModifyUser.Name = "btn_ModifyUser";
            this.btn_ModifyUser.Size = new System.Drawing.Size(127, 107);
            this.btn_ModifyUser.TabIndex = 2;
            this.btn_ModifyUser.Text = "Modificar";
            this.btn_ModifyUser.UseVisualStyleBackColor = true;
            this.btn_ModifyUser.Click += new System.EventHandler(this.btn_ModifyUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(272, 11);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(127, 107);
            this.btn_DeleteUser.TabIndex = 3;
            this.btn_DeleteUser.Text = "Eliminar";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // gb_buttons
            // 
            this.gb_buttons.Controls.Add(this.btn_ModifyUser);
            this.gb_buttons.Controls.Add(this.btn_nuevoUser);
            this.gb_buttons.Controls.Add(this.btn_DeleteUser);
            this.gb_buttons.Location = new System.Drawing.Point(644, 324);
            this.gb_buttons.Name = "gb_buttons";
            this.gb_buttons.Size = new System.Drawing.Size(405, 124);
            this.gb_buttons.TabIndex = 5;
            this.gb_buttons.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.Email});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 396);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._users_apiDataSet;
            // 
            // _users_apiDataSet
            // 
            this._users_apiDataSet.DataSetName = "_users_apiDataSet";
            this._users_apiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // txt_userId
            // 
            this.txt_userId.Location = new System.Drawing.Point(650, 141);
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(185, 22);
            this.txt_userId.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(650, 202);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(185, 22);
            this.txt_name.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(650, 264);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(185, 22);
            this.txt_email.TabIndex = 9;
            // 
            // l_userid
            // 
            this.l_userid.AutoSize = true;
            this.l_userid.Location = new System.Drawing.Point(647, 122);
            this.l_userid.Name = "l_userid";
            this.l_userid.Size = new System.Drawing.Size(47, 16);
            this.l_userid.TabIndex = 10;
            this.l_userid.Text = "UserId";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(647, 183);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(44, 16);
            this.l_name.TabIndex = 11;
            this.l_name.Text = "Name";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(647, 245);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(41, 16);
            this.l_email.TabIndex = 12;
            this.l_email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ADMINISTRADOR DE USUARIOS";
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Pricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.l_userid);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_userId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_buttons);
            this.Controls.Add(this.l_title);
            this.Name = "Pricipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pricipal_Load);
            this.gb_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._users_apiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevoUser;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.Button btn_ModifyUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.GroupBox gb_buttons;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _users_apiDataSet _users_apiDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _users_apiDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label l_userid;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

