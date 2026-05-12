using UnityEngine;
using UnityEngine.Tilemaps;
public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Tilemap MyTilemap;
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cellPicker();
        }
    }
    private void cellPicker()
    {
        Vector3 MousePosition = Input.mousePosition;
        Debug.Log("de positie van de muis is " + MousePosition);

        Vector3 WorldPosition = Camera.main.ScreenToWorldPoint (MousePosition);
        Debug.Log("Worldpositie van de muis is " + WorldPosition);

        Vector3Int CellPosition = MyTilemap.WorldToCell (WorldPosition);
        Debug.Log("Positie van de cell is " + CellPosition);
    }

   
}
