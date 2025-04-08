namespace M322_WPF_TempRechner;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {
        
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
        
    }

    private void CK_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void Umrechnen_Click(object sender, EventArgs e)
    {
        if (RechnerText.Text == "")
        {
            ErrorLabel.Text = "!!Es wurde nichts Eingegeben!!";
        }

        else
        {
            ErrorLabel.Text = "";

            if (CK.Checked)
            {
                TemperaturLabel.Text = "\u00b0C";
                
                
            }
        }
    }
}