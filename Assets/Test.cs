using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //�̗�
    private int power = 25; //�U����
    private int mp = 53; //����



    public void Attack()
    {
        //�U���p�̊֐�
        Debug.Log(this.power + "�̃_���[�W��^����");
    }
    public void Defence(int damage)
    {
        //�h��p�̊֐�
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        //�c��hp�����炷
        this.hp -= damage;
    }
    public void Magic()
    {
        for (int i = 0; i < 11; i++)
        {
            if (this.mp >= 5)
            {
                //mp��5�ȏ�̏ꍇ��5���炵�A�R���\�[���� ���@�U���������B�c��MP�́Z�Z�B �ƕ\��
                this.mp -= 5;
                Debug.Log("���@�U���������B�c��MP��" + this.mp);
            }
            else
            {
                //mp��5�����̏ꍇ�AMP������Ȃ����߁A���@���g���Ȃ��B �ƕ\��
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
        }

    }
}

public class Test : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //�U���p�̊֐����Ăяo��
        lastboss.Attack();
        //�h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        //���@�U���p�̊֐����Ăяo��
        lastboss.Magic();
        
    }




    // Update is called once per frame
    void Update()
    �@�@{
        
    �@�@}
}
