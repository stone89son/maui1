namespace MauiApp1.Controls;

public partial class CardControl : ContentView
{
    //public BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(CardControl), propertyChanged: (bindable, oldValue, newValue)=> {
    //	var control = (CardControl)bindable;
    //	control.TitleLabel.Text = newValue as string;

    //   });
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(CardControl));
    public CardControl()
	{
		InitializeComponent();
	}
	public string Title {
		get => GetValue(TitleProperty) as string;
		set => SetValue(TitleProperty, value);
	}
}