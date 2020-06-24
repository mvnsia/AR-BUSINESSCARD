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
        for(int i=0;i<vrb.Length;i++)
        {
            vrb[i].RegisterOnButtonPressed(OnButtonPressed);
            vrb[i].RegisterOnButtonReleased(OnButtonReleased);
        }
        imagego.SetActive(false);
        githubgo.SetActive(false);
        resumego.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName== "ImageVB")
        {
            imagego.SetActive(true);
            githubgo.SetActive(false);
            resumego.SetActive(false);
        }

        else if(vb.VirtualButtonName == "GithubVB")
        {
            imagego.SetActive(false);
            githubgo.SetActive(true);
            resumego.SetActive(false);
        }

        else if(vb.VirtualButtonName == "ResumeVB")
        {
            imagego.SetActive(false);
            githubgo.SetActive(false);
            resumego.SetActive(true);
        }

        else
        {
            throw new UnityException(vb.VirtualButtonName + "virtual button not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log("Virtual button released");
     }

}
