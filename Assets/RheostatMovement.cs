using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tajurbah_Gah
{
    public class RheostatMovement : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
        }

      
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.Find("Slider").position.x > -0.610)
            {
                gameObject.transform.Find("Slider").transform.Translate(Vector3.left * Time.deltaTime);
            }
            else
            {

            }
            if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.Find("Slider").position.x < 0.001)
            {
                gameObject.transform.Find("Slider").transform.Translate(Vector3.right * Time.deltaTime);
            }
            else
            {

            }
        }

    }
}
