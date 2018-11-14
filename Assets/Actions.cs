using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour {

    public GameObject flamesParticleEffect;
    private bool flamesActivated = false;

    public AudioSource fireAudio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FireAction()
    {
        Debug.Log("Fire Action");
        if (flamesActivated)
        {
            flamesParticleEffect.SetActive(false);
            flamesActivated = false;
            if (fireAudio.isPlaying)
            {
                fireAudio.Stop();
            }
        }
        else
        {
            flamesParticleEffect.SetActive(true);
            flamesActivated = true;
            if (!fireAudio.isPlaying)
            {
                fireAudio.time = 3f;
                fireAudio.Play();
            }
        }
    }

    
}
