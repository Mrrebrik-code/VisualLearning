using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PictureShower : MonoBehaviour
{
	[SerializeField] private Image _image;
	[SerializeField] private float _smoothFade;
	[SerializeField] private bool _switch;

	public void SetPicture(Sprite sprite)
	{

		StartCoroutine(Fader(sprite));

	}
	private IEnumerator Fader(Sprite sprite)
	{
		if (_switch)
		{
			_switch = false;
			_image.DOFade(0f, _smoothFade);
			yield return new WaitForSeconds(_smoothFade);
			_image.sprite = sprite;
			_image.DOFade(1f, _smoothFade);
			yield return new WaitForSeconds(_smoothFade);
			_switch = true;
		}
		
	}
}
