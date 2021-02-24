using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Enemy : Character
{

    // Start is called before the first frame update
    void Start()
    {
        position = Vector3.zero;

        Initialize();
    }

    public override void Initialize()
    {
        position = this.transform.position;

        //初期位置
        position = new Vector3(5, 5, 0);

        //位置を反映
        this.transform.position = position;
    }

    // Update is called once per frame
    public override void Update()
    {

    }

    public override void ShutDown()
    {
        
    }
}
