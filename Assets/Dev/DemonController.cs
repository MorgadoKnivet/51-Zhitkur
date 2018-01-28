using UnityEngine;
using UnityEngine.AI;
using Util;
using System.Collections.Generic;

public class DemonController : MonoBehaviour {

	public NavMeshAgent agent;

	//public 
	public Transform target;

	public Transform randObj;
	private Transform[] randList;



	private void Awake()
	{
		Memory.Demoniao = this;

		agent = GetComponent<NavMeshAgent>();

		randList = randObj.GetComponentsInChildren<Transform>();
	}

	private void Start()
	{
		agent.destination = target.position;
	}

	public void verifyTargetDistance(Vector3 nTarget)
	{
		if (Vector3.Distance(transform.position, nTarget) < Vector3.Distance(transform.position, target.position))
		{
			agent.destination = nTarget;
		}
	}

	private void Update()
	{
		if (agent.enabled && agent.remainingDistance <= 0) {
			//Debug.Log("chequei");

			target = randList[Random.Range(0, randList.Length)];

			agent.destination = target.position;
		}
	}

}
