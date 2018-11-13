using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour {

    public GameObject flamesParticleEffect;
    private bool flamesActivated = false;

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
        }
        else
        {
            flamesParticleEffect.SetActive(true);
            flamesActivated = true;
        }
    }

    
    public void DracarysAction()
    {
        Debug.Log("Dracarys Action");
        if (flamesActivated)
        {
            flamesParticleEffect.SetActive(false);
            flamesActivated = false;
        }
        else
        {
            flamesParticleEffect.SetActive(true);
            flamesActivated = true;
        }
    }// end of DracarysAction
}
