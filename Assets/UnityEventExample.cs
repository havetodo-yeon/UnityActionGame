using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// event(�̺�Ʈ) : ��ü���� �۾� ������ �˸��� ���� ������ �޼���
// �̺�Ʈ�� �ܺ� ������(Subscriber)���� Ư�� ���� �˷��ִ� ����� �����.

// Event Handler(�̺�Ʈ �ڵ鷯) : �����ڰ� �̺�Ʈ�� �߻��� ��� � ����� ������ �� �������ִ� ��
// +=�� ���� �̺�Ʈ�� ���� �߰��� �����ϸ�, -=�� ���� �����ϴ� �͵� �����մϴ�.
// �̺�Ʈ �߻� �� �߰��� �ڵ鷯�� ���������� ȣ��˴ϴ�.

class ClickEvent
{
    public event EventHandler Click;

    public void MouseButtonDown()
    {
        if (Click != null)  // Click�� ���� ��
        {
            Click(this, EventArgs.Empty);   // Click �۾� ����, Empth = ���� �־��� �����Ͱ� ����
            // EventArgs �̺�Ʈ ���� �� �Ķ���ͷ� �����͸� �ް� ���� ��� �ش� Ŭ������ ��ӹ޾� ����մϴ�.
            // EventArgs�� �̺�Ʈ �߻��� ���õ� ������ ������ �ֽ��ϴ�.
            // �̺�Ʈ �ڵ鷯�� ����ϴ� �Ķ���� ���Դϴ�.
        }
    }
}

public class UnityEventExample : MonoBehaviour
{
    ClickEvent clickEvent;
    // Start is called before the first frame update
    void Start()
    {
        clickEvent = new ClickEvent();
        clickEvent.Click += new EventHandler(ButtonClick);
    }
    private void ButtonClick(object sender, EventArgs e)
    {
        Debug.Log("Click Button F");
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            clickEvent.MouseButtonDown();
        }
    }
}
