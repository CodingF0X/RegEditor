
namespace RegEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Form1
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Name = "Form1";
        //    this.Text = "Form1";
        //    this.Load += new System.EventHandler(this.Form1_Load);
        //    this.ResumeLayout(false);

        //}


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvRegistry = new System.Windows.Forms.TreeView();
            this.cmnTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnAddTree = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnDeleteTree = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvRegistry = new System.Windows.Forms.ListView();
            this.cmnListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnAddList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnEditList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnDeleteList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmnTree.SuspendLayout();
            this.cmnListview.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 42);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvRegistry);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvRegistry);
            this.splitContainer1.Size = new System.Drawing.Size(1111, 734);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvRegistry
            // 
            this.tvRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvRegistry.ContextMenuStrip = this.cmnTree;
            this.tvRegistry.FullRowSelect = true;
            this.tvRegistry.HideSelection = false;
            this.tvRegistry.ImageIndex = 0;
            this.tvRegistry.ImageList = this.imageList1;
            this.tvRegistry.Location = new System.Drawing.Point(4, 5);
            this.tvRegistry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvRegistry.Name = "tvRegistry";
            this.tvRegistry.SelectedImageIndex = 0;
            this.tvRegistry.Size = new System.Drawing.Size(360, 722);
            this.tvRegistry.TabIndex = 0;
            this.tvRegistry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvRegistry_MouseDown);
            // 
            // cmnTree
            // 
            this.cmnTree.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnAddTree,
            this.cmnDeleteTree});
            this.cmnTree.Name = "cmnTree";
            this.cmnTree.Size = new System.Drawing.Size(155, 52);
            // 
            // cmnAddTree
            // 
            this.cmnAddTree.Name = "cmnAddTree";
            this.cmnAddTree.Size = new System.Drawing.Size(154, 24);
            this.cmnAddTree.Text = "ADD...";
            this.cmnAddTree.Click += new System.EventHandler(this.cmnAddTree_Click);
            // 
            // cmnDeleteTree
            // 
            this.cmnDeleteTree.Name = "cmnDeleteTree";
            this.cmnDeleteTree.Size = new System.Drawing.Size(154, 24);
            this.cmnDeleteTree.Text = "Delete";
            this.cmnDeleteTree.Click += new System.EventHandler(this.cmnDeleteTree_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvRegistry
            // 
            this.lvRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRegistry.ContextMenuStrip = this.cmnListview;
            this.lvRegistry.FullRowSelect = true;
            this.lvRegistry.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRegistry.HideSelection = false;
            this.lvRegistry.Location = new System.Drawing.Point(4, 5);
            this.lvRegistry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvRegistry.MultiSelect = false;
            this.lvRegistry.Name = "lvRegistry";
            this.lvRegistry.Size = new System.Drawing.Size(732, 727);
            this.lvRegistry.TabIndex = 0;
            this.lvRegistry.UseCompatibleStateImageBehavior = false;
            this.lvRegistry.View = System.Windows.Forms.View.Details;
            // 
            // cmnListview
            // 
            this.cmnListview.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnListview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnAddList,
            this.cmnEditList,
            this.cmnDeleteList});
            this.cmnListview.Name = "cmnListview";
            this.cmnListview.Size = new System.Drawing.Size(190, 76);
            // 
            // cmnAddList
            // 
            this.cmnAddList.Name = "cmnAddList";
            this.cmnAddList.Size = new System.Drawing.Size(189, 24);
            this.cmnAddList.Text = "Add...";
            this.cmnAddList.Click += new System.EventHandler(this.cmnAddList_Click);
            // 
            // cmnEditList
            // 
            this.cmnEditList.Name = "cmnEditList";
            this.cmnEditList.Size = new System.Drawing.Size(189, 24);
            this.cmnEditList.Text = "Edit...";
            this.cmnEditList.Click += new System.EventHandler(this.cmnEditList_Click);
            // 
            // cmnDeleteList
            // 
            this.cmnDeleteList.Name = "cmnDeleteList";
            this.cmnDeleteList.Size = new System.Drawing.Size(189, 24);
            this.cmnDeleteList.Text = "Delete";
            this.cmnDeleteList.Click += new System.EventHandler(this.cmnDeleteList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 794);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Regedit";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmnTree.ResumeLayout(false);
            this.cmnListview.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvRegistry;
        private System.Windows.Forms.ListView lvRegistry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmnTree;
        private System.Windows.Forms.ToolStripMenuItem cmnAddTree;
        private System.Windows.Forms.ToolStripMenuItem cmnDeleteTree;
        private System.Windows.Forms.ContextMenuStrip cmnListview;
        private System.Windows.Forms.ToolStripMenuItem cmnAddList;
        private System.Windows.Forms.ToolStripMenuItem cmnEditList;
        private System.Windows.Forms.ToolStripMenuItem cmnDeleteList;
        private System.Windows.Forms.ImageList imageList1;


    }
}

