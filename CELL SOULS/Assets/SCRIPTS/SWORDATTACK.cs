using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWORDATTACK : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    // Start is called before the first frame update
    void Start()
    {
        myAnimationController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      
    {
        if (Input.GetMouseButtonDown(0))
        {
            myAnimationController.SetBool("SWORDATTACK", true);
                print ("attack");

        }
            if (Input.GetMouseButtonUp(0))
            {
                myAnimationController.SetBool("SWORDATTACK", false);
                print("attack");

            }


        } 
    }
}
