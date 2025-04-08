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
        TemperaturLabel.Text = "\u00b0C";
    }
    private void KC_CheckedChanged(object sender, EventArgs e)
    {
        TemperaturLabel.Text = "\u00b0K";
    }

    private void CF_CheckedChanged(object sender, EventArgs e)
    {
        TemperaturLabel.Text = "\u00b0C";
    }

    private void FC_CheckedChanged(object sender, EventArgs e)
    {
        TemperaturLabel.Text = "\u00b0F";
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
            
            string inputText = RechnerText.Text;
            
            if (CK.Checked)
            {
                double.TryParse(inputText, out double inputTemp);
                
                double ergebnis = inputTemp + 273.15;
                
                Resultat.Text = $"{ergebnis:f2} \u00b0K";
            }
            
            else if (KC.Checked)
            {
                double.TryParse(inputText, out double inputTemp);
                
                double ergebnis = inputTemp - 273.15;
                
                Resultat.Text = $"{ergebnis:f2} \u00b0C";
            }
            
            else if (CF.Checked)
            {
                double.TryParse(inputText, out double inputTemp);
                
                double ergebnis = (inputTemp * 1.8) + 32;
                
                Resultat.Text = $"{ergebnis:f2} \u00b0F";
            }
            
            else if (FC.Checked)
            {
                double.TryParse(inputText, out double inputTemp);
                
                double ergebnis = (inputTemp - 32) / 1.8;
                
                Resultat.Text = $"{ergebnis:f2} \u00b0C";
            }
        }
    }
    
}