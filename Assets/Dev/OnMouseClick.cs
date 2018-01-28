using UnityEngine;
//using Unity

public class OnMouseClick : MonoBehaviour {

	 

	private void OnMouseDown()
	{
		transform.parent.GetComponent<Interagible>().interacao();
	}
}
