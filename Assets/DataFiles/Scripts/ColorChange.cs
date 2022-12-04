using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    [SerializeField]
    private GameObject gObj;
    private Renderer gObjRenderer;
    private Color newGObjColor;
    private float random1,random2,random3;

    // Start is called before the first frame update
    void Start()
    {
        gObjRenderer = gObj.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeObjColor);
    }

    private void ChangeObjColor()
    {
        random1 = Random.Range(0f,1f);
        random2 = Random.Range(0f,1f);
        random3 = Random.Range(0f,1f);

        newGObjColor = new Color(random1,random2,random3,1f);

        gObjRenderer.material.SetColor("_Color",newGObjColor);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
