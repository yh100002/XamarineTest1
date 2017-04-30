using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuotesExample
{
	public partial class MainPage : ContentPage
	{
        private int _index = 0;
        private List<string> _listText = new List<string>()
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };

		public MainPage()
		{
			InitializeComponent();

            currentQuote.Text = _listText[0];
		}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //var answer = DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            //System.Diagnostics.Debug.WriteLine("Answer: " + answer);

            if (_index == _listText.Count()) _index = 0;

            currentQuote.Text = _listText[_index++];
        }
    }
}
