using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using LearnLangApp.Core;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LearnLangApp.GUI
{
    public partial class MainWindow : Window
    {
        private CardCarousel<CardViewModel> _carousel;

        public MainWindow()
        {
            InitializeComponent();

            _carousel = new CardCarousel<CardViewModel>([
                new CardViewModel() {
                    Definition = "Text",
                    Word = "�����"
                },
                new CardViewModel() {
                    Definition = "Any",
                    Word = "�����"
                },
                new CardViewModel() {
                    Definition = "Split",
                    Word = "���������"
                }
            ]).Shaffle();

            //CardTextBlock.Text = _carousel.First().Word;
        }
    }
}