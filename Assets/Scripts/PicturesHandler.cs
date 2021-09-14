using UnityEngine;
using System.Linq;
using Zenject;
using System;

public class PicturesHandler : MonoBehaviour
{
	private ILoaderPictures _loader;
	private PictureShower _pictureShower;
	private SwitchButton[] _buttonsSwitch;
	private int _idSelected;
	private void Start()
	{
		_idSelected = default;
	}
	private void OnDestroy()
	{
		_buttonsSwitch.ToList().ForEach(b => b.OnSwitchPicture -= SwitchPicture);
	}
	[Inject]
	public void Init(ILoaderPictures loader, PictureShower pictureShower, SwitchButton[] buttonsSwitch)
	{
		_loader = loader;

		_pictureShower = pictureShower;
		_pictureShower.SetPicture(_loader.GetPictures()[_idSelected].Sprite);

		_buttonsSwitch = buttonsSwitch;
		_buttonsSwitch.ToList().ForEach(b => b.OnSwitchPicture += SwitchPicture);
	}

	private void SwitchPicture(bool vector)
	{
		if(vector)
		{
			_idSelected++;
			if (_idSelected >= _loader.GetPictures().Count) _idSelected = _loader.GetPictures().Count - 1;

			_pictureShower.SetPicture(_loader.GetPictures()[_idSelected].Sprite);
		}
		else
		{
			_idSelected--;
			if (_idSelected < 0) _idSelected = default;

			_pictureShower.SetPicture(_loader.GetPictures()[_idSelected].Sprite);
		}
	}
}
