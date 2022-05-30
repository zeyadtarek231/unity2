using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationtransition : MonoBehaviour
{
    // Start is called before the first frame update
    public AnimationClip close;
    Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }
    private KeyCode[] keyCodes = new KeyCode[] { KeyCode.Alpha0, KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6, KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9 };


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < keyCodes.Length; ++i)
        {
            if (Input.GetKeyDown(keyCodes[0]))
            {
                Debug.Log(i * 3);
                anim.Play();
                this.GetComponent<Animation>().Play("openf");
                break;
            }
            if (Input.GetKeyDown(keyCodes[1]))
            {
                Debug.Log(i * 3);
                anim.Play();
                this.GetComponent<Animation>().Play("closef");
                break;
            }

            if (Input.GetKeyDown(keyCodes[2]))
            {
                Debug.Log(i * 3);
                anim.Play();
                this.GetComponent<Animation>().Play("closeelbow");
                break;
            }

            if (Input.GetKeyDown(keyCodes[3]))
            {
                Debug.Log(i * 3);
                anim.Play();
                this.GetComponent<Animation>().Play("openelbow");
                break;
            }

            if (Input.GetKeyDown(keyCodes[4]))
            {
                Debug.Log(i * 3);
                anim.Play();
                this.GetComponent<Animation>().Play("reflectionin");
                break;
            }

            if (Input.GetKeyDown(keyCodes[5]))
            {
                Debug.Log(i * 3);
                anim.Play();
                this.GetComponent<Animation>().Play("reflitionout");
                break;
            }

            if (Input.GetKeyDown(keyCodes[6]))
            {
                Debug.Log(i * 3);
                anim.Play();
                this.GetComponent<Animation>().Play("rest");
                break;
            }

        }
        /* if (Input.GetKey(KeyCode.W))
         {
             anim.clip = close;
             this.GetComponent<Animation>().Play("closef");
         }
         if (Input.GetKey(KeyCode.A))
         {
             anim.clip = close;
             this.GetComponent<Animation>().Play("openf");
         }
         if (Input.GetKey(KeyCode.S))
         {
             anim.clip = close;
             this.GetComponent<Animation>().Play("closeelbow");
         }*/

    }
}
