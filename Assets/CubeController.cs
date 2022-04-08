using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12;
    //���ňʒu
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        if(transform.position.x<this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //�g���K�[���[�h�ő��̃I�u�W�F�N�g�ƐڐG�����ꍇ�̏���
    //2D��CubePrefab��Is Trigger�Ƀ`�F�b�N���ꂸ��void OnCollisionEnter2D(Collision2D other)���g��
    //void OnTriggerEnter2D(Collider2D other)���g���ƃL���[�u���n�ʂ����蔲����
    void OnCollisionEnter2D(Collision2D other)
    {
        //�n�ʂɃL���[�u���ڐG�����ꍇ
        if(other.gameObject.tag=="GroundTag")
        {
            //�����o��
            GetComponent<AudioSource>().Play();
        }

        //�L���[�u���m���ڐG�����ꍇ
        if(other.gameObject.tag == "CubeTag")
        {
            //�����o��
            GetComponent<AudioSource>().Play();
            Debug.Log("debug comment" + other.gameObject.tag);
        }
    }
}
