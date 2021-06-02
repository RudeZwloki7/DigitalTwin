using UnityEngine;

//using Quickstarts.ConsoleReferenceClient;

public class LampObject : MonoBehaviour
{
    public bool _isLit = false;

    public bool IsLit
    {
        get => _isLit;
        private set => _isLit = value;
    }

    public GameObject filament;

    private Material _wolfram;

    // Start is called before the first frame update
    void Start()
    {
        _wolfram = filament.GetComponent<Renderer>().material;
        if (IsLit)
        {
            _wolfram.DisableKeyword("_EMISSION");   
        }
        else
        {
            _wolfram.EnableKeyword("_EMISSION");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _wolfram.EnableKeyword("_EMISSION");
            IsLit = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _wolfram.DisableKeyword("_EMISSION");
            IsLit = false;
        }
    }
}