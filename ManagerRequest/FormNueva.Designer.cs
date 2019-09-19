namespace ManagerRequest
{
    partial class FormNueva
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
            System.Windows.Forms.Label fechaTransaccionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label medioIdLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label usuarioNombreLabel;
            System.Windows.Forms.Label coloniaNombreLabel;
            System.Windows.Forms.Label ciudadNombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNueva));
            this.label1 = new System.Windows.Forms.Label();
            this.listaTransaccionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaTransaccionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripLabel();
            this.listaCiudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaTransaccionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.usuarioNombreTextBox = new System.Windows.Forms.TextBox();
            this.listaAsuntosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listatipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaColoniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coloniaNombreComboBox = new System.Windows.Forms.ComboBox();
            this.ciudadNombreComboBox = new System.Windows.Forms.ComboBox();
            this.documentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaAsuntosListBox = new System.Windows.Forms.ListBox();
            this.listamedioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listamedioComboBox = new System.Windows.Forms.ComboBox();
            this.listasolicitantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listasolicitantesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listaEstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fechaTransaccionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            medioIdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            usuarioNombreLabel = new System.Windows.Forms.Label();
            coloniaNombreLabel = new System.Windows.Forms.Label();
            ciudadNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaTransaccionBindingNavigator)).BeginInit();
            this.listaTransaccionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCiudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAsuntosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listatipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaColoniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listamedioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasolicitantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaTransaccionLabel
            // 
            fechaTransaccionLabel.AutoSize = true;
            fechaTransaccionLabel.Location = new System.Drawing.Point(12, 157);
            fechaTransaccionLabel.Name = "fechaTransaccionLabel";
            fechaTransaccionLabel.Size = new System.Drawing.Size(102, 13);
            fechaTransaccionLabel.TabIndex = 9;
            fechaTransaccionLabel.Text = "Fecha Transaccion:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 73);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // medioIdLabel
            // 
            medioIdLabel.AutoSize = true;
            medioIdLabel.Location = new System.Drawing.Point(12, 132);
            medioIdLabel.Name = "medioIdLabel";
            medioIdLabel.Size = new System.Drawing.Size(51, 13);
            medioIdLabel.TabIndex = 13;
            medioIdLabel.Text = "Medio Id:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(23, 254);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 17;
            statusLabel.Text = "Status:";
            // 
            // usuarioNombreLabel
            // 
            usuarioNombreLabel.AutoSize = true;
            usuarioNombreLabel.Location = new System.Drawing.Point(12, 101);
            usuarioNombreLabel.Name = "usuarioNombreLabel";
            usuarioNombreLabel.Size = new System.Drawing.Size(86, 13);
            usuarioNombreLabel.TabIndex = 21;
            usuarioNombreLabel.Text = "Usuario Nombre:";
            // 
            // coloniaNombreLabel
            // 
            coloniaNombreLabel.AutoSize = true;
            coloniaNombreLabel.Location = new System.Drawing.Point(359, 136);
            coloniaNombreLabel.Name = "coloniaNombreLabel";
            coloniaNombreLabel.Size = new System.Drawing.Size(85, 13);
            coloniaNombreLabel.TabIndex = 22;
            coloniaNombreLabel.Text = "Colonia Nombre:";
            // 
            // ciudadNombreLabel
            // 
            ciudadNombreLabel.AutoSize = true;
            ciudadNombreLabel.Location = new System.Drawing.Point(359, 98);
            ciudadNombreLabel.Name = "ciudadNombreLabel";
            ciudadNombreLabel.Size = new System.Drawing.Size(83, 13);
            ciudadNombreLabel.TabIndex = 23;
            ciudadNombreLabel.Text = "Ciudad Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Documento";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listaTransaccionBindingNavigator
            // 
            this.listaTransaccionBindingNavigator.AddNewItem = null;
            this.listaTransaccionBindingNavigator.BindingSource = this.listaTransaccionBindingSource;
            this.listaTransaccionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaTransaccionBindingNavigator.DeleteItem = null;
            this.listaTransaccionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaTransaccionBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaTransaccionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaTransaccionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaTransaccionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaTransaccionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaTransaccionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaTransaccionBindingNavigator.Name = "listaTransaccionBindingNavigator";
            this.listaTransaccionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaTransaccionBindingNavigator.Size = new System.Drawing.Size(725, 25);
            this.listaTransaccionBindingNavigator.TabIndex = 3;
            this.listaTransaccionBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaTransaccionBindingSource
            // 
           
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaTransaccionBindingNavigatorSaveItem
            // 
            this.listaTransaccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaTransaccionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaTransaccionBindingNavigatorSaveItem.Image")));
            this.listaTransaccionBindingNavigatorSaveItem.Name = "listaTransaccionBindingNavigatorSaveItem";
            this.listaTransaccionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaTransaccionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaTransaccionBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaTransaccionBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click_1);
            // 
            // listaCiudadBindingSource
            // 
            this.listaCiudadBindingSource.DataSource = typeof(Denuncias.BL.Ciudad);
            // 
            // fechaTransaccionDateTimePicker
            // 
            this.fechaTransaccionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaTransaccionBindingSource, "FechaTransaccion", true));
            this.fechaTransaccionDateTimePicker.Location = new System.Drawing.Point(120, 153);
            this.fechaTransaccionDateTimePicker.Name = "fechaTransaccionDateTimePicker";
            this.fechaTransaccionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaTransaccionDateTimePicker.TabIndex = 10;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTransaccionBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(120, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(62, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // usuarioNombreTextBox
            // 
            this.usuarioNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTransaccionBindingSource, "UsuarioNombre", true));
            this.usuarioNombreTextBox.Location = new System.Drawing.Point(120, 98);
            this.usuarioNombreTextBox.Name = "usuarioNombreTextBox";
            this.usuarioNombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioNombreTextBox.TabIndex = 22;
            // 
            // listaAsuntosBindingSource
            // 
            this.listaAsuntosBindingSource.DataSource = typeof(Denuncias.BL.Asunto);
            // 
            // listatipoDocumentoBindingSource
            // 
            this.listatipoDocumentoBindingSource.DataSource = typeof(Denuncias.BL.TipodeDocumento);
            // 
            // listaColoniaBindingSource
            // 
            this.listaColoniaBindingSource.DataSource = typeof(Denuncias.BL.Colonia);
            // 
            // coloniaNombreComboBox
            // 
            this.coloniaNombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTransaccionBindingSource, "ColoniaId", true));
            this.coloniaNombreComboBox.DataSource = this.listaColoniaBindingSource;
            this.coloniaNombreComboBox.DisplayMember = "ColoniaNombre";
            this.coloniaNombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coloniaNombreComboBox.FormattingEnabled = true;
            this.coloniaNombreComboBox.Location = new System.Drawing.Point(450, 133);
            this.coloniaNombreComboBox.Name = "coloniaNombreComboBox";
            this.coloniaNombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.coloniaNombreComboBox.TabIndex = 23;
            this.coloniaNombreComboBox.ValueMember = "Id";
            // 
            // ciudadNombreComboBox
            // 
            this.ciudadNombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTransaccionBindingSource, "CiudadId", true));
            this.ciudadNombreComboBox.DataSource = this.listaCiudadBindingSource;
            this.ciudadNombreComboBox.DisplayMember = "CiudadNombre";
            this.ciudadNombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadNombreComboBox.FormattingEnabled = true;
            this.ciudadNombreComboBox.Location = new System.Drawing.Point(448, 95);
            this.ciudadNombreComboBox.Name = "ciudadNombreComboBox";
            this.ciudadNombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.ciudadNombreComboBox.TabIndex = 24;
            this.ciudadNombreComboBox.ValueMember = "Id";
            // 
            // documentoBindingSource
            // 
            this.documentoBindingSource.DataSource = typeof(Denuncias.BL.Documento);
            // 
            // listaUsuariosBindingSource
            // 
            this.listaUsuariosBindingSource.DataSource = typeof(Denuncias.BL.Usuario);
            // 
            // listaAsuntosListBox
            // 
            this.listaAsuntosListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTransaccionBindingSource, "AsuntoId", true));
            this.listaAsuntosListBox.DataSource = this.listaAsuntosBindingSource;
            this.listaAsuntosListBox.DisplayMember = "Descripcion";
            this.listaAsuntosListBox.FormattingEnabled = true;
            this.listaAsuntosListBox.Location = new System.Drawing.Point(12, 294);
            this.listaAsuntosListBox.MultiColumn = true;
            this.listaAsuntosListBox.Name = "listaAsuntosListBox";
            this.listaAsuntosListBox.Size = new System.Drawing.Size(551, 69);
            this.listaAsuntosListBox.TabIndex = 24;
            this.listaAsuntosListBox.ValueMember = "Id";
            // 
            // listamedioBindingSource
            // 
            this.listamedioBindingSource.DataSource = typeof(Denuncias.BL.TipoMedio);
            // 
            // listamedioComboBox
            // 
            this.listamedioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTransaccionBindingSource, "TipoMedioId", true));
            this.listamedioComboBox.DataSource = this.listamedioBindingSource;
            this.listamedioComboBox.DisplayMember = "Descripcion";
            this.listamedioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listamedioComboBox.FormattingEnabled = true;
            this.listamedioComboBox.Location = new System.Drawing.Point(120, 126);
            this.listamedioComboBox.Name = "listamedioComboBox";
            this.listamedioComboBox.Size = new System.Drawing.Size(200, 21);
            this.listamedioComboBox.TabIndex = 24;
            this.listamedioComboBox.ValueMember = "Id";
            // 
            // listasolicitantesBindingSource
            // 
            this.listasolicitantesBindingSource.DataSource = typeof(Denuncias.BL.TipoSolicitante);
            // 
            // listasolicitantesComboBox
            // 
            this.listasolicitantesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTransaccionBindingSource, "TipoSolicitanteId", true));
            this.listasolicitantesComboBox.DataSource = this.listasolicitantesBindingSource;
            this.listasolicitantesComboBox.DisplayMember = "Descripcion";
            this.listasolicitantesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listasolicitantesComboBox.FormattingEnabled = true;
            this.listasolicitantesComboBox.Location = new System.Drawing.Point(120, 214);
            this.listasolicitantesComboBox.Name = "listasolicitantesComboBox";
            this.listasolicitantesComboBox.Size = new System.Drawing.Size(200, 21);
            this.listasolicitantesComboBox.TabIndex = 24;
            this.listasolicitantesComboBox.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo Solicitante:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaTransaccionBindingSource, "EstatusId", true));
            this.comboBox1.DataSource = this.listaEstatusBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "Id";
            // 
            // listaEstatusBindingSource
            // 
            this.listaEstatusBindingSource.DataSource = typeof(Denuncias.BL.Estatus);
            // 
            // FormNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 404);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listasolicitantesComboBox);
            this.Controls.Add(this.listamedioComboBox);
            this.Controls.Add(this.listaAsuntosListBox);
            this.Controls.Add(ciudadNombreLabel);
            this.Controls.Add(this.ciudadNombreComboBox);
            this.Controls.Add(coloniaNombreLabel);
            this.Controls.Add(this.coloniaNombreComboBox);
            this.Controls.Add(fechaTransaccionLabel);
            this.Controls.Add(this.fechaTransaccionDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(medioIdLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(usuarioNombreLabel);
            this.Controls.Add(this.usuarioNombreTextBox);
            this.Controls.Add(this.listaTransaccionBindingNavigator);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNueva";
            this.Text = "Nueva Solicitud";
            this.Load += new System.EventHandler(this.FormNueva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaTransaccionBindingNavigator)).EndInit();
            this.listaTransaccionBindingNavigator.ResumeLayout(false);
            this.listaTransaccionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCiudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAsuntosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listatipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaColoniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listamedioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasolicitantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator listaTransaccionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaTransaccionBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker fechaTransaccionDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox usuarioNombreTextBox;
        private System.Windows.Forms.BindingSource listaAsuntosBindingSource;
        private System.Windows.Forms.BindingSource listatipoDocumentoBindingSource;
        private System.Windows.Forms.BindingSource listaColoniaBindingSource;
        private System.Windows.Forms.ComboBox coloniaNombreComboBox;
        private System.Windows.Forms.BindingSource listaCiudadBindingSource;
        private System.Windows.Forms.ComboBox ciudadNombreComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripButtonCancelar;
        private System.Windows.Forms.BindingSource documentoBindingSource;
        private System.Windows.Forms.BindingSource listaUsuariosBindingSource;
        private System.Windows.Forms.ListBox listaAsuntosListBox;
        private System.Windows.Forms.BindingSource listamedioBindingSource;
        private System.Windows.Forms.ComboBox listamedioComboBox;
        private System.Windows.Forms.BindingSource listaTransaccionBindingSource;
        private System.Windows.Forms.BindingSource listasolicitantesBindingSource;
        private System.Windows.Forms.ComboBox listasolicitantesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource listaEstatusBindingSource;
    }
}