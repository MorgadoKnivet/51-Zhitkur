using UnityEngine;
using Util;

public class EmissionAudio : MonoBehaviour {

	private void Start()
	{
		Memory.Demoniao.verifyTargetDistance(transform.position);

		Destroy(gameObject, 3);
	}
}
