using UnityEngine;
using Util;

public class ScenarioScript : MonoBehaviour {

	public AudioSource dinamico;
	public AudioSource estatico;

	public void checkOver() {
		Memory.gc.checkGameover();
	}

	public void Freeze() {
		Memory.gc.freezeIA();
	}

	public void Unfreeze() {
		Memory.gc.unFreezeIA();
	}

	public void tocarAudio(string dyOes) {
		if (dyOes == "e")
		{
			estatico.Play();
		}
		else {
			dinamico.Play(); ;
		}

	}

	public void pararAudio(string dyOes) {
		if (dyOes == "e")
		{
			estatico.Pause();
		}
		else
		{
			dinamico.Pause(); ;
		}
	}
	
}
