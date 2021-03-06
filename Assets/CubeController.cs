using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;
    //消滅位置
    private float deadLine = -10;

    //プレイヤーに触れた
    //private bool isPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーに触れるまでキューブを移動させる
        //if (isPlayer == false)
        //{
            //キューブを移動させる
            transform.Translate(this.speed * Time.deltaTime, 0, 0);
        //}

        //画面外に出たら破棄する
        if(transform.position.x<this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    //2DはCubePrefabのIs Triggerにチェック入れずにvoid OnCollisionEnter2D(Collision2D other)を使う
    //void OnTriggerEnter2D(Collider2D other)を使うとキューブが地面をすり抜ける
    void OnCollisionEnter2D(Collision2D other)
    {
        /*
        //プレイヤーに触れた場合
        if(other.gameObject.tag=="Player")
        {
            isPlayer = true;
        }
        */
        //地面にキューブが接触した場合
        if(other.gameObject.tag=="GroundTag")
        {
            //音を出す
            GetComponent<AudioSource>().Play();
        }

        //キューブ同士が接触した場合
        if(other.gameObject.tag == "CubeTag")
        {
            //音を出す
            GetComponent<AudioSource>().Play();
            //Debug.Log("debug comment" + other.gameObject.tag);
        }
    }

}
