using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Util;

public class LossyEnd : MonoBehaviour {

	public List<Image> imagens;

	private void Start()
	{
		for (int i = 4; i >= 0; i--) {
			imagens[i].color = Color.red;
		}
		
	}
}
