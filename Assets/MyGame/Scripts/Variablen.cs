using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}


public class Variablen : MonoBehaviour
{
    public GameObject x;

    public int anzTueren = 4;
    
    public Color farbe;
    
    [SerializeField]
    int anzAutos;
    public bool fahren;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(
            Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " +
            Himmelsrichtungen.West + " " + Himmelsrichtungen.Ost);

        fahren = false;
        anzTueren = 6;
        farbe = Color.black;
        Debug.Log( "black " +    farbe.ToString());

        farbe = Color.white;
        Debug.Log( "white " + farbe.ToString());

        farbe = Color.red;
        Debug.Log( "red " + farbe.ToString());

        Debug.Log(x.ToString());

        Debug.Log(anzAutos.ToString());

        Debug.Log("bool fahren " + fahren.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (farbe == Color.black)
        {
            fahren = true;
        }
        else
        {
            anzTueren = 8;
            fahren = false;
        }
    }
}
