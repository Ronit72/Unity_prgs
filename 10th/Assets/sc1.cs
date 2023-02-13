using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc1 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource horn, desc;
    public bool flag;
    void Start()
    {
        flag = false;
    }
    public void honksound()
    {
        horn.Play();
    }
    public void controlfeatures()
    {
        if (!flag)
            desc.Play();
        else
            desc.Pause();
        flag = !flag;
    }
}
