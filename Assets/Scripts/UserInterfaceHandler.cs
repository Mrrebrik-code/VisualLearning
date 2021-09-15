using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterfaceHandler : MonoBehaviour
{
	[SerializeField] private SwitchButton[] _switchButton;
	public SwitchButton[] SwitchButton{ get{ return _switchButton; } }
}
