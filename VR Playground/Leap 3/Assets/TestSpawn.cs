using UnityEngine;
using System.Collections;

public class TestSpawn : MonoBehaviour
{
	public GameObject prefab;

	void Start()
	{
		StartCoroutine (Spawn(prefab));
	}

	IEnumerator Spawn(GameObject prefab)
	{
		while(true){					
			Instantiate(prefab, new Vector3( Random.Range(-5.0f, 5.0f), 18.0f, Random.Range(-5.0f, 5.0f)), Quaternion.identity);
			yield return new WaitForSeconds (3.0f);
			//if (offset > 10.0f)
			//	break;
		}
	}
}


		