using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Player : Character
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
        position = new Vector3(0, 0, 0);

        //位置を反映
        this.transform.position = position;
    }

    // Update is called once per frame
    public override void Update()
    {
        Vector3 velocity = Vector3.zero;

        if(Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = 1.0f;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -1.0f;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            velocity.y = 1.0f;
            
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            velocity.y = -1.0f;
        }

        //正規化
        velocity.Normalize();

        //移動処理
        float speed = 1.0f;
        position += velocity * speed;

        //移動範囲の制限
        position.x = Clamp(-10, 10, position.x);
        position.y = Clamp(-4.6f, 6.6f, position.y);

        //Unity側に値を反映
        this.transform.position = position;
    }

    public override void ShutDown()
    {
        
    }

    /// <summary>
    /// float型の範囲制限(全部の型でできるようにした方がいいね)
    /// </summary>
    /// <param name="min">最小値</param>
    /// <param name="max">最大値</param>
    /// <param name="value">設定したい値</param>
    /// <returns>範囲制限がかかった値</returns>
    float Clamp(float min,float max, float value)
    {
        float result = value;

        if(result < min)
        {
            result = min;
        }
        else if(result > max)
        {
            result = max;
        }

        return result;
    }


}
