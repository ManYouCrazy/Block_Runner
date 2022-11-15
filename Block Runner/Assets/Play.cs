using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    public PlayerMovment movmentscript;
    public GameObject Image;
    public GameObject Button;

    public void start(int asd){
        if (asd == 1) {
            movmentscript.enabled = true;
            Button.SetActive(false);
            Image.SetActive(false);
        }
    }
}
