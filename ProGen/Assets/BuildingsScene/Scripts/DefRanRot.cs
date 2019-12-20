using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefRanRot : MonoBehaviour
{
   // public static Vector3 straightRot = new Vector3(0,0,0);
   // public static Vector3 rightRot = new Vector3(0,90,0);
   // public static Vector3 fullRot = new Vector3(0,180,0);
   // public static Vector3 leftRot = new Vector3(0,270,0);
    
   // public static Vector3 [] newRot = new Vector3[] {straightRot, rightRot, fullRot, leftRot};
    //public static int randomIndex = Random.Range(0, 4);
   // public static Vector3 randomNewRot = newRot[randomIndex];
    
    static int[] newYRot; //= new int[]{0,90,180,270};
    static int randomIndex; // = Random.Range(0, newYRot.Length);
    private int newRanYrot; // = newYRot[randomIndex];
    
    // Start is called before the first frame update
    void Start()
    {
       newYRot = new int[]{0,90,180,270};
       randomIndex = Random.Range(0, newYRot.Length);
       newRanYrot = newYRot[randomIndex];
        RandomiseRotOnY();
    }

    public void RandomiseRotOnY()
    {

        //transform.rotation = Random.rotation;
        //Quaternion RanYRot = Quaternion.Euler(randomNewRot);
        Quaternion RanYRot = Quaternion.Euler(0,newRanYrot,0);
        transform.rotation = RanYRot;
    }
}

