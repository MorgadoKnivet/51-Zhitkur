using UnityEngine;

namespace Util {

	public static class Memory {
		public static GameController gc;
		public static Animator ScenaryAnimator;
		public static DemonController Demoniao;

		public static int deadScientists;
		public static bool deadSoldier;
		public static bool destroyedBase;
		public static int safeScientists; 

		public static GameObject SolderInst() {
			return Resources.Load("Soldier") as GameObject;
		}

		public static GameObject SoundInst()
		{
			return Resources.Load("AudioSource") as GameObject;
		}

		public static GameObject DemonInst()
		{
			return Resources.Load("Demonio") as GameObject;
		}
	}

	public static class sceneEvents{
		public static void PlayDeath() {
			Memory.ScenaryAnimator.SetTrigger("Death");
		}
	}

}
