using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 mousePosition;
    
    private void Update()
    {
        float miny = -70;
        float maxy = 70;
        float minx = -150;
        float maxx = 150;

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        if (mousePosition.x < minx)
        {
            transform.position = new Vector2(minx, mousePosition.y);

        }else if (mousePosition.x > maxx)
        {
            transform.position = new Vector2(maxx, mousePosition.y);

        }else if (mousePosition.y > maxy)
        {
            transform.position = new Vector2(mousePosition.x, maxy);
        }
        else if (mousePosition.y < miny)
        {
            transform.position = new Vector2(mousePosition.x, miny);
        }


        if (mousePosition.x > minx && mousePosition.x < maxx && mousePosition.y > miny && mousePosition.y < maxy)
        {
            transform.position = mousePosition;
            

        }else if (transform.position.x <= minx)
        {

            transform.position = new Vector2(minx, mousePosition.y);

        }
        else if (transform.position.x >= maxx)
        {
   
            transform.position = new Vector2 (maxx, mousePosition.y);
        }
        else if (transform.position.y <= miny)
        {

            transform.position = new Vector2(mousePosition.x, miny);

        }
        else if (transform.position.y >= maxy)
        {

            transform.position = new Vector2(mousePosition.x, maxy);

        }
    }
    
}
