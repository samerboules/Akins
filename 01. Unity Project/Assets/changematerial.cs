using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changematerial : MonoBehaviour
{
    public Material AngryMaterial;
    public GameObject AtkinsModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AtkinsModel.GetComponent<Renderer>().material = AngryMaterial;
        
    }
}
