using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DeleteScroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int pointerID = 0;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)))  //버튼을 누름.
        {
            if (EventSystem.current.IsPointerOverGameObject() == false) //캔버스가 선택되었을때 이벤트 시스템이다.
            {
                GameObject[] respawnScroll = GameObject.FindGameObjectsWithTag("CameraScroll");
                foreach (var t in respawnScroll)
                {
                    t.SetActive(false);
                }


/*                GameObject[] respawnBtn = GameObject.FindGameObjectsWithTag("CameraBtn");
                //Debug.Log(respawnBtn);
                foreach (var t in respawnBtn)
                {
                    Debug.Log(t);
                    t.SetActive(true);
                }*/
            }
        }
    }
}
