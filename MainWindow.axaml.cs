using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Data;

namespace KalkulackaApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button && Display != null)
        {
            Display.Text += button.Content.ToString();
        }
    }
    private void Equal_Click(object? sender, RoutedEventArgs e)
    {
        try
        {
            var result = new DataTable().Compute(Display.Text, null);
            Display.Text = result.ToString();
        }
        catch
        {
            Display.Text = "Error";
        }
    }
    private void Clear_Button(object? sender, RoutedEventArgs e)
    {
        Display.Text = string.Empty;
    }
}