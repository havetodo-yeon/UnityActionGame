using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample02 : MonoBehaviour
{
    static int coin = 0;
    static int point = 0;
    static int exp = 0;

    public delegate void PlusDelegate(int _coin,  int _point, int _exp);

    static void PlusCoin(int _coin, int _point, int _exp)
    {
        coin += _coin;
        Debug.Log($"Get {_coin}Coin!");
    }

    static void PlusPoint(int _coin, int _point, int _exp)
    {
        point += _point;
        Debug.Log($"Get {_point}Point!");
    }
    
    static void PlusExp(int _coin, int _point, int _exp)
    {
        exp += _exp;
        Debug.Log($"Get {_exp}Exp!");
    }

    private void Start()
    {
        // Get coin 100, point 50, exp 500
/*        PlusCoin(100);
        PlusPoint(50);
        PlusExp(500);*/

        // ��������Ʈ ü��
        // ��������Ʈ���� �Լ��� + �Ǵ� -�� ���� �߰�, ������ �� �ֽ��ϴ�.
        // �߰��� ��� �߰� ������� �Լ� ȣ�� �� ����˴ϴ�.(�Լ� ���� ����)
        // �� ���� ����ó�� �ϹǷ� ȣ���� �Լ� ���� �پ��

        PlusDelegate kill_Unit = PlusCoin;
        kill_Unit += PlusPoint;
        kill_Unit += PlusExp;

        kill_Unit(100, 50, 500);


    }

}
