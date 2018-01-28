using UnityEngine;
using Util;
using UnityEngine.SceneManagement;

public class CientisController : MonoBehaviour {

	int mortos = 0;

	private void Update()
	{
		if (mortos >= 3)
		{
			GameOver();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Demonio"))
		{
			GetComponent<Animator>().SetTrigger("Dead");

			Memory.deadScientists++;

			if (Memory.deadScientists >= 3) {
				Memory.gc.gameOver = true;
			}

			this.enabled = false;

		}
	}

	public void Death() {
		sceneEvents.PlayDeath();
		Instantiate(Memory.Demoniao, transform.position, Quaternion.identity);

		Destroy(gameObject);
	}

	private void GameOver()
	{
		if (Linguagem.linguagem == true)
			SceneManager.LoadScene("GameOver");
		else if (Linguagem.linguagem == false)
			SceneManager.LoadScene("GameOverIngles");
	}
}
