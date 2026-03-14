namespace DyJum;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        ProgressArc.Drawable = new ProgressArcDrawable();
    }
}