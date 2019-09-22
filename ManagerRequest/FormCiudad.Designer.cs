namespace ManagerRequest
{
    partial class FormCiudad
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
            System.Windows.Forms.Label ciudadNombreLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label paisNombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCiudad));
            this.listaCiudadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaCiudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listaCiudadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.ciudadNombreTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.paisNombreTextBox = new System.Windows.Forms.TextBox();
            ciudadNombreLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            paisNombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCiudadBindingNavigator)).BeginInit();
            this.listaCiudadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCiudadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ciudadNombreLabel
            // 
            ciudadNombreLabel.AutoSize = true;
            ciudadNombreLabel.Location = new System.Drawing.Point(23, 102);
            ciudadNombreLabel.Name = "ciudadNombreLabel";
            ciudadNombreLabel.Size = new System.Drawing.Size(46, 13);
            ciudadNombreLabel.TabIndex = 1;
            ciudadNombreLabel.Text = "Ciudad :";
            ciudadNombreLabel.Click += new System.EventHandler(this.ciudadNombreLabel_Click);
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(23, 72);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 3;
            codigoLabel.Text = "Codigo:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 42);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // paisNombreLabel
            // 
            paisNombreLabel.AutoSize = true;
            paisNombreLabel.Location = new System.Drawing.Point(23, 133);
            paisNombreLabel.Name = "paisNombreLabel";
            paisNombreLabel.Size = new System.Drawing.Size(33, 13);
            paisNombreLabel.TabIndex = 7;
            paisNombreLabel.Text = "Pais :";
            // 
            // listaCiudadBindingNavigator
            // 
            this.listaCiudadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaCiudadBindingNavigator.BindingSource = this.listaCiudadBindingSource;
            this.listaCiudadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaCiudadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaCiudadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaCiudadBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaCiudadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaCiudadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaCiudadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaCiudadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaCiudadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaCiudadBindingNavigator.Name = "listaCiudadBindingNavigator";
            this.listaCiudadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaCiudadBindingNavigator.Size = new System.Drawing.Size(355, 25);
            this.listaCiudadBindingNavigator.TabIndex = 0;
            this.listaCiudadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // listaCiudadBindingSource
            // 
            this.listaCiudadBindingSource.DataSource = typeof(Denuncias.BL.Ciudad);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaCiudadBindingNavigatorSaveItem
            // 
            this.listaCiudadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaCiudadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaCiudadBindingNavigatorSaveItem.Image")));
            this.listaCiudadBindingNavigatorSaveItem.Name = "listaCiudadBindingNavigatorSaveItem";
            this.listaCiudadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaCiudadBindingNavigatorSaveItem.Text = "Save Data";
            this.listaCiudadBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaCiudadBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // ciudadNombreTextBox
            // 
            this.ciudadNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCiudadBindingSource, "CiudadNombre", true));
            this.ciudadNombreTextBox.Location = new System.Drawing.Point(112, 99);
            this.ciudadNombreTextBox.Name = "ciudadNombreTextBox";
            this.ciudadNombreTextBox.Size = new System.Drawing.Size(172, 20);
            this.ciudadNombreTextBox.TabIndex = 2;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCiudadBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(112, 69);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCiudadBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(112, 39);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // paisNombreTextBox
            // 
            this.paisNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCiudadBindingSource, "PaisNombre", true));
            this.paisNombreTextBox.Location = new System.Drawing.Point(112, 130);
            this.paisNombreTextBox.Name = "paisNombreTextBox";
            this.paisNombreTextBox.Size = new System.Drawing.Size(172, 20);
            this.paisNombreTextBox.TabIndex = 8;
            // 
            // FormCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 207);
            this.Controls.Add(ciudadNombreLabel);
            this.Controls.Add(this.ciudadNombreTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(paisNombreLabel);
            this.Controls.Add(this.paisNombreTextBox);
            this.Controls.Add(this.listaCiudadBindingNavigator);
            this.Name = "FormCiudad";
            this.Text = "FormCiudad";
            this.Load += new System.EventHandler(this.FormCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCiudadBindingNavigator)).EndInit();
            this.listaCiudadBindingNavigator.ResumeLayout(false);
            this.listaCiudadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCiudadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaCiudadBindingSource;
        private System.Windows.Forms.BindingNavigator listaCiudadBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaCiudadBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ciudadNombreTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox paisNombreTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}