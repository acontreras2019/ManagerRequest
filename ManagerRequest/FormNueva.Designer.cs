﻿namespace ManagerRequest
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label fechaRespuestaLabel;
            System.Windows.Forms.Label fechaTransaccionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label medioIdLabel;
            System.Windows.Forms.Label receptorLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label usuarioNombreLabel;
            System.Windows.Forms.Label coloniaNombreLabel;
            System.Windows.Forms.Label ciudadNombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNueva));
            this.label1 = new System.Windows.Forms.Label();
            this.listaTransaccionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaTransaccionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripLabel();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.listaCiudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaRespuestaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaTransaccionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.receptorTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
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
            this.descripcionComboBox = new System.Windows.Forms.ComboBox();
            activoLabel = new System.Windows.Forms.Label();
            fechaRespuestaLabel = new System.Windows.Forms.Label();
            fechaTransaccionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            medioIdLabel = new System.Windows.Forms.Label();
            receptorLabel = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(237, 70);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 3;
            activoLabel.Text = "Activo:";
            // 
            // fechaRespuestaLabel
            // 
            fechaRespuestaLabel.AutoSize = true;
            fechaRespuestaLabel.Location = new System.Drawing.Point(12, 192);
            fechaRespuestaLabel.Name = "fechaRespuestaLabel";
            fechaRespuestaLabel.Size = new System.Drawing.Size(94, 13);
            fechaRespuestaLabel.TabIndex = 7;
            fechaRespuestaLabel.Text = "Fecha Respuesta:";
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
            // receptorLabel
            // 
            receptorLabel.AutoSize = true;
            receptorLabel.Location = new System.Drawing.Point(12, 223);
            receptorLabel.Name = "receptorLabel";
            receptorLabel.Size = new System.Drawing.Size(54, 13);
            receptorLabel.TabIndex = 15;
            receptorLabel.Text = "Receptor:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(12, 249);
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
            this.listaTransaccionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaTransaccionBindingNavigator.BindingSource = this.listaTransaccionBindingSource;
            this.listaTransaccionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaTransaccionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.listaTransaccionBindingNavigator.Size = new System.Drawing.Size(593, 25);
            this.listaTransaccionBindingNavigator.TabIndex = 3;
            this.listaTransaccionBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaCiudadBindingSource, "CiudadNombre", true));
            this.activoCheckBox.Location = new System.Drawing.Point(297, 62);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 4;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            this.activoCheckBox.Visible = false;
            // 
            // fechaRespuestaDateTimePicker
            // 
            this.fechaRespuestaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaTransaccionBindingSource, "FechaRespuesta", true));
            this.fechaRespuestaDateTimePicker.Location = new System.Drawing.Point(120, 188);
            this.fechaRespuestaDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.fechaRespuestaDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fechaRespuestaDateTimePicker.Name = "fechaRespuestaDateTimePicker";
            this.fechaRespuestaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaRespuestaDateTimePicker.TabIndex = 8;
            // 
            // fechaTransaccionDateTimePicker
            // 
            this.fechaTransaccionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaTransaccionBindingSource, "FechaTransaccion", true));
            this.fechaTransaccionDateTimePicker.Location = new System.Drawing.Point(120, 153);
            this.fechaTransaccionDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.fechaTransaccionDateTimePicker.MinDate = new System.DateTime(2000, 9, 24, 23, 59, 0, 0);
            this.fechaTransaccionDateTimePicker.Name = "fechaTransaccionDateTimePicker";
            this.fechaTransaccionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaTransaccionDateTimePicker.TabIndex = 10;
            this.fechaTransaccionDateTimePicker.Value = new System.DateTime(2019, 9, 24, 23, 59, 59, 0);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTransaccionBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(120, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(62, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // receptorTextBox
            // 
            this.receptorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTransaccionBindingSource, "Receptor", true));
            this.receptorTextBox.Location = new System.Drawing.Point(120, 220);
            this.receptorTextBox.Name = "receptorTextBox";
            this.receptorTextBox.Size = new System.Drawing.Size(200, 20);
            this.receptorTextBox.TabIndex = 16;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTransaccionBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(120, 246);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 18;
            // 
            // usuarioNombreTextBox
            // 
            this.usuarioNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaTransaccionBindingSource, "UsuarioNombre", true));
            this.usuarioNombreTextBox.Location = new System.Drawing.Point(120, 98);
            this.usuarioNombreTextBox.Name = "usuarioNombreTextBox";
            this.usuarioNombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioNombreTextBox.TabIndex = 22;
            // 
            // coloniaNombreComboBox
            // 
            this.coloniaNombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaColoniaBindingSource, "ColoniaNombre", true));
            this.coloniaNombreComboBox.DataSource = this.listaColoniaBindingSource;
            this.coloniaNombreComboBox.DisplayMember = "ColoniaNombre";
            this.coloniaNombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coloniaNombreComboBox.FormattingEnabled = true;
            this.coloniaNombreComboBox.Location = new System.Drawing.Point(450, 133);
            this.coloniaNombreComboBox.Name = "coloniaNombreComboBox";
            this.coloniaNombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.coloniaNombreComboBox.TabIndex = 23;
            this.coloniaNombreComboBox.ValueMember = "ColoniaNombre";
            // 
            // ciudadNombreComboBox
            // 
            this.ciudadNombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCiudadBindingSource, "CiudadNombre", true));
            this.ciudadNombreComboBox.DataSource = this.listaCiudadBindingSource;
            this.ciudadNombreComboBox.DisplayMember = "CiudadNombre";
            this.ciudadNombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadNombreComboBox.FormattingEnabled = true;
            this.ciudadNombreComboBox.Location = new System.Drawing.Point(448, 95);
            this.ciudadNombreComboBox.Name = "ciudadNombreComboBox";
            this.ciudadNombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.ciudadNombreComboBox.TabIndex = 24;
            this.ciudadNombreComboBox.ValueMember = "CiudadNombre";
            // 
            // listaAsuntosListBox
            // 
            this.listaAsuntosListBox.DataSource = this.listaAsuntosBindingSource;
            this.listaAsuntosListBox.DisplayMember = "Descripcion";
            this.listaAsuntosListBox.FormattingEnabled = true;
            this.listaAsuntosListBox.Location = new System.Drawing.Point(20, 272);
            this.listaAsuntosListBox.MultiColumn = true;
            this.listaAsuntosListBox.Name = "listaAsuntosListBox";
            this.listaAsuntosListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listaAsuntosListBox.Size = new System.Drawing.Size(551, 30);
            this.listaAsuntosListBox.TabIndex = 24;
            this.listaAsuntosListBox.ValueMember = "Activo";
            // 
            // listamedioBindingSource
            // 
            this.listamedioBindingSource.DataSource = typeof(Denuncias.BL.TipoMedio);
            // 
            // descripcionComboBox
            // 
            this.descripcionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listamedioBindingSource, "Id", true));
            this.descripcionComboBox.DataSource = this.listamedioBindingSource;
            this.descripcionComboBox.DisplayMember = "Descripcion";
            this.descripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descripcionComboBox.FormattingEnabled = true;
            this.descripcionComboBox.Location = new System.Drawing.Point(120, 124);
            this.descripcionComboBox.Name = "descripcionComboBox";
            this.descripcionComboBox.Size = new System.Drawing.Size(200, 21);
            this.descripcionComboBox.TabIndex = 25;
            this.descripcionComboBox.ValueMember = "Id";
            // 
            // FormNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 671);
            this.Controls.Add(this.descripcionComboBox);
            this.Controls.Add(this.listaAsuntosListBox);
            this.Controls.Add(ciudadNombreLabel);
            this.Controls.Add(this.ciudadNombreComboBox);
            this.Controls.Add(coloniaNombreLabel);
            this.Controls.Add(this.coloniaNombreComboBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(fechaRespuestaLabel);
            this.Controls.Add(this.fechaRespuestaDateTimePicker);
            this.Controls.Add(fechaTransaccionLabel);
            this.Controls.Add(this.fechaTransaccionDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(medioIdLabel);
            this.Controls.Add(receptorLabel);
            this.Controls.Add(this.receptorTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource listaTransaccionBindingSource;
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
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaRespuestaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaTransaccionDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox receptorTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
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
        private System.Windows.Forms.ComboBox descripcionComboBox;
    }
}