using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTileYScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        RandomiseScaleOnY();
    }

    public void RandomiseScaleOnY()
    {
        Vector3 randScale = new Vector3(Random.Range(12.5f, 12.5f),
                                        Random.Range(0, 12.5f),
                                        Random.Range(12.5f, 12.5f));
        //float RanYScale = Quaternion.Euler(0,Random.Range(0,360),0);
        transform.localScale = randScale;
    }
}
