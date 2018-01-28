using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Util;

public class OverScreen : MonoBehaviour {

	public RectTransform happyEnd;
	public RectTransform badEnd;
	public RectTransform lossyEnd;

	//public Image panel;

	bool prepRestart;

	private void Start()
	{
		if ((Memory.destroyedBase || Memory.deadScientists >= 3) || (Memory.deadSoldier && Memory.safeScientists < 3))
		{
			badEnd.gameObject.SetActive(true);

		}
		else if ((Memory.deadScientists > 0) || (Memory.deadSoldier && Memory.safeScientists >= 3))
		{
			lossyEnd.gameObject.SetActive(true);

		}
		else {
			happyEnd.gameObject.SetActive(true);

		}

		Invoke("ready",1f);
	}

	void ready() {
		prepRestart = true;
	}

	private void Update()
	{
		if (prepRestart) {
			if (Input.GetMouseButtonDown(0)) {
				SceneManager.LoadScene("_MainGame");
			}
		}
	}

}
