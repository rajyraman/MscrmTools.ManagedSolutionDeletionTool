﻿namespace MscrmTools.ManagedSolutionDeletionTool.UserControls
{
    partial class SolutionProperties
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
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.lblCanBeUninstall = new System.Windows.Forms.Label();
            this.pnlNoDependency = new System.Windows.Forms.Panel();
            this.llDeleteSolution = new System.Windows.Forms.LinkLabel();
            this.pnlDependency = new System.Windows.Forms.Panel();
            this.tvDependencies = new System.Windows.Forms.TreeView();
            this.llDeleteSolutionDependencies = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNoDependency.SuspendLayout();
            this.pnlDependency.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSolutionName
            // 
            this.lblSolutionName.AutoSize = true;
            this.lblSolutionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSolutionName.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionName.Location = new System.Drawing.Point(0, 0);
            this.lblSolutionName.Name = "lblSolutionName";
            this.lblSolutionName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblSolutionName.Size = new System.Drawing.Size(200, 48);
            this.lblSolutionName.TabIndex = 0;
            this.lblSolutionName.Text = "[SolutionName]";
            // 
            // lblCanBeUninstall
            // 
            this.lblCanBeUninstall.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCanBeUninstall.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanBeUninstall.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCanBeUninstall.Location = new System.Drawing.Point(0, 0);
            this.lblCanBeUninstall.MaximumSize = new System.Drawing.Size(0, 100);
            this.lblCanBeUninstall.Name = "lblCanBeUninstall";
            this.lblCanBeUninstall.Size = new System.Drawing.Size(470, 32);
            this.lblCanBeUninstall.TabIndex = 1;
            this.lblCanBeUninstall.Text = "This solution has no dependent solutions and can be deleted immediatly";
            // 
            // pnlNoDependency
            // 
            this.pnlNoDependency.Controls.Add(this.llDeleteSolution);
            this.pnlNoDependency.Controls.Add(this.lblCanBeUninstall);
            this.pnlNoDependency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNoDependency.Location = new System.Drawing.Point(0, 48);
            this.pnlNoDependency.Name = "pnlNoDependency";
            this.pnlNoDependency.Size = new System.Drawing.Size(470, 60);
            this.pnlNoDependency.TabIndex = 2;
            // 
            // llDeleteSolution
            // 
            this.llDeleteSolution.AutoSize = true;
            this.llDeleteSolution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.llDeleteSolution.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDeleteSolution.Location = new System.Drawing.Point(0, 32);
            this.llDeleteSolution.Name = "llDeleteSolution";
            this.llDeleteSolution.Size = new System.Drawing.Size(144, 28);
            this.llDeleteSolution.TabIndex = 2;
            this.llDeleteSolution.TabStop = true;
            this.llDeleteSolution.Text = "Delete solution";
            this.llDeleteSolution.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDeleteSolution_LinkClicked);
            // 
            // pnlDependency
            // 
            this.pnlDependency.Controls.Add(this.tvDependencies);
            this.pnlDependency.Controls.Add(this.llDeleteSolutionDependencies);
            this.pnlDependency.Controls.Add(this.label1);
            this.pnlDependency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDependency.Location = new System.Drawing.Point(0, 108);
            this.pnlDependency.Name = "pnlDependency";
            this.pnlDependency.Size = new System.Drawing.Size(470, 494);
            this.pnlDependency.TabIndex = 3;
            // 
            // tvDependencies
            // 
            this.tvDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDependencies.Location = new System.Drawing.Point(0, 96);
            this.tvDependencies.Name = "tvDependencies";
            this.tvDependencies.Size = new System.Drawing.Size(470, 370);
            this.tvDependencies.TabIndex = 4;
            // 
            // llDeleteSolutionDependencies
            // 
            this.llDeleteSolutionDependencies.AutoSize = true;
            this.llDeleteSolutionDependencies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.llDeleteSolutionDependencies.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDeleteSolutionDependencies.Location = new System.Drawing.Point(0, 466);
            this.llDeleteSolutionDependencies.Name = "llDeleteSolutionDependencies";
            this.llDeleteSolutionDependencies.Size = new System.Drawing.Size(416, 28);
            this.llDeleteSolutionDependencies.TabIndex = 3;
            this.llDeleteSolutionDependencies.TabStop = true;
            this.llDeleteSolutionDependencies.Text = "Delete solution and all its dependent solutions";
            this.llDeleteSolutionDependencies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDeleteSolutionDependencies_LinkClicked);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(470, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "This solution has dependent solutions. You need to delete dependent solutions bef" +
    "ore you can delete this solution\r\n\r\nThe following treeview shows the solution de" +
    "pendencies";
            // 
            // SolutionProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDependency);
            this.Controls.Add(this.pnlNoDependency);
            this.Controls.Add(this.lblSolutionName);
            this.Name = "SolutionProperties";
            this.Size = new System.Drawing.Size(470, 885);
            this.pnlNoDependency.ResumeLayout(false);
            this.pnlNoDependency.PerformLayout();
            this.pnlDependency.ResumeLayout(false);
            this.pnlDependency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.Label lblCanBeUninstall;
        private System.Windows.Forms.Panel pnlNoDependency;
        private System.Windows.Forms.LinkLabel llDeleteSolution;
        private System.Windows.Forms.Panel pnlDependency;
        private System.Windows.Forms.TreeView tvDependencies;
        private System.Windows.Forms.LinkLabel llDeleteSolutionDependencies;
        private System.Windows.Forms.Label label1;
    }
}
