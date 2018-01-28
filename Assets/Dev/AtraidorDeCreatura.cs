using UnityEngine;

public class AtraidorDeCreatura : MonoBehaviour {

	public CientisController CientistaDaArea;
	public Door myDoor;

	private void Start()
	{
		myDoor = transform.parent.GetComponent<Door>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (CientistaDaArea != null && myDoor.aberto)
		{

			//Debug.Log("Ferrou");
			if (other.gameObject.CompareTag("Demonio"))
			{
				other.GetComponent<DemonController>().agent.destination = CientistaDaArea.transform.position;
			}
			else if (other.gameObject.CompareTag("Warrior")) {
				other.GetComponent<SoldierController>().agent.destination = CientistaDaArea.transform.position;
			}
		}
	}
}
