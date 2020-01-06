using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
	public void irAEscena(string _escena)
	{
		StartCoroutine(OpenScene(_escena));
	}

	private IEnumerator OpenScene(string escena)
	{
		float fadeTime = GameObject.Find("Canvas").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		SceneManager.LoadScene(escena);
	}
}
