using UnityEngine;

public class AudioByAnimator : MonoBehaviour {

	private AudioSource aS;

	private void Awake()
	{
		aS = GetComponent<AudioSource>();
	}

	private void playAudio() {
		aS.Play();
	}
	private void stopAudio() {
		aS.Stop();
	}
}
