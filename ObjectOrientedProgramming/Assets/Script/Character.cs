using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Character : MonoBehaviour
{
    //親子で共通の情報は [protected]
    protected Vector3 position;//位置
    protected bool isDeadFlag; //死亡フラグ

    // Start is called before the first frame update
    void Start()
    {
        position = Vector3.zero;
        isDeadFlag = false;
    }

    //親で内容を決めず、各子どもで定義を具体的にする
    //抽象メソッドは[abstract]

    /// <summary>
    /// 初期化
    /// </summary>
    public abstract void Initialize();

    /// <summary>
    /// 更新
    /// </summary>
    public abstract void Update();

    /// <summary>
    /// 終了
    /// </summary>
    public abstract void ShutDown();

    /// <summary>
    /// 死んでいるか?
    /// </summary>
    /// <returns>死亡フラグ</returns>
    public bool IsDead()
    {
        return isDeadFlag;
    }
}
