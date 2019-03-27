using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ReticleTest : MonoBehaviour
{
    public float Spinforce;
    void Update(){
        transform.Rotate(0,Spinforce*Time.deltaTime,0);
    }
    public void RandomlyTeleport()
    {
        Debug.Log("reached here");
        gameObject.transform.position = new Vector3(
            GetRandomCoordinate(), Random.Range(0.5f, 2), GetRandomCoordinate());
    }

    public void ChangeSpin(){
        Spinforce-=Spinforce;
    }
    

    private float GetRandomCoordinate()
    {
        var coordinate = Random.Range(-7,7);
        while( coordinate > -1.5 && coordinate < 1.5)
        {
            coordinate = Random.Range(-5,5);
        }
        return coordinate;
    }
}



