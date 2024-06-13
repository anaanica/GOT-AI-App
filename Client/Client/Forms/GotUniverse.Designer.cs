namespace Client.Forms
{
    partial class GotUniverse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GotUniverse));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpGotApi = new System.Windows.Forms.TabPage();
            this.btClearGotContinents = new System.Windows.Forms.Button();
            this.btGetGotContinents = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbGotContinents = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btGetGotCharacters = new System.Windows.Forms.Button();
            this.lbGotCharacters = new System.Windows.Forms.ListBox();
            this.tpAiApi = new System.Windows.Forms.TabPage();
            this.btSend = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.tpRest = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btClearTextBoxes = new System.Windows.Forms.Button();
            this.btAddGotCharacter = new System.Windows.Forms.Button();
            this.lbFeedback = new System.Windows.Forms.Label();
            this.cbValidation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbImageUrl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFamily = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tpSoap = new System.Windows.Forms.TabPage();
            this.lbContinentResult = new System.Windows.Forms.Label();
            this.btSearchContinent = new System.Windows.Forms.Button();
            this.tbContinent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbContinentSearch = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCharacterResult = new System.Windows.Forms.Label();
            this.btSearchCharacter = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.lbCharacterSearch = new System.Windows.Forms.ListBox();
            this.tpJaxb = new System.Windows.Forms.TabPage();
            this.lbValidation = new System.Windows.Forms.Label();
            this.btValidate = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpGotApi.SuspendLayout();
            this.tpAiApi.SuspendLayout();
            this.tpRest.SuspendLayout();
            this.tpSoap.SuspendLayout();
            this.tpJaxb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpGotApi);
            this.tabControl.Controls.Add(this.tpAiApi);
            this.tabControl.Controls.Add(this.tpRest);
            this.tabControl.Controls.Add(this.tpSoap);
            this.tabControl.Controls.Add(this.tpJaxb);
            this.tabControl.Location = new System.Drawing.Point(2, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1077, 575);
            this.tabControl.TabIndex = 0;
            // 
            // tpGotApi
            // 
            this.tpGotApi.Controls.Add(this.btClearGotContinents);
            this.tpGotApi.Controls.Add(this.btGetGotContinents);
            this.tpGotApi.Controls.Add(this.label7);
            this.tpGotApi.Controls.Add(this.lbGotContinents);
            this.tpGotApi.Controls.Add(this.label6);
            this.tpGotApi.Controls.Add(this.btClear);
            this.tpGotApi.Controls.Add(this.btGetGotCharacters);
            this.tpGotApi.Controls.Add(this.lbGotCharacters);
            this.tpGotApi.Location = new System.Drawing.Point(4, 29);
            this.tpGotApi.Name = "tpGotApi";
            this.tpGotApi.Padding = new System.Windows.Forms.Padding(3);
            this.tpGotApi.Size = new System.Drawing.Size(1069, 542);
            this.tpGotApi.TabIndex = 0;
            this.tpGotApi.Text = "GOT Api";
            this.tpGotApi.UseVisualStyleBackColor = true;
            // 
            // btClearGotContinents
            // 
            this.btClearGotContinents.Location = new System.Drawing.Point(952, 431);
            this.btClearGotContinents.Name = "btClearGotContinents";
            this.btClearGotContinents.Size = new System.Drawing.Size(99, 51);
            this.btClearGotContinents.TabIndex = 10;
            this.btClearGotContinents.Text = "Clear";
            this.btClearGotContinents.UseVisualStyleBackColor = true;
            this.btClearGotContinents.Click += new System.EventHandler(this.btClearGotContinents_Click);
            // 
            // btGetGotContinents
            // 
            this.btGetGotContinents.Location = new System.Drawing.Point(829, 431);
            this.btGetGotContinents.Name = "btGetGotContinents";
            this.btGetGotContinents.Size = new System.Drawing.Size(103, 51);
            this.btGetGotContinents.TabIndex = 9;
            this.btGetGotContinents.Text = "Get";
            this.btGetGotContinents.UseVisualStyleBackColor = true;
            this.btGetGotContinents.Click += new System.EventHandler(this.btGetGotContinents_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(825, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Game of Thrones continents";
            // 
            // lbGotContinents
            // 
            this.lbGotContinents.FormattingEnabled = true;
            this.lbGotContinents.ItemHeight = 20;
            this.lbGotContinents.Location = new System.Drawing.Point(825, 53);
            this.lbGotContinents.Name = "lbGotContinents";
            this.lbGotContinents.Size = new System.Drawing.Size(226, 344);
            this.lbGotContinents.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Game of Thrones characters";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(244, 431);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(198, 51);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btGetGotCharacters
            // 
            this.btGetGotCharacters.Location = new System.Drawing.Point(6, 431);
            this.btGetGotCharacters.Name = "btGetGotCharacters";
            this.btGetGotCharacters.Size = new System.Drawing.Size(219, 51);
            this.btGetGotCharacters.TabIndex = 4;
            this.btGetGotCharacters.Text = "Get GOT characters";
            this.btGetGotCharacters.UseVisualStyleBackColor = true;
            this.btGetGotCharacters.Click += new System.EventHandler(this.btGetGotCharacters_Click);
            // 
            // lbGotCharacters
            // 
            this.lbGotCharacters.FormattingEnabled = true;
            this.lbGotCharacters.ItemHeight = 20;
            this.lbGotCharacters.Location = new System.Drawing.Point(6, 53);
            this.lbGotCharacters.Name = "lbGotCharacters";
            this.lbGotCharacters.Size = new System.Drawing.Size(803, 344);
            this.lbGotCharacters.TabIndex = 3;
            // 
            // tpAiApi
            // 
            this.tpAiApi.Controls.Add(this.btSend);
            this.tpAiApi.Controls.Add(this.messageBox);
            this.tpAiApi.Controls.Add(this.chatBox);
            this.tpAiApi.Location = new System.Drawing.Point(4, 29);
            this.tpAiApi.Name = "tpAiApi";
            this.tpAiApi.Padding = new System.Windows.Forms.Padding(3);
            this.tpAiApi.Size = new System.Drawing.Size(1069, 542);
            this.tpAiApi.TabIndex = 1;
            this.tpAiApi.Text = "AI Api";
            this.tpAiApi.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(779, 464);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(119, 35);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(157, 473);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(583, 26);
            this.messageBox.TabIndex = 4;
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(157, 44);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatBox.Size = new System.Drawing.Size(755, 400);
            this.chatBox.TabIndex = 3;
            // 
            // tpRest
            // 
            this.tpRest.Controls.Add(this.label2);
            this.tpRest.Controls.Add(this.btClearTextBoxes);
            this.tpRest.Controls.Add(this.btAddGotCharacter);
            this.tpRest.Controls.Add(this.lbFeedback);
            this.tpRest.Controls.Add(this.cbValidation);
            this.tpRest.Controls.Add(this.label1);
            this.tpRest.Controls.Add(this.label12);
            this.tpRest.Controls.Add(this.tbImageUrl);
            this.tpRest.Controls.Add(this.label11);
            this.tpRest.Controls.Add(this.tbImage);
            this.tpRest.Controls.Add(this.label9);
            this.tpRest.Controls.Add(this.tbFamily);
            this.tpRest.Controls.Add(this.tbTitle);
            this.tpRest.Controls.Add(this.label5);
            this.tpRest.Controls.Add(this.tbFullName);
            this.tpRest.Controls.Add(this.label4);
            this.tpRest.Controls.Add(this.tbLastName);
            this.tpRest.Controls.Add(this.label3);
            this.tpRest.Controls.Add(this.tbFirstName);
            this.tpRest.Location = new System.Drawing.Point(4, 29);
            this.tpRest.Name = "tpRest";
            this.tpRest.Padding = new System.Windows.Forms.Padding(3);
            this.tpRest.Size = new System.Drawing.Size(1069, 542);
            this.tpRest.TabIndex = 2;
            this.tpRest.Text = "REST";
            this.tpRest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Title";
            // 
            // btClearTextBoxes
            // 
            this.btClearTextBoxes.Location = new System.Drawing.Point(443, 446);
            this.btClearTextBoxes.Name = "btClearTextBoxes";
            this.btClearTextBoxes.Size = new System.Drawing.Size(124, 47);
            this.btClearTextBoxes.TabIndex = 46;
            this.btClearTextBoxes.Text = "Clear";
            this.btClearTextBoxes.UseVisualStyleBackColor = true;
            this.btClearTextBoxes.Click += new System.EventHandler(this.btClearTextBoxes_Click);
            // 
            // btAddGotCharacter
            // 
            this.btAddGotCharacter.Location = new System.Drawing.Point(106, 446);
            this.btAddGotCharacter.Name = "btAddGotCharacter";
            this.btAddGotCharacter.Size = new System.Drawing.Size(314, 47);
            this.btAddGotCharacter.TabIndex = 45;
            this.btAddGotCharacter.Text = "Add GOT character";
            this.btAddGotCharacter.UseVisualStyleBackColor = true;
            this.btAddGotCharacter.Click += new System.EventHandler(this.btAddGotCharacter_Click);
            // 
            // lbFeedback
            // 
            this.lbFeedback.AutoSize = true;
            this.lbFeedback.Location = new System.Drawing.Point(695, 446);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(0, 20);
            this.lbFeedback.TabIndex = 44;
            // 
            // cbValidation
            // 
            this.cbValidation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValidation.FormattingEnabled = true;
            this.cbValidation.Location = new System.Drawing.Point(699, 330);
            this.cbValidation.Name = "cbValidation";
            this.cbValidation.Size = new System.Drawing.Size(121, 28);
            this.cbValidation.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Validation:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(549, 218);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "ImageUrl";
            // 
            // tbImageUrl
            // 
            this.tbImageUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImageUrl.Location = new System.Drawing.Point(549, 248);
            this.tbImageUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbImageUrl.Name = "tbImageUrl";
            this.tbImageUrl.Size = new System.Drawing.Size(505, 26);
            this.tbImageUrl.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 134);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Image";
            // 
            // tbImage
            // 
            this.tbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImage.Location = new System.Drawing.Point(549, 164);
            this.tbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(505, 26);
            this.tbImage.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Family";
            // 
            // tbFamily
            // 
            this.tbFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFamily.Location = new System.Drawing.Point(549, 79);
            this.tbFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFamily.Name = "tbFamily";
            this.tbFamily.Size = new System.Drawing.Size(505, 26);
            this.tbFamily.TabIndex = 36;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTitle.Location = new System.Drawing.Point(14, 330);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(505, 26);
            this.tbTitle.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "FullName";
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFullName.Location = new System.Drawing.Point(14, 248);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(505, 26);
            this.tbFullName.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "LastName";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLastName.Location = new System.Drawing.Point(14, 164);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(505, 26);
            this.tbLastName.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "FirstName";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFirstName.Location = new System.Drawing.Point(14, 79);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(505, 26);
            this.tbFirstName.TabIndex = 29;
            // 
            // tpSoap
            // 
            this.tpSoap.Controls.Add(this.lbContinentResult);
            this.tpSoap.Controls.Add(this.btSearchContinent);
            this.tpSoap.Controls.Add(this.tbContinent);
            this.tpSoap.Controls.Add(this.label10);
            this.tpSoap.Controls.Add(this.lbContinentSearch);
            this.tpSoap.Controls.Add(this.label8);
            this.tpSoap.Controls.Add(this.lbCharacterResult);
            this.tpSoap.Controls.Add(this.btSearchCharacter);
            this.tpSoap.Controls.Add(this.tbValue);
            this.tpSoap.Controls.Add(this.cbKey);
            this.tpSoap.Controls.Add(this.lbCharacterSearch);
            this.tpSoap.Location = new System.Drawing.Point(4, 29);
            this.tpSoap.Name = "tpSoap";
            this.tpSoap.Padding = new System.Windows.Forms.Padding(3);
            this.tpSoap.Size = new System.Drawing.Size(1069, 542);
            this.tpSoap.TabIndex = 3;
            this.tpSoap.Text = "SOAP";
            this.tpSoap.UseVisualStyleBackColor = true;
            // 
            // lbContinentResult
            // 
            this.lbContinentResult.AutoSize = true;
            this.lbContinentResult.Location = new System.Drawing.Point(844, 493);
            this.lbContinentResult.Name = "lbContinentResult";
            this.lbContinentResult.Size = new System.Drawing.Size(0, 20);
            this.lbContinentResult.TabIndex = 15;
            // 
            // btSearchContinent
            // 
            this.btSearchContinent.Location = new System.Drawing.Point(966, 439);
            this.btSearchContinent.Name = "btSearchContinent";
            this.btSearchContinent.Size = new System.Drawing.Size(94, 39);
            this.btSearchContinent.TabIndex = 14;
            this.btSearchContinent.Text = "Search";
            this.btSearchContinent.UseVisualStyleBackColor = true;
            this.btSearchContinent.Click += new System.EventHandler(this.btSearchContinent_Click);
            // 
            // tbContinent
            // 
            this.tbContinent.Location = new System.Drawing.Point(786, 447);
            this.tbContinent.Name = "tbContinent";
            this.tbContinent.Size = new System.Drawing.Size(173, 26);
            this.tbContinent.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(786, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Search continent";
            // 
            // lbContinentSearch
            // 
            this.lbContinentSearch.FormattingEnabled = true;
            this.lbContinentSearch.ItemHeight = 20;
            this.lbContinentSearch.Location = new System.Drawing.Point(786, 50);
            this.lbContinentSearch.Name = "lbContinentSearch";
            this.lbContinentSearch.Size = new System.Drawing.Size(274, 364);
            this.lbContinentSearch.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Search characters";
            // 
            // lbCharacterResult
            // 
            this.lbCharacterResult.AutoSize = true;
            this.lbCharacterResult.Location = new System.Drawing.Point(526, 494);
            this.lbCharacterResult.Name = "lbCharacterResult";
            this.lbCharacterResult.Size = new System.Drawing.Size(0, 20);
            this.lbCharacterResult.TabIndex = 9;
            // 
            // btSearchCharacter
            // 
            this.btSearchCharacter.Location = new System.Drawing.Point(675, 439);
            this.btSearchCharacter.Name = "btSearchCharacter";
            this.btSearchCharacter.Size = new System.Drawing.Size(104, 39);
            this.btSearchCharacter.TabIndex = 8;
            this.btSearchCharacter.Text = "Search";
            this.btSearchCharacter.UseVisualStyleBackColor = true;
            this.btSearchCharacter.Click += new System.EventHandler(this.btSoapSearch_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(133, 447);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(536, 26);
            this.tbValue.TabIndex = 7;
            // 
            // cbKey
            // 
            this.cbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Location = new System.Drawing.Point(6, 445);
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(121, 28);
            this.cbKey.TabIndex = 6;
            // 
            // lbCharacterSearch
            // 
            this.lbCharacterSearch.FormattingEnabled = true;
            this.lbCharacterSearch.ItemHeight = 20;
            this.lbCharacterSearch.Location = new System.Drawing.Point(6, 50);
            this.lbCharacterSearch.Name = "lbCharacterSearch";
            this.lbCharacterSearch.Size = new System.Drawing.Size(773, 364);
            this.lbCharacterSearch.TabIndex = 5;
            // 
            // tpJaxb
            // 
            this.tpJaxb.Controls.Add(this.btValidate);
            this.tpJaxb.Controls.Add(this.lbValidation);
            this.tpJaxb.Location = new System.Drawing.Point(4, 29);
            this.tpJaxb.Name = "tpJaxb";
            this.tpJaxb.Padding = new System.Windows.Forms.Padding(3);
            this.tpJaxb.Size = new System.Drawing.Size(1069, 542);
            this.tpJaxb.TabIndex = 4;
            this.tpJaxb.Text = "JAXB";
            this.tpJaxb.UseVisualStyleBackColor = true;
            // 
            // lbValidation
            // 
            this.lbValidation.AutoSize = true;
            this.lbValidation.Location = new System.Drawing.Point(22, 28);
            this.lbValidation.Name = "lbValidation";
            this.lbValidation.Size = new System.Drawing.Size(0, 20);
            this.lbValidation.TabIndex = 0;
            // 
            // btValidate
            // 
            this.btValidate.Location = new System.Drawing.Point(26, 109);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(96, 35);
            this.btValidate.TabIndex = 1;
            this.btValidate.Text = "Validate";
            this.btValidate.UseVisualStyleBackColor = true;
            this.btValidate.Click += new System.EventHandler(this.btValidate_Click);
            // 
            // GotUniverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 599);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GotUniverse";
            this.Text = "GotUniverse";
            this.tabControl.ResumeLayout(false);
            this.tpGotApi.ResumeLayout(false);
            this.tpGotApi.PerformLayout();
            this.tpAiApi.ResumeLayout(false);
            this.tpAiApi.PerformLayout();
            this.tpRest.ResumeLayout(false);
            this.tpRest.PerformLayout();
            this.tpSoap.ResumeLayout(false);
            this.tpSoap.PerformLayout();
            this.tpJaxb.ResumeLayout(false);
            this.tpJaxb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpGotApi;
        private System.Windows.Forms.TabPage tpAiApi;
        private System.Windows.Forms.TabPage tpRest;
        private System.Windows.Forms.TabPage tpSoap;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btGetGotCharacters;
        private System.Windows.Forms.ListBox lbGotCharacters;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Button btClearTextBoxes;
        private System.Windows.Forms.Button btAddGotCharacter;
        private System.Windows.Forms.Label lbFeedback;
        private System.Windows.Forms.ComboBox cbValidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbImageUrl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFamily;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbCharacterResult;
        private System.Windows.Forms.Button btSearchCharacter;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.ComboBox cbKey;
        private System.Windows.Forms.ListBox lbCharacterSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbGotContinents;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btGetGotContinents;
        private System.Windows.Forms.Button btClearGotContinents;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbContinentSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btSearchContinent;
        private System.Windows.Forms.TextBox tbContinent;
        private System.Windows.Forms.Label lbContinentResult;
        private System.Windows.Forms.TabPage tpJaxb;
        private System.Windows.Forms.Label lbValidation;
        private System.Windows.Forms.Button btValidate;
    }
}