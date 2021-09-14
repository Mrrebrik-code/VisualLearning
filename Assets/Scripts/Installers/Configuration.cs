using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;



[CreateAssetMenu(fileName = "picture", menuName = "Pictures/config")]
public class Configuration : ScriptableObject
{
	public TestUpdate.Settings _settingsTest;
}
