using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
	//[SerializeField] private PictureShower _pictureShower;
	[SerializeField] private SwitchButton[] _buttonsSwitch;
    public override void InstallBindings()
	{
		BindingLoaderPicture();
		BindingSwitchButtons();
	}

	private void BindingSwitchButtons()
	{
		Container
			.Bind<SwitchButton[]>()
			.FromInstance(_buttonsSwitch)
			.AsSingle();
	}

	private void BindingLoaderPicture()
	{
		Container
			.Bind<ILoaderPictures>()
			.To<LoadPictures>()
			.AsSingle()
			.NonLazy();
	}
}