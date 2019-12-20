using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPick : MonoBehaviour
{
    public GameObject[] itemToPick;
    // Start is called before the first frame update
    void Start()
    {
        Pick();
    }

    public void Pick()
    {
        int randomIndex = Random.Range(0, itemToPick.Length);
        GameObject clone = Instantiate(itemToPick[randomIndex], transform.position, Quaternion.identity);
    }
    
}
