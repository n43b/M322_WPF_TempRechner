namespace M322_WPF_TempRechner;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        CK = new System.Windows.Forms.RadioButton();
        KC = new System.Windows.Forms.RadioButton();
        CF = new System.Windows.Forms.RadioButton();
        FC = new System.Windows.Forms.RadioButton();
        groupBox1 = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        RechnerText = new System.Windows.Forms.TextBox();
        TemperaturLabel = new System.Windows.Forms.Label();
        Umrechnen = new System.Windows.Forms.Button();
        ErrorLabel = new System.Windows.Forms.Label();
        Resultat = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // CK
        // 
        CK.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        CK.Location = new System.Drawing.Point(18, 44);
        CK.Name = "CK";
        CK.Size = new System.Drawing.Size(132, 40);
        CK.TabIndex = 0;
        CK.TabStop = true;
        CK.Text = "°C   ➔   °K";
        CK.UseVisualStyleBackColor = true;
        CK.CheckedChanged += CK_CheckedChanged;
        // 
        // KC
        // 
        KC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        KC.Location = new System.Drawing.Point(18, 90);
        KC.Name = "KC";
        KC.Size = new System.Drawing.Size(132, 40);
        KC.TabIndex = 1;
        KC.TabStop = true;
        KC.Text = "°K   ➔   °C";
        KC.UseVisualStyleBackColor = true;
        // 
        // CF
        // 
        CF.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        CF.Location = new System.Drawing.Point(18, 136);
        CF.Name = "CF";
        CF.Size = new System.Drawing.Size(132, 40);
        CF.TabIndex = 2;
        CF.TabStop = true;
        CF.Text = "°C   ➔   °F";
        CF.UseVisualStyleBackColor = true;
        // 
        // FC
        // 
        FC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FC.Location = new System.Drawing.Point(18, 182);
        FC.Name = "FC";
        FC.Size = new System.Drawing.Size(132, 40);
        FC.TabIndex = 3;
        FC.TabStop = true;
        FC.Text = "°F   ➔   °C";
        FC.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(FC);
        groupBox1.Controls.Add(CF);
        groupBox1.Controls.Add(KC);
        groupBox1.Controls.Add(CK);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox1.Location = new System.Drawing.Point(23, 207);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(357, 231);
        groupBox1.TabIndex = 4;
        groupBox1.TabStop = false;
        groupBox1.Text = "Umrechnung";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(26, 58);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(164, 53);
        label1.TabIndex = 5;
        label1.Text = "Temperratur:";
        // 
        // RechnerText
        // 
        RechnerText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        RechnerText.Location = new System.Drawing.Point(225, 58);
        RechnerText.Multiline = true;
        RechnerText.Name = "RechnerText";
        RechnerText.Size = new System.Drawing.Size(155, 53);
        RechnerText.TabIndex = 6;
        // 
        // TemperaturLabel
        // 
        TemperaturLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        TemperaturLabel.Location = new System.Drawing.Point(386, 70);
        TemperaturLabel.Name = "TemperaturLabel";
        TemperaturLabel.Size = new System.Drawing.Size(49, 41);
        TemperaturLabel.TabIndex = 7;
        TemperaturLabel.Click += label2_Click;
        // 
        // Umrechnen
        // 
        Umrechnen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Umrechnen.Location = new System.Drawing.Point(407, 374);
        Umrechnen.Name = "Umrechnen";
        Umrechnen.Size = new System.Drawing.Size(162, 64);
        Umrechnen.TabIndex = 8;
        Umrechnen.Text = "Umrechnen";
        Umrechnen.UseVisualStyleBackColor = true;
        Umrechnen.Click += Umrechnen_Click;
        // 
        // ErrorLabel
        // 
        ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        ErrorLabel.ForeColor = System.Drawing.Color.Red;
        ErrorLabel.Location = new System.Drawing.Point(407, 242);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new System.Drawing.Size(378, 95);
        ErrorLabel.TabIndex = 9;
        // 
        // Resultat
        // 
        Resultat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Resultat.ForeColor = System.Drawing.Color.Red;
        Resultat.Location = new System.Drawing.Point(225, 141);
        Resultat.Name = "Resultat";
        Resultat.Size = new System.Drawing.Size(155, 53);
        Resultat.TabIndex = 10;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Resultat);
        Controls.Add(ErrorLabel);
        Controls.Add(Umrechnen);
        Controls.Add(TemperaturLabel);
        Controls.Add(RechnerText);
        Controls.Add(label1);
        Controls.Add(groupBox1);
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label Resultat;

    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.Button Umrechnen;

    private System.Windows.Forms.Label TemperaturLabel;

    private System.Windows.Forms.TextBox RechnerText;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.RadioButton KC;
    private System.Windows.Forms.RadioButton CF;
    private System.Windows.Forms.RadioButton FC;

    private System.Windows.Forms.RadioButton CK;

    #endregion
}