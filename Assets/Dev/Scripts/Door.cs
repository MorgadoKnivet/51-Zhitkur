using UnityEngine;
using UnityEngine.EventSystems;
using Util;

public class Door : Interagible {

	public bool aberto;

	private Animator anmr;
	public Door gemea;
	private bool principal;
	public bool StartOpen;

	private bool locked;

	private GameObject visualObj;

	private void Awake()
	{
		anmr = GetComponent<Animator>();
		aberto = StartOpen;
		anmr.SetBool("Abrir", aberto);

		if (gemea != null) {
			principal = true;
		}
	}

	private void Start()
	{
		visualObj = transform.GetChild(0).gameObject;

		if (principal)
		{
			//Debug.Log(!aberto + gameObject.name);
			gemea.gemea = this;
		}
	}

	public void AbrirFechar() {
		if (locked) {
			return;
		}

		aberto = !aberto;

		anmr.SetBool("Abrir", aberto);

		if (gemea != null) {
			gemea.FecharAbrir();
		}

		Instantiate(Memory.SoundInst(), transform.position, Quaternion.identity);
	}

	public void FecharAbrir() {
		aberto = !aberto;

		anmr.SetBool("Abrir", aberto);

		Instantiate(Memory.SoundInst(), transform.position, Quaternion.identity);
	}

	public override void interacao()
	{
		AbrirFechar();
	}

	private void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.CompareTag("Liver") || other.gameObject.CompareTag("Demonio") || other.gameObject.CompareTag("Warrior")) {
			//Debug.Log("Okey");
			lockDoor(true);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Liver") || other.gameObject.CompareTag("Demonio") || other.gameObject.CompareTag("Warrior"))
		{
			lockDoor(false);
		}
	}

	private void lockDoor(bool locker) {
		/*if (aberto) {
			locked = locker;
			gemea.locked = locked;

			if (locked)
			{
				visualObj.GetComponent<MeshRenderer>().material.color = Color.red;
				gemea.visualObj.GetComponent<MeshRenderer>().material.color = Color.red;
			}
			else {
				visualObj.GetComponent<MeshRenderer>().material.color = Color.blue;
				gemea.visualObj.GetComponent<MeshRenderer>().material.color = Color.blue;
			}
		}*/
	}
}
