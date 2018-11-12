namespace XMLFormat
{
    partial class XMLFormat
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
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopyToClipBoard = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDock = new System.Windows.Forms.Button();
            this.xmlEditor = new XmlEditor();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 35);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(1473, 232);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input text here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // btnCopyToClipBoard
            // 
            this.btnCopyToClipBoard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCopyToClipBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCopyToClipBoard.Location = new System.Drawing.Point(1240, 857);
            this.btnCopyToClipBoard.Name = "btnCopyToClipBoard";
            this.btnCopyToClipBoard.Size = new System.Drawing.Size(344, 59);
            this.btnCopyToClipBoard.TabIndex = 5;
            this.btnCopyToClipBoard.Text = "Copy To Clipboard";
            this.btnCopyToClipBoard.UseVisualStyleBackColor = false;
            this.btnCopyToClipBoard.Click += new System.EventHandler(this.btnCopyToClipBoard_Click);
            // 
            // btnXML
            // 
            this.btnXML.AllowDrop = true;
            this.btnXML.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXML.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXML.Location = new System.Drawing.Point(1341, 273);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(135, 46);
            this.btnXML.TabIndex = 6;
            this.btnXML.Text = "XML Format";
            this.btnXML.UseVisualStyleBackColor = false;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnReset
            // 
            this.btnReset.AllowDrop = true;
            this.btnReset.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(1159, 273);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 46);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDock
            // 
            this.btnDock.AllowDrop = true;
            this.btnDock.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDock.Location = new System.Drawing.Point(1547, 321);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(65, 31);
            this.btnDock.TabIndex = 9;
            this.btnDock.Text = "[ ]";
            this.btnDock.UseVisualStyleBackColor = false;
            this.btnDock.Click += new System.EventHandler(this.btnDock_Click);
            // 
            // xmlEditor
            // 
            this.xmlEditor.AllowXmlFormatting = true;
            this.xmlEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlEditor.Location = new System.Drawing.Point(12, 338);
            this.xmlEditor.Margin = new System.Windows.Forms.Padding(4);
            this.xmlEditor.Name = "xmlEditor";
            this.xmlEditor.ReadOnly = false;
            this.xmlEditor.Size = new System.Drawing.Size(1600, 512);
            this.xmlEditor.TabIndex = 8;
            // 
            // XMLFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 915);
            this.Controls.Add(this.btnDock);
            this.Controls.Add(this.xmlEditor);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnCopyToClipBoard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "XMLFormat";
            this.Text = "XML Format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopyToClipBoard;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnReset;
        private XmlEditor xmlEditor;
        private System.Windows.Forms.Button btnDock;
    }
}

