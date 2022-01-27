using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class camrecontroller : MonoBehaviour

{

    public GameObject player;

    public GameObject altCamera;

    private Vector3 offset = new Vector3(0, 5, -7);

    public int playerIndex;

    // Start is called before the first frame update



    void Start()

    {



    }



    // Update is called once per frame

    void LateUpdate()

    {

        transform.position = player.transform.position + offset;

    }



    private void Update()

    {

        if ((playerIndex == 0 && Input.GetKeyDown(KeyCode.V)) || (playerIndex == 1 && Input.GetKeyDown(KeyCode.B)))

        {

            if (GetComponent<Camera>().isActiveAndEnabled)

            {

                altCamera.SetActive(true);

                GetComponent<Camera>().enabled = false;

            }

            else

            {

                altCamera.SetActive(false);

                GetComponent<Camera>().enabled = true;

            }

        }

    }

}
