using UnityEngine;
using Util;

public class EmissionAudio : MonoBehaviour {

	public float scaleFrame;

	private void Start()
	{
		Memory.Demoniao.verifyTargetDistance(transform.position);

		Destroy(gameObject, 0.75f);
	}

	private void Update()
	{
		transform.localScale = transform.localScale + new Vector3(scaleFrame, scaleFrame, scaleFrame);
	}
}
