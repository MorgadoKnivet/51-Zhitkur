using UnityEngine;
using UnityEngine.Video;
using Util;

public class VideoScript : MonoBehaviour {

	VideoPlayer video;

	private void Awake()
	{
		video = GetComponent<VideoPlayer>();

	}	

	private void Update()
	{
		if (video.isPlaying == false) {
			//Memory.ScenaryAnimator.SetTrigger("");
			Destroy(gameObject);
		}
	}

}
