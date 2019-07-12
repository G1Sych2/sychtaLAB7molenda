namespace ZGADYWANKA
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.Zakod = new System.Windows.Forms.Label();
            this.ZakDo = new System.Windows.Forms.Label();
            this.textBoxfrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.GenButton = new System.Windows.Forms.Button();
            this.StartInfoLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMoves = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonStory = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.labelZaMaloZaDuzo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(34, 35);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(154, 61);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "Nowa Gra";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(264, 35);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(157, 61);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Pauza";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Zakod
            // 
            this.Zakod.AutoSize = true;
            this.Zakod.Location = new System.Drawing.Point(31, 139);
            this.Zakod.Name = "Zakod";
            this.Zakod.Size = new System.Drawing.Size(76, 17);
            this.Zakod.TabIndex = 2;
            this.Zakod.Text = "Zakres od:";
            // 
            // ZakDo
            // 
            this.ZakDo.AutoSize = true;
            this.ZakDo.Location = new System.Drawing.Point(31, 174);
            this.ZakDo.Name = "ZakDo";
            this.ZakDo.Size = new System.Drawing.Size(76, 17);
            this.ZakDo.TabIndex = 3;
            this.ZakDo.Text = "Zakres do:";
            // 
            // textBoxfrom
            // 
            this.textBoxfrom.Location = new System.Drawing.Point(117, 139);
            this.textBoxfrom.Name = "textBoxfrom";
            this.textBoxfrom.Size = new System.Drawing.Size(160, 22);
            this.textBoxfrom.TabIndex = 4;
            this.textBoxfrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxfrom_KeyPress);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(117, 169);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(160, 22);
            this.textBoxTo.TabIndex = 5;
            this.textBoxTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTo_KeyPress);
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(298, 151);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(122, 40);
            this.GenButton.TabIndex = 6;
            this.GenButton.Text = "Wylosuj";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // StartInfoLabel
            // 
            this.StartInfoLabel.AutoSize = true;
            this.StartInfoLabel.Location = new System.Drawing.Point(31, 212);
            this.StartInfoLabel.Name = "StartInfoLabel";
            this.StartInfoLabel.Size = new System.Drawing.Size(197, 17);
            this.StartInfoLabel.TabIndex = 7;
            this.StartInfoLabel.Text = "Podaj zakres i wciśnij Wylosuj!";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(299, 212);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(70, 17);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Czas Gry:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(34, 255);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(119, 22);
            this.textBoxNumber.TabIndex = 9;
            this.textBoxNumber.Text = "Wpisz Liczbę";
            this.textBoxNumber.Click += new System.EventHandler(this.textBoxNumber_Click);
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Enabled = false;
            this.buttonCheck.Location = new System.Drawing.Point(264, 247);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(157, 30);
            this.buttonCheck.TabIndex = 10;
            this.buttonCheck.Text = "Sprawdź";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(31, 321);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(127, 17);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "Całkowity czas gry:";
            this.labelTime.Visible = false;
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Location = new System.Drawing.Point(31, 354);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(102, 17);
            this.labelMoves.TabIndex = 12;
            this.labelMoves.Text = "Liczba ruchów:";
            this.labelMoves.Visible = false;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(31, 383);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(91, 17);
            this.labelNumber.TabIndex = 13;
            this.labelNumber.Text = "Wylosowana:";
            this.labelNumber.Visible = false;
            // 
            // buttonStory
            // 
            this.buttonStory.Location = new System.Drawing.Point(34, 433);
            this.buttonStory.Name = "buttonStory";
            this.buttonStory.Size = new System.Drawing.Size(154, 37);
            this.buttonStory.TabIndex = 14;
            this.buttonStory.Text = "Historia Gry";
            this.buttonStory.UseVisualStyleBackColor = true;
            this.buttonStory.Click += new System.EventHandler(this.buttonStory_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(264, 432);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(156, 38);
            this.buttonInfo.TabIndex = 15;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 1000;
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // labelZaMaloZaDuzo
            // 
            this.labelZaMaloZaDuzo.AutoSize = true;
            this.labelZaMaloZaDuzo.Location = new System.Drawing.Point(31, 292);
            this.labelZaMaloZaDuzo.Name = "labelZaMaloZaDuzo";
            this.labelZaMaloZaDuzo.Size = new System.Drawing.Size(62, 17);
            this.labelZaMaloZaDuzo.TabIndex = 16;
            this.labelZaMaloZaDuzo.Text = "Zgadłeś!";
            this.labelZaMaloZaDuzo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 512);
            this.Controls.Add(this.labelZaMaloZaDuzo);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonStory);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.StartInfoLabel);
            this.Controls.Add(this.GenButton);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxfrom);
            this.Controls.Add(this.ZakDo);
            this.Controls.Add(this.Zakod);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.NewGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label Zakod;
        private System.Windows.Forms.Label ZakDo;
        private System.Windows.Forms.TextBox textBoxfrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.Label StartInfoLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonStory;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.Label labelZaMaloZaDuzo;
    }
}

