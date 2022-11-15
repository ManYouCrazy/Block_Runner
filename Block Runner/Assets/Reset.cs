using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Transform playerpos;
    public Vector3 origin;
    public PlayerMovment movment;
    public MeshRenderer visible;
    public GameObject button;

    public void reset(int mesage){
        transform.position = origin;
        movment.enabled = true;
        visible.enabled = true;
        button.SetActive(false);
    }
    
}
