using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    // Use this initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // デバッグ
        Debug.Log("衝突時:" + other.gameObject.tag);

        // 地面とキューブに当たったら音を鳴らす
        if (other.gameObject.tag == "Untagged" || other.gameObject.tag == "CubeTag")
        {
            // 効果音
            GetComponent<AudioSource>().Play();
        }
    }

}
