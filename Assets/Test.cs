using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ�����
        int[] array= { 0, 1, 2, 3, 4 };

        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\��
        for (int i = 0; i<array.Length; i++)
        {
            Debug.Log(array [i]);
        }
        //for�����g���A�z��̊e�v�f�̒l���t���ɕ\��
        for (int i = 4; i<array.Length; i--)
        {
            Debug.Log(array[i]);
        }
    }



    // Update is called once per frame
    void Update()
    �@�@{
        
    �@�@}
}
