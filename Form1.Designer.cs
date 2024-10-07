namespace PoolTable
{
    partial class Form1
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
            this.ctrlPoolTable1 = new PoolTable.ctrlPoolTable();
            this.ctrlPoolTable2 = new PoolTable.ctrlPoolTable();
            this.ctrlPoolTable3 = new PoolTable.ctrlPoolTable();
            this.ctrlPoolTable4 = new PoolTable.ctrlPoolTable();
            this.ctrlPoolTable5 = new PoolTable.ctrlPoolTable();
            this.ctrlPoolTable6 = new PoolTable.ctrlPoolTable();
            this.SuspendLayout();
            // 
            // ctrlPoolTable1
            // 
            this.ctrlPoolTable1.HourlyRate = 0.1D;
            this.ctrlPoolTable1.Location = new System.Drawing.Point(12, 10);
            this.ctrlPoolTable1.Name = "ctrlPoolTable1";
            this.ctrlPoolTable1.PlayerName = "Amir";
            this.ctrlPoolTable1.Size = new System.Drawing.Size(393, 275);
            this.ctrlPoolTable1.TabIndex = 0;
            this.ctrlPoolTable1.TableTitle = "VIP";
            this.ctrlPoolTable1.OnTableFinish += new System.EventHandler<PoolTable.ctrlPoolTable.TableEventArgs>(this.ctrlPoolTable1_OnTableFinish);
            // 
            // ctrlPoolTable2
            // 
            this.ctrlPoolTable2.HourlyRate = 0.05D;
            this.ctrlPoolTable2.Location = new System.Drawing.Point(449, 10);
            this.ctrlPoolTable2.Name = "ctrlPoolTable2";
            this.ctrlPoolTable2.PlayerName = "Omar";
            this.ctrlPoolTable2.Size = new System.Drawing.Size(393, 275);
            this.ctrlPoolTable2.TabIndex = 0;
            this.ctrlPoolTable2.TableTitle = "Table1";
            this.ctrlPoolTable2.OnTableFinish += new System.EventHandler<PoolTable.ctrlPoolTable.TableEventArgs>(this.ctrlPoolTable1_OnTableFinish);
            // 
            // ctrlPoolTable3
            // 
            this.ctrlPoolTable3.HourlyRate = 0.01D;
            this.ctrlPoolTable3.Location = new System.Drawing.Point(909, 10);
            this.ctrlPoolTable3.Name = "ctrlPoolTable3";
            this.ctrlPoolTable3.PlayerName = "Mostafa";
            this.ctrlPoolTable3.Size = new System.Drawing.Size(393, 275);
            this.ctrlPoolTable3.TabIndex = 0;
            this.ctrlPoolTable3.TableTitle = "Table 2";
            this.ctrlPoolTable3.OnTableFinish += new System.EventHandler<PoolTable.ctrlPoolTable.TableEventArgs>(this.ctrlPoolTable1_OnTableFinish);
            // 
            // ctrlPoolTable4
            // 
            this.ctrlPoolTable4.HourlyRate = 60D;
            this.ctrlPoolTable4.Location = new System.Drawing.Point(909, 331);
            this.ctrlPoolTable4.Name = "ctrlPoolTable4";
            this.ctrlPoolTable4.PlayerName = "Mano";
            this.ctrlPoolTable4.Size = new System.Drawing.Size(393, 275);
            this.ctrlPoolTable4.TabIndex = 0;
            this.ctrlPoolTable4.TableTitle = "Table 5";
            this.ctrlPoolTable4.OnTableFinish += new System.EventHandler<PoolTable.ctrlPoolTable.TableEventArgs>(this.ctrlPoolTable1_OnTableFinish);
            // 
            // ctrlPoolTable5
            // 
            this.ctrlPoolTable5.HourlyRate = 0.1D;
            this.ctrlPoolTable5.Location = new System.Drawing.Point(449, 331);
            this.ctrlPoolTable5.Name = "ctrlPoolTable5";
            this.ctrlPoolTable5.PlayerName = "Alaa";
            this.ctrlPoolTable5.Size = new System.Drawing.Size(393, 275);
            this.ctrlPoolTable5.TabIndex = 0;
            this.ctrlPoolTable5.TableTitle = "Table 4";
            this.ctrlPoolTable5.OnTableFinish += new System.EventHandler<PoolTable.ctrlPoolTable.TableEventArgs>(this.ctrlPoolTable1_OnTableFinish);
            // 
            // ctrlPoolTable6
            // 
            this.ctrlPoolTable6.HourlyRate = 0.01D;
            this.ctrlPoolTable6.Location = new System.Drawing.Point(12, 331);
            this.ctrlPoolTable6.Name = "ctrlPoolTable6";
            this.ctrlPoolTable6.PlayerName = "Mohammed";
            this.ctrlPoolTable6.Size = new System.Drawing.Size(393, 275);
            this.ctrlPoolTable6.TabIndex = 0;
            this.ctrlPoolTable6.TableTitle = "Table 3";
            this.ctrlPoolTable6.OnTableFinish += new System.EventHandler<PoolTable.ctrlPoolTable.TableEventArgs>(this.ctrlPoolTable1_OnTableFinish);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 618);
            this.Controls.Add(this.ctrlPoolTable6);
            this.Controls.Add(this.ctrlPoolTable5);
            this.Controls.Add(this.ctrlPoolTable4);
            this.Controls.Add(this.ctrlPoolTable3);
            this.Controls.Add(this.ctrlPoolTable2);
            this.Controls.Add(this.ctrlPoolTable1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPoolTable ctrlPoolTable1;
        private ctrlPoolTable ctrlPoolTable2;
        private ctrlPoolTable ctrlPoolTable3;
        private ctrlPoolTable ctrlPoolTable4;
        private ctrlPoolTable ctrlPoolTable5;
        private ctrlPoolTable ctrlPoolTable6;
    }
}

