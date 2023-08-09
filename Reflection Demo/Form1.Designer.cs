namespace Reflection_Demo
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
         txtbox = new TextBox();
         button1 = new Button();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         listBox1 = new ListBox();
         listBox2 = new ListBox();
         listBox3 = new ListBox();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.ImageAlign = ContentAlignment.TopCenter;
         label1.Location = new Point(40, 18);
         label1.Name = "label1";
         label1.Size = new Size(66, 15);
         label1.TabIndex = 3;
         label1.Text = "Type Name";
         // 
         // txtbox
         // 
         txtbox.Location = new Point(146, 18);
         txtbox.Name = "txtbox";
         txtbox.Size = new Size(206, 23);
         txtbox.TabIndex = 4;
         // 
         // button1
         // 
         button1.Location = new Point(549, 12);
         button1.Name = "button1";
         button1.Size = new Size(200, 54);
         button1.TabIndex = 5;
         button1.Text = "Discover type information";
         button1.UseVisualStyleBackColor = true;
         button1.Click += button1_Click;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.ImageAlign = ContentAlignment.TopCenter;
         label2.Location = new Point(40, 83);
         label2.Name = "label2";
         label2.Size = new Size(54, 15);
         label2.TabIndex = 6;
         label2.Text = "Methods";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.ImageAlign = ContentAlignment.TopCenter;
         label3.Location = new Point(346, 83);
         label3.Name = "label3";
         label3.Size = new Size(60, 15);
         label3.TabIndex = 7;
         label3.Text = "Properties";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.ImageAlign = ContentAlignment.TopCenter;
         label4.Location = new Point(641, 83);
         label4.Name = "label4";
         label4.Size = new Size(71, 15);
         label4.TabIndex = 8;
         label4.Text = "Construcors";
         // 
         // listBox1
         // 
         listBox1.FormattingEnabled = true;
         listBox1.ItemHeight = 15;
         listBox1.Location = new Point(40, 101);
         listBox1.Name = "listBox1";
         listBox1.Size = new Size(254, 394);
         listBox1.TabIndex = 9;
         // 
         // listBox2
         // 
         listBox2.FormattingEnabled = true;
         listBox2.ItemHeight = 15;
         listBox2.Location = new Point(346, 101);
         listBox2.Name = "listBox2";
         listBox2.Size = new Size(243, 394);
         listBox2.TabIndex = 10;
         // 
         // listBox3
         // 
         listBox3.FormattingEnabled = true;
         listBox3.ItemHeight = 15;
         listBox3.Location = new Point(641, 101);
         listBox3.Name = "listBox3";
         listBox3.Size = new Size(243, 394);
         listBox3.TabIndex = 11;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(937, 557);
         Controls.Add(listBox3);
         Controls.Add(listBox2);
         Controls.Add(listBox1);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(button1);
         Controls.Add(txtbox);
         Controls.Add(label1);
         Name = "Form1";
         Text = "Form1";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private Label label1;
      private TextBox txtbox;
      private Button button1;
      private Label label2;
      private Label label3;
      private Label label4;
      private ListBox listBox1;
      private ListBox listBox2;
      private ListBox listBox3;
   }
}