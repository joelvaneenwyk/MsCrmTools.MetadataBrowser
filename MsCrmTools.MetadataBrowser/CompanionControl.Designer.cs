﻿
namespace MsCrmTools.MetadataBrowser
{
    partial class CompanionControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanionControl));
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.chkKeys = new System.Windows.Forms.CheckBox();
            this.chkRels = new System.Windows.Forms.CheckBox();
            this.chkColumns = new System.Windows.Forms.CheckBox();
            this.chkEntities = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbSearchResult = new System.Windows.Forms.GroupBox();
            this.lvSearchResult = new System.Windows.Forms.ListView();
            this.chLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbProperties = new System.Windows.Forms.GroupBox();
            this.scProperties = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.pgOptionSetValues = new System.Windows.Forms.PropertyGrid();
            this.cmsPicklist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDisplayNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.cmsMetadata = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMenuTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTableCopyLogicalName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTableCopyLogicalCollectionName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTableCopySchemaName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenuColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColumnCopyLogicalName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColumnCopySchemaName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColumnCopyWabApiLookupName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenuRel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelCopyParentNavigation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelCopyChildNavigation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelCopySchemaName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelCopyParentNavigationWithBinding = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearch.SuspendLayout();
            this.gbSearchResult.SuspendLayout();
            this.gbProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scProperties)).BeginInit();
            this.scProperties.Panel1.SuspendLayout();
            this.scProperties.Panel2.SuspendLayout();
            this.scProperties.SuspendLayout();
            this.cmsPicklist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.cmsMetadata.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.chkKeys);
            this.gbSearch.Controls.Add(this.chkRels);
            this.gbSearch.Controls.Add(this.chkColumns);
            this.gbSearch.Controls.Add(this.chkEntities);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(421, 89);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search metadata";
            // 
            // chkKeys
            // 
            this.chkKeys.AutoSize = true;
            this.chkKeys.Checked = true;
            this.chkKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeys.Location = new System.Drawing.Point(334, 57);
            this.chkKeys.Name = "chkKeys";
            this.chkKeys.Size = new System.Drawing.Size(69, 24);
            this.chkKeys.TabIndex = 4;
            this.chkKeys.Text = "Keys";
            this.chkKeys.UseVisualStyleBackColor = true;
            this.chkKeys.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkEntities_MouseClick);
            // 
            // chkRels
            // 
            this.chkRels.AutoSize = true;
            this.chkRels.Checked = true;
            this.chkRels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRels.Location = new System.Drawing.Point(197, 57);
            this.chkRels.Name = "chkRels";
            this.chkRels.Size = new System.Drawing.Size(131, 24);
            this.chkRels.TabIndex = 3;
            this.chkRels.Text = "Relationships";
            this.chkRels.UseVisualStyleBackColor = true;
            this.chkRels.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkEntities_MouseClick);
            // 
            // chkColumns
            // 
            this.chkColumns.AutoSize = true;
            this.chkColumns.Checked = true;
            this.chkColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColumns.Location = new System.Drawing.Point(94, 57);
            this.chkColumns.Name = "chkColumns";
            this.chkColumns.Size = new System.Drawing.Size(97, 24);
            this.chkColumns.TabIndex = 2;
            this.chkColumns.Text = "Columns";
            this.chkColumns.UseVisualStyleBackColor = true;
            this.chkColumns.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkEntities_MouseClick);
            // 
            // chkEntities
            // 
            this.chkEntities.AutoSize = true;
            this.chkEntities.Checked = true;
            this.chkEntities.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntities.Location = new System.Drawing.Point(6, 57);
            this.chkEntities.Name = "chkEntities";
            this.chkEntities.Size = new System.Drawing.Size(82, 24);
            this.chkEntities.TabIndex = 1;
            this.chkEntities.Text = "Tables";
            this.chkEntities.UseVisualStyleBackColor = true;
            this.chkEntities.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkEntities_MouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(6, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(409, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gbSearchResult
            // 
            this.gbSearchResult.Controls.Add(this.lvSearchResult);
            this.gbSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchResult.Location = new System.Drawing.Point(0, 0);
            this.gbSearchResult.Name = "gbSearchResult";
            this.gbSearchResult.Size = new System.Drawing.Size(421, 283);
            this.gbSearchResult.TabIndex = 1;
            this.gbSearchResult.TabStop = false;
            this.gbSearchResult.Text = "Search result";
            // 
            // lvSearchResult
            // 
            this.lvSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLogicalName,
            this.chEntity});
            this.lvSearchResult.ContextMenuStrip = this.cmsMetadata;
            this.lvSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSearchResult.FullRowSelect = true;
            this.lvSearchResult.HideSelection = false;
            this.lvSearchResult.Location = new System.Drawing.Point(3, 22);
            this.lvSearchResult.Name = "lvSearchResult";
            this.lvSearchResult.Size = new System.Drawing.Size(415, 258);
            this.lvSearchResult.SmallImageList = this.imageList1;
            this.lvSearchResult.TabIndex = 0;
            this.lvSearchResult.UseCompatibleStateImageBehavior = false;
            this.lvSearchResult.View = System.Windows.Forms.View.Details;
            this.lvSearchResult.SelectedIndexChanged += new System.EventHandler(this.lvSearchResult_SelectedIndexChanged);
            this.lvSearchResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSearchResult_MouseClick);
            // 
            // chLogicalName
            // 
            this.chLogicalName.Text = "Logical name";
            this.chLogicalName.Width = 156;
            // 
            // chEntity
            // 
            this.chEntity.Text = "Entity";
            this.chEntity.Width = 205;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ico_16_form.gif");
            this.imageList1.Images.SetKeyName(1, "text_area (2).png");
            this.imageList1.Images.SetKeyName(2, "ico_16_relationshipsN21.gif");
            this.imageList1.Images.SetKeyName(3, "ico_16_relationshipsN2N.gif");
            this.imageList1.Images.SetKeyName(4, "key.png");
            // 
            // gbProperties
            // 
            this.gbProperties.Controls.Add(this.scProperties);
            this.gbProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProperties.Location = new System.Drawing.Point(0, 0);
            this.gbProperties.Name = "gbProperties";
            this.gbProperties.Size = new System.Drawing.Size(421, 1040);
            this.gbProperties.TabIndex = 2;
            this.gbProperties.TabStop = false;
            this.gbProperties.Text = "Properties";
            // 
            // scProperties
            // 
            this.scProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scProperties.Location = new System.Drawing.Point(3, 22);
            this.scProperties.Name = "scProperties";
            this.scProperties.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scProperties.Panel1
            // 
            this.scProperties.Panel1.Controls.Add(this.propertyGrid1);
            // 
            // scProperties.Panel2
            // 
            this.scProperties.Panel2.Controls.Add(this.pgOptionSetValues);
            this.scProperties.Size = new System.Drawing.Size(415, 1015);
            this.scProperties.SplitterDistance = 506;
            this.scProperties.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(415, 506);
            this.propertyGrid1.TabIndex = 0;
            // 
            // pgOptionSetValues
            // 
            this.pgOptionSetValues.ContextMenuStrip = this.cmsPicklist;
            this.pgOptionSetValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgOptionSetValues.HelpVisible = false;
            this.pgOptionSetValues.Location = new System.Drawing.Point(0, 0);
            this.pgOptionSetValues.Name = "pgOptionSetValues";
            this.pgOptionSetValues.Size = new System.Drawing.Size(415, 505);
            this.pgOptionSetValues.TabIndex = 0;
            this.pgOptionSetValues.ToolbarVisible = false;
            // 
            // cmsPicklist
            // 
            this.cmsPicklist.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsPicklist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyValueToolStripMenuItem,
            this.copyDisplayNameToolStripMenuItem});
            this.cmsPicklist.Name = "cmsPicklist";
            this.cmsPicklist.Size = new System.Drawing.Size(173, 68);
            this.cmsPicklist.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsPicklist_ItemClicked);
            // 
            // copyValueToolStripMenuItem
            // 
            this.copyValueToolStripMenuItem.Name = "copyValueToolStripMenuItem";
            this.copyValueToolStripMenuItem.Size = new System.Drawing.Size(172, 32);
            this.copyValueToolStripMenuItem.Text = "Copy value";
            // 
            // copyDisplayNameToolStripMenuItem
            // 
            this.copyDisplayNameToolStripMenuItem.Name = "copyDisplayNameToolStripMenuItem";
            this.copyDisplayNameToolStripMenuItem.Size = new System.Drawing.Size(172, 32);
            this.copyDisplayNameToolStripMenuItem.Text = "Copy label";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 89);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.gbSearchResult);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.gbProperties);
            this.scMain.Size = new System.Drawing.Size(421, 1327);
            this.scMain.SplitterDistance = 283;
            this.scMain.TabIndex = 3;
            // 
            // cmsMetadata
            // 
            this.cmsMetadata.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenuTable,
            this.tsmiTableCopyLogicalName,
            this.tsmiTableCopyLogicalCollectionName,
            this.tsmiTableCopySchemaName,
            this.tsmiMenuColumn,
            this.tsmiColumnCopyLogicalName,
            this.tsmiColumnCopySchemaName,
            this.tsmiColumnCopyWabApiLookupName,
            this.tsmiMenuRel,
            this.tsmiRelCopySchemaName,
            this.tsmiRelCopyParentNavigation,
            this.tsmiRelCopyParentNavigationWithBinding,
            this.tsmiRelCopyChildNavigation});
            this.cmsMetadata.Name = "cmsMetadata";
            this.cmsMetadata.Size = new System.Drawing.Size(520, 420);
            this.cmsMetadata.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMetadata_ItemClicked);
            // 
            // tsmiMenuTable
            // 
            this.tsmiMenuTable.Enabled = false;
            this.tsmiMenuTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmiMenuTable.ForeColor = System.Drawing.Color.Black;
            this.tsmiMenuTable.Name = "tsmiMenuTable";
            this.tsmiMenuTable.Size = new System.Drawing.Size(519, 32);
            this.tsmiMenuTable.Text = "Table";
            // 
            // tsmiTableCopyLogicalName
            // 
            this.tsmiTableCopyLogicalName.Name = "tsmiTableCopyLogicalName";
            this.tsmiTableCopyLogicalName.Size = new System.Drawing.Size(519, 32);
            this.tsmiTableCopyLogicalName.Text = "Copy Logical name";
            // 
            // tsmiTableCopyLogicalCollectionName
            // 
            this.tsmiTableCopyLogicalCollectionName.Name = "tsmiTableCopyLogicalCollectionName";
            this.tsmiTableCopyLogicalCollectionName.Size = new System.Drawing.Size(519, 32);
            this.tsmiTableCopyLogicalCollectionName.Text = "Copy Logical collection name";
            // 
            // tsmiTableCopySchemaName
            // 
            this.tsmiTableCopySchemaName.Name = "tsmiTableCopySchemaName";
            this.tsmiTableCopySchemaName.Size = new System.Drawing.Size(519, 32);
            this.tsmiTableCopySchemaName.Text = "Copy Schema name";
            // 
            // tsmiMenuColumn
            // 
            this.tsmiMenuColumn.Enabled = false;
            this.tsmiMenuColumn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmiMenuColumn.ForeColor = System.Drawing.Color.Black;
            this.tsmiMenuColumn.Name = "tsmiMenuColumn";
            this.tsmiMenuColumn.Size = new System.Drawing.Size(519, 32);
            this.tsmiMenuColumn.Text = "Column";
            // 
            // tsmiColumnCopyLogicalName
            // 
            this.tsmiColumnCopyLogicalName.Name = "tsmiColumnCopyLogicalName";
            this.tsmiColumnCopyLogicalName.Size = new System.Drawing.Size(519, 32);
            this.tsmiColumnCopyLogicalName.Text = "Copy Logical name";
            // 
            // tsmiColumnCopySchemaName
            // 
            this.tsmiColumnCopySchemaName.Name = "tsmiColumnCopySchemaName";
            this.tsmiColumnCopySchemaName.Size = new System.Drawing.Size(519, 32);
            this.tsmiColumnCopySchemaName.Text = "Copy Schema name";
            // 
            // tsmiColumnCopyWabApiLookupName
            // 
            this.tsmiColumnCopyWabApiLookupName.Name = "tsmiColumnCopyWabApiLookupName";
            this.tsmiColumnCopyWabApiLookupName.Size = new System.Drawing.Size(519, 32);
            this.tsmiColumnCopyWabApiLookupName.Tag = "Copy Web Api Lookup name";
            this.tsmiColumnCopyWabApiLookupName.Text = "Copy Web Api Lookup name";
            // 
            // tsmiMenuRel
            // 
            this.tsmiMenuRel.Enabled = false;
            this.tsmiMenuRel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmiMenuRel.ForeColor = System.Drawing.Color.Black;
            this.tsmiMenuRel.Name = "tsmiMenuRel";
            this.tsmiMenuRel.Size = new System.Drawing.Size(519, 32);
            this.tsmiMenuRel.Text = "Relationship";
            // 
            // tsmiRelCopyParentNavigation
            // 
            this.tsmiRelCopyParentNavigation.Name = "tsmiRelCopyParentNavigation";
            this.tsmiRelCopyParentNavigation.Size = new System.Drawing.Size(519, 32);
            this.tsmiRelCopyParentNavigation.Text = "Copy Web api Parent Navigation property";
            // 
            // tsmiRelCopyChildNavigation
            // 
            this.tsmiRelCopyChildNavigation.Name = "tsmiRelCopyChildNavigation";
            this.tsmiRelCopyChildNavigation.Size = new System.Drawing.Size(519, 32);
            this.tsmiRelCopyChildNavigation.Text = "Copy Web api Child Navigation property";
            // 
            // tsmiRelCopySchemaName
            // 
            this.tsmiRelCopySchemaName.Name = "tsmiRelCopySchemaName";
            this.tsmiRelCopySchemaName.Size = new System.Drawing.Size(519, 32);
            this.tsmiRelCopySchemaName.Text = "Copy Schema name";
            // 
            // tsmiRelCopyParentNavigationWithBinding
            // 
            this.tsmiRelCopyParentNavigationWithBinding.Name = "tsmiRelCopyParentNavigationWithBinding";
            this.tsmiRelCopyParentNavigationWithBinding.Size = new System.Drawing.Size(519, 32);
            this.tsmiRelCopyParentNavigationWithBinding.Text = "Copy Web api Parent Navigation property with binding";
            // 
            // CompanionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.gbSearch);
            this.Name = "CompanionControl";
            this.Size = new System.Drawing.Size(421, 1416);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbSearchResult.ResumeLayout(false);
            this.gbProperties.ResumeLayout(false);
            this.scProperties.Panel1.ResumeLayout(false);
            this.scProperties.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scProperties)).EndInit();
            this.scProperties.ResumeLayout(false);
            this.cmsPicklist.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.cmsMetadata.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbSearchResult;
        private System.Windows.Forms.ListView lvSearchResult;
        private System.Windows.Forms.ColumnHeader chLogicalName;
        private System.Windows.Forms.ColumnHeader chEntity;
        private System.Windows.Forms.GroupBox gbProperties;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox chkKeys;
        private System.Windows.Forms.CheckBox chkRels;
        private System.Windows.Forms.CheckBox chkColumns;
        private System.Windows.Forms.CheckBox chkEntities;
        private System.Windows.Forms.PropertyGrid pgOptionSetValues;
        private System.Windows.Forms.ContextMenuStrip cmsPicklist;
        private System.Windows.Forms.ToolStripMenuItem copyValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDisplayNameToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMetadata;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableCopyLogicalName;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableCopyLogicalCollectionName;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableCopySchemaName;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuColumn;
        private System.Windows.Forms.ToolStripMenuItem tsmiColumnCopyLogicalName;
        private System.Windows.Forms.ToolStripMenuItem tsmiColumnCopySchemaName;
        private System.Windows.Forms.ToolStripMenuItem tsmiColumnCopyWabApiLookupName;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuRel;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelCopyParentNavigation;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelCopyChildNavigation;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelCopySchemaName;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelCopyParentNavigationWithBinding;
    }
}