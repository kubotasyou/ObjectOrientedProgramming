using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class RandomEnemy : Character
{
    private int timer;

    // Start is called before the first frame update
    void Start()
    {
        position = Vector3.zero;

        timer = 60;

        Initialize();
    }

    public override void Initialize()
    {
        position = this.transform.position;
        //初期位置
        position = new Vector3(Random.Range(-10, 10), Random.Range(-4.6f, 6.6f), 0);
        //位置を反映
        this.transform.position = position;

        //時間を2～5秒のランダムにする
        timer = 60 * Random.Range(2, 5);
    }

    // Update is called once per frame
    public override void Update()
    {
        timer--;

        if(timer < 0)
        {
            //位置と時間を初期化
            Initialize();
        }
    }

    public override void ShutDown()
    {

    }
}
