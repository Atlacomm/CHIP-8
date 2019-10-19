using System.Windows.Forms;

namespace CHIP8.Windows
{
    partial class SettingsWindow
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
            this.labelButton0 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelButtonF = new System.Windows.Forms.Label();
            this.labelButtonE = new System.Windows.Forms.Label();
            this.labelButtonD = new System.Windows.Forms.Label();
            this.labelButtonC = new System.Windows.Forms.Label();
            this.labelButtonB = new System.Windows.Forms.Label();
            this.labelButtonA = new System.Windows.Forms.Label();
            this.labelButton9 = new System.Windows.Forms.Label();
            this.labelButton8 = new System.Windows.Forms.Label();
            this.labelButton7 = new System.Windows.Forms.Label();
            this.labelButton6 = new System.Windows.Forms.Label();
            this.labelButton5 = new System.Windows.Forms.Label();
            this.labelButton4 = new System.Windows.Forms.Label();
            this.labelButton3 = new System.Windows.Forms.Label();
            this.labelButton2 = new System.Windows.Forms.Label();
            this.labelButton1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.keyQuery8 = new CHIP8.Controls.KeyQuery();
            this.keyQuery9 = new CHIP8.Controls.KeyQuery();
            this.keyQueryA = new CHIP8.Controls.KeyQuery();
            this.keyQueryB = new CHIP8.Controls.KeyQuery();
            this.keyQueryC = new CHIP8.Controls.KeyQuery();
            this.keyQueryD = new CHIP8.Controls.KeyQuery();
            this.keyQueryE = new CHIP8.Controls.KeyQuery();
            this.keyQueryF = new CHIP8.Controls.KeyQuery();
            this.keyQuery4 = new CHIP8.Controls.KeyQuery();
            this.keyQuery5 = new CHIP8.Controls.KeyQuery();
            this.keyQuery6 = new CHIP8.Controls.KeyQuery();
            this.keyQuery7 = new CHIP8.Controls.KeyQuery();
            this.keyQuery2 = new CHIP8.Controls.KeyQuery();
            this.keyQuery3 = new CHIP8.Controls.KeyQuery();
            this.keyQuery1 = new CHIP8.Controls.KeyQuery();
            this.keyQuery0 = new CHIP8.Controls.KeyQuery();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelButton0
            // 
            this.labelButton0.AutoSize = true;
            this.labelButton0.Location = new System.Drawing.Point(6, 22);
            this.labelButton0.Name = "labelButton0";
            this.labelButton0.Size = new System.Drawing.Size(47, 13);
            this.labelButton0.TabIndex = 0;
            this.labelButton0.Text = "Button 0";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.keyQuery8);
            this.groupBoxInput.Controls.Add(this.keyQuery9);
            this.groupBoxInput.Controls.Add(this.keyQueryA);
            this.groupBoxInput.Controls.Add(this.keyQueryB);
            this.groupBoxInput.Controls.Add(this.keyQueryC);
            this.groupBoxInput.Controls.Add(this.keyQueryD);
            this.groupBoxInput.Controls.Add(this.keyQueryE);
            this.groupBoxInput.Controls.Add(this.keyQueryF);
            this.groupBoxInput.Controls.Add(this.keyQuery4);
            this.groupBoxInput.Controls.Add(this.keyQuery5);
            this.groupBoxInput.Controls.Add(this.keyQuery6);
            this.groupBoxInput.Controls.Add(this.keyQuery7);
            this.groupBoxInput.Controls.Add(this.keyQuery2);
            this.groupBoxInput.Controls.Add(this.keyQuery3);
            this.groupBoxInput.Controls.Add(this.keyQuery1);
            this.groupBoxInput.Controls.Add(this.keyQuery0);
            this.groupBoxInput.Controls.Add(this.labelButtonF);
            this.groupBoxInput.Controls.Add(this.labelButtonE);
            this.groupBoxInput.Controls.Add(this.labelButtonD);
            this.groupBoxInput.Controls.Add(this.labelButtonC);
            this.groupBoxInput.Controls.Add(this.labelButtonB);
            this.groupBoxInput.Controls.Add(this.labelButtonA);
            this.groupBoxInput.Controls.Add(this.labelButton9);
            this.groupBoxInput.Controls.Add(this.labelButton8);
            this.groupBoxInput.Controls.Add(this.labelButton7);
            this.groupBoxInput.Controls.Add(this.labelButton6);
            this.groupBoxInput.Controls.Add(this.labelButton5);
            this.groupBoxInput.Controls.Add(this.labelButton4);
            this.groupBoxInput.Controls.Add(this.labelButton3);
            this.groupBoxInput.Controls.Add(this.labelButton2);
            this.groupBoxInput.Controls.Add(this.labelButton1);
            this.groupBoxInput.Controls.Add(this.labelButton0);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(466, 231);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // labelButtonF
            // 
            this.labelButtonF.AutoSize = true;
            this.labelButtonF.Location = new System.Drawing.Point(246, 204);
            this.labelButtonF.Name = "labelButtonF";
            this.labelButtonF.Size = new System.Drawing.Size(47, 13);
            this.labelButtonF.TabIndex = 31;
            this.labelButtonF.Text = "Button F";
            // 
            // labelButtonE
            // 
            this.labelButtonE.AutoSize = true;
            this.labelButtonE.Location = new System.Drawing.Point(246, 178);
            this.labelButtonE.Name = "labelButtonE";
            this.labelButtonE.Size = new System.Drawing.Size(48, 13);
            this.labelButtonE.TabIndex = 29;
            this.labelButtonE.Text = "Button E";
            // 
            // labelButtonD
            // 
            this.labelButtonD.AutoSize = true;
            this.labelButtonD.Location = new System.Drawing.Point(246, 152);
            this.labelButtonD.Name = "labelButtonD";
            this.labelButtonD.Size = new System.Drawing.Size(49, 13);
            this.labelButtonD.TabIndex = 27;
            this.labelButtonD.Text = "Button D";
            // 
            // labelButtonC
            // 
            this.labelButtonC.AutoSize = true;
            this.labelButtonC.Location = new System.Drawing.Point(246, 126);
            this.labelButtonC.Name = "labelButtonC";
            this.labelButtonC.Size = new System.Drawing.Size(48, 13);
            this.labelButtonC.TabIndex = 25;
            this.labelButtonC.Text = "Button C";
            // 
            // labelButtonB
            // 
            this.labelButtonB.AutoSize = true;
            this.labelButtonB.Location = new System.Drawing.Point(246, 100);
            this.labelButtonB.Name = "labelButtonB";
            this.labelButtonB.Size = new System.Drawing.Size(48, 13);
            this.labelButtonB.TabIndex = 23;
            this.labelButtonB.Text = "Button B";
            // 
            // labelButtonA
            // 
            this.labelButtonA.AutoSize = true;
            this.labelButtonA.Location = new System.Drawing.Point(246, 74);
            this.labelButtonA.Name = "labelButtonA";
            this.labelButtonA.Size = new System.Drawing.Size(48, 13);
            this.labelButtonA.TabIndex = 21;
            this.labelButtonA.Text = "Button A";
            // 
            // labelButton9
            // 
            this.labelButton9.AutoSize = true;
            this.labelButton9.Location = new System.Drawing.Point(246, 48);
            this.labelButton9.Name = "labelButton9";
            this.labelButton9.Size = new System.Drawing.Size(47, 13);
            this.labelButton9.TabIndex = 19;
            this.labelButton9.Text = "Button 9";
            // 
            // labelButton8
            // 
            this.labelButton8.AutoSize = true;
            this.labelButton8.Location = new System.Drawing.Point(246, 22);
            this.labelButton8.Name = "labelButton8";
            this.labelButton8.Size = new System.Drawing.Size(47, 13);
            this.labelButton8.TabIndex = 17;
            this.labelButton8.Text = "Button 8";
            // 
            // labelButton7
            // 
            this.labelButton7.AutoSize = true;
            this.labelButton7.Location = new System.Drawing.Point(6, 204);
            this.labelButton7.Name = "labelButton7";
            this.labelButton7.Size = new System.Drawing.Size(47, 13);
            this.labelButton7.TabIndex = 15;
            this.labelButton7.Text = "Button 7";
            // 
            // labelButton6
            // 
            this.labelButton6.AutoSize = true;
            this.labelButton6.Location = new System.Drawing.Point(6, 178);
            this.labelButton6.Name = "labelButton6";
            this.labelButton6.Size = new System.Drawing.Size(47, 13);
            this.labelButton6.TabIndex = 13;
            this.labelButton6.Text = "Button 6";
            // 
            // labelButton5
            // 
            this.labelButton5.AutoSize = true;
            this.labelButton5.Location = new System.Drawing.Point(6, 152);
            this.labelButton5.Name = "labelButton5";
            this.labelButton5.Size = new System.Drawing.Size(47, 13);
            this.labelButton5.TabIndex = 11;
            this.labelButton5.Text = "Button 5";
            // 
            // labelButton4
            // 
            this.labelButton4.AutoSize = true;
            this.labelButton4.Location = new System.Drawing.Point(6, 126);
            this.labelButton4.Name = "labelButton4";
            this.labelButton4.Size = new System.Drawing.Size(47, 13);
            this.labelButton4.TabIndex = 9;
            this.labelButton4.Text = "Button 4";
            // 
            // labelButton3
            // 
            this.labelButton3.AutoSize = true;
            this.labelButton3.Location = new System.Drawing.Point(6, 100);
            this.labelButton3.Name = "labelButton3";
            this.labelButton3.Size = new System.Drawing.Size(47, 13);
            this.labelButton3.TabIndex = 7;
            this.labelButton3.Text = "Button 3";
            // 
            // labelButton2
            // 
            this.labelButton2.AutoSize = true;
            this.labelButton2.Location = new System.Drawing.Point(6, 74);
            this.labelButton2.Name = "labelButton2";
            this.labelButton2.Size = new System.Drawing.Size(47, 13);
            this.labelButton2.TabIndex = 5;
            this.labelButton2.Text = "Button 2";
            // 
            // labelButton1
            // 
            this.labelButton1.AutoSize = true;
            this.labelButton1.Location = new System.Drawing.Point(6, 48);
            this.labelButton1.Name = "labelButton1";
            this.labelButton1.Size = new System.Drawing.Size(47, 13);
            this.labelButton1.TabIndex = 3;
            this.labelButton1.Text = "Button 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // keyQuery8
            // 
            this.keyQuery8.BackColor = System.Drawing.Color.White;
            this.keyQuery8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery8.Location = new System.Drawing.Point(322, 19);
            this.keyQuery8.Name = "keyQuery8";
            this.keyQuery8.Size = new System.Drawing.Size(128, 20);
            this.keyQuery8.TabIndex = 47;
            this.keyQuery8.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery9
            // 
            this.keyQuery9.BackColor = System.Drawing.Color.White;
            this.keyQuery9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery9.Location = new System.Drawing.Point(322, 45);
            this.keyQuery9.Name = "keyQuery9";
            this.keyQuery9.Size = new System.Drawing.Size(128, 20);
            this.keyQuery9.TabIndex = 46;
            this.keyQuery9.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQueryA
            // 
            this.keyQueryA.BackColor = System.Drawing.Color.White;
            this.keyQueryA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQueryA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQueryA.Location = new System.Drawing.Point(322, 71);
            this.keyQueryA.Name = "keyQueryA";
            this.keyQueryA.Size = new System.Drawing.Size(128, 20);
            this.keyQueryA.TabIndex = 45;
            this.keyQueryA.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQueryA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQueryB
            // 
            this.keyQueryB.BackColor = System.Drawing.Color.White;
            this.keyQueryB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQueryB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQueryB.Location = new System.Drawing.Point(322, 97);
            this.keyQueryB.Name = "keyQueryB";
            this.keyQueryB.Size = new System.Drawing.Size(128, 20);
            this.keyQueryB.TabIndex = 44;
            this.keyQueryB.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQueryB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQueryC
            // 
            this.keyQueryC.BackColor = System.Drawing.Color.White;
            this.keyQueryC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQueryC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQueryC.Location = new System.Drawing.Point(322, 123);
            this.keyQueryC.Name = "keyQueryC";
            this.keyQueryC.Size = new System.Drawing.Size(128, 20);
            this.keyQueryC.TabIndex = 43;
            this.keyQueryC.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQueryC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQueryD
            // 
            this.keyQueryD.BackColor = System.Drawing.Color.White;
            this.keyQueryD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQueryD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQueryD.Location = new System.Drawing.Point(322, 149);
            this.keyQueryD.Name = "keyQueryD";
            this.keyQueryD.Size = new System.Drawing.Size(128, 20);
            this.keyQueryD.TabIndex = 42;
            this.keyQueryD.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQueryD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQueryE
            // 
            this.keyQueryE.BackColor = System.Drawing.Color.White;
            this.keyQueryE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQueryE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQueryE.Location = new System.Drawing.Point(322, 175);
            this.keyQueryE.Name = "keyQueryE";
            this.keyQueryE.Size = new System.Drawing.Size(128, 20);
            this.keyQueryE.TabIndex = 41;
            this.keyQueryE.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQueryE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQueryF
            // 
            this.keyQueryF.BackColor = System.Drawing.Color.White;
            this.keyQueryF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQueryF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQueryF.Location = new System.Drawing.Point(322, 201);
            this.keyQueryF.Name = "keyQueryF";
            this.keyQueryF.Size = new System.Drawing.Size(128, 20);
            this.keyQueryF.TabIndex = 40;
            this.keyQueryF.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQueryF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery4
            // 
            this.keyQuery4.BackColor = System.Drawing.Color.White;
            this.keyQuery4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery4.Location = new System.Drawing.Point(82, 123);
            this.keyQuery4.Name = "keyQuery4";
            this.keyQuery4.Size = new System.Drawing.Size(128, 20);
            this.keyQuery4.TabIndex = 39;
            this.keyQuery4.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery5
            // 
            this.keyQuery5.BackColor = System.Drawing.Color.White;
            this.keyQuery5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery5.Location = new System.Drawing.Point(82, 149);
            this.keyQuery5.Name = "keyQuery5";
            this.keyQuery5.Size = new System.Drawing.Size(128, 20);
            this.keyQuery5.TabIndex = 38;
            this.keyQuery5.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery6
            // 
            this.keyQuery6.BackColor = System.Drawing.Color.White;
            this.keyQuery6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery6.Location = new System.Drawing.Point(82, 175);
            this.keyQuery6.Name = "keyQuery6";
            this.keyQuery6.Size = new System.Drawing.Size(128, 20);
            this.keyQuery6.TabIndex = 37;
            this.keyQuery6.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery7
            // 
            this.keyQuery7.BackColor = System.Drawing.Color.White;
            this.keyQuery7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery7.Location = new System.Drawing.Point(82, 201);
            this.keyQuery7.Name = "keyQuery7";
            this.keyQuery7.Size = new System.Drawing.Size(128, 20);
            this.keyQuery7.TabIndex = 36;
            this.keyQuery7.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery2
            // 
            this.keyQuery2.BackColor = System.Drawing.Color.White;
            this.keyQuery2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery2.Location = new System.Drawing.Point(82, 71);
            this.keyQuery2.Name = "keyQuery2";
            this.keyQuery2.Size = new System.Drawing.Size(128, 20);
            this.keyQuery2.TabIndex = 35;
            this.keyQuery2.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery3
            // 
            this.keyQuery3.BackColor = System.Drawing.Color.White;
            this.keyQuery3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery3.Location = new System.Drawing.Point(82, 97);
            this.keyQuery3.Name = "keyQuery3";
            this.keyQuery3.Size = new System.Drawing.Size(128, 20);
            this.keyQuery3.TabIndex = 34;
            this.keyQuery3.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery1
            // 
            this.keyQuery1.BackColor = System.Drawing.Color.White;
            this.keyQuery1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery1.Location = new System.Drawing.Point(82, 45);
            this.keyQuery1.Name = "keyQuery1";
            this.keyQuery1.Size = new System.Drawing.Size(128, 20);
            this.keyQuery1.TabIndex = 33;
            this.keyQuery1.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // keyQuery0
            // 
            this.keyQuery0.BackColor = System.Drawing.Color.White;
            this.keyQuery0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyQuery0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyQuery0.Location = new System.Drawing.Point(82, 19);
            this.keyQuery0.Name = "keyQuery0";
            this.keyQuery0.Size = new System.Drawing.Size(128, 20);
            this.keyQuery0.TabIndex = 32;
            this.keyQuery0.KeySelected += new System.Windows.Forms.KeyEventHandler(this.keyQuery_KeySelected);
            this.keyQuery0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyQuery_MouseClick);
            // 
            // SettingsWindow
            // 
            this.ClientSize = new System.Drawing.Size(490, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxInput;
        private Label labelButton0;
        private Label labelButton1;
        private Label labelButton2;
        private Label labelButton3;
        private Label labelButton4;
        private Label labelButton5;
        private Label labelButton6;
        private Label labelButton7;
        private Label labelButton8;
        private Label labelButton9;
        private Label labelButtonA;
        private Label labelButtonB;
        private Label labelButtonC;
        private Label labelButtonD;
        private Label labelButtonE;
        private Label labelButtonF;
        private Controls.KeyQuery keyQuery0;
        private Controls.KeyQuery keyQuery1;
        private Controls.KeyQuery keyQuery2;
        private Controls.KeyQuery keyQuery3;
        private Controls.KeyQuery keyQuery4;
        private Controls.KeyQuery keyQuery5;
        private Controls.KeyQuery keyQuery6;
        private Controls.KeyQuery keyQuery7;
        private Controls.KeyQuery keyQuery8;
        private Controls.KeyQuery keyQuery9;
        private Controls.KeyQuery keyQueryA;
        private Controls.KeyQuery keyQueryB;
        private Controls.KeyQuery keyQueryC;
        private Controls.KeyQuery keyQueryD;
        private Controls.KeyQuery keyQueryE;
        private Controls.KeyQuery keyQueryF;
        private Button button1;
        private Button button2;
    }
}