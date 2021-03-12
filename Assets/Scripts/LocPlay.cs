using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocPlay : MonoBehaviour
{
    public Image marker;
    private float x = 0;
    private float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Finds where the location marker is on Mapbox and puts the UI location marker ontop
        Vector3 pos = this.transform.position;
        x = pos.x;
        y = pos.y;
        marker.transform.position = new Vector2(x,y);
    }
}
