using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public string type = "";
    public string number = "";
    public bool isJoker = false;
    public bool Draggable = true;
  
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
            this.transform.position = Vector3.Lerp(this.transform.position, Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(2), Time.deltaTime*0.7f);
        }
        
      
    }

    public void SetBlocksprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
        type = sprite.name.Split('_')[0];
        number = sprite.name.Split('_')[1];
    }
}
