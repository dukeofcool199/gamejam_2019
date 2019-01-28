using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro_dialogue : MonoBehaviour {

		bool start = false;
		public AudioClip maria;
		public AudioClip doThis;

		private AudioSource audioSource;

		// Start is called before the first frame update
		void Start () {
			audioSource = GetComponent<AudioSource> ();
			audioSource.clip = maria;
			audioSource.Play ();

		}

		// Update is called once per frame
		void Update () {
			if (!audioSource.isPlaying && audioSource.clip == maria) {
				audioSource.clip = doThis;
				audioSource.Play (); 
			}

			if (!audioSource.isPlaying && audioSource.clip == doThis) {
				audioSource.clip = null;
			}
			if (audioSource.clip == null) {
				SceneManager.LoadScene(1);
			}

		}
}