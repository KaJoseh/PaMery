using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public float timeout;

	public string sceneName;

	private float time;

    public bool doFade;

    void Update(){
		time += Time.deltaTime;
		if (time >= timeout){
			if(!doFade)
				SceneManager.LoadScene (sceneName);
			else if (doFade)
				StartCoroutine(OpenScene ());
		}
	}

	private IEnumerator OpenScene ( ) {
		float fadeTime = GameObject.Find ("Canvas").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene (sceneName);
	}

}
