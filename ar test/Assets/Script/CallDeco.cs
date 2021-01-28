using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallDeco : MonoBehaviour
{
    object[] newObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ModelClick()
    {
        GameObject[] respawn = GameObject.FindGameObjectsWithTag("DecoName");
        foreach (var t in respawn)
        {
            Destroy(t);
        }
        string dir = "Decos/" + this.name + "/" + this.name;
        if (Resources.LoadAll<GameObject>(dir).Length != 0)
        {
            GameObject instance = Instantiate(Resources.Load(dir, typeof(GameObject))) as GameObject;
            instance.tag = "DecoName";
        }


    }
}
