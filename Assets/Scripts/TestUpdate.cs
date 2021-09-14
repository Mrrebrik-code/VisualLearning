using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using System;

public class TestUpdate : IInitializable
{
	Settings _settings;
	public void Initialize()
	{
		Debug.Log(_settings.GetTest());
	}

	[Inject]
	public void Init(Settings settings)
	{
		_settings = settings;
	}

	[Serializable]
	public class Settings
	{
		[SerializeField] private string test;
		public string GetTest()
		{
			return test;
		}
	}
}
