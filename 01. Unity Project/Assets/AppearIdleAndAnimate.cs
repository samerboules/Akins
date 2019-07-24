using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class AppearIdleAndAnimate : MonoBehaviour
{
    public GameObject FaceChangeGO;
    public GameObject JumpingAtkinsGO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JumpingAtkinsGO.GetComponent<Animator>().GetBool("JumpAnimationDone") == false)
        {
            //Do nothing until jump complete
        }else
        {
            //Set the scale of IdleAtkins 
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            //Start the FaceChange playable
            FaceChangeGO.GetComponent<PlayableDirector>().Play();
        }

    }
}
