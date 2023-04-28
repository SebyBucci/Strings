using System.Globalization;

namespace bucci.sebastian.3i.MAUIString;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        string inputString = InputEntry.Text;

        // Elaborazione della stringa
        string maiuscola = inputString.ToUpper();
        string minuscola = inputString.ToLower();
        string capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputString);
        bool palindroma = inputString.SequenceEqual(inputString.Reverse());
        string reverse = new string(inputString.Reverse().ToArray());
        int numParole = inputString.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
        int numLettere = inputString.Length;
        bool alfanumerica = inputString.All(c => char.IsLetterOrDigit(c));
    // Mostra i risultati
    Maiuscola.Text = $"Maiuscola: {maiuscola}";
    Minuscola.Text = $"Minuscola: {minuscola}";
    Capitalized.Text = $"Capitalized: {capitalized}";
    Palindroma.Text = $"Palindroma: {(palindroma ? "sì" : "no")}";
    Reverse.Text = $"Reverse: {reverse}";
    NumParole.Text = $"Numero parole: {numParole}";
    NumLettere.Text = $"Numero lettere: {numLettere}";
     Alfanumerica.Text = $"Alfanumerica: {(alfanumerica ? "sì" : "no")}";
    }



