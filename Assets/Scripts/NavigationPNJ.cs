using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class NavigationPNJ : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private NavMeshAgent agent;

    [SerializeField]
    private InfosJoueur so_infosJoueur;

    [SerializeField]
    private float distanceJoueur;

    [SerializeField]
    private GestionnaireNiveaux gestionnaireNiveaux;

    [SerializeField]
    private TMP_Text champPV; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (Vector3.Distance(agent.transform.position, player.position) < distanceJoueur){
            agent.destination = player.position;
            GetComponent<Animator>().SetBool("Course", true);
        }

        else {
            agent.destination = this.transform.position;
            GetComponent<Animator>().SetBool("Course", false);
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            so_infosJoueur.nbVie -= 1;
            champPV.text = "Points de vie : " + so_infosJoueur.nbVie;
            Debug.Log("Perdu un point");
            GetComponent<Animator>().SetTrigger("Attaque");
            gestionnaireNiveaux.Perdu();
        }
    }
}