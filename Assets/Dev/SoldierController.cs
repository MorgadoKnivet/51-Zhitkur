using UnityEngine;
using UnityEngine.AI;
using Util;

public class SoldierController : MonoBehaviour {

	public NavMeshAgent agent;

	private bool scoltingAgent;

	public Transform target;

	public Material escoltar;

	private Vector3 startPos;

	private void Start() {
		target = Memory.gc.AreaDeCivis.GetChild(Random.Range(0, Memory.gc.AreaDeCivis.childCount));
		startPos = transform.position;

		agent = GetComponent<NavMeshAgent>();

		
		agent.destination = target.position;
	}

	private void OnTriggerEnter(Collider other)
	{
		//Debug.Log(other.gameObject.name);
		if (other.gameObject.CompareTag("Liver"))
		{	
			resgatarCivil(other.gameObject);
		}
		else if (other.gameObject.CompareTag("Finish"))
		{
			if (scoltingAgent)
			{
				Destroy(gameObject);
			}
		}else if (other.gameObject.CompareTag("Demonio"))
		{
			GetComponent<Animator>().SetTrigger("Dead");
		}
	}

	private void OnCollisionEnter(Collision collision)
	{

	}

	private void resgatarCivil(GameObject civil) {
		Destroy(civil);

		transform.GetChild(0).GetComponent<MeshRenderer>().material = escoltar;

		agent.destination = startPos;

		scoltingAgent = true;
	}

	private void death() {
		sceneEvents.PlayDeath();
		Memory.gc.gameOver = true;
		Destroy(gameObject);
	}

}
