namespace WinFormsApp1
{
    partial class FormMain
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
            btnTest = new Button();
            btnTest2 = new Button();
            lblTest = new Label();
            tbTest = new TextBox();
            chBTest = new CheckBox();
            rBtn5 = new RadioButton();
            rBtnTest4 = new RadioButton();
            gB1 = new GroupBox();
            rBtnTest3 = new RadioButton();
            rBtnTest = new RadioButton();
            rBtnTest2 = new RadioButton();
            gB2 = new GroupBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новыйToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            bntOpenFail = new Button();
            btnSaveFile = new Button();
            gB1.SuspendLayout();
            gB2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTest.Location = new Point(737, 36);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 25);
            btnTest.TabIndex = 0;
            btnTest.Text = "Нажми";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += TextChange;
            // 
            // btnTest2
            // 
            btnTest2.Location = new Point(737, 79);
            btnTest2.Name = "btnTest2";
            btnTest2.Size = new Size(75, 23);
            btnTest2.TabIndex = 1;
            btnTest2.Text = "Проверка";
            btnTest2.UseVisualStyleBackColor = true;
            btnTest2.Click += TextChange;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(12, 40);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(55, 15);
            lblTest.TabIndex = 2;
            lblTest.Text = "Подпись";
            // 
            // tbTest
            // 
            tbTest.AccessibleRole = AccessibleRole.PageTabList;
            tbTest.Location = new Point(69, 40);
            tbTest.Multiline = true;
            tbTest.Name = "tbTest";
            tbTest.ScrollBars = ScrollBars.Vertical;
            tbTest.Size = new Size(375, 259);
            tbTest.TabIndex = 3;
            // 
            // chBTest
            // 
            chBTest.AutoSize = true;
            chBTest.Location = new Point(486, 42);
            chBTest.Name = "chBTest";
            chBTest.Size = new Size(83, 19);
            chBTest.TabIndex = 4;
            chBTest.Text = "checkBox1";
            chBTest.UseVisualStyleBackColor = true;
            chBTest.CheckedChanged += chBTest_CheckedChanged;
            // 
            // rBtn5
            // 
            rBtn5.AutoSize = true;
            rBtn5.Location = new Point(6, 47);
            rBtn5.Name = "rBtn5";
            rBtn5.Size = new Size(94, 19);
            rBtn5.TabIndex = 1;
            rBtn5.TabStop = true;
            rBtn5.Text = "radioButton1";
            rBtn5.UseVisualStyleBackColor = true;
            // 
            // rBtnTest4
            // 
            rBtnTest4.AutoSize = true;
            rBtnTest4.Location = new Point(6, 22);
            rBtnTest4.Name = "rBtnTest4";
            rBtnTest4.Size = new Size(94, 19);
            rBtnTest4.TabIndex = 0;
            rBtnTest4.TabStop = true;
            rBtnTest4.Text = "radioButton1";
            rBtnTest4.UseVisualStyleBackColor = true;
            // 
            // gB1
            // 
            gB1.Controls.Add(rBtnTest3);
            gB1.Controls.Add(rBtnTest);
            gB1.Controls.Add(rBtnTest2);
            gB1.Location = new Point(476, 108);
            gB1.Name = "gB1";
            gB1.Size = new Size(117, 100);
            gB1.TabIndex = 8;
            gB1.TabStop = false;
            gB1.Text = "Группа 1";
            // 
            // rBtnTest3
            // 
            rBtnTest3.AutoSize = true;
            rBtnTest3.Location = new Point(10, 72);
            rBtnTest3.Name = "rBtnTest3";
            rBtnTest3.Size = new Size(94, 19);
            rBtnTest3.TabIndex = 7;
            rBtnTest3.TabStop = true;
            rBtnTest3.Text = "radioButton1";
            rBtnTest3.UseVisualStyleBackColor = true;
            // 
            // rBtnTest
            // 
            rBtnTest.AutoSize = true;
            rBtnTest.Location = new Point(10, 22);
            rBtnTest.Name = "rBtnTest";
            rBtnTest.Size = new Size(94, 19);
            rBtnTest.TabIndex = 5;
            rBtnTest.Text = "radioButton1";
            rBtnTest.UseVisualStyleBackColor = true;
            // 
            // rBtnTest2
            // 
            rBtnTest2.AutoSize = true;
            rBtnTest2.Location = new Point(10, 47);
            rBtnTest2.Name = "rBtnTest2";
            rBtnTest2.Size = new Size(94, 19);
            rBtnTest2.TabIndex = 6;
            rBtnTest2.Text = "radioButton1";
            rBtnTest2.UseVisualStyleBackColor = true;
            // 
            // gB2
            // 
            gB2.Controls.Add(rBtn5);
            gB2.Controls.Add(rBtnTest4);
            gB2.Location = new Point(621, 108);
            gB2.Name = "gB2";
            gB2.Size = new Size(133, 75);
            gB2.TabIndex = 9;
            gB2.TabStop = false;
            gB2.Text = "Группа 2";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(821, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новыйToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            новыйToolStripMenuItem.Checked = true;
            новыйToolStripMenuItem.CheckState = CheckState.Checked;
            новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            новыйToolStripMenuItem.Size = new Size(133, 22);
            новыйToolStripMenuItem.Text = "Новый";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text|*.txt";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // bntOpenFail
            // 
            bntOpenFail.Location = new Point(730, 236);
            bntOpenFail.Name = "bntOpenFail";
            bntOpenFail.Size = new Size(75, 23);
            bntOpenFail.TabIndex = 11;
            bntOpenFail.Text = "Открыть";
            bntOpenFail.UseVisualStyleBackColor = true;
            bntOpenFail.Click += bntOpenFail_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(730, 276);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(75, 23);
            btnSaveFile.TabIndex = 12;
            btnSaveFile.Text = "Сохранить";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 431);
            Controls.Add(btnSaveFile);
            Controls.Add(bntOpenFail);
            Controls.Add(gB2);
            Controls.Add(gB1);
            Controls.Add(chBTest);
            Controls.Add(tbTest);
            Controls.Add(lblTest);
            Controls.Add(btnTest2);
            Controls.Add(btnTest);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Тестовое приложение";
            gB1.ResumeLayout(false);
            gB1.PerformLayout();
            gB2.ResumeLayout(false);
            gB2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private Button btnTest2;
        private Label lblTest;
        private TextBox tbTest;
        private CheckBox chBTest;
        private RadioButton rBtn5;
        private RadioButton rBtnTest4;
        private GroupBox gB1;
        private RadioButton rBtnTest3;
        private RadioButton rBtnTest;
        private RadioButton rBtnTest2;
        private GroupBox gB2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новыйToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private FontDialog fontDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button bntOpenFail;
        private Button btnSaveFile;
    }
}
