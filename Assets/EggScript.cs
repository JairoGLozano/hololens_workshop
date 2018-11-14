using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour {

    SimpleObjectPool parentObjectPool;

	public void SetUp(Vector3 newPosition, SimpleObjectPool parentObjectPool)
    {
        this.parentObjectPool = parentObjectPool;
        gameObject.transform.position = newPosition;
        StartCoroutine(WaitToBeDestroyed());
    }

    IEnumerator WaitToBeDestroyed()
    {
        yield return new WaitForSeconds(15);

        this.parentObjectPool.ReturnObject(gameObject);
    }
}
