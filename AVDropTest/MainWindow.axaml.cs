using Avalonia.Controls;

namespace AVDropTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_DragEnter(object? sender, Avalonia.Input.DragEventArgs e)
        {
        }

        private void Window_DragOver(object? sender, Avalonia.Input.DragEventArgs e)
        {
            e.DragEffects = Avalonia.Input.DragDropEffects.Move;
        }

        private void Window_Drop(object? sender, Avalonia.Input.DragEventArgs e)
        {
        }
    }
}