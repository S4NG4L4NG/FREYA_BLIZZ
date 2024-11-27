using FREYA_BLIZZ.ViewModel;
namespace FREYA_BLIZZ.View;

public partial class StudentView : ContentPage
{
	public StudentView()
	{
		InitializeComponent();
        BindingContext = new StudentViewModel();
    }
}