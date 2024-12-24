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
        private Point _ghostPosition = new(0, 0);
        private readonly Point _mouseOffset = new(-5, -5);

        public MainWindow()
        {
            InitializeComponent();

            _carousel = new([
                new CardViewModel() {
                    Definition = "Text",
                    Word = "Текст"
                },
                new CardViewModel() {
                    Definition = "Any",
                    Word = "Любой"
                },
                new CardViewModel() {
                    Definition = "Split",
                    Word = "Расколоть"
                }
            ]);

            CardTextBlock.Text = _carousel.First().Word;
            //AddHandler(DragDrop.DragOverEvent, DragOver);
            //GhostItem.IsVisible = false;

            var t = MoveCard();
        }

        private async Task MoveCard()
        {
            while (true) 
            {
                Card.

                

                Card.TranslatePoint()
            }
        }

        private void DragOver(object? sender, DragEventArgs e)
        {
            //var currentPosition = e.GetPosition(MainContainer);

            //var offsetX = currentPosition.X - _ghostPosition.X;
            //var offsetY = currentPosition.Y - _ghostPosition.Y;

            //GhostItem.RenderTransform = new TranslateTransform(offsetX, offsetY);

            //// set drag cursor icon
            //e.DragEffects = DragDropEffects.Move;
            //if (DataContext is not DragAndDropPageViewModel vm) return;
            //var data = e.Data.Get(DragAndDropPageViewModel.CustomFormat);
            //if (data is not TaskItem taskItem) return;
            //if (!vm.IsDestinationValid(taskItem, (e.Source as Control)?.Name))
            //{
            //    e.DragEffects = DragDropEffects.None;
            //}
        }

        private async Task Border_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            //Console.WriteLine("DoDrag start");

            //if (sender is not Border border) return;
            //if (border.DataContext is not TaskItem taskItem) return;

            //var ghostPos = GhostItem.Bounds.Position;
            //_ghostPosition = new Point(ghostPos.X + _mouseOffset.X, ghostPos.Y + _mouseOffset.Y);

            //var mousePos = e.GetPosition(MainContainer);
            //var offsetX = mousePos.X - ghostPos.X;
            //var offsetY = mousePos.Y - ghostPos.Y + _mouseOffset.X;
            //GhostItem.RenderTransform = new TranslateTransform(offsetX, offsetY);

            //if (DataContext is not DragAndDropPageViewModel vm) return;
            //vm.StartDrag(taskItem);

            //GhostItem.IsVisible = true;

            //var dragData = new DataObject();
            //dragData.Set(DragAndDropPageViewModel.CustomFormat, taskItem);
            //var result = await DragDrop.DoDragDrop(e, dragData, DragDropEffects.Move);
            //Console.WriteLine($"DragAndDrop result: {result}");
            //GhostItem.IsVisible = false;
        }
    }
}