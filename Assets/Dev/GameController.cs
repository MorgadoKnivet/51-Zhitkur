using UnityEngine;
using Util;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class GameController : MonoBehaviour
{
	public bool gameOver;

	public float SpwTime;
	public List<Transform> spwPoints;

	public Camera gameplayCam;
	public Camera scenarioCam;

	public Transform AreaDeCivis;

	public GameObject Scenario;

	private void Awake()
	{
		Memory.gc = this;
		Memory.ScenaryAnimator = Scenario.GetComponent<Animator>();
		Memory.deadScientists = 0;
		Memory.safeScientists = 0;
		Memory.deadSoldier = false;
		Memory.destroyedBase = false;

		gameOver = false;

	}

	public void obixoFugiu() {
		gameOver = true;

		Memory.ScenaryAnimator.SetTrigger("Death");

	}

	private void Start()
	{
		StartCoroutine(Invasao());
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = scenarioCam.ScreenPointToRay(Input.mousePosition);


			if (Physics.Raycast(ray, out hit))
			{
				//Debug.Log(hit.collider.gameObject.name);


				var localPoint = hit.textureCoord;

				Ray portalRay = gameplayCam.ScreenPointToRay(new Vector2(localPoint.x * gameplayCam.pixelWidth, localPoint.y * gameplayCam.pixelHeight));
				RaycastHit portalHit;

				if (Physics.Raycast(portalRay, out portalHit))
				{
					if(portalHit.collider.transform.parent.GetComponent<Interagible>() != null)
					portalHit.collider.transform.parent.GetComponent<Interagible>().interacao();
				}
			}
		}
	}

	IEnumerator Invasao() {
		yield return new WaitForSeconds(SpwTime);

		int rad = Random.Range(0, spwPoints.Count);

		Instantiate(Memory.SolderInst(), spwPoints[rad].position, Quaternion.identity);

		//StartCoroutine(Invasao());
	}

	public void checkGameover() {
		if (gameOver) {
			SceneManager.LoadScene("GameOver");
		}
	}

	public void freezeIA() {
		foreach (NavMeshAgent nv in FindObjectsOfType<NavMeshAgent>()) {
			nv.enabled = false;
		}
	}

	public void unFreezeIA()
	{
		foreach (NavMeshAgent nv in FindObjectsOfType<NavMeshAgent>())
		{
			nv.enabled = true;
		}

	}
}
