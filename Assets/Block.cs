using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public string type = "";
    public string number = "";
    public bool isJoker = false;
    public bool Draggable = true;
    public float smoathDamping=5f;
    SpriteRenderer spriteRenderer;


    private bool _isMoveWithMouse = false;
    //test amaçlý true

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnMouseUp() 
    {
        if (Draggable)
        {
            _isMoveWithMouse = false;
        }
    }
    private void OnMouseDown()
    {
        if (Draggable) 
        {
            _isMoveWithMouse = true;
        }
       
    }
    private void Update()
    {
        if (_isMoveWithMouse)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(5), Time.deltaTime*1.9f);
        }
        
      
    }

    public void SetBlocksprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
        type = sprite.name.Split('_')[0];
        number = sprite.name.Split('_')[1];
    }
}
