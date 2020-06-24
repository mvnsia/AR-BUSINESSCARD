using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VirtualBtn : MonoBehaviour
{
    public GameObject imagego, githubgo, resumego;
    // Start is called before the first frame update
    void Start()
    {
        imagego.SetActive(false);
        githubgo.SetActive(false);
        resumego.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public OnButtonPressed(VirtualButtonBehaviour vb)
    //{

    //}

    //public OnButtonReleased(VirtualButtonBehaviour vb)
    //{

//    }

}
