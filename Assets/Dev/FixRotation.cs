using UnityEngine;

public class FixRotation : MonoBehaviour {

	private void Update()
	{
		transform.eulerAngles = new Vector3(-transform.parent.eulerAngles.x, 0, 0);
	}
}