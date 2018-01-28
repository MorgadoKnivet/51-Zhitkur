using UnityEngine;
using UnityEngine.Video;
using System.Collections;
using Util;

public class VideoScript : MonoBehaviour {

	VideoPlayer mt;

	private void Awake()
	{
		mt = GetComponent<VideoPlayer>();
	}

	private void Start()
	{

	}

}
