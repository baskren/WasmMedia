using Windows.Media.Core;

namespace WasmMedia;

public sealed partial class MainPage : Page
{
    static Windows.Media.Playback.MediaPlayer MediaPlayer = new();

    public MainPage()
    {
        this.InitializeComponent();
    }

    private void myButton_Click(object sender, RoutedEventArgs e)
    {
        myButton.Content = "FONT ASSET LOADED";
        myButton.IsEnabled = false;
        tb1.FontFamily = new FontFamily("ms-appx:///Assets/Fonts/PlaywriteAUTAS-VariableFont_wght.ttf#Playwrite AU TAS");
    }

    private void chime1_Click(object sender, RoutedEventArgs e)
    {
        MediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Sounds/Alarm.mp3"));
        MediaPlayer.Play();
    }

}
