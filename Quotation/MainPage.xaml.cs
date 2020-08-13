using Xamarin.Forms;

namespace Quotation
{
    public partial class MainPage : ContentPage
    {
        private string[] quotations = {
            "Insanity: doing the same thing over and over again and expecting different results.",
            "Imagination is more important than knowledge.",
            "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
            "Imagination is everything. It is the preview of life's coming attractions.",
            "Life is like riding a bicycle. To keep your balance you must keep moving.",
            "In the middle of difficulty lies opportunity.",
            "Look deep into nature, and then you will understand everything better.",
            "I have no special talents. I am only passionately curious.",
            "The important thing is not to stop questioning. Curiosity has its own reason for existing.",
            "If you can't explain it simply, you don't understand it well enough."
        };

        private int currentQuoteIndex;

        public MainPage()
        {
            InitializeComponent();
            currentQuoteIndex = 0;
            quotationLabel.Text = quotations[currentQuoteIndex];
        }

        void OnRequestNextQuotation(System.Object sender, System.EventArgs e)
        {
            currentQuoteIndex = (currentQuoteIndex + 1) % quotations.Length;
            quotationLabel.Text = quotations[currentQuoteIndex];
        }
    }
}
