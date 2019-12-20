using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;

public class NoOverlap : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    public float rayCastDistance = 100f;
    public float overlapTestBoxSize = 1f;
    public LayerMask spawnObjectLayer;
    
    Vector3 offset = new Vector3(0,.5f,0);
    
    Collider[] colliderInsideOverlapBox = new Collider[1];
    
    // Start is called before the first frame update
    void Start()
    {
        PositionRaycast();
    }
    public void PositionRaycast()
        {
            RaycastHit hit;
            
            if (Physics.Raycast(transform.position, Vector3.down, out hit, rayCastDistance));

            {
                //Debug.Log("i hit");
                Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
                Vector3 overlapTestBoxScale = new Vector3(overlapTestBoxSize, overlapTestBoxSize, overlapTestBoxSize);
                //Collider[] colliderInsideOverlapBox = new Collider[1];
                int numberOfCollidersFound = Physics.OverlapBoxNonAlloc(hit.point, overlapTestBoxScale,
                                                                        colliderInsideOverlapBox, spawnRotation, spawnObjectLayer);
               // Debug.Log("num of colliders found " + numberOfCollidersFound);

                if (numberOfCollidersFound == 0)
                {
                    Pick(hit.point + offset, spawnRotation);
                }
                else
                {
                    Debug.Log("name of collider found " + colliderInsideOverlapBox[0].name);
                }
            }
        }

    public void Pick(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn);
        Debug.Log("spawned building");
    }
}
