
namespace Lab1
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
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textName = new TextBox();
            textSurname = new TextBox();
            textBirth = new TextBox();
            textGroup = new TextBox();
            textCourse = new TextBox();
            textOutput = new TextBox();
            btnOK = new Button();
            btnClose = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Birthday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Group";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 180);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Course";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 20);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Output";
            // 
            // textName
            // 
            textName.Location = new Point(100, 20);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 6;
            // 
            // textSurname
            // 
            textSurname.Location = new Point(100, 60);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(100, 23);
            textSurname.TabIndex = 7;
            // 
            // textBirth
            // 
            textBirth.Location = new Point(100, 100);
            textBirth.Name = "textBirth";
            textBirth.Size = new Size(100, 23);
            textBirth.TabIndex = 8;
            // 
            // textGroup
            // 
            textGroup.Location = new Point(100, 140);
            textGroup.Name = "textGroup";
            textGroup.Size = new Size(100, 23);
            textGroup.TabIndex = 9;
            // 
            // textCourse
            // 
            textCourse.Location = new Point(100, 180);
            textCourse.Name = "textCourse";
            textCourse.Size = new Size(100, 23);
            textCourse.TabIndex = 10;
            // 
            // textOutput
            // 
            textOutput.Location = new Point(350, 20);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.Size = new Size(100, 103);
            textOutput.TabIndex = 11;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(100, 270);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 12;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(350, 270);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = SystemColors.Control;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(23, 228);
            labelError.Name = "labelError";
            labelError.Size = new Size(12, 15);
            labelError.TabIndex = 14;
            labelError.Text = "*";
            labelError.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnClose;
            ClientSize = new Size(514, 311);
            Controls.Add(labelError);
            Controls.Add(btnClose);
            Controls.Add(btnOK);
            Controls.Add(textOutput);
            Controls.Add(textCourse);
            Controls.Add(textGroup);
            Controls.Add(textBirth);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Лаб. 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textName;
        private TextBox textSurname;
        private TextBox textBirth;
        private TextBox textGroup;
        private TextBox textCourse;
        private TextBox textOutput;
        private Button btnOK;
        private Button btnClose;
        private Label labelError;
    }
}
