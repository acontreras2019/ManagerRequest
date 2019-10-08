namespace ManagerRequest
{
    partial class FormBarriosyColonias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarriosyColonias));
            System.Windows.Forms.Label coloniaNombreLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label sectorLabel;
            this.listaColoniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaColoniaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaColoniaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coloniaNombreTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.sectorTextBox = new System.Windows.Forms.TextBox();
            coloniaNombreLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            sectorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaColoniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaColoniaBindingNavigator)).BeginInit();
            this.listaColoniaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaColoniaBindingSource
            // 
            this.listaColoniaBindingSource.DataSource = typeof(Denuncias.BL.Colonia);
            // 
            // listaColoniaBindingNavigator
            // 
            this.listaColoniaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaColoniaBindingNavigator.BindingSource = this.listaColoniaBindingSource;
            this.listaColoniaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaColoniaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaColoniaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.listaColoniaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaColoniaBindingNavigatorSaveItem});
            this.listaColoniaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaColoniaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaColoniaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaColoniaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaColoniaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaColoniaBindingNavigator.Name = "listaColoniaBindingNavigator";
            this.listaColoniaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaColoniaBindingNavigator.Size = new System.Drawing.Size(503, 31);
            this.listaColoniaBindingNavigator.TabIndex = 0;
            this.listaColoniaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // listaColoniaBindingNavigatorSaveItem
            // 
            this.listaColoniaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaColoniaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaColoniaBindingNavigatorSaveItem.Image")));
            this.listaColoniaBindingNavigatorSaveItem.Name = "listaColoniaBindingNavigatorSaveItem";
            this.listaColoniaBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.listaColoniaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaColoniaBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaColoniaBindingNavigatorSaveItem_Click);
            // 
            // coloniaNombreLabel
            // 
            coloniaNombreLabel.AutoSize = true;
            coloniaNombreLabel.Location = new System.Drawing.Point(70, 152);
            coloniaNombreLabel.Name = "coloniaNombreLabel";
            coloniaNombreLabel.Size = new System.Drawing.Size(125, 20);
            coloniaNombreLabel.TabIndex = 1;
            coloniaNombreLabel.Text = "Barrio o Colonia:";
            // 
            // coloniaNombreTextBox
            // 
            this.coloniaNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaColoniaBindingSource, "ColoniaNombre", true));
            this.coloniaNombreTextBox.Location = new System.Drawing.Point(202, 149);
            this.coloniaNombreTextBox.Name = "coloniaNombreTextBox";
            this.coloniaNombreTextBox.Size = new System.Drawing.Size(223, 26);
            this.coloniaNombreTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(70, 114);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaColoniaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(202, 111);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(34, 26);
            this.idTextBox.TabIndex = 4;
            // 
            // sectorLabel
            // 
            sectorLabel.AutoSize = true;
            sectorLabel.Location = new System.Drawing.Point(70, 189);
            sectorLabel.Name = "sectorLabel";
            sectorLabel.Size = new System.Drawing.Size(60, 20);
            sectorLabel.TabIndex = 5;
            sectorLabel.Text = "Sector:";
            // 
            // sectorTextBox
            // 
            this.sectorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaColoniaBindingSource, "Sector", true));
            this.sectorTextBox.Location = new System.Drawing.Point(202, 186);
            this.sectorTextBox.Name = "sectorTextBox";
            this.sectorTextBox.Size = new System.Drawing.Size(74, 26);
            this.sectorTextBox.TabIndex = 6;
            // 
            // FormBarriosyColonias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 277);
            this.Controls.Add(coloniaNombreLabel);
            this.Controls.Add(this.coloniaNombreTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(sectorLabel);
            this.Controls.Add(this.sectorTextBox);
            this.Controls.Add(this.listaColoniaBindingNavigator);
            this.Name = "FormBarriosyColonias";
            this.Text = "FormBarriosyColonias";
            ((System.ComponentModel.ISupportInitialize)(this.listaColoniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaColoniaBindingNavigator)).EndInit();
            this.listaColoniaBindingNavigator.ResumeLayout(false);
            this.listaColoniaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaColoniaBindingSource;
        private System.Windows.Forms.BindingNavigator listaColoniaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaColoniaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox coloniaNombreTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox sectorTextBox;
    }
}