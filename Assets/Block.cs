using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    private Transform[] ch1Places; // 32 adet boþ alanýn Transform'larý
    [SerializeField]
     public static GameObject tas;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;
    private string number="";
    public string type = "";
    public bool isJoker;

    public int no;
    public int tip;

    
    private void Start()
    {
        initialPosition = transform.position;
    }

    private static void Random()
    {

        //i=0 kýrmýzý,i=1 mavi;i=2 siyah, i=3 sarý

        int randomIndex = UnityEngine.Random.Range(0, 4);


    }
    private void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
        }
    }

    private void OnMouseUp()
    {
        if (!locked)
        {
            Transform closestPlace = GetClosestPlace();// En yakýn boþ alaný bul

            if (closestPlace != null && Vector2.Distance(transform.position, closestPlace.position) <= 0.5f)
            {
                transform.position = new Vector2(transform.position.x, closestPlace.position.y);
                type = tas.tag;
                Debug.Log(type);
                //locked = true;// Nesneyi en yakýn boþ alana kilitli hale getir
            }
           
        }
    }

    private Transform GetClosestPlace()
    {
        Transform closestPlace = null;
        float minDistance = float.MaxValue;

        foreach (Transform place in ch1Places)
        {
            float distance = Vector2.Distance(transform.position, place.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                closestPlace = place;
            }
        }

        return closestPlace;
    }
}
