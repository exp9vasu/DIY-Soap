using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public GameObject Hand1_bomb, Hand2_printer;
    public Animator MoldAnim;

    public GameObject Pan, HandPrintObjCollider, Cam2, obiSolver;


    // Start is called before the first frame update
    void Start()
    {
        Hand1_bomb.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableBombPrint1()
    {
        MoldAnim.SetBool("bombprint1",true);
    }
    public void EnableBombPrint2()
    {
        MoldAnim.SetBool("bombprint2", true);
    }
    public void EnableHandPrint()
    {
        MoldAnim.SetBool("handPrint", true);
    }

    public void BombPlaced()
    {
        Hand2_printer.SetActive(true);
    }

    public void HandPlaced()
    {
        Hand1_bomb.GetComponent<Animator>().SetBool("liftBomb", true);
        HandPrintObjCollider.SetActive(true);
        
    }

    public void StartPouring()
    {
        
        Pan.SetActive(true);
    }

    public void StartObiFluid()
    {
        Cam2.SetActive(true);
        obiSolver.SetActive(true);
    }
}
