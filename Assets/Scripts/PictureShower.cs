using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureShower : MonoBehaviour
{
	[SerializeField] private Image _image;

	public void SetPicture(Sprite sprite)
	{
		_image.sprite = sprite;
	}
}
