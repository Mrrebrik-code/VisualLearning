using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
	//[SerializeField] private PictureShower _pictureShower;
	[SerializeField] private SwitchButton[] _buttonsSwitch;
	public Configuration _config;
    public override void InstallBindings()
	{
		BindingLoaderPicture();
		BindingPictureShower();
		Container.
			Bind<SwitchButton[]>().
			FromInstance(_buttonsSwitch).
			AsSingle();
		Container.Bind<IInitializable>().To<TestUpdate>().AsSingle();
		Container.BindInstance(_config._settingsTest);
	}
	private void BindingLoaderPicture()
	{
		Container
			.Bind<ILoaderPictures>()
			.To<LoadPictures>()
			.AsSingle()
			.NonLazy();
	}
	private void BindingPictureShower()
	{
		/*Container
			.BindInstance(typeof(PictureShower)).AsSingle();*/
	}
}