using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Delegate?
// C C++�� �Լ� �����Ϳ� ����� ����

// ��������Ʈ�� �Լ� Ÿ�Կ� ���� ���Ǹ� �����ϰ�
// �Ű������� ���� ���踦 ������ ���
// ���� Ÿ��, ���� �Ű������� ���� �޼ҵ带
// �ҷ��� ����� �� �ִ� C#�� �����Դϴ�.

public class DelegateExample : MonoBehaviour
{
    // 1. delegate ����
    delegate void DelegateTester();

    // 2. delegate�� ������ ���¿� ������ �Լ��� �����մϴ�.
    void DelegateTest01()
    {
        Debug.Log("Delegate test 01");
    }
    void DelegateTest02()
    {
        Debug.Log("Delegate test 02");
    }

    // 3. delegate ���
    void Start()
    {
        // ��������Ʈ ����
        // ��������Ʈ�� ������ = new ��������Ʈ��(�Լ���);
        DelegateTester delegateTester = new DelegateTester(DelegateTest01);

        // ��������Ʈ ȣ��
        delegateTester();

        delegateTester = DelegateTest02;    // ��������Ʈ�� ó���� �Լ� ����

        delegateTester();

    }

    // ��� ���� ???
    // 
    
}
