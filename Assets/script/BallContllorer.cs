using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;

    //�����̍ŏ��l���w�肷��ϐ���ǉ�
    public float minSpeed = 5f;
    //�����̍ő�l���w��
    public float maxSpeed = 10f;

    Rigidbody myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Rigdbod�ɃA�N�Z�X���ĕϐ��ɕێ����Ă���
        myrigidbody = GetComponent<Rigidbody>();
        //�E�΂�45�x�ɐi��
        myrigidbody.velocity = new Vector3(speed, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //���݂̑������擾
        Vector3 velocity = myrigidbody.velocity;
        //�����̌v�Z
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        //���x��ύX
        myrigidbody.velocity = velocity.normalized * clampedSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //�������A�v���C���[�ɓ��������Ƃ��ɁA���˕Ԃ������ς���
        if (collision.gameObject.CompareTag("player"))
        {
            //�v���C���[�̈ʒu���擾
            Vector3 playerPos = collision.transform.position;

            //�{�[���̈ʒu���擾
            Vector3 ballPos = collision.transform.position;

            //�v���C���[���猩���{�[���̕������v�Z
            Vector3 directio = (ballPos - playerPos).normalized;
            //���݂̑������擾
            float speed = myrigidbody.velocity.magnitude;

            //���x�̕ύX
            myrigidbody.velocity += directio * speed;

        }
    }
}
