using UnityEngine;
using Util; 

public class ExitController : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Demonio")) {
			Memory.gc.obixoFugiu();
		}
	}

}
