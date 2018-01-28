using UnityEngine;
using Util;
using UnityEngine.SceneManagement;

public class CientisController : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Demonio"))
		{
			GetComponent<Animator>().SetTrigger("Dead");

			Memory.deadScientists++;

			GetComponent<BoxCollider>().enabled = false;

			if (Memory.deadScientists >= 3) {
				Memory.gc.gameOver = true;
			}

			//this.enabled = false;

		}
	}

	public void Death() {
		sceneEvents.PlayDeath();
		Instantiate(Memory.Demoniao, transform.position, Quaternion.identity);

		Destroy(gameObject);
	}

	private void GameOver()
	{
		//if (Linguagem.linguagem == true)
		//	SceneManager.LoadScene("GameOver");
		//else if (Linguagem.linguagem == false)
		//	SceneManager.LoadScene("GameOverIngles");
	}
}
