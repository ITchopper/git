using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CallModel : MonoBehaviour
{

    object[] newObj;
    Animator animator;
    public Vector3 targetTransform;
    GameObject instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ModelClick()
    {
        GameObject[] respawn = GameObject.FindGameObjectsWithTag("ModelName");
        foreach (var t in respawn)
        {
            Destroy(t);
        }
        string dir = "Models/" + this.name + "/" + this.name;
        string aniDir = "Animations/Walking";
        Vector3 pos;

        if (Resources.LoadAll<GameObject>(dir).Length != 0)
        {
            instance = Instantiate(Resources.Load(dir, typeof(GameObject))) as GameObject;
            instance.tag = "ModelName";
            animator = instance.GetComponent<Animator>();
            Debug.Log(animator);
            instance.GetComponent<Animator>().runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(aniDir);

        }

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))  // 마우스가 클릭 되면
        {
            if (EventSystem.current.IsPointerOverGameObject() == false)
            {
                Debug.Log("Adsf");
                // 마우스로 찍은 위치의 좌표 값을 가져온다
                Vector3 mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                instance.transform.Translate(mouseInput);
            }

        }
    }
}
