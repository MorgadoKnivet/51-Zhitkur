using UnityEngine;
using Util;

public class ScenarioScript : MonoBehaviour {

	public void checkOver() {
		Memory.gc.checkGameover();
	}

	public void Freeze() {
		Memory.gc.freezeIA();
	}

	public void Unfreeze() {
		Memory.gc.unFreezeIA();
	}
		
}
