namespace Kvasova6task
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxConnectionType = new System.Windows.Forms.GroupBox();
            this.radioButtonCable = new System.Windows.Forms.RadioButton();
            this.radioButtonWall = new System.Windows.Forms.RadioButton();
            this.groupBoxVertexType = new System.Windows.Forms.GroupBox();
            this.radioButtonForAngle = new System.Windows.Forms.RadioButton();
            this.radioButtonRouter = new System.Windows.Forms.RadioButton();
            this.radioButtonPrinter = new System.Windows.Forms.RadioButton();
            this.radioButtonComputer = new System.Windows.Forms.RadioButton();
            this.groupBoxRegime = new System.Windows.Forms.GroupBox();
            this.radioButtonMoveVertex = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleteConnection = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleteVertex = new System.Windows.Forms.RadioButton();
            this.radioButtonAddConnection = new System.Windows.Forms.RadioButton();
            this.radioButtonAddVertex = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxConnectionType.SuspendLayout();
            this.groupBoxVertexType.SuspendLayout();
            this.groupBoxRegime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 592);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBoxConnectionType
            // 
            this.groupBoxConnectionType.Controls.Add(this.radioButtonCable);
            this.groupBoxConnectionType.Controls.Add(this.radioButtonWall);
            this.groupBoxConnectionType.Location = new System.Drawing.Point(7, 266);
            this.groupBoxConnectionType.Name = "groupBoxConnectionType";
            this.groupBoxConnectionType.Size = new System.Drawing.Size(141, 69);
            this.groupBoxConnectionType.TabIndex = 6;
            this.groupBoxConnectionType.TabStop = false;
            this.groupBoxConnectionType.Text = "Тип Connection";
            // 
            // radioButtonCable
            // 
            this.radioButtonCable.AutoSize = true;
            this.radioButtonCable.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCable.Name = "radioButtonCable";
            this.radioButtonCable.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCable.TabIndex = 4;
            this.radioButtonCable.TabStop = true;
            this.radioButtonCable.Text = "CABLE";
            this.radioButtonCable.UseVisualStyleBackColor = true;
            // 
            // radioButtonWall
            // 
            this.radioButtonWall.AutoSize = true;
            this.radioButtonWall.Location = new System.Drawing.Point(6, 19);
            this.radioButtonWall.Name = "radioButtonWall";
            this.radioButtonWall.Size = new System.Drawing.Size(55, 17);
            this.radioButtonWall.TabIndex = 3;
            this.radioButtonWall.TabStop = true;
            this.radioButtonWall.Text = "WALL";
            this.radioButtonWall.UseVisualStyleBackColor = true;
            // 
            // groupBoxVertexType
            // 
            this.groupBoxVertexType.Controls.Add(this.radioButtonForAngle);
            this.groupBoxVertexType.Controls.Add(this.radioButtonRouter);
            this.groupBoxVertexType.Controls.Add(this.radioButtonPrinter);
            this.groupBoxVertexType.Controls.Add(this.radioButtonComputer);
            this.groupBoxVertexType.Location = new System.Drawing.Point(7, 145);
            this.groupBoxVertexType.Name = "groupBoxVertexType";
            this.groupBoxVertexType.Size = new System.Drawing.Size(141, 114);
            this.groupBoxVertexType.TabIndex = 5;
            this.groupBoxVertexType.TabStop = false;
            this.groupBoxVertexType.Text = "Тип Vertex";
            // 
            // radioButtonForAngle
            // 
            this.radioButtonForAngle.AutoSize = true;
            this.radioButtonForAngle.Location = new System.Drawing.Point(6, 20);
            this.radioButtonForAngle.Name = "radioButtonForAngle";
            this.radioButtonForAngle.Size = new System.Drawing.Size(89, 17);
            this.radioButtonForAngle.TabIndex = 3;
            this.radioButtonForAngle.TabStop = true;
            this.radioButtonForAngle.Text = "FOR_ANGLE";
            this.radioButtonForAngle.UseVisualStyleBackColor = true;
            // 
            // radioButtonRouter
            // 
            this.radioButtonRouter.AutoSize = true;
            this.radioButtonRouter.Location = new System.Drawing.Point(6, 66);
            this.radioButtonRouter.Name = "radioButtonRouter";
            this.radioButtonRouter.Size = new System.Drawing.Size(71, 17);
            this.radioButtonRouter.TabIndex = 2;
            this.radioButtonRouter.TabStop = true;
            this.radioButtonRouter.Text = "ROUTER";
            this.radioButtonRouter.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrinter
            // 
            this.radioButtonPrinter.AutoSize = true;
            this.radioButtonPrinter.Location = new System.Drawing.Point(6, 43);
            this.radioButtonPrinter.Name = "radioButtonPrinter";
            this.radioButtonPrinter.Size = new System.Drawing.Size(73, 17);
            this.radioButtonPrinter.TabIndex = 1;
            this.radioButtonPrinter.TabStop = true;
            this.radioButtonPrinter.Text = "PRINTER";
            this.radioButtonPrinter.UseVisualStyleBackColor = true;
            // 
            // radioButtonComputer
            // 
            this.radioButtonComputer.AutoSize = true;
            this.radioButtonComputer.Location = new System.Drawing.Point(6, 89);
            this.radioButtonComputer.Name = "radioButtonComputer";
            this.radioButtonComputer.Size = new System.Drawing.Size(86, 17);
            this.radioButtonComputer.TabIndex = 0;
            this.radioButtonComputer.TabStop = true;
            this.radioButtonComputer.Text = "COMPUTER";
            this.radioButtonComputer.UseVisualStyleBackColor = true;
            // 
            // groupBoxRegime
            // 
            this.groupBoxRegime.Controls.Add(this.radioButtonMoveVertex);
            this.groupBoxRegime.Controls.Add(this.radioButtonDeleteConnection);
            this.groupBoxRegime.Controls.Add(this.radioButtonDeleteVertex);
            this.groupBoxRegime.Controls.Add(this.radioButtonAddConnection);
            this.groupBoxRegime.Controls.Add(this.radioButtonAddVertex);
            this.groupBoxRegime.Location = new System.Drawing.Point(7, 8);
            this.groupBoxRegime.Name = "groupBoxRegime";
            this.groupBoxRegime.Size = new System.Drawing.Size(141, 130);
            this.groupBoxRegime.TabIndex = 4;
            this.groupBoxRegime.TabStop = false;
            // 
            // radioButtonMoveVertex
            // 
            this.radioButtonMoveVertex.AutoSize = true;
            this.radioButtonMoveVertex.Location = new System.Drawing.Point(7, 106);
            this.radioButtonMoveVertex.Name = "radioButtonMoveVertex";
            this.radioButtonMoveVertex.Size = new System.Drawing.Size(124, 17);
            this.radioButtonMoveVertex.TabIndex = 4;
            this.radioButtonMoveVertex.TabStop = true;
            this.radioButtonMoveVertex.Text = "Передвинуть Vertex";
            this.radioButtonMoveVertex.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeleteConnection
            // 
            this.radioButtonDeleteConnection.AutoSize = true;
            this.radioButtonDeleteConnection.Location = new System.Drawing.Point(7, 82);
            this.radioButtonDeleteConnection.Name = "radioButtonDeleteConnection";
            this.radioButtonDeleteConnection.Size = new System.Drawing.Size(125, 17);
            this.radioButtonDeleteConnection.TabIndex = 3;
            this.radioButtonDeleteConnection.TabStop = true;
            this.radioButtonDeleteConnection.Text = "Удалить Connection";
            this.radioButtonDeleteConnection.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeleteVertex
            // 
            this.radioButtonDeleteVertex.AutoSize = true;
            this.radioButtonDeleteVertex.Location = new System.Drawing.Point(7, 58);
            this.radioButtonDeleteVertex.Name = "radioButtonDeleteVertex";
            this.radioButtonDeleteVertex.Size = new System.Drawing.Size(101, 17);
            this.radioButtonDeleteVertex.TabIndex = 2;
            this.radioButtonDeleteVertex.TabStop = true;
            this.radioButtonDeleteVertex.Text = "Удалить Vertex";
            this.radioButtonDeleteVertex.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddConnection
            // 
            this.radioButtonAddConnection.AutoSize = true;
            this.radioButtonAddConnection.Location = new System.Drawing.Point(7, 34);
            this.radioButtonAddConnection.Name = "radioButtonAddConnection";
            this.radioButtonAddConnection.Size = new System.Drawing.Size(132, 17);
            this.radioButtonAddConnection.TabIndex = 1;
            this.radioButtonAddConnection.TabStop = true;
            this.radioButtonAddConnection.Text = "Добавить Connection";
            this.radioButtonAddConnection.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddVertex
            // 
            this.radioButtonAddVertex.AutoSize = true;
            this.radioButtonAddVertex.Location = new System.Drawing.Point(7, 10);
            this.radioButtonAddVertex.Name = "radioButtonAddVertex";
            this.radioButtonAddVertex.Size = new System.Drawing.Size(108, 17);
            this.radioButtonAddVertex.TabIndex = 0;
            this.radioButtonAddVertex.TabStop = true;
            this.radioButtonAddVertex.Text = "Добавить Vertex";
            this.radioButtonAddVertex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxConnectionType);
            this.Controls.Add(this.groupBoxVertexType);
            this.Controls.Add(this.groupBoxRegime);
            this.Name = "Form1";
            this.Text = "Kvasova5task";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxConnectionType.ResumeLayout(false);
            this.groupBoxConnectionType.PerformLayout();
            this.groupBoxVertexType.ResumeLayout(false);
            this.groupBoxVertexType.PerformLayout();
            this.groupBoxRegime.ResumeLayout(false);
            this.groupBoxRegime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxConnectionType;
        private System.Windows.Forms.RadioButton radioButtonCable;
        private System.Windows.Forms.RadioButton radioButtonWall;
        private System.Windows.Forms.GroupBox groupBoxVertexType;
        private System.Windows.Forms.RadioButton radioButtonForAngle;
        private System.Windows.Forms.RadioButton radioButtonRouter;
        private System.Windows.Forms.RadioButton radioButtonPrinter;
        private System.Windows.Forms.RadioButton radioButtonComputer;
        private System.Windows.Forms.GroupBox groupBoxRegime;
        private System.Windows.Forms.RadioButton radioButtonMoveVertex;
        private System.Windows.Forms.RadioButton radioButtonDeleteConnection;
        private System.Windows.Forms.RadioButton radioButtonDeleteVertex;
        private System.Windows.Forms.RadioButton radioButtonAddConnection;
        private System.Windows.Forms.RadioButton radioButtonAddVertex;
    }
}

